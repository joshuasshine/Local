using System;

namespace AetherPal.Control.Presentation.Localization
{
    public class Control_Presentation_TechConsole_DeviceLandingPage : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_DeviceLandingPage_NoArticlesFound { get { return "No Articles Found"; } }
        public string AWC_DeviceLandingPage_Link { get { return "Link"; } }
        public string AWC_DeviceLandingPage_SendEmail { get { return "Send Email"; } }
        public string AWC_DeviceLandingPage_NoTopIssuesFound { get { return "No Top Issues found!"; } }
        public string AWC_DeviceLandingPage_Days { get { return "days"; } }
        public string AWC_DeviceLandingPage_Day { get { return "day"; } }
        public string AWC_DeviceLandingPage_Hours { get { return "hrs"; } }
        public string AWC_DeviceLandingPage_Hour { get { return "hr"; } }
        public string AWC_DeviceLandingPage_Minutes { get { return "mins"; } }
        public string AWC_DeviceLandingPage_Minute { get { return "min"; } }
        public string AWC_DeviceLandingPage_Seconds { get { return "seconds"; } }
        public string AWC_DeviceLandingPage_IMEI { get { return "IMEI"; } }
    }
}
