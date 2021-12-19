using System.Runtime.InteropServices;

namespace FreeType
{
    public unsafe struct FT_Opaque_Paint
    {
        [NativeTypeName("FT_Byte *")]
        public byte* p;

        [NativeTypeName("FT_Bool")]
        public byte insert_root_transform;
    }
}
