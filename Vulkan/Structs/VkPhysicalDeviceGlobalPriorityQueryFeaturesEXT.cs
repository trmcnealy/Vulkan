using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceGlobalPriorityQueryFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint GlobalPriorityQuery;
    }
}
