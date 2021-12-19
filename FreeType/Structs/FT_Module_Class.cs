using System.Runtime.InteropServices;
using Vulkan;

namespace FreeType
{
    public struct FT_Module_Class
    {
        [NativeTypeName("FT_ULong")]
        public uint module_flags;

        [NativeTypeName("FT_Long")]
        public int module_size;

        [NativeTypeName("const FT_String *")]
        public utf8string module_name;

        [NativeTypeName("FT_Fixed")]
        public int module_version;

        [NativeTypeName("FT_Fixed")]
        public int module_requires;

        [NativeTypeName("const void *")]
        public nint module_interface;

        [NativeTypeName("FT_Module_Constructor")]
        public nint module_init;

        [NativeTypeName("FT_Module_Destructor")]
        public nint module_done;

        [NativeTypeName("FT_Module_Requester")]
        public nint get_interface;
    }
}
