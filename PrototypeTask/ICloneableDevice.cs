using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeTask
{
    public interface ICloneableDevice
    {
        ICloneableDevice Clone();
        void DisplayInfo();
    }
}
