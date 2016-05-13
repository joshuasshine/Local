using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    class Control_Presentation_TechConsole_DeviceDepot : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_DeviceDepot_DeviceTechnicalDetails_TechnicalSpecification { get { return "Technical Specification"; } }
        public string AWC_DeviceDepot_DeviceTechnicalDetails_ScreenSize { get { return "Screen Size"; } }
        public string AWC_DeviceDepot_DeviceTechnicalDetails_SimType { get { return "SIM Type"; } }
        public string AWC_DeviceDepot_DeviceTechnicalDetails_SDCard { get { return "SD Card"; } }
        public string AWC_DeviceDepot_DeviceTechnicalDetails_NoDeviceSpecificationFound { get { return "No Device Specification Details found."; } }
       
        public string AWC_DeviceDepot_LandingPage_DeviceInformation { get { return "Device Information"; } }
        public string AWC_DeviceDepot_LandingPage_ArticlesList { get { return "Articles List"; } }

        public string AWC_DeviceDepot_RelatedArticleDialog_RelatedArticle { get { return "RELATED ARTICLES"; } }
                
        public string AWC_DeviceDepot_RemoteDevice_LoadingOS { get { return "Loading OS..."; } }
        public string AWC_DeviceDepot_RemoteDevice_Manufacturers { get { return "Manufacturers"; } }
        public string AWC_DeviceDepot_RemoteDevice_SelectOS { get { return "Select atleast one OS"; } }
        public string AWC_DeviceDepot_RemoteDevice_SelectManufacturer { get { return "Select atleast one Manufacturer"; } }
        public string AWC_DeviceDepot_RemoteDevice_Model { get { return "Model"; } }
        public string AWC_DeviceDepot_RemoteDevice_AvailableDevices { get { return "Available Devices"; } }
        public string AWC_DeviceDepot_RemoteDevice_NoDevicesFound { get { return "No Devices found."; } }
        public string AWC_DeviceDepot_RemoteDevice_InSessionDevices { get { return "In-Session Devices"; } }
        public string AWC_DeviceDepot_RemoteDevice_NoActiveSessions { get { return "No Active Sessions found."; } }
        public string AWC_DeviceDepot_RemoteDevice_SortBy { get { return "Sort by"; } }
        public string AWC_DeviceDepot_RemoteDevice_Manufacturer { get { return "Manufacturer"; } }
        public string AWC_DeviceDepot_RemoteDevice_AddDevice { get { return "Add Device"; } }
        public string AWC_DeviceDepot_RemoteDevice_Refresh { get { return "Refresh"; } }
        public string AWC_DeviceDepot_RemoteDevice_NoOSAvailable { get { return "No OS available"; } }
        public string AWC_DeviceDepot_RemoteDevice_LoginToConnectToDeviceStore { get { return "Please login to connect to Device Store"; } }
        public string AWC_DeviceDepot_RemoteDevice_PromptToDeleteDevice { get { return "Are you sure you want to delete \"{0}\" device?"; } }

        public string AWC_DeviceDepot_RemoteDeviceFeedback_FeedBack { get { return "FEEDBACK"; } }
        public string AWC_DeviceDepot_RemoteDeviceFeedback_Article { get { return "Article : "; } }

        public string AWC_DeviceDepot_RemoteDeviceLandingPage_HowToGuides { get { return "'How To' guides"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_SearchList { get { return "Search list below"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_NoInformation { get { return "No Information found."; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_LoginToRetrieveArticles { get { return "Please login to retrieve articles"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_LoginToRetrieveTechnicalSpecification { get { return "Please login to retrieve Technical Specification"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_LoginToConnectToDeviceStore { get { return "Please login to connect to Device Store"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_General { get { return "General"; } }
        public string AWC_DeviceDepot_RemoteDeviceLandingPage_PromptToClose { get { return "Do you want to close the tab?"; } }

        public string AWC_DeviceDepot_RenameDialogBox_RenameDevice { get { return "RENAME DEVICE"; } }
        public string AWC_DeviceDepot_RenameDialogBox_EnterNewDeviceName { get { return "Please enter new device name"; } }

        public string AWC_DeviceDepot_Player_Pause { get { return "Pause"; } }
        public string AWC_DeviceDepot_Player_Play { get { return "Play"; } }
        public string AWC_DeviceDepot_Player_ViewRelatedArticles { get { return "View Related Articles"; } }
        public string AWC_DeviceDepot_Player_ShowHardwareButtonTip { get { return "Show Hardware Button Tip"; } }
        public string AWC_DeviceDepot_Player_Steps { get { return "Steps"; } }
        public string AWC_DeviceDepot_Player_High { get { return "High [2s]"; } }
        public string AWC_DeviceDepot_Player_Medium { get { return "Medium [4s]"; } }
        public string AWC_DeviceDepot_Player_Low { get { return "Low [6s]"; } }
        public string AWC_DeviceDepot_Player_AnimationModeON { get { return "Animation Mode ON"; } }

        public string AWC_DeviceDepot_PlayerPopup_DockToTab { get { return "Dock to new tab"; } }

        public string AWC_DeviceDepot_Resources_RecommendedArticles { get { return "Recommended Articles ({0})"; } }
        public string AWC_DeviceDepot_Resources_NoArticlesFound { get { return "No Article(s) found."; } }
        public string AWC_DeviceDepot_Resources_Show { get { return "SHOW"; } }
        public string AWC_DeviceDepot_Resources_Hide { get { return "HIDE"; } }
        public string AWC_DeviceDepot_Resources_Start { get { return "Start"; } }

        public string AWC_DeviceDepot_RemoteDeviceControl_Launch { get { return "LAUNCH"; } }
        public string AWC_DeviceDepot_RemoteDeviceControl_InSession { get { return "IN-SESSION "; } } //Space left for proper indendation
        public string AWC_DeviceDepot_RemoteDeviceControl_Available { get { return "Available : "; } } //Space left for proper indendation

        public string AWC_DeviceDepot_RecentDevices_PreEnrolled { get { return "Pre Enrolled"; } }
    }
}
