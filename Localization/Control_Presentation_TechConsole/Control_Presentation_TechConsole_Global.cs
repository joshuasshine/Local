using System;

namespace AetherPal.Control.Presentation.Localization
{
    public class Control_Presentation_TechConsole_Global : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_Global_Actions { get { return "Actions"; } }
        public string AWC_Global_AetherpalFooter { get { return "© 2009 - 2014 AetherPal Inc. All rights reserved."; } }
        public string AWC_Global_AliveDevices_Message { get { return "Device(s) might be alive. Please close the devices then try."; } }
        public string AWC_Global_Button_Abort { get { return "Abort"; } }
        public string AWC_Global_Button_AddFolder { get { return "Add Folder"; } }
        public string AWC_Global_Button_AdvancedSettings { get { return "Advanced Settings"; } }
        public string AWC_Global_Button_Back { get { return "Back"; } }
        public string AWC_Global_Button_Cancel { get { return "Cancel"; } }
        public string AWC_Global_Button_Clear { get { return "Clear"; } }
        public string AWC_Global_Button_Close { get { return "Close"; } }
        public string AWC_Global_Button_Copy { get { return "Copy"; } }
        public string AWC_Global_Button_CopyTo { get { return "CopyTo"; } }
        public string AWC_Global_Button_Delete { get { return "Delete"; } }
        public string AWC_Global_Button_GenerateReport { get { return "Generate Report"; } }
        public string AWC_Global_Button_Home { get { return "Home"; } }
        public string AWC_Global_Button_Ignore { get { return "Ignore"; } }
        public string AWC_Global_Button_Maximize_Tooltip { get { return "Maximize"; } }
        public string AWC_Global_Button_More_Tooltip { get { return "More"; } }
        public string AWC_Global_Button_Next { get { return "Next"; } }
        public string AWC_Global_Button_No { get { return "No"; } }
        public string AWC_Global_Button_Ok { get { return "OK"; } }
        public string AWC_Global_Button_Receive { get { return "Receive"; } }
        public string AWC_Global_Button_Rename { get { return "Rename"; } }
        public string AWC_Global_Button_Reset { get { return "Reset"; } }
        public string AWC_Global_Button_Restore_Tooltip { get { return "Restore"; } }
        public string AWC_Global_Button_Retry { get { return "Retry"; } }
        public string AWC_Global_Button_Save { get { return "Save"; } }
        public string AWC_Global_Button_SaveAll_Tooltip { get { return "Save All"; } }
        public string AWC_Global_Button_Search { get { return "Search"; } }
        public string AWC_Global_Button_Send { get { return "Send"; } }
        public string AWC_Global_Button_Submit { get { return "Submit"; } }
        public string AWC_Global_Button_TryAgain { get { return "Try Again"; } }
        public string AWC_Global_Button_TryFromDevice { get { return "Try From Device"; } }
        public string AWC_Global_Button_Up { get { return "Up"; } }
        public string AWC_Global_Button_View { get { return "View"; } }
        public string AWC_Global_Button_Yes { get { return "Yes"; } }
        public string AWC_Global_CannotAddFiveDevices { get { return "You can not add more than 5 devices in session"; } }
        public string AWC_Global_CapsLockOn { get { return "Caps Lock is on"; } }
        public string AWC_Global_CheckBoxByPassProxy { get { return "Bypass proxy server for local addresses"; } }
        public string AWC_Global_CheckBoxProxyAuthentication { get { return "Enable proxy authentication"; } }
        public string AWC_Global_Connecting { get { return "Connecting"; } }
        public string AWC_Global_Connecting_PleaseWait { get { return "Connecting. Please wait..."; } }
        public string AWC_Global_ConnectionTime { get { return "Connection Time"; } }
        public string AWC_Global_ContactServerFailure { get { return "Unable to contact the server."; } }
        public string AWC_Global_DeviceInfo_DeviceName { get { return "Device Name"; } }
        public string AWC_Global_DeviceInfo_OperatingSystem { get { return "Operating System"; } }
        public string AWC_Global_DeviceInfo_PhoneNumber { get { return "Phone Number"; } }
        public string AWC_Global_Devices { get { return "Devices"; } }
        public string AWC_Global_DevicesInSession { get { return "InSession"; } }
        public string AWC_Global_Disconnect_Alert { get { return "Are you sure you want to disconnect?"; } }
        public string AWC_Global_DisconnectSession { get { return "Device(s) might be in-session. Please disconnect the session(s)."; } }
        public string AWC_Global_EmptyAdminService { get { return "Admin service URI cannot be empty!"; } }
        public string AWC_Global_Error { get { return "Error"; } }
        public string AWC_Global_ErrorMessage_LogPath { get { return "An Error occured while opening Log Path"; } }
        public string AWC_Global_Existence_Message { get { return "Already in session!"; } }
        public string AWC_Global_Export_Failed { get { return "Export Failed!"; } }
        public string AWC_Global_FileManager_Address { get { return "Address"; } }
        public string AWC_Global_FileManager_Modified { get { return "Modified"; } }
        public string AWC_Global_FileManager_Size { get { return "Size"; } }
        public string AWC_Global_FileManager_Type { get { return "Type"; } }
        public string AWC_Global_GenericLoginFailed { get { return "Login failed. Please contact administrator."; } }
        public string AWC_Global_HeaderConnectionMode { get { return "Connection mode - {0}"; } }
        public string AWC_Global_HeaderDisplayCapture { get { return "Display Capture"; } }
        public string AWC_Global_Host { get { return "Host :"; } }
        public string AWC_Global_Loading { get { return "Loading. Please wait..."; } }
        public string AWC_Global_LoadingMessage_DeviceConnected { get { return "Device Connected. Waiting to Establish Streaming Link"; } }
        public string AWC_Global_LoadingMessage_EstablishingSL { get { return "Establishing Streaming Link to "; } }
        public string AWC_Global_LoginFailed { get { return "Login failed, Authentication failed {0} times"; } }
        public string AWC_Global_Logout { get { return "Logout"; } }
        public string AWC_Global_MenuItem_Diagnose { get { return "Diagnose"; } }
        public string AWC_Global_MultiLanguage { get { return "Multi language"; } }
        public string AWC_Global_Name { get { return "Name"; } }
        public string AWC_Global_NoRecords_Message { get { return "No records found"; } }
        public string AWC_Global_Options_About { get { return "About"; } }
        public string AWC_Global_Options_FullScreen { get { return "Full Screen"; } }
        public string AWC_Global_Options_Heading { get { return "Options"; } }
        public string AWC_Global_Options_Language { get { return "Language"; } }
        public string AWC_Global_Options_Logs { get { return "Logs"; } }
        public string AWC_Global_Password { get { return "Password"; } }
        public string AWC_Global_PasswordIsNull { get { return "Password cannot be empty"; } }
        public string AWC_Global_Port { get { return "Port :"; } }
        public string AWC_Global_PreEnrolledDevices { get { return "Pre-Enrolled"; } }
        public string AWC_Global_ProductName { get { return "AetherPal Web Console"; } }
        public string AWC_Global_ProgressInitializeConnectivity { get { return "Initializing Connectivity..."; } }
        public string AWC_Global_ProgressInitializingApplication { get { return "Initializing application..."; } }
        public string AWC_Global_ProgressLoadingAPN { get { return "Loading APN records..."; } }
        public string AWC_Global_ProgressLoadingConfiguration { get { return "Loading System Configurations..."; } }
        public string AWC_Global_ProgressLoadingMessage { get { return "Loading..."; } }
        public string AWC_Global_ProgressLoadingOperator { get { return "Loading operator list"; } }
        public string AWC_Global_ProgressLoadingRecent { get { return "Loading recent devices"; } }
        public string AWC_Global_ProgressLoadingTool { get { return "Loading tool configurations"; } }
        public string AWC_Global_ProgressLogging { get { return "Logging off"; } }
        public string AWC_Global_ProgressSearching { get { return "Searching for devices..."; } }
        public string AWC_Global_ProxySettings { get { return "Proxy Settings"; } }
        public string AWC_Global_ProxyType { get { return "Proxy type :"; } }
        public string AWC_Global_RadioAutoProxy { get { return "Auto detect proxy settings from IE"; } }
        public string AWC_Global_RadioCustomerInitiatedConnection { get { return "Customer initiated connection"; } }
        public string AWC_Global_RadioDonotUseProxy { get { return "Don't use proxy"; } }
        public string AWC_Global_RadioTechnicianInitiatedConnection { get { return "Technician initiated connection"; } }
        public string AWC_Global_RadioUseProxy { get { return "Use proxy settings"; } }
        public string AWC_Global_Refresh { get { return "Refresh"; } }
        public string AWC_Global_Reports_Administrator { get { return "Administrator"; } }
        public string AWC_Global_Reports_EndTime { get { return "End Time"; } }
        public string AWC_Global_Reports_InvalidDateSelection_Message { get { return "Invalid date selection. 'From date' should be lesser than 'To date'"; } }
        public string AWC_Global_Reports_InvalidDateSelection_Message_CurrentDate { get { return "Invalid date selection. 'From date' or 'To date' should not be exceed to current date."; } }
        public string AWC_Global_Reports_NoRecordsFound_Message { get { return "No records found between {0} and {1}"; } }
        public string AWC_Global_Reports_SessionStatus { get { return "Session Status"; } }
        public string AWC_Global_Reports_StartTime { get { return "Start Time"; } }
        public string AWC_Global_SearchApplicationList { get { return "Search from application list"; } }
        public string AWC_Global_SearchCriteria_From { get { return "From :"; } }
        public string AWC_Global_SearchCriteria_To { get { return "To :"; } }
        public string AWC_Global_SearchDevice_MessageRetrieveEnrolled { get { return "Click here to retrieve all enrolled devices."; } }
        public string AWC_Global_SearchDevice_MessageRetrievePreEnrolled { get { return "Click here to retrieve all pre-enrolled devices."; } }
        public string AWC_Global_SearchDevice_SearchCriteria { get { return "Search Criteria :"; } }
        public string AWC_Global_SearchDevice_SearchCriteria_Contains { get { return "Contains"; } }
        public string AWC_Global_SearchDevice_SearchCriteria_EndsWith { get { return "Endswith"; } }
        public string AWC_Global_SearchDevice_SearchCriteria_StartsWith { get { return "Startswith"; } }
        public string AWC_Global_SearchDevice_WaterMark_EnterDevice { get { return "Enter device name"; } }
        public string AWC_Global_SearchDevice_WaterMark_EnterPhone { get { return "Enter Phone Number"; } }
        public string AWC_Global_SearchListBelow { get { return "Search list below"; } }
        public string AWC_Global_ServerNotConfigured { get { return "AetherPal server not configured!"; } }
        public string AWC_Global_SessionDeviceExistence_Message { get { return "Device already in-session."; } }
        public string AWC_Global_Sno { get { return "SNO"; } }
        public string AWC_Global_Title { get { return "AetherPal for Smart phones powered by AetherPal Inc.,"; } }
        public string AWC_Global_UserAccountBlocked { get { return "Your user account has been blocked"; } }
        public string AWC_Global_UserAccountInSession { get { return "User account already in session, Please contact administrator."; } }
        public string AWC_Global_UserName { get { return "User Name"; } }
        public string AWC_Global_UserNameIsNull { get { return "Username cannot be empty"; } }
        public string AWC_Global_UserNamePasswordIncorrect { get { return "The username or password you entered is incorrect. "; } }
        public string AWC_Global_UserNamePasswordInvalid { get { return "Username/Password invalid."; } }
        public string AWC_Global_Validation_AutoDetectOS { get { return "Device OS can not be 'AutoDetect' for Re-Enrollment!"; } }
        public string AWC_Global_Validation_EmptyPassword { get { return "Password should not be empty"; } }
        public string AWC_Global_Validation_EmptyString { get { return "Value should not be empty."; } }
        public string AWC_Global_Validation_InvalidEmail { get { return "Invalid Email address."; } }
        public string AWC_Global_Validation_NumericValueOnly { get { return "Value should be Numeric only."; } }
        public string AWC_Global_Validation_PasswordMismatch { get { return "Password does not match"; } }
        public string AWC_Global_Waiting { get { return "Waiting for device connection"; } }
        public string AWC_Global_Welcome { get { return "Welcome"; } }
        public string AWC_Global_WelcomeText { get { return "{0} !"; } }
        public string AWC_Global_KnowledgeBase { get { return "KnowledgeBase"; } }
        public string AWC_Global_CommandNotAllowed { get { return "This command is not allowed in"; } }
        public string AWC_Global_SearchField { get { return "Search field : "; } }
        public string AWC_Global_SearchUsing { get { return "Search using..."; } }
        public string AWC_Global_Button_Go { get { return "Go"; } }
        public string AWC_Global_InvalidToken { get { return "Invalid user token."; } }
        public string AWC_Global_Status { get { return "Status"; } }

        public string AWC_Global_Paste { get { return "Paste"; } }
    }
}
