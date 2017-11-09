using System;
using System.Collections.Generic;
using System.Text;

namespace UlziUI.Classes.AppLanguages
{
    #region AppLanguage
    public class AppLanguage : BaseData
    {
        public AppLanguage(string displayName)
            : base()
        {
            this.DisplayName = displayName;
        }

        public void Assign(AppLanguage appLanguage)
        {
            if (appLanguage != null)
            {
                this.DisplayName = appLanguage.DisplayName;

                this.AppName = appLanguage.AppName;

                #region Alert Dialog strings
                this.AlertDialogOKAnswerText = appLanguage.AlertDialogOKAnswerText;
                this.AlertDialogYesAnswerText = appLanguage.AlertDialogYesAnswerText;
                this.AlertDialogNoAnswerText = appLanguage.AlertDialogNoAnswerText;
                this.AlertDialogRemoveEmergencyContactTitleText = appLanguage.AlertDialogRemoveEmergencyContactTitleText;
                this.AlertDialogRemoveEmergencyContectMessageText = appLanguage.AlertDialogRemoveEmergencyContectMessageText;
                this.AlertDialogPrimaryEmergencyContactMessageText = appLanguage.AlertDialogPrimaryEmergencyContactMessageText;
                this.AlertDialogPrivateDataAcknowledgmentTitleText = appLanguage.AlertDialogPrivateDataAcknowledgmentTitleText;
                this.AlertDialogPrivateDataAcknowledgmentMessageText = appLanguage.AlertDialogPrivateDataAcknowledgmentMessageText;
                this.AlertDialogPrivateDataAcknowledgmentDeclineAnswerText = appLanguage.AlertDialogPrivateDataAcknowledgmentDeclineAnswerText;
                this.AlertDialogPrivateDataAcknowledgmentAgreeAnswerText = appLanguage.AlertDialogPrivateDataAcknowledgmentAgreeAnswerText;
                this.AlertDialogSendYouNotificationsTitleText = appLanguage.AlertDialogSendYouNotificationsTitleText;
                this.AlertDialogSendYouNotificationsMessageText = appLanguage.AlertDialogSendYouNotificationsMessageText;
                this.AlertDialogSendYouNotificationsDontAllowAnswerText = appLanguage.AlertDialogSendYouNotificationsDontAllowAnswerText;
                this.AlertDialogSendYouNotificationsAllowAnswerText = appLanguage.AlertDialogSendYouNotificationsAllowAnswerText;
                this.AlertDialogSubscriptionTermsTitleText = appLanguage.AlertDialogSubscriptionTermsTitleText;
                this.AlertDialogSubscriptionTermsMessageText = appLanguage.AlertDialogSubscriptionTermsMessageText;
                this.AlertDialogSubscriptionTermsCancelAnswerText = appLanguage.AlertDialogSubscriptionTermsCancelAnswerText;
                this.AlertDialogSubscriptionTermsContinueAnswerText = appLanguage.AlertDialogSubscriptionTermsContinueAnswerText;
                this.AlertDialogConfirmSubscriptionTitleText = appLanguage.AlertDialogConfirmSubscriptionTitleText;
                this.AlertDialogConfirmSubscriptionMessageText = appLanguage.AlertDialogConfirmSubscriptionMessageText;
                this.AlertDialogConfirmSubscriptionCancelAnswerText = appLanguage.AlertDialogConfirmSubscriptionCancelAnswerText;
                this.AlertDialogConfirmSubscriptionOKAnswerText = appLanguage.AlertDialogConfirmSubscriptionOKAnswerText;
                this.AlertDialogCurrentlySubscribedTitleText = appLanguage.AlertDialogCurrentlySubscribedTitleText;
                this.AlertDialogCurrentlySubscribedMessageText = appLanguage.AlertDialogCurrentlySubscribedMessageText;
                this.AlertDialogCurrentlySubscribedManageAnswerText = appLanguage.AlertDialogCurrentlySubscribedManageAnswerText;
                this.AlertDialogCurrentlySubscribedOKAnswerText = appLanguage.AlertDialogCurrentlySubscribedOKAnswerText;
                this.AlertDialogCancelPremiumAccountTitleText = appLanguage.AlertDialogCancelPremiumAccountTitleText;
                this.AlertDialogCancelPremiumAccountMessageText = appLanguage.AlertDialogCancelPremiumAccountMessageText;
                this.AlertDialogCancelPremiumAccountNevermindAnswerText = appLanguage.AlertDialogCancelPremiumAccountNevermindAnswerText;
                this.AlertDialogCancelPremiumAccountYesAnswerText = appLanguage.AlertDialogCancelPremiumAccountYesAnswerText;
                this.AlertDialogAccessMicrophoneTitleText = appLanguage.AlertDialogAccessMicrophoneTitleText;
                this.AlertDialogAccessMicrophoneMessageText = appLanguage.AlertDialogAccessMicrophoneMessageText;
                this.AlertDialogAccessMicrophoneDontAllowAnswerText = appLanguage.AlertDialogAccessMicrophoneDontAllowAnswerText;
                this.AlertDialogAccessMicrophoneOKAnswerText = appLanguage.AlertDialogAccessMicrophoneOKAnswerText;
                this.AlertDialogEmergencyForgotPasswordTitleText = appLanguage.AlertDialogEmergencyForgotPasswordTitleText;
                this.AlertDialogEmergencyForgotPasswordMessageText = appLanguage.AlertDialogEmergencyForgotPasswordMessageText;
                this.AlertDialogEmergencyForgotPasswordOKAnswerText = appLanguage.AlertDialogEmergencyForgotPasswordOKAnswerText;
                this.AlertDialogEmergencyForgotPasswordCancelAnswerText = appLanguage.AlertDialogEmergencyForgotPasswordCancelAnswerText;
                this.AlertDialogNotPremiumMemberTitleText = appLanguage.AlertDialogNotPremiumMemberTitleText;
                this.AlertDialogNotPremiumMemberMessageText = appLanguage.AlertDialogNotPremiumMemberMessageText;
                this.AlertDialogNotPremiumMemberGetPremiumAnswerText = appLanguage.AlertDialogNotPremiumMemberGetPremiumAnswerText;
                this.AlertDialogNotPremiumMemberCancelAnswerText = appLanguage.AlertDialogNotPremiumMemberCancelAnswerText;
                #endregion

                #region Select Photo Action Sheet
                this.SelectPhotoActionSheetTitleText = appLanguage.SelectPhotoActionSheetTitleText;
                this.SelectPhotoActionSheetCancelText = appLanguage.SelectPhotoActionSheetCancelText;
                this.SelectPhotoActionSheetFromCameraText = appLanguage.SelectPhotoActionSheetFromCameraText;
                this.SelectPhotoActionSheetFromGalleryText = appLanguage.SelectPhotoActionSheetFromGalleryText;
                #endregion

                #region Select Blocked People Action Sheet
                this.SelectBlockedPeopleActionSheetTitleText = appLanguage.SelectBlockedPeopleActionSheetTitleText;
                this.SelectBlockedPeopleActionSheetCancelText = appLanguage.SelectBlockedPeopleActionSheetCancelText;
                this.SelectBlockedPeopleActionSheetSelectContactText = appLanguage.SelectBlockedPeopleActionSheetSelectContactText;
                this.SelectBlockedPeopleActionSheetManualInputText = appLanguage.SelectBlockedPeopleActionSheetManualInputText;
                #endregion

                #region Picker titles
                this.SelectGenderPickerTitleText = appLanguage.SelectGenderPickerTitleText;
                this.SelectHeightPickerTitleText = appLanguage.SelectHeightPickerTitleText;
                this.SelectWeightPickerTitleText = appLanguage.SelectWeightPickerTitleText;
                this.SelectHairColorPickerTitleText = appLanguage.SelectHairColorPickerTitleText;
                this.SelectEyeColorPickerTitleText = appLanguage.SelectEyeColorPickerTitleText;
                this.SelectEthnicityPickerTitleText = appLanguage.SelectEthnicityPickerTitleText;
                this.SelectRelationPickerTitleText = appLanguage.SelectRelationPickerTitleText;
                this.SelectBirthDatePickerTitleText = appLanguage.SelectBirthDatePickerTitleText;
                #endregion

                #region Month Selector
                this.MonthSelectorJanuary = appLanguage.MonthSelectorJanuary;
                this.MonthSelectorFebruary = appLanguage.MonthSelectorFebruary;
                this.MonthSelectorMarch = appLanguage.MonthSelectorMarch;
                this.MonthSelectorApril = appLanguage.MonthSelectorApril;
                this.MonthSelectorMay = appLanguage.MonthSelectorMay;
                this.MonthSelectorJune = appLanguage.MonthSelectorJune;
                this.MonthSelectorJuly = appLanguage.MonthSelectorJuly;
                this.MonthSelectorAugust = appLanguage.MonthSelectorAugust;
                this.MonthSelectorSeptember = appLanguage.MonthSelectorSeptember;
                this.MonthSelectorOctober = appLanguage.MonthSelectorOctober;
                this.MonthSelectorNovember = appLanguage.MonthSelectorNovember;
                this.MonthSelectorDecember = appLanguage.MonthSelectorDecember;
                #endregion

                #region Genders strings
                this.GenderNotSelectedText = appLanguage.GenderNotSelectedText;
                this.GenderMaleText = appLanguage.GenderMaleText;
                this.GenderFemaleText = appLanguage.GenderFemaleText;
                #endregion

                #region Hair Color strings
                this.HairColorBald = appLanguage.HairColorBald;
                this.HairColorBlack = appLanguage.HairColorBlack;
                this.HairColorBlonde = appLanguage.HairColorBlonde;
                this.HairColorBlue = appLanguage.HairColorBlue;
                this.HairColorBrown = appLanguage.HairColorBrown;
                this.HairColorGreen = appLanguage.HairColorGreen;
                this.HairColorGray = appLanguage.HairColorGray;
                this.HairColorOrange = appLanguage.HairColorOrange;
                this.HairColorPurple = appLanguage.HairColorPurple;
                this.HairColorPink = appLanguage.HairColorPink;
                this.HairColorRed = appLanguage.HairColorRed;
                this.HairColorSandy = appLanguage.HairColorSandy;
                this.HairColorWhite = appLanguage.HairColorWhite;
                #endregion

                #region Eye Color strings
                this.EyeColorBlack = appLanguage.EyeColorBlack;
                this.EyeColorBlue = appLanguage.EyeColorBlue;
                this.EyeColorBrown = appLanguage.EyeColorBrown;
                this.EyeColorGray = appLanguage.EyeColorGray;
                this.EyeColorGreen = appLanguage.EyeColorGreen;
                this.EyeColorHazel = appLanguage.EyeColorHazel;
                this.EyeColorMaroon = appLanguage.EyeColorMaroon;
                #endregion

                #region Ethnicity Color strings
                this.EthnicityAsian = appLanguage.EthnicityAsian;
                this.EthnicityBlack = appLanguage.EthnicityBlack;
                this.EthnicityHispanic = appLanguage.EthnicityHispanic;
                this.EthnicityIndian = appLanguage.EthnicityIndian;
                this.EthnicityMiddleEastern = appLanguage.EthnicityMiddleEastern;
                this.EthnicityMultiracial = appLanguage.EthnicityMultiracial;
                this.EthnicityWhite = appLanguage.EthnicityWhite;
                #endregion

                #region Relation strings
                this.RelationFather = appLanguage.RelationFather;
                this.RelationMother = appLanguage.RelationMother;
                this.RelationBoyfriend = appLanguage.RelationBoyfriend;
                this.RelationDaughter = appLanguage.RelationDaughter;
                this.RelationFraternityBrother = appLanguage.RelationFraternityBrother;
                this.RelationFriend = appLanguage.RelationFriend;
                this.RelationGirlfriend = appLanguage.RelationGirlfriend;
                this.RelationHusband = appLanguage.RelationHusband;
                this.RelationPartner = appLanguage.RelationPartner;
                this.RelationSibling = appLanguage.RelationSibling;
                this.RelationSon = appLanguage.RelationSon;
                this.RelationSororitySister = appLanguage.RelationSororitySister;
                this.RelationWife = appLanguage.RelationWife;
                this.RelationOther = appLanguage.RelationOther;
                #endregion

                #region Map Directions
                this.MapDirectionsNorth = appLanguage.MapDirectionsNorth;
                this.MapDirectionsNorthEast = appLanguage.MapDirectionsNorthEast;
                this.MapDirectionsEast = appLanguage.MapDirectionsEast;
                this.MapDirectionsSouthEast = appLanguage.MapDirectionsSouthEast;
                this.MapDirectionsSouth = appLanguage.MapDirectionsSouth;
                this.MapDirectionsSouthWest = appLanguage.MapDirectionsSouthWest;
                this.MapDirectionsWest = appLanguage.MapDirectionsWest;
                this.MapDirectionsNorthWest = appLanguage.MapDirectionsNorthWest;
                #endregion

                #region Account Type Info view
                this.AccountTypeInfoViewTopInfoText = appLanguage.AccountTypeInfoViewTopInfoText;
                this.AccountTypeInfoViewFreeLabelText = appLanguage.AccountTypeInfoViewFreeLabelText;
                this.AccountTypeInfoViewSilverLabelText = appLanguage.AccountTypeInfoViewSilverLabelText;
                this.AccountTypeInfoViewGoldLabelText = appLanguage.AccountTypeInfoViewGoldLabelText;
                this.AccountTypeInfoViewBeAHeroLabelText = appLanguage.AccountTypeInfoViewBeAHeroLabelText;
                this.AccountTypeInfoViewBeAHeroDescriptionText = appLanguage.AccountTypeInfoViewBeAHeroDescriptionText;
                this.AccountTypeInfoViewCallPoliceLabelText = appLanguage.AccountTypeInfoViewCallPoliceLabelText;
                this.AccountTypeInfoViewCallPoliceDescriptionText = appLanguage.AccountTypeInfoViewCallPoliceDescriptionText;
                this.AccountTypeInfoViewAlertEmergencyContactsLabelText = appLanguage.AccountTypeInfoViewAlertEmergencyContactsLabelText;
                this.AccountTypeInfoViewAlertEmergencyContactsDescriptionText = appLanguage.AccountTypeInfoViewAlertEmergencyContactsDescriptionText;
                this.AccountTypeInfoViewAlertCommunityRespondersLabelText = appLanguage.AccountTypeInfoViewAlertCommunityRespondersLabelText;
                this.AccountTypeInfoViewAlertCommunityRespondersDescriptionText = appLanguage.AccountTypeInfoViewAlertCommunityRespondersDescriptionText;
                this.AccountTypeInfoViewAudioVideoRecordingLabelText = appLanguage.AccountTypeInfoViewAudioVideoRecordingLabelText;
                this.AccountTypeInfoViewAudioVideoRecordingDescriptionText = appLanguage.AccountTypeInfoViewAudioVideoRecordingDescriptionText;
                this.AccountTypeInfoViewActivateFlashlightLabelText = appLanguage.AccountTypeInfoViewActivateFlashlightLabelText;
                this.AccountTypeInfoViewActivateFlashlightDescriptionText = appLanguage.AccountTypeInfoViewActivateFlashlightDescriptionText;
                this.AccountTypeInfoViewPlanYourRoutesLabelText = appLanguage.AccountTypeInfoViewPlanYourRoutesLabelText;
                this.AccountTypeInfoViewPlanYourRoutesDescriptionText = appLanguage.AccountTypeInfoViewPlanYourRoutesDescriptionText;
                this.AccountTypeInfoViewTurnOnSirenLabelText = appLanguage.AccountTypeInfoViewTurnOnSirenLabelText;
                this.AccountTypeInfoViewTurnOnSirenDescriptionText = appLanguage.AccountTypeInfoViewTurnOnSirenDescriptionText;
                this.AccountTypeInfoViewSendMyLocationToPoliceLabelText = appLanguage.AccountTypeInfoViewSendMyLocationToPoliceLabelText;
                this.AccountTypeInfoViewSendMyLocationToPoliceDescriptionText = appLanguage.AccountTypeInfoViewSendMyLocationToPoliceDescriptionText;
                this.AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText = appLanguage.AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText;
                this.AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText = appLanguage.AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText;
                this.AccountTypeInfoViewTrackFriendsAndFamilyLabelText = appLanguage.AccountTypeInfoViewTrackFriendsAndFamilyLabelText;
                this.AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText = appLanguage.AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText;
                this.AccountTypeInfoViewCustomNotificationSoundsLabelText = appLanguage.AccountTypeInfoViewCustomNotificationSoundsLabelText;
                this.AccountTypeInfoViewCustomNotificationSoundsDescriptionText = appLanguage.AccountTypeInfoViewCustomNotificationSoundsDescriptionText;
                this.AccountTypeInfoViewSetTrackingZonesLabelText = appLanguage.AccountTypeInfoViewSetTrackingZonesLabelText;
                this.AccountTypeInfoViewSetTrackingZonesDescriptionText = appLanguage.AccountTypeInfoViewSetTrackingZonesDescriptionText;
                this.AccountTypeInfoViewSaveVideoToTheCloudLabelText = appLanguage.AccountTypeInfoViewSaveVideoToTheCloudLabelText;
                this.AccountTypeInfoViewSaveVideoToTheCloudDescriptionText = appLanguage.AccountTypeInfoViewSaveVideoToTheCloudDescriptionText;
                this.AccountTypeInfoViewFreeCostLabelText = appLanguage.AccountTypeInfoViewFreeCostLabelText;
                this.AccountTypeInfoViewCostLabelText = appLanguage.AccountTypeInfoViewCostLabelText;
                this.AccountTypeInfoViewBottomInfoText = appLanguage.AccountTypeInfoViewBottomInfoText;
                this.AccountTypeInfoViewBeACommunityResponderLabelText = appLanguage.AccountTypeInfoViewBeACommunityResponderLabelText;
                this.AccountTypeInfoViewBeACommunityResponderDescriptionText = appLanguage.AccountTypeInfoViewBeACommunityResponderDescriptionText;
                this.AccountTypeInfoViewMonthlyPriceLabelText = appLanguage.AccountTypeInfoViewMonthlyPriceLabelText;
                this.AccountTypeInfoViewStudentDiscountLabelText = appLanguage.AccountTypeInfoViewStudentDiscountLabelText;
                this.AccountTypeInfoViewTrySilverLabelText = appLanguage.AccountTypeInfoViewTrySilverLabelText;
                this.AccountTypeInfoViewSetSpeedNotificationLabelText = appLanguage.AccountTypeInfoViewSetSpeedNotificationLabelText;  // CakeSoft fixed bug 21&38
                this.AccountTypeInfoViewCustomMapStylesLabelText = appLanguage.AccountTypeInfoViewCustomMapStylesLabelText;
                this.AccountTypeInfoViewSatelliteViewLabelText = appLanguage.AccountTypeInfoViewSatelliteViewLabelText;
                this.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText = appLanguage.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText;
                this.AccountTypeInfoViewOfflineMapsLabelText = appLanguage.AccountTypeInfoViewOfflineMapsLabelText;
                this.AccountTypeInfoViewOfflineMapsDescriptionText = appLanguage.AccountTypeInfoViewOfflineMapsDescriptionText;
                this.AccountTypeInfoViewSetSpeedNotificationDescriptionText = appLanguage.AccountTypeInfoViewSetSpeedNotificationDescriptionText;
                this.AccountTypeInfoViewCustomMapStylesDescriptionText = appLanguage.AccountTypeInfoViewCustomMapStylesDescriptionText;
                this.AccountTypeInfoViewSatelliteViewDescriptionText = appLanguage.AccountTypeInfoViewSatelliteViewDescriptionText;
                this.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText = appLanguage.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText;
                #endregion

                #region Button Settings Info View
                this.ButtonSettingsInfoFeaturesLabelText = appLanguage.ButtonSettingsInfoFeaturesLabelText;
                this.ButtonSettingsInfoFreeLabelText = appLanguage.ButtonSettingsInfoFreeLabelText;
                this.ButtonSettingsInfoSilverLabelText = appLanguage.ButtonSettingsInfoSilverLabelText;
                this.ButtonSettingsInfoCallPoliceLabelText = appLanguage.ButtonSettingsInfoCallPoliceLabelText;
                this.ButtonSettingsInfoCallPoliceDescriptionText = appLanguage.ButtonSettingsInfoCallPoliceDescriptionText;
                this.ButtonSettingsInfoAlertEmergencyContactsLabelText = appLanguage.ButtonSettingsInfoAlertEmergencyContactsLabelText;
                this.ButtonSettingsInfoAlertEmergencyContactsDescriptionText = appLanguage.ButtonSettingsInfoAlertEmergencyContactsDescriptionText;
                this.ButtonSettingsInfoAlertCommunityRespondersLabelText = appLanguage.ButtonSettingsInfoAlertCommunityRespondersLabelText;
                this.ButtonSettingsInfoAlertCommunityRespondersDescriptionText = appLanguage.ButtonSettingsInfoAlertCommunityRespondersDescriptionText;
                this.ButtonSettingsInfoRecordAudioAndVideoLabelText = appLanguage.ButtonSettingsInfoRecordAudioAndVideoLabelText;
                this.ButtonSettingsInfoRecordAudioAndVideoDescriptionText = appLanguage.ButtonSettingsInfoRecordAudioAndVideoDescriptionText;
                this.ButtonSettingsInfoActivateFlashlightLabelText = appLanguage.ButtonSettingsInfoActivateFlashlightLabelText;
                this.ButtonSettingsInfoActivateFlashlightDescriptionText = appLanguage.ButtonSettingsInfoActivateFlashlightDescriptionText;
                this.ButtonSettingsInfoTurnOnSirenLabelText = appLanguage.ButtonSettingsInfoTurnOnSirenLabelText;
                this.ButtonSettingsInfoTurnOnSirenDescriptionText = appLanguage.ButtonSettingsInfoTurnOnSirenDescriptionText;
                this.ButtonSettingsSendMyLocationToPoliceLabelText = appLanguage.ButtonSettingsSendMyLocationToPoliceLabelText;
                this.ButtonSettingsSendMyLocationToPoliceDescriptionText = appLanguage.ButtonSettingsSendMyLocationToPoliceDescriptionText;
                this.ButtonSettingsPanelSelectorLeftText = appLanguage.ButtonSettingsPanelSelectorLeftText;
                this.ButtonSettingsPanelSelectorRightText = appLanguage.ButtonSettingsPanelSelectorRightText;
                this.ButtonSettingsInfoFreeFeaturesLabelText = appLanguage.ButtonSettingsInfoFreeFeaturesLabelText;
                this.ButtonSettingsInfoSilverFeaturesLabelText = appLanguage.ButtonSettingsInfoSilverFeaturesLabelText;
                this.ButtonSettingsInfoGoldFeaturesLabelText = appLanguage.ButtonSettingsInfoGoldFeaturesLabelText;
                this.ButtonSettingsInfoSaveVideoToCloudLabelText = appLanguage.ButtonSettingsInfoSaveVideoToCloudLabelText;
                this.ButtonSettingsInfoSaveVideoToCloudDescriptionText = appLanguage.ButtonSettingsInfoSaveVideoToCloudDescriptionText;
                #endregion

                #region Main page
                this.MainPageSelectorDoneCommandText = appLanguage.MainPageSelectorDoneCommandText;
                #endregion

                #region Start panel
                this.StartPanelWelcomeText = appLanguage.StartPanelWelcomeText;
                this.StartPanelLogInButtonText = appLanguage.StartPanelLogInButtonText;
                this.StartPanelCreateAccountButtonText = appLanguage.StartPanelCreateAccountButtonText;
                this.StartPanelFacebookLoginButtonText = appLanguage.StartPanelFacebookLoginButtonText;
                #endregion

                #region Login panel
                this.LoginPanelWelcomeText = appLanguage.LoginPanelWelcomeText;
                this.LoginPanelEmailPlaceholderText = appLanguage.LoginPanelEmailPlaceholderText;
                this.LoginPanelPasswordPlaceholderText = appLanguage.LoginPanelPasswordPlaceholderText;
                this.LoginPanelForgotCommandText = appLanguage.LoginPanelForgotCommandText;
                this.LoginPanelSignUpCommandText = appLanguage.LoginPanelSignUpCommandText;
                this.LoginPanelLogInButtonText = appLanguage.LoginPanelLogInButtonText;
                this.LoginPanelErrorText = appLanguage.LoginPanelErrorText;
                #endregion

                #region Passcode Login panel
                this.PasscodeLoginPanelInfoText = appLanguage.PasscodeLoginPanelInfoText;
                this.PasscodeLoginPanelForgotPasscodeCommandText = appLanguage.PasscodeLoginPanelForgotPasscodeCommandText;
                #endregion

                #region Forgor Password panel
                this.ForgotPasswordPanelWelcomeText = appLanguage.ForgotPasswordPanelWelcomeText;
                this.ForgotPasswordPanelTopInfoText = appLanguage.ForgotPasswordPanelTopInfoText;
                this.ForgotPasswordPanelEmailPlaceholderText = appLanguage.ForgotPasswordPanelEmailPlaceholderText;
                this.ForgotPasswordPanelSendAnEmailButtonText = appLanguage.ForgotPasswordPanelSendAnEmailButtonText;
                this.ForgotPasswordPanelErrorText = appLanguage.ForgotPasswordPanelErrorText;
                this.ForgotPasswordPanelBackCommandText = appLanguage.ForgotPasswordPanelBackCommandText;
                #endregion

                #region Terms Of Use panel
                this.TermsOfUsePanelTitleText = appLanguage.TermsOfUsePanelTitleText;
                this.TermsOfUsePanelDeclineCommandText = appLanguage.TermsOfUsePanelDeclineCommandText;
                this.TermsOfUsePanelAcceptCommandText = appLanguage.TermsOfUsePanelAcceptCommandText;
                this.TermsOfUsePanelTextTitle = appLanguage.TermsOfUsePanelTextTitle;
                this.TermsOfUsePanelTextContentLine_1 = appLanguage.TermsOfUsePanelTextContentLine_1;
                this.TermsOfUsePanelTextContentLine_2 = appLanguage.TermsOfUsePanelTextContentLine_2;
                this.TermsOfUsePanelTextContentLine_3 = appLanguage.TermsOfUsePanelTextContentLine_3;
                this.TermsOfUsePanelTextContentLine_4 = appLanguage.TermsOfUsePanelTextContentLine_4;
                this.TermsOfUsePanelTextContentLine_5 = appLanguage.TermsOfUsePanelTextContentLine_5;  //CakeSoft fixed bug SB-17
                this.TermsOfUsePanelTextContentLine_6 = appLanguage.TermsOfUsePanelTextContentLine_6;
                this.TermsOfUsePanelTextContentLine_7 = appLanguage.TermsOfUsePanelTextContentLine_7;
                this.TermsOfUsePanelTextContentLine_8 = appLanguage.TermsOfUsePanelTextContentLine_8;
                this.TermsOfUsePanelTextContentLine_9 = appLanguage.TermsOfUsePanelTextContentLine_9;
                this.TermsOfUsePanelTextContentLine_10 = appLanguage.TermsOfUsePanelTextContentLine_10;
                this.TermsOfUsePanelTextContentLine_11 = appLanguage.TermsOfUsePanelTextContentLine_11;
                this.TermsOfUsePanelTextContentLine_12 = appLanguage.TermsOfUsePanelTextContentLine_12;
                this.TermsOfUsePanelTextContentLine_13 = appLanguage.TermsOfUsePanelTextContentLine_13;
                this.TermsOfUsePanelTextContentLine_14 = appLanguage.TermsOfUsePanelTextContentLine_14;
                this.TermsOfUsePanelTextContentLine_15 = appLanguage.TermsOfUsePanelTextContentLine_15;
                this.TermsOfUsePanelTextContentLine_16 = appLanguage.TermsOfUsePanelTextContentLine_16;
                this.TermsOfUsePanelTextContentLine_17 = appLanguage.TermsOfUsePanelTextContentLine_17;
                this.TermsOfUsePanelTextContentLine_18 = appLanguage.TermsOfUsePanelTextContentLine_18;
                this.TermsOfUsePanelTextContentLine_19 = appLanguage.TermsOfUsePanelTextContentLine_19;
                this.TermsOfUsePanelTextContentLine_20 = appLanguage.TermsOfUsePanelTextContentLine_20;
                this.TermsOfUsePanelTextContentLine_21 = appLanguage.TermsOfUsePanelTextContentLine_21;
                this.TermsOfUsePanelTextContentLine_22 = appLanguage.TermsOfUsePanelTextContentLine_22;
                this.TermsOfUsePanelTextContentLine_23 = appLanguage.TermsOfUsePanelTextContentLine_23;
                this.TermsOfUsePanelTextContentLine_24 = appLanguage.TermsOfUsePanelTextContentLine_24;
                this.TermsOfUsePanelTextContentLine_25 = appLanguage.TermsOfUsePanelTextContentLine_25;
                this.TermsOfUsePanelTextContentLine_26 = appLanguage.TermsOfUsePanelTextContentLine_26;
                this.TermsOfUsePanelTextContentLine_27 = appLanguage.TermsOfUsePanelTextContentLine_27;
                this.TermsOfUsePanelTextContentLine_28 = appLanguage.TermsOfUsePanelTextContentLine_28;
                this.TermsOfUsePanelTextContentLine_29 = appLanguage.TermsOfUsePanelTextContentLine_29;
                this.TermsOfUsePanelTextContentLine_30 = appLanguage.TermsOfUsePanelTextContentLine_30;
                this.TermsOfUsePanelTextContentLine_31 = appLanguage.TermsOfUsePanelTextContentLine_31;
                this.TermsOfUsePanelTextContentLine_32 = appLanguage.TermsOfUsePanelTextContentLine_32;
                this.TermsOfUsePanelTextContentLine_33 = appLanguage.TermsOfUsePanelTextContentLine_33;
                this.TermsOfUsePanelTextContentLine_34 = appLanguage.TermsOfUsePanelTextContentLine_34;
                this.TermsOfUsePanelTextContentLine_35 = appLanguage.TermsOfUsePanelTextContentLine_35;
                this.TermsOfUsePanelTextContentLine_36 = appLanguage.TermsOfUsePanelTextContentLine_36;
                this.TermsOfUsePanelTextContentLine_37 = appLanguage.TermsOfUsePanelTextContentLine_37;
                this.TermsOfUsePanelTextContentLine_38 = appLanguage.TermsOfUsePanelTextContentLine_38;
                this.TermsOfUsePanelTextContentLine_39 = appLanguage.TermsOfUsePanelTextContentLine_39;
                this.TermsOfUsePanelTextContentLine_40 = appLanguage.TermsOfUsePanelTextContentLine_40;
                this.TermsOfUsePanelTextContentLine_41 = appLanguage.TermsOfUsePanelTextContentLine_41;
                this.TermsOfUsePanelTextContentLine_42 = appLanguage.TermsOfUsePanelTextContentLine_42;
                this.TermsOfUsePanelTextContentLine_43 = appLanguage.TermsOfUsePanelTextContentLine_43;
                this.TermsOfUsePanelTextContentLine_44 = appLanguage.TermsOfUsePanelTextContentLine_44;
                this.TermsOfUsePanelTextContentLine_45 = appLanguage.TermsOfUsePanelTextContentLine_45;
                this.TermsOfUsePanelTextContentLine_46 = appLanguage.TermsOfUsePanelTextContentLine_46;
                this.TermsOfUsePanelTextContentLine_47 = appLanguage.TermsOfUsePanelTextContentLine_47;
                this.TermsOfUsePanelTextContentLine_48 = appLanguage.TermsOfUsePanelTextContentLine_48;
                this.TermsOfUsePanelTextContentLine_49 = appLanguage.TermsOfUsePanelTextContentLine_49;
                this.TermsOfUsePanelTextContentLine_50 = appLanguage.TermsOfUsePanelTextContentLine_50;
                this.TermsOfUsePanelTextContentLine_51 = appLanguage.TermsOfUsePanelTextContentLine_51;
                this.TermsOfUsePanelTextContentLine_52 = appLanguage.TermsOfUsePanelTextContentLine_52;
                this.TermsOfUsePanelTextContentLine_53 = appLanguage.TermsOfUsePanelTextContentLine_53;
                this.TermsOfUsePanelTextContentLine_54 = appLanguage.TermsOfUsePanelTextContentLine_54;
                this.TermsOfUsePanelTextContentLine_55 = appLanguage.TermsOfUsePanelTextContentLine_55;
                this.TermsOfUsePanelTextContentLine_56 = appLanguage.TermsOfUsePanelTextContentLine_56;
                this.TermsOfUsePanelTextContentLine_57 = appLanguage.TermsOfUsePanelTextContentLine_57;
                this.TermsOfUsePanelTextContentLine_58 = appLanguage.TermsOfUsePanelTextContentLine_58;
                this.TermsOfUsePanelTextContentLine_59 = appLanguage.TermsOfUsePanelTextContentLine_59;
                this.TermsOfUsePanelTextContentLine_60 = appLanguage.TermsOfUsePanelTextContentLine_60;
                this.TermsOfUsePanelTextContentLine_61 = appLanguage.TermsOfUsePanelTextContentLine_61;
                this.TermsOfUsePanelTextContentLine_62 = appLanguage.TermsOfUsePanelTextContentLine_62;
                this.TermsOfUsePanelIHaveReadCheckedText = appLanguage.TermsOfUsePanelIHaveReadCheckedText;
                #endregion

                #region Create Account Phone panel
                this.CraeteAccountPhonePanelTitleText = appLanguage.CraeteAccountPhonePanelTitleText;
                this.CreateAccountPhonePanelCancelCommandText = appLanguage.CreateAccountPhonePanelCancelCommandText;
                this.CreateAccountPhonePanelNextCommandText = appLanguage.CreateAccountPhonePanelNextCommandText;
                this.CreateAccountPhonePanelPhoneLabelText = appLanguage.CreateAccountPhonePanelPhoneLabelText;
                #endregion

                #region Create Account panel
                this.CreateAccountPanelTitleText = appLanguage.CreateAccountPanelTitleText;
                this.CreateAccountPanelCancelCommandText = appLanguage.CreateAccountPanelCancelCommandText;
                this.CreateAccountPanelNextCommandText = appLanguage.CreateAccountPanelNextCommandText;
                this.CreateAccountPanelFirstNameLabelText = appLanguage.CreateAccountPanelFirstNameLabelText;
                this.CreateAccountPanelLastNameLabelText = appLanguage.CreateAccountPanelLastNameLabelText;
                this.CreateAccountPanelGenderLabelText = appLanguage.CreateAccountPanelGenderLabelText;
                this.CreateAccountPanelBirthDayLabelText = appLanguage.CreateAccountPanelBirthDayLabelText;
                this.CreateAccountPanelPhoneNumberLabelText = appLanguage.CreateAccountPanelPhoneNumberLabelText;
                this.CreateAccountPanelEmailLabelText = appLanguage.CreateAccountPanelEmailLabelText;
                this.CreateAccountPanelReEnterEmailLabelText = appLanguage.CreateAccountPanelReEnterEmailLabelText;
                this.CreateAccountPanelPasswordLabelText = appLanguage.CreateAccountPanelPasswordLabelText;
                this.CreateAccountPanelReEnterPasswordLabelText = appLanguage.CreateAccountPanelReEnterPasswordLabelText;
                #endregion

                #region Phone Verification panel
                this.PhoneVerificationPanelTitleText = appLanguage.PhoneVerificationPanelTitleText;
                this.PhoneVerificationPanelBackCommandText = appLanguage.PhoneVerificationPanelBackCommandText;
                this.PhoneVerificationPanelSaveCommandText = appLanguage.PhoneVerificationPanelSaveCommandText;
                this.PhoneVerificationPanelTopInfoText = appLanguage.PhoneVerificationPanelTopInfoText;
                this.PhoneVerificationPanelCodeLabelText = appLanguage.PhoneVerificationPanelCodeLabelText;
                #endregion

                #region Detailed Info page
                this.DetailedInfoPanelTitleText = appLanguage.DetailedInfoPanelTitleText;
                this.DetailedInfoPanelBackCommandText = appLanguage.DetailedInfoPanelBackCommandText;
                this.DetailedInfoPanelNextCommandText = appLanguage.DetailedInfoPanelNextCommandText;
                this.DetailedInfoPanelTopInfoText = appLanguage.DetailedInfoPanelTopInfoText;
                this.DetailedInfoPanelHeightLabelText = appLanguage.DetailedInfoPanelHeightLabelText;
                this.DetailedInfoPanelWeightLabelText = appLanguage.DetailedInfoPanelWeightLabelText;
                this.DetailedInfoPanelHairColorLabelText = appLanguage.DetailedInfoPanelHairColorLabelText;
                this.DetailedInfoPanelEyeColorLabelText = appLanguage.DetailedInfoPanelEyeColorLabelText;
                this.DetailedInfoPanelEthnicityLabelText = appLanguage.DetailedInfoPanelEthnicityLabelText;
                this.DetailedInfoPanelStreetLabelText = appLanguage.DetailedInfoPanelStreetLabelText;
                this.DetailedInfoPanelCityLabelText = appLanguage.DetailedInfoPanelCityLabelText;
                this.DetailedInfoPanelStateLabelText = appLanguage.DetailedInfoPanelStateLabelText;
                this.DetailedInfoPanelZipCodeLabelText = appLanguage.DetailedInfoPanelZipCodeLabelText;
                this.DetailedInfoPanelMediasLabelText = appLanguage.DetailedInfoPanelMediasLabelText;
                this.DetailedInfoPanelAllergiesLabelText = appLanguage.DetailedInfoPanelAllergiesLabelText;
                this.DetailedInfoPanelMedicationsLabelText = appLanguage.DetailedInfoPanelMedicationsLabelText;
                this.DetailedInfoPanelHomeAddressLabelText = appLanguage.DetailedInfoPanelHomeAddressLabelText;
                this.DetailedInfoPanelMedicalConditionsLabelText = appLanguage.DetailedInfoPanelMedicalConditionsLabelText;
                #endregion

                #region Passcode page
                this.PasscodePanelTitleText = appLanguage.PasscodePanelTitleText;
                this.PasscodePanelBackCommandText = appLanguage.PasscodePanelBackCommandText;
                this.PasscodePanelSaveCommandText = appLanguage.PasscodePanelSaveCommandText;
                this.PasscodePanelTopInfoText = appLanguage.PasscodePanelTopInfoText;
                this.PasscodePanelPasscodeLabelText = appLanguage.PasscodePanelPasscodeLabelText;
                this.PasscodePanelPasscodeConfirmLabelText = appLanguage.PasscodePanelPasscodeConfirmLabelText;
                #endregion

                #region Account Type panel
                this.AccountTypePanelTitleText = appLanguage.AccountTypePanelTitleText;
                this.AccountTypePanelBackCommandText = appLanguage.AccountTypePanelBackCommandText;
                this.AccountTypePanelSilverButtonText = appLanguage.AccountTypePanelSilverButtonText;
                this.AccountTypePanelGoldButtonText = appLanguage.AccountTypePanelGoldButtonText;
                this.AccountTypePanelFreeButtonText = appLanguage.AccountTypePanelFreeButtonText;
                this.AccountTypePanelCancelPremiumAccountButtonText = appLanguage.AccountTypePanelCancelPremiumAccountButtonText;
                this.AccountTypePanelGiftTheAppCommandText = appLanguage.AccountTypePanelGiftTheAppCommandText;
                #endregion

                #region Add Emergency Contract panel
                this.AddEmergencyContactsPanelTitleLabel = appLanguage.AddEmergencyContactsPanelTitleLabel;
                this.AddEmergencyContactsPanelBackCommandText = appLanguage.AddEmergencyContactsPanelBackCommandText;
                this.AddEmergencyContactsPanelSkipCommandText = appLanguage.AddEmergencyContactsPanelSkipCommandText;
                this.AddEmergencyContactsPanelNextCommandText = appLanguage.AddEmergencyContactsPanelNextCommandText;
                this.AddEmergencyContactsPanelTopInfoText = appLanguage.AddEmergencyContactsPanelTopInfoText;
                this.AddEmergencyContactsPanelEmptyListText = appLanguage.AddEmergencyContactsPanelEmptyListText;
                this.AddEmergencyContactsPanelAddEmergencyContractButtonText = appLanguage.AddEmergencyContactsPanelAddEmergencyContractButtonText;
                this.AddEmergencyContactsPanelUnlockPremiumButtonText = appLanguage.AddEmergencyContactsPanelUnlockPremiumButtonText;
                this.AddEmergencyContactsPanelLimitLabelText = appLanguage.AddEmergencyContactsPanelLimitLabelText;
                this.AddEmergencyContactsPanelPauseAllLabelText = appLanguage.AddEmergencyContactsPanelPauseAllLabelText;
                this.AddEmergencyContactsPanelSearchPlaceholderText = appLanguage.AddEmergencyContactsPanelSearchPlaceholderText;
                this.AddEmergencyContactsPanelTrackThemLabelText = appLanguage.AddEmergencyContactsPanelTrackThemLabelText;
                this.AddEmergencyContactsPanelTrackMeLabelText = appLanguage.AddEmergencyContactsPanelTrackMeLabelText;
                this.AddEmergencyContactsPanelYellowAlertLabelText = appLanguage.AddEmergencyContactsPanelYellowAlertLabelText;
                this.AddEmergencyContactsPanelRedAlertLabelText = appLanguage.AddEmergencyContactsPanelRedAlertLabelText;
                this.AddEmergencyContactsPanelExpanderPauseInfoText = appLanguage.AddEmergencyContactsPanelExpanderPauseInfoText;
                this.AddEmergencyContactsPanelRelationShipLabelText = appLanguage.AddEmergencyContactsPanelRelationShipLabelText;
                this.AddEmergencyContactsPanelReponseButtonText = appLanguage.AddEmergencyContactsPanelReponseButtonText;
                this.AddEmergencyContactsPanelRemoveContactCommandText = appLanguage.AddEmergencyContactsPanelRemoveContactCommandText;
                this.AddEmergencyRelationshipPickerTitleText = appLanguage.AddEmergencyRelationshipPickerTitleText;
                #endregion

                #region Select Emergency Contracts panel
                this.SelectEmergencyContactsPanelTitleLabel = appLanguage.SelectEmergencyContactsPanelTitleLabel;
                this.SelectEmergencyContactsPanelBackCommandText = appLanguage.SelectEmergencyContactsPanelBackCommandText;
                this.SelectEmergencyContactsPanelSearchPlaceholderText = appLanguage.SelectEmergencyContactsPanelSearchPlaceholderText;
                this.SelectEmergencyContactsPanelAddToEmergencyContactsCommandText = appLanguage.SelectEmergencyContactsPanelAddToEmergencyContactsCommandText;
                this.SelectEmergencyContactsPanelRequestLocationSharingCommandText = appLanguage.SelectEmergencyContactsPanelRequestLocationSharingCommandText;
                this.SelectEmergencyContactsPanelAddingEmergencyContact = appLanguage.SelectEmergencyContactsPanelAddingEmergencyContact; //CakeSoft fixed bug SB-54
                this.SelectEmergencyContactsPanelAddingMonitoredContact = appLanguage.SelectEmergencyContactsPanelAddingMonitoredContact;
                #endregion

                #region Button Settings panel
                this.ButtonSettingsPanelEmergencyButtonText = appLanguage.ButtonSettingsPanelEmergencyButtonText;
                this.ButtonSettingsPanelBadSituationButtonText = appLanguage.ButtonSettingsPanelBadSituationButtonText;
                this.ButtonSettingsPanelTitleText = appLanguage.ButtonSettingsPanelTitleText;
                this.ButtonSettingsPanelBackCommandText = appLanguage.ButtonSettingsPanelBackCommandText;
                this.ButtonSettingsPanelNextCommandText = appLanguage.ButtonSettingsPanelNextCommandText;
                this.ButtonSettingsPanelSkipButtonText = appLanguage.ButtonSettingsPanelSkipButtonText;
                this.ButtonSettingsPanelTopInfoText = appLanguage.ButtonSettingsPanelTopInfoText;
                this.ButtonSettingsPanelTopInfoBSText = appLanguage.ButtonSettingsPanelTopInfoBSText;
                this.ButtonSettingsPanelMiddleInfoText = appLanguage.ButtonSettingsPanelMiddleInfoText;
                this.ButtonSettingsPanelMiddleInfoBSText = appLanguage.ButtonSettingsPanelMiddleInfoBSText;
                this.ButtonSettingsPanelFirstInfoText = appLanguage.ButtonSettingsPanelFirstInfoText;
                this.ButtonSettingsPanelSecondInfoText = appLanguage.ButtonSettingsPanelSecondInfoText;
                this.ButtonSettingsPanelBottomInfoText = appLanguage.ButtonSettingsPanelBottomInfoText;
                this.ButtonSettingsPanelCheckOutPremiumButtonText = appLanguage.ButtonSettingsPanelCheckOutPremiumButtonText;
                this.ButtonSettingsPanelRedAlertTopInfoText = appLanguage.ButtonSettingsPanelRedAlertTopInfoText;
                #endregion

                #region What Happend panel
                this.WhatHappendPanelTopInfoText = appLanguage.WhatHappendPanelTopInfoText;
                this.WhatHappendPanelFalseAlarmCommandText = appLanguage.WhatHappendPanelFalseAlarmCommandText;
                this.WhatHappendPanelNothingJustBeingCautiousCommandText = appLanguage.WhatHappendPanelNothingJustBeingCautiousCommandText;
                this.WhatHappendPanelIWasInABadSituationCommandText = appLanguage.WhatHappendPanelIWasInABadSituationCommandText;
                this.WhatHappendPanelIWasAssaultedCommandText = appLanguage.WhatHappendPanelIWasAssaultedCommandText;
                this.WhatHappendPanelCloseButtonText = appLanguage.WhatHappendPanelCloseButtonText;
                #endregion

                #region What Happened Popup panel
                this.WhatHappenedPopupPanelTitleText = appLanguage.WhatHappenedPopupPanelTitleText;
                this.WhatHappenedPopupPanelFalseAlarmText = appLanguage.WhatHappenedPopupPanelFalseAlarmText;
                this.WhatHappenedPopupNothingJustBeingCautiousText = appLanguage.WhatHappenedPopupNothingJustBeingCautiousText;
                this.WhatHappenedPopupPanelIWasInABadSituationText = appLanguage.WhatHappenedPopupPanelIWasInABadSituationText;
                this.WhatHappenedPopupPanelIWasAssaultedText = appLanguage.WhatHappenedPopupPanelIWasAssaultedText;
                this.WhatHappenedPopupPanelOtherText = appLanguage.WhatHappenedPopupPanelOtherText;
                #endregion

                #region Incident Ended Popup panel
                this.IncidentEndedPopupPanelTitleText = appLanguage.IncidentEndedPopupPanelTitleText;
                this.IncidentEndedPopupPanelOtherText = appLanguage.IncidentEndedPopupPanelOtherText;
                this.IncidentEndedPopupPanelIGotHurtText = appLanguage.IncidentEndedPopupPanelIGotHurtText;
                this.IncidentEndedPopupPanelIHaveToLeaveText = appLanguage.IncidentEndedPopupPanelIHaveToLeaveText;
                this.IncidentEndedPopupPanelPoliceHaveArrivedText = appLanguage.IncidentEndedPopupPanelPoliceHaveArrivedText;
                this.IncidentEndedPopupPanelSituationIsStillHappeningText = appLanguage.IncidentEndedPopupPanelSituationIsStillHappeningText;
                #endregion

                #region Forgot Password Popup panel
                this.ForgotPasswordPopupPanelTitleText = appLanguage.ForgotPasswordPopupPanelTitleText;
                this.ForgotPasswordPopupPanelInfoText = appLanguage.ForgotPasswordPopupPanelInfoText;
                this.ForgotPasswordPopupPanelGotItButtonText = appLanguage.ForgotPasswordPopupPanelGotItButtonText;
                #endregion

                #region Stay Signed In Popup panel
                this.StaySignedInPopupPanelTitleText = appLanguage.StaySignedInPopupPanelTitleText;
                this.StaySignedInPopupPanelContentText = appLanguage.StaySignedInPopupPanelContentText;
                this.StaySignedInPopupPanelRelogInEveryTimeButtonText = appLanguage.StaySignedInPopupPanelRelogInEveryTimeButtonText;
                this.StaySignedInPopupPanelStayInSignedButtonText = appLanguage.StaySignedInPopupPanelStayInSignedButtonText;
                #endregion

                #region Premium Popup Panel
                this.PremiumPopupPanelCongratulationsText = appLanguage.PremiumPopupPanelCongratulationsText;
                this.PremiumPopupPanelInfoFormatText = appLanguage.PremiumPopupPanelInfoFormatText;
                this.PremiumPopupPanelInfoText = appLanguage.PremiumPopupPanelInfoText;
                this.PremiumPopupPanelGotItButtonText = appLanguage.PremiumPopupPanelGotItButtonText;
                this.PremiumPopupPanelSilverText = appLanguage.PremiumPopupPanelSilverText;
                this.PremiumPopupPanelGoldText = appLanguage.PremiumPopupPanelGoldText;
                #endregion

                #region Work panel
                this.WorkPanelEmergencyCommandText = appLanguage.WorkPanelEmergencyCommandText;
                this.WorkPanelStarredCommandText = appLanguage.WorkPanelStarredCommandText;
                this.WorkPanelMapCommandText = appLanguage.WorkPanelMapCommandText;
                this.WorkPanelNotificationsCommandText = appLanguage.WorkPanelNotificationsCommandText;
                this.WorkPanelAccountCommandText = appLanguage.WorkPanelAccountCommandText;
                #endregion

                #region Emergency panel
                this.EmergencyPanelTitleText = appLanguage.EmergencyPanelTitleText;
                this.EmergencyPanelEmergencyText = appLanguage.EmergencyPanelEmergencyText;
                this.EmergencyPanelBadSituationTitleText = appLanguage.EmergencyPanelBadSituationTitleText;
                this.EmergencyPanelCallToPoliceTitleText = appLanguage.EmergencyPanelCallToPoliceTitleText;
                this.EmergencyPanelTopInfoText = appLanguage.EmergencyPanelTopInfoText;
                this.EmergencyPanelActivatedInfoText = appLanguage.EmergencyPanelActivatedInfoText;
                this.EmergencyPanelEndRouteEarlyInfoText = appLanguage.EmergencyPanelEndRouteEarlyInfoText;
                this.EmergencyPanelOutRouteInfoText = appLanguage.EmergencyPanelOutRouteInfoText;
                this.EmergencyPanelSecondsText = appLanguage.EmergencyPanelSecondsText;
                this.EmergencyPanelBottomInfoText = appLanguage.EmergencyPanelBottomInfoText;
                this.EmergencyPanelForgotPasswordCommandText = appLanguage.EmergencyPanelForgotPasswordCommandText;
                this.EmergencyPanelForgotPasswordInfoText = appLanguage.EmergencyPanelForgotPasswordInfoText;
                #endregion

                #region End Route Early Panel
                this.EndRouteEarlyPanelTitleText = appLanguage.EndRouteEarlyPanelTitleText;
                this.EndRouteEarlyPanelSecondsText = appLanguage.EndRouteEarlyPanelSecondsText;
                this.EndRouteEarlyPanelBottomInfoText = appLanguage.EndRouteEarlyPanelBottomInfoText;
                #endregion

                #region Test panel
                this.TestPanelTitleText = appLanguage.TestPanelTitleText;
                this.TestPanelBackCommandText = appLanguage.TestPanelBackCommandText;
                this.TestPanelTopInfoText = appLanguage.TestPanelTopInfoText;
                this.TestPanelEndTestModeButtonText = appLanguage.TestPanelEndTestModeButtonText;
                this.TestPanelTestButtonText = appLanguage.TestPanelTestButtonText;
                this.TestPanelNotifyEmergencyContactsLabelText = appLanguage.TestPanelNotifyEmergencyContactsLabelText;
                this.TestPanelNotifyEmergencyContactsDescriptionText = appLanguage.TestPanelNotifyEmergencyContactsDescriptionText;
                this.TestPanelAudioVideoRecordingLabelText = appLanguage.TestPanelAudioVideoRecordingLabelText;
                this.TestPanelAudioVideoRecordingDescriptionText = appLanguage.TestPanelAudioVideoRecordingDescriptionText;
                this.TestPanelActivateFlashlightLabelText = appLanguage.TestPanelActivateFlashlightLabelText;
                this.TestPanelActivateFlashlightDescriptionText = appLanguage.TestPanelActivateFlashlightDescriptionText;
                this.TestPanelAlertNearbyCurrentUsersLabelText = appLanguage.TestPanelAlertNearbyCurrentUsersLabelText;
                this.TestPanelAlertNearbyCurrentUsersDescriptionText = appLanguage.TestPanelAlertNearbyCurrentUsersDescriptionText; ;
                this.TestPanelTurnOnSirenLabelText = appLanguage.TestPanelTurnOnSirenLabelText;
                this.TestPanelTurnOnSirenDescriptionText = appLanguage.TestPanelTurnOnSirenDescriptionText;
                this.TestPanelSendMyLocationToPoliceLabelText = appLanguage.TestPanelSendMyLocationToPoliceLabelText;
                this.TestPanelSendMyLocationToPoliceDescriptionText = appLanguage.TestPanelSendMyLocationToPoliceDescriptionText;
                this.TestPanelSendMyLocationToPoliceLinkText = appLanguage.TestPanelSendMyLocationToPoliceLinkText;
                this.TestPanelCallAlarmMonitoringLabelText = appLanguage.TestPanelCallAlarmMonitoringLabelText;
                this.TestPanelCallAlarmMonitoringDescriptionText = appLanguage.TestPanelCallAlarmMonitoringDescriptionText;
                this.TestPanelCallPoliceLabelText = appLanguage.TestPanelCallPoliceLabelText;
                this.TestPanelCallPoliceDescriptionText = appLanguage.TestPanelCallPoliceDescriptionText;
                #endregion

                #region Home panel
                this.HomePanelTitleText = appLanguage.HomePanelTitleText;
                this.HomePanelTitleFormatText = appLanguage.HomePanelTitleFormatText;
                this.HomePanelLastUpdatedInfoLabelText = appLanguage.HomePanelLastUpdatedInfoLabelText;
                this.HomePanelBattaryLabelText = appLanguage.HomePanelBattaryLabelText;
                this.HomePanelArmedLabelText = appLanguage.HomePanelArmedLabelText;
                this.HomePanelDisarmedLabelText = appLanguage.HomePanelDisarmedLabelText;
                this.HomePanelSafetyLabelText = appLanguage.HomePanelSafetyLabelText;
                this.HomePanelEndTripButtonText = appLanguage.HomePanelEndTripButtonText;
                this.HomePanelEndTripDownButtonText = appLanguage.HomePanelEndTripDownButtonText;
                this.HomePanelPauseTripButtonText = appLanguage.HomePanelPauseTripButtonText;
                this.HomePanelContinueTripButtonText = appLanguage.HomePanelContinueTripButtonText;
                this.HomePanelSaveCommandText = appLanguage.HomePanelSaveCommandText;
                this.HomePanelWalkingTimeText = appLanguage.HomePanelWalkingTimeText;
                this.HomePanelBicyclingTimeText = appLanguage.HomePanelBicyclingTimeText;
                this.HomePanelDrivingTimeText = appLanguage.HomePanelDrivingTimeText;
                this.HomePanelSelfRespondersLabelText = appLanguage.HomePanelSelfRespondersLabelText;
                this.HomePanelEditRouteDialogTitleText = appLanguage.HomePanelEditRouteDialogTitleText;
                this.HomePanelEditRouteDialogMessageText = appLanguage.HomePanelEditRouteDialogMessageText;
                this.HomePanelEditRouteDialogActionChangeText = appLanguage.HomePanelEditRouteDialogActionChangeText;
                this.HomePanelEditRouteDialogActionCancleText = appLanguage.HomePanelEditRouteDialogActionCancleText;
                #endregion

                #region Notifications panel
                #endregion

                #region Notification Main panel
                this.NotificationsMainPanelTitleText = appLanguage.NotificationsMainPanelTitleText;
                #endregion

                #region Notifications Friend In Emergency Panel
                this.NotificationsInEmergencyPanelBackCommandText = appLanguage.NotificationsInEmergencyPanelBackCommandText;
                this.NotificationsInEmergencyPanelTitleText = appLanguage.NotificationsInEmergencyPanelTitleText;
                this.NotificationsInEmergencyPanelPhoneStatusText = appLanguage.NotificationsInEmergencyPanelPhoneStatusText;
                this.NotificationsInEmergencyPanelEmergencyButtonLabelText = appLanguage.NotificationsInEmergencyPanelEmergencyButtonLabelText;
                this.NotificationsInEmergencyPanelRespondersNearByLabelText = appLanguage.NotificationsInEmergencyPanelRespondersNearByLabelText;
                this.NotificationsInEmergencyPanelEmergencyButtonInactiviveText = appLanguage.NotificationsInEmergencyPanelEmergencyButtonInactiviveText;
                this.NotificationsInEmergencyPanelSafetyArmedSwitchText = appLanguage.NotificationsInEmergencyPanelSafetyArmedSwitchText;
                this.NotificationsInEmergencyPanelEmergencyButtonAlarmText = appLanguage.NotificationsInEmergencyPanelEmergencyButtonAlarmText;
                this.NotificationsInEmergencyPanelPhoneOnStatusText = appLanguage.NotificationsInEmergencyPanelPhoneOnStatusText;
                this.NotificationsInEmergencyPanelPhoneOffStatusText = appLanguage.NotificationsInEmergencyPanelPhoneOffStatusText;
                this.NotificationsInEmergencyPanelTrackingRouteText = appLanguage.NotificationsInEmergencyPanelTrackingRouteText;
                this.NotificationsInEmergencyPanelNotTrackingRouteText = appLanguage.NotificationsInEmergencyPanelNotTrackingRouteText;
                this.NotificationsInEmergencyPanelLocationTitleText = appLanguage.NotificationsInEmergencyPanelLocationTitleText;
                this.NotificationsInEmergencyPanelReportToPoliceText = appLanguage.NotificationsInEmergencyPanelReportToPoliceText;
                this.NotificationsInEmergencyPanelMinText = appLanguage.NotificationsInEmergencyPanelMinText;
                this.NotificationsInEmergencyPanelMilesText = appLanguage.NotificationsInEmergencyPanelMilesText;
                this.NotificationsInEmergencyPanelMph = appLanguage.NotificationsInEmergencyPanelMph;
                this.NotificationsInEmergencyPanelDirectThereText = appLanguage.NotificationsInEmergencyPanelDirectThereText;
                #endregion

                #region Notifications Call To Police Panel
                this.NotificationsCallPolicePanelBackCommandText = appLanguage.NotificationsCallPolicePanelBackCommandText;
                this.NotificationsCallPolicePanelTitleText = appLanguage.NotificationsCallPolicePanelTitleText;
                this.NotificationsCallPolicePanelEndCallCommandText = appLanguage.NotificationsCallPolicePanelEndCallCommandText;
                this.NotificationsCallPolicePanelReadToPoliceTitleText = appLanguage.NotificationsCallPolicePanelReadToPoliceTitleText;
                this.NotificationsCallPolicePanelCallText = appLanguage.NotificationsCallPolicePanelCallText;
                this.NotificationsCallPolicePanelMyPhoneLabelText = appLanguage.NotificationsCallPolicePanelMyPhoneLabelText;
                this.NotificationsCallPolicePanelMyNameLabelText = appLanguage.NotificationsCallPolicePanelMyNameLabelText;
                this.NotificationsCallPolicePanelInfoToPoliceTitleText = appLanguage.NotificationsCallPolicePanelInfoToPoliceTitleText;
                this.NotificationsCallPolicePanelNameLabelText = appLanguage.NotificationsCallPolicePanelNameLabelText;
                this.NotificationsCallPolicePanelAgeLabelText = appLanguage.NotificationsCallPolicePanelAgeLabelText;
                this.NotificationsCallPolicePanelEthnicityLabelText = appLanguage.NotificationsCallPolicePanelEthnicityLabelText;
                this.NotificationsCallPolicePanelHairColorLabelText = appLanguage.NotificationsCallPolicePanelHairColorLabelText;
                this.NotificationsCallPolicePanelHeightLabelText = appLanguage.NotificationsCallPolicePanelHeightLabelText;
                this.NotificationsCallPolicePanelAllergiesLabelText = appLanguage.NotificationsCallPolicePanelAllergiesLabelText;
                this.NotificationsCallPolicePanelMedicationsLabelText = appLanguage.NotificationsCallPolicePanelMedicationsLabelText;
                this.NotificationsCallPolicePanelMinText = appLanguage.NotificationsCallPolicePanelMinText;
                this.NotificationsCallPolicePanelMilesText = appLanguage.NotificationsCallPolicePanelMilesText;
                this.NotificationsCallPolicePanelMph = appLanguage.NotificationsCallPolicePanelMph;
                this.NotificationsCallPolicePanelDirectThereText = appLanguage.NotificationsCallPolicePanelDirectThereText;
                #endregion

                #region Notifications Emergency Directions Panel
                this.NotificationsDirectionsPanelMinText = appLanguage.NotificationsDirectionsPanelMinText;
                this.NotificationsDirectionsPanelTimeText = appLanguage.NotificationsDirectionsPanelTimeText;
                this.NotificationsDirectionsPanelMilesText = appLanguage.NotificationsDirectionsPanelMilesText;
                this.NotificationsDirectionsPanelFtText = appLanguage.NotificationsDirectionsPanelFtText;
                this.NotificationsDirectionsPanelCallToPoliceLabelText = appLanguage.NotificationsDirectionsPanelCallToPoliceLabelText;
                this.NotificationsDirectionsPanelRespondersLabelText = appLanguage.NotificationsDirectionsPanelRespondersLabelText;
                this.NotificationsDirectionsPanelEndNavLabelText = appLanguage.NotificationsDirectionsPanelEndNavLabelText;
                this.NotificationsDirectionsPanelEndNavCommandText = appLanguage.NotificationsDirectionsPanelEndNavCommandText;
                #endregion

                #region Notifications Emergency Record Panel
                this.NotificationsEmergencyRecordPanelCallToPoliceLabelText = appLanguage.NotificationsEmergencyRecordPanelCallToPoliceLabelText;
                this.NotificationsEmergencyRecordPanelRespondersLabelText = appLanguage.NotificationsEmergencyRecordPanelRespondersLabelText;
                this.NotificationsEmergencyRecordPanelEndRecLabelText = appLanguage.NotificationsEmergencyRecordPanelEndRecLabelText;
                this.NotificationsEmergencyRecordPanelEndRecCommandText = appLanguage.NotificationsEmergencyRecordPanelEndRecCommandText;
                #endregion

                #region Notifications Breaking News panel
                this.NotificationsBreakingNewsPanelTitleText = appLanguage.NotificationsBreakingNewsPanelTitleText;
                this.NotificationsBreakingNewsPanelBackCommandText = appLanguage.NotificationsBreakingNewsPanelBackCommandText;
                #endregion

                #region Notifications Local Alert panel
                this.NotificationsLocalAlertPanelTitleText = appLanguage.NotificationsLocalAlertPanelTitleText;
                this.NotificationsLocalAlertPanelBackCommandText = appLanguage.NotificationsLocalAlertPanelBackCommandText;
                #endregion

                #region Notifications Safety Tip panel
                this.NotificationsSafetyTipPanelTitleText = appLanguage.NotificationsSafetyTipPanelTitleText;
                this.NotificationsSafetyTipPanelBackCommandText = appLanguage.NotificationsSafetyTipPanelBackCommandText;
                #endregion

                #region Notifications Help Panel
                this.NotificationsHelpPanelBackCommandText = appLanguage.NotificationsHelpPanelBackCommandText;
                this.NotificationsHelpPanelTitleText = appLanguage.NotificationsHelpPanelTitleText;
                this.NotificationsHelpPanelReportToPoliceText = appLanguage.NotificationsHelpPanelReportToPoliceText;
                this.NotificationsHelpPanelMinText = appLanguage.NotificationsHelpPanelMinText;
                this.NotificationsHelpPanelMilesText = appLanguage.NotificationsHelpPanelMilesText;
                this.NotificationsHelpPanelMphText = appLanguage.NotificationsHelpPanelMphText;
                this.NotificationsHelpPanelDirectThereText = appLanguage.NotificationsHelpPanelDirectThereText;
                #endregion

                #region Account panel
                this.AccountPanelMemberSinceFormatText = appLanguage.AccountPanelMemberSinceFormatText;
                this.AccountPanelViewProfileCommandText = appLanguage.AccountPanelViewProfileCommandText;
                this.AccountPanelSettingsCommandText = appLanguage.AccountPanelSettingsCommandText;
                this.AccountPanelShareCommandText = appLanguage.AccountPanelShareCommandText;
                this.AccountPanelGetPremiumCommandText = appLanguage.AccountPanelGetPremiumCommandText;
                this.AccountPanelContactUsCommandText = appLanguage.AccountPanelContactUsCommandText;
                this.AccountPanelFriendsCommandText = appLanguage.AccountPanelFriendsCommandText;
                this.AccountPanelProfileCommandText = appLanguage.AccountPanelProfileCommandText;
                this.AccountPanelGiftAppCommandText = appLanguage.AccountPanelGiftAppCommandText;
                this.AccountPanelFollowUsCommandText = appLanguage.AccountPanelFollowUsCommandText;
                #endregion

                #region List panel
                this.ListPanelSelectorLeftText = appLanguage.ListPanelSelectorLeftText;
                this.ListPanelSelectorRightText = appLanguage.ListPanelSelectorRightText;
                this.ListPanelPeoplesListTitleText = appLanguage.ListPanelPeoplesListTitleText;
                this.ListPanelAddPeopleCommandText = appLanguage.ListPanelAddPeopleCommandText;
                this.ListPanelPlacesListTitleText = appLanguage.ListPanelPlacesListTitleText;
                this.ListPanelAddPlaceCommandText = appLanguage.ListPanelAddPlaceCommandText;
                this.ListPanelPendingApproval = appLanguage.ListPanelPendingApproval;
                #endregion

                #region Add Place panel
                this.AddPlacePanelTitleText = appLanguage.AddPlacePanelTitleText;
                this.ModifyPlacePanelTitleText = appLanguage.ModifyPlacePanelTitleText; //CakeSoft fixed bug SB-18
                this.AddPlacePanelTopInfoText = appLanguage.AddPlacePanelTopInfoText;
                this.AddPlacePanelNameLabelText = appLanguage.AddPlacePanelNameLabelText;
                this.AddPlacePanelAddressLabelText = appLanguage.AddPlacePanelAddressLabelText;
                this.AddPlacePanelMinutesText = appLanguage.AddPlacePanelMinutesText;
                this.AddPlacePanelMilesText = appLanguage.AddPlacePanelMilesText;
                this.AddPlacePanelSaveButtonText = appLanguage.AddPlacePanelSaveButtonText;
                #endregion

                #region Start Recording Route panel
                this.StartRecordingRoutePanelInfoTextLine_1 = appLanguage.StartRecordingRoutePanelInfoTextLine_1;
                this.StartRecordingRoutePanelInfoTextLine_2 = appLanguage.StartRecordingRoutePanelInfoTextLine_2;
                this.StartRecordingRoutePanelButtonText = appLanguage.StartRecordingRoutePanelButtonText;
                #endregion

                #region End Recording Route panel
                this.EndRecordingRoutePanelInfoText = appLanguage.EndRecordingRoutePanelInfoText;
                this.EndRecordingRoutePanelButtonText = appLanguage.EndRecordingRoutePanelButtonText;
                #endregion

                #region Edit Route Info panel
                this.EditRouteInfoPanelInfoTextLine_1 = appLanguage.EditRouteInfoPanelInfoTextLine_1;
                this.EditRouteInfoPanelInfoTextLine_2 = appLanguage.EditRouteInfoPanelInfoTextLine_2;
                this.EditRouteInfoPanelInfoTextLine_3 = appLanguage.EditRouteInfoPanelInfoTextLine_3;
                this.EditRouteInfoPanelInfoTextLine_4 = appLanguage.EditRouteInfoPanelInfoTextLine_4;
                #endregion

                #region End Route Info panel
                this.EndRouteInfoPanelInfoTextLine_1 = appLanguage.EndRouteInfoPanelInfoTextLine_1;
                this.EndRouteInfoPanelInfoTextLine_2 = appLanguage.EndRouteInfoPanelInfoTextLine_2;
                this.EndRouteInfoPanelInfoTextLine_3 = appLanguage.EndRouteInfoPanelInfoTextLine_3;
                #endregion

                #region Profile panel
                this.ProfilePanelBackCommandText = appLanguage.ProfilePanelBackCommandText;
                this.ProfilePanelTopInfoText = appLanguage.ProfilePanelTopInfoText;
                this.ProfilePanelCompletedPercentText = appLanguage.ProfilePanelCompletedPercentText;
                this.ProfilePanelBasicInfoText = appLanguage.ProfilePanelBasicInfoText;
                this.ProfilePanelMedicalInfoText = appLanguage.ProfilePanelMedicalInfoText;
                this.ProfilePanelEmergencyContactInfoText = appLanguage.ProfilePanelEmergencyContactInfoText;
                this.ProfilePanelSaveCommandText = appLanguage.ProfilePanelSaveCommandText;
                this.ProfilePanelFirstAndLastNameLabelText = appLanguage.ProfilePanelFirstAndLastNameLabelText;
                this.ProfilePanelGenderLabelText = appLanguage.ProfilePanelGenderLabelText;
                this.ProfilePanelBirthDayLabelText = appLanguage.ProfilePanelBirthDayLabelText;
                this.ProfilePanelEmailLabelText = appLanguage.ProfilePanelEmailLabelText;
                this.ProfilePanelPhoneNumberLabelText = appLanguage.ProfilePanelPhoneNumberLabelText;
                this.ProfilePanelConnectSocialMediaLabelText = appLanguage.ProfilePanelConnectSocialMediaLabelText;
                this.ProfilePanelHeightLabelText = appLanguage.ProfilePanelHeightLabelText;
                this.ProfilePanelWeightLabelText = appLanguage.ProfilePanelWeightLabelText;
                this.ProfilePanelHairColorLabelText = appLanguage.ProfilePanelHairColorLabelText;
                this.ProfilePanelEyeColorLabelText = appLanguage.ProfilePanelEyeColorLabelText;
                this.ProfilePanelEthnicityLabelText = appLanguage.ProfilePanelEthnicityLabelText;
                this.ProfilePanelStreetLabelText = appLanguage.ProfilePanelStreetLabelText;
                this.ProfilePanelCityLabelText = appLanguage.ProfilePanelCityLabelText;
                this.ProfilePanelStateLabelText = appLanguage.ProfilePanelStateLabelText;
                this.ProfilePanelZipCodeLabelText = appLanguage.ProfilePanelZipCodeLabelText;
                this.ProfilePanelAllergiesLabelText = appLanguage.ProfilePanelAllergiesLabelText;
                this.ProfilePanelMedicationsLabelText = appLanguage.ProfilePanelMedicationsLabelText;
                this.ProfilePanelEmergencyContactNameLabelText = appLanguage.ProfilePanelEmergencyContactNameLabelText;
                this.ProfilePanelEmergencyContactRelationLabelText = appLanguage.ProfilePanelEmergencyContactRelationLabelText;
                this.ProfilePanelEmergencyContactEmailLabelText = appLanguage.ProfilePanelEmergencyContactEmailLabelText;
                this.ProfilePanelEmergencyContactPhoneNumberLabelText = appLanguage.ProfilePanelEmergencyContactPhoneNumberLabelText;
                this.ProfilePanelGetAnotherEmergencyContactButtonText = appLanguage.ProfilePanelGetAnotherEmergencyContactButtonText;
                this.ProfilePanelLoggedToastText = appLanguage.ProfilePanelLoggedToastText;
                this.ProfilePanelTitleText = appLanguage.ProfilePanelTitleText;
                this.ProfilePanelMedicalInfoHeaderText = appLanguage.ProfilePanelMedicalInfoHeaderText;
                this.ProfilePanelBasicInfoHeaderText = appLanguage.ProfilePanelBasicInfoHeaderText;
                this.ProfilePanelEmergencyContactHeaderInfoText = appLanguage.ProfilePanelEmergencyContactHeaderInfoText;
                this.ProfilePanelSexLabelText = appLanguage.ProfilePanelSexLabelText;
                this.ProfilePanelAddressLabelText = appLanguage.ProfilePanelAddressLabelText;
                this.ProfilePanelStaySignedInHeaderInfoText = appLanguage.ProfilePanelStaySignedInHeaderInfoText;
                this.ProfilePanelFacefookButtonText = appLanguage.ProfilePanelFacefookButtonText;
                this.ProfilePanelStaySignedInfoText = appLanguage.ProfilePanelStaySignedInfoText;
                this.ProfilePanelStaySignedLabelText = appLanguage.ProfilePanelStaySignedLabelText;
                #endregion

                #region Settings panel
                this.SettingsPanelTitleText = appLanguage.SettingsPanelTitleText;
                this.SettingsPanelBackCommandText = appLanguage.SettingsPanelBackCommandText;
                this.SettingsPanelEditProfileCommandText = appLanguage.SettingsPanelEditProfileCommandText;
                this.SettingsPanelEmergencyButtonSettingsCommandText = appLanguage.SettingsPanelEmergencyButtonSettingsCommandText;
                this.SettingsPanelNotificationSettingsCommandText = appLanguage.SettingsPanelNotificationSettingsCommandText;
                this.SettingsPanelChangeDeactivationPasscodeCommandText = appLanguage.SettingsPanelChangeDeactivationPasscodeCommandText;
                this.SettingsPanelEmergencyContactsCommandText = appLanguage.SettingsPanelEmergencyContactsCommandText;
                this.SettingsPanelBlockedPeopleCommandText = appLanguage.SettingsPanelBlockedPeopleCommandText;
                this.SettingsPanelLocationSharingCommandText = appLanguage.SettingsPanelLocationSharingCommandText;
                this.SettingsPanelTestModeCommandText = appLanguage.SettingsPanelTestModeCommandText;
                this.SettingsPanelTutorialCommandText = appLanguage.SettingsPanelTutorialCommandText;
                this.SettingsPanelReceiveSafetyTipsCommandText = appLanguage.SettingsPanelReceiveSafetyTipsCommandText;
                this.SettingsPanelReceiveAlertsCommandText = appLanguage.SettingsPanelReceiveAlertsCommandText;
                this.SettingsPanelRecordCommandText = appLanguage.SettingsPanelRecordCommandText;
                this.SettingsPanelLockSettingsCommandText = appLanguage.SettingsPanelLockSettingsCommandText;
                this.SettingsPanelEditLocationSharingCommandText = appLanguage.SettingsPanelEditLocationSharingCommandText;
                this.SettingsPanelTrackFriendsCommandText = appLanguage.SettingsPanelTrackFriendsCommandText;
                this.SettingsPanelTermsofUse = appLanguage.SettingsPanelTermsofUse;
                this.SettingsPanelPrivacyPolicies = appLanguage.SettingsPanelPrivacyPolicies;  // CakeSoft fixed bug ulzi-5
                #endregion

                #region Share panel
                this.SharePanelTitleText = appLanguage.SharePanelTitleText;
                this.SharePanelBackCommandText = appLanguage.SharePanelBackCommandText;
                this.SharePanelShareCommandText = appLanguage.SharePanelShareCommandText;
                this.SharePanelTopInfoText = appLanguage.SharePanelTopInfoText;
                this.SharePanelWriteACaptionPlaceholderText = appLanguage.SharePanelWriteACaptionPlaceholderText;
                this.SharePanelTagPeopleCommandText = appLanguage.SharePanelTagPeopleCommandText;
                this.SharePanelFacebookCommandText = appLanguage.SharePanelFacebookCommandText;
                this.SharePanelTwitterCommandText = appLanguage.SharePanelTwitterCommandText;
                this.SharePanelInstagramCommandText = appLanguage.SharePanelInstagramCommandText;
                this.SharePanelPinterestCommandText = appLanguage.SharePanelPinterestCommandText;
                this.SharePanelLinkedInCommandText = appLanguage.SharePanelLinkedInCommandText;
                this.SharePanelTextCommandText = appLanguage.SharePanelTextCommandText;
                this.SharePanelEmailCommandText = appLanguage.SharePanelEmailCommandText;
                this.SharePanelWriteAMessagePlaceholderText = appLanguage.SharePanelWriteAMessagePlaceholderText;
                this.SharePanelChoosePeopleToShareCommandText = appLanguage.SharePanelChoosePeopleToShareCommandText;
                this.SharePanelChooseShareViaEmailCommandText = appLanguage.SharePanelChooseShareViaEmailCommandText;
                this.SharePanelSubjectText = appLanguage.SharePanelSubjectText;
                this.SharePanelShareInfoText = appLanguage.SharePanelShareInfoText;
                this.SharePanelMessageText = appLanguage.SharePanelMessageText;
                this.SharePanelShareWithSelectedContacts = appLanguage.SharePanelShareWithSelectedContacts;
                this.SharePanelAppShareMessage = appLanguage.SharePanelAppShareMessage;
                #endregion

                #region Contact Us panel
                this.ContactUsPanelTitleText = appLanguage.ContactUsPanelTitleText;
                this.ContactUsPanelBackCommandText = appLanguage.ContactUsPanelBackCommandText;
                this.ContactUsPanelContentTitleText = appLanguage.ContactUsPanelContentTitleText;
                this.ContactUsPanelTopInfoText = appLanguage.ContactUsPanelTopInfoText;
                this.ContactUsPanelSubjectLabelText = appLanguage.ContactUsPanelSubjectLabelText;
                this.ContactUsPanelMessageLabelText = appLanguage.ContactUsPanelMessageLabelText;
                this.ContactUsPanelSendButtonText = appLanguage.ContactUsPanelSendButtonText;
                this.ContactUsPanelFeedbackTitleText = appLanguage.ContactUsPanelFeedbackTitleText;
                this.ContactUsPanelMailIdText = appLanguage.ContactUsPanelMailIdText;
                #endregion

                #region Premium Account panel
                this.PremiumAccountPanelTitleText_old = appLanguage.PremiumAccountPanelTitleText_old;
                this.PremiumAccountPanelBackCommandText = appLanguage.PremiumAccountPanelBackCommandText;
                this.PremiumAccountPanelPremiumSilverButtonText = appLanguage.PremiumAccountPanelPremiumSilverButtonText;
                this.PremiumAccountPanelPremiumGoldButtonText = appLanguage.PremiumAccountPanelPremiumGoldButtonText;
                this.PremiumAccountPanelCancelPremiumButtonText = appLanguage.PremiumAccountPanelCancelPremiumButtonText;
                this.PremiumAccountPanelTitleText = appLanguage.PremiumAccountPanelTitleText;
                this.PremiumAccountPanelTrySilverButtonText = appLanguage.PremiumAccountPanelTrySilverButtonText;
                this.PremiumAccountPanelTryGoldButtonText = appLanguage.PremiumAccountPanelTryGoldButtonText;
                this.PremiumAccountPanelGiftAppCommandText = appLanguage.PremiumAccountPanelGiftAppCommandText;
                this.PremiumAccountPanelCancelSilverButtonText = appLanguage.PremiumAccountPanelCancelSilverButtonText;
                this.PremiumAccountPanelCancelGoldButtonText = appLanguage.PremiumAccountPanelCancelGoldButtonText;
                #endregion

                #region Change Passcode panel
                this.ChangePasscodePanelTitleText = appLanguage.ChangePasscodePanelTitleText;
                this.ChangePasscodePanelBackCommandText = appLanguage.ChangePasscodePanelBackCommandText;
                this.ChangePasscodePanelSaveCommandText = appLanguage.ChangePasscodePanelSaveCommandText;
                this.ChangePasscodePanelTopInfoText = appLanguage.ChangePasscodePanelTopInfoText;
                this.ChangePasscodePanelOldPasscodeLabelText = appLanguage.ChangePasscodePanelOldPasscodeLabelText;
                this.ChangePasscodePanelNewPasscodeLabelText = appLanguage.ChangePasscodePanelNewPasscodeLabelText;
                this.ChangePasscodePanelRepeatNewPasscodeLabelText = appLanguage.ChangePasscodePanelRepeatNewPasscodeLabelText;
                this.ChangePasscodePanelForgotPasscodeCommandText = appLanguage.ChangePasscodePanelForgotPasscodeCommandText;
                this.ChangePasscodePanelNextCommandText = appLanguage.ChangePasscodePanelNextCommandText;
                #endregion

                #region Button Settings panel
                this.AccountButtonSettingsPanelTitleText = appLanguage.AccountButtonSettingsPanelTitleText;
                this.AccountButtonSettingsPanelBackCommandText = appLanguage.AccountButtonSettingsPanelBackCommandText;
                this.AccountButtonSettingsPanelFirstTopInfoText = appLanguage.AccountButtonSettingsPanelFirstTopInfoText;
                this.AccountButtonSettingsPanelSecondTopInfoText = appLanguage.AccountButtonSettingsPanelSecondTopInfoText;
                this.AccountButtonSettingsAction1ButtonText = appLanguage.AccountButtonSettingsAction1ButtonText;
                this.AccountButtonSettingsAction2ButtonText = appLanguage.AccountButtonSettingsAction2ButtonText;
                this.AccountButtonSettingsAction3ButtonText = appLanguage.AccountButtonSettingsAction3ButtonText;
                this.AccountButtonSettingsImageTitleFormatText = appLanguage.AccountButtonSettingsImageTitleFormatText;
                this.AccountButtonSettingsBottomInfoText = appLanguage.AccountButtonSettingsBottomInfoText;
                this.AccountButtonSettingsCheckOutPremiumButtonText = appLanguage.AccountButtonSettingsCheckOutPremiumButtonText;
                #endregion

                #region Location Sharing panel
                this.LocationSharingPanelTitleText = appLanguage.LocationSharingPanelTitleText;
                this.LocationSharingPanelBackCommandText = appLanguage.LocationSharingPanelBackCommandText;
                this.LocationSharingPanelTopInfoText = appLanguage.LocationSharingPanelTopInfoText;
                this.LocationSharingPanelNewTopInfoText = appLanguage.LocationSharingPanelNewTopInfoText;
                this.LocationSharingPanelAddAnotherContactButtonText = appLanguage.LocationSharingPanelAddAnotherContactButtonText;
                this.LocationSharingPanelUnlockPremiumButtonText = appLanguage.LocationSharingPanelUnlockPremiumButtonText;
                this.LocationSharingPanelExpanderTopInfoText = appLanguage.LocationSharingPanelExpanderTopInfoText;
                this.LocationSharingPanelExpanderDaysLabelText = appLanguage.LocationSharingPanelExpanderDaysLabelText;
                this.LocationSharingPanelExpanderHoursLabelText = appLanguage.LocationSharingPanelExpanderHoursLabelText;
                this.LocationSharingPanelExpanderMinutesLabelText = appLanguage.LocationSharingPanelExpanderMinutesLabelText;
                this.LocationSharingPanelExpanderCancelCommandText = appLanguage.LocationSharingPanelExpanderCancelCommandText;
                this.LocationSharingPanelExpanderDoneCommandText = appLanguage.LocationSharingPanelExpanderDoneCommandText;
                this.LocationSharingPanelAddPeopleCommandText = appLanguage.LocationSharingPanelAddPeopleCommandText;
                this.LocationSharingPanelPendingApproval = appLanguage.LocationSharingPanelPendingApproval;
                #endregion

                #region Start Trip Panel
                this.StartTripLabelText = appLanguage.StartTripLabelText;
                this.StartTripPanelDeletePlaceLabelText = appLanguage.StartTripPanelDeletePlaceLabelText;
                this.StartTripPanelStartTextFormat = appLanguage.StartTripPanelStartTextFormat;
                this.StartTripPanelStartRouteLabelText = appLanguage.StartTripPanelStartRouteLabelText;
                this.StartTripPanelDeleteLocationCommandText = appLanguage.StartTripPanelDeleteLocationCommandText;
                this.StartTripPanelSavedRouteCommandText = appLanguage.StartTripPanelSavedRouteCommandText;
                this.StartTripPanelNewRouteCommandText = appLanguage.StartTripPanelNewRouteCommandText;
                #endregion

                #region Track Person Panel
                this.TrackPersonPanelSafeStatusText = appLanguage.TrackPersonPanelSafeStatusText;
                this.TrackPersonPanelStandByStatusText = appLanguage.TrackPersonPanelStandByStatusText;
                this.TrackPersonPanelUnsafeStatusText = appLanguage.TrackPersonPanelUnsafeStatusText;
                this.TrackPersonPanelSafetyStatusLabelText = appLanguage.TrackPersonPanelSafetyStatusLabelText;
                this.TrackPersonPanelPhoneStatusText = appLanguage.TrackPersonPanelPhoneStatusText;
                this.TrackPersonPanelPhoneOnStatusText = appLanguage.TrackPersonPanelPhoneOnStatusText;
                this.TrackPersonPanelPhoneOffStatusText = appLanguage.TrackPersonPanelPhoneOffStatusText;
                this.TrackPersonPanelSafetySwitchLabelText = appLanguage.TrackPersonPanelSafetySwitchLabelText;
                this.TrackPersonPanelSafetyArmedSwitchText = appLanguage.TrackPersonPanelSafetyArmedSwitchText;
                this.TrackPersonPanelSafetyDisarmedSwitchText = appLanguage.TrackPersonPanelSafetyDisarmedSwitchText;
                this.TrackPersonPanelStunLastActivatedLabelText = appLanguage.TrackPersonPanelStunLastActivatedLabelText;
                this.TrackPersonPanelMinText = appLanguage.TrackPersonPanelMinText;
                this.TrackPersonPanelMilesText = appLanguage.TrackPersonPanelMilesText;
                this.TrackPersonPanelDaysText = appLanguage.TrackPersonPanelDaysText;
                this.TrackPersonPanelRespondersNearByLabelText = appLanguage.TrackPersonPanelRespondersNearByLabelText;
                this.TrackPersonPanelCurrentLocationTitleText = appLanguage.TrackPersonPanelCurrentLocationTitleText;
                this.TrackPersonPanelSecondsFormatText = appLanguage.TrackPersonPanelSecondsFormatText;
                this.TrackPersonPanelInfoFormatText = appLanguage.TrackPersonPanelInfoFormatText;
                this.TrackPersonPanelInfoFormatWithoutHeadedText = appLanguage.TrackPersonPanelInfoFormatWithoutHeadedText;
                this.TrackPersonPanelLocalEmergencyCenterTitleText = appLanguage.TrackPersonPanelLocalEmergencyCenterTitleText;
                this.TrackPersonPanelMph = appLanguage.TrackPersonPanelMph;
                this.TrackPersonPanelDirectionsButtonText = appLanguage.TrackPersonPanelDirectionsButtonText;
                this.TrackPersonPanelMapOfFrequentLabelText = appLanguage.TrackPersonPanelMapOfFrequentLabelText;
                this.TrackPersonPanelNotificationZonesTitleText = appLanguage.TrackPersonPanelNotificationZonesTitleText;
                this.TrackPersonPanelAddLocationCommandText = appLanguage.TrackPersonPanelAddLocationCommandText;
                this.TrackPersonPanelNotificationSpeedTitleText = appLanguage.TrackPersonPanelNotificationSpeedTitleText;
                this.TrackPersonPanelNotificationSpeedText = appLanguage.TrackPersonPanelNotificationSpeedText;
                this.TrackPersonPanelNotificationSettingsTitleText = appLanguage.TrackPersonPanelNotificationSettingsTitleText;
                this.TrackPersonPanelInEmergencyText = appLanguage.TrackPersonPanelInEmergencyText;
                this.TrackPersonPanelCaseArmedText = appLanguage.TrackPersonPanelCaseArmedText;
                this.TrackPersonPanelNotificationZonesText = appLanguage.TrackPersonPanelNotificationZonesText;
                this.TrackPersonPanelNotificationSoundsTitleText = appLanguage.TrackPersonPanelNotificationSoundsTitleText;
                this.TrackPersonPanelRingtoneText = appLanguage.TrackPersonPanelRingtoneText;
                this.TrackPersonPanelNotificationText = appLanguage.TrackPersonPanelNotificationText;
                this.TrackPersonPanelStopTrackingCommandText = appLanguage.TrackPersonPanelStopTrackingCommandText;
                this.TrackPersonPanelArriveLabelText = appLanguage.TrackPersonPanelArriveLabelText;
                this.TrackPersonPanelLeaveLabelText = appLanguage.TrackPersonPanelLeaveLabelText;
                this.TrackPersonPanelRingVibrateNotificationSettingLabelText = appLanguage.TrackPersonPanelRingVibrateNotificationSettingLabelText;
                this.TrackPersonPanelVibrateNotificationSettingLabelText = appLanguage.TrackPersonPanelVibrateNotificationSettingLabelText;
                this.TrackPersonPanelNotificationSettingLabelText = appLanguage.TrackPersonPanelNotificationSettingLabelText;
                this.TrackPersonPanelNoNotificationSettingLabelText = appLanguage.TrackPersonPanelNoNotificationSettingLabelText;
                this.TrackPersonPanelEmergencyButtonLabelText = appLanguage.TrackPersonPanelEmergencyButtonLabelText;
                this.TrackPersonPanelEmergencyButtonInactiviveText = appLanguage.TrackPersonPanelEmergencyButtonInactiviveText;
                this.TrackPersonPanelEmergencyButtonActiviveText = appLanguage.TrackPersonPanelEmergencyButtonActiviveText;
                this.TrackPersonPanelTrackingRouteText = appLanguage.TrackPersonPanelTrackingRouteText;
                this.TrackPersonPanelNotTrackingRouteText = appLanguage.TrackPersonPanelNotTrackingRouteText;
                this.TrackPersonPanelEmergencyButtonAlarmText = appLanguage.TrackPersonPanelEmergencyButtonAlarmText;
                this.TrackPersonPanelReportToPoliceText = appLanguage.TrackPersonPanelReportToPoliceText;
                this.TrackPersonPanelDirectThereText = appLanguage.TrackPersonPanelDirectThereText;
                this.TrackPersonPanelInBadSituationText = appLanguage.TrackPersonPanelInBadSituationText;
                this.TrackPersonPanelDeviatedFromRouteText = appLanguage.TrackPersonPanelDeviatedFromRouteText;
                this.TrackPersonPanelOnMyWayButtonText = appLanguage.TrackPersonPanelOnMyWayButtonText;
                this.TrackPersonPanelCallPoliceButtonText = appLanguage.TrackPersonPanelCallPoliceButtonText;
                this.TrackPersonPanelEventHasEndedButtonText = appLanguage.TrackPersonPanelEventHasEndedButtonText;
                this.TrackPersonPanelEndCallButtonText = appLanguage.TrackPersonPanelEndCallButtonText;
                this.TrackPersonPanelVitalInfoText = appLanguage.TrackPersonPanelVitalInfoText;
                this.TrackPersonPanelVitalInfoNameText = appLanguage.TrackPersonPanelVitalInfoNameText;
                this.TrackPersonPanelVitalInfoAgeText = appLanguage.TrackPersonPanelVitalInfoAgeText;
                this.TrackPersonPanelVitalInfoSexText = appLanguage.TrackPersonPanelVitalInfoSexText;
                this.TrackPersonPanelVitalInfoHeightText = appLanguage.TrackPersonPanelVitalInfoHeightText;
                this.TrackPersonPanelVitalInfoEthnicityText = appLanguage.TrackPersonPanelVitalInfoEthnicityText;
                this.TrackPersonPanelVitalInfoHairColorText = appLanguage.TrackPersonPanelVitalInfoHairColorText;
                this.TrackPersonPanelVitalInfoAllergiesText = appLanguage.TrackPersonPanelVitalInfoAllergiesText;
                this.TrackPersonPanelVitalInfoMedicationsText = appLanguage.TrackPersonPanelVitalInfoMedicationsText;
                #endregion

                #region Notification Settings Panel
                this.NotificationSettingsPanelBackCommandText = appLanguage.NotificationSettingsPanelBackCommandText;
                this.NotificationSettingsPanelTitleText = appLanguage.NotificationSettingsPanelTitleText;
                this.NotificationSettingsPanelNotificationsLabelText = appLanguage.NotificationSettingsPanelNotificationsLabelText;
                this.NotificationSettingsPanelNotificationStyleLabelText = appLanguage.NotificationSettingsPanelNotificationStyleLabelText;
                this.NotificationSettingsPanelBeAHeroItemText = appLanguage.NotificationSettingsPanelBeAHeroItemText;
                this.NotificationSettingsPanelReceiveSafetyTipsItemText = appLanguage.NotificationSettingsPanelReceiveSafetyTipsItemText;
                this.NotificationSettingsPanelYouTrackInTroubleItemText = appLanguage.NotificationSettingsPanelYouTrackInTroubleItemText;
                this.NotificationSettingsPanelContactInTroubleItemText = appLanguage.NotificationSettingsPanelContactInTroubleItemText;
                this.NotificationSettingsPanelContactInBadSituationItemText = appLanguage.NotificationSettingsPanelContactInBadSituationItemText;
                this.NotificationSettingsPanelNeedsYourHelpItemText = appLanguage.NotificationSettingsPanelNeedsYourHelpItemText;
                this.NotificationSettingsPanelOtherNotificationItemText = appLanguage.NotificationSettingsPanelOtherNotificationItemText;
                this.NotificationSettingsPanelGetAlertsItemText = appLanguage.NotificationSettingsPanelGetAlertsItemText;
                this.NotificationSettingsPanelGetAlertsTrackItemText = appLanguage.NotificationSettingsPanelGetAlertsTrackItemText;
                this.NotificationSettingsPanelGetSafetyTipsItemText = appLanguage.NotificationSettingsPanelGetSafetyTipsItemText;
                this.NotificationSettingsPanelContactInYeallowAlertItemText = appLanguage.NotificationSettingsPanelContactInYeallowAlertItemText;
                #endregion

                #region Notification Settings Set Panel
                this.NotificationSettingsSetPanelTitleText = appLanguage.NotificationSettingsSetPanelTitleText;
                this.NotificationSettingsSetPanelBackCommandText = appLanguage.NotificationSettingsSetPanelBackCommandText;
                this.NotificationSettingsSetPanelTopInfoText = appLanguage.NotificationSettingsSetPanelTopInfoText;
                this.NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText = appLanguage.NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText;
                this.NotificationSettingsSetPanelRingVibrateNotificationLabelText = appLanguage.NotificationSettingsSetPanelRingVibrateNotificationLabelText;
                this.NotificationSettingsSetPanelVibrateNotificationLabelText = appLanguage.NotificationSettingsSetPanelVibrateNotificationLabelText;
                this.NotificationSettingsSetPanelNotificationLabelText = appLanguage.NotificationSettingsSetPanelNotificationLabelText;
                #endregion

                #region Verify Email Panel
                this.VerifyEmailPanelTitleText = appLanguage.VerifyEmailPanelTitleText;
                this.VerifyEmailPanelBackCommandText = appLanguage.VerifyEmailPanelBackCommandText;
                this.VerifyEmailPanelTopInfoText = appLanguage.VerifyEmailPanelTopInfoText;
                this.VerifyEmailPanelEmailLabelText = appLanguage.VerifyEmailPanelEmailLabelText;
                this.VerifyEmailPanelResendEmailButtonText = appLanguage.VerifyEmailPanelResendEmailButtonText;
                #endregion

                #region Upgrade To Panel
                this.UpgradeToPanelSilverTitleText = appLanguage.UpgradeToPanelSilverTitleText;
                this.UpgradeToPanelGoldTitleText = appLanguage.UpgradeToPanelGoldTitleText;
                this.UpgradeToPanelBackCommandText = appLanguage.UpgradeToPanelBackCommandText;
                this.UpgradeToPanelRegularText = appLanguage.UpgradeToPanelRegularText;
                this.UpgradeToPanelStudentText = appLanguage.UpgradeToPanelStudentText;
                this.UpgradeToPanelPremiumSilverLabelText = appLanguage.UpgradeToPanelPremiumSilverLabelText;
                this.UpgradeToPanelPremiumGoldLabelText = appLanguage.UpgradeToPanelPremiumGoldLabelText;
                this.UpgradeToPanelMonthlySubscribtionText = appLanguage.UpgradeToPanelMonthlySubscribtionText;
                this.UpgradeToPanelYearlySubscribtionText = appLanguage.UpgradeToPanelYearlySubscribtionText;
                this.UpgradeToPanelDiscountCodeLabelText = appLanguage.UpgradeToPanelDiscountCodeLabelText;
                this.UpgradeToPanelDiscountCodePlaceholderText = appLanguage.UpgradeToPanelDiscountCodePlaceholderText;
                this.UpgradeToPanelDiscountCodeNiceText = appLanguage.UpgradeToPanelDiscountCodeNiceText;
                this.UpgradeToPanelContinueButtonText = appLanguage.UpgradeToPanelContinueButtonText;
                this.UpgradeToPanelUpgradeToGold = appLanguage.UpgradeToPanelUpgradeToGold;
                this.UpgradeToPanelAnnualSubscribtionText = appLanguage.UpgradeToPanelAnnualSubscribtionText;
                #endregion

                #region Ringtone Panel
                this.RingtonePanelBackCommandText = appLanguage.RingtonePanelBackCommandText;
                this.RingtonePanelTitleText = appLanguage.RingtonePanelTitleText;
                #endregion

                #region Check Out Panel
                this.CheckOutPanelTitleText = appLanguage.CheckOutPanelTitleText;
                this.CheckOutPanelBackButtonText = appLanguage.CheckOutPanelBackButtonText;
                this.CheckOutPanelTaxText = appLanguage.CheckOutPanelTaxText;
                this.CheckOutPanelTotalText = appLanguage.CheckOutPanelTotalText;
                this.CheckOutPanelGiftTheAppButtonText = appLanguage.CheckOutPanelGiftTheAppButtonText;
                this.CheckOutPanelCheckOutButtonText = appLanguage.CheckOutPanelCheckOutButtonText;
                #endregion

                #region Gift The App Panel
                this.GiftTheAppPanelTitleText = appLanguage.GiftTheAppPanelTitleText;
                this.GiftTheAppPanelBackButtonText = appLanguage.GiftTheAppPanelBackButtonText;
                this.GiftTheAppPanelGiftToText = appLanguage.GiftTheAppPanelGiftToText;
                this.GiftTheAppPanelPremiumSilverLabelText = appLanguage.GiftTheAppPanelPremiumSilverLabelText;
                this.GiftTheAppPanelSilverMonthlySubscriptionText = appLanguage.GiftTheAppPanelSilverMonthlySubscriptionText;
                this.GiftTheAppPanelSilverYearlySubscriptionText = appLanguage.GiftTheAppPanelSilverYearlySubscriptionText;
                this.GiftTheAppPanelPremiumGoldLabelText = appLanguage.GiftTheAppPanelPremiumGoldLabelText;
                this.GiftTheAppPanelGoldMonthlySubscriptionText = appLanguage.GiftTheAppPanelGoldMonthlySubscriptionText;
                this.GiftTheAppPanelGoldYearlySubscriptionText = appLanguage.GiftTheAppPanelGoldYearlySubscriptionText;
                this.GiftTheAppPanelContinueButtonText = appLanguage.GiftTheAppPanelContinueButtonText;
                this.GiftTheAppPanelAnnualSubscribtionText = appLanguage.GiftTheAppPanelAnnualSubscribtionText;
                #endregion

                #region Gift The App Start Panel
                this.GiftTheAppStartTitleText = appLanguage.GiftTheAppStartTitleText;
                this.GiftTheAppStartTopInfoText = appLanguage.GiftTheAppStartTopInfoText;
                this.GiftTheAppStartChooseWhoButtonText = appLanguage.GiftTheAppStartChooseWhoButtonText;
                #endregion

                #region Check Out Card Panel
                this.CheckOutCardPanelTitleText = appLanguage.CheckOutCardPanelTitleText;
                this.CheckOutCardPanelBackButtonText = appLanguage.CheckOutCardPanelBackButtonText;
                this.CheckOutCardPanelTopInfoText = appLanguage.CheckOutCardPanelTopInfoText;
                this.CheckOutCardPanelCardNumberLabelText = appLanguage.CheckOutCardPanelCardNumberLabelText;
                this.CheckOutCardPanelCardNumberPlaceholderText = appLanguage.CheckOutCardPanelCardNumberPlaceholderText;
                this.CheckOutCardPanelFullNameLabelText = appLanguage.CheckOutCardPanelFullNameLabelText;
                this.CheckOutCardPanelFullNamePlaceholderText = appLanguage.CheckOutCardPanelFullNamePlaceholderText;
                this.CheckOutCardPanelExpirationDateLabelText = appLanguage.CheckOutCardPanelExpirationDateLabelText;
                this.CheckOutCardPanelExpirationDatePlaceholderText = appLanguage.CheckOutCardPanelExpirationDatePlaceholderText;
                this.CheckOutCardPanelCVCLabelText = appLanguage.CheckOutCardPanelCVCLabelText;
                this.CheckOutCardPanelCVCPlaceholderText = appLanguage.CheckOutCardPanelCVCPlaceholderText;
                this.CheckOutCardPanelPurchaseSubscribtionButtonText = appLanguage.CheckOutCardPanelPurchaseSubscribtionButtonText;
                #endregion

                #region Set Tracking Zone Panel
                this.SetTrackingZonePanelBackCommandText = appLanguage.SetTrackingZonePanelBackCommandText;
                this.SetTrackingZonePanelTitleText = appLanguage.SetTrackingZonePanelTitleText;
                this.SetTrackingZonePanelSaveCommandText = appLanguage.SetTrackingZonePanelSaveCommandText;
                this.SetTrackingZonePanelSearchLocationText = appLanguage.SetTrackingZonePanelSearchLocationText;
                this.SetTrackingZonePanelLocationNameText = appLanguage.SetTrackingZonePanelLocationNameText;
                this.SetTrackingZonePanelNotifyWhenText = appLanguage.SetTrackingZonePanelNotifyWhenText;
                this.SetTrackingZonePanelArrivesText = appLanguage.SetTrackingZonePanelArrivesText;
                this.SetTrackingZonePanelLeavesText = appLanguage.SetTrackingZonePanelLeavesText;
                this.SetTrackingZonePanelDeleteCommandText = appLanguage.SetTrackingZonePanelDeleteCommandText;
                #endregion

                #region Share Your Location Panel
                this.ShareYourLocationPanelTitleText = appLanguage.ShareYourLocationPanelTitleText;
                this.ShareYourLocationPanelBackCommandText = appLanguage.ShareYourLocationPanelBackCommandText;
                this.ShareYourLocationPanelTopInfoText = appLanguage.ShareYourLocationPanelTopInfoText;
                this.ShareViewLocationPanelYesButtonText = appLanguage.ShareViewLocationPanelYesButtonText;
                this.ShareViewLocationPanelNoButtonText = appLanguage.ShareViewLocationPanelNoButtonText;
                this.ShareViewLocationPanelBottomInfoText = appLanguage.ShareViewLocationPanelBottomInfoText;
                this.ShareViewLocationPanelPendingApprovalText = appLanguage.ShareViewLocationPanelPendingApprovalText;
                this.ShareYourLocationPanelShareInfoText = appLanguage.ShareYourLocationPanelShareInfoText;
                this.ShareViewLocationPanelShareBottomInfoText = appLanguage.ShareViewLocationPanelShareBottomInfoText;
                #endregion

                #region Route Out Emergency Activated Panel
                this.RouteOutEmergencyActivatedPanelTitleText = appLanguage.RouteOutEmergencyActivatedPanelTitleText;
                this.RouteOutEmergencyActivatedPanelTopInfoText = appLanguage.RouteOutEmergencyActivatedPanelTopInfoText;
                this.RouteOutEmergencyActivatedPanelSendingText = appLanguage.RouteOutEmergencyActivatedPanelSendingText;
                this.RouteOutEmergencyActivatedPanelSecondsTemplate = appLanguage.RouteOutEmergencyActivatedPanelSecondsTemplate;
                this.RouteOutEmergencyActivatedPanelPasscodeText = appLanguage.RouteOutEmergencyActivatedPanelPasscodeText;
                #endregion

                #region Add New Route Panel
                this.AddNewRoutePanelHeaderText = appLanguage.AddNewRoutePanelHeaderText;
                this.AddNewRoutePanelNewEditText = appLanguage.AddNewRoutePanelNewEditText;
                this.AddNewRoutePanelNewEditContentText = appLanguage.AddNewRoutePanelNewEditContentText;
                this.AddNewRoutePanelGenerateEditText = appLanguage.AddNewRoutePanelGenerateEditText;
                this.AddNewRoutePanelRecordText = appLanguage.AddNewRoutePanelRecordText;
                this.AddNewRoutePanelGenerateEditContentText = appLanguage.AddNewRoutePanelGenerateEditContentText;
                this.AddNewRoutePanelRecordContentText = appLanguage.AddNewRoutePanelRecordContentText;
                #endregion

                #region EditRouteNameDialog
                this.EditRouteNameDialogTitleText = appLanguage.EditRouteNameDialogTitleText;
                this.EditRouteNameDialogNamePlaceholderText = appLanguage.EditRouteNameDialogNamePlaceholderText;
                this.EditRouteNameDialogCancelButtonText = appLanguage.EditRouteNameDialogCancelButtonText;
                this.EditRouteNameDialogSaveButtonText = appLanguage.EditRouteNameDialogSaveButtonText;
                #endregion

                #region EditSpeedLimitDialog
                this.EditSpeedLimitDialogTitleText = appLanguage.EditSpeedLimitDialogTitleText;
                this.EditSpeedLimitDialogSpeedLimitPlaceholderText = appLanguage.EditSpeedLimitDialogSpeedLimitPlaceholderText;
                this.EditSpeedLimitDialogCancelButtonText = appLanguage.EditSpeedLimitDialogCancelButtonText;
                this.EditSpeedLimitDialogSaveButtonText = appLanguage.EditRouteNameDialogSaveButtonText;
                #endregion

                #region EditPasswordDialog
                this.EditPasswordDialogTitleText = appLanguage.EditPasswordDialogTitleText;
                this.EditPasswordDialogPasscodePlaceholderText = appLanguage.EditPasswordDialogPasscodePlaceholderText;
                this.EditPasswordDialogCancelButtonText = appLanguage.EditPasswordDialogCancelButtonText;
                this.EditPasswordDialogOkButtonText = appLanguage.EditPasswordDialogOkButtonText;
                this.EditPasswordDialogForgotPasscodeButtonText = appLanguage.EditPasswordDialogForgotPasscodeButtonText;
                #endregion

                #region Saved Route Hide Panel
                this.SavedRouteHidePanelRouteName = appLanguage.SavedRouteHidePanelRouteName;
                this.SavedRouteHidePanelStartButtonText = appLanguage.SavedRouteHidePanelStartButtonText;
                #endregion

                #region Friends List Panel
                this.FriendsListPanelTitleText = appLanguage.FriendsListPanelTitleText;
                #endregion

                #region Lock Settings Panel
                this.LockSettingsPanelTitleText = appLanguage.LockSettingsPanelTitleText;
                this.LockSettingsPanelNextCommandText = appLanguage.LockSettingsPanelNextCommandText;
                this.LockSettingsPanelSettingsProtectedText = appLanguage.LockSettingsPanelSettingsProtectedText;
                this.LockSettingsPanelOldPasswordLabelText = appLanguage.LockSettingsPanelOldPasswordLabelText;
                this.LockSettingsPanelNewPasswordLabelText = appLanguage.LockSettingsPanelNewPasswordLabelText;
                this.LockSettingsPanelReenterPasswordLabelText = appLanguage.LockSettingsPanelReenterPasswordLabelText;
                this.LockSettingsPanelForgotPasscodeCommandText = appLanguage.LockSettingsPanelForgotPasscodeCommandText;
                #endregion

                #region Track Friends And Family Pane;
                this.TrackFriendsPanelTitleText = appLanguage.TrackFriendsPanelTitleText;
                this.TrackFriendsPanelYourPeopleLabelText = appLanguage.TrackFriendsPanelYourPeopleLabelText;
                this.TrackFriendsPanelPendingApproval = appLanguage.TrackFriendsPanelPendingApproval;
                this.TrackFriendsPanelAddPeopleCommandText = appLanguage.TrackFriendsPanelAddPeopleCommandText;
                #endregion

                #region Location Auto Complete Panel
                this.LocationAutoCompletePanelSearchLocationPlaceholderText = appLanguage.LocationAutoCompletePanelSearchLocationPlaceholderText;
                #endregion

                #region Incident Ended Panel
                this.IncidentEndedPanelTitleText = appLanguage.IncidentEndedPanelTitleText;
                this.IncidentEndedPanelTopInfoText = appLanguage.IncidentEndedPanelTopInfoText;
                this.IncidentEndedPanelEvidenceText = appLanguage.IncidentEndedPanelEvidenceText;
                this.IncidentEndedPanelRecordingText = appLanguage.IncidentEndedPanelRecordingText;
                this.IncidentEndedPanelSendButtonText = appLanguage.IncidentEndedPanelSendButtonText;
                this.IncidentEndedPanelSendCommandText = appLanguage.IncidentEndedPanelSendCommandText;
                this.IncidentEndedPanelWhatHappenedLabelText = appLanguage.IncidentEndedPanelWhatHappenedLabelText;
                #endregion

                #region Help Person Panel
                this.HelpPersonPanelCurrentLocationTitleText = appLanguage.HelpPersonPanelCurrentLocationTitleText;
                this.HelpPersonPanelSecondsFormatText = appLanguage.HelpPersonPanelSecondsFormatText;
                this.HelpPersonPanelMinutesFormatText = appLanguage.HelpPersonPanelMinutesFormatText;
                this.HelpPersonPanelInfoFormatText = appLanguage.HelpPersonPanelInfoFormatText;
                this.HelpPersonPanelOnMyWayText = appLanguage.HelpPersonPanelOnMyWayText;
                this.HelpPersonPanelEventHasEndedText = appLanguage.HelpPersonPanelEventHasEndedText;
                this.HelpPersonPanelCallPoliceText = appLanguage.HelpPersonPanelCallPoliceText;
                this.HelpPersonPanelEndCallText = appLanguage.HelpPersonPanelEndCallText;
                this.HelpPersonPanelVitalInfoLabelText = appLanguage.HelpPersonPanelVitalInfoLabelText;
                this.HelpPersonPanelNameLabelText = appLanguage.HelpPersonPanelNameLabelText;
                this.HelpPersonPanelAgeLabelText = appLanguage.HelpPersonPanelAgeLabelText;
                this.HelpPersonPanelSexLabelText = appLanguage.HelpPersonPanelSexLabelText;
                this.HelpPersonPanelHeightLabelText = appLanguage.HelpPersonPanelHeightLabelText;
                this.HelpPersonPanelEthnicityLabelText = appLanguage.HelpPersonPanelEthnicityLabelText;
                this.HelpPersonPanelHairColorLabelText = appLanguage.HelpPersonPanelHairColorLabelText;
                this.HelpPersonPanelAllergiesLabelText = appLanguage.HelpPersonPanelAllergiesLabelText;
                this.HelpPersonPanelMedicationsLabelText = appLanguage.HelpPersonPanelMedicationsLabelText;
                #endregion

                #region Person At Incident Panel
                this.PersonAtIncidentPanelTopInfoText = appLanguage.PersonAtIncidentPanelTopInfoText;
                this.PersonAtIncidentPanelCurrentLocationTitleText = appLanguage.PersonAtIncidentPanelCurrentLocationTitleText;
                this.PersonAtIncidentPanelSecondsFormatText = appLanguage.PersonAtIncidentPanelSecondsFormatText;
                this.PersonAtIncidentPanelMinutesFormatText = appLanguage.PersonAtIncidentPanelMinutesFormatText;
                this.PersonAtIncidentPanelInfoFormatText = appLanguage.PersonAtIncidentPanelInfoFormatText;
                this.PersonAtIncidentPanelEventHasEndedText = appLanguage.PersonAtIncidentPanelEventHasEndedText;
                this.PersonAtIncidentPanelCallPoliceText = appLanguage.PersonAtIncidentPanelCallPoliceText;
                this.PersonAtIncidentPanelEndCallText = appLanguage.PersonAtIncidentPanelEndCallText;
                this.PersonAtIncidentPanelVitalInfoLabelText = appLanguage.PersonAtIncidentPanelVitalInfoLabelText;
                this.PersonAtIncidentPanelNameLabelText = appLanguage.PersonAtIncidentPanelNameLabelText;
                this.PersonAtIncidentPanelAgeLabelText = appLanguage.PersonAtIncidentPanelAgeLabelText;
                this.PersonAtIncidentPanelSexLabelText = appLanguage.PersonAtIncidentPanelSexLabelText;
                this.PersonAtIncidentPanelHeightLabelText = appLanguage.PersonAtIncidentPanelHeightLabelText;
                this.PersonAtIncidentPanelEthnicityLabelText = appLanguage.PersonAtIncidentPanelEthnicityLabelText;
                this.PersonAtIncidentPanelHairColorLabelText = appLanguage.PersonAtIncidentPanelHairColorLabelText;
                this.PersonAtIncidentPanelAllergiesLabelText = appLanguage.PersonAtIncidentPanelAllergiesLabelText;
                this.PersonAtIncidentPanelMedicationsLabelText = appLanguage.PersonAtIncidentPanelMedicationsLabelText;
                #endregion

                #region Verify Email Popup panel
                this.VerifyEmailPopupPanelTitleText = appLanguage.VerifyEmailPopupPanelTitleText;
                this.VerifyEmailPopupPanelInfoText = appLanguage.VerifyEmailPopupPanelInfoText;
                this.VerifyEmailPopupPanelGotItButtonText = appLanguage.VerifyEmailPopupPanelGotItButtonText;
                #endregion

                #region Contacts Info Panel
                this.ContactsInfoPanelPendingApprovalText = appLanguage.ContactsInfoPanelPendingApprovalText;
                this.ContactsInfoPanelLocationSharingPauseText = appLanguage.ContactsInfoPanelLocationSharingPauseText;
                this.ContactsInfoPanelPermissionGrantedText = appLanguage.ContactsInfoPanelPermissionGrantedText;
                #endregion

                #region Blocked People Page
                this.BlockedPeoplePageTitleText = appLanguage.BlockedPeoplePageTitleText;
                this.BlockedPeoplePageTopInfoText = appLanguage.BlockedPeoplePageTopInfoText;
                this.BlockedPeoplePageFirstNameLabelText = appLanguage.BlockedPeoplePageFirstNameLabelText;
                this.BlockedPeoplePageLastNameLabelText = appLanguage.BlockedPeoplePageLastNameLabelText;
                this.BlockedPeoplePageEmailLabelText = appLanguage.BlockedPeoplePageEmailLabelText;
                this.BlockedPeoplePagePhoneLabelText = appLanguage.BlockedPeoplePagePhoneLabelText;
                this.BlockedPeoplePageBlockButtonText = appLanguage.BlockedPeoplePageBlockButtonText;
                this.BlockedPeoplePageUnblockButtonText = appLanguage.BlockedPeoplePageUnblockButtonText;
                this.BlockedPeoplePageAddPersonCommandText = appLanguage.BlockedPeoplePageAddPersonCommandText;
                #endregion
            }
        }

