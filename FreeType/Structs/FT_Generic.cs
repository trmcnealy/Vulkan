using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_Generic
    {
        [NativeTypeName("void *")]
        public nint data;

        [NativeTypeName("FT_Generic_Finalizer")]
        public nint finalizer;
    }
}
