using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceSubgroupSizeControlFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint SubgroupSizeControl;

        [NativeTypeName("VkBool32")] public uint ComputeFullSubgroups;
    }
}
