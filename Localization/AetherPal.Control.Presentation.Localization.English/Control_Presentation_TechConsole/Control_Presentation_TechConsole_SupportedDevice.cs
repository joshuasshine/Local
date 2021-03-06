using AetherPal.Control.Presentation.Localization;
using System;

namespace AetherPal.Control.Presentation.Localization.English
{
    public class Control_Presentation_TechConsole_SupportedDevice : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_SupportedDevice_EndOfSupport { get { return "End of Support"; } }
        public string AWC_SupportedDevice_Height { get { return "Height(in pixels)"; } }
        public string AWC_SupportedDevice_KBLinks { get { return "KB Links"; } }
        public string AWC_SupportedDevice_LaunchDate { get { return "Launch Date"; } }
        public string AWC_SupportedDevice_ModelName { get { return "Model Name"; } }
        public string AWC_SupportedDevice_MRVersion { get { return "MR Version"; } }
        public string AWC_SupportedDevice_Width { get { return "Width(in pixels)"; } }
    }
}
