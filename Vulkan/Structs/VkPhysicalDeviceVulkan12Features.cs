using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint SamplerMirrorClampToEdge;

        [NativeTypeName("Bool32")] public uint DrawIndirectCount;

        [NativeTypeName("Bool32")] public uint StorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public uint UniformAndStorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public uint StoragePushConstant8;

        [NativeTypeName("Bool32")] public uint ShaderBufferInt64Atomics;

        [NativeTypeName("Bool32")] public uint ShaderSharedInt64Atomics;

        [NativeTypeName("Bool32")] public uint ShaderFloat16;

        [NativeTypeName("Bool32")] public uint ShaderInt8;

        [NativeTypeName("Bool32")] public uint DescriptorIndexing;

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

        [NativeTypeName("Bool32")] public uint SamplerFilterMinmax;

        [NativeTypeName("Bool32")] public uint ScalarBlockLayout;

        [NativeTypeName("Bool32")] public uint ImagelessFramebuffer;

        [NativeTypeName("Bool32")] public uint UniformBufferStandardLayout;

        [NativeTypeName("Bool32")] public uint ShaderSubgroupExtendedTypes;

        [NativeTypeName("Bool32")] public uint SeparateDepthStencilLayouts;

        [NativeTypeName("Bool32")] public uint HostQueryReset;

        [NativeTypeName("Bool32")] public uint TimelineSemaphore;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddress;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddressCaptureReplay;

        [NativeTypeName("Bool32")] public uint BufferDeviceAddressMultiDevice;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModel;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModelDeviceScope;

        [NativeTypeName("Bool32")] public uint VulkanMemoryModelAvailabilityVisibilityChains;

        [NativeTypeName("Bool32")] public uint ShaderOutputViewportIndex;

        [NativeTypeName("Bool32")] public uint ShaderOutputLayer;

        [NativeTypeName("Bool32")] public uint SubgroupBroadcastDynamicId;
    }
}
