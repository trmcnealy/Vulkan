using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkObjectType ObjectType;

        [NativeTypeName("uint64_t")] public ulong ObjectHandle;

        [NativeTypeName("const char *")] 
        public utf8string PObjectName;
    }
}
