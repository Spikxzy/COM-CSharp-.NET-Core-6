﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace COM_obj_with_events
{
    [ComImport]
    [Guid(AssemblyInfo.ResultInterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IResult
    {
        double ReturnResult();
    }
}
