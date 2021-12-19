using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public unsafe struct FT_Open_Args
    {
        [NativeTypeName("FT_UInt")]
        public uint flags;

        [NativeTypeName("const FT_Byte *")]
        public byte* memory_base;

        [NativeTypeName("FT_Long")]
        public int memory_size;

        [NativeTypeName("FT_String *")]
        public utf8string pathname;

        [NativeTypeName("FT_Stream")]
        public FT_Stream stream;

        [NativeTypeName("FT_Module")]
        public FT_Module* driver;

        [NativeTypeName("FT_Int")]
        public int num_params;

        [NativeTypeName("FT_Parameter *")]
        public FT_Parameter* @params;
    }
}
