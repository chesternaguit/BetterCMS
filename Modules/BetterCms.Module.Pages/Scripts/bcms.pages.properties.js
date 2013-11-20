﻿/*jslint unparam: true, white: true, browser: true, devel: true, vars: true */
/*global bettercms */

bettercms.define('bcms.pages.properties', ['bcms.jquery', 'bcms', 'bcms.modal', 'bcms.forms', 'bcms.dynamicContent', 'bcms.tags', 'bcms.ko.extenders',
        'bcms.media', 'bcms.redirect', 'bcms.options', 'bcms.security', 'bcms.messages', 'bcms.codeEditor'],
    function ($, bcms, modal, forms, dynamicContent, tags, ko, media, redirect, options, security, messages, codeEditor) {
        'use strict';

        var page = {},
            selectors = {
                editPagePropertiesCloseInfoMessageBox: '.bcms-info-message-box',

                editPermalink: '#bcms-pageproperties-editpermalink',
                editPermalinkBox: '.bcms-edit-urlpath-box',
                editPermalinkClose: 'div.bcms-edit-urlpath-box .bcms-tip-close, div.bcms-edit-urlpath-box .bcms-btn-links-small',
                editPermalinkSave: '#bcms-save-permalink',
                permalinkHiddenField: '#bcms-page-permalink',
                permalinkEditField: '#bcms-page-permalink-edit',
                permalinkInfoField: '#bcms-page-permalink-info',

                pagePropertiesTemplateSelect: '.bcms-inner-grid-box',
                pagePropertiesTemplateId: '#TemplateId',
                pagePropertiesMasterPageId: '#MasterPageId',
                pagePropertiesActiveTemplateBox: '.bcms-inner-grid-box-active',
                pagePropertiesTemplatePreviewLink: '.bcms-preview-template',

                pagePropertiesForm: 'form:first',
                pagePropertiesPageIsPublishedCheckbox: '#IsPagePublished',
                pagePropertiesPageIsMasterCheckbox: '#IsMasterPage',

                optionsTab: '#bcms-tab-4'
            },
            links = {
                loadEditPropertiesDialogUrl: null,
                loadLayoutOptionsUrl: null
            },
            globalization = {
                editPagePropertiesModalTitle: null,
                editMasterPagePropertiesModalTitle: null,
                pageStatusChangeConfirmationMessagePublish: null,
                pageStatusChangeConfirmationMessageUnPublish: null,
                pageConversionToMasterConfirmationMessage: null,
                selectedMasterIsChildPage: null
            },
            keys = {
                editPagePropertiesInfoMessageClosed: 'bcms.EditPagePropertiesInfoBoxClosed'
            },
            classes = {
                pagePropertiesActiveTemplateBox: 'bcms-inner-grid-box-active',
                inactive: 'bcms-inactive'
            },
            currentPageIsPublished,
            currentPageIsMaster;

        /**
        * Assign objects to module.
        */
        page.links = links;
        page.globalization = globalization;

        /**
        * Page view model
        */
        function PageViewModel(image, secondaryImage, featuredImage, tagsViewModel, optionListViewModel, accessControlViewModel) {
            var self = this;

            self.tags = tagsViewModel;
            self.options = optionListViewModel;
            self.image = ko.observable(new media.ImageSelectorViewModel(image));
            self.secondaryImage = ko.observable(new media.ImageSelectorViewModel(secondaryImage));
            self.featuredImage = ko.observable(new media.ImageSelectorViewModel(featuredImage));
            self.accessControl = accessControlViewModel;
        }

        /**
        * Initializes EditPageProperties dialog events.
        */
        page.initEditPagePropertiesDialogEvents = function (dialog, content) {
            var optionsContainer = dialog.container.find(selectors.optionsTab),
                optionListViewModel = options.createOptionValuesViewModel(optionsContainer, content.Data.OptionValues, content.Data.CustomOptions),
                tagsViewModel = new tags.TagsListViewModel(content.Data.Tags),
                accessControlViewModel = security.createUserAccessViewModel(content.Data.UserAccessList),
                pageViewModel = new PageViewModel(content.Data.Image, content.Data.SecondaryImage, content.Data.FeaturedImage, tagsViewModel, optionListViewModel, accessControlViewModel),
                form = dialog.container.find(selectors.pagePropertiesForm);

            ko.applyBindings(pageViewModel, form.get(0));

            currentPageIsPublished = dialog.container.find(selectors.pagePropertiesPageIsPublishedCheckbox).is(':checked');
            currentPageIsMaster = dialog.container.find(selectors.pagePropertiesPageIsMasterCheckbox).is(':checked');

            dialog.container.find(selectors.editPermalink).on('click', function () {
                page.showPagePropertiesEditPermalinkBox(dialog);
            });

            dialog.container.find(selectors.editPermalinkClose).on('click', function () {
                page.closePagePropertiesEditPermalinkBox(dialog);
            });

            dialog.container.find(selectors.editPermalinkSave).on('click', function () {
                page.savePagePropertiesEditPermalinkBox(dialog);
            });

            form.on('submit', function () {
                if (!dialog.container.find(selectors.permalinkEditField).valid()) {
                    page.showPagePropertiesEditPermalinkBox(dialog);
                }
            });

            var infoMessageClosed = localStorage.getItem(keys.editPagePropertiesInfoMessageClosed);
            if (infoMessageClosed && infoMessageClosed === '1') {
                page.hideEditPagePropertiesInfoMessage(dialog);
            } else {
                dialog.container.find(selectors.editPagePropertiesCloseInfoMessageBox).on('click', function () {
                    localStorage.setItem(keys.editPagePropertiesInfoMessageClosed, '1');
                    page.hideEditPagePropertiesInfoMessage(dialog);
                });
            }

            dialog.container.find(selectors.pagePropertiesTemplateSelect).on('click', function () {
                page.highlightPagePropertiesActiveTemplate(dialog, this, function (id, isMasterPage) {
                    page.loadLayoutOptions(id, isMasterPage, dialog.container, optionsContainer, optionListViewModel);
                });
            });

            dialog.container.find(selectors.pagePropertiesTemplatePreviewLink).on('click', function () {
                var template = $(this),
                    url = template.data('url'),
                    alt = template.data('alt');

                modal.imagePreview(url, alt);
            });

            bcms.preventInputFromSubmittingForm(dialog.container.find(selectors.permalinkEditField), {
                preventedEnter: function () {
                    dialog.container.find(selectors.permalinkEditField).blur();
                    page.savePagePropertiesEditPermalinkBox(dialog);
                },
                preventedEsc: function () {
                    dialog.container.find(selectors.permalinkEditField).blur();
                    page.closePagePropertiesEditPermalinkBox(dialog);
                }
            });

            codeEditor.initialize(dialog.container);
            
            return pageViewModel;
        };

        /**
        * Loads layout options: when user changes layout, options are reloaded
        */
        page.loadLayoutOptions = function (id, isMasterPage, mainContainer, optionsContainer, optionListViewModel) {
            var onComplete = function (json) {
                var i,
                    j,
                    items = optionListViewModel.items,
                    item,
                    itemExists,
                    itemsToRemove = [],
                    length;

                optionsContainer.hideLoading();
                if (json.Messages && json.Messages.length > 0) {
                    messages.refreshBox(mainContainer, json);
                }
                if (json.Success) {
                    // Remove unchanged items
                    for (i = 0, length = items().length; i < length; i++) {
                        item = items()[i];
                        if (item.useDefaultValue() === true && item.canEditOption() === false) {
                            itemsToRemove.push(item);
                        } else {
                            item.defaultValue('');
                            item.canEditOption(true);
                            item.useDefaultValue(false);
                        }
                    }
                    for (i = 0, length = itemsToRemove.length; i < length; i++) {
                        item = itemsToRemove[i];
                        items.remove(item);
                    }

                    // Add new items
                    for (i = 0, length = json.Data.length; i < length; i++) {
                        itemExists = false;

                        for (j = 0; j < items().length; j++) {
                            item = items()[j];
                            if (item.key() == json.Data[i].OptionKey) {

                                var canEditOption = item.type() != json.Data[i].Type && item.customType() != json.Data[i].CustomType;
                                item.canEditOption(canEditOption);
                                item.changeFieldsEditing();

                                if (!canEditOption) {
                                    item.defaultValue(json.Data[i].OptionDefaultValue);
                                }

                                itemExists = true;
                                break;
                            }
                        }

                        // Do not add option if such already exists
                        if (itemExists) {
                            continue;
                        }

                        item = optionListViewModel.createItem(json.Data[i]);
                        optionListViewModel.items.push(item);
                    }

                    // Set fields editings
                    for (i = 0, length = items().length; i < length; i++) {
                        item = items()[i];
                        item.changeFieldsEditing();
                    }
                }
            };

            optionsContainer.showLoading();

            $.ajax({
                type: 'GET',
                url: $.format(links.loadLayoutOptionsUrl, id, isMasterPage)
            })
            .done(function (result) {
                onComplete(result);
            })
            .fail(function (response) {
                onComplete(bcms.parseFailedResponse(response));
            });
        };

        /**
        * Shows edit permalink box in PageProperties dialog.
        */
        page.showPagePropertiesEditPermalinkBox = function (dialog) {
            dialog.container.find(selectors.editPermalinkBox).show();
            dialog.container.find(selectors.editPermalink).hide();
            dialog.container.find(selectors.permalinkInfoField).hide();
            dialog.container.find(selectors.permalinkEditField).focus();
        };

        /**
        * Sets changed permalink value in PageProperties dialog
        */
        page.savePagePropertiesEditPermalinkBox = function (dialog) {
            if ($(selectors.permalinkEditField).valid()) {
                var value = dialog.container.find(selectors.permalinkEditField).val();
                dialog.container.find(selectors.permalinkHiddenField).val(value);
                dialog.container.find(selectors.permalinkInfoField).html(value || "&nbsp;");

                page.hidePagePropertiesEditPermalinkBox(dialog);
            }
        };

        /*
        * Closes edit permalink box in PageProperties dialog.
        */
        page.closePagePropertiesEditPermalinkBox = function (dialog) {
            var value = dialog.container.find(selectors.permalinkHiddenField).val(),
                permalinkEditField = dialog.container.find(selectors.permalinkEditField);
            permalinkEditField.val(value);
            permalinkEditField.blur();

            page.hidePagePropertiesEditPermalinkBox(dialog);
        };

        /**
        * Hides edit permalink box in PageProperties dialog.
        */
        page.hidePagePropertiesEditPermalinkBox = function (dialog) {
            dialog.container.find(selectors.editPermalinkBox).hide();
            dialog.container.find(selectors.editPermalink).show();
            dialog.container.find(selectors.permalinkInfoField).show();
        };

        /**
        * Hides info message box in EditPageProperties dialog.
        */
        page.hideEditPagePropertiesInfoMessage = function (dialog) {
            dialog.container.find(selectors.editPagePropertiesCloseInfoMessageBox).hide();
        };

        /**
        * highlights active template box in PageProperties dialog.
        */
        page.highlightPagePropertiesActiveTemplate = function (dialog, selectButton, onChangeCallback) {
            var active = dialog.container.find(selectors.pagePropertiesActiveTemplateBox),
                template = $(selectButton),
                id = $(template).data('id'),
                isMasterPage = $(template).data('master'),
                isCircular = $(template).data('iscircular');
            
            if (active.get(0) === template.get(0)) {
                return;
            }

            if (isCircular) {
                var messagesBox = messages.box({ container: dialog.container });
                messagesBox.clearMessages();
                messagesBox.addWarningMessage(globalization.selectedMasterIsChildPage);
            }

            active.removeClass(classes.pagePropertiesActiveTemplateBox);
            if (template) {
                if (isMasterPage) {
                    dialog.container.find(selectors.pagePropertiesMasterPageId).val(id);
                    dialog.container.find(selectors.pagePropertiesTemplateId).val('');
                } else {
                    dialog.container.find(selectors.pagePropertiesTemplateId).val(id);
                    dialog.container.find(selectors.pagePropertiesMasterPageId).val('');
                }
                $(template).addClass(classes.pagePropertiesActiveTemplateBox);

                onChangeCallback.call(this, id, isMasterPage);
            }
        };

        /**
        * Opens modal window for given page with page properties
        */
        page.openEditPageDialog = function (id, postSuccess, title) {
            var pageViewModel,
                canEdit = security.IsAuthorized(["BcmsEditContent"]),
                canEditMaster = security.IsAuthorized(["BcmsAdministration"]),
                canPublish = security.IsAuthorized(["BcmsPublishContent"]);
            
            modal.open({
                title: title || globalization.editPagePropertiesModalTitle,
                disableAccept: !canEdit && !canPublish && !canEditMaster,
                onLoad: function (dialog) {
                    var url = $.format(links.loadEditPropertiesDialogUrl, id);
                    dynamicContent.bindDialog(dialog, url, {
                        contentAvailable: function (childDialog, content) {
                            var form = dialog.container.find('form'),
                                publishCheckbox = form.find(selectors.pagePropertiesPageIsPublishedCheckbox);
                            // User with only BcmsPublishContent but without BcmsEditContent can only publish - only publish checkbox needs to be enabled.
                            if (form.data('readonly') !== true && canPublish && !canEdit && !canEditMaster) {
                                // Disable everything.
                                dialog.container.find('.bcms-tab-single').each(function () {
                                    $(this).addClass(classes.inactive);
                                });
                                publishCheckbox.parents('.bcms-tab-single').find('.bcms-padded-content').each(function () {
                                    $(this).children().each(function () {
                                        $(this).addClass(classes.inactive);
                                    });
                                });
                                form.find('input:visible').attr('readonly', 'readonly');
                                form.find('textarea:visible').attr('readonly', 'readonly');
                                form.find('input[type=text]:visible:not([data-bind])').parent('div').css('z-index', 100);
                                form.find('textarea:visible:not([data-bind])').attr('readonly', 'readonly').parent('div').css('z-index', 100);
                                publishCheckbox.parents('.bcms-input-list-holder').parent().find('.bcms-checkbox-holder').each(function () {
                                    $(this).addClass(classes.inactive);
                                });
                                // Enable only publish checkbox.
                                publishCheckbox.parents('.' + classes.inactive).each(function () {
                                    $(this).removeClass(classes.inactive);
                                });
                                publishCheckbox.removeAttr('readonly');
                            }
                            pageViewModel = page.initEditPagePropertiesDialogEvents(childDialog, content);
                            if (content.Data && content.Data.IsMasterPage === true) {
                                childDialog.setTitle(globalization.editMasterPagePropertiesModalTitle);
                            }
                        },

                        beforePost: function () {
                            if (!dialog.container.find(selectors.permalinkEditField).valid()) {
                                page.showAddNewPageEditPermalinkBox(dialog);
                                return false;
                            }

                            if (!pageViewModel.options.isValid(true)) {
                                return false;
                            }

                            var newPageIsPublished = dialog.container.find(selectors.pagePropertiesPageIsPublishedCheckbox).is(':checked'),
                                message = newPageIsPublished ? globalization.pageStatusChangeConfirmationMessagePublish : globalization.pageStatusChangeConfirmationMessageUnPublish,
                                isMasterPage = dialog.container.find(selectors.pagePropertiesPageIsMasterCheckbox).is(':checked');
                            
                            if (currentPageIsMaster != isMasterPage) {
                                modal.confirm({
                                    content: globalization.pageConversionToMasterConfirmationMessage,
                                    onAccept: function () {
                                        // Skip page publishing confirmation, because making master will force to publish.
                                        if (currentPageIsPublished != newPageIsPublished) {
                                            currentPageIsPublished = newPageIsPublished;
                                        }
                                        currentPageIsMaster = isMasterPage;
                                        dialog.container.find(selectors.pagePropertiesForm).submit();
                                    }
                                });
                                return false;
                            }

                            if (currentPageIsPublished != newPageIsPublished) {
                                modal.confirm({
                                    content: message,
                                    onAccept: function () {
                                        currentPageIsPublished = newPageIsPublished;
                                        dialog.container.find(selectors.pagePropertiesForm).submit();
                                    }
                                });
                                return false;
                            }

                            return true;
                        },

                        postSuccess: postSuccess
                    });
                }
            });
        };

        /**
        * Opens modal window for current page with page properties
        */
        page.editPageProperties = function () {
            page.openEditPageDialog(bcms.pageId, function (data) {
                // Redirect
                if (data.Data && data.Data.PageUrl) {
                    redirect.RedirectWithAlert(data.Data.PageUrl);
                }
            }, globalization.editPagePropertiesModalTitle);
        };
        
        /**
        * Opens modal window for current page with page properties
        */
        page.editMasterPageProperties = function () {
            page.openEditPageDialog(bcms.pageId, function (data) {
                // Redirect
                if (data.Data && data.Data.PageUrl) {
                    redirect.RedirectWithAlert(data.Data.PageUrl);
                }
            }, globalization.editMasterPagePropertiesModalTitle);
        };

        /**
        * Initializes page module.
        */
        page.init = function () {
            bcms.logger.debug('Initializing bcms.pages.properties module.');
        };

        /**
        * Register initialization
        */
        bcms.registerInit(page.init);

        return page;
    });
