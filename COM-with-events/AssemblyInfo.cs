using System;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: ComVisible(true)]
[assembly: Guid(COM_obj_with_events.AssemblyInfo.LibraryGuid)]

namespace COM_obj_with_events
{
    internal class AssemblyInfo
    {
		/// <summary> Id for the class of the COM object.</summary>
		internal const string ComObjClassGuid = "6CE0CB27-9189-4B2A-9F0A-04CEEBB5CC43";

		/// <summary> Id for the interface of the COM object.</summary>
		internal const string ComObjInterfaceGuid = "64D7BF36-CB33-4137-9EDA-23C0AC49FED7";

        internal const string ResultClassGuid = "4193FE51-B851-4267-A817-54725BA29954";

        internal const string ResultInterfaceGuid = "949298B1-947B-440C-AD01-75C7D0D10334";

        /// <summary> Id for the library.</summary>
        internal const string LibraryGuid = "8E069232-C779-4C11-9442-BBD988DA7900";
	}
}
