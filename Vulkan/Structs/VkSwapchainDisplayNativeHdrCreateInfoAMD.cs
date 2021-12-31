using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSwapchainDisplayNativeHdrCreateInfoAMD
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint LocalDimmingEnable;
    }
}
