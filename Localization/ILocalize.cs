using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AetherPal.Control.Presentation.Localization
//namespace AetherPal.Control.Sys.Utils
{
    public interface ILocalize
    {
        Type Type { get; }
        ushort Identifier { get; }
    }
}
