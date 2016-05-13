using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class Control_Presentation_TechConsole_DeviceDiagnostics : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }

        public string AWC_DeviceDiagnostics_Header { get { return "Device Diagnostics"; } }
        public string AWC_DeviceDiagnostics_SCUE_DownloadErrorMsg { get { return "Error while downloading SCUE resources..."; } }
        public string AWC_DeviceDiagnostics_WebServer_ErrorMsg { get { return "Error while initializing local web server..."; } }
        public string AWC_DeviceDiagnostics_SCUE_FilesMissing { get { return "SCUE files are missing..."; } }
        public string AWC_DeviceDiagnostics_Reports_UploadingMsg { get { return "Please wait while uploading report xml file..."; } }
        public string AWC_DeviceDiagnostics_Reports_NoRecordErrorMsg { get { return "No Reports record found in current session..."; } }
        public string AWC_DeviceDiagnostics_SCUE_FeatureNotAvailableMsg { get { return "This feature is currently not enabled"; } }
        

        public string AWC_DeviceTutorial_Header { get { return "Device Tutorial"; } }
    }
}
