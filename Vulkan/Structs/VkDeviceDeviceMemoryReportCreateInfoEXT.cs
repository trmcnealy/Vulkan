using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceDeviceMemoryReportCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDeviceMemoryReportFlagsEXT")]
        public uint Flags;

        [NativeTypeName("PFN_vkDeviceMemoryReportCallbackEXT")]
        public nint PfnUserCallback;

        [NativeTypeName("void *")] public nint PUserData;
    }
}
