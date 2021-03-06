using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class Control_Presentation_TechConsole_Dashboard : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_Dashboard_Date { get { return "Date"; } }
        public string AWC_Dashboard_DeviceManagement { get { return "Device Management"; } }
        public string AWC_Dashboard_DeviceStore { get { return "Device Store"; } }
        public string AWC_Dashboard_GettingStarted { get { return "Getting Started"; } }
        public string AWC_Dashboard_Heading { get { return "Dashboard"; } }
        public string AWC_Dashboard_Highlights_ClickHere_ToolTip { get { return "Click here to retrieve latest data of highlights…"; } }
        public string AWC_Dashboard_Highlights_DevicesCreated { get { return "Devices Created"; } }
        public string AWC_Dashboard_Highlights_Heading { get { return "Highlights"; } }
        public string AWC_Dashboard_Highlights_PendingEnrollments { get { return "Pending Enrollments"; } }
        public string AWC_Dashboard_Highlights_ReportsforPast5days { get { return "Reports for Past 5 days"; } }
        public string AWC_Dashboard_Highlights_RetrieveMessage { get { return "Retrieving data..."; } }
        public string AWC_Dashboard_Highlights_SuccessfulEnrollments { get { return "Successful Enrollments"; } }
        public string AWC_Dashboard_Highlights_SuccessfulSessions { get { return "Successful Sessions"; } }
        public string AWC_Dashboard_KnowlegeBase { get { return "Knowledge Base"; } }
        public string AWC_Dashboard_MainPage_ConnectionErrorStatus { get { return "Connection Error Status:"; } }
        public string AWC_Dashboard_MainPage_ConnectionFailure { get { return "Connection Failure!"; } }
        public string AWC_Dashboard_MainPage_ConnectionMode { get { return "Connection Mode -"; } }
        public string AWC_Dashboard_MainPage_LoadingBrowser { get { return "Loading browser. Please wait..."; } }
        public string AWC_Dashboard_MainPage_ProxyAuthRequired { get { return "Proxy Auth Required!"; } }
        public string AWC_Dashboard_MainPage_UnableToContactServer { get { return "Unable to contact the server."; } }
        public string AWC_Dashboard_MainPage_UnknownConnection { get { return "Unknown Connection Error!"; } }
        public string AWC_Dashboard_Operations { get { return "Operations"; } }
        public string AWC_Dashboard_Reports { get { return "Reports"; } }
        public string AWC_Dashboard_Studio { get { return "Studio"; } }
        public string AWC_Dashboard_Time { get { return "Time"; } }
    }
}
