using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSamplerCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkSamplerCreateFlags")]
        public uint Flags;

        public VkFilter MagFilter;

        public VkFilter MinFilter;

        public VkSamplerMipmapMode MipmapMode;

        public VkSamplerAddressMode AddressModeU;

        public VkSamplerAddressMode AddressModeV;

        public VkSamplerAddressMode AddressModeW;

        public float MipLodBias;

        [NativeTypeName("Bool32")] public uint AnisotropyEnable;

        public float MaxAnisotropy;

        [NativeTypeName("Bool32")] public uint CompareEnable;

        public VkCompareOp CompareOp;

        public float MinLod;

        public float MaxLod;

        public VkBorderColor BorderColor;

        [NativeTypeName("Bool32")] public uint UnnormalizedCoordinates;
    }
}
