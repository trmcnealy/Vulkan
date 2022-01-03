using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDebugMarkerMarkerInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("const char *")] 
        public utf8string PMarkerName;

        [NativeTypeName("float [4]")] public fixed float Color[4];
    }
}
