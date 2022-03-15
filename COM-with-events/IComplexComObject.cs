namespace COM_with_events
{
    using System;
    using System.Runtime.InteropServices;

    [ComVisible(true)]
    [Guid(AssemblyInfo.AdditionDoneGuid)]
    public delegate void AdditionDoneDelegate();

    [ComImport]
    [Guid(AssemblyInfo.ComObjInterfaceGuid)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IComplexComObject
    {
        IResult Addition(double firstValue, double secondValue);
        string HelloWorld();

        event AdditionDoneDelegate AdditionDone;
    }
}
