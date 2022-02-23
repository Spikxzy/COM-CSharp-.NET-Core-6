using System;
using System.Runtime.InteropServices;

namespace COMEarlyBinding
{
    [ComImport]
    [Guid(AssemblyInfo.InterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ICOMObject
    {
        double Addition(double firstValue, double secondValue);
        string HelloWorld();
    }
}
