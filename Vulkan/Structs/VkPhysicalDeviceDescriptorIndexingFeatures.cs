using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDescriptorIndexingFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint ShaderInputAttachmentArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderUniformTexelBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageTexelBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public uint ShaderUniformBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderSampledImageArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageImageArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderInputAttachmentArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderUniformTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint ShaderStorageTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public uint DescriptorBindingUniformBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingSampledImageUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingStorageImageUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingStorageBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingUniformTexelBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingStorageTexelBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public uint DescriptorBindingUpdateUnusedWhilePending;

        [NativeTypeName("Bool32")] public uint DescriptorBindingPartiallyBound;

        [NativeTypeName("Bool32")] public uint DescriptorBindingVariableDescriptorCount;

        [NativeTypeName("Bool32")] public uint RuntimeDescriptorArray;
    }
}
