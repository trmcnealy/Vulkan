using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint WorkgroupMemoryExplicitLayout;

        [NativeTypeName("VkBool32")] public uint WorkgroupMemoryExplicitLayoutScalarBlockLayout;

        [NativeTypeName("VkBool32")] public uint WorkgroupMemoryExplicitLayout8BitAccess;

        [NativeTypeName("VkBool32")] public uint WorkgroupMemoryExplicitLayout16BitAccess;
    }
}
