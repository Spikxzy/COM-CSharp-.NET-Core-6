using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace COM_with_events
{
    [Guid(AssemblyInfo.EventsGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    [ComVisible(true)]
    public interface COMEvents
    {
        void AdditionDone();
    }
}
