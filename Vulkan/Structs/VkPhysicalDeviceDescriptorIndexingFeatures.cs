using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint ShaderInputAttachmentArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderUniformTexelBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageTexelBufferArrayDynamicIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderUniformBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderSampledImageArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageImageArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderInputAttachmentArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderUniformTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint ShaderStorageTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingUniformBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingSampledImageUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingStorageImageUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingStorageBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingUniformTexelBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingStorageTexelBufferUpdateAfterBind;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingUpdateUnusedWhilePending;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingPartiallyBound;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingVariableDescriptorCount;

        [NativeTypeName("VkBool32")] public uint RuntimeDescriptorArray;
    }
}
