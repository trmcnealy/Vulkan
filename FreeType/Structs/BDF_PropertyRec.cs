using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public struct BDF_PropertyRec
    {
        [NativeTypeName("BDF_PropertyType")]
        public BDF_PropertyType type;

        [NativeTypeName("union (anonymous union at D:/AssemblyCache/FreeType/include/freetype/ftbdf.h:120:5)")]
        public _u_e__Union u;

        [StructLayout(LayoutKind.Explicit)]
        public struct _u_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("const char *")]
            public utf8string atom;

            [FieldOffset(0)]
            [NativeTypeName("FT_Int32")]
            public int integer;

            [FieldOffset(0)]
            [NativeTypeName("FT_UInt32")]
            public uint cardinal;
        }
    }
}
