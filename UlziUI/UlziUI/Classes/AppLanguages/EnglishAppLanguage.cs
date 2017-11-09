using System;
using System.Collections.Generic;
using System.Text;

namespace UlziUI.Classes.AppLanguages
{
    #region EnglishAppLanguage 
    public class EnglishAppLanguage : AppLanguage
    {
        public EnglishAppLanguage() : base(AppLanguages.ENGLISH_LANGUAGE_NAME)
        {
            this.AppName = "Ulzi";

            #region Alert Dialog strings
            this.AlertDialogOKAnswerText = "OK";
            this.AlertDialogYesAnswerText = "Yes";
            this.AlertDialogNoAnswerText = "No";
            this.AlertDialogRemoveEmergencyContactTitleText = "Delete Confirmation";
            this.AlertDialogRemoveEmergencyContectMessageText = "Are you sure you want to remove this person from your Emergency Contacts? ";
            this.AlertDialogPrimaryEmergencyContactMessageText = "You’ve just added {0} as a primary emergency contact. Primary emergency contacts will be notified is situations when a large response group is unnecessary. ";
            this.AlertDialogPrivateDataAcknowledgmentTitleText = "Private Data Acknowledgment";
            this.AlertDialogPrivateDataAcknowledgmentMessageText = "This app records video, audio and takes photos without indicating that video, audio or photos are being recorded. Your personal user data (including recorded video, audio and photos as well as contact information) will be uploaded to Ulzi servers.";
            this.AlertDialogPrivateDataAcknowledgmentDeclineAnswerText = "Decline";
            this.AlertDialogPrivateDataAcknowledgmentAgreeAnswerText = "I Agree";
            this.AlertDialogSendYouNotificationsTitleText = "“Ulzi” Would Like to Send You Notifications";
            this.AlertDialogSendYouNotificationsMessageText = "Notifications may include alerts, sounds, and icon badges. These can be configured in Settings.";
            this.AlertDialogSendYouNotificationsDontAllowAnswerText = "Don’t Allow";
            this.AlertDialogSendYouNotificationsAllowAnswerText = "Allow";
            this.AlertDialogSubscriptionTermsTitleText = "Subscription Terms";
            this.AlertDialogSubscriptionTermsMessageText = "Subscribe to Premium {0}. This subscription will automatically renew every month for ${1}.";
            this.AlertDialogSubscriptionTermsCancelAnswerText = "Cancel";
            this.AlertDialogSubscriptionTermsContinueAnswerText = "Continue";
            this.AlertDialogConfirmSubscriptionTitleText = "Confirm Subscription";
            this.AlertDialogConfirmSubscriptionMessageText = "The subscription will continue unless cancelled in Settings at least one day before a subscription period ends.";
            this.AlertDialogConfirmSubscriptionCancelAnswerText = "Cancel";
            this.AlertDialogConfirmSubscriptionOKAnswerText = "OK";
            this.AlertDialogCurrentlySubscribedTitleText = "You’re currently subscribed to this.";
            this.AlertDialogCurrentlySubscribedMessageText = "Your 1-Month subscription renews on {0} for ${1}. To review subscription settings or cancel this subscription, tap Manage.";
            this.AlertDialogCurrentlySubscribedManageAnswerText = "Manage";
            this.AlertDialogCurrentlySubscribedOKAnswerText = "OK";
            this.AlertDialogCancelPremiumAccountTitleText = "Cancel your Premium account?";
            this.AlertDialogCancelPremiumAccountMessageText = "If you want to cancel your premium account, we will stop charging your credit card immediately and your Premium account will expire at the end of your billing cycle. All of your settings and history will be deleted.";
            this.AlertDialogCancelPremiumAccountNevermindAnswerText = "Nevermind";
            this.AlertDialogCancelPremiumAccountYesAnswerText = "Yes, cancel it.";
            this.AlertDialogAccessMicrophoneTitleText = "“Ulzi” Would Like to Access the Microphone";
            this.AlertDialogAccessMicrophoneMessageText = "Ulzi would like to be able to record sounds during an incident";
            this.AlertDialogAccessMicrophoneDontAllowAnswerText = "Don’t Allow";
            this.AlertDialogAccessMicrophoneOKAnswerText = "OK";
            this.AlertDialogEmergencyForgotPasswordTitleText = "Forgot Emergency Passcode";
            this.AlertDialogEmergencyForgotPasswordMessageText = "For your safety we will wait 15 minutes then send you an email with your passcode."; //Cakesoft Fixed SB-76
            this.AlertDialogEmergencyForgotPasswordOKAnswerText = "OK";
            this.AlertDialogEmergencyForgotPasswordCancelAnswerText = "Cancel";
            this.AlertDialogNotPremiumMemberTitleText = "Not Yet a Premium Member";
            this.AlertDialogNotPremiumMemberMessageText = "To access this feature, you need to have a Premium account.";
            this.AlertDialogNotPremiumMemberGetPremiumAnswerText = "Get Premium";
            this.AlertDialogNotPremiumMemberCancelAnswerText = "Cancel";
            #endregion

            #region Select Photo Action Sheet
            this.SelectPhotoActionSheetTitleText = "Add Image";
            this.SelectPhotoActionSheetCancelText = "Cancel";
            this.SelectPhotoActionSheetFromCameraText = "From Camera";
            this.SelectPhotoActionSheetFromGalleryText = "From Gallery";
            #endregion

            #region Select Blocked People Action Sheet
            this.SelectBlockedPeopleActionSheetTitleText = "Select People To Block";
            this.SelectBlockedPeopleActionSheetCancelText = "Cancel";
            this.SelectBlockedPeopleActionSheetSelectContactText = "Select from Address Book";
            this.SelectBlockedPeopleActionSheetManualInputText = "Enter Manually";
            #endregion

            #region Picker titles
            this.SelectGenderPickerTitleText = "Select Gender";
            this.SelectHeightPickerTitleText = "Select Height";
            this.SelectWeightPickerTitleText = "Select Weight";
            this.SelectHairColorPickerTitleText = "Select Hair Color";
            this.SelectEyeColorPickerTitleText = "Select Eye Color";
            this.SelectEthnicityPickerTitleText = "Select Ethnicity";
            this.SelectRelationPickerTitleText = "Select Relation";
            this.SelectBirthDatePickerTitleText = "Select Birthday";
            #endregion

            #region Month Selector
            this.MonthSelectorJanuary = "January";
            this.MonthSelectorFebruary = "February";
            this.MonthSelectorMarch = "March";
            this.MonthSelectorApril = "April";
            this.MonthSelectorMay = "May";
            this.MonthSelectorJune = "June";
            this.MonthSelectorJuly = "July";
            this.MonthSelectorAugust = "August";
            this.MonthSelectorSeptember = "September";
            this.MonthSelectorOctober = "October";
            this.MonthSelectorNovember = "November";
            this.MonthSelectorDecember = "December";
            #endregion

            #region Genders strings
            this.GenderMaleText = "Male";
            this.GenderFemaleText = "Female";
            #endregion

            #region Hair Color strings
            this.HairColorBald = "Bald";
            this.HairColorBlack = "Black";
            this.HairColorBlonde = "Blonde (Strawberry)";
            this.HairColorBlue = "Blue";
            this.HairColorBrown = "Brown";
            this.HairColorGreen = "Green";
            this.HairColorGray = "Gray (partially gray)";
            this.HairColorOrange = "Orange";
            this.HairColorPurple = "Purple";
            this.HairColorPink = "Pink";
            this.HairColorRed = "Red (Auburn)";
            this.HairColorSandy = "Sandy";
            this.HairColorWhite = "White";
            #endregion

            #region Eye Color strings
            this.EyeColorBlack = "Black";
            this.EyeColorBlue = "Blue";
            this.EyeColorBrown = "Brown";
            this.EyeColorGray = "Gray";
            this.EyeColorGreen = "Green";
            this.EyeColorHazel = "Hazel";
            this.EyeColorMaroon = "Maroon";
            #endregion

            #region Ethnicity Color strings
            this.EthnicityAsian = "Asian";
            this.EthnicityBlack = "Black";
            this.EthnicityHispanic = "Hispanic";
            this.EthnicityIndian = "Indian";
            this.EthnicityMiddleEastern = "Middle Eastern";
            this.EthnicityMultiracial = "Multiracial";
            this.EthnicityWhite = "White";
            #endregion

            #region Relation strings
            this.RelationFather = "Father";
            this.RelationMother = "Mother";
            this.RelationBoyfriend = "Boyfriend";
            this.RelationDaughter = "Daughter";
            this.RelationFraternityBrother = "Fraternity brother";
            this.RelationFriend = "Friend";
            this.RelationGirlfriend = "Girlfriend";
            this.RelationHusband = "Husband";
            this.RelationPartner = "Partner";
            this.RelationSibling = "Sibling";
            this.RelationSon = "Son";
            this.RelationSororitySister = "Sorority sister";
            this.RelationWife = "Wife";
            this.RelationOther = "other";
            #endregion

            #region Map Directions
            this.MapDirectionsNorth = "north";
            this.MapDirectionsNorthEast = "northeast";
            this.MapDirectionsEast = "east";
            this.MapDirectionsSouthEast = "southeast";
            this.MapDirectionsSouth = "south";
            this.MapDirectionsSouthWest = "southwest";
            this.MapDirectionsWest = "west";
            this.MapDirectionsNorthWest = "northwest";
            #endregion

            #region Account Type Info View
            this.AccountTypeInfoViewTopInfoText = "As a premium member, you get access to Ulzi full protection and safety system giving you complete peace of mind, safety, and freedom. So, what does that include?"; // CakeSoft fixed bug BR-14
            this.AccountTypeInfoViewFreeLabelText = "Free";
            this.AccountTypeInfoViewSilverLabelText = "Silver";
            this.AccountTypeInfoViewGoldLabelText = "Gold";
            this.AccountTypeInfoViewBeAHeroLabelText = "Be A Hero";
            this.AccountTypeInfoViewBeAHeroDescriptionText = "Be A Hero" + Environment.NewLine + "Be A Hero" + Environment.NewLine + "Be A Hero";
            this.AccountTypeInfoViewCallPoliceLabelText = "Call Police";
            this.AccountTypeInfoViewCallPoliceDescriptionText = "In an emergency, call the police with the push of a button.";  // CakeSoft fixed bug 21&38
            this.AccountTypeInfoViewAlertEmergencyContactsLabelText = "Alert Emergency Contacts";
            this.AccountTypeInfoViewAlertEmergencyContactsDescriptionText = "Instantly notify your emergency contacts when you’re in an unsafe or emergency situation.";
            this.AccountTypeInfoViewAlertCommunityRespondersLabelText = "Alert Community Responders";
            this.AccountTypeInfoViewAlertCommunityRespondersDescriptionText = "In an emergency, get help from nearby users who can come to your side or call the police for you.";
            this.AccountTypeInfoViewAudioVideoRecordingLabelText = "Record All Available Audio & Video";
            this.AccountTypeInfoViewAudioVideoRecordingDescriptionText = "In an emergency, automatically start recording audio and video of your surroundings, your assailant, etc. This will provide sorely needed courtroom evidence and will help get criminals off the street for good.";
            this.AccountTypeInfoViewActivateFlashlightLabelText = "Activate Flashlight";
            this.AccountTypeInfoViewActivateFlashlightDescriptionText = "Activate your phone’s flashlight in an emergency.";
            this.AccountTypeInfoViewPlanYourRoutesLabelText = "Plan Your Routes";
            this.AccountTypeInfoViewPlanYourRoutesDescriptionText = "Notify your contacts of the route you plan to take. They can then track you as you walk from School to Home, Work to Car, etc. and will be notified if you deviate too far from your route. Get up to 10 routes a month with Ulzi Free.";
            this.AccountTypeInfoViewTurnOnSirenLabelText = "Activate Siren";
            this.AccountTypeInfoViewTurnOnSirenDescriptionText = " In an emergency, activate a high decibel siren to let an assailant know you are protected, and to alert community members of your situation.";
            this.AccountTypeInfoViewSendMyLocationToPoliceLabelText = "Send Your Location to Police";
            this.AccountTypeInfoViewSendMyLocationToPoliceDescriptionText = "Send your exact location directly to local law enforcement. It’s a common misconception that police can track a cell phone.";
            this.AccountTypeInfoViewHaveFriendsFamilyTrackYouLabelText = "Let Friends & Family Track You";
            this.AccountTypeInfoViewHaveFriendsFamilyTrackYouDescriptionText = "Let your loved ones track you, allowing them to keep you safe at all times and giving them peace of mind.";
            this.AccountTypeInfoViewTrackFriendsAndFamilyLabelText = "Track Your Friends & Family";
            this.AccountTypeInfoViewTrackFriendsAndFamilyDescriptionText = "Track your loved ones. Track up to 2 people with Ulzi Silver, or upgrade to Gold for unlimited access. Users must approve you as a tracker.";
            this.AccountTypeInfoViewCustomNotificationSoundsLabelText = "Set Custom Notification Sounds";
            this.AccountTypeInfoViewCustomNotificationSoundsDescriptionText = "Customize alert sounds for each loved one you are tracking.";
            this.AccountTypeInfoViewSetTrackingZonesLabelText = "Set Tracking Zones";
            this.AccountTypeInfoViewSetTrackingZonesDescriptionText = "Set custom zones (around home, school, friends’ houses) to know when a loved one leaves or enters that zone.";
            this.AccountTypeInfoViewSaveVideoToTheCloudLabelText = "Save Audio & Video to Cloud";
            this.AccountTypeInfoViewSaveVideoToTheCloudDescriptionText = "Automatically upload audio and video recordings during an emergency to the Cloud. It will be saved there even if your phone is knocked out of your hand or destroyed.";
            this.AccountTypeInfoViewCostLabelText = "Cost ($/month)";
            this.AccountTypeInfoViewFreeCostLabelText = "Free";
            this.AccountTypeInfoViewBottomInfoText = "Try Premium Silver free for 30 days!";
            this.AccountTypeInfoViewBeAHeroLabelText = "Be A Hero";
            this.AccountTypeInfoViewBeACommunityResponderLabelText = "Be a Community Responder";
            this.AccountTypeInfoViewBeACommunityResponderDescriptionText = "You are now a part of the Ulzi community, the first crowdsourced safety system. By getting alerts when someone near you is in trouble, you can be a companion, a witness, and a hero.";
            this.AccountTypeInfoViewMonthlyPriceLabelText = "Monthly Price";
            this.AccountTypeInfoViewStudentDiscountLabelText = "Student Discount (50% off)";
            this.AccountTypeInfoViewTrySilverLabelText = "Try Silver free for 30 days!";
            this.AccountTypeInfoViewOfflineMapsLabelText = "Offline Maps";
            this.AccountTypeInfoViewOfflineMapsDescriptionText = "Save maps to use when you have no service or low data.";
            this.AccountTypeInfoViewSetSpeedNotificationLabelText = "Set Speed Notifications";
            this.AccountTypeInfoViewSetSpeedNotificationDescriptionText = "Set speed limits and be notified if loved ones exceed it.";
            this.AccountTypeInfoViewCustomMapStylesLabelText = "Customize Your Map Style";
            this.AccountTypeInfoViewCustomMapStylesDescriptionText = "Customize your map display with preset styles.";
            this.AccountTypeInfoViewSatelliteViewLabelText = "Satellite View";
            this.AccountTypeInfoViewSatelliteViewDescriptionText = "Access a satellite view of your maps.";
            this.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextLabelText = "Receive Emergency Notifications via Text";
            this.AccountTypeInfoViewReceiveEmergencyNotificationsviaTextDescriptionText = "Don’t worry if you’re low on data—We’ll send all emergency notifications via text.";
            #endregion

            #region Button Settings Info View
            this.ButtonSettingsPanelEmergencyButtonText = "Emergency";
            this.ButtonSettingsPanelBadSituationButtonText = "Bad Situation";
            this.ButtonSettingsInfoFeaturesLabelText = "Features";
            this.ButtonSettingsInfoFreeLabelText = "Free";
            this.ButtonSettingsInfoSilverLabelText = "Silver";
            this.ButtonSettingsInfoCallPoliceLabelText = "Call Police";
            this.ButtonSettingsInfoCallPoliceDescriptionText = "In an emergency, call the police with the push of a button. They’ll know your exact location and can respond immediately.";
            this.ButtonSettingsInfoAlertEmergencyContactsLabelText = "Alert Emergency Contacts";
            this.ButtonSettingsInfoAlertEmergencyContactsDescriptionText = "Let Ulzi users within several blocks of you know when you feel unsafe or are in an emergency situation. Someone will come help you or call the police for you.";
            this.ButtonSettingsInfoAlertCommunityRespondersLabelText = "Alert Community Responders";
            this.ButtonSettingsInfoAlertCommunityRespondersDescriptionText = "Set your personal emergency contacts so they’ll be instantly notified when you’re in an unsafe or emergency situation.";
            this.ButtonSettingsInfoRecordAudioAndVideoLabelText = "Record Audio and Video";
            this.ButtonSettingsInfoRecordAudioAndVideoDescriptionText = "In an emergency, automatically start recording audio and video of your surroundings, your assailant, etc. This provides sorely needed courtroom evidence and helps get criminals off the street for good.";
            this.ButtonSettingsInfoActivateFlashlightLabelText = "Activate Flashlight";
            this.ButtonSettingsInfoActivateFlashlightDescriptionText = "Set your preferences to also activate your phone’s flashlight in an emergency.";
            this.ButtonSettingsInfoTurnOnSirenLabelText = "Turn On Siren";
            this.ButtonSettingsInfoTurnOnSirenDescriptionText = "In an emergency situation, activate a high decibel siren to let an assailant know you are protected, and to alert community members of your situation.";
            this.ButtonSettingsSendMyLocationToPoliceLabelText = "Send My Location to Police";
            this.ButtonSettingsSendMyLocationToPoliceDescriptionText = "Send your location directly to local law enforcement. It is a common misconception that police can track a cell phone.";
            this.ButtonSettingsInfoFreeFeaturesLabelText = "Free Features";
            this.ButtonSettingsInfoSilverFeaturesLabelText = "Silver Features";
            this.ButtonSettingsInfoGoldFeaturesLabelText = "Gold Features";
            this.ButtonSettingsInfoSaveVideoToCloudLabelText = "Save Video To The Cloud";
            this.ButtonSettingsInfoSaveVideoToCloudDescriptionText = "Save Video To The Cloud" + Environment.NewLine + "Save Video To The Cloud" + Environment.NewLine + "Save Video To The Cloud";
            #endregion

            #region Main page
            this.MainPageSelectorDoneCommandText = "Done";
            #endregion

            #region Start panel
            this.StartPanelWelcomeText = "Welcome to your safer world.";
            this.StartPanelLogInButtonText = "LOG IN";
            this.StartPanelCreateAccountButtonText = "CREATE ACCOUNT";
            this.StartPanelFacebookLoginButtonText = "LOG IN WITH FACEBOOK";
            #endregion

            #region Login panel
            this.LoginPanelWelcomeText = "Welcome to your safer world.";
            this.LoginPanelEmailPlaceholderText = "Email";
            this.LoginPanelPasswordPlaceholderText = "Password";
            this.LoginPanelForgotCommandText = "Forgot Password? ";
            this.LoginPanelSignUpCommandText = "DON’T HAVE AN ACCOUNT? SIGN UP!   ";
            this.LoginPanelLogInButtonText = "LOG IN";
            this.LoginPanelErrorText = "Email and Password do not match";
            #endregion

            #region Passcode Login panel
            this.PasscodeLoginPanelInfoText = "Type in passcode to log in.";
            this.PasscodeLoginPanelForgotPasscodeCommandText = "Forgot Passcode? ";
            #endregion

            #region Phone Verification panel
            this.PhoneVerificationPanelTitleText = "Phone Verification";
            this.PhoneVerificationPanelBackCommandText = "Back";
            this.PhoneVerificationPanelSaveCommandText = "Next ";
            this.PhoneVerificationPanelTopInfoText = "Please enter the verification code that was texted to you.";
            this.PhoneVerificationPanelCodeLabelText = "ENTER CODE";
            #endregion

            #region Forgor Password panel
            this.ForgotPasswordPanelWelcomeText = "Reset your password.";
            this.ForgotPasswordPanelTopInfoText = "Enter your email, and we'll send you a link to reset your password.";
            this.ForgotPasswordPanelEmailPlaceholderText = "Email";
            this.ForgotPasswordPanelSendAnEmailButtonText = "SEND AN EMAIL";
            this.ForgotPasswordPanelErrorText = "There is no account for this email.";
            this.ForgotPasswordPanelBackCommandText = "BACK";
            #endregion

            #region Terms Of Use panel
            this.TermsOfUsePanelTitleText = "Terms Of Use";
            this.TermsOfUsePanelDeclineCommandText = "Decline";
            this.TermsOfUsePanelAcceptCommandText = "Accept";
            this.TermsOfUsePanelTextTitle = "Last Updated: September 28th, 2017"; //CakeSoft fixed bug SB-17
            this.TermsOfUsePanelTextContentLine_1 = "PLEASE READ THESE TERMS OF USE CAREFULLY BEFORE USING THE SERVICES OFFERED BY NO PENCILS INC. (“Ulzi” OR “us”). These Terms of Use set forth the legally binding terms and conditions for your use of the Ulzi Services.";
            this.TermsOfUsePanelTextContentLine_2 = "INTRODUCTION";
            this.TermsOfUsePanelTextContentLine_3 = "By using the Services, you agree to be bound by the terms and conditions contained herein (the “Terms of Use”), which also incorporates the Ulzi Privacy Policy (https://ulzi.com/privacy%20policy) and all other operating rules, policies and procedures that may be published from time to time on the Site by Ulzi, each of which is incorporated herein by reference and which may be updated by Ulzi from time to time without notice to you in accordance with the terms set out below unless otherwise indicated. In addition, some features offered through the Services may be subject to additional terms and conditions specified by Ulzi from time to time; your use of such services is subject to those additional terms and conditions, which are incorporated into these Terms of Use by reference." +
            " We may, in our sole discretion, modify this Terms of Use with or without notice to you. The “Last Updated” date at the top of this Terms of Use will indicate when the latest modifications were made. By continuing to access and use the Services after this Terms of Use has been modified, you are agreeing to such modifications. Therefore, you should review this Terms of Use prior to each use of the Services. In addition, when using particular services or features you shall be subject to any posted guidelines or policies applicable to such services, features or purchases that may be posted from time to time. All such guidelines or policies are hereby incorporated by reference into this Terms of Use." +
             " You represent and warrant that if you are an individual, you are of legal age to form a binding contract, or that if you are registering on behalf of an entity, that you are authorized to enter into, and bind the entity to, these Terms of Use and register for the Services. You agree not to impersonate or misrepresent your affiliation with any person or entity, including using another person’s username, passcode or other account information, or another person’s name or likeness, or provide false details for a parent or guardian. You agree that we may take steps to verify the accuracy of information you provide, including contact information for a parent or guardian. Ulzi may, in its sole discretion, refuse to offer the Services to any person or entity and change its eligibility criteria at any time. You are solely responsible for ensuring that these Terms of Use are in compliance with all laws, rules and regulations applicable to you and the right to access the Services is revoked where these Terms of Use or use of the Services is prohibited and, in such circumstances, you agree not to use or access the Site or Services in any way.";
            this.TermsOfUsePanelTextContentLine_4 = "CONNECTIVITY, COMMUNICATIONS, PRIVACY";
            this.TermsOfUsePanelTextContentLine_5 = "You must have an internet-enabled cell phone or device using either the iOS or Android operating system in order to access the Services. Normal carrier charges and taxes may apply to any content you obtain from the Services. Ulzi is not responsible for any surcharges you incur from your mobile phone or internet"
                + "service provider as a result of the use of the Services. Use of the Services is subject to the terms of our Privacy Policy (https://ulzi.com/privacy%20policy). By using the Services, you acknowledge that you have read, and you agree to be bound by, the terms of our Privacy Policy. We reserve the right, and you authorize us, to use information regarding your use of the Services, account registration, and any other personal information provided by you in accordance with our Privacy Policy. You further acknowledge and agree that any disputes related to the Privacy Policy, including any breaches in security or privacy, will be subject to the limitations on liability, dispute resolution and arbitration provisions contained in this Terms of Use.";
            this.TermsOfUsePanelTextContentLine_6 = "COPYRIGHT; TRADEMARKS";
            this.TermsOfUsePanelTextContentLine_7 = "You acknowledge that all materials on the Services, including the Services’ design, graphics, text, sounds, pictures, software and other files and the selection and arrangement thereof (collectively, “Materials”), are the property of Ulzi or its licensors, and are subject to and protected by United States and international copyright and other intellectual property laws and rights. You will not obtain any ownership interest in the Materials or the Services through this Terms of Use or otherwise. All rights to Materials not expressly granted in this Terms of Use are reserved to their respective copyright owners. " +
                "Except as expressly authorized by this Terms of Use or on the Services, you may not copy, reproduce, distribute, republish, download, perform, display, post, transmit, exploit, create derivative works or otherwise use any of the Materials in any form or by any means, without the prior written authorization of Ulzi or the respective copyright owner. Ulzi authorizes you to view and download the Materials only for personal and internal business use, provided that you keep intact all copyright and other proprietary notices contained in the original Materials. You may not modify or adapt the Materials in any way or otherwise use them for any public or commercial purposes. The trademarks, service marks, trade names, trade dress and logos (collectively, “Marks”) contained or described on the Services (including, without limitation, Ulzi and any Marks associated with any products available on the Service) are the sole property of Ulzi and/or its licensors and may not be copied, imitated or otherwise used, in whole or in part, without the prior written authorization of Ulzi and/or licensors. " +
                "In addition, all page headers, custom graphics, button icons and scripts are Marks of Ulzi and may not be copied, imitated or otherwise used, in whole or in part, without the prior written authorization of Ulzi. Ulzi will enforce its intellectual property rights to the fullest extent of the law.";
            this.TermsOfUsePanelTextContentLine_8 = "USER CONDUCT";
            this.TermsOfUsePanelTextContentLine_9 = "You agree that you will not use the Services to:";
            this.TermsOfUsePanelTextContentLine_10 = "1. upload, post, email or otherwise transmit any content that is unlawful, harmful, threatening, abusive, harassing, defamatory, vulgar, obscene, pornographic, libelous, invasive of another’s privacy, hateful, or racially, ethnically or otherwise unlawful or objectionable(including without limitation, nudity and depiction of drug use);";
            this.TermsOfUsePanelTextContentLine_11 = "2. intentionally harm minors in any way;";
            this.TermsOfUsePanelTextContentLine_12 = "3. impersonate any person or entity, including, but not limited to a representative of Ulzi, or falsely state or otherwise misrepresent your affiliation with a person or entity;";
            this.TermsOfUsePanelTextContentLine_13 = "4. forge headers or otherwise manipulate identifiers in order to disguise the origin of any content transmitted through the Services;";
            this.TermsOfUsePanelTextContentLine_14 = "5. upload, post, email or otherwise transmit any content that you do not have a right to transmit under any law or under contractual or fiduciary relationships (such as inside information, proprietary and confidential information learned or disclosed as part of employment relationships or under nondisclosure agreements);";
            this.TermsOfUsePanelTextContentLine_15 = "6. upload, post, email or otherwise transmit any content that infringes any patent, trademark, trade secret, copyright or other proprietary rights of any party;";
            this.TermsOfUsePanelTextContentLine_16 = "7. upload, post, email or otherwise transmit any unsolicited or unauthorized advertising, promotional materials, “junk mail,” “spam,” “chain letters,” “pyramid schemes,” or any other form of solicitation;";
            this.TermsOfUsePanelTextContentLine_17 = "8. upload, post, email or otherwise transmit any material that contains software viruses or any other computer code, files or programs designed to interrupt, emulate, destroy or limit the functionality of any computer software or hardware or telecommunications equipment;";
            this.TermsOfUsePanelTextContentLine_18 = "9. disrupt the normal flow of dialogue, cause a screen to “scroll” faster than other users of the Services are able to type, or otherwise act in a manner that negatively affects other users’ ability to engage in real time exchanges;";
            this.TermsOfUsePanelTextContentLine_19 = "10. interfere with or disrupt the Services or servers or networks connected to the Services, or disobey any requirements, procedures, policies or regulations of networks connected to the Services;";
            this.TermsOfUsePanelTextContentLine_20 = "11. “stalk” or otherwise harass another;";
            this.TermsOfUsePanelTextContentLine_21 = "12. collect or store personal information or data about other Services users, or disclose another user’s personal information or data to any third party;";
            this.TermsOfUsePanelTextContentLine_22 = "13. solicit personal information or data from anyone under 13 years of age; and / or";
            this.TermsOfUsePanelTextContentLine_23 = "14. “bot,” “hack,” “crack,” or otherwise attempt to circumvent any access control, copyright protection or license - enforcement mechanisms associated with or related to the Services.";
            this.TermsOfUsePanelTextContentLine_24 = "Any comments, suggestions, or feedback relating to the Services (collectively, “Feedback”) submitted to Ulzi shall become the property of Ulzi. Ulzi will not be required to treat any Feedback as confidential, and will not be liable for any ideas (including without limitation, product, application, site, Services or advertising ideas) and will not incur any liability as a result of any similarities that may appear in the Services, or operations, in the future. Without limitation, Ulzi will have exclusive ownership of all present and future existing rights to the Feedback of every kind and nature everywhere and will be entitled to use the Feedback for any commercial or other purpose whatsoever, without compensation to you or any other person sending the Feedback. " +
                "You acknowledge that you are responsible for whatever material you submit, and you, not Ulzi, have full responsibility for the message, including its legality, reliability,appropriateness, originality, and copyright.";
            this.TermsOfUsePanelTextContentLine_25 = "LINKS; THIRD PARTY WEBSITES";
            this.TermsOfUsePanelTextContentLine_26 = "Links on the Services to third party websites and applications are provided only as a convenience to you. If you use these links, you will leave the Services. Your dealings with third parties through links to such third party websites or applications are solely between you and such third parties. You agree that Ulzi will not be responsible or liable for any content, goods or services provided on or through these outside websites or applications or for your use or inability to use such websites or applications. You will use these links at your own risk. You are advised that other websites on the Internet and mobile applications, including third party websites and applications linked from the Services, might contain material or information that some people may find offensive or inappropriate; or that is inaccurate, untrue, misleading or deceptive; or that is defamatory, libelous, infringing of others’ rights or otherwise unlawful. Ulzi expressly disclaims any responsibility for the content, legality, decency or accuracy of any information, and for any products and services, that appear on any third party website or application." +
                " Without limiting the foregoing, your correspondence or business dealings with, participation in promotions of or purchases from, advertisers or third party applications found on or through the use of the Services, including payment for and delivery of related goods or services, and any other terms, conditions, warranties or representations associated with such dealings, are solely between you and such advertiser or third party application provider. You agree that Ulzi and its Affiliated Parties shall not be responsible or liable for any loss or damage of any sort incurred as the result of any such dealings or as the result of the presence of such advertisers or third party application providers on the Services." +
                " Ulzi is not responsible for any product or service(including third party applications) sold on or through the Services or any claims of quality or performance made on or through the Services.";
            this.TermsOfUsePanelTextContentLine_27 = "GENERAL DISCLAIMER";
            this.TermsOfUsePanelTextContentLine_28 = "You expressly understand and agree that: your use of the services is at your sole risk. The services and the materials contained herein are provided on an “as is” and “as available” basis. Except as otherwise expressly provided in this Terms of Use, Ulzi and its Affiliated Parties expressly disclaim all warranties of any kind, whether express or implied, including, but not limited to the implied warranties of merchantability, fitness for a particular purpose and non-infringement." +
                 " Except as otherwise expressly provided in this terms of use, Ulzi and its Affiliated Parties make no warranty that(a) the services will meet your requirements, (b) the services will be uninterrupted, timely, secure, or error-free, (c)the information that may be obtained from the use of the services will be accurate or reliable, (d) the quality of any services, information, or other material obtained by you through the services will meet your expectations, and(e) any errors in the services will be corrected. Any material downloaded or otherwise obtained through the use of the services is done at your own discretion and risk and you will be solely responsible for any damage to your computer system, your mobile device, or loss of data that results from the download of any such material. No advice or information, whether oral or written, obtained by you from Ulzi and its Affiliated Parties or on or through the service shall create any warranty not expressly stated in this terms of use. To the fullest extent permissible by applicable law, Ulzi ";
            this.TermsOfUsePanelTextContentLine_29 = "ALERT DISCLAIMER";
            this.TermsOfUsePanelTextContentLine_30 = "The Service is ONLY a peer-to-peer communication and information service which allows users to share personal and geographic information with one or more users based upon user defined options, data and actions. Ulzi does not express or imply that use of the Service will deter the occurrence of an unlawful act or make any representation as to a response from your predetermined contacts, the Ulzi community of users, or law enforcement." +
                " You understand and agree that the Service will notify you in the event that one of your predetermined contacts, or another Ulzi user in your proximity, has triggered an ad-hoc request for assistance; that responding to any request for assistance is inherently dangerous and you agree that Ulzi shall not be liable for any monetary costs you may incur or any physical or psychological injury you may sustain as a result of YOUR DECISION to participate or not participate in any response." +
                " You understand and agree that any alerts provided through the Service may be delayed or prevented by a variety of factors. Ulzi does its best to provide alerts in a timely manner with accurate information. However, we neither guarantee the delivery nor the accuracy of the content of any alert. You also agree that Ulzi shall not be liable for any delays, failure to deliver, or misdirected delivery of any alert; for any errors in the content of an alert; or for any actions taken or not taken by you or any third party in reliance on an alert.";
            this.TermsOfUsePanelTextContentLine_31 = "LIMITATION OF LIABILITY";
            this.TermsOfUsePanelTextContentLine_32 = "Ulzi and its Affiliated Parties shall not under any circumstances be liable for any damages of any kind arising out of, in connection with or relating to the use of or inability to use the services, including any liability (a) for any incorrect or inaccurate information, (b) for any unauthorized access to or disclosure of your transmissions or data, (c) for statements or conduct of any third party on the services, or (d) for any other matter relating to the services or any third party website or application. This is a comprehensive limitation of liability that applies to all damages of any kind, including any direct, indirect, special, incidental or consequential damages (including damages for loss of business, loss of profits, loss of good will, loss of use, loss of data, services or information, litigation or the like), whether based on breach of contract, breach of warranty, tort (including negligence), product liability or otherwise, even if an individual advises of the possibility of such damages. " +
                "The limitations of liability set forth herein are fundamental elements of the basis of the bargain between Ulzi and you. The information and services offered on and through the services would not be provided without such limitations. Notwithstanding the foregoing, the sole and entire maximum liability of Ulzi and Affiliated Parties for any reason shall be limited to $500.00 (five hundred United States dollars). You acknowledge and agree that if you have not paid Ulzi any amounts for any information or service prior to the date on which you first assert any claim, your sole and exclusive remedy for any dispute with Ulzi is to stop using the services and cancel your account." +
                 " Some jurisdictions do not allow the disclaimer of certain warranties or the limitation or exclusion of liability for certain types of damages. Accordingly, some of the above disclaimers and limitations may not apply to you. In such jurisdictions, the exclusions and liability are limited to the fullest extent permitted by law.";
            this.TermsOfUsePanelTextContentLine_33 = "INDEMNIFICATION";
            this.TermsOfUsePanelTextContentLine_34 = "You agree to indemnify, defend and hold harmless Ulzi and its Affiliated Parties against all claims, demands, causes of action, losses, expenses, damages and costs, including any reasonable attorneys’ fees, resulting or arising from or relating to your use of or conduct on the Services, any activity related to your account by you or any other person, any material that you submit to, post on or transmit through the Services, your breach of this Terms of Use, your infringement or violation of any rights of another, or termination of your access to the Services. Ulzi reserves the right to assume the exclusive defense and control of any matter otherwise subject to indemnification by you, in which event you will assist and cooperate with Ulzi in asserting any available defenses.";
            this.TermsOfUsePanelTextContentLine_35 = "SERVICES USAGE; TERMINATION OF USAGE";
            this.TermsOfUsePanelTextContentLine_36 = "You are required to establish an account on the Services in order to take advantage of certain features of the Services. If you provide information on the Services, you agree to (a) provide true, accurate, current and complete information about yourself as prompted by the Services, and (b) as permitted, maintain and promptly update such information to keep it true, accurate, current and complete. If you provide any information that is false, inaccurate, outdated or incomplete, or if Ulzi has reasonable grounds, in its sole discretion, to suspect that such information is false, inaccurate, outdated or incomplete, Ulzi has the right to suspend or terminate your account and prohibit any and all current or future use of the Services (or any portion thereof) by you." +
                " You will create a passcode while completing the mobile application account registration process. You are responsible for maintaining the confidentiality of your passcode, and are fully responsible for all activities that occur under your account. Ulzi reserves the right to refuse registration of, or cancel, an account in its sole discretion. You agree it is your responsibility to (a) immediately notify Ulzi of any unauthorized use of your account or any other breach of security, and (b) ensure that you exit from your mobile application account whenever you are not in direct control of your cellular. You agree to be responsible for all actions resulting from the use of your account on the Services, including actions resulting from unauthorized use of your account prior to your taking steps to prevent such occurrence by changing your passcode and notifying Ulzi. Ulzi and its Affiliated Parties cannot and will not be liable for any loss or damage arising from your failure to comply with this section. " +
                "For purposes of this Terms of Use and solely to provide the account information to you as part of the Services, you grant Ulzi a limited power of attorney, and appoint Ulzi as your attorney-in-fact and agent, to access third party sites, retrieve and use your information with the full power and authority to do and perform each thing necessary in connection with such activities, as you could do in person. You acknowledge and agree that when Ulzi is accessing and retrieving account information from third party sites, Ulzi is acting as your agent, and not as the agent of or on behalf of the third party. You understand and agree that the Services are not sponsored or endorsed by any third parties accessible through the Services." +
                " You agree to use the Services only for lawful purposes, and that you are responsible for your use of and communications on the Services. You agree not to post on or transmit through the Service any unlawful, infringing, threatening, harassing, defamatory, vulgar, obscene, profane, indecent, offensive, hateful or otherwise objectionable material of any kind, including any material that encourages criminal conduct or conduct that would give rise to civil liability, infringes others’ intellectual property rights or otherwise violates any applicable local, state, national or international law. You agree not to use the Services in any manner that interferes with its normal operation or with any other user’s use and enjoyment of the Services. You further agree that you will not access the Services by any means except through the interface provided by Ulzi for access to the Services. " +
                "Creating or maintaining any link from another website or application to any page or functionality on the Services without the prior written authorization of Ulzi is prohibited. Running or displaying the Services or any information or material displayed on the Services in frames or through similar means on another website or application without the prior written authorization of Ulzi is prohibited. Any permitted links to the Services must comply with all applicable laws, rules, and regulations." +
                " Ulzi makes no representation that Materials contained on the Services or products described or offered on the Services are appropriate or available for use in jurisdictions outside the United States, or that this Terms of Use complies with the laws of any other country. Visitors who use the Services and reside outside the United States do so on their own initiative and are responsible for compliance with all laws, if and to the extent local laws are applicable. You agree that you will not access the Services from any territory where its contents are illegal, and that you, and not Ulzi and its Affiliated Parties, are responsible for compliance with applicable local laws." +
                " This Terms of Use is effective unless and until terminated by either you or Ulzi. You may terminate this Terms of Use at any time, provided that you discontinue any further use of the Services. Ulzi also may terminate or suspend this Terms of Use, at any time, without notice, and accordingly deny you access to the Services, for any reason, including without limitation, if in Ulzi’s sole discretion you fail to comply with any term or provision of this Terms of Use or your use is harmful to the interests of another user or Ulzi and its Affiliated Parties. Upon any termination of the Terms of Use by either you or us, you must promptly stop using the Services and destroy all materials downloaded or otherwise obtained from the Services, as well as all copies of such materials, whether made under the Terms of Use or otherwise. Any fees paid hereunder are non-refundable. All provisions of these Terms of Use which by their nature should survive termination shall survive termination, including, without limitation, ownership provisions, warranty disclaimers, indemnity and limitations of liability." +
                "Ulzi reserves the right at any time and from time to time to modify or discontinue, temporarily or permanently, the Services (or any part thereof) with or without notice. Except as otherwise expressly stated in this Terms of Use, you agree that Ulzi and its Affiliated Parties shall not be liable to you or to any third party for any modification, suspension or discontinuation of the Services." +
                "You agree that Ulzi may terminate or suspend your access to all or part of the Services, without notice, for any conduct that Ulzi, in its sole discretion, believes is in violation of this Terms of Use or any applicable law or is harmful to the interests of another user or Ulzi and its Affiliated Parties.";
            this.TermsOfUsePanelTextContentLine_37 = "SWEEPSTAKES, CONTESTS, RAFFLES, SURVEYS AND SIMILAR PROMOTIONS";
            this.TermsOfUsePanelTextContentLine_38 = "Any sweepstakes, contests, raffles, surveys, games, or similar promotions made available through the Services may be governed by specific rules that are separate from and in addition to this Terms of Use. By participating in any such sweepstakes, contest, raffle, survey, game, or similar promotion, you will become subject to those rules, which may vary from this Terms of Use set forth herein, and which are incorporated into this Terms of Use. Ulzi urges you to read the applicable rules, which may be linked from the particular activity, and to review our Privacy Policy, which in addition to this Terms of Use, governs any information you submit in connection with such activities.";
            this.TermsOfUsePanelTextContentLine_39 = "ONLINE AND MOBILE ALERTS";
            this.TermsOfUsePanelTextContentLine_40 = "Ulzi may from time to time provide automatic alerts and voluntary account-related alerts. Although you may have the option to suppress some of these alerts, we strongly recommend that you do not since they are security-related. Some alerts may be turned on by default as part of the Services. They may then be customized, deactivated or reactivated by you. These alerts allow you to choose alert messages for your accounts. Ulzi may add new alerts from time to time, or cease to provide certain alerts at any time upon its sole discretion. Some alerts may have different options available, and you may be asked to select from among these options. Some alerts may be sent to the email address you have provided as your primary email address. If your email address or your mobile device’s email address changes, you are responsible for informing us of that change. You can also choose to have alerts sent to a mobile device that accepts text messages. Changes to your email address or mobile number will apply to all of your alerts. " +
                "Because alerts are not encrypted, we will never include your passcode; however, alerts may include some information about your account. Anyone with access to your email will be able to view the content of these alerts.";
            this.TermsOfUsePanelTextContentLine_41 = "FILTERING";
            this.TermsOfUsePanelTextContentLine_42 = "Pursuant to 47 U.S.C. Section 230 (d) as amended, we hereby notify you that parental control protections (such as computer hardware, software, or filtering services) are commercially available that may assist you in limiting access to material that is harmful to minors. Information identifying current providers of such protection is available at http://www.staysafe.org.";
            this.TermsOfUsePanelTextContentLine_43 = "APPLICABLE LAW; JURISDICTION; DISPUTE RESOLUTION";
            this.TermsOfUsePanelTextContentLine_44 = "The Services are controlled and operated by Ulzi from within the United States of America, and is intended for use only by residents of the United States. Ulzi makes no representations or warranties that the content or materials of the Services are appropriate or lawful in any foreign countries, or that any items or applications offered for sale or download through links on the Services will be available outside the United States. Those who choose to access the Services from other locations do so on their own initiative and are responsible for compliance with local laws, if and to the extent local laws are applicable. You may not use or export or re-export any content downloaded from the Services or any copy or adaptation of such content, in violation of any applicable laws or regulations, including without limitation United States export laws and regulations." +
                " The formation, construction and interpretation of this Terms of Use shall in all respects be governed by and construed in accordance with the laws of the United States and the State of California, without giving effect to any principles of conflicts of laws. This Terms of Use shall not be governed by the United Nations Conventions of Contracts for the International Sale of Goods, the application of which is hereby expressly excluded from any interpretation of this Terms of Use. Any dispute with Ulzi, or its officers, directors, employees, agents or affiliates, arising under or in relation to this Agreement shall be resolved exclusively through the small-claims court of the San Luis Obispo Superior Court within the county of San Luis Obispo, California, except with respect to imminent harm requiring temporary or preliminary injunctive relief in which case Ulzi may seek such relief in any court with jurisdiction over the parties. " +
                " You understand that, in return for agreement to this provision, Ulzi is able to offer the Service at the terms designated, and that your assent to this provision is an indispensable consideration to this Agreement. You also acknowledge and understand that, with respect to any dispute with Ulzi, its officers, directors, employees, agents or affiliates, arising out of or relating to your use of the Service or this Agreement: You are giving up your right to have a trial by jury; and you are giving up your right to serve as a representative, as a private attorney general, or in any other representative capacity, or to participate as a member of a class of claimants, in any lawsuit involving any such dispute. " +
                "All claims you bring against Ulzi must be resolved in accordance with this Section. All claims filed or brought contrary to this Section shall be considered improperly filed and a breach of this Terms of Use. Should either party file a claim contrary to this Section, the other party may recover attorneys’ fees and costs, provided that such party seeking such fees has notified the other in writing of the improperly filed claim, and the other has failed to promptly withdraw the claim.";
            this.TermsOfUsePanelTextContentLine_45 = "SEVERABILITY; INTERPRETATION";
            this.TermsOfUsePanelTextContentLine_46 = "If any provision of this Terms of Use shall be deemed unlawful, void, or for any reason unenforceable by a court of competent jurisdiction, the validity and enforceability of any remaining provisions shall not be affected. When used in this Terms of Use, the term “including” shall be deemed to be followed by the words “without limitation.”";
            this.TermsOfUsePanelTextContentLine_47 = "ENTIRE AGREEMENT";
            this.TermsOfUsePanelTextContentLine_48 = "This Terms of Use, including the Privacy Policy and other policies incorporated herein, constitutes the entire and only agreement between Ulzi and each user of the Services with respect to the subject matter of this Terms of Use and supersedes any and all prior or contemporaneous agreements, representations, warranties and understandings, written or oral, with respect to the subject matter of this Terms of Use.";
            this.TermsOfUsePanelTextContentLine_49 = "MISCELLANEOUS";
            this.TermsOfUsePanelTextContentLine_50 = "The failure of Ulzi and its Affiliated Parties to insist upon strict adherence to any term of this Terms of Use shall not constitute a waiver of such term and shall not be considered a waiver or limit that party’s right thereafter to insist upon strict adherence to that term or any other term of this Terms of Use." +
                  " You agree that regardless of any statute or law to the contrary, any claim of cause of action arising from or relating to use of the Services or this Terms of Use must be filed within one year after such claim or cause of action arose, or will be forever barred. The “Disclaimer; Limitation of Liability” provisions of this Terms of Use are for the benefit of Ulzi and its Affiliated Parties as defined herein, and each of these individuals or entities shall have the right to assert and enforce these provisions directly against you on its own behalf.";
            this.TermsOfUsePanelTextContentLine_51 = "COPYRIGHT POLICY";
            this.TermsOfUsePanelTextContentLine_52 = "We respect the intellectual property rights of others and require that Service users do the same. If you believe that your proprietary work has been copied in a way that constitutes copyright infringement, please forward the following information to Ulzi at legal@ulzi.com designated as such pursuant to the Digital Millennium Copyright Act, 17 U.S.C. 512(c)(2), named below:";
            this.TermsOfUsePanelTextContentLine_53 = "1. A physical signature of the person authorized to act on behalf of the owner of the copyright;";
            this.TermsOfUsePanelTextContentLine_54 = "2. A description of the copyrighted work that you claim has been infringed;";
            this.TermsOfUsePanelTextContentLine_55 = "3. A description of where the material that you claim is infringing is located on the Services;";
            this.TermsOfUsePanelTextContentLine_56 = "4. Your address, telephone number, and email address;";
            this.TermsOfUsePanelTextContentLine_57 = "5. A statement by you that you have a good faith belief that the disputed use is not authorized by the copyright owner, its agent, or the law; and";
            this.TermsOfUsePanelTextContentLine_58 = "6. A statement by you, made under penalty of perjury, that the above information in your notice is accurate and that you are the copyright owner or authorized to act on the copyright owner’s behalf.";
            this.TermsOfUsePanelTextContentLine_59 = "LANGUAGE";
            this.TermsOfUsePanelTextContentLine_60 = "Where Ulzi has provided you with a translation of the English language version of these Terms of Use, then you agree that the translation is provided for your convenience only and that the English language versions of the Terms will govern your relationship with Ulzi." +
                 " If there is any contradiction between what the English language version of these Terms of Use says and what a translation says, then the English language version shall take precedence.";
            this.TermsOfUsePanelTextContentLine_61 = "CONTACT INFORMATION";
            this.TermsOfUsePanelTextContentLine_62 = "If you have any comments, questions, or complaints regarding this Terms of Use or the Services, or wish to report any violation of this Terms of Use, please contact Us (https://ulzi.com/contact). We will address any issue to the best of our abilities as soon as possible.";
            this.TermsOfUsePanelIHaveReadCheckedText = "I have read and understood the above Terms of Use";
            #endregion

            #region Create Account Phone panel
            this.CraeteAccountPhonePanelTitleText = "Create Account";
            this.CreateAccountPhonePanelCancelCommandText = "Cancel";
            this.CreateAccountPhonePanelNextCommandText = "Next ";
            this.CreateAccountPhonePanelPhoneLabelText = "PHONE NUMBER";
            #endregion

            #region Create Account panel
            this.CreateAccountPanelTitleText = "Create Account";
            this.CreateAccountPanelCancelCommandText = "Cancel";
            this.CreateAccountPanelNextCommandText = "Next ";
            this.CreateAccountPanelFirstNameLabelText = "FIRST NAME";
            this.CreateAccountPanelLastNameLabelText = "LAST NAME";
            this.CreateAccountPanelGenderLabelText = "GENDER";
            this.CreateAccountPanelBirthDayLabelText = "BIRTHDAY";
            this.CreateAccountPanelPhoneNumberLabelText = "PHONE NUMBER";
            this.CreateAccountPanelEmailLabelText = "EMAIL";
            this.CreateAccountPanelReEnterEmailLabelText = "RE-ENTER EMAIL";
            this.CreateAccountPanelPasswordLabelText = "PASSWORD";
            this.CreateAccountPanelReEnterPasswordLabelText = "RE-ENTER PASSWORD";
            #endregion

            #region Detailed Info page
            this.DetailedInfoPanelTitleText = "Create Account";
            this.DetailedInfoPanelBackCommandText = "Back";
            this.DetailedInfoPanelNextCommandText = "Next ";
            this.DetailedInfoPanelTopInfoText = "When you’re in danger, this information will assist police and medical parties in helping you.";
            this.DetailedInfoPanelHeightLabelText = "HEIGHT";
            this.DetailedInfoPanelWeightLabelText = "WEIGHT";
            this.DetailedInfoPanelHairColorLabelText = "HAIR COLOR";
            this.DetailedInfoPanelEyeColorLabelText = "EYE COLOR";
            this.DetailedInfoPanelEthnicityLabelText = "ETHNICITY";
            this.DetailedInfoPanelStreetLabelText = "STREET";
            this.DetailedInfoPanelCityLabelText = "CITY";
            this.DetailedInfoPanelStateLabelText = "STATE";
            this.DetailedInfoPanelZipCodeLabelText = "ZIP CODE";
            this.DetailedInfoPanelMediasLabelText = "CONNECT SOCIAL MEDIA";
            this.DetailedInfoPanelAllergiesLabelText = "ALLERGIES";
            this.DetailedInfoPanelMedicationsLabelText = "MEDICATIONS";
            this.DetailedInfoPanelHomeAddressLabelText = "HOME ADDRESS";
            this.DetailedInfoPanelMedicalConditionsLabelText = "MEDICAL CONDITIONS";
            #endregion

            #region Passcode page
            this.PasscodePanelTitleText = "Set Emergency Passcode";
            this.PasscodePanelBackCommandText = "Back";
            this.PasscodePanelSaveCommandText = "Save ";
            this.PasscodePanelTopInfoText = "Set a passcode that will be used to cancel an accidental alarm, to end an Emergency/Bad Situation or end a trip.";
            this.PasscodePanelPasscodeLabelText = "ENTER PASSCODE";
            this.PasscodePanelPasscodeConfirmLabelText = "REPEAT PASSCODE";
            #endregion

            #region Account Type panel
            this.AccountTypePanelTitleText = "Account Type";
            this.AccountTypePanelBackCommandText = "Back";
            this.AccountTypePanelSilverButtonText = "Try Silver";
            this.AccountTypePanelGoldButtonText = "Try Gold";
            this.AccountTypePanelFreeButtonText = "I Want To Use The Free Version";
            this.AccountTypePanelCancelPremiumAccountButtonText = "Cancel Premium Account";
            this.AccountTypePanelGiftTheAppCommandText = "Gift The App! ";
            #endregion

            #region Add Emergency Contact panel
            this.AddEmergencyContactsPanelTitleLabel = "Contacts";
            this.AddEmergencyContactsPanelBackCommandText = "Back";
            this.AddEmergencyContactsPanelSkipCommandText = "Skip ";
            this.AddEmergencyContactsPanelNextCommandText = "Next ";
            this.AddEmergencyContactsPanelTopInfoText = "Choose who will receive an emergency notification when you’re in trouble. Choose whether they are notified in a red or yellow alert. Select who you want to track and who you would like to be able to see your location.";
            this.AddEmergencyContactsPanelEmptyListText = "Yikes! No emergency contacts yet.";
            this.AddEmergencyContactsPanelAddEmergencyContractButtonText = "Add Person";
            this.AddEmergencyContactsPanelUnlockPremiumButtonText = "Unlock Premium";
            this.AddEmergencyContactsPanelLimitLabelText = "Oops! Your account limits you to two emergency contacts. Start your premium account today to add an unlimited number of emergency contacts.";
            this.AddEmergencyContactsPanelPauseAllLabelText = "Pause All Location Sharing";
            this.AddEmergencyContactsPanelSearchPlaceholderText = "Search";
            this.AddEmergencyContactsPanelTrackThemLabelText = "Track Them";
            this.AddEmergencyContactsPanelTrackMeLabelText = "Track Me";
            this.AddEmergencyContactsPanelYellowAlertLabelText = "Yellow Alert";
            this.AddEmergencyContactsPanelRedAlertLabelText = "Red Alert";
            this.AddEmergencyContactsPanelExpanderPauseInfoText = "Pause Location Sharing";
            this.AddEmergencyContactsPanelRelationShipLabelText = "RELATIONSHIP";
            this.AddEmergencyContactsPanelReponseButtonText = "Respond To Tracking Request";
            this.AddEmergencyContactsPanelRemoveContactCommandText = "Remove From Contacts ";
            this.AddEmergencyRelationshipPickerTitleText = "Relationship";
            #endregion

            #region Select Emergency Contracts panel
            this.SelectEmergencyContactsPanelTitleLabel = "Choose Contacts";
            this.SelectEmergencyContactsPanelBackCommandText = "Back";
            this.SelectEmergencyContactsPanelSearchPlaceholderText = "Search";
            this.SelectEmergencyContactsPanelAddToEmergencyContactsCommandText = "Add to Contacts";
            this.SelectEmergencyContactsPanelAddingEmergencyContact = "AddingEmergencyContact"; //CakeSoft fixed bug SB-54
            this.SelectEmergencyContactsPanelAddingMonitoredContact = "AddingMontioredContact";
            #endregion

            #region Button Settings panel
            this.ButtonSettingsPanelTitleText = "Button Settings";
            this.ButtonSettingsPanelBackCommandText = "Back";
            this.ButtonSettingsPanelNextCommandText = "Next ";
            this.ButtonSettingsPanelSkipButtonText = "Skip this step for now";
            this.ButtonSettingsPanelTopInfoText = "You will push this button when you are in an emergency (Think “code red” situation).";
            this.ButtonSettingsPanelTopInfoBSText = "You will push this button when you are in a bad (but non-emergency) situation (Think “code yellow” situation).";
            this.ButtonSettingsPanelMiddleInfoText = "Edit the features that are activated when you push the Emergency button.";
            this.ButtonSettingsPanelMiddleInfoBSText = "Edit the features that are activated when you push the Bad situation button.";
            this.ButtonSettingsPanelBottomInfoText = "See what else you get with a Premium account!";
            this.ButtonSettingsPanelCheckOutPremiumButtonText = "Check Out Premium";
            this.ButtonSettingsPanelRedAlertTopInfoText = "Push this button when you are in an emergency (Think “code red” situation).";
            this.ButtonSettingsPanelSelectorLeftText = "Emergency";
            this.ButtonSettingsPanelSelectorRightText = "Bad Situation";
            #endregion

            #region What Happend panel
            this.WhatHappendPanelTopInfoText = "What just happened?";
            this.WhatHappendPanelFalseAlarmCommandText = "False Alarm";
            this.WhatHappendPanelNothingJustBeingCautiousCommandText = "Nothing, just being cautious";
            this.WhatHappendPanelIWasInABadSituationCommandText = "I was in a bad situation";
            this.WhatHappendPanelIWasAssaultedCommandText = "I was assaulted";
            this.WhatHappendPanelCloseButtonText = "Close";
            #endregion

            #region What Happened Popup panel
            this.WhatHappenedPopupPanelTitleText = "What happened?";
            this.WhatHappenedPopupPanelFalseAlarmText = "It was a false alarm";
            this.WhatHappenedPopupNothingJustBeingCautiousText = "Nothing, just being cautious";
            this.WhatHappenedPopupPanelIWasInABadSituationText = "I was in a bad situation";
            this.WhatHappenedPopupPanelIWasAssaultedText = "I was assaulted";
            this.WhatHappenedPopupPanelOtherText = "Other...";
            #endregion

            #region Incident Ended Popup panel
            this.IncidentEndedPopupPanelTitleText = "What happened?";
            this.IncidentEndedPopupPanelOtherText = "Other...";
            this.IncidentEndedPopupPanelIGotHurtText = "I got hurt";
            this.IncidentEndedPopupPanelIHaveToLeaveText = "I have to leave";
            this.IncidentEndedPopupPanelPoliceHaveArrivedText = "Police have arrived";
            this.IncidentEndedPopupPanelSituationIsStillHappeningText = "Situation is still happening";
            #endregion

            #region Forgot Password Popup panel
            this.ForgotPasswordPopupPanelTitleText = "Email sent!";
            this.ForgotPasswordPopupPanelInfoText = "Your passcode will be sent in 15 minutes.";
            this.ForgotPasswordPopupPanelGotItButtonText = "Got It!";
            #endregion

            #region Stay Signed In Popup panel
            this.StaySignedInPopupPanelTitleText = "Stay signed in? ";
            this.StaySignedInPopupPanelContentText = "Would you like to sign in with your passcode every time you open the app or stay signed in?";
            this.StaySignedInPopupPanelRelogInEveryTimeButtonText = "Re-log in every time";
            this.StaySignedInPopupPanelStayInSignedButtonText = "Stay signed in";
            #endregion

            #region Premium Popup Panel
            this.PremiumPopupPanelCongratulationsText = "Congratulations!";
            this.PremiumPopupPanelInfoFormatText = "You are now a Premium {0} member!";
            this.PremiumPopupPanelInfoText = "Start by tracking family and friends or by planning a route.";
            this.PremiumPopupPanelGotItButtonText = "Got It!";
            this.PremiumPopupPanelSilverText = "Silver";
            this.PremiumPopupPanelGoldText = "Gold";
            #endregion

            #region Work panel
            this.WorkPanelEmergencyCommandText = "Emergency";
            this.WorkPanelStarredCommandText = "Starred ";
            this.WorkPanelMapCommandText = "Map ";
            this.WorkPanelNotificationsCommandText = "Notifications ";
            this.WorkPanelAccountCommandText = "Account ";
            #endregion

            #region Emergency panel
            this.EmergencyPanelTitleText = "Emergency Activated";
            this.EmergencyPanelEmergencyText = "Emergency";
            this.EmergencyPanelBadSituationTitleText = "Bad Situation Activated";
            this.EmergencyPanelCallToPoliceTitleText = "Calling The Police";
            this.EmergencyPanelTopInfoText = "Sending help in…";
            this.EmergencyPanelSecondsText = "{0} seconds";
            this.EmergencyPanelEndRouteEarlyInfoText = "End Route Early";
            this.EmergencyPanelOutRouteInfoText = "You have deviated from your route.";
            this.EmergencyPanelActivatedInfoText = "Emergency Features Activated";
            this.EmergencyPanelBottomInfoText = "Type in passcode to disarm.";
            this.EmergencyPanelForgotPasswordCommandText = "Forgot Passcode? ";
            this.EmergencyPanelForgotPasswordInfoText = "Contact an emergency contact to get a temporary passcode.";
            #endregion

            #region End Route Early Panel
            this.EndRouteEarlyPanelTitleText = "Calling To Police";
            this.EndRouteEarlyPanelSecondsText = "End Route Early";
            this.EndRouteEarlyPanelBottomInfoText = "Type in passcode to disarm.";
            #endregion

            #region Test panel
            this.TestPanelTitleText = "Test Mode";
            this.TestPanelBackCommandText = "Back";
            this.TestPanelTopInfoText = "Test Mode temporarily allows you to test the emergency settings on your device without people thinking you are in a real emergency.";
            this.TestPanelEndTestModeButtonText = "End test mode now";
            this.TestPanelTestButtonText = "Test!";
            this.TestPanelNotifyEmergencyContactsLabelText = "Notify Emergency Contacts";
            this.TestPanelNotifyEmergencyContactsDescriptionText = "3 people read out of 5 sent";
            this.TestPanelAudioVideoRecordingLabelText = "Audio/Video Recording";
            this.TestPanelAudioVideoRecordingDescriptionText = "";
            this.TestPanelActivateFlashlightLabelText = "Activate Flashlight";
            this.TestPanelActivateFlashlightDescriptionText = "";
            this.TestPanelAlertNearbyCurrentUsersLabelText = "Alert Nearby Ulzi Users";
            this.TestPanelAlertNearbyCurrentUsersDescriptionText = "There are 18 Responders near you with 5 within 2 minutes of you.";
            this.TestPanelTurnOnSirenLabelText = "Turn On Siren";
            this.TestPanelTurnOnSirenDescriptionText = "";
            this.TestPanelSendMyLocationToPoliceLabelText = "Send My Location to Police";
            this.TestPanelSendMyLocationToPoliceDescriptionText = "Received! You are ";
            this.TestPanelSendMyLocationToPoliceLinkText = "here.";
            this.TestPanelCallAlarmMonitoringLabelText = "Call 24/7 Alarm Monitoring";
            this.TestPanelCallAlarmMonitoringDescriptionText = "";
            this.TestPanelCallPoliceLabelText = "Call Police";
            this.TestPanelCallPoliceDescriptionText = "Cannot test calling police.";
            #endregion

            #region Home panel
            this.HomePanelTitleText = "Welcome to Ulzi!";
            this.HomePanelTitleFormatText = "{0} Might Be In Trouble!";
            this.HomePanelLastUpdatedInfoLabelText = "Last Updated… {0} seconds ago";
            this.HomePanelBattaryLabelText = "Battery";
            this.HomePanelArmedLabelText = "Armed";
            this.HomePanelDisarmedLabelText = "Disarmed";
            this.HomePanelSafetyLabelText = "Safety";
            this.HomePanelEndTripButtonText = "End";
            this.HomePanelEndTripDownButtonText = "End Trip";
            this.HomePanelPauseTripButtonText = "Pause Trip";
            this.HomePanelContinueTripButtonText = "Continue Trip";
            this.HomePanelSaveCommandText = "Save";
            this.HomePanelWalkingTimeText = "Walk ({0} min)";
            this.HomePanelBicyclingTimeText = "Bike ({0} min)";
            this.HomePanelDrivingTimeText = "Drive ({0} min)";
            this.HomePanelSelfRespondersLabelText = " Responders nearby";
            this.HomePanelEditRouteDialogTitleText = "Route";
            this.HomePanelEditRouteDialogMessageText = "Route name already in use";
            this.HomePanelEditRouteDialogActionChangeText = "Change";
            this.HomePanelEditRouteDialogActionCancleText = "Cancel";
            #endregion

            #region Notifications panel
            #endregion

            #region Notification Main panel
            this.NotificationsMainPanelTitleText = "Notifications";
            #endregion

            #region Notifications Friend In Emergency Panel
            this.NotificationsInEmergencyPanelBackCommandText = "Back";
            this.NotificationsInEmergencyPanelTitleText = "{0} in EMERGENCY";
            this.NotificationsInEmergencyPanelPhoneStatusText = "Phone Status - {0}";
            this.NotificationsInEmergencyPanelEmergencyButtonLabelText = "Emergency Button - {0}";
            this.NotificationsInEmergencyPanelRespondersNearByLabelText = "Responders Near By - {0}";
            this.NotificationsInEmergencyPanelEmergencyButtonInactiviveText = "inactive";
            this.NotificationsInEmergencyPanelSafetyArmedSwitchText = "Active";
            this.NotificationsInEmergencyPanelEmergencyButtonAlarmText = "Alarm";
            this.NotificationsInEmergencyPanelPhoneOnStatusText = "ON";
            this.NotificationsInEmergencyPanelPhoneOffStatusText = "OFF";
            this.NotificationsInEmergencyPanelTrackingRouteText = "Tracking a Route";
            this.NotificationsInEmergencyPanelNotTrackingRouteText = "Not Tracking a Route";
            this.NotificationsInEmergencyPanelLocationTitleText = "THEIR LOCATION";
            this.NotificationsInEmergencyPanelReportToPoliceText = "Report their location to police!";
            this.NotificationsInEmergencyPanelMinText = "{0} minutes";
            this.NotificationsInEmergencyPanelMilesText = "{0} miles";
            this.NotificationsInEmergencyPanelMph = "{0} mph";
            this.NotificationsInEmergencyPanelDirectThereText = "Direct me there so I can help!";
            #endregion

            #region Notifications Call To Police Panel
            this.NotificationsCallPolicePanelBackCommandText = "Back";
            this.NotificationsCallPolicePanelTitleText = "On Phone with 911";
            this.NotificationsCallPolicePanelEndCallCommandText = "End Call";
            this.NotificationsCallPolicePanelReadToPoliceTitleText = "Read this to 911";
            this.NotificationsCallPolicePanelCallText = "<html style='font-size:12.75pt;line-height:20px'><span style='color:#9B9B9B'>\"A </span><span style='color:#woman'>{0} </span><span style='color:#9B9B9B'>named </span><span style='color:#woman'>{1} </span><span style='color:#9B9B9B'>needs help. Her address is:</span></html>";
            this.NotificationsCallPolicePanelMyPhoneLabelText = "My phone number is";
            this.NotificationsCallPolicePanelMyNameLabelText = "My name is";
            this.NotificationsCallPolicePanelInfoToPoliceTitleText = "Other Info for 911";
            this.NotificationsCallPolicePanelNameLabelText = "Name";
            this.NotificationsCallPolicePanelAgeLabelText = "Age";
            this.NotificationsCallPolicePanelEthnicityLabelText = "Ethnicity";
            this.NotificationsCallPolicePanelHairColorLabelText = "Hair Color";
            this.NotificationsCallPolicePanelHeightLabelText = "Height";
            this.NotificationsCallPolicePanelAllergiesLabelText = "Allergies";
            this.NotificationsCallPolicePanelMedicationsLabelText = "Medications";
            this.NotificationsCallPolicePanelMinText = "{0} minutes";
            this.NotificationsCallPolicePanelMilesText = "{0} miles";
            this.NotificationsCallPolicePanelMph = "{0} mph";
            this.NotificationsCallPolicePanelDirectThereText = "Direct me there so I can help!";
            #endregion

            #region Notifications Emergency Record Panel
            this.NotificationsEmergencyRecordPanelCallToPoliceLabelText = "Call 911";
            this.NotificationsEmergencyRecordPanelRespondersLabelText = "{0} responders";
            this.NotificationsEmergencyRecordPanelEndRecLabelText = "Do not confront assailant!";
            this.NotificationsEmergencyRecordPanelEndRecCommandText = "End Rec";
            #endregion

            #region Notifications Emergency Directions
            this.NotificationsDirectionsPanelMinText = "{0} min";
            this.NotificationsDirectionsPanelTimeText = "{0} h {1} min";
            this.NotificationsDirectionsPanelMilesText = "{0} mi";
            this.NotificationsDirectionsPanelFtText = "{0} ft";
            this.NotificationsDirectionsPanelCallToPoliceLabelText = "Call 911";
            this.NotificationsDirectionsPanelRespondersLabelText = "{0} responders";
            this.NotificationsDirectionsPanelEndNavLabelText = "Do not confront assailant!";
            this.NotificationsDirectionsPanelEndNavCommandText = "End Nav";
            #endregion

            #region Notifications Breaking News panel
            this.NotificationsBreakingNewsPanelTitleText = "Breaking News";
            this.NotificationsBreakingNewsPanelBackCommandText = "Back";
            #endregion

            #region Notifications Local Alert panel
            this.NotificationsLocalAlertPanelTitleText = "Local Alert";
            this.NotificationsLocalAlertPanelBackCommandText = "Back";
            #endregion

            #region Notifications Safety Tip panel
            this.NotificationsSafetyTipPanelTitleText = "Safety Tip";
            this.NotificationsSafetyTipPanelBackCommandText = "Back";
            #endregion

            #region Notifications Help Panel
            this.NotificationsHelpPanelBackCommandText = "Back";
            this.NotificationsHelpPanelTitleText = "Help";
            this.NotificationsHelpPanelReportToPoliceText = "Report their location to police!";
            this.NotificationsHelpPanelMinText = "{0} minutes";
            this.NotificationsHelpPanelMilesText = "{0} miles";
            this.NotificationsHelpPanelMphText = "{0} mph";
            this.NotificationsHelpPanelDirectThereText = "Direct me there so I can help!";
            #endregion

            #region Account panel
            this.AccountPanelMemberSinceFormatText = "Member Since {0}";
            this.AccountPanelViewProfileCommandText = "View Profile";
            this.AccountPanelSettingsCommandText = "Settings";
            this.AccountPanelShareCommandText = "Share";
            this.AccountPanelGetPremiumCommandText = "Get Premium!";
            this.AccountPanelContactUsCommandText = "Contact Us ";
            this.AccountPanelFriendsCommandText = "{0} Friends";
            this.AccountPanelProfileCommandText = "Profile";
            this.AccountPanelGiftAppCommandText = "Gift the App! ";
            this.AccountPanelFollowUsCommandText = "Follow Us ";
            #endregion

            #region List panel
            this.ListPanelSelectorLeftText = "People";
            this.ListPanelSelectorRightText = "Places";
            this.ListPanelPeoplesListTitleText = "People You’re Tracking";
            this.ListPanelAddPeopleCommandText = "Add Person";
            this.ListPanelPlacesListTitleText = "Your Places";
            this.ListPanelAddPlaceCommandText = "Add Place";
            this.ListPanelPendingApproval = "Pending Approval";
            #endregion

            #region Add Place panel
            this.AddPlacePanelTitleText = "Add a New Place";
            this.ModifyPlacePanelTitleText = "Modify Place"; //CakeSoft fixed bug SB-18
            this.AddPlacePanelTopInfoText = "This way we can keep you safe while traveling there (e.g. school, home)";
            this.AddPlacePanelNameLabelText = "ENTER PLACE NAME";
            this.AddPlacePanelAddressLabelText = "ADDRESS";
            this.AddPlacePanelMinutesText = "{0} minutes";
            this.AddPlacePanelMilesText = "{0} miles";
            this.AddPlacePanelSaveButtonText = "Save Place!";
            #endregion

            #region Start Recording Route
            this.StartRecordingRoutePanelInfoTextLine_1 = "Click the start button then go. We will record and save your route for future use.";
            this.StartRecordingRoutePanelInfoTextLine_2 = "Warning: Keep the app open and your emergency button close at hand! Since we don’t know your exact route we won't be able to monitor the path you are taking.";
            this.StartRecordingRoutePanelButtonText = "Start Recording Route";
            #endregion

            #region End Recording Route panel
            this.EndRecordingRoutePanelInfoText = "Warning: Keep the app open and your emergency button close at hand! Since we don’t know your exact route we won't be able to monitor the path you are taking.";
            this.EndRecordingRoutePanelButtonText = "End Recording Route";
            #endregion

            #region Edit Route Info panel
            this.EditRouteInfoPanelInfoTextLine_1 = "To edit the route: Click and drag any point on the map. Add a point by tapping anywhere on the route.";
            this.EditRouteInfoPanelInfoTextLine_2 = "To delete a point: Select the point and click the Trash icon.";
            this.EditRouteInfoPanelInfoTextLine_3 = "To select multiple points: Click the Lasso icon and group the points you want to adjust.";
            this.EditRouteInfoPanelInfoTextLine_4 = "To adjust the width of the route: Click the Arrow icon and adjust the slider. If you deviate from this route, we’ll ask if you’re okay—so the wider the route, the more leeway you have before the alarm is activated.";
            #endregion

            #region End Route Info panel
            this.EndRouteInfoPanelInfoTextLine_1 = "We are monitoring your activity as you travel to your destination.";
            this.EndRouteInfoPanelInfoTextLine_2 = "If something seems off, we will send you an alert and ask for your emergency passcode.";
            this.EndRouteInfoPanelInfoTextLine_3 = "If you don't enter your passcode in time, we will activate your emergency features.";
            #endregion

            #region Profile panel
            this.ProfilePanelBackCommandText = "Back";
            this.ProfilePanelTopInfoText = "If you’re in danger, this information is used to assist emergency medical and police.";
            this.ProfilePanelCompletedPercentText = "Your profile is {0}% complete.";
            this.ProfilePanelBasicInfoText = "Basic Information";
            this.ProfilePanelMedicalInfoText = "Medical Information";
            this.ProfilePanelEmergencyContactInfoText = "Emergency Contact Info";
            this.ProfilePanelSaveCommandText = "Save";
            this.ProfilePanelFirstAndLastNameLabelText = "FIRST AND LAST NAME";
            this.ProfilePanelGenderLabelText = "GENDER";
            this.ProfilePanelBirthDayLabelText = "BIRTHDAY";
            this.ProfilePanelEmailLabelText = "EMAIL";
            this.ProfilePanelPhoneNumberLabelText = "PHONE NUMBER";
            this.ProfilePanelConnectSocialMediaLabelText = "CONNECT SOCIAL MEDIA";
            this.ProfilePanelHeightLabelText = "HEIGHT";
            this.ProfilePanelWeightLabelText = "WEIGHT";
            this.ProfilePanelHairColorLabelText = "HAIR COLOR";
            this.ProfilePanelEyeColorLabelText = "EYE COLOR";
            this.ProfilePanelEthnicityLabelText = "ETHNICITY";
            this.ProfilePanelStreetLabelText = "STREET";
            this.ProfilePanelCityLabelText = "CITY";
            this.ProfilePanelStateLabelText = "STATE";
            this.ProfilePanelZipCodeLabelText = "ZIP CODE";
            this.ProfilePanelAllergiesLabelText = "ALLERGIES";
            this.ProfilePanelMedicationsLabelText = "MEDICATIONS";
            this.ProfilePanelEmergencyContactNameLabelText = "NAME";
            this.ProfilePanelEmergencyContactRelationLabelText = "RELATION";
            this.ProfilePanelEmergencyContactEmailLabelText = "EMAIL";
            this.ProfilePanelEmergencyContactPhoneNumberLabelText = "PHONE NUMBER";
            this.ProfilePanelGetAnotherEmergencyContactButtonText = "Add another emergency contact";
            this.ProfilePanelLoggedToastText = "You're already logged in {0}";
            this.ProfilePanelTitleText = "Profile";
            this.ProfilePanelMedicalInfoHeaderText = "Medical Info";
            this.ProfilePanelBasicInfoHeaderText = "Basic Info";
            this.ProfilePanelEmergencyContactHeaderInfoText = "Emergency Contacts";
            this.ProfilePanelSexLabelText = "SEX";
            this.ProfilePanelAddressLabelText = "ADDRESS";
            this.ProfilePanelStaySignedInHeaderInfoText = "Stay Signed In";
            this.ProfilePanelFacefookButtonText = "Connect Facebook";
            this.ProfilePanelStaySignedInfoText = "Would you like to sign in with your passcode every time you open the app or stay signed in?";
            this.ProfilePanelStaySignedLabelText = "Stay signed in";
            #endregion

            #region Settings panel
            this.SettingsPanelTitleText = "Settings";
            this.SettingsPanelBackCommandText = "Back";
            this.SettingsPanelEditProfileCommandText = "Edit Profile";
            this.SettingsPanelEmergencyButtonSettingsCommandText = "Emergency Button Settings";
            this.SettingsPanelNotificationSettingsCommandText = "Notification Settings";
            this.SettingsPanelChangeDeactivationPasscodeCommandText = "Change Deactivation Passcode";
            this.SettingsPanelEmergencyContactsCommandText = "Contacts";
            this.SettingsPanelBlockedPeopleCommandText = "Blocked People";
            this.SettingsPanelLocationSharingCommandText = "Location Sharing";
            this.SettingsPanelTestModeCommandText = "Test Mode";
            this.SettingsPanelTutorialCommandText = "Tutorial";
            this.SettingsPanelReceiveSafetyTipsCommandText = "Receive Safety Tips";
            this.SettingsPanelReceiveAlertsCommandText = "Receive alerts when someone near you needs help";
            this.SettingsPanelRecordCommandText = "Audio/Video Recording";
            this.SettingsPanelLockSettingsCommandText = "Lock Settings";
            this.SettingsPanelEditLocationSharingCommandText = "People Who Can See Me";
            this.SettingsPanelTrackFriendsCommandText = "People I Can See";
            this.SelectEmergencyContactsPanelAddToEmergencyContactsCommandText = "Add to Contacts";
            this.SelectEmergencyContactsPanelRequestLocationSharingCommandText = "Request Location Sharing";
            this.SharePanelShareWithSelectedContacts = "Add to Contacts";
            this.SettingsPanelTermsofUse = "Terms of Use";
            this.SettingsPanelPrivacyPolicies = "Privacy Policies";// CakeSoft fixed bug ulzi-5
            #endregion

            #region Share panel
            this.SharePanelTitleText = "Share Ulzi";
            this.SharePanelBackCommandText = "Back";
            this.SharePanelShareCommandText = "Share";
            this.SharePanelTopInfoText = "Our goal is to bring safety and peace of mind to as many people as possible. Help us spread the word!";
            this.SharePanelWriteACaptionPlaceholderText = "Write a caption…";
            this.SharePanelTagPeopleCommandText = "Tag People";
            this.SharePanelFacebookCommandText = "Facebook";
            this.SharePanelTwitterCommandText = "Twitter";
            this.SharePanelInstagramCommandText = "Instagram";
            this.SharePanelPinterestCommandText = "Pinterest";
            this.SharePanelLinkedInCommandText = "LinkedIn";
            this.SharePanelTextCommandText = "Text";
            this.SharePanelEmailCommandText = "Email";
            this.SharePanelWriteAMessagePlaceholderText = "Write a message…";
            this.SharePanelChoosePeopleToShareCommandText = "Choose People to Share Via Text";
            this.SharePanelChooseShareViaEmailCommandText = "Share Via Email";
            this.SharePanelSubjectText = "Invitation To Ulzi";
            this.SharePanelShareInfoText = "Give one, get one! Give a month of Ulzi Premium to a friend, and get one when they purchase! Safety is made to be shared. So why not get rewarded while you do it?";
            this.SharePanelMessageText = "Share Ulzi message";
            #endregion

            #region Contact Us panel
            this.ContactUsPanelTitleText = "Contact Us";
            this.ContactUsPanelBackCommandText = "Back";
            this.ContactUsPanelContentTitleText = "We’re In This Together";
            this.ContactUsPanelTopInfoText = "If we can do a better job helping you feel safe, we want to know. Message us your feature suggestions, general concerns, or just to say hi. Or you can check us out on our social media accounts.";
            this.ContactUsPanelSubjectLabelText = "SUBJECT";
            this.ContactUsPanelMessageLabelText = "MESSAGE";
            this.ContactUsPanelSendButtonText = "Send!";
            this.ContactUsPanelFeedbackTitleText = "We Love Feedback";
            this.ContactUsPanelMailIdText = "contactus@ulzi.com";
            #endregion

            #region Premium Account panel
            this.PremiumAccountPanelTitleText_old = "Premium Account";
            this.PremiumAccountPanelBackCommandText = "Back";
            this.PremiumAccountPanelPremiumSilverButtonText = "Try Premium Silver";
            this.PremiumAccountPanelPremiumGoldButtonText = "Get Premium Gold!";
            this.PremiumAccountPanelCancelPremiumButtonText = "Cancel Premium Account";
            this.PremiumAccountPanelTitleText = "Get Premium";
            this.PremiumAccountPanelTrySilverButtonText = "Try Silver";
            this.PremiumAccountPanelTryGoldButtonText = "Try Gold";
            this.PremiumAccountPanelGiftAppCommandText = "Gift the App!";
            this.PremiumAccountPanelCancelSilverButtonText = "Cancel Silver Account";
            this.PremiumAccountPanelCancelGoldButtonText = "Cancel Gold Account";
            #endregion

            #region Change Passcode panel
            this.ChangePasscodePanelTitleText = "Change Passcode";
            this.ChangePasscodePanelBackCommandText = "Back";
            this.ChangePasscodePanelSaveCommandText = "Save";
            this.ChangePasscodePanelTopInfoText = "Passcode will be used to disarm emergency features.";
            this.ChangePasscodePanelOldPasscodeLabelText = "ENTER OLD PASSCODE";
            this.ChangePasscodePanelNewPasscodeLabelText = "ENTER NEW PASSCODE";
            this.ChangePasscodePanelRepeatNewPasscodeLabelText = "REPEAT NEW PASSCODE";
            // Cakesoft Fixed SB-2
            this.ChangePasscodePanelForgotPasscodeCommandText = "Forgot Passcode?";
            this.ChangePasscodePanelNextCommandText = "Next";
            #endregion

            #region Button Settings panel
            this.AccountButtonSettingsPanelTitleText = "Button Settings";
            this.AccountButtonSettingsPanelBackCommandText = "Back";
            this.AccountButtonSettingsPanelFirstTopInfoText = "You can customize which features are activated when certain buttons are pressed. ";
            this.AccountButtonSettingsPanelSecondTopInfoText = "You can customize which features are activated when emergency button is pressed. ";
            this.AccountButtonSettingsAction1ButtonText = "Action 1";
            this.AccountButtonSettingsAction2ButtonText = "Action 2";
            this.AccountButtonSettingsAction3ButtonText = "Action 3";
            this.AccountButtonSettingsImageTitleFormatText = "Action {0}:";
            this.AccountButtonSettingsBottomInfoText = "See what else you get with a premium account!";
            this.AccountButtonSettingsCheckOutPremiumButtonText = "Check Out Premium";
            #endregion

            #region Location Sharing panel
            this.LocationSharingPanelTitleText = "People Who Can See Me"; // "Location Sharing";
            this.LocationSharingPanelBackCommandText = "Back";
            this.LocationSharingPanelTopInfoText = "Who can see your location";
            this.LocationSharingPanelNewTopInfoText = "Who can view your location";
            this.LocationSharingPanelAddAnotherContactButtonText = "Add Another Contact";
            this.LocationSharingPanelUnlockPremiumButtonText = "Unlock Premium";
            this.LocationSharingPanelExpanderTopInfoText = "Pause location sharing for…";
            this.LocationSharingPanelExpanderDaysLabelText = "Days";
            this.LocationSharingPanelExpanderHoursLabelText = "Hours";
            this.LocationSharingPanelExpanderMinutesLabelText = "Minutes";
            this.LocationSharingPanelExpanderCancelCommandText = "Cancel";
            this.LocationSharingPanelExpanderDoneCommandText = "Done";
            this.LocationSharingPanelAddPeopleCommandText = "Add Person";
            this.LocationSharingPanelPendingApproval = "Pending Approval";
            #endregion

            #region Start Trip panel
            this.StartTripLabelText = "Start a Trip ";
            this.StartTripPanelDeletePlaceLabelText = "Delete Place";
            this.StartTripPanelStartTextFormat = "{0} min";
            this.StartTripPanelStartRouteLabelText = "Start a Route";
            this.StartTripPanelDeleteLocationCommandText = "Delete Location";
            this.StartTripPanelSavedRouteCommandText = "Saved Route";
            this.StartTripPanelNewRouteCommandText = "New Route";
            #endregion

            #region Track Person panel
            this.TrackPersonPanelSafetyStatusLabelText = "Safety Status";
            this.TrackPersonPanelSafeStatusText = "Safe";
            this.TrackPersonPanelStandByStatusText = "Stand By";
            this.TrackPersonPanelUnsafeStatusText = "UnSafe";
            this.TrackPersonPanelPhoneStatusText = "Phone Status - {0}";
            this.TrackPersonPanelPhoneOnStatusText = "ON";
            this.TrackPersonPanelPhoneOffStatusText = "OFF";
            this.TrackPersonPanelSafetySwitchLabelText = "Safety Switch - {0}";
            this.TrackPersonPanelSafetyArmedSwitchText = "Armed";
            this.TrackPersonPanelSafetyDisarmedSwitchText = "Disarmed";
            this.TrackPersonPanelStunLastActivatedLabelText = "Stun Last Activated - {0}";
            this.TrackPersonPanelMinText = "{0} minutes";
            this.TrackPersonPanelMilesText = "{0} miles";
            this.TrackPersonPanelDaysText = "days";
            this.TrackPersonPanelRespondersNearByLabelText = "Responders Near By - {0}";
            this.TrackPersonPanelCurrentLocationTitleText = "Their Location: ";
            this.TrackPersonPanelSecondsFormatText = "{0} seconds ago";
            this.TrackPersonPanelInfoFormatText = "{0} miles away, moving {1} mph headed {2}";
            this.TrackPersonPanelInfoFormatWithoutHeadedText = "{0} miles away, moving {1} mph ";
            this.TrackPersonPanelLocalEmergencyCenterTitleText = "LOCAL EMERGENCY RESPONSE CENTER";
            this.TrackPersonPanelMph = "{0} mph";
            this.TrackPersonPanelDirectionsButtonText = "Directions";
            this.TrackPersonPanelMapOfFrequentLabelText = "View Map of Frequent Locations";
            this.TrackPersonPanelNotificationZonesTitleText = "ZONE NOTIFICATION:";
            this.TrackPersonPanelAddLocationCommandText = "Add Another Location";
            this.TrackPersonPanelNotificationSpeedTitleText = "SPEED NOTIFICATION:";
            this.TrackPersonPanelNotificationSpeedText = "Speed Limit Notification";
            this.TrackPersonPanelNotificationSettingsTitleText = "NOTIFICATION SETTINGS FOR {0}:";
            this.TrackPersonPanelInEmergencyText = "In Emergency";
            this.TrackPersonPanelCaseArmedText = "Case Armed";
            this.TrackPersonPanelNotificationZonesText = "Notification Zone";
            this.TrackPersonPanelNotificationSoundsTitleText = "NOTIFICATION SOUNDS:";
            this.TrackPersonPanelRingtoneText = "Ringtone";
            this.TrackPersonPanelNotificationText = "Notification";
            this.TrackPersonPanelStopTrackingCommandText = "Stop Tracking {0}";
            this.TrackPersonPanelArriveLabelText = "Arrive";
            this.TrackPersonPanelLeaveLabelText = "Leave";
            this.TrackPersonPanelRingVibrateNotificationSettingLabelText = "Ring, Vibrate, & Notification";
            this.TrackPersonPanelVibrateNotificationSettingLabelText = "Notification & Vibrate";
            this.TrackPersonPanelNotificationSettingLabelText = "Notification";
            this.TrackPersonPanelNoNotificationSettingLabelText = "No Notification";
            this.TrackPersonPanelEmergencyButtonLabelText = "Emergency Button - {0}";
            this.TrackPersonPanelEmergencyButtonInactiviveText = "Emergency Button - Inactive";
            this.TrackPersonPanelEmergencyButtonActiviveText = "Emergency Button - Activated";
            this.TrackPersonPanelEmergencyButtonAlarmText = "Alarm";
            this.TrackPersonPanelTrackingRouteText = "Tracking a Route";
            this.TrackPersonPanelNotTrackingRouteText = "Not Tracking a Route";
            this.TrackPersonPanelReportToPoliceText = "Report their location to police";
            this.TrackPersonPanelDirectThereText = "Direct me there";
            this.TrackPersonPanelInBadSituationText = "In Bad Situation";
            this.TrackPersonPanelDeviatedFromRouteText = "Deviated From Route";
            this.TrackPersonPanelOnMyWayButtonText = "I’m on my way";
            this.TrackPersonPanelCallPoliceButtonText = "Call 911";
            this.TrackPersonPanelEventHasEndedButtonText = "Event Has Ended";
            this.TrackPersonPanelEndCallButtonText = "End Call";
            this.TrackPersonPanelVitalInfoText = "Vital info to read to 911:";
            this.TrackPersonPanelVitalInfoNameText = "Name";
            this.TrackPersonPanelVitalInfoAgeText = "Age";
            this.TrackPersonPanelVitalInfoSexText = "Sex";
            this.TrackPersonPanelVitalInfoHeightText = "Height";
            this.TrackPersonPanelVitalInfoEthnicityText = "Ethnicity";
            this.TrackPersonPanelVitalInfoHairColorText = "Hair Color";
            this.TrackPersonPanelVitalInfoAllergiesText = "Allergies";
            this.TrackPersonPanelVitalInfoMedicationsText = "Medications";
            #endregion

            #region Notification Settings Set Panel
            this.NotificationSettingsSetPanelTitleText = "Notification Settings";
            this.NotificationSettingsSetPanelBackCommandText = "Back";
            this.NotificationSettingsSetPanelTopInfoText = "Emergency contact is in a bad situation";
            this.NotificationSettingsSetPanelFlashRingVibrateNotificationLabelText = "Flash, Ring, Vibrate, & Notification";
            this.NotificationSettingsSetPanelRingVibrateNotificationLabelText = "Ring, Vibrate, & Notification";
            this.NotificationSettingsSetPanelVibrateNotificationLabelText = "Vibrate & Notification";
            this.NotificationSettingsSetPanelNotificationLabelText = "Notification";
            #endregion

            #region Notification Settings Panel
            this.NotificationSettingsPanelBackCommandText = "Back";
            this.NotificationSettingsPanelTitleText = "Notification Settings";
            this.NotificationSettingsPanelNotificationsLabelText = "NOTIFICATIONS";
            this.NotificationSettingsPanelNotificationStyleLabelText = "NOTIFICATION STYLE";
            this.NotificationSettingsPanelBeAHeroItemText = "Be a Hero - Receive alerts when someone near you needs help.";
            this.NotificationSettingsPanelReceiveSafetyTipsItemText = "Receive Safety Tips";
            this.NotificationSettingsPanelYouTrackInTroubleItemText = "Someone you track is in trouble";
            this.NotificationSettingsPanelContactInTroubleItemText = "Emergency contact is in trouble";
            this.NotificationSettingsPanelContactInBadSituationItemText = "Emergency contact is in a bad situation";
            this.NotificationSettingsPanelNeedsYourHelpItemText = "Someone nearby needs your help";
            this.NotificationSettingsPanelOtherNotificationItemText = "Other Notifications";
            this.NotificationSettingsPanelGetAlertsItemText = "Get alerts when someone near you needs help.";
            this.NotificationSettingsPanelGetAlertsTrackItemText = "Get alerts when someone you track is in a registered sex offenders house.";
            this.NotificationSettingsPanelGetSafetyTipsItemText = "Get Safety Tips";
            this.NotificationSettingsPanelContactInYeallowAlertItemText = "Emergency contact is in a yellow alert";
            #endregion

            #region Verify Email Panel
            this.VerifyEmailPanelTitleText = "Verify Email";
            this.VerifyEmailPanelBackCommandText = "Back";
            this.VerifyEmailPanelTopInfoText = "Please verify your email address by clicking the link in the email you received when signing up.";
            this.VerifyEmailPanelEmailLabelText = "EMAIL";
            this.VerifyEmailPanelResendEmailButtonText = "Resend Email";
            #endregion

            #region Upgrade To Panel
            this.UpgradeToPanelSilverTitleText = "Upgrade To Silver";
            this.UpgradeToPanelGoldTitleText = "Upgrade To Gold";
            this.UpgradeToPanelBackCommandText = "Back";
            this.UpgradeToPanelRegularText = "Regular";
            this.UpgradeToPanelStudentText = "Student";
            this.UpgradeToPanelPremiumSilverLabelText = "PREMIUM: SILVER";
            this.UpgradeToPanelPremiumGoldLabelText = "PREMIUM: GOLD";
            this.UpgradeToPanelMonthlySubscribtionText = "Monthly Subscription";
            this.UpgradeToPanelYearlySubscribtionText = "Yearly Subscription";
            this.UpgradeToPanelDiscountCodeLabelText = "DISCOUNT CODE";
            this.UpgradeToPanelDiscountCodePlaceholderText = "Enter code";
            this.UpgradeToPanelDiscountCodeNiceText = "Nice! You get three months for free!";
            this.UpgradeToPanelContinueButtonText = "Continue";
            this.UpgradeToPanelUpgradeToGold = "Upgrade to Gold instead!";
            this.UpgradeToPanelAnnualSubscribtionText = "Annual Subscription";
            #endregion

            #region Check Out Panel
            this.CheckOutPanelTitleText = "Checkout";
            this.CheckOutPanelBackButtonText = "Back";
            this.CheckOutPanelTaxText = "Tax";
            this.CheckOutPanelTotalText = "Total";
            this.CheckOutPanelGiftTheAppButtonText = "Gift the App";
            this.CheckOutPanelCheckOutButtonText = "Check Out";
            #endregion

            #region Gift The App Panel
            this.GiftTheAppPanelTitleText = "Gift the App";
            this.GiftTheAppPanelBackButtonText = "Back";
            this.GiftTheAppPanelGiftToText = "Gift to: {0}";
            this.GiftTheAppPanelPremiumSilverLabelText = "PREMIUM: SILVER";
            this.GiftTheAppPanelSilverMonthlySubscriptionText = "Monthly Subscription";
            this.GiftTheAppPanelSilverYearlySubscriptionText = "Yearly Subscription";
            this.GiftTheAppPanelPremiumGoldLabelText = "PREMIUM: GOLD";
            this.GiftTheAppPanelGoldMonthlySubscriptionText = "Monthly Subscription";
            this.GiftTheAppPanelGoldYearlySubscriptionText = "Yearly Subscription";
            this.GiftTheAppPanelContinueButtonText = "Continue";
            this.GiftTheAppPanelAnnualSubscribtionText = "Annual Subscription";
            #endregion

            #region Gift The App Start Panel
            this.GiftTheAppStartTitleText = "Gift the App";
            this.GiftTheAppStartTopInfoText = "Want to keep someone else safe?";
            this.GiftTheAppStartChooseWhoButtonText = "Choose Who To Gift The App To";
            #endregion

            #region Check Out Card Panel
            this.CheckOutCardPanelTitleText = "Checkout";
            this.CheckOutCardPanelBackButtonText = "Back";
            this.CheckOutCardPanelTopInfoText = "This is where the auto updating credit card image goes";
            this.CheckOutCardPanelCardNumberLabelText = "CARD NUMBER";
            this.CheckOutCardPanelCardNumberPlaceholderText = "XXXX XXXX XXXX XXXX";
            this.CheckOutCardPanelFullNameLabelText = "FULL NAME";
            this.CheckOutCardPanelFullNamePlaceholderText = "Full Name";
            this.CheckOutCardPanelExpirationDateLabelText = "EXPIRATION DATE";
            this.CheckOutCardPanelExpirationDatePlaceholderText = "XX/XX";
            this.CheckOutCardPanelCVCLabelText = "CVC";
            this.CheckOutCardPanelCVCPlaceholderText = "XXX";
            this.CheckOutCardPanelPurchaseSubscribtionButtonText = "Purchase Subscription";
            #endregion

            #region Ringtone Panel
            this.RingtonePanelBackCommandText = "Back";
            this.RingtonePanelTitleText = "Ringtone";
            #endregion

            #region Set Tracking Zone Panel
            this.SetTrackingZonePanelBackCommandText = "Back";
            this.SetTrackingZonePanelTitleText = "Set Tracking Zone";
            this.SetTrackingZonePanelSaveCommandText = "Save";
            this.SetTrackingZonePanelSearchLocationText = "Search Location…";
            this.SetTrackingZonePanelLocationNameText = "LOCATION NAME";
            this.SetTrackingZonePanelNotifyWhenText = "NOTIFY ME WHEN";
            this.SetTrackingZonePanelArrivesText = "Arrives";
            this.SetTrackingZonePanelLeavesText = "Leaves";
            this.SetTrackingZonePanelDeleteCommandText = "Delete Zone";
            #endregion

            #region Share Your Location Panel
            this.ShareYourLocationPanelTitleText = "Share Your Location";
            this.ShareYourLocationPanelBackCommandText = "Back";
            this.ShareYourLocationPanelTopInfoText = "The person below would like to track your location to help keep you safe. ";
            this.ShareViewLocationPanelYesButtonText = "Yes, they can track me!";
            this.ShareViewLocationPanelNoButtonText = "No, they cannot track me.";
            this.ShareViewLocationPanelBottomInfoText = "Do not accept if you do not know them. If you are unsure you can click on their phone number to call them.";
            this.ShareViewLocationPanelPendingApprovalText = "Pending your approval";
            this.ShareYourLocationPanelShareInfoText = "{0} would like to track your location to help keep you safe.";
            this.ShareViewLocationPanelShareBottomInfoText = "If you do not know this person, do not accept. If you are unsure, you can click on their phone number to call them.";
            #endregion

            #region Route Out Emergency Activated Panel
            this.RouteOutEmergencyActivatedPanelTitleText = "Emergency Activated";
            this.RouteOutEmergencyActivatedPanelTopInfoText = "You have deviated from your route.";
            this.RouteOutEmergencyActivatedPanelSendingText = "Sending help in…";
            this.RouteOutEmergencyActivatedPanelSecondsTemplate = "{0} seconds";
            this.RouteOutEmergencyActivatedPanelPasscodeText = "Type in passcode to disarm.";
            #endregion

            #region Add New Route Panel
            this.AddNewRoutePanelHeaderText = "Add New Route";
            this.AddNewRoutePanelNewEditText = "New & Edit";
            this.AddNewRoutePanelNewEditContentText = "Create and configure the route yourself.";
            this.AddNewRoutePanelGenerateEditText = "Generate & Edit";
            this.AddNewRoutePanelRecordText = "Record";
            this.AddNewRoutePanelGenerateEditContentText = "Let us generate the fastest route. Then you can tweak it.";
            this.AddNewRoutePanelRecordContentText = "Record the route you take and save it for future use.";
            #endregion

            #region EditRouteNameDialog
            this.EditRouteNameDialogTitleText = "Name Your Route";
            this.EditRouteNameDialogNamePlaceholderText = "Input";
            this.EditRouteNameDialogCancelButtonText = "Cancel";
            this.EditRouteNameDialogSaveButtonText = "Save";
            #endregion

            #region EditSpeedLimitDialog
            this.EditSpeedLimitDialogTitleText = "Entry Speed Limit";
            this.EditSpeedLimitDialogSpeedLimitPlaceholderText = "Input";
            this.EditSpeedLimitDialogCancelButtonText = "Cancel";
            this.EditSpeedLimitDialogSaveButtonText = "Save";
            #endregion

            #region Enter Passcode
            this.EditPasswordDialogTitleText = "Enter password to change settings"; ;
            this.EditPasswordDialogPasscodePlaceholderText = "Input";
            this.EditPasswordDialogCancelButtonText = "Cancel";
            this.EditPasswordDialogOkButtonText = "OK";
            // Cakesoft Fixed SB-84
            this.EditPasswordDialogForgotPasscodeButtonText = "Forgot Passcode?";
            #endregion

            #region Saved Route Hide Panel
            this.SavedRouteHidePanelRouteName = "Route: {0}";
            this.SavedRouteHidePanelStartButtonText = "Start";
            #endregion

            #region Friends List Panel
            this.FriendsListPanelTitleText = "Friends List";
            #endregion

            #region Lock Settings Panel
            this.LockSettingsPanelTitleText = "Lock Settings";
            this.LockSettingsPanelNextCommandText = "Next ";
            this.LockSettingsPanelSettingsProtectedText = "I want settings to be password protected.";
            this.LockSettingsPanelOldPasswordLabelText = "OLD PASSWORD";
            this.LockSettingsPanelNewPasswordLabelText = "NEW PASSWORD";
            this.LockSettingsPanelReenterPasswordLabelText = "RE-ENTER PASSWORD";
            this.LockSettingsPanelForgotPasscodeCommandText = "Forgot Passcode? ";
            #endregion

            #region Track Friends And Family Panel
            this.TrackFriendsPanelTitleText = "People I Can See";
            this.TrackFriendsPanelYourPeopleLabelText = "Your People";
            this.TrackFriendsPanelPendingApproval = "Pending Approval";
            this.TrackFriendsPanelAddPeopleCommandText = "Add Person";
            #endregion

            #region Location Auto Complete Panel
            this.LocationAutoCompletePanelSearchLocationPlaceholderText = "Location Search...";
            #endregion

            #region Incident Ended Panel
            this.IncidentEndedPanelTitleText = "Incident Ended";
            this.IncidentEndedPanelTopInfoText = "Tell us more about what happened.";
            this.IncidentEndedPanelEvidenceText = "I have evidence from the incident.";
            this.IncidentEndedPanelRecordingText = "You can access the recording from my phone to be used for evidence.";
            this.IncidentEndedPanelSendButtonText = "Send!";
            this.IncidentEndedPanelSendCommandText = "Send ";
            this.IncidentEndedPanelWhatHappenedLabelText = "WHAT HAPPENED?";
            #endregion

            #region Help Person Panel
            this.HelpPersonPanelCurrentLocationTitleText = "THEIR LOCATION: ";
            this.HelpPersonPanelSecondsFormatText = "{0} seconds ago";
            this.HelpPersonPanelMinutesFormatText = "{0} minutes ago";
            this.HelpPersonPanelInfoFormatText = "{0} miles away, moving {1} mph headed {2}";
            this.HelpPersonPanelOnMyWayText = "On my way";
            this.HelpPersonPanelEventHasEndedText = "Event Has Ended";
            this.HelpPersonPanelCallPoliceText = "Call 911";
            this.HelpPersonPanelEndCallText = "End Call";
            this.HelpPersonPanelVitalInfoLabelText = "Vital info to read to 911:";
            this.HelpPersonPanelNameLabelText = "Name";
            this.HelpPersonPanelAgeLabelText = "Age";
            this.HelpPersonPanelSexLabelText = "Sex";
            this.HelpPersonPanelHeightLabelText = "Height";
            this.HelpPersonPanelEthnicityLabelText = "Ethnicity";
            this.HelpPersonPanelHairColorLabelText = "Hair Color";
            this.HelpPersonPanelAllergiesLabelText = "Allergies";
            this.HelpPersonPanelMedicationsLabelText = "Medications";
            #endregion

            #region Person At Incident Panel
            this.PersonAtIncidentPanelTopInfoText = "Stay at a safe distance." + Environment.NewLine + "Do not approach assailant." + Environment.NewLine + "Keep video camera recording and facing assailant.";
            this.PersonAtIncidentPanelCurrentLocationTitleText = "THEIR LOCATION: ";
            this.PersonAtIncidentPanelSecondsFormatText = "{0} seconds ago";
            this.PersonAtIncidentPanelMinutesFormatText = "{0} minutes ago";
            this.PersonAtIncidentPanelInfoFormatText = "{0} miles away, moving {1} mph headed {2}";
            this.PersonAtIncidentPanelEventHasEndedText = "Event Has Ended";
            this.PersonAtIncidentPanelCallPoliceText = "Call 911";
            this.PersonAtIncidentPanelEndCallText = "End Call";
            this.PersonAtIncidentPanelVitalInfoLabelText = "Vital info to read to 911:";
            this.PersonAtIncidentPanelNameLabelText = "Name";
            this.PersonAtIncidentPanelAgeLabelText = "Age";
            this.PersonAtIncidentPanelSexLabelText = "Sex";
            this.PersonAtIncidentPanelHeightLabelText = "Height";
            this.PersonAtIncidentPanelEthnicityLabelText = "Ethnicity";
            this.PersonAtIncidentPanelHairColorLabelText = "Hair Color";
            this.PersonAtIncidentPanelAllergiesLabelText = "Allergies";
            this.PersonAtIncidentPanelMedicationsLabelText = "Medications";
            #endregion

            #region Verify Email Popup panel
            this.VerifyEmailPopupPanelTitleText = "Email sent!";
            this.VerifyEmailPopupPanelInfoText = "Check your email for confirmation.";
            this.VerifyEmailPopupPanelGotItButtonText = "Got It!";
            #endregion

            #region Contacts Info Panel
            this.ContactsInfoPanelPendingApprovalText = "Pending Approval";
            this.ContactsInfoPanelLocationSharingPauseText = "Location sharing paused";
            this.ContactsInfoPanelPermissionGrantedText = "Permission granted or will be notified.";
            #endregion

            #region Blocked People Page
            this.BlockedPeoplePageTitleText = "Blocked People";
            this.BlockedPeoplePageTopInfoText = "Add any information you have on someone that you would like to be blocked from being notified as a community responder when you are in an emergency. You do not need to fill out every field.  Blocked users will not receive any notifications when you are in an emergency or bad situation.  A blocked user’s requests to track you will be deleted before they get to you.";
            this.BlockedPeoplePageFirstNameLabelText = "FIRST NAME";
            this.BlockedPeoplePageLastNameLabelText = "LAST NAME";
            this.BlockedPeoplePageEmailLabelText = "EMAIL";
            this.BlockedPeoplePagePhoneLabelText = "PHONE NUMBER";
            this.BlockedPeoplePageBlockButtonText = "Block";
            this.BlockedPeoplePageUnblockButtonText = "Unblock";
            this.BlockedPeoplePageAddPersonCommandText = "Add Person";
            #endregion
        }
    }
    #endregion
}
