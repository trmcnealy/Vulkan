using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDepthStencilResolveProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedDepthResolveModes;

        [NativeTypeName("VkResolveModeFlags")] public uint SupportedStencilResolveModes;

        [NativeTypeName("Bool32")] public uint IndependentResolveNone;

        [NativeTypeName("Bool32")] public uint IndependentResolve;
    }
}
