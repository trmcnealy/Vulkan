using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint VertexAttributeInstanceRateDivisor;

        [NativeTypeName("VkBool32")] public uint VertexAttributeInstanceRateZeroDivisor;
    }
}