        public string DisplayName { get; private set; }

        public string AppName
        {
            get { return (string)this.GetValue("AppName"); }
            set { this.SetValue("AppName", value); }
        }

        #region Alert Dialog strings
        public string AlertDialogOKAnswerText
        {
            get { return (string)this.GetValue("AlertDialogOKAnswerText"); }
            set { this.SetValue("AlertDialogOKAnswerText", value); }
        }

        public string AlertDialogYesAnswerText
        {
            get { return (string)this.GetValue("AlertDialogYesAnswerText"); }
            set { this.SetValue("AlertDialogYesAnswerText", value); }
        }

        public string AlertDialogNoAnswerText
        {
            get { return (string)this.GetValue("AlertDialogNoAnswerText"); }
            set { this.SetValue("AlertDialogNoAnswerText", value); }
        }

        public string AlertDialogRemoveEmergencyContactTitleText
        {
            get { return (string)this.GetValue("AlertDialogRemoveEmergencyContactTitleText"); }
            set { this.SetValue("AlertDialogRemoveEmergencyContactTitleText", value); }
        }

        public string AlertDialogRemoveEmergencyContectMessageText
        {
            get { return (string)this.GetValue("AlertDialogRemoveEmergencyContectMessageText"); }
            set { this.SetValue("AlertDialogRemoveEmergencyContectMessageText", value); }
        }

