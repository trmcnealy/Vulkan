using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedDepthResolveModes;

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedStencilResolveModes;

        [NativeTypeName("VkBool32")] public uint IndependentResolveNone;

        [NativeTypeName("VkBool32")] public uint IndependentResolve;
    }
}
