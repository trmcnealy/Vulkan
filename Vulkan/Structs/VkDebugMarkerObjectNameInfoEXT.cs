using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugMarkerObjectNameInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkDebugReportObjectTypeEXT ObjectType;

        [NativeTypeName("uint64_t")] public ulong Object;

        [NativeTypeName("const char *")] 
        public utf8string PObjectName;
    }
}