        public string AlertDialogPrimaryEmergencyContactMessageText
        {
            get { return (string)this.GetValue("AlertDialogPrimaryEmergencyContactMessageText"); }
            set { this.SetValue("AlertDialogPrimaryEmergencyContactMessageText", value); }
        }

        public string AlertDialogPrivateDataAcknowledgmentTitleText
        {
            get { return (string)this.GetValue("AlertDialogPrivateDataAcknowledgmentTitleText"); }
            set { this.SetValue("AlertDialogPrivateDataAcknowledgmentTitleText", value); }
        }

        public string AlertDialogPrivateDataAcknowledgmentMessageText
        {
            get { return (string)this.GetValue("AlertDialogPrivateDataAcknowledgmentMessageText"); }
            set { this.SetValue("AlertDialogPrivateDataAcknowledgmentMessageText", value); }
        }

        public string AlertDialogPrivateDataAcknowledgmentDeclineAnswerText
        {
            get { return (string)this.GetValue("AlertDialogPrivateDataAcknowledgmentDeclineAnswerText"); }
            set { this.SetValue("AlertDialogPrivateDataAcknowledgmentDeclineAnswerText", value); }
        }

        public string AlertDialogPrivateDataAcknowledgmentAgreeAnswerText
        {
            get { return (string)this.GetValue("AlertDialogPrivateDataAcknowledgmentAgreeAnswerText"); }
            set { this.SetValue("AlertDialogPrivateDataAcknowledgmentAgreeAnswerText", value); }
        }

