using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AetherPal.Control.Presentation.Localization
{
    public interface ILocalize
    {
        Type Type { get; }
        ushort Identifier { get; }
    }
}
