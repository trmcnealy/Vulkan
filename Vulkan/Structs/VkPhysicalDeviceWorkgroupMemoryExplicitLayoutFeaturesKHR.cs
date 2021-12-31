using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint WorkgroupMemoryExplicitLayout;

        [NativeTypeName("Bool32")] public uint WorkgroupMemoryExplicitLayoutScalarBlockLayout;

        [NativeTypeName("Bool32")] public uint WorkgroupMemoryExplicitLayout8BitAccess;

        [NativeTypeName("Bool32")] public uint WorkgroupMemoryExplicitLayout16BitAccess;
    }
}
