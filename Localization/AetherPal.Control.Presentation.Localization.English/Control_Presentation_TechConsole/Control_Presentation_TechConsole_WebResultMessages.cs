using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    class Control_Presentation_TechConsole_WebResultMessages : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }

        public string AWC_WebResultMessage_17161 { get { return "You must change your password."; } }
        public string AWC_WebResultMessage_17163 { get { return "Password Expired, You must change your password."; } }
        public string AWC_WebResultMessage_1003 { get { return "Permission denied. Please contact your administrator."; } }

        public string AWC_Tool_ServerConnectivityLost { get { return "Connection with the server lost!"; } }
        public string AWC_Tool_URINotFound { get { return "Signal Message: No URI"; } }
        public string AWC_Tool_LinkActivationFailed { get { return "Link Activation Failed"; } }
        public string AWC_Tool_ClientStreamingLinkInterrupted { get { return "Streaming Link (D-B) between the Device and the Server has been Interrupted"; } }
        public string AWC_Tool_ControlStreamingLinkAuthFailed { get { return "Bearer Link Authentication Failed"; } }
        public string AWC_Tool_ToolServiceCreationFailed { get { return "Unable to Create Tool Service."; } }
        public string AWC_Tool_ClientStreamingLinkCreationFailed { get { return "Device was unable to establish Bearer Link"; } }
        public string AWC_Tool_ClientToolUnreachable { get { return "Destination Tool Unreachable"; } }
        public string AWC_Tool_ClientSignalLinkCreationFailed { get { return "Signal Link Connection to the Tool Service Failed"; } }
        public string AWC_Tool_InService { get { return "Tools in service"; } }

    }
}