        public string AlertDialogSendYouNotificationsTitleText
        {
            get { return (string)this.GetValue("AlertDialogSendYouNotificationsTitleText"); }
            set { this.SetValue("AlertDialogSendYouNotificationsTitleText", value); }
        }

        public string AlertDialogSendYouNotificationsMessageText
        {
            get { return (string)this.GetValue("AlertDialogSendYouNotificationsMessageText"); }
            set { this.SetValue("AlertDialogSendYouNotificationsMessageText", value); }
        }

        public string AlertDialogSendYouNotificationsDontAllowAnswerText
        {
            get { return (string)this.GetValue("AlertDialogSendYouNotificationsDontAllowAnswerText"); }
            set { this.SetValue("AlertDialogSendYouNotificationsDontAllowAnswerText", value); }
        }

        public string AlertDialogSendYouNotificationsAllowAnswerText
        {
            get { return (string)this.GetValue("AlertDialogSendYouNotificationsAllowAnswerText"); }
            set { this.SetValue("AlertDialogSendYouNotificationsAllowAnswerText", value); }
        }

        public string AlertDialogSubscriptionTermsTitleText
        {
            get { return (string)this.GetValue("AlertDialogSubscriptionTermsTitleText"); }
            set { this.SetValue("AlertDialogSubscriptionTermsTitleText", value); }
        }

        public string AlertDialogSubscriptionTermsMessageText
        {
            get { return (string)this.GetValue("AlertDialogSubscriptionTermsMessageText"); }
            set { this.SetValue("AlertDialogSubscriptionTermsMessageText", value); }
        }

        public string AlertDialogSubscriptionTermsCancelAnswerText
        {
            get { return (string)this.GetValue("AlertDialogSubscriptionTermsCancelAnswerText"); }
            set { this.SetValue("AlertDialogSubscriptionTermsCancelAnswerText", value); }
        }

        public string AlertDialogSubscriptionTermsContinueAnswerText
        {
            get { return (string)this.GetValue("AlertDialogSubscriptionTermsContinueAnswerText"); }
            set { this.SetValue("AlertDialogSubscriptionTermsContinueAnswerText", value); }
        }

        public string AlertDialogConfirmSubscriptionTitleText
        {
            get { return (string)this.GetValue("AlertDialogConfirmSubscriptionTitleText"); }
            set { this.SetValue("AlertDialogConfirmSubscriptionTitleText", value); }
        }

        public string AlertDialogConfirmSubscriptionMessageText
        {
            get { return (string)this.GetValue("AlertDialogConfirmSubscriptionMessageText"); }
            set { this.SetValue("AlertDialogConfirmSubscriptionMessageText", value); }
        }

        public string AlertDialogConfirmSubscriptionCancelAnswerText
        {
            get { return (string)this.GetValue("AlertDialogConfirmSubscriptionCancelAnswerText"); }
            set { this.SetValue("AlertDialogConfirmSubscriptionCancelAnswerText", value); }
        }

        public string AlertDialogConfirmSubscriptionOKAnswerText
        {
            get { return (string)this.GetValue("AlertDialogConfirmSubscriptionOKAnswerText"); }
            set { this.SetValue("AlertDialogConfirmSubscriptionOKAnswerText", value); }
        }

        public string AlertDialogCurrentlySubscribedTitleText
        {
            get { return (string)this.GetValue("AlertDialogCurrentlySubscribedTitleText"); }
            set { this.SetValue("AlertDialogCurrentlySubscribedTitleText", value); }
        }

        public string AlertDialogCurrentlySubscribedMessageText
        {
            get { return (string)this.GetValue("AlertDialogCurrentlySubscribedMessageText"); }
            set { this.SetValue("AlertDialogCurrentlySubscribedMessageText", value); }
        }

        public string AlertDialogCurrentlySubscribedManageAnswerText
        {
            get { return (string)this.GetValue("AlertDialogCurrentlySubscribedManageAnswerText"); }
            set { this.SetValue("AlertDialogCurrentlySubscribedManageAnswerText", value); }
        }

        public string AlertDialogCurrentlySubscribedOKAnswerText
        {
            get { return (string)this.GetValue("AlertDialogCurrentlySubscribedOKAnswerText"); }
            set { this.SetValue("AlertDialogCurrentlySubscribedOKAnswerText", value); }
        }

        public string AlertDialogCancelPremiumAccountTitleText
        {
            get { return (string)this.GetValue("AlertDialogCancelPremiumAccountTitleText"); }
            set { this.SetValue("AlertDialogCancelPremiumAccountTitleText", value); }
        }

        public string AlertDialogCancelPremiumAccountMessageText
        {
            get { return (string)this.GetValue("AlertDialogCancelPremiumAccountMessageText"); }
            set { this.SetValue("AlertDialogCancelPremiumAccountMessageText", value); }
        }

        public string AlertDialogCancelPremiumAccountNevermindAnswerText
        {
            get { return (string)this.GetValue("AlertDialogCancelPremiumAccountNevermindAnswerText"); }
            set { this.SetValue("AlertDialogCancelPremiumAccountNevermindAnswerText", value); }
        }

        public string AlertDialogCancelPremiumAccountYesAnswerText
        {
            get { return (string)this.GetValue("AlertDialogCancelPremiumAccountYesAnswerText"); }
            set { this.SetValue("AlertDialogCancelPremiumAccountYesAnswerText", value); }
        }

        public string AlertDialogAccessMicrophoneTitleText
        {
            get { return (string)this.GetValue("AlertDialogAccessMicrophoneTitleText"); }
            set { this.SetValue("AlertDialogAccessMicrophoneTitleText", value); }
        }

        public string AlertDialogAccessMicrophoneMessageText
        {
            get { return (string)this.GetValue("AlertDialogAccessMicrophoneMessageText"); }
            set { this.SetValue("AlertDialogAccessMicrophoneMessageText", value); }
        }

        public string AlertDialogAccessMicrophoneDontAllowAnswerText
        {
            get { return (string)this.GetValue("AlertDialogAccessMicrophoneDontAllowAnswerText"); }
            set { this.SetValue("AlertDialogAccessMicrophoneDontAllowAnswerText", value); }
        }

        public string AlertDialogAccessMicrophoneOKAnswerText
        {
            get { return (string)this.GetValue("AlertDialogAccessMicrophoneOKAnswerText"); }
            set { this.SetValue("AlertDialogAccessMicrophoneOKAnswerText", value); }
        }

        public string AlertDialogEmergencyForgotPasswordTitleText
        {
            get { return (string)this.GetValue("AlertDialogEmergencyForgotPasswordTitleText"); }
            set { this.SetValue("AlertDialogEmergencyForgotPasswordTitleText", value); }
        }

        public string AlertDialogEmergencyForgotPasswordMessageText
        {
            get { return (string)this.GetValue("AlertDialogEmergencyForgotPasswordMessageText"); }
            set { this.SetValue("AlertDialogEmergencyForgotPasswordMessageText", value); }
        }

        public string AlertDialogEmergencyForgotPasswordOKAnswerText
        {
            get { return (string)this.GetValue("AlertDialogEmergencyForgotPasswordOKAnswerText"); }
            set { this.SetValue("AlertDialogEmergencyForgotPasswordOKAnswerText", value); }
        }

        public string AlertDialogEmergencyForgotPasswordCancelAnswerText
        {
            get { return (string)this.GetValue("AlertDialogEmergencyForgotPasswordCancelAnswerText"); }
            set { this.SetValue("AlertDialogEmergencyForgotPasswordCancelAnswerText", value); }
        }

        public string AlertDialogNotPremiumMemberTitleText
        {
            get { return (string)this.GetValue("AlertDialogNotPremiumMemberTitleText"); }
            set { this.SetValue("AlertDialogNotPremiumMemberTitleText", value); }
        }

        public string AlertDialogNotPremiumMemberMessageText
        {
            get { return (string)this.GetValue("AlertDialogNotPremiumMemberMessageText"); }
            set { this.SetValue("AlertDialogNotPremiumMemberMessageText", value); }
        }

        public string AlertDialogNotPremiumMemberGetPremiumAnswerText
        {
            get { return (string)this.GetValue("AlertDialogNotPremiumMemberGetPremiumAnswerText"); }
            set { this.SetValue("AlertDialogNotPremiumMemberGetPremiumAnswerText", value); }
        }

        public string AlertDialogNotPremiumMemberCancelAnswerText
        {
            get { return (string)this.GetValue("AlertDialogNotPremiumMemberCancelAnswerText"); }
            set { this.SetValue("AlertDialogNotPremiumMemberCancelAnswerText", value); }
        }
        #endregion

        #region Select Photo Action Sheet
        public string SelectPhotoActionSheetTitleText
        {
            get { return (string)this.GetValue("SelectPhotoActionSheetTitleText"); }
            set { this.SetValue("SelectPhotoActionSheetTitleText", value); }
        }

        public string SelectPhotoActionSheetCancelText
        {
            get { return (string)this.GetValue("SelectPhotoActionSheetCancelText"); }
            set { this.SetValue("SelectPhotoActionSheetCancelText", value); }
        }

        public string SelectPhotoActionSheetFromCameraText
        {
            get { return (string)this.GetValue("SelectPhotoActionSheetFromCameraText"); }
            set { this.SetValue("SelectPhotoActionSheetFromCameraText", value); }
        }

        public string SelectPhotoActionSheetFromGalleryText
        {
            get { return (string)this.GetValue("SelectPhotoActionSheetFromGalleryText"); }
            set { this.SetValue("SelectPhotoActionSheetFromGalleryText", value); }
        }
        #endregion

        #region Select Blocked People Action Sheet
        public string SelectBlockedPeopleActionSheetTitleText
        {
            get { return (string)this.GetValue("SelectBlockedPeopleActionSheetTitleText"); }
            set { this.SetValue("SelectBlockedPeopleActionSheetTitleText", value); }
        }

        public string SelectBlockedPeopleActionSheetCancelText
        {
            get { return (string)this.GetValue("SelectBlockedPeopleActionSheetCancelText"); }
            set { this.SetValue("SelectBlockedPeopleActionSheetCancelText", value); }
        }

        public string SelectBlockedPeopleActionSheetSelectContactText
        {
            get { return (string)this.GetValue("SelectBlockedPeopleActionSheetSelectContactText"); }
            set { this.SetValue("SelectBlockedPeopleActionSheetSelectContactText", value); }
        }

        public string SelectBlockedPeopleActionSheetManualInputText
        {
            get { return (string)this.GetValue("SelectBlockedPeopleActionSheetManualInputText"); }
            set { this.SetValue("SelectBlockedPeopleActionSheetManualInputText", value); }
        }
        #endregion

        #region Picker titles
        public string SelectGenderPickerTitleText
        {
            get { return (string)this.GetValue("SelectGenderPickerTitleText"); }
            set { this.SetValue("SelectGenderPickerTitleText", value); }
        }

        public string SelectHeightPickerTitleText
        {
            get { return (string)this.GetValue("SelectHeightPickerTitleText"); }
            set { this.SetValue("SelectHeightPickerTitleText", value); }
        }

        public string SelectWeightPickerTitleText
        {
            get { return (string)this.GetValue("SelectWeightPickerTitleText"); }
            set { this.SetValue("SelectWeightPickerTitleText", value); }
        }

        public string SelectHairColorPickerTitleText
        {
            get { return (string)this.GetValue("SelectHairColorPickerTitleText"); }
            set { this.SetValue("SelectHairColorPickerTitleText", value); }
        }

        public string SelectEyeColorPickerTitleText
        {
            get { return (string)this.GetValue("SelectEyeColorPickerTitleText"); }
            set { this.SetValue("SelectEyeColorPickerTitleText", value); }
        }

        public string SelectEthnicityPickerTitleText
        {
            get { return (string)this.GetValue("SelectEthnicityPickerTitleText"); }
            set { this.SetValue("SelectEthnicityPickerTitleText", value); }
        }

        public string SelectRelationPickerTitleText
        {
            get { return (string)this.GetValue("SelectRelationPickerTitleText"); }
            set { this.SetValue("SelectRelationPickerTitleText", value); }
        }

        public string SelectBirthDatePickerTitleText
        {
            get { return (string)this.GetValue("SelectBirthDatePickerTitleText"); }
            set { this.SetValue("SelectBirthDatePickerTitleText", value); }
        }
        #endregion

        #region Month Selector
        public string MonthSelectorJanuary
        {
            get { return (string)this.GetValue("MonthSelectorJanuary"); }
            set { this.SetValue("MonthSelectorJanuary", value); }
        }

        public string MonthSelectorFebruary
        {
            get { return (string)this.GetValue("MonthSelectorFebruary"); }
            set { this.SetValue("MonthSelectorFebruary", value); }
        }

        public string MonthSelectorMarch
        {
            get { return (string)this.GetValue("MonthSelectorMarch"); }
            set { this.SetValue("MonthSelectorMarch", value); }
        }

        public string MonthSelectorApril
        {
            get { return (string)this.GetValue("MonthSelectorApril"); }
            set { this.SetValue("MonthSelectorApril", value); }
        }

        public string MonthSelectorMay
        {
            get { return (string)this.GetValue("MonthSelectorMay"); }
            set { this.SetValue("MonthSelectorMay", value); }
        }

        public string MonthSelectorJune
        {
            get { return (string)this.GetValue("MonthSelectorJune"); }
            set { this.SetValue("MonthSelectorJune", value); }
        }

        public string MonthSelectorJuly
        {
            get { return (string)this.GetValue("MonthSelectorJuly"); }
            set { this.SetValue("MonthSelectorJuly", value); }
        }

        public string MonthSelectorAugust
        {
            get { return (string)this.GetValue("MonthSelectorAugust"); }
            set { this.SetValue("MonthSelectorAugust", value); }
        }

        public string MonthSelectorSeptember
        {
            get { return (string)this.GetValue("MonthSelectorSeptember"); }
            set { this.SetValue("MonthSelectorSeptember", value); }
        }

        public string MonthSelectorOctober
        {
            get { return (string)this.GetValue("MonthSelectorOctober"); }
            set { this.SetValue("MonthSelectorOctober", value); }
        }

        public string MonthSelectorNovember
        {
            get { return (string)this.GetValue("MonthSelectorNovember"); }
            set { this.SetValue("MonthSelectorNovember", value); }
        }

        public string MonthSelectorDecember
        {
            get { return (string)this.GetValue("MonthSelectorDecember"); }
            set { this.SetValue("MonthSelectorDecember", value); }
        }
        #endregion

        #region Genders strings
        public string GenderNotSelectedText
        {
            get { return (string)this.GetValue("GenderNotSelectedText"); }
            set { this.SetValue("GenderNotSelectedText", value); }
        }

        public string GenderMaleText
        {
            get { return (string)this.GetValue("GenderMaleText"); }
            set { this.SetValue("GenderMaleText", value); }
        }

        public string GenderFemaleText
        {
            get { return (string)this.GetValue("GenderFemaleText"); }
            set { this.SetValue("GenderFemaleText", value); }
        }
        #endregion

        #region Hair Color strings
        public string HairColorBald
        {
            get { return (string)this.GetValue("HairColorBald"); }
            set { this.SetValue("HairColorBald", value); }
        }

        public string HairColorBlack
        {
            get { return (string)this.GetValue("HairColorBlack"); }
            set { this.SetValue("HairColorBlack", value); }
        }

        public string HairColorBlonde
        {
            get { return (string)this.GetValue("HairColorBlonde"); }
            set { this.SetValue("HairColorBlonde", value); }
        }

        public string HairColorBlue
        {
            get { return (string)this.GetValue("HairColorBlue"); }
            set { this.SetValue("HairColorBlue", value); }
        }

        public string HairColorBrown
        {
            get { return (string)this.GetValue("HairColorBrown"); }
            set { this.SetValue("HairColorBrown", value); }
        }

        public string HairColorGreen
        {
            get { return (string)this.GetValue("HairColorGreen"); }
            set { this.SetValue("HairColorGreen", value); }
        }

        public string HairColorGray
        {
            get { return (string)this.GetValue("HairColorGray"); }
            set { this.SetValue("HairColorGray", value); }
        }

        public string HairColorOrange
        {
            get { return (string)this.GetValue("HairColorOrange"); }
            set { this.SetValue("HairColorOrange", value); }
        }

        public string HairColorPurple
        {
            get { return (string)this.GetValue("HairColorPurple"); }
            set { this.SetValue("HairColorPurple", value); }
        }

        public string HairColorPink
        {
            get { return (string)this.GetValue("HairColorPink"); }
            set { this.SetValue("HairColorPink", value); }
        }

        public string HairColorRed
        {
            get { return (string)this.GetValue(""); }
            set { this.SetValue("", value); }
        }

        public string HairColorSandy
        {
            get { return (string)this.GetValue("HairColorSandy"); }
            set { this.SetValue("HairColorSandy", value); }
        }

        public string HairColorWhite
        {
            get { return (string)this.GetValue("HairColorWhite"); }
            set { this.SetValue("HairColorWhite", value); }
        }
        #endregion

        #region Eye Color strings
        public string EyeColorBlack
        {
            get { return (string)this.GetValue("EyeColorBlack"); }
            set { this.SetValue("EyeColorBlack", value); }
        }

        public string EyeColorBlue
        {
            get { return (string)this.GetValue("EyeColorBlue"); }
            set { this.SetValue("EyeColorBlue", value); }
        }

        public string EyeColorBrown
        {
            get { return (string)this.GetValue("EyeColorBrown"); }
            set { this.SetValue("EyeColorBrown", value); }
        }

        public string EyeColorGray
        {
            get { return (string)this.GetValue("EyeColorGray"); }
            set { this.SetValue("EyeColorGray", value); }
        }

        public string EyeColorGreen
        {
            get { return (string)this.GetValue("EyeColorGreen"); }
            set { this.SetValue("EyeColorGreen", value); }
        }

        public string EyeColorHazel
        {
            get { return (string)this.GetValue("EyeColorHazel"); }
            set { this.SetValue("EyeColorHazel", value); }
        }

        public string EyeColorMaroon
        {
            get { return (string)this.GetValue("EyeColorMaroon"); }
            set { this.SetValue("EyeColorMaroon", value); }
        }
        #endregion

        #region Ethnicity Color strings
        public string EthnicityAsian
        {
            get { return (string)this.GetValue("EthnicityAsian"); }
            set { this.SetValue("EthnicityAsian", value); }
        }

        public string EthnicityBlack
        {
            get { return (string)this.GetValue("EthnicityBlack"); }
            set { this.SetValue("EthnicityBlack", value); }
        }

        public string EthnicityHispanic
        {
            get { return (string)this.GetValue("EthnicityHispanic"); }
            set { this.SetValue("EthnicityHispanic", value); }
        }

        public string EthnicityIndian
        {
            get { return (string)this.GetValue("EthnicityIndian"); }
            set { this.SetValue("EthnicityIndian", value); }
        }

        public string EthnicityMiddleEastern
        {
            get { return (string)this.GetValue("EthnicityMiddleEastern"); }
            set { this.SetValue("EthnicityMiddleEastern", value); }
        }

        public string EthnicityMultiracial
        {
            get { return (string)this.GetValue("EthnicityMultiracial"); }
            set { this.SetValue("EthnicityMultiracial", value); }
        }

        public string EthnicityWhite
        {
            get { return (string)this.GetValue("EthnicityWhite"); }
            set { this.SetValue("EthnicityWhite", value); }
        }
        #endregion

        #region Relation strings
        public string RelationFather
        {
            get { return (string)this.GetValue("RelationFather"); }
            set { this.SetValue("RelationFather", value); }
        }

        public string RelationMother
        {
            get { return (string)this.GetValue("RelationMother"); }
            set { this.SetValue("RelationMother", value); }
        }

        public string RelationBoyfriend
        {
            get { return (string)this.GetValue("RelationBoyfriend"); }
            set { this.SetValue("RelationBoyfriend", value); }
        }

        public string RelationDaughter
        {
            get { return (string)this.GetValue("RelationDaughter"); }
            set { this.SetValue("RelationDaughter", value); }
        }

        public string RelationFraternityBrother
        {
            get { return (string)this.GetValue("RelationFraternityBrother"); }
            set { this.SetValue("RelationFraternityBrother", value); }
        }

        public string RelationFriend
        {
            get { return (string)this.GetValue("RelationFriend"); }
            set { this.SetValue("RelationFriend", value); }
        }

        public string RelationGirlfriend
        {
            get { return (string)this.GetValue("RelationGirlfriend"); }
            set { this.SetValue("RelationGirlfriend", value); }
        }

        public string RelationHusband
        {
            get { return (string)this.GetValue("RelationHusband"); }
            set { this.SetValue("RelationHusband", value); }
        }

        public string RelationPartner
        {
            get { return (string)this.GetValue("RelationPartner"); }
            set { this.SetValue("RelationPartner", value); }
        }

        public string RelationSibling
        {
            get { return (string)this.GetValue("RelationSibling"); }
            set { this.SetValue("RelationSibling", value); }
        }

        public string RelationSon
        {
            get { return (string)this.GetValue("RelationSon"); }
            set { this.SetValue("RelationSon", value); }
        }

        public string RelationSororitySister
        {
            get { return (string)this.GetValue("RelationSororitySister"); }
            set { this.SetValue("RelationSororitySister", value); }
        }

        public string RelationWife
        {
            get { return (string)this.GetValue("RelationWife"); }
            set { this.SetValue("RelationWife", value); }
        }

        public string RelationOther
        {
            get { return (string)this.GetValue("RelationOther"); }
            set { this.SetValue("RelationOther", value); }
        }
        #endregion

        #region Map Directions
        public string MapDirectionsNorth
        {
            get { return (string)this.GetValue("MapDirectionsNorth"); }
            set { this.SetValue("MapDirectionsNorth", value); }
        }

        public string MapDirectionsNorthEast
        {
            get { return (string)this.GetValue("MapDirectionsNorthEast"); }
            set { this.SetValue("MapDirectionsNorthEast", value); }
        }

        public string MapDirectionsEast
        {
            get { return (string)this.GetValue("MapDirectionsEast"); }
            set { this.SetValue("MapDirectionsEast", value); }
        }

        public string MapDirectionsSouthEast
        {
            get { return (string)this.GetValue("MapDirectionsSouthEast"); }
            set { this.SetValue("MapDirectionsSouthEast", value); }
        }

        public string MapDirectionsSouth
        {
            get { return (string)this.GetValue("MapDirectionsSouth"); }
            set { this.SetValue("MapDirectionsSouth", value); }
        }

        public string MapDirectionsSouthWest
        {
            get { return (string)this.GetValue("MapDirectionsSouthWest"); }
            set { this.SetValue("MapDirectionsSouthWest", value); }
        }

        public string MapDirectionsWest
        {
            get { return (string)this.GetValue("MapDirectionsWest"); }
            set { this.SetValue("MapDirectionsWest", value); }
        }

        public string MapDirectionsNorthWest
        {
            get { return (string)this.GetValue("MapDirectionsNorthWest"); }
            set { this.SetValue("MapDirectionsNorthWest", value); }
        }
        #endregion

        #region Account Type Info View
        public string AccountTypeInfoViewTopInfoText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTopInfoText"); }
            set { this.SetValue("AccountTypeInfoViewTopInfoText", value); }
        }

        public string AccountTypeInfoViewFreeLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewFreeLabelText"); }
            set { this.SetValue("AccountTypeInfoViewFreeLabelText", value); }
        }

        public string AccountTypeInfoViewSilverLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSilverLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSilverLabelText", value); }
        }

        public string AccountTypeInfoViewGoldLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewGoldLabelText"); }
            set { this.SetValue("AccountTypeInfoViewGoldLabelText", value); }
        }

        public string AccountTypeInfoViewBeAHeroLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewBeAHeroLabelText"); }
            set { this.SetValue("AccountTypeInfoViewBeAHeroLabelText", value); }
        }

        public string AccountTypeInfoViewBeAHeroDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewBeAHeroDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewBeAHeroDescriptionText", value); }
        }

        public string AccountTypeInfoViewCallPoliceLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCallPoliceLabelText"); }
            set { this.SetValue("AccountTypeInfoViewCallPoliceLabelText", value); }
        }

        public string AccountTypeInfoViewCallPoliceDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCallPoliceDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewCallPoliceDescriptionText", value); }
        }

        public string AccountTypeInfoViewAlertEmergencyContactsLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAlertEmergencyContactsLabelText"); }
            set { this.SetValue("AccountTypeInfoViewAlertEmergencyContactsLabelText", value); }
        }

        public string AccountTypeInfoViewAlertEmergencyContactsDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAlertEmergencyContactsDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewAlertEmergencyContactsDescriptionText", value); }
        }

        public string AccountTypeInfoViewAlertCommunityRespondersLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAlertCommunityRespondersLabelText"); }
            set { this.SetValue("AccountTypeInfoViewAlertCommunityRespondersLabelText", value); }
        }

        public string AccountTypeInfoViewAlertCommunityRespondersDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAlertCommunityRespondersDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewAlertCommunityRespondersDescriptionText", value); }
        }

        public string AccountTypeInfoViewAudioVideoRecordingLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAudioVideoRecordingLabelText"); }
            set { this.SetValue("AccountTypeInfoViewAudioVideoRecordingLabelText", value); }
        }

        public string AccountTypeInfoViewAudioVideoRecordingDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewAudioVideoRecordingDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewAudioVideoRecordingDescriptionText", value); }
        }

        public string AccountTypeInfoViewActivateFlashlightLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewActivateFlashlightLabelText"); }
            set { this.SetValue("AccountTypeInfoViewActivateFlashlightLabelText", value); }
        }

        public string AccountTypeInfoViewActivateFlashlightDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewActivateFlashlightDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewActivateFlashlightDescriptionText", value); }
        }

        public string AccountTypeInfoViewPlanYourRoutesLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewPlanYourRoutesLabelText"); }
            set { this.SetValue("AccountTypeInfoViewPlanYourRoutesLabelText", value); }
        }

        public string AccountTypeInfoViewPlanYourRoutesDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewPlanYourRoutesDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewPlanYourRoutesDescriptionText", value); }
        }

        public string AccountTypeInfoViewTurnOnSirenLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTurnOnSirenLabelText"); }
            set { this.SetValue("AccountTypeInfoViewTurnOnSirenLabelText", value); }
        }

        public string AccountTypeInfoViewTurnOnSirenDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTurnOnSirenDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewTurnOnSirenDescriptionText", value); }
        }

        public string AccountTypeInfoViewSendMyLocationToPoliceLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSendMyLocationToPoliceLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSendMyLocationToPoliceLabelText", value); }
        }

        public string AccountTypeInfoViewSendMyLocationToPoliceDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSendMyLocationToPoliceDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewSendMyLocationToPoliceDescriptionText", value); }
        }

        public string AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText"); }
            set { this.SetValue("AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText", value); }
        }

        public string AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText", value); }
        }

        public string AccountTypeInfoViewTrackFriendsAndFamilyLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTrackFriendsAndFamilyLabelText"); }
            set { this.SetValue("AccountTypeInfoViewTrackFriendsAndFamilyLabelText", value); }
        }

        public string AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText", value); }
        }

        public string AccountTypeInfoViewCustomNotificationSoundsLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCustomNotificationSoundsLabelText"); }
            set { this.SetValue("AccountTypeInfoViewCustomNotificationSoundsLabelText", value); }
        }

        public string AccountTypeInfoViewCustomNotificationSoundsDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCustomNotificationSoundsDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewCustomNotificationSoundsDescriptionText", value); }
        }

        public string AccountTypeInfoViewSetTrackingZonesLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSetTrackingZonesLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSetTrackingZonesLabelText", value); }
        }

        public string AccountTypeInfoViewSetTrackingZonesDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSetTrackingZonesDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewSetTrackingZonesDescriptionText", value); }
        }

        public string AccountTypeInfoViewSaveVideoToTheCloudLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSaveVideoToTheCloudLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSaveVideoToTheCloudLabelText", value); }
        }

        public string AccountTypeInfoViewSaveVideoToTheCloudDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSaveVideoToTheCloudDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewSaveVideoToTheCloudDescriptionText", value); }
        }

        public string AccountTypeInfoViewFreeCostLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewFreeCostLabelText"); }
            set { this.SetValue("AccountTypeInfoViewFreeCostLabelText", value); }
        }

        public string AccountTypeInfoViewCostLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCostLabelText"); }
            set { this.SetValue("AccountTypeInfoViewCostLabelText", value); }
        }

        public string AccountTypeInfoViewBottomInfoText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewBottomInfoText"); }
            set { this.SetValue("AccountTypeInfoViewBottomInfoText", value); }
        }

        public string AccountTypeInfoViewBeACommunityResponderLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewBeACommunityResponderLabelText"); }
            set { this.SetValue("AccountTypeInfoViewBeACommunityResponderLabelText", value); }
        }

        public string AccountTypeInfoViewBeACommunityResponderDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewBeACommunityResponderDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewBeACommunityResponderDescriptionText", value); }
        }

        public string AccountTypeInfoViewMonthlyPriceLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewMonthlyPriceLabelText"); }
            set { this.SetValue("AccountTypeInfoViewMonthlyPriceLabelText", value); }
        }

        public string AccountTypeInfoViewStudentDiscountLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewStudentDiscountLabelText"); }
            set { this.SetValue("AccountTypeInfoViewStudentDiscountLabelText", value); }
        }

        public string AccountTypeInfoViewTrySilverLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewTrySilverLabelText"); }
            set { this.SetValue("AccountTypeInfoViewTrySilverLabelText", value); }
        }

        public string AccountTypeInfoViewSetSpeedNotificationLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSetSpeedNotificationLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSetSpeedNotificationLabelText", value); }
        }

        public string AccountTypeInfoViewCustomMapStylesLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCustomMapStylesLabelText"); }
            set { this.SetValue("AccountTypeInfoViewCustomMapStylesLabelText", value); }
        }

        public string AccountTypeInfoViewSatelliteViewLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSatelliteViewLabelText"); }
            set { this.SetValue("AccountTypeInfoViewSatelliteViewLabelText", value); }
        }

        public string AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText"); }
            set { this.SetValue("AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText", value); }
        }

        public string AccountTypeInfoViewOfflineMapsLabelText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewOfflineMapsLabelText"); }
            set { this.SetValue("AccountTypeInfoViewOfflineMapsLabelText", value); }
        }

        public string AccountTypeInfoViewOfflineMapsDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewOfflineMapsDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewOfflineMapsDescriptionText", value); }
        }

        public string AccountTypeInfoViewSetSpeedNotificationDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSetSpeedNotificationDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewSetSpeedNotificationDescriptionText", value); }
        }

        public string AccountTypeInfoViewCustomMapStylesDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewCustomMapStylesDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewCustomMapStylesDescriptionText", value); }
        }

        public string AccountTypeInfoViewSatelliteViewDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewSatelliteViewDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewSatelliteViewDescriptionText", value); }
        }

        public string AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText
        {
            get { return (string)this.GetValue("AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText"); }
            set { this.SetValue("AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText", value); }
        }
        #endregion

        #region Button Settings Info View
        public string ButtonSettingsInfoFeaturesLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoFeaturesLabelText"); }
            set { this.SetValue("ButtonSettingsInfoFeaturesLabelText", value); }
        }

        public string ButtonSettingsInfoFreeLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoFreeLabelText"); }
            set { this.SetValue("ButtonSettingsInfoFreeLabelText", value); }
        }

        public string ButtonSettingsInfoSilverLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoSilverLabelText"); }
            set { this.SetValue("ButtonSettingsInfoSilverLabelText", value); }
        }

        public string ButtonSettingsInfoCallPoliceLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoCallPoliceLabelText"); }
            set { this.SetValue("ButtonSettingsInfoCallPoliceLabelText", value); }
        }

        public string ButtonSettingsInfoCallPoliceDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoCallPoliceDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoCallPoliceDescriptionText", value); }
        }

        public string ButtonSettingsInfoAlertEmergencyContactsLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoAlertEmergencyContactsLabelText"); }
            set { this.SetValue("ButtonSettingsInfoAlertEmergencyContactsLabelText", value); }
        }

        public string ButtonSettingsInfoAlertEmergencyContactsDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoAlertEmergencyContactsDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoAlertEmergencyContactsDescriptionText", value); }
        }

        public string ButtonSettingsInfoAlertCommunityRespondersLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoAlertCommunityRespondersLabelText"); }
            set { this.SetValue("ButtonSettingsInfoAlertCommunityRespondersLabelText", value); }
        }

        public string ButtonSettingsInfoAlertCommunityRespondersDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoAlertCommunityRespondersDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoAlertCommunityRespondersDescriptionText", value); }
        }

        public string ButtonSettingsInfoRecordAudioAndVideoLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoRecordAudioAndVideoLabelText"); }
            set { this.SetValue("ButtonSettingsInfoRecordAudioAndVideoLabelText", value); }
        }

        public string ButtonSettingsInfoRecordAudioAndVideoDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoRecordAudioAndVideoDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoRecordAudioAndVideoDescriptionText", value); }
        }

        public string ButtonSettingsInfoActivateFlashlightLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoActivateFlashlightLabelText"); }
            set { this.SetValue("ButtonSettingsInfoActivateFlashlightLabelText", value); }
        }

        public string ButtonSettingsInfoActivateFlashlightDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoActivateFlashlightDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoActivateFlashlightDescriptionText", value); }
        }

        public string ButtonSettingsInfoTurnOnSirenLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoTurnOnSirenLabelText"); }
            set { this.SetValue("ButtonSettingsInfoTurnOnSirenLabelText", value); }
        }

        public string ButtonSettingsInfoTurnOnSirenDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoTurnOnSirenDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoTurnOnSirenDescriptionText", value); }
        }

        public string ButtonSettingsSendMyLocationToPoliceLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsSendMyLocationToPoliceLabelText"); }
            set { this.SetValue("ButtonSettingsSendMyLocationToPoliceLabelText", value); }
        }

        public string ButtonSettingsSendMyLocationToPoliceDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsSendMyLocationToPoliceDescriptionText"); }
            set { this.SetValue("ButtonSettingsSendMyLocationToPoliceDescriptionText", value); }
        }

        public string ButtonSettingsPanelSelectorLeftText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelSelectorLeftText"); }
            set { this.SetValue("ButtonSettingsPanelSelectorLeftText", value); }
        }

        public string ButtonSettingsPanelSelectorRightText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelSelectorRightText"); }
            set { this.SetValue("ButtonSettingsPanelSelectorRightText", value); }
        }

        public string ButtonSettingsInfoFreeFeaturesLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoFreeFeaturesLabelText"); }
            set { this.SetValue("ButtonSettingsInfoFreeFeaturesLabelText", value); }
        }

        public string ButtonSettingsInfoSilverFeaturesLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoSilverFeaturesLabelText"); }
            set { this.SetValue("ButtonSettingsInfoSilverFeaturesLabelText", value); }
        }

        public string ButtonSettingsInfoGoldFeaturesLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoGoldFeaturesLabelText"); }
            set { this.SetValue("ButtonSettingsInfoGoldFeaturesLabelText", value); }
        }

        public string ButtonSettingsInfoSaveVideoToCloudLabelText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoSaveVideoToCloudLabelText"); }
            set { this.SetValue("ButtonSettingsInfoSaveVideoToCloudLabelText", value); }
        }

        public string ButtonSettingsInfoSaveVideoToCloudDescriptionText
        {
            get { return (string)this.GetValue("ButtonSettingsInfoSaveVideoToCloudDescriptionText"); }
            set { this.SetValue("ButtonSettingsInfoSaveVideoToCloudDescriptionText", value); }
        }
        #endregion

        #region Main page
        public string MainPageSelectorDoneCommandText
        {
            get { return (string)this.GetValue("MainPageSelectorDoneCommandText"); }
            set { this.SetValue("MainPageSelectorDoneCommandText", value); }
        }
        #endregion

        #region Start panel
        public string StartPanelWelcomeText
        {
            get { return (string)this.GetValue("StartPanelWelcomeText"); }
            set { this.SetValue("StartPanelWelcomeText", value); }
        }

        public string StartPanelLogInButtonText
        {
            get { return (string)this.GetValue("StartPanelLogInButtonText"); }
            set { this.SetValue("StartPanelLogInButtonText", value); }
        }

        public string StartPanelCreateAccountButtonText
        {
            get { return (string)this.GetValue("StartPanelCreateAccountButtonText"); }
            set { this.SetValue("StartPanelCreateAccountButtonText", value); }
        }

        public string StartPanelFacebookLoginButtonText
        {
            get { return (string)this.GetValue("StartPanelFacebookLoginButtonText"); }
            set { this.SetValue("StartPanelFacebookLoginButtonText", value); }
        }
        #endregion

        #region Login panel
        public string LoginPanelWelcomeText
        {
            get { return (string)this.GetValue("LoginPanelWelcomeText"); }
            set { this.SetValue("LoginPanelWelcomeText", value); }
        }

        public string LoginPanelEmailPlaceholderText
        {
            get { return (string)this.GetValue("LoginPanelEmailPlaceholderText"); }
            set { this.SetValue("LoginPanelEmailPlaceholderText", value); }
        }

        public string LoginPanelPasswordPlaceholderText
        {
            get { return (string)this.GetValue("LoginPanelPasswordPlaceholderText"); }
            set { this.SetValue("LoginPanelPasswordPlaceholderText", value); }
        }

        public string LoginPanelForgotCommandText
        {
            get { return (string)this.GetValue("LoginPanelForgotCommandText"); }
            set { this.SetValue("LoginPanelForgotCommandText", value); }
        }

        public string LoginPanelSignUpCommandText
        {
            get { return (string)this.GetValue("LoginPanelSignUpCommandText"); }
            set { this.SetValue("LoginPanelSignUpCommandText", value); }
        }

        public string LoginPanelLogInButtonText
        {
            get { return (string)this.GetValue("LoginPanelLogInButtonText"); }
            set { this.SetValue("LoginPanelLogInButtonText", value); }
        }

        public string LoginPanelErrorText
        {
            get { return (string)this.GetValue("LoginPanelErrorText"); }
            set { this.SetValue("LoginPanelErrorText", value); }
        }
        #endregion

        #region Passcode Login panel
        public string PasscodeLoginPanelInfoText
        {
            get { return (string)this.GetValue("PasscodeLoginPanelInfoText"); }
            set { this.SetValue("PasscodeLoginPanelInfoText", value); }
        }

        public string PasscodeLoginPanelForgotPasscodeCommandText
        {
            get { return (string)this.GetValue("PasscodeLoginPanelForgotPasscodeCommandText"); }
            set { this.SetValue("PasscodeLoginPanelForgotPasscodeCommandText", value); }
        }
        #endregion

        #region Forgor Password panel
        public string ForgotPasswordPanelWelcomeText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelWelcomeText"); }
            set { this.SetValue("ForgotPasswordPanelWelcomeText", value); }
        }

        public string ForgotPasswordPanelTopInfoText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelTopInfoText"); }
            set { this.SetValue("ForgotPasswordPanelTopInfoText", value); }
        }

        public string ForgotPasswordPanelEmailPlaceholderText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelEmailPlaceholderText"); }
            set { this.SetValue("ForgotPasswordPanelEmailPlaceholderText", value); }
        }

        public string ForgotPasswordPanelSendAnEmailButtonText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelSendAnEmailButtonText"); }
            set { this.SetValue("ForgotPasswordPanelSendAnEmailButtonText", value); }
        }

        public string ForgotPasswordPanelErrorText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelErrorText"); }
            set { this.SetValue("ForgotPasswordPanelErrorText", value); }
        }

        public string ForgotPasswordPanelBackCommandText
        {
            get { return (string)this.GetValue("ForgotPasswordPanelBackCommandText"); }
            set { this.SetValue("ForgotPasswordPanelBackCommandText", value); }
        }
        #endregion

        #region Terms Of Use panel
        public string TermsOfUsePanelTitleText
        {
            get { return (string)this.GetValue("TermsOfUsePanelTitleText"); }
            set { this.SetValue("TermsOfUsePanelTitleText", value); }
        }

        public string TermsOfUsePanelDeclineCommandText
        {
            get { return (string)this.GetValue("TermsOfUsePanelDeclineCommandText"); }
            set { this.SetValue("TermsOfUsePanelDeclineCommandText", value); }
        }

        public string TermsOfUsePanelAcceptCommandText
        {
            get { return (string)this.GetValue("TermsOfUsePanelAcceptCommandText"); }
            set { this.SetValue("TermsOfUsePanelAcceptCommandText", value); }
        }

        public string TermsOfUsePanelTextTitle
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextTitle"); }
            set { this.SetValue("TermsOfUsePanelTextTitle", value); }
        }

        public string TermsOfUsePanelTextContentLine_1
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_1"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_1", value); }
        }

        public string TermsOfUsePanelTextContentLine_2
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_2"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_2", value); }
        }

        public string TermsOfUsePanelTextContentLine_3
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_3"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_3", value); }
        }

        public string TermsOfUsePanelTextContentLine_4
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_4"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_4", value); }
        }

        public string TermsOfUsePanelTextContentLine_5
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_5"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_5", value); }
        }

        public string TermsOfUsePanelTextContentLine_6
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_6"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_6", value); }
        }

        public string TermsOfUsePanelTextContentLine_7
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_7"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_7", value); }
        }

        public string TermsOfUsePanelTextContentLine_8
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_8"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_8", value); }
        }

        public string TermsOfUsePanelTextContentLine_9
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_9"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_9", value); }
        }

        public string TermsOfUsePanelTextContentLine_10
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_10"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_10", value); }
        }

        public string TermsOfUsePanelTextContentLine_11
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_11"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_11", value); }
        }

        public string TermsOfUsePanelTextContentLine_12
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_12"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_12", value); }
        }

        public string TermsOfUsePanelTextContentLine_13
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_13"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_13", value); }
        }

        public string TermsOfUsePanelTextContentLine_14
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_14"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_14", value); }
        }

        public string TermsOfUsePanelTextContentLine_15
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_15"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_15", value); }
        }

        public string TermsOfUsePanelTextContentLine_16
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_16"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_16", value); }
        }

        public string TermsOfUsePanelTextContentLine_17
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_17"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_17", value); }
        }

        public string TermsOfUsePanelTextContentLine_18
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_18"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_18", value); }
        }

        public string TermsOfUsePanelTextContentLine_19
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_19"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_19", value); }
        }

        public string TermsOfUsePanelTextContentLine_20
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_20"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_20", value); }
        }

        public string TermsOfUsePanelTextContentLine_21
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_21"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_21", value); }
        }

        public string TermsOfUsePanelTextContentLine_22
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_22"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_22", value); }
        }

        public string TermsOfUsePanelTextContentLine_23
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_23"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_23", value); }
        }

        public string TermsOfUsePanelTextContentLine_24
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_24"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_24", value); }
        }

        public string TermsOfUsePanelTextContentLine_25
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_25"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_25", value); }
        }

        public string TermsOfUsePanelTextContentLine_26
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_26"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_26", value); }
        }

        public string TermsOfUsePanelTextContentLine_27
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_27"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_27", value); }
        }

        public string TermsOfUsePanelTextContentLine_28
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_28"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_28", value); }
        }

        public string TermsOfUsePanelTextContentLine_29
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_29"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_29", value); }
        }

        public string TermsOfUsePanelTextContentLine_30
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_30"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_30", value); }
        }

        public string TermsOfUsePanelTextContentLine_31
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_31"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_31", value); }
        }

        public string TermsOfUsePanelTextContentLine_32
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_32"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_32", value); }
        }

        public string TermsOfUsePanelTextContentLine_33
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_33"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_33", value); }
        }

        public string TermsOfUsePanelTextContentLine_34
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_34"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_34", value); }
        }

        public string TermsOfUsePanelTextContentLine_35
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_35"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_35", value); }
        }

        public string TermsOfUsePanelTextContentLine_36
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_36"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_36", value); }
        }

        public string TermsOfUsePanelTextContentLine_37
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_37"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_37", value); }
        }

        public string TermsOfUsePanelTextContentLine_38
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_38"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_38", value); }
        }

        public string TermsOfUsePanelTextContentLine_39
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_39"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_39", value); }
        }

        public string TermsOfUsePanelTextContentLine_40
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_40"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_40", value); }
        }

        public string TermsOfUsePanelTextContentLine_41
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_41"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_41", value); }
        }

        public string TermsOfUsePanelTextContentLine_42
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_42"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_42", value); }
        }

        public string TermsOfUsePanelTextContentLine_43
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_43"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_43", value); }
        }

        public string TermsOfUsePanelTextContentLine_44
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_44"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_44", value); }
        }

        public string TermsOfUsePanelTextContentLine_45
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_45"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_45", value); }
        }

        public string TermsOfUsePanelTextContentLine_46
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_46"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_46", value); }
        }

        public string TermsOfUsePanelTextContentLine_47
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_47"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_47", value); }
        }

        public string TermsOfUsePanelTextContentLine_48
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_48"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_48", value); }
        }

        public string TermsOfUsePanelTextContentLine_49
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_49"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_49", value); }
        }

        public string TermsOfUsePanelTextContentLine_50
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_50"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_50", value); }
        }

        public string TermsOfUsePanelTextContentLine_51
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_51"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_51", value); }
        }

        public string TermsOfUsePanelTextContentLine_52
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_52"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_52", value); }
        }

        public string TermsOfUsePanelTextContentLine_53
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_53"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_53", value); }
        }

        public string TermsOfUsePanelTextContentLine_54
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_54"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_54", value); }
        }

        public string TermsOfUsePanelTextContentLine_55
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_55"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_55", value); }
        }

        public string TermsOfUsePanelTextContentLine_56
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_56"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_56", value); }
        }

        public string TermsOfUsePanelTextContentLine_57
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_57"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_57", value); }
        }

        public string TermsOfUsePanelTextContentLine_58
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_58"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_58", value); }
        }

        public string TermsOfUsePanelTextContentLine_59
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_59"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_59", value); }
        }

        public string TermsOfUsePanelTextContentLine_60
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_60"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_60", value); }
        }

        public string TermsOfUsePanelTextContentLine_61
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_61"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_61", value); }
        }

        public string TermsOfUsePanelTextContentLine_62
        {
            get { return (string)this.GetValue("TermsOfUsePanelTextContentLine_62"); }
            set { this.SetValue("TermsOfUsePanelTextContentLine_62", value); }
        }

        public string TermsOfUsePanelIHaveReadCheckedText
        {
            get { return (string)this.GetValue("TermsOfUsePanelIHaveReadCheckedText"); }
            set { this.SetValue("TermsOfUsePanelIHaveReadCheckedText", value); }
        }
        #endregion

        #region Create Account Phone panel
        public string CraeteAccountPhonePanelTitleText
        {
            get { return (string)this.GetValue("CraeteAccountPhonePanelTitleText"); }
            set { this.SetValue("CraeteAccountPhonePanelTitleText", value); }
        }

        public string CreateAccountPhonePanelCancelCommandText
        {
            get { return (string)this.GetValue("CreateAccountPhonePanelCancelCommandText"); }
            set { this.SetValue("CreateAccountPhonePanelCancelCommandText", value); }
        }

        public string CreateAccountPhonePanelNextCommandText
        {
            get { return (string)this.GetValue("CreateAccountPhonePanelNextCommandText"); }
            set { this.SetValue("CreateAccountPhonePanelNextCommandText", value); }
        }

        public string CreateAccountPhonePanelPhoneLabelText
        {
            get { return (string)this.GetValue("CreateAccountPhonePanelPhoneLabelText"); }
            set { this.SetValue("CreateAccountPhonePanelPhoneLabelText", value); }
        }
        #endregion

        #region Create Account panel
        public string CreateAccountPanelTitleText
        {
            get { return (string)this.GetValue("CreateAccountPanelTitleText"); }
            set { this.SetValue("CreateAccountPanelTitleText", value); }
        }

        public string CreateAccountPanelCancelCommandText
        {
            get { return (string)this.GetValue("CreateAccountPanelCancelCommandText"); }
            set { this.SetValue("CreateAccountPanelCancelCommandText", value); }
        }

        public string CreateAccountPanelNextCommandText
        {
            get { return (string)this.GetValue("CreateAccountPanelNextCommandText"); }
            set { this.SetValue("CreateAccountPanelNextCommandText", value); }
        }

        public string CreateAccountPanelFirstNameLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelFirstNameLabelText"); }
            set { this.SetValue("CreateAccountPanelFirstNameLabelText", value); }
        }

        public string CreateAccountPanelLastNameLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelLastNameLabelText"); }
            set { this.SetValue("CreateAccountPanelLastNameLabelText", value); }
        }

        public string CreateAccountPanelGenderLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelGenderLabelText"); }
            set { this.SetValue("CreateAccountPanelGenderLabelText", value); }
        }

        public string CreateAccountPanelBirthDayLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelBirthDayLabelText"); }
            set { this.SetValue("CreateAccountPanelBirthDayLabelText", value); }
        }

        public string CreateAccountPanelPhoneNumberLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelPhoneNumberLabelText"); }
            set { this.SetValue("CreateAccountPanelPhoneNumberLabelText", value); }
        }

        public string CreateAccountPanelEmailLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelEmailLabelText"); }
            set { this.SetValue("CreateAccountPanelEmailLabelText", value); }
        }

        public string CreateAccountPanelReEnterEmailLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelReEnterEmailLabelText"); }
            set { this.SetValue("CreateAccountPanelReEnterEmailLabelText", value); }
        }

        public string CreateAccountPanelPasswordLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelPasswordLabelText"); }
            set { this.SetValue("CreateAccountPanelPasswordLabelText", value); }
        }

        public string CreateAccountPanelReEnterPasswordLabelText
        {
            get { return (string)this.GetValue("CreateAccountPanelReEnterPasswordLabelText"); }
            set { this.SetValue("CreateAccountPanelReEnterPasswordLabelText", value); }
        }
        #endregion

        #region Phone Verification panel
        public string PhoneVerificationPanelTitleText
        {
            get { return (string)this.GetValue("PhoneVerificationPanelTitleText"); }
            set { this.SetValue("PhoneVerificationPanelTitleText", value); }
        }

        public string PhoneVerificationPanelBackCommandText
        {
            get { return (string)this.GetValue("PhoneVerificationPanelBackCommandText"); }
            set { this.SetValue("PhoneVerificationPanelBackCommandText", value); }
        }

        public string PhoneVerificationPanelSaveCommandText
        {
            get { return (string)this.GetValue("PhoneVerificationPanelSaveCommandText"); }
            set { this.SetValue("PhoneVerificationPanelSaveCommandText", value); }
        }

        public string PhoneVerificationPanelTopInfoText
        {
            get { return (string)this.GetValue("PhoneVerificationPanelTopInfoText"); }
            set { this.SetValue("PhoneVerificationPanelTopInfoText", value); }
        }

        public string PhoneVerificationPanelCodeLabelText
        {
            get { return (string)this.GetValue("PhoneVerificationPanelCodeLabelText"); }
            set { this.SetValue("PhoneVerificationPanelCodeLabelText", value); }
        }
        #endregion

        #region Detailed Info panel
        public string DetailedInfoPanelTitleText
        {
            get { return (string)this.GetValue("DetailedInfoPanelTitleText"); }
            set { this.SetValue("DetailedInfoPanelTitleText", value); }
        }

        public string DetailedInfoPanelBackCommandText
        {
            get { return (string)this.GetValue("DetailedInfoPanelBackCommandText"); }
            set { this.SetValue("DetailedInfoPanelBackCommandText", value); }
        }

        public string DetailedInfoPanelNextCommandText
        {
            get { return (string)this.GetValue("DetailedInfoPanelNextCommandText"); }
            set { this.SetValue("DetailedInfoPanelNextCommandText", value); }
        }

        public string DetailedInfoPanelTopInfoText
        {
            get { return (string)this.GetValue("DetailedInfoPanelTopInfoText"); }
            set { this.SetValue("DetailedInfoPanelTopInfoText", value); }
        }

        public string DetailedInfoPanelHeightLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelHeightLabelText"); }
            set { this.SetValue("DetailedInfoPanelHeightLabelText", value); }
        }

        public string DetailedInfoPanelWeightLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelWeightLabelText"); }
            set { this.SetValue("DetailedInfoPanelWeightLabelText", value); }
        }

        public string DetailedInfoPanelHairColorLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelHairColorLabelText"); }
            set { this.SetValue("DetailedInfoPanelHairColorLabelText", value); }
        }

        public string DetailedInfoPanelEyeColorLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelEyeColorLabelText"); }
            set { this.SetValue("DetailedInfoPanelEyeColorLabelText", value); }
        }

        public string DetailedInfoPanelEthnicityLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelEthnicityLabelText"); }
            set { this.SetValue("DetailedInfoPanelEthnicityLabelText", value); }
        }

        public string DetailedInfoPanelStreetLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelStreetLabelText"); }
            set { this.SetValue("DetailedInfoPanelStreetLabelText", value); }
        }

        public string DetailedInfoPanelCityLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelCityLabelText"); }
            set { this.SetValue("DetailedInfoPanelCityLabelText", value); }
        }

        public string DetailedInfoPanelStateLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelStateLabelText"); }
            set { this.SetValue("DetailedInfoPanelStateLabelText", value); }
        }

        public string DetailedInfoPanelZipCodeLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelZipCodeLabelText"); }
            set { this.SetValue("DetailedInfoPanelZipCodeLabelText", value); }
        }

        public string DetailedInfoPanelMediasLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelMediasLabelText"); }
            set { this.SetValue("DetailedInfoPanelMediasLabelText", value); }
        }

        public string DetailedInfoPanelAllergiesLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelAllergiesLabelText"); }
            set { this.SetValue("DetailedInfoPanelAllergiesLabelText", value); }
        }

        public string DetailedInfoPanelMedicationsLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelMedicationsLabelText"); }
            set { this.SetValue("DetailedInfoPanelMedicationsLabelText", value); }
        }

        public string DetailedInfoPanelHomeAddressLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelHomeAddressLabelText"); }
            set { this.SetValue("DetailedInfoPanelHomeAddressLabelText", value); }
        }

        public string DetailedInfoPanelMedicalConditionsLabelText
        {
            get { return (string)this.GetValue("DetailedInfoPanelMedicalConditionsLabelText"); }
            set { this.SetValue("DetailedInfoPanelMedicalConditionsLabelText", value); }
        }
        #endregion

        #region Passcode panel
        public string PasscodePanelTitleText
        {
            get { return (string)this.GetValue("PasscodePanelTitleText"); }
            set { this.SetValue("PasscodePanelTitleText", value); }
        }

        public string PasscodePanelBackCommandText
        {
            get { return (string)this.GetValue("PasscodePanelBackCommandText"); }
            set { this.SetValue("PasscodePanelBackCommandText", value); }
        }

        public string PasscodePanelSaveCommandText
        {
            get { return (string)this.GetValue("PasscodePanelSaveCommandText"); }
            set { this.SetValue("PasscodePanelSaveCommandText", value); }
        }

        public string PasscodePanelTopInfoText
        {
            get { return (string)this.GetValue("PasscodePanelTopInfoText"); }
            set { this.SetValue("PasscodePanelTopInfoText", value); }
        }

        public string PasscodePanelPasscodeLabelText
        {
            get { return (string)this.GetValue("PasscodePanelPasscodeLabelText"); }
            set { this.SetValue("PasscodePanelPasscodeLabelText", value); }
        }

        public string PasscodePanelPasscodeConfirmLabelText
        {
            get { return (string)this.GetValue("PasscodePanelPasscodeConfirmLabelText"); }
            set { this.SetValue("PasscodePanelPasscodeConfirmLabelText", value); }
        }
        #endregion

        #region Account Type panel
        public string AccountTypePanelTitleText
        {
            get { return (string)this.GetValue("AccountTypePanelTitleText"); }
            set { this.SetValue("AccountTypePanelTitleText", value); }
        }

        public string AccountTypePanelBackCommandText
        {
            get { return (string)this.GetValue("AccountTypePanelBackCommandText"); }
            set { this.SetValue("AccountTypePanelBackCommandText", value); }
        }

        public string AccountTypePanelSilverButtonText
        {
            get { return (string)this.GetValue("AccountTypePanelSilverButtonText"); }
            set { this.SetValue("AccountTypePanelSilverButtonText", value); }
        }

        public string AccountTypePanelGoldButtonText
        {
            get { return (string)this.GetValue("AccountTypePanelGoldButtonText"); }
            set { this.SetValue("AccountTypePanelGoldButtonText", value); }
        }

        public string AccountTypePanelFreeButtonText
        {
            get { return (string)this.GetValue("AccountTypePanelFreeButtonText"); }
            set { this.SetValue("AccountTypePanelFreeButtonText", value); }
        }

        public string AccountTypePanelCancelPremiumAccountButtonText
        {
            get { return (string)this.GetValue("AccountTypePanelCancelPremiumAccountButtonText"); }
            set { this.SetValue("AccountTypePanelCancelPremiumAccountButtonText", value); }
        }

        public string AccountTypePanelGiftTheAppCommandText
        {
            get { return (string)this.GetValue("AccountTypePanelGiftTheAppCommandText"); }
            set { this.SetValue("AccountTypePanelGiftTheAppCommandText", value); }
        }
        #endregion

        #region Add Emergency Contacts panel
        public string AddEmergencyContactsPanelTitleLabel
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelTitleLabel"); }
            set { this.SetValue("AddEmergencyContactsPanelTitleLabel", value); }
        }

        public string AddEmergencyContactsPanelBackCommandText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelBackCommandText"); }
            set { this.SetValue("AddEmergencyContactsPanelBackCommandText", value); }
        }

        public string AddEmergencyContactsPanelSkipCommandText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelSkipCommandText"); }
            set { this.SetValue("AddEmergencyContactsPanelSkipCommandText", value); }
        }

        public string AddEmergencyContactsPanelNextCommandText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelNextCommandText"); }
            set { this.SetValue("AddEmergencyContactsPanelNextCommandText", value); }
        }

        public string AddEmergencyContactsPanelTopInfoText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelTopInfoText"); }
            set { this.SetValue("AddEmergencyContactsPanelTopInfoText", value); }
        }

        public string AddEmergencyContactsPanelEmptyListText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelEmptyListText"); }
            set { this.SetValue("AddEmergencyContactsPanelEmptyListText", value); }
        }

        public string AddEmergencyContactsPanelAddEmergencyContractButtonText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelAddEmergencyContractButtonText"); }
            set { this.SetValue("AddEmergencyContactsPanelAddEmergencyContractButtonText", value); }
        }

        public string AddEmergencyContactsPanelUnlockPremiumButtonText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelUnlockPremiumButtonText"); }
            set { this.SetValue("AddEmergencyContactsPanelUnlockPremiumButtonText", value); }
        }

        public string AddEmergencyContactsPanelLimitLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelLimitLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelLimitLabelText", value); }
        }

        public string AddEmergencyContactsPanelPauseAllLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelPauseAllLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelPauseAllLabelText", value); }
        }

        public string AddEmergencyContactsPanelSearchPlaceholderText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelSearchPlaceholderText"); }
            set { this.SetValue("AddEmergencyContactsPanelSearchPlaceholderText", value); }
        }

        public string AddEmergencyContactsPanelTrackThemLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelTrackThemLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelTrackThemLabelText", value); }
        }

        public string AddEmergencyContactsPanelTrackMeLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelTrackMeLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelTrackMeLabelText", value); }
        }

        public string AddEmergencyContactsPanelYellowAlertLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelYellowAlertLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelYellowAlertLabelText", value); }
        }

        public string AddEmergencyContactsPanelRedAlertLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelRedAlertLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelRedAlertLabelText", value); }
        }

        public string AddEmergencyContactsPanelExpanderPauseInfoText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelExpanderPauseInfoText"); }
            set { this.SetValue("AddEmergencyContactsPanelExpanderPauseInfoText", value); }
        }

        public string AddEmergencyContactsPanelRelationShipLabelText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelRelationShipLabelText"); }
            set { this.SetValue("AddEmergencyContactsPanelRelationShipLabelText", value); }
        }

        public string AddEmergencyContactsPanelReponseButtonText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelReponseButtonText"); }
            set { this.SetValue("AddEmergencyContactsPanelReponseButtonText", value); }
        }

        public string AddEmergencyContactsPanelRemoveContactCommandText
        {
            get { return (string)this.GetValue("AddEmergencyContactsPanelRemoveContactCommandText"); }
            set { this.SetValue("AddEmergencyContactsPanelRemoveContactCommandText", value); }
        }

        public string AddEmergencyRelationshipPickerTitleText
        {
            get { return (string)this.GetValue("AddEmergencyRelationshipPickerTitleText"); }
            set { this.SetValue("AddEmergencyRelationshipPickerTitleText", value); }
        }

        #endregion

        #region Select Emergency Contracts panel
        public string SelectEmergencyContactsPanelTitleLabel
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelTitleLabel"); }
            set { this.SetValue("SelectEmergencyContactsPanelTitleLabel", value); }
        }

        public string SelectEmergencyContactsPanelBackCommandText
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelBackCommandText"); }
            set { this.SetValue("SelectEmergencyContactsPanelBackCommandText", value); }
        }

        public string SelectEmergencyContactsPanelSearchPlaceholderText
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelSearchPlaceholderText"); }
            set { this.SetValue("SelectEmergencyContactsPanelSearchPlaceholderText", value); }
        }

        public string SelectEmergencyContactsPanelAddToEmergencyContactsCommandText
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelAddToEmergencyContactsCommandText"); }
            set { this.SetValue("SelectEmergencyContactsPanelAddToEmergencyContactsCommandText", value); }
        }
        public string SelectEmergencyContactsPanelRequestLocationSharingCommandText
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelRequestLocationSharingCommandText"); }
            set { this.SetValue("SelectEmergencyContactsPanelRequestLocationSharingCommandText", value); }
        }

        public string SelectEmergencyContactsPanelAddingEmergencyContact
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelAddingEmergencyContact"); }
            set { this.SetValue("SelectEmergencyContactsPanelAddingEmergencyContact", value); }
        }

        public string SelectEmergencyContactsPanelAddingMonitoredContact
        {
            get { return (string)this.GetValue("SelectEmergencyContactsPanelAddingMonitoredContact"); }
            set { this.SetValue("SelectEmergencyContactsPanelAddingMonitoredContact", value); }
        }
        #endregion

        #region Button Settings panel
        public string ButtonSettingsPanelTitleText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelTitleText"); }
            set { this.SetValue("ButtonSettingsPanelTitleText", value); }
        }

        public string ButtonSettingsPanelBackCommandText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelBackCommandText"); }
            set { this.SetValue("ButtonSettingsPanelBackCommandText", value); }
        }

        public string ButtonSettingsPanelNextCommandText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelNextCommandText"); }
            set { this.SetValue("ButtonSettingsPanelNextCommandText", value); }
        }

        public string ButtonSettingsPanelSkipButtonText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelSkipButtonText"); }
            set { this.SetValue("ButtonSettingsPanelSkipButtonText", value); }
        }

        public string ButtonSettingsPanelEmergencyButtonText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelEmergencyButtonText"); }
            set { this.SetValue("ButtonSettingsPanelEmergencyButtonText", value); }
        }

        public string ButtonSettingsPanelBadSituationButtonText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelBadSituationButtonText"); }
            set { this.SetValue("ButtonSettingsPanelBadSituationButtonText", value); }
        }

        public string ButtonSettingsPanelTopInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelTopInfoText"); }
            set { this.SetValue("ButtonSettingsPanelTopInfoText", value); }
        }

        public string ButtonSettingsPanelTopInfoBSText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelTopInfoBSText"); }
            set { this.SetValue("ButtonSettingsPanelTopInfoBSText", value); }
        }

        public string ButtonSettingsPanelMiddleInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelMiddleInfoText"); }
            set { this.SetValue("ButtonSettingsPanelMiddleInfoText", value); }
        }

        public string ButtonSettingsPanelMiddleInfoBSText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelMiddleInfoBSText"); }
            set { this.SetValue("ButtonSettingsPanelMiddleInfoBSText", value); }
        }

        public string ButtonSettingsPanelFirstInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelFirstInfoText"); }
            set { this.SetValue("ButtonSettingsPanelFirstInfoText", value); }
        }

        public string ButtonSettingsPanelSecondInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelSecondInfoText"); }
            set { this.SetValue("ButtonSettingsPanelSecondInfoText", value); }
        }

        public string ButtonSettingsPanelBottomInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelBottomInfoText"); }
            set { this.SetValue("ButtonSettingsPanelBottomInfoText", value); }
        }

        public string ButtonSettingsPanelCheckOutPremiumButtonText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelCheckOutPremiumButtonText"); }
            set { this.SetValue("ButtonSettingsPanelCheckOutPremiumButtonText", value); }
        }

        public string ButtonSettingsPanelRedAlertTopInfoText
        {
            get { return (string)this.GetValue("ButtonSettingsPanelRedAlertTopInfoText"); }
            set { this.SetValue("ButtonSettingsPanelRedAlertTopInfoText", value); }
        }
        #endregion

        #region What Happend panel
        public string WhatHappendPanelTopInfoText
        {
            get { return (string)this.GetValue("WhatHappendPanelTopInfoText"); }
            set { this.SetValue("WhatHappendPanelTopInfoText", value); }
        }

        public string WhatHappendPanelFalseAlarmCommandText
        {
            get { return (string)this.GetValue("WhatHappendPanelFalseAlarmCommandText"); }
            set { this.SetValue("WhatHappendPanelFalseAlarmCommandText", value); }
        }

        public string WhatHappendPanelNothingJustBeingCautiousCommandText
        {
            get { return (string)this.GetValue("WhatHappendPanelNothingJustBeingCautiousCommandText"); }
            set { this.SetValue("WhatHappendPanelNothingJustBeingCautiousCommandText", value); }
        }

        public string WhatHappendPanelIWasInABadSituationCommandText
        {
            get { return (string)this.GetValue("WhatHappendPanelIWasInABadSituationCommandText"); }
            set { this.SetValue("WhatHappendPanelIWasInABadSituationCommandText", value); }
        }

        public string WhatHappendPanelIWasAssaultedCommandText
        {
            get { return (string)this.GetValue("WhatHappendPanelIWasAssaultedCommandText"); }
            set { this.SetValue("WhatHappendPanelIWasAssaultedCommandText", value); }
        }

        public string WhatHappendPanelCloseButtonText
        {
            get { return (string)this.GetValue("WhatHappendPanelCloseButtonText"); }
            set { this.SetValue("WhatHappendPanelCloseButtonText", value); }
        }
        #endregion

        #region What Happened Popup panel
        public string WhatHappenedPopupPanelTitleText
        {
            get { return (string)this.GetValue("WhatHappenedPopupPanelTitleText"); }
            set { this.SetValue("WhatHappenedPopupPanelTitleText", value); }
        }

        public string WhatHappenedPopupPanelIWasAssaultedText
        {
            get { return (string)this.GetValue("WhatHappenedPopupPanelIWasAssaultedText"); }
            set { this.SetValue("WhatHappenedPopupPanelIWasAssaultedText", value); }
        }

        public string WhatHappenedPopupPanelOtherText
        {
            get { return (string)this.GetValue("WhatHappenedPopupPanelOtherText"); }
            set { this.SetValue("WhatHappenedPopupPanelOtherText", value); }
        }

        public string WhatHappenedPopupPanelIWasInABadSituationText
        {
            get { return (string)this.GetValue("WhatHappenedPopupPanelIWasInABadSituationText"); }
            set { this.SetValue("WhatHappenedPopupPanelIWasInABadSituationText", value); }
        }

        public string WhatHappenedPopupNothingJustBeingCautiousText
        {
            get { return (string)this.GetValue("WhatHappenedPopupNothingJustBeingCautiousText"); }
            set { this.SetValue("WhatHappenedPopupNothingJustBeingCautiousText", value); }
        }

        public string WhatHappenedPopupPanelFalseAlarmText
        {
            get { return (string)this.GetValue("WhatHappenedPopupPanelFalseAlarmText"); }
            set { this.SetValue("WhatHappenedPopupPanelFalseAlarmText", value); }
        }
        #endregion

        #region Incident Ended Popup panel
        public string IncidentEndedPopupPanelTitleText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelTitleText"); }
            set { this.SetValue("IncidentEndedPopupPanelTitleText", value); }
        }

        public string IncidentEndedPopupPanelOtherText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelOtherText"); }
            set { this.SetValue("IncidentEndedPopupPanelOtherText", value); }
        }

        public string IncidentEndedPopupPanelIHaveToLeaveText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelIHaveToLeaveText"); }
            set { this.SetValue("IncidentEndedPopupPanelIHaveToLeaveText", value); }
        }

        public string IncidentEndedPopupPanelPoliceHaveArrivedText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelPoliceHaveArrivedText"); }
            set { this.SetValue("IncidentEndedPopupPanelPoliceHaveArrivedText", value); }
        }

        public string IncidentEndedPopupPanelIGotHurtText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelIGotHurtText"); }
            set { this.SetValue("IncidentEndedPopupPanelIGotHurtText", value); }
        }

        public string IncidentEndedPopupPanelSituationIsStillHappeningText
        {
            get { return (string)this.GetValue("IncidentEndedPopupPanelSituationIsStillHappeningText"); }
            set { this.SetValue("IncidentEndedPopupPanelSituationIsStillHappeningText", value); }
        }
        #endregion

        #region Forgot Password Popup panel
        public string ForgotPasswordPopupPanelTitleText
        {
            get { return (string)this.GetValue("ForgotPasswordPopupPanelTitleText"); }
            set { this.SetValue("ForgotPasswordPopupPanelTitleText", value); }
        }

        public string ForgotPasswordPopupPanelInfoText
        {
            get { return (string)this.GetValue("ForgotPasswordPopupPanelInfoText"); }
            set { this.SetValue("ForgotPasswordPopupPanelInfoText", value); }
        }

        public string ForgotPasswordPopupPanelGotItButtonText
        {
            get { return (string)this.GetValue("ForgotPasswordPopupPanelGotItButtonText"); }
            set { this.SetValue("ForgotPasswordPopupPanelGotItButtonText", value); }
        }
        #endregion

        #region Stay Signed In Popup panel
        public string StaySignedInPopupPanelTitleText
        {
            get { return (string)this.GetValue("StaySignedInPopupPanelTitleText"); }
            set { this.SetValue("StaySignedInPopupPanelTitleText", value); }
        }

        public string StaySignedInPopupPanelContentText
        {
            get { return (string)this.GetValue("StaySignedInPopupPanelContentText"); }
            set { this.SetValue("StaySignedInPopupPanelContentText", value); }
        }

        public string StaySignedInPopupPanelRelogInEveryTimeButtonText
        {
            get { return (string)this.GetValue("StaySignedInPopupPanelRelogInEveryTimeButtonText"); }
            set { this.SetValue("StaySignedInPopupPanelRelogInEveryTimeButtonText", value); }
        }

        public string StaySignedInPopupPanelStayInSignedButtonText
        {
            get { return (string)this.GetValue("StaySignedInPopupPanelStayInSignedButtonText"); }
            set { this.SetValue("StaySignedInPopupPanelStayInSignedButtonText", value); }
        }
        #endregion

        #region Premium Popup Panel
        public string PremiumPopupPanelCongratulationsText
        {
            get { return (string)this.GetValue("PremiumPopupPanelCongratulationsText"); }
            set { this.SetValue("PremiumPopupPanelCongratulationsText", value); }
        }

        public string PremiumPopupPanelInfoFormatText
        {
            get { return (string)this.GetValue("PremiumPopupPanelInfoFormatText"); }
            set { this.SetValue("PremiumPopupPanelInfoFormatText", value); }
        }

        public string PremiumPopupPanelInfoText
        {
            get { return (string)this.GetValue("PremiumPopupPanelInfoText"); }
            set { this.SetValue("PremiumPopupPanelInfoText", value); }
        }

        public string PremiumPopupPanelGotItButtonText
        {
            get { return (string)this.GetValue("PremiumPopupPanelGotItButtonText"); }
            set { this.SetValue("PremiumPopupPanelGotItButtonText", value); }
        }

        public string PremiumPopupPanelSilverText
        {
            get { return (string)this.GetValue("PremiumPopupPanelSilverText"); }
            set { this.SetValue("PremiumPopupPanelSilverText", value); }
        }

        public string PremiumPopupPanelGoldText
        {
            get { return (string)this.GetValue("PremiumPopupPanelGoldText"); }
            set { this.SetValue("PremiumPopupPanelGoldText", value); }
        }
        #endregion

        #region Work panel
        public string WorkPanelEmergencyCommandText
        {
            get { return (string)this.GetValue("WorkPanelEmergencyCommandText"); }
            set { this.SetValue("WorkPanelEmergencyCommandText", value); }
        }

        public string WorkPanelStarredCommandText
        {
            get { return (string)this.GetValue("WorkPanelStarredCommandText"); }
            set { this.SetValue("WorkPanelStarredCommandText", value); }
        }

        public string WorkPanelMapCommandText
        {
            get { return (string)this.GetValue("WorkPanelMapCommandText"); }
            set { this.SetValue("WorkPanelMapCommandText", value); }
        }

        public string WorkPanelNotificationsCommandText
        {
            get { return (string)this.GetValue("WorkPanelNotificationsCommandText"); }
            set { this.SetValue("WorkPanelNotificationsCommandText", value); }
        }

        public string WorkPanelAccountCommandText
        {
            get { return (string)this.GetValue("WorkPanelAccountCommandText"); }
            set { this.SetValue("WorkPanelAccountCommandText", value); }
        }
        #endregion

        #region Emergency panel
        public string EmergencyPanelTitleText
        {
            get { return (string)this.GetValue("EmergencyPanelTitleText"); }
            set { this.SetValue("EmergencyPanelTitleText", value); }
        }

        public string EmergencyPanelEmergencyText
        {
            get { return (string)this.GetValue("EmergencyPanelEmergencyText"); }
            set { this.SetValue("EmergencyPanelEmergencyText", value); }
        }

        public string EmergencyPanelBadSituationTitleText
        {
            get { return (string)this.GetValue("EmergencyPanelBadSituationTitleText"); }
            set { this.SetValue("EmergencyPanelBadSituationTitleText", value); }
        }

        public string EmergencyPanelCallToPoliceTitleText
        {
            get { return (string)this.GetValue("EmergencyPanelCallToPoliceTitleText"); }
            set { this.SetValue("EmergencyPanelCallToPoliceTitleText", value); }
        }

        public string EmergencyPanelTopInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelTopInfoText"); }
            set { this.SetValue("EmergencyPanelTopInfoText", value); }
        }

        public string EmergencyPanelActivatedInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelActivatedInfoText"); }
            set { this.SetValue("EmergencyPanelActivatedInfoText", value); }
        }

        public string EmergencyPanelEndRouteEarlyInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelEndRouteEarlyInfoText"); }
            set { this.SetValue("EmergencyPanelEndRouteEarlyInfoText", value); }
        }

        public string EmergencyPanelOutRouteInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelOutRouteInfoText"); }
            set { this.SetValue("EmergencyPanelOutRouteInfoText", value); }
        }

        public string EmergencyPanelSecondsText
        {
            get { return (string)this.GetValue("EmergencyPanelSecondsText"); }
            set { this.SetValue("EmergencyPanelSecondsText", value); }
        }

        public string EmergencyPanelBottomInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelBottomInfoText"); }
            set { this.SetValue("EmergencyPanelBottomInfoText", value); }
        }

        public string EmergencyPanelForgotPasswordCommandText
        {
            get { return (string)this.GetValue("EmergencyPanelForgotPasswordCommandText"); }
            set { this.SetValue("EmergencyPanelForgotPasswordCommandText", value); }
        }

        public string EmergencyPanelForgotPasswordInfoText
        {
            get { return (string)this.GetValue("EmergencyPanelForgotPasswordInfoText"); }
            set { this.SetValue("EmergencyPanelForgotPasswordInfoText", value); }
        }
        #endregion

        #region End Route Early Panel
        public string EndRouteEarlyPanelTitleText
        {
            get { return (string)this.GetValue("EndRouteEarlyPanelTitleText"); }
            set { this.SetValue("EndRouteEarlyPanelTitleText", value); }
        }

        public string EndRouteEarlyPanelSecondsText
        {
            get { return (string)this.GetValue("EndRouteEarlyPanelSecondsText"); }
            set { this.SetValue("EndRouteEarlyPanelSecondsText", value); }
        }

        public string EndRouteEarlyPanelBottomInfoText
        {
            get { return (string)this.GetValue("EndRouteEarlyPanelBottomInfoText"); }
            set { this.SetValue("EndRouteEarlyPanelBottomInfoText", value); }
        }
        #endregion

        #region Test panel
        public string TestPanelTitleText
        {
            get { return (string)this.GetValue("TestPanelTitleText"); }
            set { this.SetValue("TestPanelTitleText", value); }
        }

        public string TestPanelBackCommandText
        {
            get { return (string)this.GetValue("TestPanelBackCommandText"); }
            set { this.SetValue("TestPanelBackCommandText", value); }
        }

        public string TestPanelTopInfoText
        {
            get { return (string)this.GetValue("TestPanelTopInfoText"); }
            set { this.SetValue("TestPanelTopInfoText", value); }
        }

        public string TestPanelEndTestModeButtonText
        {
            get { return (string)this.GetValue("TestPanelEndTestModeButtonText"); }
            set { this.SetValue("TestPanelEndTestModeButtonText", value); }
        }

        public string TestPanelTestButtonText
        {
            get { return (string)this.GetValue("TestPanelTestButtonText"); }
            set { this.SetValue("TestPanelTestButtonText", value); }
        }

        public string TestPanelNotifyEmergencyContactsLabelText
        {
            get { return (string)this.GetValue("TestPanelNotifyEmergencyContactsLabelText"); }
            set { this.SetValue("TestPanelNotifyEmergencyContactsLabelText", value); }
        }

        public string TestPanelNotifyEmergencyContactsDescriptionText
        {
            get { return (string)this.GetValue("TestPanelNotifyEmergencyContactsDescriptionText"); }
            set { this.SetValue("TestPanelNotifyEmergencyContactsDescriptionText", value); }
        }

        public string TestPanelAudioVideoRecordingLabelText
        {
            get { return (string)this.GetValue("TestPanelAudioVideoRecordingLabelText"); }
            set { this.SetValue("TestPanelAudioVideoRecordingLabelText", value); }
        }

        public string TestPanelAudioVideoRecordingDescriptionText
        {
            get { return (string)this.GetValue("TestPanelAudioVideoRecordingDescriptionText"); }
            set { this.SetValue("TestPanelAudioVideoRecordingDescriptionText", value); }
        }

        public string TestPanelActivateFlashlightLabelText
        {
            get { return (string)this.GetValue("TestPanelActivateFlashlightLabelText"); }
            set { this.SetValue("TestPanelActivateFlashlightLabelText", value); }
        }

        public string TestPanelActivateFlashlightDescriptionText
        {
            get { return (string)this.GetValue("TestPanelActivateFlashlightDescriptionText"); }
            set { this.SetValue("TestPanelActivateFlashlightDescriptionText", value); }
        }

        public string TestPanelAlertNearbyCurrentUsersLabelText
        {
            get { return (string)this.GetValue("TestPanelAlertNearbyCurrentUsersLabelText"); }
            set { this.SetValue("TestPanelAlertNearbyCurrentUsersLabelText", value); }
        }

        public string TestPanelAlertNearbyCurrentUsersDescriptionText
        {
            get { return (string)this.GetValue("TestPanelAlertNearbyCurrentUsersDescriptionText"); }
            set { this.SetValue("TestPanelAlertNearbyCurrentUsersDescriptionText", value); }
        }

        public string TestPanelTurnOnSirenLabelText
        {
            get { return (string)this.GetValue("TestPanelTurnOnSirenLabelText"); }
            set { this.SetValue("TestPanelTurnOnSirenLabelText", value); }
        }

        public string TestPanelTurnOnSirenDescriptionText
        {
            get { return (string)this.GetValue("TestPanelTurnOnSirenDescriptionText"); }
            set { this.SetValue("TestPanelTurnOnSirenDescriptionText", value); }
        }

        public string TestPanelSendMyLocationToPoliceLabelText
        {
            get { return (string)this.GetValue("TestPanelSendMyLocationToPoliceLabelText"); }
            set { this.SetValue("TestPanelSendMyLocationToPoliceLabelText", value); }
        }

        public string TestPanelSendMyLocationToPoliceDescriptionText
        {
            get { return (string)this.GetValue("TestPanelSendMyLocationToPoliceDescriptionText"); }
            set { this.SetValue("TestPanelSendMyLocationToPoliceDescriptionText", value); }
        }

        public string TestPanelSendMyLocationToPoliceLinkText
        {
            get { return (string)this.GetValue("TestPanelSendMyLocationToPoliceLinkText"); }
            set { this.SetValue("TestPanelSendMyLocationToPoliceLinkText", value); }
        }

        public string TestPanelCallAlarmMonitoringLabelText
        {
            get { return (string)this.GetValue("TestPanelCallAlarmMonitoringLabelText"); }
            set { this.SetValue("TestPanelCallAlarmMonitoringLabelText", value); }
        }

        public string TestPanelCallAlarmMonitoringDescriptionText
        {
            get { return (string)this.GetValue("TestPanelCallAlarmMonitoringDescriptionText"); }
            set { this.SetValue("TestPanelCallAlarmMonitoringDescriptionText", value); }
        }

        public string TestPanelCallPoliceLabelText
        {
            get { return (string)this.GetValue("TestPanelCallPoliceLabelText"); }
            set { this.SetValue("TestPanelCallPoliceLabelText", value); }
        }

        public string TestPanelCallPoliceDescriptionText
        {
            get { return (string)this.GetValue("TestPanelCallPoliceDescriptionText"); }
            set { this.SetValue("TestPanelCallPoliceDescriptionText", value); }
        }
        #endregion

        #region Home panel
        public string HomePanelTitleText
        {
            get { return (string)this.GetValue("HomePanelTitleText"); }
            set { this.SetValue("HomePanelTitleText", value); }
        }

        public string HomePanelTitleFormatText
        {
            get { return (string)this.GetValue("HomePanelTitleFormatText"); }
            set { this.SetValue("HomePanelTitleFormatText", value); }
        }

        public string HomePanelLastUpdatedInfoLabelText
        {
            get { return (string)this.GetValue("HomePanelLastUpdatedInfoLabelText"); }
            set { this.SetValue("HomePanelLastUpdatedInfoLabelText", value); }
        }

        public string HomePanelBattaryLabelText
        {
            get { return (string)this.GetValue("HomePanelBattaryLabelText"); }
            set { this.SetValue("HomePanelBattaryLabelText", value); }
        }

        public string HomePanelArmedLabelText
        {
            get { return (string)this.GetValue("HomePanelArmedLabelText"); }
            set { this.SetValue("HomePanelArmedLabelText", value); }
        }

        public string HomePanelDisarmedLabelText
        {
            get { return (string)this.GetValue("HomePanelDisarmedLabelText"); }
            set { this.SetValue("HomePanelDisarmedLabelText", value); }
        }

        public string HomePanelSafetyLabelText
        {
            get { return (string)this.GetValue("HomePanelSafetyLabelText"); }
            set { this.SetValue("HomePanelSafetyLabelText", value); }
        }

        public string HomePanelEndTripButtonText
        {
            get { return (string)this.GetValue("HomePanelEndTripButtonText"); }
            set { this.SetValue("HomePanelEndTripButtonText", value); }
        }

        public string HomePanelEndTripDownButtonText
        {
            get { return (string)this.GetValue("HomePanelEndTripDownButtonText"); }
            set { this.SetValue("HomePanelEndTripDownButtonText", value); }
        }

        public string HomePanelPauseTripButtonText
        {
            get { return (string)this.GetValue("HomePanelPauseTripButtonText"); }
            set { this.SetValue("HomePanelPauseTripButtonText", value); }
        }

        public string HomePanelContinueTripButtonText
        {
            get { return (string)this.GetValue("HomePanelContinueTripButtonText"); }
            set { this.SetValue("HomePanelContinueTripButtonText", value); }
        }

        public string HomePanelSaveCommandText
        {
            get { return (string)this.GetValue("HomePanelSaveCommandText"); }
            set { this.SetValue("HomePanelSaveCommandText", value); }
        }

        public string HomePanelWalkingTimeText
        {
            get { return (string)this.GetValue("HomePanelWalkingTimeText"); }
            set { this.SetValue("HomePanelWalkingTimeText", value); }
        }

        public string HomePanelBicyclingTimeText
        {
            get { return (string)this.GetValue("HomePanelBicyclingTimeText"); }
            set { this.SetValue("HomePanelBicyclingTimeText", value); }
        }

        public string HomePanelDrivingTimeText
        {
            get { return (string)this.GetValue("HomePanelDrivingTimeText"); }
            set { this.SetValue("HomePanelDrivingTimeText", value); }
        }

        public string HomePanelSelfRespondersLabelText
        {
            get { return (string)this.GetValue("HomePanelSelfRespondersLabelText"); }
            set { this.SetValue("HomePanelSelfRespondersLabelText", value); }
        }
        public string HomePanelEditRouteDialogTitleText
        {
            get { return (string)this.GetValue("HomePanelEditRouteDialogTitleText"); }
            set { this.SetValue("HomePanelEditRouteDialogTitleText", value); }
        }
        public string HomePanelEditRouteDialogMessageText
        {
            get { return (string)this.GetValue("HomePanelEditRouteDialogMessageText"); }
            set { this.SetValue("HomePanelEditRouteDialogMessageText", value); }
        }
        public string HomePanelEditRouteDialogActionChangeText
        {
            get { return (string)this.GetValue("HomePanelEditRouteDialogActionChangeText"); }
            set { this.SetValue("HomePanelEditRouteDialogActionChangeText", value); }
        }
        public string HomePanelEditRouteDialogActionCancleText
        {
            get { return (string)this.GetValue("HomePanelEditRouteDialogActionCancleText"); }
            set { this.SetValue("HomePanelEditRouteDialogActionCancleText", value); }
        }
        #endregion

        #region Notifications panel
        #endregion

        #region Notifications Main panel
        public string NotificationsMainPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsMainPanelTitleText"); }
            set { this.SetValue("NotificationsMainPanelTitleText", value); }
        }
        #endregion

        #region Notifications Friend In Emergency Panel
        public string NotificationsInEmergencyPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelBackCommandText"); }
            set { this.SetValue("NotificationsInEmergencyPanelBackCommandText", value); }
        }

        public string NotificationsInEmergencyPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelTitleText"); }
            set { this.SetValue("NotificationsInEmergencyPanelTitleText", value); }
        }

        public string NotificationsInEmergencyPanelPhoneStatusText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelPhoneStatusText"); }
            set { this.SetValue("NotificationsInEmergencyPanelPhoneStatusText", value); }
        }

        public string NotificationsInEmergencyPanelEmergencyButtonLabelText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelEmergencyButtonLabelText"); }
            set { this.SetValue("NotificationsInEmergencyPanelEmergencyButtonLabelText", value); }
        }

        public string NotificationsInEmergencyPanelRespondersNearByLabelText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelRespondersNearByLabelText"); }
            set { this.SetValue("NotificationsInEmergencyPanelRespondersNearByLabelText", value); }
        }

        public string NotificationsInEmergencyPanelEmergencyButtonInactiviveText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelEmergencyButtonInactiviveText"); }
            set { this.SetValue("NotificationsInEmergencyPanelEmergencyButtonInactiviveText", value); }
        }

        public string NotificationsInEmergencyPanelSafetyArmedSwitchText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelSafetyArmedSwitchText"); }
            set { this.SetValue("NotificationsInEmergencyPanelSafetyArmedSwitchText", value); }
        }

        public string NotificationsInEmergencyPanelEmergencyButtonAlarmText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelEmergencyButtonAlarmText"); }
            set { this.SetValue("NotificationsInEmergencyPanelEmergencyButtonAlarmText", value); }
        }

        public string NotificationsInEmergencyPanelPhoneOnStatusText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelPhoneOnStatusText"); }
            set { this.SetValue("NotificationsInEmergencyPanelPhoneOnStatusText", value); }
        }

        public string NotificationsInEmergencyPanelPhoneOffStatusText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelPhoneOffStatusText"); }
            set { this.SetValue("NotificationsInEmergencyPanelPhoneOffStatusText", value); }
        }

        public string NotificationsInEmergencyPanelTrackingRouteText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelTrackingRouteText"); }
            set { this.SetValue("NotificationsInEmergencyPanelTrackingRouteText", value); }
        }

        public string NotificationsInEmergencyPanelNotTrackingRouteText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelNotTrackingRouteText"); }
            set { this.SetValue("NotificationsInEmergencyPanelNotTrackingRouteText", value); }
        }

        public string NotificationsInEmergencyPanelLocationTitleText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelLocationTitleText"); }
            set { this.SetValue("NotificationsInEmergencyPanelLocationTitleText", value); }
        }

        public string NotificationsInEmergencyPanelReportToPoliceText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelReportToPoliceText"); }
            set { this.SetValue("NotificationsInEmergencyPanelReportToPoliceText", value); }
        }

        public string NotificationsInEmergencyPanelMinText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelMinText"); }
            set { this.SetValue("NotificationsInEmergencyPanelMinText", value); }
        }

        public string NotificationsInEmergencyPanelMilesText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelMilesText"); }
            set { this.SetValue("NotificationsInEmergencyPanelMilesText", value); }
        }

        public string NotificationsInEmergencyPanelMph
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelMph"); }
            set { this.SetValue("NotificationsInEmergencyPanelMph", value); }
        }

        public string NotificationsInEmergencyPanelDirectThereText
        {
            get { return (string)this.GetValue("NotificationsInEmergencyPanelDirectThereText"); }
            set { this.SetValue("NotificationsInEmergencyPanelDirectThereText", value); }
        }
        #endregion

        #region Notifications Call To Police Panel
        public string NotificationsCallPolicePanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelBackCommandText"); }
            set { this.SetValue("NotificationsCallPolicePanelBackCommandText", value); }
        }

        public string NotificationsCallPolicePanelTitleText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelTitleText"); }
            set { this.SetValue("NotificationsCallPolicePanelTitleText", value); }
        }

        public string NotificationsCallPolicePanelEndCallCommandText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelEndCallCommandText"); }
            set { this.SetValue("NotificationsCallPolicePanelEndCallCommandText", value); }
        }

        public string NotificationsCallPolicePanelReadToPoliceTitleText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelReadToPoliceTitleText"); }
            set { this.SetValue("NotificationsCallPolicePanelReadToPoliceTitleText", value); }
        }

        public string NotificationsCallPolicePanelCallText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelCallText"); }
            set { this.SetValue("NotificationsCallPolicePanelCallText", value); }
        }

        public string NotificationsCallPolicePanelMyPhoneLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMyPhoneLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelMyPhoneLabelText", value); }
        }

        public string NotificationsCallPolicePanelMyNameLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMyNameLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelMyNameLabelText", value); }
        }

        public string NotificationsCallPolicePanelInfoToPoliceTitleText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelInfoToPoliceTitleText"); }
            set { this.SetValue("NotificationsCallPolicePanelInfoToPoliceTitleText", value); }
        }

        public string NotificationsCallPolicePanelNameLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelNameLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelNameLabelText", value); }
        }

        public string NotificationsCallPolicePanelAgeLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelAgeLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelAgeLabelText", value); }
        }

        public string NotificationsCallPolicePanelEthnicityLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelEthnicityLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelEthnicityLabelText", value); }
        }

        public string NotificationsCallPolicePanelHairColorLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelHairColorLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelHairColorLabelText", value); }
        }

        public string NotificationsCallPolicePanelHeightLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelHeightLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelHeightLabelText", value); }
        }

        public string NotificationsCallPolicePanelAllergiesLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelAllergiesLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelAllergiesLabelText", value); }
        }

        public string NotificationsCallPolicePanelMedicationsLabelText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMedicationsLabelText"); }
            set { this.SetValue("NotificationsCallPolicePanelMedicationsLabelText", value); }
        }

        public string NotificationsCallPolicePanelMinText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMinText"); }
            set { this.SetValue("NotificationsCallPolicePanelMinText", value); }
        }

        public string NotificationsCallPolicePanelMilesText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMilesText"); }
            set { this.SetValue("NotificationsCallPolicePanelMilesText", value); }
        }

        public string NotificationsCallPolicePanelMph
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelMph"); }
            set { this.SetValue("NotificationsCallPolicePanelMph", value); }
        }

        public string NotificationsCallPolicePanelDirectThereText
        {
            get { return (string)this.GetValue("NotificationsCallPolicePanelDirectThereText"); }
            set { this.SetValue("NotificationsCallPolicePanelDirectThereText", value); }
        }
        #endregion

        #region Notifications Emergency Directions Panel
        public string NotificationsDirectionsPanelMinText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelMinText"); }
            set { this.SetValue("NotificationsDirectionsPanelMinText", value); }
        }

        public string NotificationsDirectionsPanelTimeText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelTimeText"); }
            set { this.SetValue("NotificationsDirectionsPanelTimeText", value); }
        }

        public string NotificationsDirectionsPanelMilesText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelMilesText"); }
            set { this.SetValue("NotificationsDirectionsPanelMilesText", value); }
        }

        public string NotificationsDirectionsPanelFtText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelFtText"); }
            set { this.SetValue("NotificationsDirectionsPanelFtText", value); }
        }

        public string NotificationsDirectionsPanelCallToPoliceLabelText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelCallToPoliceLabelText"); }
            set { this.SetValue("NotificationsDirectionsPanelCallToPoliceLabelText", value); }
        }

        public string NotificationsDirectionsPanelRespondersLabelText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelRespondersLabelText"); }
            set { this.SetValue("NotificationsDirectionsPanelRespondersLabelText", value); }
        }

        public string NotificationsDirectionsPanelEndNavLabelText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelEndNavLabelText"); }
            set { this.SetValue("NotificationsDirectionsPanelEndNavLabelText", value); }
        }

        public string NotificationsDirectionsPanelEndNavCommandText
        {
            get { return (string)this.GetValue("NotificationsDirectionsPanelEndNavCommandText"); }
            set { this.SetValue("NotificationsDirectionsPanelEndNavCommandText", value); }
        }
        #endregion

        #region Notifications Emergency Record Panel
        public string NotificationsEmergencyRecordPanelCallToPoliceLabelText
        {
            get { return (string)this.GetValue("NotificationsEmergencyRecordPanelCallToPoliceLabelText"); }
            set { this.SetValue("NotificationsEmergencyRecordPanelCallToPoliceLabelText", value); }
        }

        public string NotificationsEmergencyRecordPanelRespondersLabelText
        {
            get { return (string)this.GetValue("NotificationsEmergencyRecordPanelRespondersLabelText"); }
            set { this.SetValue("NotificationsEmergencyRecordPanelRespondersLabelText", value); }
        }

        public string NotificationsEmergencyRecordPanelEndRecLabelText
        {
            get { return (string)this.GetValue("NotificationsEmergencyRecordPanelEndRecLabelText"); }
            set { this.SetValue("NotificationsEmergencyRecordPanelEndRecLabelText", value); }
        }

        public string NotificationsEmergencyRecordPanelEndRecCommandText
        {
            get { return (string)this.GetValue("NotificationsEmergencyRecordPanelEndRecCommandText"); }
            set { this.SetValue("NotificationsEmergencyRecordPanelEndRecCommandText", value); }
        }
        #endregion

        #region Notifications Breaking News panel
        public string NotificationsBreakingNewsPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsBreakingNewsPanelTitleText"); }
            set { this.SetValue("NotificationsBreakingNewsPanelTitleText", value); }
        }

        public string NotificationsBreakingNewsPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsBreakingNewsPanelBackCommandText"); }
            set { this.SetValue("NotificationsBreakingNewsPanelBackCommandText", value); }
        }
        #endregion

        #region Notifications Local Alert panel
        public string NotificationsLocalAlertPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsLocalAlertPanelTitleText"); }
            set { this.SetValue("NotificationsLocalAlertPanelTitleText", value); }
        }

        public string NotificationsLocalAlertPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsLocalAlertPanelBackCommandText"); }
            set { this.SetValue("NotificationsLocalAlertPanelBackCommandText", value); }
        }
        #endregion

        #region Notifications Safety Tip panel
        public string NotificationsSafetyTipPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsSafetyTipPanelTitleText"); }
            set { this.SetValue("NotificationsSafetyTipPanelTitleText", value); }
        }

        public string NotificationsSafetyTipPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsSafetyTipPanelBackCommandText"); }
            set { this.SetValue("NotificationsSafetyTipPanelBackCommandText", value); }
        }
        #endregion

        #region Notifications Help Panel
        public string NotificationsHelpPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelBackCommandText"); }
            set { this.SetValue("NotificationsHelpPanelBackCommandText", value); }
        }

        public string NotificationsHelpPanelTitleText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelTitleText"); }
            set { this.SetValue("NotificationsHelpPanelTitleText", value); }
        }

        public string NotificationsHelpPanelReportToPoliceText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelReportToPoliceText"); }
            set { this.SetValue("NotificationsHelpPanelReportToPoliceText", value); }
        }

        public string NotificationsHelpPanelMinText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelMinText"); }
            set { this.SetValue("NotificationsHelpPanelMinText", value); }
        }

        public string NotificationsHelpPanelMilesText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelMilesText"); }
            set { this.SetValue("NotificationsHelpPanelMilesText", value); }
        }

        public string NotificationsHelpPanelMphText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelMphText"); }
            set { this.SetValue("NotificationsHelpPanelMphText", value); }
        }

        public string NotificationsHelpPanelDirectThereText
        {
            get { return (string)this.GetValue("NotificationsHelpPanelDirectThereText"); }
            set { this.SetValue("NotificationsHelpPanelDirectThereText", value); }
        }
        #endregion

        #region Account panel
        public string AccountPanelMemberSinceFormatText
        {
            get { return (string)this.GetValue("AccountPanelMemberSinceFormatText"); }
            set { this.SetValue("AccountPanelMemberSinceFormatText", value); }
        }

        public string AccountPanelViewProfileCommandText
        {
            get { return (string)this.GetValue("AccountPanelViewProfileCommandText"); }
            set { this.SetValue("AccountPanelViewProfileCommandText", value); }
        }

        public string AccountPanelSettingsCommandText
        {
            get { return (string)this.GetValue("AccountPanelSettingsCommandText"); }
            set { this.SetValue("AccountPanelSettingsCommandText", value); }
        }

        public string AccountPanelShareCommandText
        {
            get { return (string)this.GetValue("AccountPanelShareCommandText"); }
            set { this.SetValue("AccountPanelShareCommandText", value); }
        }

        public string AccountPanelGetPremiumCommandText
        {
            get { return (string)this.GetValue("AccountPanelGetPremiumCommandText"); }
            set { this.SetValue("AccountPanelGetPremiumCommandText", value); }
        }

        public string AccountPanelContactUsCommandText
        {
            get { return (string)this.GetValue("AccountPanelContactUsCommandText"); }
            set { this.SetValue("AccountPanelContactUsCommandText", value); }
        }

        public string AccountPanelFriendsCommandText
        {
            get { return (string)this.GetValue("AccountPanelFriendsCommandText"); }
            set { this.SetValue("AccountPanelFriendsCommandText", value); }
        }

        public string AccountPanelProfileCommandText
        {
            get { return (string)this.GetValue("AccountPanelProfileCommandText"); }
            set { this.SetValue("AccountPanelProfileCommandText", value); }
        }

        public string AccountPanelGiftAppCommandText
        {
            get { return (string)this.GetValue("AccountPanelGiftAppCommandText"); }
            set { this.SetValue("AccountPanelGiftAppCommandText", value); }
        }

        public string AccountPanelFollowUsCommandText
        {
            get { return (string)this.GetValue("AccountPanelFollowUsCommandText"); }
            set { this.SetValue("AccountPanelFollowUsCommandText", value); }
        }
        #endregion

        #region List panel
        public string ListPanelSelectorLeftText
        {
            get { return (string)this.GetValue("ListPanelSelectorLeftText"); }
            set { this.SetValue("ListPanelSelectorLeftText", value); }
        }

        public string ListPanelSelectorRightText
        {
            get { return (string)this.GetValue("ListPanelSelectorRightText"); }
            set { this.SetValue("ListPanelSelectorRightText", value); }
        }

        public string ListPanelPeoplesListTitleText
        {
            get { return (string)this.GetValue("ListPanelPeoplesListTitleText"); }
            set { this.SetValue("ListPanelPeoplesListTitleText", value); }
        }

        public string ListPanelAddPeopleCommandText
        {
            get { return (string)this.GetValue("ListPanelAddPeopleCommandText"); }
            set { this.SetValue("ListPanelAddPeopleCommandText", value); }
        }

        public string ListPanelPlacesListTitleText
        {
            get { return (string)this.GetValue("ListPanelPlacesListTitleText"); }
            set { this.SetValue("ListPanelPlacesListTitleText", value); }
        }

        public string ListPanelAddPlaceCommandText
        {
            get { return (string)this.GetValue("ListPanelAddPlaceCommandText"); }
            set { this.SetValue("ListPanelAddPlaceCommandText", value); }
        }

        public string ListPanelPendingApproval
        {
            get { return (string)this.GetValue("ListPanelPendingApproval"); }
            set { this.SetValue("ListPanelPendingApproval", value); }
        }
        #endregion

        #region Add Place panel
        public string AddPlacePanelTitleText
        {
            get { return (string)this.GetValue("AddPlacePanelTitleText"); }
            set { this.SetValue("AddPlacePanelTitleText", value); }
        }

        public string ModifyPlacePanelTitleText
        {
            get { return (string)this.GetValue("ModifyPlacePanelTitleText"); }
            set { this.SetValue("ModifyPlacePanelTitleText", value); }
        }

        public string AddPlacePanelTopInfoText
        {
            get { return (string)this.GetValue("AddPlacePanelTopInfoText"); }
            set { this.SetValue("AddPlacePanelTopInfoText", value); }
        }

        public string AddPlacePanelNameLabelText
        {
            get { return (string)this.GetValue("AddPlacePanelNameLabelText"); }
            set { this.SetValue("AddPlacePanelNameLabelText", value); }
        }

        public string AddPlacePanelAddressLabelText
        {
            get { return (string)this.GetValue("AddPlacePanelAddressLabelText"); }
            set { this.SetValue("AddPlacePanelAddressLabelText", value); }
        }

        public string AddPlacePanelMinutesText
        {
            get { return (string)this.GetValue("AddPlacePanelMinutesText"); }
            set { this.SetValue("AddPlacePanelMinutesText", value); }
        }

        public string AddPlacePanelMilesText
        {
            get { return (string)this.GetValue("AddPlacePanelMilesText"); }
            set { this.SetValue("AddPlacePanelMilesText", value); }
        }

        public string AddPlacePanelSaveButtonText
        {
            get { return (string)this.GetValue("AddPlacePanelSaveButtonText"); }
            set { this.SetValue("AddPlacePanelSaveButtonText", value); }
        }
        #endregion

        #region Start Recording Route panel
        public string StartRecordingRoutePanelInfoTextLine_1
        {
            get { return (string)this.GetValue("StartRecordingRoutePanelInfoTextLine_1"); }
            set { this.SetValue("StartRecordingRoutePanelInfoTextLine_1", value); }
        }

        public string StartRecordingRoutePanelInfoTextLine_2
        {
            get { return (string)this.GetValue("StartRecordingRoutePanelInfoTextLine_2"); }
            set { this.SetValue("StartRecordingRoutePanelInfoTextLine_2", value); }
        }

        public string StartRecordingRoutePanelButtonText
        {
            get { return (string)this.GetValue("StartRecordingRoutePanelButtonText"); }
            set { this.SetValue("StartRecordingRoutePanelButtonText", value); }
        }
        #endregion

        #region End Recording Route panel
        public string EndRecordingRoutePanelInfoText
        {
            get { return (string)this.GetValue("EndRecordingRoutePanelInfoText"); }
            set { this.SetValue("EndRecordingRoutePanelInfoText", value); }
        }

        public string EndRecordingRoutePanelButtonText
        {
            get { return (string)this.GetValue("EndRecordingRoutePanelButtonText"); }
            set { this.SetValue("EndRecordingRoutePanelButtonText", value); }
        }
        #endregion

        #region Edit Route Info panel
        public string EditRouteInfoPanelInfoTextLine_1
        {
            get { return (string)this.GetValue("EditRouteInfoPanelInfoTextLine_1"); }
            set { this.SetValue("EditRouteInfoPanelInfoTextLine_1", value); }
        }

        public string EditRouteInfoPanelInfoTextLine_2
        {
            get { return (string)this.GetValue("EditRouteInfoPanelInfoTextLine_2"); }
            set { this.SetValue("EditRouteInfoPanelInfoTextLine_2", value); }
        }

        public string EditRouteInfoPanelInfoTextLine_3
        {
            get { return (string)this.GetValue("EditRouteInfoPanelInfoTextLine_3"); }
            set { this.SetValue("EditRouteInfoPanelInfoTextLine_3", value); }
        }

        public string EditRouteInfoPanelInfoTextLine_4
        {
            get { return (string)this.GetValue("EditRouteInfoPanelInfoTextLine_4"); }
            set { this.SetValue("EditRouteInfoPanelInfoTextLine_4", value); }
        }
        #endregion

        #region End Route Info panel
        public string EndRouteInfoPanelInfoTextLine_1
        {
            get { return (string)this.GetValue("EndRouteInfoPanelInfoTextLine_1"); }
            set { this.SetValue("EndRouteInfoPanelInfoTextLine_1", value); }
        }

        public string EndRouteInfoPanelInfoTextLine_2
        {
            get { return (string)this.GetValue("EndRouteInfoPanelInfoTextLine_2"); }
            set { this.SetValue("EndRouteInfoPanelInfoTextLine_2", value); }
        }

        public string EndRouteInfoPanelInfoTextLine_3
        {
            get { return (string)this.GetValue("EndRouteInfoPanelInfoTextLine_3"); }
            set { this.SetValue("EndRouteInfoPanelInfoTextLine_3", value); }
        }
        #endregion

        #region Profile panel
        public string ProfilePanelBackCommandText
        {
            get { return (string)this.GetValue("ProfilePanelBackCommandText"); }
            set { this.SetValue("ProfilePanelBackCommandText", value); }
        }

        public string ProfilePanelTopInfoText
        {
            get { return (string)this.GetValue("ProfilePanelTopInfoText"); }
            set { this.SetValue("ProfilePanelTopInfoText", value); }
        }

        public string ProfilePanelCompletedPercentText
        {
            get { return (string)this.GetValue("ProfilePanelCompletedPercentText"); }
            set { this.SetValue("ProfilePanelCompletedPercentText", value); }
        }

        public string ProfilePanelBasicInfoText
        {
            get { return (string)this.GetValue("ProfilePanelBasicInfoText"); }
            set { this.SetValue("ProfilePanelBasicInfoText", value); }
        }

        public string ProfilePanelMedicalInfoText
        {
            get { return (string)this.GetValue("ProfilePanelMedicalInfoText"); }
            set { this.SetValue("ProfilePanelMedicalInfoText", value); }
        }

        public string ProfilePanelEmergencyContactInfoText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactInfoText"); }
            set { this.SetValue("ProfilePanelEmergencyContactInfoText", value); }
        }

        public string ProfilePanelSaveCommandText
        {
            get { return (string)this.GetValue("ProfilePanelSaveCommandText"); }
            set { this.SetValue("ProfilePanelSaveCommandText", value); }
        }

        public string ProfilePanelFirstAndLastNameLabelText
        {
            get { return (string)this.GetValue("ProfilePanelFirstAndLastNameLabelText"); }
            set { this.SetValue("ProfilePanelFirstAndLastNameLabelText", value); }
        }

        public string ProfilePanelGenderLabelText
        {
            get { return (string)this.GetValue("ProfilePanelGenderLabelText"); }
            set { this.SetValue("ProfilePanelGenderLabelText", value); }
        }

        public string ProfilePanelBirthDayLabelText
        {
            get { return (string)this.GetValue("ProfilePanelBirthDayLabelText"); }
            set { this.SetValue("ProfilePanelBirthDayLabelText", value); }
        }

        public string ProfilePanelEmailLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEmailLabelText"); }
            set { this.SetValue("ProfilePanelEmailLabelText", value); }
        }

        public string ProfilePanelPhoneNumberLabelText
        {
            get { return (string)this.GetValue("ProfilePanelPhoneNumberLabelText"); }
            set { this.SetValue("ProfilePanelPhoneNumberLabelText", value); }
        }

        public string ProfilePanelConnectSocialMediaLabelText
        {
            get { return (string)this.GetValue("ProfilePanelConnectSocialMediaLabelText"); }
            set { this.SetValue("ProfilePanelConnectSocialMediaLabelText", value); }
        }

        public string ProfilePanelHeightLabelText
        {
            get { return (string)this.GetValue("ProfilePanelHeightLabelText"); }
            set { this.SetValue("ProfilePanelHeightLabelText", value); }
        }

        public string ProfilePanelWeightLabelText
        {
            get { return (string)this.GetValue("ProfilePanelWeightLabelText"); }
            set { this.SetValue("ProfilePanelWeightLabelText", value); }
        }

        public string ProfilePanelHairColorLabelText
        {
            get { return (string)this.GetValue("ProfilePanelHairColorLabelText"); }
            set { this.SetValue("ProfilePanelHairColorLabelText", value); }
        }

        public string ProfilePanelEyeColorLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEyeColorLabelText"); }
            set { this.SetValue("ProfilePanelEyeColorLabelText", value); }
        }

        public string ProfilePanelEthnicityLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEthnicityLabelText"); }
            set { this.SetValue("ProfilePanelEthnicityLabelText", value); }
        }

        public string ProfilePanelStreetLabelText
        {
            get { return (string)this.GetValue("ProfilePanelStreetLabelText"); }
            set { this.SetValue("ProfilePanelStreetLabelText", value); }
        }

        public string ProfilePanelCityLabelText
        {
            get { return (string)this.GetValue("ProfilePanelCityLabelText"); }
            set { this.SetValue("ProfilePanelCityLabelText", value); }
        }

        public string ProfilePanelStateLabelText
        {
            get { return (string)this.GetValue("ProfilePanelStateLabelText"); }
            set { this.SetValue("ProfilePanelStateLabelText", value); }
        }

        public string ProfilePanelZipCodeLabelText
        {
            get { return (string)this.GetValue("ProfilePanelZipCodeLabelText"); }
            set { this.SetValue("ProfilePanelZipCodeLabelText", value); }
        }

        public string ProfilePanelAllergiesLabelText
        {
            get { return (string)this.GetValue("ProfilePanelAllergiesLabelText"); }
            set { this.SetValue("ProfilePanelAllergiesLabelText", value); }
        }

        public string ProfilePanelMedicationsLabelText
        {
            get { return (string)this.GetValue("ProfilePanelMedicationsLabelText"); }
            set { this.SetValue("ProfilePanelMedicationsLabelText", value); }
        }

        public string ProfilePanelEmergencyContactNameLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactNameLabelText"); }
            set { this.SetValue("ProfilePanelEmergencyContactNameLabelText", value); }
        }

        public string ProfilePanelEmergencyContactRelationLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactRelationLabelText"); }
            set { this.SetValue("ProfilePanelEmergencyContactRelationLabelText", value); }
        }

        public string ProfilePanelEmergencyContactEmailLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactEmailLabelText"); }
            set { this.SetValue("ProfilePanelEmergencyContactEmailLabelText", value); }
        }

        public string ProfilePanelEmergencyContactPhoneNumberLabelText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactPhoneNumberLabelText"); }
            set { this.SetValue("ProfilePanelEmergencyContactPhoneNumberLabelText", value); }
        }

        public string ProfilePanelGetAnotherEmergencyContactButtonText
        {
            get { return (string)this.GetValue("ProfilePanelGetAnotherEmergencyContactButtonText"); }
            set { this.SetValue("ProfilePanelGetAnotherEmergencyContactButtonText", value); }
        }

        public string ProfilePanelLoggedToastText
        {
            get { return (string)this.GetValue("ProfilePanelLoggedToastText"); }
            set { this.SetValue("ProfilePanelLoggedToastText", value); }
        }

        public string ProfilePanelTitleText
        {
            get { return (string)this.GetValue("ProfilePanelTitleText"); }
            set { this.SetValue("ProfilePanelTitleText", value); }
        }

        public string ProfilePanelMedicalInfoHeaderText
        {
            get { return (string)this.GetValue("ProfilePanelMedicalInfoHeaderText"); }
            set { this.SetValue("ProfilePanelMedicalInfoHeaderText", value); }
        }

        public string ProfilePanelBasicInfoHeaderText
        {
            get { return (string)this.GetValue("ProfilePanelBasicInfoHeaderText"); }
            set { this.SetValue("ProfilePanelBasicInfoHeaderText", value); }
        }

        public string ProfilePanelEmergencyContactHeaderInfoText
        {
            get { return (string)this.GetValue("ProfilePanelEmergencyContactHeaderInfoText"); }
            set { this.SetValue("ProfilePanelEmergencyContactHeaderInfoText", value); }
        }

        public string ProfilePanelSexLabelText
        {
            get { return (string)this.GetValue("ProfilePanelSexLabelText"); }
            set { this.SetValue("ProfilePanelSexLabelText", value); }
        }

        public string ProfilePanelAddressLabelText
        {
            get { return (string)this.GetValue("ProfilePanelAddressLabelText"); }
            set { this.SetValue("ProfilePanelAddressLabelText", value); }
        }

        public string ProfilePanelStaySignedInHeaderInfoText
        {
            get { return (string)this.GetValue("ProfilePanelStaySignedInHeaderInfoText"); }
            set { this.SetValue("ProfilePanelStaySignedInHeaderInfoText", value); }
        }

        public string ProfilePanelFacefookButtonText
        {
            get { return (string)this.GetValue("ProfilePanelFacefookButtonText"); }
            set { this.SetValue("ProfilePanelFacefookButtonText", value); }
        }

        public string ProfilePanelStaySignedInfoText
        {
            get { return (string)this.GetValue("ProfilePanelStaySignedInfoText"); }
            set { this.SetValue("ProfilePanelStaySignedInfoText", value); }
        }

        public string ProfilePanelStaySignedLabelText
        {
            get { return (string)this.GetValue("ProfilePanelStaySignedLabelText"); }
            set { this.SetValue("ProfilePanelStaySignedLabelText", value); }
        }
        #endregion

        #region Settings panel
        public string SettingsPanelTitleText
        {
            get { return (string)this.GetValue("SettingsPanelTitleText"); }
            set { this.SetValue("SettingsPanelTitleText", value); }
        }

        public string SettingsPanelBackCommandText
        {
            get { return (string)this.GetValue("SettingsPanelBackCommandText"); }
            set { this.SetValue("SettingsPanelBackCommandText", value); }
        }

        public string SettingsPanelEditProfileCommandText
        {
            get { return (string)this.GetValue("SettingsPanelEditProfileCommandText"); }
            set { this.SetValue("SettingsPanelEditProfileCommandText", value); }
        }

        public string SettingsPanelEmergencyButtonSettingsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelEmergencyButtonSettingsCommandText"); }
            set { this.SetValue("SettingsPanelEmergencyButtonSettingsCommandText", value); }
        }

        public string SettingsPanelNotificationSettingsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelNotificationSettingsCommandText"); }
            set { this.SetValue("SettingsPanelNotificationSettingsCommandText", value); }
        }

        public string SettingsPanelChangeDeactivationPasscodeCommandText
        {
            get { return (string)this.GetValue("SettingsPanelChangeDeactivationPasscodeCommandText"); }
            set { this.SetValue("SettingsPanelChangeDeactivationPasscodeCommandText", value); }
        }

        public string SettingsPanelEmergencyContactsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelEmergencyContactsCommandText"); }
            set { this.SetValue("SettingsPanelEmergencyContactsCommandText", value); }
        }

        public string SettingsPanelBlockedPeopleCommandText
        {
            get { return (string)this.GetValue("SettingsPanelBlockedPeopleCommandText"); }
            set { this.SetValue("SettingsPanelBlockedPeopleCommandText", value); }
        }

        public string SettingsPanelLocationSharingCommandText
        {
            get { return (string)this.GetValue("SettingsPanelLocationSharingCommandText"); }
            set { this.SetValue("SettingsPanelLocationSharingCommandText", value); }
        }

        public string SettingsPanelTestModeCommandText
        {
            get { return (string)this.GetValue("SettingsPanelTestModeCommandText"); }
            set { this.SetValue("SettingsPanelTestModeCommandText", value); }
        }

        public string SettingsPanelTutorialCommandText
        {
            get { return (string)this.GetValue("SettingsPanelTutorialCommandText"); }
            set { this.SetValue("SettingsPanelTutorialCommandText", value); }
        }

        public string SettingsPanelReceiveSafetyTipsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelReceiveSafetyTipsCommandText"); }
            set { this.SetValue("SettingsPanelReceiveSafetyTipsCommandText", value); }
        }

        public string SettingsPanelReceiveAlertsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelReceiveAlertsCommandText"); }
            set { this.SetValue("SettingsPanelReceiveAlertsCommandText", value); }
        }

        public string SettingsPanelRecordCommandText
        {
            get { return (string)this.GetValue("SettingsPanelRecordCommandText"); }
            set { this.SetValue("SettingsPanelRecordCommandText", value); }
        }

        public string SettingsPanelLockSettingsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelLockSettingsCommandText"); }
            set { this.SetValue("SettingsPanelLockSettingsCommandText", value); }
        }

        public string SettingsPanelEditLocationSharingCommandText
        {
            get { return (string)this.GetValue("SettingsPanelEditLocationSharingCommandText"); }
            set { this.SetValue("SettingsPanelEditLocationSharingCommandText", value); }
        }

        public string SettingsPanelTrackFriendsCommandText
        {
            get { return (string)this.GetValue("SettingsPanelTrackFriendsCommandText"); }
            set { this.SetValue("SettingsPanelTrackFriendsCommandText", value); }
        }

        public string SettingsPanelTermsofUse
        {
            get { return (string)this.GetValue("SettingsPanelTermsofUse"); }
            set { this.SetValue("SettingsPanelTermsofUse", value); }
        }

        public string SettingsPanelPrivacyPolicies
        {
            get { return (string)this.GetValue("SettingsPanelPrivacyPolicies"); }
            set { this.SetValue("SettingsPanelPrivacyPolicies", value); }
        }
        #endregion

        #region Share panel
        public string SharePanelTitleText
        {
            get { return (string)this.GetValue("SharePanelTitleText"); }
            set { this.SetValue("SharePanelTitleText", value); }
        }

        public string SharePanelBackCommandText
        {
            get { return (string)this.GetValue("SharePanelBackCommandText"); }
            set { this.SetValue("SharePanelBackCommandText", value); }
        }

        public string SharePanelShareCommandText
        {
            get { return (string)this.GetValue("SharePanelShareCommandText"); }
            set { this.SetValue("SharePanelShareCommandText", value); }
        }

        public string SharePanelTopInfoText
        {
            get { return (string)this.GetValue("SharePanelTopInfoText"); }
            set { this.SetValue("SharePanelTopInfoText", value); }
        }

        public string SharePanelWriteACaptionPlaceholderText
        {
            get { return (string)this.GetValue("SharePanelWriteACaptionPlaceholderText"); }
            set { this.SetValue("SharePanelWriteACaptionPlaceholderText", value); }
        }

        public string SharePanelTagPeopleCommandText
        {
            get { return (string)this.GetValue("SharePanelTagPeopleCommandText"); }
            set { this.SetValue("SharePanelTagPeopleCommandText", value); }
        }

        public string SharePanelFacebookCommandText
        {
            get { return (string)this.GetValue("SharePanelFacebookCommandText"); }
            set { this.SetValue("SharePanelFacebookCommandText", value); }
        }

        public string SharePanelTwitterCommandText
        {
            get { return (string)this.GetValue("SharePanelTwitterCommandText"); }
            set { this.SetValue("SharePanelTwitterCommandText", value); }
        }

        public string SharePanelInstagramCommandText
        {
            get { return (string)this.GetValue("SharePanelInstagramCommandText"); }
            set { this.SetValue("SharePanelInstagramCommandText", value); }
        }

        public string SharePanelPinterestCommandText
        {
            get { return (string)this.GetValue("SharePanelPinterestCommandText"); }
            set { this.SetValue("SharePanelPinterestCommandText", value); }
        }

        public string SharePanelLinkedInCommandText
        {
            get { return (string)this.GetValue("SharePanelLinkedInCommandText"); }
            set { this.SetValue("SharePanelLinkedInCommandText", value); }
        }

        public string SharePanelTextCommandText
        {
            get { return (string)this.GetValue("SharePanelTextCommandText"); }
            set { this.SetValue("SharePanelTextCommandText", value); }
        }

        public string SharePanelEmailCommandText
        {
            get { return (string)this.GetValue("SharePanelEmailCommandText"); }
            set { this.SetValue("SharePanelEmailCommandText", value); }
        }

        public string SharePanelWriteAMessagePlaceholderText
        {
            get { return (string)this.GetValue("SharePanelWriteAMessagePlaceholderText"); }
            set { this.SetValue("SharePanelWriteAMessagePlaceholderText", value); }
        }

        public string SharePanelChoosePeopleToShareCommandText
        {
            get { return (string)this.GetValue("SharePanelChoosePeopleToShareCommandText"); }
            set { this.SetValue("SharePanelChoosePeopleToShareCommandText", value); }
        }

        public string SharePanelChooseShareViaEmailCommandText
        {
            get { return (string)this.GetValue("SharePanelChooseShareViaEmailCommandText"); }
            set { this.SetValue("SharePanelChooseShareViaEmailCommandText", value); }
        }

        public string SharePanelSubjectText
        {
            get { return (string)this.GetValue("SharePanelSubjectText"); }
            set { this.SetValue("SharePanelSubjectText", value); }
        }

        public string SharePanelShareInfoText
        {
            get { return (string)this.GetValue("SharePanelShareInfoText"); }
            set { this.SetValue("SharePanelShareInfoText", value); }
        }

        public string SharePanelMessageText
        {
            get { return (string)this.GetValue("SharePanelMessageText"); }
            set { this.SetValue("SharePanelMessageText", value); }
        }

        public string SharePanelShareWithSelectedContacts
        {
            get { return (string)this.GetValue("SharePanelShareWithSelectedContacts"); }
            set { this.SetValue("SharePanelShareWithSelectedContacts", value); }
        }
        public string SharePanelAppShareMessage
        {
            get { return (string)this.GetValue("SharePanelAppShareMessage"); }
            set { this.SetValue("SharePanelAppShareMessage", value); }
        }
        #endregion

        #region Contact Us panel
        public string ContactUsPanelTitleText
        {
            get { return (string)this.GetValue("ContactUsPanelTitleText"); }
            set { this.SetValue("ContactUsPanelTitleText", value); }
        }

        public string ContactUsPanelBackCommandText
        {
            get { return (string)this.GetValue("ContactUsPanelBackCommandText"); }
            set { this.SetValue("ContactUsPanelBackCommandText", value); }
        }

        public string ContactUsPanelContentTitleText
        {
            get { return (string)this.GetValue("ContactUsPanelContentTitleText"); }
            set { this.SetValue("ContactUsPanelContentTitleText", value); }
        }

        public string ContactUsPanelTopInfoText
        {
            get { return (string)this.GetValue("ContactUsPanelTopInfoText"); }
            set { this.SetValue("ContactUsPanelTopInfoText", value); }
        }

        public string ContactUsPanelSubjectLabelText
        {
            get { return (string)this.GetValue("ContactUsPanelSubjectLabelText"); }
            set { this.SetValue("ContactUsPanelSubjectLabelText", value); }
        }

        public string ContactUsPanelMessageLabelText
        {
            get { return (string)this.GetValue("ContactUsPanelMessageLabelText"); }
            set { this.SetValue("ContactUsPanelMessageLabelText", value); }
        }

        public string ContactUsPanelSendButtonText
        {
            get { return (string)this.GetValue("ContactUsPanelSendButtonText"); }
            set { this.SetValue("ContactUsPanelSendButtonText", value); }
        }

        public string ContactUsPanelFeedbackTitleText
        {
            get { return (string)this.GetValue("ContactUsPanelFeedbackTitleText"); }
            set { this.SetValue("ContactUsPanelFeedbackTitleText", value); }
        }
        public string ContactUsPanelMailIdText
        {
            get { return (string)this.GetValue("ContactUsPanelMailIdText"); }
            set { this.SetValue("ContactUsPanelMailIdText", value); }
        }
        #endregion

        #region Premium Account panel
        public string PremiumAccountPanelTitleText_old
        {
            get { return (string)this.GetValue("PremiumAccountPanelTitleText_old"); }
            set { this.SetValue("PremiumAccountPanelTitleText_old", value); }
        }

        public string PremiumAccountPanelBackCommandText
        {
            get { return (string)this.GetValue("PremiumAccountPanelBackCommandText"); }
            set { this.SetValue("PremiumAccountPanelBackCommandText", value); }
        }

        public string PremiumAccountPanelPremiumSilverButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelPremiumSilverButtonText"); }
            set { this.SetValue("PremiumAccountPanelPremiumSilverButtonText", value); }
        }

        public string PremiumAccountPanelPremiumGoldButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelPremiumGoldButtonText"); }
            set { this.SetValue("PremiumAccountPanelPremiumGoldButtonText", value); }
        }

        public string PremiumAccountPanelCancelPremiumButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelCancelPremiumButtonText"); }
            set { this.SetValue("PremiumAccountPanelCancelPremiumButtonText", value); }
        }

        public string PremiumAccountPanelTitleText
        {
            get { return (string)this.GetValue("PremiumAccountPanelTitleText"); }
            set { this.SetValue("PremiumAccountPanelTitleText", value); }
        }

        public string PremiumAccountPanelTrySilverButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelTrySilverButtonText"); }
            set { this.SetValue("PremiumAccountPanelTrySilverButtonText", value); }
        }

        public string PremiumAccountPanelTryGoldButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelTryGoldButtonText"); }
            set { this.SetValue("PremiumAccountPanelTryGoldButtonText", value); }
        }

        public string PremiumAccountPanelGiftAppCommandText
        {
            get { return (string)this.GetValue("PremiumAccountPanelGiftAppCommandText"); }
            set { this.SetValue("PremiumAccountPanelGiftAppCommandText", value); }
        }

        public string PremiumAccountPanelCancelSilverButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelCancelSilverButtonText"); }
            set { this.SetValue("PremiumAccountPanelCancelSilverButtonText", value); }
        }

        public string PremiumAccountPanelCancelGoldButtonText
        {
            get { return (string)this.GetValue("PremiumAccountPanelCancelGoldButtonText"); }
            set { this.SetValue("PremiumAccountPanelCancelGoldButtonText", value); }
        }
        #endregion

        #region Change Passcode panel
        public string ChangePasscodePanelTitleText
        {
            get { return (string)this.GetValue("ChangePasscodePanelTitleText"); }
            set { this.SetValue("ChangePasscodePanelTitleText", value); }
        }

        public string ChangePasscodePanelBackCommandText
        {
            get { return (string)this.GetValue("ChangePasscodePanelBackCommandText"); }
            set { this.SetValue("ChangePasscodePanelBackCommandText", value); }
        }

        public string ChangePasscodePanelSaveCommandText
        {
            get { return (string)this.GetValue("ChangePasscodePanelSaveCommandText"); }
            set { this.SetValue("ChangePasscodePanelSaveCommandText", value); }
        }

        public string ChangePasscodePanelTopInfoText
        {
            get { return (string)this.GetValue("ChangePasscodePanelTopInfoText"); }
            set { this.SetValue("ChangePasscodePanelTopInfoText", value); }
        }

        public string ChangePasscodePanelOldPasscodeLabelText
        {
            get { return (string)this.GetValue("ChangePasscodePanelOldPasscodeLabelText"); }
            set { this.SetValue("ChangePasscodePanelOldPasscodeLabelText", value); }
        }

        public string ChangePasscodePanelNewPasscodeLabelText
        {
            get { return (string)this.GetValue("ChangePasscodePanelNewPasscodeLabelText"); }
            set { this.SetValue("ChangePasscodePanelNewPasscodeLabelText", value); }
        }

        public string ChangePasscodePanelRepeatNewPasscodeLabelText
        {
            get { return (string)this.GetValue("ChangePasscodePanelRepeatNewPasscodeLabelText"); }
            set { this.SetValue("ChangePasscodePanelRepeatNewPasscodeLabelText", value); }
        }

        public string ChangePasscodePanelForgotPasscodeCommandText
        {
            get { return (string)this.GetValue("ChangePasscodePanelForgotPasscodeCommandText"); }
            set { this.SetValue("ChangePasscodePanelForgotPasscodeCommandText", value); }
        }

        public string ChangePasscodePanelNextCommandText
        {
            get { return (string)this.GetValue("ChangePasscodePanelNextCommandText"); }
            set { this.SetValue("ChangePasscodePanelNextCommandText", value); }
        }
        #endregion

        #region Button Settings panel
        public string AccountButtonSettingsPanelTitleText
        {
            get { return (string)this.GetValue("AccountButtonSettingsPanelTitleText"); }
            set { this.SetValue("AccountButtonSettingsPanelTitleText", value); }
        }

        public string AccountButtonSettingsPanelBackCommandText
        {
            get { return (string)this.GetValue("AccountButtonSettingsPanelBackCommandText"); }
            set { this.SetValue("AccountButtonSettingsPanelBackCommandText", value); }
        }

        public string AccountButtonSettingsPanelFirstTopInfoText
        {
            get { return (string)this.GetValue("AccountButtonSettingsPanelFirstTopInfoText"); }
            set { this.SetValue("AccountButtonSettingsPanelFirstTopInfoText", value); }
        }

        public string AccountButtonSettingsPanelSecondTopInfoText
        {
            get { return (string)this.GetValue("AccountButtonSettingsPanelSecondTopInfoText"); }
            set { this.SetValue("AccountButtonSettingsPanelSecondTopInfoText", value); }
        }

        public string AccountButtonSettingsAction1ButtonText
        {
            get { return (string)this.GetValue("AccountButtonSettingsAction1ButtonText"); }
            set { this.SetValue("AccountButtonSettingsAction1ButtonText", value); }
        }

        public string AccountButtonSettingsAction2ButtonText
        {
            get { return (string)this.GetValue("AccountButtonSettingsAction2ButtonText"); }
            set { this.SetValue("AccountButtonSettingsAction2ButtonText", value); }
        }

        public string AccountButtonSettingsAction3ButtonText
        {
            get { return (string)this.GetValue("AccountButtonSettingsAction3ButtonText"); }
            set { this.SetValue("AccountButtonSettingsAction3ButtonText", value); }
        }

        public string AccountButtonSettingsImageTitleFormatText
        {
            get { return (string)this.GetValue("AccountButtonSettingsImageTitleFormatText"); }
            set { this.SetValue("AccountButtonSettingsImageTitleFormatText", value); }
        }

        public string AccountButtonSettingsBottomInfoText
        {
            get { return (string)this.GetValue("AccountButtonSettingsBottomInfoText"); }
            set { this.SetValue("AccountButtonSettingsBottomInfoText", value); }
        }

        public string AccountButtonSettingsCheckOutPremiumButtonText
        {
            get { return (string)this.GetValue("AccountButtonSettingsCheckOutPremiumButtonText"); }
            set { this.SetValue("AccountButtonSettingsCheckOutPremiumButtonText", value); }
        }
        #endregion

        #region Location Sharing panel
        public string LocationSharingPanelTitleText
        {
            get { return (string)this.GetValue("LocationSharingPanelTitleText"); }
            set { this.SetValue("LocationSharingPanelTitleText", value); }
        }

        public string LocationSharingPanelBackCommandText
        {
            get { return (string)this.GetValue("LocationSharingPanelBackCommandText"); }
            set { this.SetValue("LocationSharingPanelBackCommandText", value); }
        }

        public string LocationSharingPanelTopInfoText
        {
            get { return (string)this.GetValue("LocationSharingPanelTopInfoText"); }
            set { this.SetValue("LocationSharingPanelTopInfoText", value); }
        }

        public string LocationSharingPanelNewTopInfoText
        {
            get { return (string)this.GetValue("LocationSharingPanelNewTopInfoText"); }
            set { this.SetValue("LocationSharingPanelNewTopInfoText", value); }
        }

        public string LocationSharingPanelAddAnotherContactButtonText
        {
            get { return (string)this.GetValue("LocationSharingPanelAddAnotherContactButtonText"); }
            set { this.SetValue("LocationSharingPanelAddAnotherContactButtonText", value); }
        }

        public string LocationSharingPanelUnlockPremiumButtonText
        {
            get { return (string)this.GetValue("LocationSharingPanelUnlockPremiumButtonText"); }
            set { this.SetValue("LocationSharingPanelUnlockPremiumButtonText", value); }
        }

        public string LocationSharingPanelExpanderTopInfoText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderTopInfoText"); }
            set { this.SetValue("LocationSharingPanelExpanderTopInfoText", value); }
        }

        public string LocationSharingPanelExpanderDaysLabelText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderDaysLabelText"); }
            set { this.SetValue("LocationSharingPanelExpanderDaysLabelText", value); }
        }

        public string LocationSharingPanelExpanderHoursLabelText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderHoursLabelText"); }
            set { this.SetValue("LocationSharingPanelExpanderHoursLabelText", value); }
        }

        public string LocationSharingPanelExpanderMinutesLabelText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderMinutesLabelText"); }
            set { this.SetValue("LocationSharingPanelExpanderMinutesLabelText", value); }
        }

        public string LocationSharingPanelExpanderCancelCommandText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderCancelCommandText"); }
            set { this.SetValue("LocationSharingPanelExpanderCancelCommandText", value); }
        }

        public string LocationSharingPanelExpanderDoneCommandText
        {
            get { return (string)this.GetValue("LocationSharingPanelExpanderDoneCommandText"); }
            set { this.SetValue("LocationSharingPanelExpanderDoneCommandText", value); }
        }

        public string LocationSharingPanelAddPeopleCommandText
        {
            get { return (string)this.GetValue("LocationSharingPanelAddPeopleCommandText"); }
            set { this.SetValue("LocationSharingPanelAddPeopleCommandText", value); }
        }

        public string LocationSharingPanelPendingApproval
        {
            get { return (string)this.GetValue("LocationSharingPanelPendingApproval"); }
            set { this.SetValue("LocationSharingPanelPendingApproval", value); }
        }
        #endregion

        #region Start Trip Panel
        public string StartTripLabelText
        {
            get { return (string)this.GetValue("StartTripLabelText"); }
            set { this.SetValue("StartTripLabelText", value); }
        }

        public string StartTripPanelDeletePlaceLabelText
        {
            get { return (string)this.GetValue("StartTripPanelDeletePlaceLabelText"); }
            set { this.SetValue("StartTripPanelDeletePlaceLabelText", value); }
        }

        public string StartTripPanelStartTextFormat
        {
            get { return (string)this.GetValue("StartTripPanelStartTextFormat"); }
            set { this.SetValue("StartTripPanelStartTextFormat", value); }
        }

        public string StartTripPanelStartRouteLabelText
        {
            get { return (string)this.GetValue("StartTripPanelStartRouteLabelText"); }
            set { this.SetValue("StartTripPanelStartRouteLabelText", value); }
        }

        public string StartTripPanelDeleteLocationCommandText
        {
            get { return (string)this.GetValue("StartTripPanelDeleteLocationCommandText"); }
            set { this.SetValue("StartTripPanelDeleteLocationCommandText", value); }
        }

        public string StartTripPanelSavedRouteCommandText
        {
            get { return (string)this.GetValue("StartTripPanelSavedRouteCommandText"); }
            set { this.SetValue("StartTripPanelSavedRouteCommandText", value); }
        }

        public string StartTripPanelNewRouteCommandText
        {
            get { return (string)this.GetValue("StartTripPanelNewRouteCommandText"); }
            set { this.SetValue("StartTripPanelNewRouteCommandText", value); }
        }
        #endregion

        #region Track Person Panel
        public string TrackPersonPanelSafetyStatusLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelSafetyStatusLabelText"); }
            set { this.SetValue("TrackPersonPanelSafetyStatusLabelText", value); }
        }

        public string TrackPersonPanelSafeStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelSafeStatusText"); }
            set { this.SetValue("TrackPersonPanelSafeStatusText", value); }
        }

        public string TrackPersonPanelStandByStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelStandByStatusText"); }
            set { this.SetValue("TrackPersonPanelStandByStatusText", value); }
        }

        public string TrackPersonPanelUnsafeStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelUnsafeStatusText"); }
            set { this.SetValue("TrackPersonPanelUnsafeStatusText", value); }
        }

        public string TrackPersonPanelPhoneStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelPhoneStatusText"); }
            set { this.SetValue("TrackPersonPanelPhoneStatusText", value); }
        }

        public string TrackPersonPanelPhoneOnStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelPhoneOnStatusText"); }
            set { this.SetValue("TrackPersonPanelPhoneOnStatusText", value); }
        }

        public string TrackPersonPanelPhoneOffStatusText
        {
            get { return (string)this.GetValue("TrackPersonPanelPhoneOffStatusText"); }
            set { this.SetValue("TrackPersonPanelPhoneOffStatusText", value); }
        }

        public string TrackPersonPanelSafetySwitchLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelSafetySwitchLabelText"); }
            set { this.SetValue("TrackPersonPanelSafetySwitchLabelText", value); }
        }

        public string TrackPersonPanelSafetyArmedSwitchText
        {
            get { return (string)this.GetValue("TrackPersonPanelSafetyArmedSwitchText"); }
            set { this.SetValue("TrackPersonPanelSafetyArmedSwitchText", value); }
        }

        public string TrackPersonPanelSafetyDisarmedSwitchText
        {
            get { return (string)this.GetValue("TrackPersonPanelSafetyDisarmedSwitchText"); }
            set { this.SetValue("TrackPersonPanelSafetyDisarmedSwitchText", value); }
        }

        public string TrackPersonPanelStunLastActivatedLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelStunLastActivatedLabelText"); }
            set { this.SetValue("TrackPersonPanelStunLastActivatedLabelText", value); }
        }

        public string TrackPersonPanelMinText
        {
            get { return (string)this.GetValue("TrackPersonPanelMinText"); }
            set { this.SetValue("TrackPersonPanelMinText", value); }
        }

        public string TrackPersonPanelMilesText
        {
            get { return (string)this.GetValue("TrackPersonPanelMilesText"); }
            set { this.SetValue("TrackPersonPanelMilesText", value); }
        }

        public string TrackPersonPanelDaysText
        {
            get { return (string)this.GetValue("TrackPersonPanelDaysText"); }
            set { this.SetValue("TrackPersonPanelDaysText", value); }
        }

        public string TrackPersonPanelRespondersNearByLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelRespondersNearByLabelText"); }
            set { this.SetValue("TrackPersonPanelRespondersNearByLabelText", value); }
        }

        public string TrackPersonPanelCurrentLocationTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelCurrentLocationTitleText"); }
            set { this.SetValue("TrackPersonPanelCurrentLocationTitleText", value); }
        }

        public string TrackPersonPanelSecondsFormatText
        {
            get { return (string)this.GetValue("TrackPersonPanelSecondsFormatText"); }
            set { this.SetValue("TrackPersonPanelSecondsFormatText", value); }
        }

        public string TrackPersonPanelInfoFormatText
        {
            get { return (string)this.GetValue("TrackPersonPanelInfoFormatText"); }
            set { this.SetValue("TrackPersonPanelInfoFormatText", value); }
        }
        public string TrackPersonPanelInfoFormatWithoutHeadedText
        {
            get { return (string)this.GetValue("TrackPersonPanelInfoFormatWithoutHeadedText"); }
            set { this.SetValue("TrackPersonPanelInfoFormatWithoutHeadedText", value); }
        }

        public string TrackPersonPanelLocalEmergencyCenterTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelLocalEmergencyCenterTitleText"); }
            set { this.SetValue("TrackPersonPanelLocalEmergencyCenterTitleText", value); }
        }

        public string TrackPersonPanelMph
        {
            get { return (string)this.GetValue("TrackPersonPanelMph"); }
            set { this.SetValue("TrackPersonPanelMph", value); }
        }

        public string TrackPersonPanelDirectionsButtonText
        {
            get { return (string)this.GetValue("TrackPersonPanelDirectionsButtonText"); }
            set { this.SetValue("TrackPersonPanelDirectionsButtonText", value); }
        }

        public string TrackPersonPanelMapOfFrequentLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelMapOfFrequentLabelText"); }
            set { this.SetValue("TrackPersonPanelMapOfFrequentLabelText", value); }
        }

        public string TrackPersonPanelNotificationZonesTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationZonesTitleText"); }
            set { this.SetValue("TrackPersonPanelNotificationZonesTitleText", value); }
        }

        public string TrackPersonPanelAddLocationCommandText
        {
            get { return (string)this.GetValue("TrackPersonPanelAddLocationCommandText"); }
            set { this.SetValue("TrackPersonPanelAddLocationCommandText", value); }
        }

        public string TrackPersonPanelNotificationSpeedTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationSpeedTitleText"); }
            set { this.SetValue("TrackPersonPanelNotificationSpeedTitleText", value); }
        }

        public string TrackPersonPanelNotificationSpeedText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationSpeedText"); }
            set { this.SetValue("TrackPersonPanelNotificationSpeedText", value); }
        }

        public string TrackPersonPanelNotificationSettingsTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationSettingsTitleText"); }
            set { this.SetValue("TrackPersonPanelNotificationSettingsTitleText", value); }
        }

        public string TrackPersonPanelInEmergencyText
        {
            get { return (string)this.GetValue("TrackPersonPanelInEmergencyText"); }
            set { this.SetValue("TrackPersonPanelInEmergencyText", value); }
        }

        public string TrackPersonPanelCaseArmedText
        {
            get { return (string)this.GetValue("TrackPersonPanelCaseArmedText"); }
            set { this.SetValue("TrackPersonPanelCaseArmedText", value); }
        }

        public string TrackPersonPanelNotificationZonesText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationZonesText"); }
            set { this.SetValue("TrackPersonPanelNotificationZonesText", value); }
        }

        public string TrackPersonPanelNotificationSoundsTitleText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationSoundsTitleText"); }
            set { this.SetValue("TrackPersonPanelNotificationSoundsTitleText", value); }
        }

        public string TrackPersonPanelRingtoneText
        {
            get { return (string)this.GetValue("TrackPersonPanelRingtoneText"); }
            set { this.SetValue("TrackPersonPanelRingtoneText", value); }
        }

        public string TrackPersonPanelNotificationText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationText"); }
            set { this.SetValue("TrackPersonPanelNotificationText", value); }
        }

        public string TrackPersonPanelStopTrackingCommandText
        {
            get { return (string)this.GetValue("TrackPersonPanelStopTrackingCommandText"); }
            set { this.SetValue("TrackPersonPanelStopTrackingCommandText", value); }
        }

        public string TrackPersonPanelArriveLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelArriveLabelText"); }
            set { this.SetValue("TrackPersonPanelArriveLabelText", value); }
        }

        public string TrackPersonPanelLeaveLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelLeaveLabelText"); }
            set { this.SetValue("TrackPersonPanelLeaveLabelText", value); }
        }

        public string TrackPersonPanelRingVibrateNotificationSettingLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelRingVibrateNotificationSettingLabelText"); }
            set { this.SetValue("TrackPersonPanelRingVibrateNotificationSettingLabelText", value); }
        }

        public string TrackPersonPanelVibrateNotificationSettingLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelVibrateNotificationSettingLabelText"); }
            set { this.SetValue("TrackPersonPanelVibrateNotificationSettingLabelText", value); }
        }

        public string TrackPersonPanelNotificationSettingLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotificationSettingLabelText"); }
            set { this.SetValue("TrackPersonPanelNotificationSettingLabelText", value); }
        }

        public string TrackPersonPanelNoNotificationSettingLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelNoNotificationSettingLabelText"); }
            set { this.SetValue("TrackPersonPanelNoNotificationSettingLabelText", value); }
        }

        public string TrackPersonPanelEmergencyButtonLabelText
        {
            get { return (string)this.GetValue("TrackPersonPanelEmergencyButtonLabelText"); }
            set { this.SetValue("TrackPersonPanelEmergencyButtonLabelText", value); }
        }

        public string TrackPersonPanelEmergencyButtonInactiviveText
        {
            get { return (string)this.GetValue("TrackPersonPanelEmergencyButtonInactiviveText"); }
            set { this.SetValue("TrackPersonPanelEmergencyButtonInactiviveText", value); }
        }

        public string TrackPersonPanelEmergencyButtonActiviveText
        {
            get { return (string)this.GetValue("TrackPersonPanelEmergencyButtonActiviveText"); }
            set { this.SetValue("TrackPersonPanelEmergencyButtonActiviveText", value); }
        }

        public string TrackPersonPanelTrackingRouteText
        {
            get { return (string)this.GetValue("TrackPersonPanelTrackingRouteText"); }
            set { this.SetValue("TrackPersonPanelTrackingRouteText", value); }
        }

        public string TrackPersonPanelNotTrackingRouteText
        {
            get { return (string)this.GetValue("TrackPersonPanelNotTrackingRouteText"); }
            set { this.SetValue("TrackPersonPanelNotTrackingRouteText", value); }
        }

        public string TrackPersonPanelEmergencyButtonAlarmText
        {
            get { return (string)this.GetValue("TrackPersonPanelEmergencyButtonAlarmText"); }
            set { this.SetValue("TrackPersonPanelEmergencyButtonAlarmText", value); }
        }

        public string TrackPersonPanelReportToPoliceText
        {
            get { return (string)this.GetValue("TrackPersonPanelReportToPoliceText"); }
            set { this.SetValue("TrackPersonPanelReportToPoliceText", value); }
        }

        public string TrackPersonPanelDirectThereText
        {
            get { return (string)this.GetValue("TrackPersonPanelDirectThereText"); }
            set { this.SetValue("TrackPersonPanelDirectThereText", value); }
        }

        public string TrackPersonPanelInBadSituationText
        {
            get { return (string)this.GetValue("TrackPersonPanelInBadSituationText"); }
            set { this.SetValue("TrackPersonPanelInBadSituationText", value); }
        }

        public string TrackPersonPanelDeviatedFromRouteText
        {
            get { return (string)this.GetValue("TrackPersonPanelDeviatedFromRouteText"); }
            set { this.SetValue("TrackPersonPanelDeviatedFromRouteText", value); }
        }

        public string TrackPersonPanelOnMyWayButtonText
        {
            get { return (string)this.GetValue("TrackPersonPanelOnMyWayButtonText"); }
            set { this.SetValue("TrackPersonPanelOnMyWayButtonText", value); }
        }

        public string TrackPersonPanelCallPoliceButtonText
        {
            get { return (string)this.GetValue("TrackPersonPanelCallPoliceButtonText"); }
            set { this.SetValue("TrackPersonPanelCallPoliceButtonText", value); }
        }

        public string TrackPersonPanelEventHasEndedButtonText
        {
            get { return (string)this.GetValue("TrackPersonPanelEventHasEndedButtonText"); }
            set { this.SetValue("TrackPersonPanelEventHasEndedButtonText", value); }
        }

        public string TrackPersonPanelEndCallButtonText
        {
            get { return (string)this.GetValue("TrackPersonPanelEndCallButtonText"); }
            set { this.SetValue("TrackPersonPanelEndCallButtonText", value); }
        }

        public string TrackPersonPanelVitalInfoText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoText", value); }
        }

        public string TrackPersonPanelVitalInfoNameText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoNameText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoNameText", value); }
        }

        public string TrackPersonPanelVitalInfoAgeText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoAgeText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoAgeText", value); }
        }

        public string TrackPersonPanelVitalInfoSexText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoSexText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoSexText", value); }
        }

        public string TrackPersonPanelVitalInfoHeightText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoHeightText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoHeightText", value); }
        }

        public string TrackPersonPanelVitalInfoEthnicityText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoEthnicityText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoEthnicityText", value); }
        }

        public string TrackPersonPanelVitalInfoHairColorText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoHairColorText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoHairColorText", value); }
        }

        public string TrackPersonPanelVitalInfoAllergiesText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoAllergiesText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoAllergiesText", value); }
        }

        public string TrackPersonPanelVitalInfoMedicationsText
        {
            get { return (string)this.GetValue("TrackPersonPanelVitalInfoMedicationsText"); }
            set { this.SetValue("TrackPersonPanelVitalInfoMedicationsText", value); }
        }
        #endregion

        #region Notification Settings Panel
        public string NotificationSettingsPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelBackCommandText"); }
            set { this.SetValue("NotificationSettingsPanelBackCommandText", value); }
        }

        public string NotificationSettingsPanelTitleText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelTitleText"); }
            set { this.SetValue("NotificationSettingsPanelTitleText", value); }
        }

        public string NotificationSettingsPanelNotificationsLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelNotificationsLabelText"); }
            set { this.SetValue("NotificationSettingsPanelNotificationsLabelText", value); }
        }

        public string NotificationSettingsPanelNotificationStyleLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelNotificationStyleLabelText"); }
            set { this.SetValue("NotificationSettingsPanelNotificationStyleLabelText", value); }
        }

        public string NotificationSettingsPanelBeAHeroItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelBeAHeroItemText"); }
            set { this.SetValue("NotificationSettingsPanelBeAHeroItemText", value); }
        }

        public string NotificationSettingsPanelReceiveSafetyTipsItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelReceiveSafetyTipsItemText"); }
            set { this.SetValue("NotificationSettingsPanelReceiveSafetyTipsItemText", value); }
        }

        public string NotificationSettingsPanelYouTrackInTroubleItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelYouTrackInTroubleItemText"); }
            set { this.SetValue("NotificationSettingsPanelYouTrackInTroubleItemText", value); }
        }

        public string NotificationSettingsPanelContactInTroubleItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelContactInTroubleItemText"); }
            set { this.SetValue("NotificationSettingsPanelContactInTroubleItemText", value); }
        }

        public string NotificationSettingsPanelContactInBadSituationItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelContactInBadSituationItemText"); }
            set { this.SetValue("NotificationSettingsPanelContactInBadSituationItemText", value); }
        }

        public string NotificationSettingsPanelNeedsYourHelpItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelNeedsYourHelpItemText"); }
            set { this.SetValue("NotificationSettingsPanelNeedsYourHelpItemText", value); }
        }

        public string NotificationSettingsPanelOtherNotificationItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelOtherNotificationItemText"); }
            set { this.SetValue("NotificationSettingsPanelOtherNotificationItemText", value); }
        }

        public string NotificationSettingsPanelGetAlertsItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelGetAlertsItemText"); }
            set { this.SetValue("NotificationSettingsPanelGetAlertsItemText", value); }
        }

        public string NotificationSettingsPanelGetAlertsTrackItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelGetAlertsTrackItemText"); }
            set { this.SetValue("NotificationSettingsPanelGetAlertsTrackItemText", value); }
        }

        public string NotificationSettingsPanelGetSafetyTipsItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelGetSafetyTipsItemText"); }
            set { this.SetValue("NotificationSettingsPanelGetSafetyTipsItemText", value); }
        }

        public string NotificationSettingsPanelContactInYeallowAlertItemText
        {
            get { return (string)this.GetValue("NotificationSettingsPanelContactInYeallowAlertItemText"); }
            set { this.SetValue("NotificationSettingsPanelContactInYeallowAlertItemText", value); }
        }
        #endregion

        #region Notification Settings Set Panel
        public string NotificationSettingsSetPanelTitleText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelTitleText"); }
            set { this.SetValue("NotificationSettingsSetPanelTitleText", value); }
        }

        public string NotificationSettingsSetPanelBackCommandText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelBackCommandText"); }
            set { this.SetValue("NotificationSettingsSetPanelBackCommandText", value); }
        }

        public string NotificationSettingsSetPanelTopInfoText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelTopInfoText"); }
            set { this.SetValue("NotificationSettingsSetPanelTopInfoText", value); }
        }

        public string NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText"); }
            set { this.SetValue("NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText", value); }
        }

        public string NotificationSettingsSetPanelRingVibrateNotificationLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelRingVibrateNotificationLabelText"); }
            set { this.SetValue("NotificationSettingsSetPanelRingVibrateNotificationLabelText", value); }
        }

        public string NotificationSettingsSetPanelVibrateNotificationLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelVibrateNotificationLabelText"); }
            set { this.SetValue("NotificationSettingsSetPanelVibrateNotificationLabelText", value); }
        }

        public string NotificationSettingsSetPanelNotificationLabelText
        {
            get { return (string)this.GetValue("NotificationSettingsSetPanelNotificationLabelText"); }
            set { this.SetValue("NotificationSettingsSetPanelNotificationLabelText", value); }
        }
        #endregion

        #region Verify Email Panel
        public string VerifyEmailPanelTitleText
        {
            get { return (string)this.GetValue("VerifyEmailPanelTitleText"); }
            set { this.SetValue("VerifyEmailPanelTitleText", value); }
        }

        public string VerifyEmailPanelBackCommandText
        {
            get { return (string)this.GetValue("VerifyEmailPanelBackCommandText"); }
            set { this.SetValue("VerifyEmailPanelBackCommandText", value); }
        }

        public string VerifyEmailPanelTopInfoText
        {
            get { return (string)this.GetValue("VerifyEmailPanelTopInfoText"); }
            set { this.SetValue("VerifyEmailPanelTopInfoText", value); }
        }

        public string VerifyEmailPanelEmailLabelText
        {
            get { return (string)this.GetValue("VerifyEmailPanelEmailLabelText"); }
            set { this.SetValue("VerifyEmailPanelEmailLabelText", value); }
        }

        public string VerifyEmailPanelResendEmailButtonText
        {
            get { return (string)this.GetValue("VerifyEmailPanelResendEmailButtonText"); }
            set { this.SetValue("VerifyEmailPanelResendEmailButtonText", value); }
        }
        #endregion

        #region Upgrade To Panel
        public string UpgradeToPanelSilverTitleText
        {
            get { return (string)this.GetValue("UpgradeToPanelSilverTitleText"); }
            set { this.SetValue("UpgradeToPanelSilverTitleText", value); }
        }

        public string UpgradeToPanelGoldTitleText
        {
            get { return (string)this.GetValue("UpgradeToPanelGoldTitleText"); }
            set { this.SetValue("UpgradeToPanelGoldTitleText", value); }
        }

        public string UpgradeToPanelBackCommandText
        {
            get { return (string)this.GetValue("UpgradeToPanelBackCommandText"); }
            set { this.SetValue("UpgradeToPanelBackCommandText", value); }
        }

        public string UpgradeToPanelRegularText
        {
            get { return (string)this.GetValue("UpgradeToPanelRegularText"); }
            set { this.SetValue("UpgradeToPanelRegularText", value); }
        }

        public string UpgradeToPanelStudentText
        {
            get { return (string)this.GetValue("UpgradeToPanelStudentText"); }
            set { this.SetValue("UpgradeToPanelStudentText", value); }
        }

        public string UpgradeToPanelPremiumSilverLabelText
        {
            get { return (string)this.GetValue("UpgradeToPanelPremiumSilverLabelText"); }
            set { this.SetValue("UpgradeToPanelPremiumSilverLabelText", value); }
        }

        public string UpgradeToPanelPremiumGoldLabelText
        {
            get { return (string)this.GetValue("UpgradeToPanelPremiumGoldLabelText"); }
            set { this.SetValue("UpgradeToPanelPremiumGoldLabelText", value); }
        }

        public string UpgradeToPanelMonthlySubscribtionText
        {
            get { return (string)this.GetValue("UpgradeToPanelMonthlySubscribtionText"); }
            set { this.SetValue("UpgradeToPanelMonthlySubscribtionText", value); }
        }

        public string UpgradeToPanelYearlySubscribtionText
        {
            get { return (string)this.GetValue("UpgradeToPanelYearlySubscribtionText"); }
            set { this.SetValue("UpgradeToPanelYearlySubscribtionText", value); }
        }

        public string UpgradeToPanelDiscountCodeLabelText
        {
            get { return (string)this.GetValue("UpgradeToPanelDiscountCodeLabelText"); }
            set { this.SetValue("UpgradeToPanelDiscountCodeLabelText", value); }
        }

        public string UpgradeToPanelDiscountCodePlaceholderText
        {
            get { return (string)this.GetValue("UpgradeToPanelDiscountCodePlaceholderText"); }
            set { this.SetValue("UpgradeToPanelDiscountCodePlaceholderText", value); }
        }

        public string UpgradeToPanelDiscountCodeNiceText
        {
            get { return (string)this.GetValue("UpgradeToPanelDiscountCodeNiceText"); }
            set { this.SetValue("UpgradeToPanelDiscountCodeNiceText", value); }
        }

        public string UpgradeToPanelContinueButtonText
        {
            get { return (string)this.GetValue("UpgradeToPanelContinueButtonText"); }
            set { this.SetValue("UpgradeToPanelContinueButtonText", value); }
        }

        public string UpgradeToPanelUpgradeToGold
        {
            get { return (string)this.GetValue("UpgradeToPanelUpgradeToGold"); }
            set { this.SetValue("UpgradeToPanelUpgradeToGold", value); }
        }

        public string UpgradeToPanelAnnualSubscribtionText
        {
            get { return (string)this.GetValue("UpgradeToPanelAnnualSubscribtionText"); }
            set { this.SetValue("UpgradeToPanelAnnualSubscribtionText", value); }
        }
        #endregion

        #region Check Out Panel
        public string CheckOutPanelTitleText
        {
            get { return (string)this.GetValue("CheckOutPanelTitleText"); }
            set { this.SetValue("CheckOutPanelTitleText", value); }
        }

        public string CheckOutPanelBackButtonText
        {
            get { return (string)this.GetValue("CheckOutPanelBackButtonText"); }
            set { this.SetValue("CheckOutPanelBackButtonText", value); }
        }

        public string CheckOutPanelTaxText
        {
            get { return (string)this.GetValue("CheckOutPanelTaxText"); }
            set { this.SetValue("CheckOutPanelTaxText", value); }
        }

        public string CheckOutPanelTotalText
        {
            get { return (string)this.GetValue("CheckOutPanelTotalText"); }
            set { this.SetValue("CheckOutPanelTotalText", value); }
        }

        public string CheckOutPanelGiftTheAppButtonText
        {
            get { return (string)this.GetValue("CheckOutPanelGiftTheAppButtonText"); }
            set { this.SetValue("CheckOutPanelGiftTheAppButtonText", value); }
        }

        public string CheckOutPanelCheckOutButtonText
        {
            get { return (string)this.GetValue("CheckOutPanelCheckOutButtonText"); }
            set { this.SetValue("CheckOutPanelCheckOutButtonText", value); }
        }
        #endregion

        #region Ringtone Panel
        public string RingtonePanelBackCommandText
        {
            get { return (string)this.GetValue("RingtonePanelBackCommandText"); }
            set { this.SetValue("RingtonePanelBackCommandText", value); }
        }

        public string RingtonePanelTitleText
        {
            get { return (string)this.GetValue("RingtonePanelTitleText"); }
            set { this.SetValue("RingtonePanelTitleText", value); }
        }
        #endregion

        #region Gift The App Panel
        public string GiftTheAppPanelTitleText
        {
            get { return (string)this.GetValue("GiftTheAppPanelTitleText"); }
            set { this.SetValue("GiftTheAppPanelTitleText", value); }
        }

        public string GiftTheAppPanelBackButtonText
        {
            get { return (string)this.GetValue("GiftTheAppPanelBackButtonText"); }
            set { this.SetValue("GiftTheAppPanelBackButtonText", value); }
        }

        public string GiftTheAppPanelGiftToText
        {
            get { return (string)this.GetValue("GiftTheAppPanelGiftToText"); }
            set { this.SetValue("GiftTheAppPanelGiftToText", value); }
        }

        public string GiftTheAppPanelPremiumSilverLabelText
        {
            get { return (string)this.GetValue("GiftTheAppPanelPremiumSilverLabelText"); }
            set { this.SetValue("GiftTheAppPanelPremiumSilverLabelText", value); }
        }

        public string GiftTheAppPanelSilverMonthlySubscriptionText
        {
            get { return (string)this.GetValue("GiftTheAppPanelSilverMonthlySubscriptionText"); }
            set { this.SetValue("GiftTheAppPanelSilverMonthlySubscriptionText", value); }
        }

        public string GiftTheAppPanelSilverYearlySubscriptionText
        {
            get { return (string)this.GetValue("GiftTheAppPanelSilverYearlySubscriptionText"); }
            set { this.SetValue("GiftTheAppPanelSilverYearlySubscriptionText", value); }
        }

        public string GiftTheAppPanelPremiumGoldLabelText
        {
            get { return (string)this.GetValue("GiftTheAppPanelPremiumGoldLabelText"); }
            set { this.SetValue("GiftTheAppPanelPremiumGoldLabelText", value); }
        }

        public string GiftTheAppPanelGoldMonthlySubscriptionText
        {
            get { return (string)this.GetValue("GiftTheAppPanelGoldMonthlySubscriptionText"); }
            set { this.SetValue("GiftTheAppPanelGoldMonthlySubscriptionText", value); }
        }

        public string GiftTheAppPanelGoldYearlySubscriptionText
        {
            get { return (string)this.GetValue("GiftTheAppPanelGoldYearlySubscriptionText"); }
            set { this.SetValue("GiftTheAppPanelGoldYearlySubscriptionText", value); }
        }

        public string GiftTheAppPanelContinueButtonText
        {
            get { return (string)this.GetValue("GiftTheAppPanelContinueButtonText"); }
            set { this.SetValue("GiftTheAppPanelContinueButtonText", value); }
        }

        public string GiftTheAppPanelAnnualSubscribtionText
        {
            get { return (string)this.GetValue("GiftTheAppPanelAnnualSubscribtionText"); }
            set { this.SetValue("GiftTheAppPanelAnnualSubscribtionText", value); }
        }
        #endregion

        #region Gift The App Start Panel
        public string GiftTheAppStartTitleText
        {
            get { return (string)this.GetValue("GiftTheAppStartTitleText"); }
            set { this.SetValue("GiftTheAppStartTitleText", value); }
        }

        public string GiftTheAppStartTopInfoText
        {
            get { return (string)this.GetValue("GiftTheAppStartTopInfoText"); }
            set { this.SetValue("GiftTheAppStartTopInfoText", value); }
        }

        public string GiftTheAppStartChooseWhoButtonText
        {
            get { return (string)this.GetValue("GiftTheAppStartChooseWhoButtonText"); }
            set { this.SetValue("GiftTheAppStartChooseWhoButtonText", value); }
        }
        #endregion

        #region Check Out Card Panel
        public string CheckOutCardPanelTitleText
        {
            get { return (string)this.GetValue("CheckOutCardPanelTitleText"); }
            set { this.SetValue("CheckOutCardPanelTitleText", value); }
        }

        public string CheckOutCardPanelBackButtonText
        {
            get { return (string)this.GetValue("CheckOutCardPanelBackButtonText"); }
            set { this.SetValue("CheckOutCardPanelBackButtonText", value); }
        }

        public string CheckOutCardPanelTopInfoText
        {
            get { return (string)this.GetValue("CheckOutCardPanelTopInfoText"); }
            set { this.SetValue("CheckOutCardPanelTopInfoText", value); }
        }

        public string CheckOutCardPanelCardNumberLabelText
        {
            get { return (string)this.GetValue("CheckOutCardPanelCardNumberLabelText"); }
            set { this.SetValue("CheckOutCardPanelCardNumberLabelText", value); }
        }

        public string CheckOutCardPanelCardNumberPlaceholderText
        {
            get { return (string)this.GetValue("CheckOutCardPanelCardNumberPlaceholderText"); }
            set { this.SetValue("CheckOutCardPanelCardNumberPlaceholderText", value); }
        }

        public string CheckOutCardPanelFullNameLabelText
        {
            get { return (string)this.GetValue("CheckOutCardPanelFullNameLabelText"); }
            set { this.SetValue("CheckOutCardPanelFullNameLabelText", value); }
        }

        public string CheckOutCardPanelFullNamePlaceholderText
        {
            get { return (string)this.GetValue("CheckOutCardPanelFullNamePlaceholderText"); }
            set { this.SetValue("CheckOutCardPanelFullNamePlaceholderText", value); }
        }

        public string CheckOutCardPanelExpirationDateLabelText
        {
            get { return (string)this.GetValue("CheckOutCardPanelExpirationDateLabelText"); }
            set { this.SetValue("CheckOutCardPanelExpirationDateLabelText", value); }
        }

        public string CheckOutCardPanelExpirationDatePlaceholderText
        {
            get { return (string)this.GetValue("CheckOutCardPanelExpirationDatePlaceholderText"); }
            set { this.SetValue("CheckOutCardPanelExpirationDatePlaceholderText", value); }
        }

        public string CheckOutCardPanelCVCLabelText
        {
            get { return (string)this.GetValue("CheckOutCardPanelCVCLabelText"); }
            set { this.SetValue("CheckOutCardPanelCVCLabelText", value); }
        }

        public string CheckOutCardPanelCVCPlaceholderText
        {
            get { return (string)this.GetValue("CheckOutCardPanelCVCPlaceholderText"); }
            set { this.SetValue("CheckOutCardPanelCVCPlaceholderText", value); }
        }

        public string CheckOutCardPanelPurchaseSubscribtionButtonText
        {
            get { return (string)this.GetValue("CheckOutCardPanelPurchaseSubscribtionButtonText"); }
            set { this.SetValue("CheckOutCardPanelPurchaseSubscribtionButtonText", value); }
        }
        #endregion

        #region Set Tracking Zone Panel
        public string SetTrackingZonePanelBackCommandText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelBackCommandText"); }
            set { this.SetValue("SetTrackingZonePanelBackCommandText", value); }
        }

        public string SetTrackingZonePanelTitleText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelTitleText"); }
            set { this.SetValue("SetTrackingZonePanelTitleText", value); }
        }

        public string SetTrackingZonePanelSaveCommandText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelSaveCommandText"); }
            set { this.SetValue("SetTrackingZonePanelSaveCommandText", value); }
        }

        public string SetTrackingZonePanelSearchLocationText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelSearchLocationText"); }
            set { this.SetValue("SetTrackingZonePanelSearchLocationText", value); }
        }

        public string SetTrackingZonePanelLocationNameText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelLocationNameText"); }
            set { this.SetValue("SetTrackingZonePanelLocationNameText", value); }
        }

        public string SetTrackingZonePanelNotifyWhenText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelNotifyWhenText"); }
            set { this.SetValue("SetTrackingZonePanelNotifyWhenText", value); }
        }

        public string SetTrackingZonePanelArrivesText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelArrivesText"); }
            set { this.SetValue("SetTrackingZonePanelArrivesText", value); }
        }

        public string SetTrackingZonePanelLeavesText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelLeavesText"); }
            set { this.SetValue("SetTrackingZonePanelLeavesText", value); }
        }

        public string SetTrackingZonePanelDeleteCommandText
        {
            get { return (string)this.GetValue("SetTrackingZonePanelDeleteCommandText"); }
            set { this.SetValue("SetTrackingZonePanelDeleteCommandText", value); }
        }
        #endregion

        #region Share Your Location Panel
        public string ShareYourLocationPanelTitleText
        {
            get { return (string)this.GetValue("ShareYourLocationPanelTitleText"); }
            set { this.SetValue("ShareYourLocationPanelTitleText", value); }
        }

        public string ShareYourLocationPanelBackCommandText
        {
            get { return (string)this.GetValue("ShareYourLocationPanelBackCommandText"); }
            set { this.SetValue("ShareYourLocationPanelBackCommandText", value); }
        }

        public string ShareYourLocationPanelTopInfoText
        {
            get { return (string)this.GetValue("ShareYourLocationPanelTopInfoText"); }
            set { this.SetValue("ShareYourLocationPanelTopInfoText", value); }
        }

        public string ShareViewLocationPanelYesButtonText
        {
            get { return (string)this.GetValue("ShareViewLocationPanelYesButtonText"); }
            set { this.SetValue("ShareViewLocationPanelYesButtonText", value); }
        }

        public string ShareViewLocationPanelNoButtonText
        {
            get { return (string)this.GetValue("ShareViewLocationPanelNoButtonText"); }
            set { this.SetValue("ShareViewLocationPanelNoButtonText", value); }
        }

        public string ShareViewLocationPanelBottomInfoText
        {
            get { return (string)this.GetValue("ShareViewLocationPanelBottomInfoText"); }
            set { this.SetValue("ShareViewLocationPanelBottomInfoText", value); }
        }

        public string ShareViewLocationPanelPendingApprovalText
        {
            get { return (string)this.GetValue("ShareViewLocationPanelPendingApprovalText"); }
            set { this.SetValue("ShareViewLocationPanelPendingApprovalText", value); }
        }

        public string ShareYourLocationPanelShareInfoText
        {
            get { return (string)this.GetValue("ShareYourLocationPanelShareInfoText"); }
            set { this.SetValue("ShareYourLocationPanelShareInfoText", value); }
        }

        public string ShareViewLocationPanelShareBottomInfoText
        {
            get { return (string)this.GetValue("ShareViewLocationPanelShareBottomInfoText"); }
            set { this.SetValue("ShareViewLocationPanelShareBottomInfoText", value); }
        }
        #endregion

        #region Route Out Emergency Activated Panel
        public string RouteOutEmergencyActivatedPanelTitleText
        {
            get { return (string)this.GetValue("RouteOutEmergencyActivatedPanelTitleText"); }
            set { this.SetValue("RouteOutEmergencyActivatedPanelTitleText", value); }
        }

        public string RouteOutEmergencyActivatedPanelTopInfoText
        {
            get { return (string)this.GetValue("RouteOutEmergencyActivatedPanelTopInfoText"); }
            set { this.SetValue("RouteOutEmergencyActivatedPanelTopInfoText", value); }
        }

        public string RouteOutEmergencyActivatedPanelSendingText
        {
            get { return (string)this.GetValue("RouteOutEmergencyActivatedPanelSendingText"); }
            set { this.SetValue("RouteOutEmergencyActivatedPanelSendingText", value); }
        }

        public string RouteOutEmergencyActivatedPanelSecondsTemplate
        {
            get { return (string)this.GetValue("RouteOutEmergencyActivatedPanelSecondsTemplate"); }
            set { this.SetValue("RouteOutEmergencyActivatedPanelSecondsTemplate", value); }
        }

        public string RouteOutEmergencyActivatedPanelPasscodeText
        {
            get { return (string)this.GetValue("RouteOutEmergencyActivatedPanelPasscodeText"); }
            set { this.SetValue("RouteOutEmergencyActivatedPanelPasscodeText", value); }
        }
        #endregion

        #region Add New Route Panel
        public string AddNewRoutePanelHeaderText
        {
            get { return (string)this.GetValue("AddNewRoutePanelHeaderText"); }
            set { this.SetValue("AddNewRoutePanelHeaderText", value); }
        }

        public string AddNewRoutePanelNewEditText
        {
            get { return (string)this.GetValue("AddNewRoutePanelNewEditText"); }
            set { this.SetValue("AddNewRoutePanelNewEditText", value); }
        }

        public string AddNewRoutePanelNewEditContentText
        {
            get { return (string)this.GetValue("AddNewRoutePanelNewEditContentText"); }
            set { this.SetValue("AddNewRoutePanelNewEditContentText", value); }
        }

        public string AddNewRoutePanelGenerateEditText
        {
            get { return (string)this.GetValue("AddNewRoutePanelGenerateEditText"); }
            set { this.SetValue("AddNewRoutePanelGenerateEditText", value); }
        }

        public string AddNewRoutePanelRecordText
        {
            get { return (string)this.GetValue("AddNewRoutePanelRecordText"); }
            set { this.SetValue("AddNewRoutePanelRecordText", value); }
        }

        public string AddNewRoutePanelGenerateEditContentText
        {
            get { return (string)this.GetValue("AddNewRoutePanelGenerateEditContentText"); }
            set { this.SetValue("AddNewRoutePanelGenerateEditContentText", value); }
        }

        public string AddNewRoutePanelRecordContentText
        {
            get { return (string)this.GetValue("AddNewRoutePanelRecordContentText"); }
            set { this.SetValue("AddNewRoutePanelRecordContentText", value); }
        }
        #endregion

        #region EditRouteNameDialog
        public string EditRouteNameDialogTitleText
        {
            get { return (string)this.GetValue("EditRouteNameDialogTitleText"); }
            set { this.SetValue("EditRouteNameDialogTitleText", value); }
        }

        public string EditRouteNameDialogNamePlaceholderText
        {
            get { return (string)this.GetValue("EditRouteNameDialogNamePlaceholderText"); }
            set { this.SetValue("EditRouteNameDialogNamePlaceholderText", value); }
        }

        public string EditRouteNameDialogCancelButtonText
        {
            get { return (string)this.GetValue("EditRouteNameDialogCancelButtonText"); }
            set { this.SetValue("EditRouteNameDialogCancelButtonText", value); }
        }

        public string EditRouteNameDialogSaveButtonText
        {
            get { return (string)this.GetValue("EditRouteNameDialogSaveButtonText"); }
            set { this.SetValue("EditRouteNameDialogSaveButtonText", value); }
        }
        #endregion

        #region EditSpeedLimitDialog
        public string EditSpeedLimitDialogTitleText
        {
            get { return (string)this.GetValue("EditSpeedLimitDialogTitleText"); }
            set { this.SetValue("EditSpeedLimitDialogTitleText", value); }
        }

        public string EditSpeedLimitDialogSpeedLimitPlaceholderText
        {
            get { return (string)this.GetValue("EditSpeedLimitDialogSpeedLimitPlaceholderText"); }
            set { this.SetValue("EditSpeedLimitDialogSpeedLimitPlaceholderText", value); }
        }

        public string EditSpeedLimitDialogCancelButtonText
        {
            get { return (string)this.GetValue("EditSpeedLimitDialogCancelButtonText"); }
            set { this.SetValue("EditSpeedLimitDialogCancelButtonText", value); }
        }

        public string EditSpeedLimitDialogSaveButtonText
        {
            get { return (string)this.GetValue("EditSpeedLimitDialogSaveButtonText"); }
            set { this.SetValue("EditSpeedLimitDialogSaveButtonText", value); }
        }
        #endregion

        #region EditPasswordDialog
        public string EditPasswordDialogTitleText
        {
            get { return (string)this.GetValue("EditPasswordDialogTitleText"); }
            set { this.SetValue("EditPasswordDialogTitleText", value); }
        }

        public string EditPasswordDialogPasscodePlaceholderText
        {
            get { return (string)this.GetValue("EditPasswordDialogPasscodePlaceholderText"); }
            set { this.SetValue("EditPasswordDialogPasscodePlaceholderText", value); }
        }

        public string EditPasswordDialogCancelButtonText
        {
            get { return (string)this.GetValue("EditPasswordDialogCancelButtonText"); }
            set { this.SetValue("EditPasswordDialogCancelButtonText", value); }
        }

        public string EditPasswordDialogOkButtonText
        {
            get { return (string)this.GetValue("EditPasswordDialogOkButtonText"); }
            set { this.SetValue("EditPasswordDialogOkButtonText", value); }
        }

        public string EditPasswordDialogForgotPasscodeButtonText
        {
            get { return (string)this.GetValue("EditPasswordDialogForgotPasscodeButtonText"); }
            set { this.SetValue("EditPasswordDialogForgotPasscodeButtonText", value); }
        }
        #endregion

        #region Saved Route Hide Panel
        public string SavedRouteHidePanelRouteName
        {
            get { return (string)this.GetValue("SavedRouteHidePanelRouteName"); }
            set { this.SetValue("SavedRouteHidePanelRouteName", value); }
        }

        public string SavedRouteHidePanelStartButtonText
        {
            get { return (string)this.GetValue("SavedRouteHidePanelStartButtonText"); }
            set { this.SetValue("SavedRouteHidePanelStartButtonText", value); }
        }
        #endregion

        #region Friends List Panel
        public string FriendsListPanelTitleText
        {
            get { return (string)this.GetValue("FriendsListPanelTitleText"); }
            set { this.SetValue("FriendsListPanelTitleText", value); }
        }
        #endregion

        #region Lock Settings Panel
        public string LockSettingsPanelTitleText
        {
            get { return (string)this.GetValue("LockSettingsPanelTitleText"); }
            set { this.SetValue("LockSettingsPanelTitleText", value); }
        }

        public string LockSettingsPanelNextCommandText
        {
            get { return (string)this.GetValue("LockSettingsPanelNextCommandText"); }
            set { this.SetValue("LockSettingsPanelNextCommandText", value); }
        }

        public string LockSettingsPanelSettingsProtectedText
        {
            get { return (string)this.GetValue("LockSettingsPanelSettingsProtectedText"); }
            set { this.SetValue("LockSettingsPanelSettingsProtectedText", value); }
        }

        public string LockSettingsPanelOldPasswordLabelText
        {
            get { return (string)this.GetValue("LockSettingsPanelOldPasswordLabelText"); }
            set { this.SetValue("LockSettingsPanelOldPasswordLabelText", value); }
        }

        public string LockSettingsPanelNewPasswordLabelText
        {
            get { return (string)this.GetValue("LockSettingsPanelNewPasswordLabelText"); }
            set { this.SetValue("LockSettingsPanelNewPasswordLabelText", value); }
        }

        public string LockSettingsPanelReenterPasswordLabelText
        {
            get { return (string)this.GetValue("LockSettingsPanelReenterPasswordLabelText"); }
            set { this.SetValue("LockSettingsPanelReenterPasswordLabelText", value); }
        }

        public string LockSettingsPanelForgotPasscodeCommandText
        {
            get { return (string)this.GetValue("LockSettingsPanelForgotPasscodeCommandText"); }
            set { this.SetValue("LockSettingsPanelForgotPasscodeCommandText", value); }
        }
        #endregion

        #region Track Friends And Family Pane;
        public string TrackFriendsPanelTitleText
        {
            get { return (string)this.GetValue("TrackFriendsPanelTitleText"); }
            set { this.SetValue("TrackFriendsPanelTitleText", value); }
        }

        public string TrackFriendsPanelYourPeopleLabelText
        {
            get { return (string)this.GetValue("TrackFriendsPanelYourPeopleLabelText"); }
            set { this.SetValue("TrackFriendsPanelYourPeopleLabelText", value); }
        }

        public string TrackFriendsPanelPendingApproval
        {
            get { return (string)this.GetValue("TrackFriendsPanelPendingApproval"); }
            set { this.SetValue("TrackFriendsPanelPendingApproval", value); }
        }

        public string TrackFriendsPanelAddPeopleCommandText
        {
            get { return (string)this.GetValue("TrackFriendsPanelAddPeopleCommandText"); }
            set { this.SetValue("TrackFriendsPanelAddPeopleCommandText", value); }
        }
        #endregion

        #region Location Auto Complete Panel
        public string LocationAutoCompletePanelSearchLocationPlaceholderText
        {
            get { return (string)this.GetValue("LocationAutoCompletePanelSearchLocationPlaceholderText"); }
            set { this.SetValue("LocationAutoCompletePanelSearchLocationPlaceholderText", value); }
        }
        #endregion

        #region Incident Ended Panel
        public string IncidentEndedPanelTitleText
        {
            get { return (string)this.GetValue("IncidentEndedPanelTitleText"); }
            set { this.SetValue("IncidentEndedPanelTitleText", value); }
        }

        public string IncidentEndedPanelTopInfoText
        {
            get { return (string)this.GetValue("IncidentEndedPanelTopInfoText"); }
            set { this.SetValue("IncidentEndedPanelTopInfoText", value); }
        }

        public string IncidentEndedPanelEvidenceText
        {
            get { return (string)this.GetValue("IncidentEndedPanelEvidenceText"); }
            set { this.SetValue("IncidentEndedPanelEvidenceText", value); }
        }

        public string IncidentEndedPanelRecordingText
        {
            get { return (string)this.GetValue("IncidentEndedPanelRecordingText"); }
            set { this.SetValue("IncidentEndedPanelRecordingText", value); }
        }

        public string IncidentEndedPanelWhatHappenedLabelText
        {
            get { return (string)this.GetValue("IncidentEndedPanelWhatHappenedLabelText"); }
            set { this.SetValue("IncidentEndedPanelWhatHappenedLabelText", value); }
        }

        public string IncidentEndedPanelSendCommandText
        {
            get { return (string)this.GetValue("IncidentEndedPanelSendCommandText"); }
            set { this.SetValue("IncidentEndedPanelSendCommandText", value); }
        }

        public string IncidentEndedPanelSendButtonText
        {
            get { return (string)this.GetValue("IncidentEndedPanelSendButtonText"); }
            set { this.SetValue("IncidentEndedPanelSendButtonText", value); }
        }
        #endregion

        #region Help Person Panel
        public string HelpPersonPanelCurrentLocationTitleText
        {
            get { return (string)this.GetValue("HelpPersonPanelCurrentLocationTitleText"); }
            set { this.SetValue("HelpPersonPanelCurrentLocationTitleText", value); }
        }

        public string HelpPersonPanelSecondsFormatText
        {
            get { return (string)this.GetValue("HelpPersonPanelSecondsFormatText"); }
            set { this.SetValue("HelpPersonPanelSecondsFormatText", value); }
        }

        public string HelpPersonPanelMinutesFormatText
        {
            get { return (string)this.GetValue("HelpPersonPanelMinutesFormatText"); }
            set { this.SetValue("HelpPersonPanelMinutesFormatText", value); }
        }

        public string HelpPersonPanelInfoFormatText
        {
            get { return (string)this.GetValue("HelpPersonPanelInfoFormatText"); }
            set { this.SetValue("HelpPersonPanelInfoFormatText", value); }
        }

        public string HelpPersonPanelOnMyWayText
        {
            get { return (string)this.GetValue("HelpPersonPanelOnMyWayText"); }
            set { this.SetValue("HelpPersonPanelOnMyWayText", value); }
        }

        public string HelpPersonPanelEventHasEndedText
        {
            get { return (string)this.GetValue("HelpPersonPanelEventHasEndedText"); }
            set { this.SetValue("HelpPersonPanelEventHasEndedText", value); }
        }

        public string HelpPersonPanelCallPoliceText
        {
            get { return (string)this.GetValue("HelpPersonPanelCallPoliceText"); }
            set { this.SetValue("HelpPersonPanelCallPoliceText", value); }
        }

        public string HelpPersonPanelEndCallText
        {
            get { return (string)this.GetValue("HelpPersonPanelEndCallText"); }
            set { this.SetValue("HelpPersonPanelEndCallText", value); }
        }

        public string HelpPersonPanelVitalInfoLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelVitalInfoLabelText"); }
            set { this.SetValue("HelpPersonPanelVitalInfoLabelText", value); }
        }

        public string HelpPersonPanelNameLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelNameLabelText"); }
            set { this.SetValue("HelpPersonPanelNameLabelText", value); }
        }

        public string HelpPersonPanelAgeLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelAgeLabelText"); }
            set { this.SetValue("HelpPersonPanelAgeLabelText", value); }
        }

        public string HelpPersonPanelSexLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelSexLabelText"); }
            set { this.SetValue("HelpPersonPanelSexLabelText", value); }
        }

        public string HelpPersonPanelHeightLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelHeightLabelText"); }
            set { this.SetValue("HelpPersonPanelHeightLabelText", value); }
        }

        public string HelpPersonPanelEthnicityLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelEthnicityLabelText"); }
            set { this.SetValue("HelpPersonPanelEthnicityLabelText", value); }
        }

        public string HelpPersonPanelHairColorLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelHairColorLabelText"); }
            set { this.SetValue("HelpPersonPanelHairColorLabelText", value); }
        }

        public string HelpPersonPanelAllergiesLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelAllergiesLabelText"); }
            set { this.SetValue("HelpPersonPanelAllergiesLabelText", value); }
        }

        public string HelpPersonPanelMedicationsLabelText
        {
            get { return (string)this.GetValue("HelpPersonPanelMedicationsLabelText"); }
            set { this.SetValue("HelpPersonPanelMedicationsLabelText", value); }
        }
        #endregion

        #region Person At Incident Panel
        public string PersonAtIncidentPanelTopInfoText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelTopInfoText"); }
            set { this.SetValue("PersonAtIncidentPanelTopInfoText", value); }
        }

        public string PersonAtIncidentPanelCurrentLocationTitleText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelCurrentLocationTitleText"); }
            set { this.SetValue("PersonAtIncidentPanelCurrentLocationTitleText", value); }
        }

        public string PersonAtIncidentPanelSecondsFormatText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelSecondsFormatText"); }
            set { this.SetValue("PersonAtIncidentPanelSecondsFormatText", value); }
        }

        public string PersonAtIncidentPanelMinutesFormatText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelMinutesFormatText"); }
            set { this.SetValue("PersonAtIncidentPanelMinutesFormatText", value); }
        }

        public string PersonAtIncidentPanelInfoFormatText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelInfoFormatText"); }
            set { this.SetValue("PersonAtIncidentPanelInfoFormatText", value); }
        }

        public string PersonAtIncidentPanelEventHasEndedText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelEventHasEndedText"); }
            set { this.SetValue("PersonAtIncidentPanelEventHasEndedText", value); }
        }

        public string PersonAtIncidentPanelCallPoliceText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelCallPoliceText"); }
            set { this.SetValue("PersonAtIncidentPanelCallPoliceText", value); }
        }

        public string PersonAtIncidentPanelEndCallText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelEndCallText"); }
            set { this.SetValue("PersonAtIncidentPanelEndCallText", value); }
        }

        public string PersonAtIncidentPanelVitalInfoLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelVitalInfoLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelVitalInfoLabelText", value); }
        }

        public string PersonAtIncidentPanelNameLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelNameLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelNameLabelText", value); }
        }

        public string PersonAtIncidentPanelAgeLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelAgeLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelAgeLabelText", value); }
        }

        public string PersonAtIncidentPanelSexLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelSexLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelSexLabelText", value); }
        }

        public string PersonAtIncidentPanelHeightLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelHeightLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelHeightLabelText", value); }
        }

        public string PersonAtIncidentPanelEthnicityLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelEthnicityLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelEthnicityLabelText", value); }
        }

        public string PersonAtIncidentPanelHairColorLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelHairColorLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelHairColorLabelText", value); }
        }

        public string PersonAtIncidentPanelAllergiesLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelAllergiesLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelAllergiesLabelText", value); }
        }

        public string PersonAtIncidentPanelMedicationsLabelText
        {
            get { return (string)this.GetValue("PersonAtIncidentPanelMedicationsLabelText"); }
            set { this.SetValue("PersonAtIncidentPanelMedicationsLabelText", value); }
        }
        #endregion

        #region Verify Email Popup panel
        public string VerifyEmailPopupPanelTitleText
        {
            get { return (string)this.GetValue("VerifyEmailPopupPanelTitleText"); }
            set { this.SetValue("VerifyEmailPopupPanelTitleText", value); }
        }

        public string VerifyEmailPopupPanelInfoText
        {
            get { return (string)this.GetValue("VerifyEmailPopupPanelInfoText"); }
            set { this.SetValue("VerifyEmailPopupPanelInfoText", value); }
        }

        public string VerifyEmailPopupPanelGotItButtonText
        {
            get { return (string)this.GetValue("VerifyEmailPopupPanelGotItButtonText"); }
            set { this.SetValue("VerifyEmailPopupPanelGotItButtonText", value); }
        }
        #endregion

        #region Contacts Info Panel
        public string ContactsInfoPanelPendingApprovalText
        {
            get { return (string)this.GetValue("ContactsInfoPanelPendingApprovalText"); }
            set { this.SetValue("ContactsInfoPanelPendingApprovalText", value); }
        }

        public string ContactsInfoPanelLocationSharingPauseText
        {
            get { return (string)this.GetValue("ContactsInfoPanelLocationSharingPauseText"); }
            set { this.SetValue("ContactsInfoPanelLocationSharingPauseText", value); }
        }

        public string ContactsInfoPanelPermissionGrantedText
        {
            get { return (string)this.GetValue("ContactsInfoPanelPermissionGrantedText"); }
            set { this.SetValue("ContactsInfoPanelPermissionGrantedText", value); }
        }
        #endregion

        #region Blocked People Page
        public string BlockedPeoplePageTitleText
        {
            get { return (string)this.GetValue("BlockedPeoplePageTitleText"); }
            set { this.SetValue("BlockedPeoplePageTitleText", value); }
        }

        public string BlockedPeoplePageTopInfoText
        {
            get { return (string)this.GetValue("BlockedPeoplePageTopInfoText"); }
            set { this.SetValue("BlockedPeoplePageTopInfoText", value); }
        }

        public string BlockedPeoplePageFirstNameLabelText
        {
            get { return (string)this.GetValue("BlockedPeoplePageFirstNameLabelText"); }
            set { this.SetValue("BlockedPeoplePageFirstNameLabelText", value); }
        }

        public string BlockedPeoplePageLastNameLabelText
        {
            get { return (string)this.GetValue("BlockedPeoplePageLastNameLabelText"); }
            set { this.SetValue("BlockedPeoplePageLastNameLabelText", value); }
        }

        public string BlockedPeoplePageEmailLabelText
        {
            get { return (string)this.GetValue("BlockedPeoplePageEmailLabelText"); }
            set { this.SetValue("BlockedPeoplePageEmailLabelText", value); }
        }

        public string BlockedPeoplePagePhoneLabelText
        {
            get { return (string)this.GetValue("BlockedPeoplePagePhoneLabelText"); }
            set { this.SetValue("BlockedPeoplePagePhoneLabelText", value); }
        }

        public string BlockedPeoplePageBlockButtonText
        {
            get { return (string)this.GetValue("BlockedPeoplePageBlockButtonText"); }
            set { this.SetValue("BlockedPeoplePageBlockButtonText", value); }
        }

        public string BlockedPeoplePageUnblockButtonText
        {
            get { return (string)this.GetValue("BlockedPeoplePageUnblockButtonText"); }
            set { this.SetValue("BlockedPeoplePageUnblockButtonText", value); }
        }

        public string BlockedPeoplePageAddPersonCommandText
        {
            get { return (string)this.GetValue("BlockedPeoplePageAddPersonCommandText"); }
            set { this.SetValue("BlockedPeoplePageAddPersonCommandText", value); }
        }
        #endregion
    }
    #endregion
}
