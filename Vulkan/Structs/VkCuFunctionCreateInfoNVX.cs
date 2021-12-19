using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkCuFunctionCreateInfoNVX
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkCuModuleNVX")] public VkCuModuleNVX Module;

        [NativeTypeName("const char *")] 
        public utf8string PName;
    }
}
