using System;

namespace AetherPal.Control.Presentation.Localization
{
    public class Control_Presentation_TechConsole_DeviceManagement : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_DeviceManagement_DeviceWizard_DownloadedFailed { get { return "DOWNLOAD FAILED"; } }
        public string AWC_DeviceManagement_DeviceWizard_DownloadedSuccessfully { get { return "DOWNLOADED SUCCESSFULLY"; } }
        public string AWC_DeviceManagement_DeviceWizard_DownloadStateInactive { get { return "DOWNLOAD STATE - INACTIVE"; } }
        public string AWC_DeviceManagement_DeviceWizard_DownloadStateIndeterminate { get { return "DOWNLOAD STATE - INDETERMINATE"; } }
        public string AWC_DeviceManagement_DeviceWizard_MessageSendingFailed { get { return "MESSAGE SENDING FAILED"; } }
        public string AWC_DeviceManagement_DeviceWizard_MessageSendingInProgress { get { return "MESSAGE SENDING IN PROGRESS"; } }
        public string AWC_DeviceManagement_DeviceWizard_MessageSentSuccessfully { get { return "MESSAGE SENT SUCCESSFULLY"; } }
        public string AWC_DeviceManagement_DeviceWizard_MessageStateInactive { get { return "MESSAGE STATE - INACTIVE"; } }
        public string AWC_DeviceManagement_AddDevice_AdvancedOption { get { return "Advanced option"; } }
        public string AWC_DeviceManagement_AddDevice_AdvancedOption_Tooltip { get { return "View/Hide advanced option"; } }
        public string AWC_DeviceManagement_AddDevice_APN { get { return "APN :"; } }
        public string AWC_DeviceManagement_AddDevice_Country { get { return "Country :"; } }
        public string AWC_DeviceManagement_AddDevice_DeviceName { get { return "Device Name :"; } }
        public string AWC_DeviceManagement_AddDevice_ExistingClient { get { return "Re-Enroll Existing client"; } }
        public string AWC_DeviceManagement_AddDevice_Heading { get { return "Add Device"; } }
        public string AWC_DeviceManagement_AddDevice_MobileOperator { get { return "Mobile Operator :"; } }
        public string AWC_DeviceManagement_AddDevice_NewClient { get { return "New Client Download"; } }
        public string AWC_DeviceManagement_AddDevice_OperatingSystem { get { return "Operating System :"; } }
        public string AWC_DeviceManagement_AddDevice_PhoneandEmail { get { return "Phone/Email"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Action { get { return "Action"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Actor { get { return "Actor"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_ClientHistory { get { return "Client History"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_CSRID { get { return "CSR ID"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Data { get { return "Data"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Details { get { return "Details"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceDiagnose_Duration { get { return "Duration - "; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceDiagnose_Header { get { return "Device Diagnose"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceDiagnose_PlayMovie { get { return "Play Movie"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceID { get { return "Device ID"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceInformation_Manufacturer { get { return "Manufacturer"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceMake { get { return "Device Make"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_DeviceModel { get { return "Device Model"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Features { get { return "FEATURES"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Headings { get { return "Device landing page"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_LastConnectionSettings { get { return "Last Connection Settings"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_MDNDeviceName { get { return "MDN / Device Name"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_MDNHistory { get { return "MDN History"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_NoDeviceInfoFound { get { return "No Device Information found."; } }
        public string AWC_DeviceManagement_DeviceLandingPage_NoRemoteSessionHistory { get { return "No Remote Session History found."; } }
        public string AWC_DeviceManagement_DeviceLandingPage_NoSessionDetails { get { return "No Session Details found."; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Notes { get { return "Notes"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Proceed { get { return "Proceed"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_Resources { get { return "Resources"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SessionDetails { get { return "Session Details"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SessionDetailsAvailable { get { return "Session Details will be available in {0} hours"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SessionDetailsLoading { get { return "Session details loading in progress. Please wait..."; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SessionId { get { return "Session Id"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SessionLoading { get { return "RemoteControl Session loading in progress. Please wait…"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_SettingsIsDifferent { get { return "This settings is different than the default (Default Value : {0})"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_StartFromDevice { get { return "Start from Device"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_TetheredConnect { get { return "Send link for Tethered Connect"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_TimeStamp { get { return "Time Stamp"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_TimestampTakeover { get { return "Timestamp of start of takeover"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_TotalLengthTimeTakeover { get { return "Total length of time of takeover"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_VolumeOfDataReceived { get { return "Volume of data received"; } }
        public string AWC_DeviceManagement_DeviceLandingPage_VolumeOfDataTransmitted { get { return "Volume of data transmitted"; } }
        public string AWC_DeviceManagement_DeviceLog { get { return "Device Log"; } }
        public string AWC_DeviceManagement_DeviceWizard_DownloadStatus_TermsAndConditions { get { return "Terms and Conditions"; } }
        public string AWC_DeviceManagement_DeviceWizard_EnrollmentInformation { get { return "Enrollment Information"; } }
        public string AWC_DeviceManagement_DeviceWizard_EnrollmentInformation_ExpirationTime { get { return "Expiration Time"; } }
        public string AWC_DeviceManagement_DeviceWizard_EnrollmentInformation_MessageSent { get { return "Message Sent"; } }
        public string AWC_DeviceManagement_DeviceWizard_Resend { get { return "Resend Message"; } }
        public string AWC_DeviceManagement_DeviceWizard_UnPin { get { return "UNPIN"; } }
        public string AWC_DeviceManagement_Enroll_Connect { get { return "Connect"; } }
        public string AWC_DeviceManagement_Enroll_CreatedTime { get { return "Created Time"; } }
        public string AWC_DeviceManagement_Enroll_Download { get { return "ENROLLMENT AND DOWNLOAD"; } }
        public string AWC_DeviceManagement_Enroll_DownloadedTime { get { return "Downloaded Time"; } }
        public string AWC_DeviceManagement_Enroll_DownloadLink { get { return "Download Link"; } }
        public string AWC_DeviceManagement_Enroll_EnrolledTime { get { return "Enrolled Time"; } }
        public string AWC_DeviceManagement_Enroll_Hide { get { return "HIDE"; } }
        public string AWC_DeviceManagement_Enroll_Installation { get { return "INSTALLATION"; } }
        public string AWC_DeviceManagement_Enroll_Platform { get { return "Platform"; } }
        public string AWC_DeviceManagement_Enroll_ReadyToConnect { get { return "READY TO CONNECT"; } }
        public string AWC_DeviceManagement_Enroll_ResendMessage { get { return "RESEND MESSAGE"; } }
        public string AWC_DeviceManagement_Enroll_SendDownloadLink { get { return "Send download link"; } }
        public string AWC_DeviceManagement_Enroll_Show { get { return "SHOW"; } }
        public string AWC_DeviceManagement_Enroll_TermsAndConditions { get { return "Terms & Conditions"; } }
        public string AWC_DeviceManagement_Enroll_UnableToCreateDevice { get { return "Unable to create device, please retry again."; } }
        public string AWC_DeviceManagement_Enroll_UserAgent { get { return "User Agent  :"; } }
        public string AWC_DeviceManagement_Enrolled { get { return "Enrolled"; } }
        public string AWC_DeviceManagement_Heading { get { return "Device Management"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_ActiveConnection { get { return "Active Connection"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_CPU { get { return "CPU"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_CPU_Usage { get { return "Usage"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_Display { get { return "Display"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_MainMemory { get { return "Main memory"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_Radio { get { return "Radio"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_Radio_NetworkName { get { return "Network Name"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_Radio_NetworkType { get { return "Network Type"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_RAMUsage { get { return "RAM Usage"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_RAMUsage_Free { get { return "Free"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_RAMUsage_Total { get { return "Total"; } }
        public string AWC_DeviceManagement_NewDeviceInfo_RAMUsage_Used { get { return "Used"; } }
        public string AWC_DeviceManagement_RecentDevices_CONNECT { get { return "CONNECT"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_Created { get { return "Created"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_Delete_ConfirmMessage { get { return "Do you want to delete {0} device?"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_Email { get { return "Email"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_FailedConnection { get { return "Unable to connect to the device.Please try again"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_LastConnected { get { return "Last Connected"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_Rename_Heading { get { return "Rename Device"; } }
        public string AWC_DeviceManagement_RecentDevices_DeviceInfo_Rename_Message { get { return "Please enter new device name"; } }
        public string AWC_DeviceManagement_RecentDevices_Heading { get { return "Recent Devices"; } }
        public string AWC_DeviceManagement_RecentDevices_LAUNCH { get { return "Launch"; } }
        public string AWC_DeviceManagement_RecentDevices_ToolTip { get { return "Recently created/connected devices"; } }
        public string AWC_DeviceManagement_SearchDevice_DeviceCreationTime { get { return "Device Creation Time"; } }
        public string AWC_DeviceManagement_SearchDevice_Heading { get { return "Search Device"; } }
        public string AWC_DeviceManagement_SearchDevice_ToolTip { get { return "Search for existing Enrolled/Pre-Enrolled devices"; } }
        public string AWC_DeviceManagement_SoftwareUpdateService_Heading { get { return "Software update service"; } }        
        public string AWC_DeviceManagement_SupportedDevices { get { return "Supported Devices"; } }
        public string AWC_DeviceManagement_NoDeviceFound { get { return "No device found"; } }

        public string AWC_DeviceManagement_Enroll_DownloadFromStore { get { return "Please enter the Device ID shown on the device"; } }
        public string AWC_DeviceManagement_Enroll_DownloadFromStore_SearchFailed { get { return "Incorrect Device ID"; } }
    }
}
