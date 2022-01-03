using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevicePointClippingProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        public VkPointClippingBehavior PointClippingBehavior;
    }
}
