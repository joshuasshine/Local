using System;

namespace AetherPal.Control.Presentation.Localization
{
    public class Control_Presentation_TechConsole_DeviceDetails : ILocalize
    {
        public Type Type { get { return this.GetType(); } }
        public ushort Identifier { get { return 0x4201; } }
        public string AWC_DeviceDetails_Heading { get { return "Device Details"; } }
    }
}
