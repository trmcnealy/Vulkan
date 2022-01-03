using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugReportCallbackCreateInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDebugReportFlagsEXT")]
        public uint Flags;

        [NativeTypeName("PFN_vkDebugReportCallbackEXT")]
        public nint PfnCallback;

        [NativeTypeName("void *")] public nint PUserData;
    }
}
