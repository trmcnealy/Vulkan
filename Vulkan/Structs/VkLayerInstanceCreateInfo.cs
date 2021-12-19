using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkLayerInstanceCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkLayerFunction")] public VkLayerFunction Function;

        [NativeTypeName("union (anonymous union at E:/Github/KhronosGroup/Vulkan-Headers/include/vulkan/vk_layer.h:125:5)")]
        public _u_e__Union U;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe struct _u_e__Union
        {
            [FieldOffset(0)] [NativeTypeName("VkLayerInstanceLink *")]
            public VkLayerInstanceLink* pLayerInfo;

            [FieldOffset(0)] [NativeTypeName("PFN_vkSetInstanceLoaderData")]
            public nint pfnSetInstanceLoaderData;

            [FieldOffset(0)] [NativeTypeName("struct (anonymous struct at E:/Github/KhronosGroup/Vulkan-Headers/include/vulkan/vk_layer.h:128:9)")]
            public _layerDevice_e__Struct layerDevice;

            [FieldOffset(0)] [NativeTypeName("VkLoaderFeatureFlags")]
            public uint loaderFeatures;

            public struct _layerDevice_e__Struct
            {
                [NativeTypeName("PFN_vkLayerCreateDevice")]
                public nint PfnLayerCreateDevice;

                [NativeTypeName("PFN_vkLayerDestroyDevice")]
                public nint PfnLayerDestroyDevice;
            }
        }
    }
}
