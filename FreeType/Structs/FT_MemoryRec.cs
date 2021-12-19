using System.Runtime.InteropServices;

namespace FreeType
{
    public struct FT_MemoryRec
    {
        [NativeTypeName("void *")]
        public nint user;

        [NativeTypeName("FT_Alloc_Func")]
        public nint alloc;

        [NativeTypeName("FT_Free_Func")]
        public nint free;

        [NativeTypeName("FT_Realloc_Func")]
        public nint realloc;
    }
}
