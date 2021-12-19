using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkLayerDeviceCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkLayerFunction")] public VkLayerFunction Function;

        [NativeTypeName("union (anonymous union at E:/Github/KhronosGroup/Vulkan-Headers/include/vulkan/vk_layer.h:146:5)")]
        public _u_e__Union U;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe struct _u_e__Union
        {
            [FieldOffset(0)] [NativeTypeName("VkLayerDeviceLink *")]
            public VkLayerDeviceLink* pLayerInfo;

            [FieldOffset(0)] [NativeTypeName("PFN_vkSetDeviceLoaderData")]
            public nint pfnSetDeviceLoaderData;
        }
    }
}
