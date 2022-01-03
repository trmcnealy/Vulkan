using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan12Features
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public Bool32 SamplerMirrorClampToEdge;

        [NativeTypeName("Bool32")] public Bool32 DrawIndirectCount;

        [NativeTypeName("Bool32")] public Bool32 StorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public Bool32 UniformAndStorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public Bool32 StoragePushConstant8;

        [NativeTypeName("Bool32")] public Bool32 ShaderBufferInt64Atomics;

        [NativeTypeName("Bool32")] public Bool32 ShaderSharedInt64Atomics;

        [NativeTypeName("Bool32")] public Bool32 ShaderFloat16;

        [NativeTypeName("Bool32")] public Bool32 ShaderInt8;

        [NativeTypeName("Bool32")] public Bool32 DescriptorIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderInputAttachmentArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderUniformTexelBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageTexelBufferArrayDynamicIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderUniformBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderSampledImageArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageImageArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderInputAttachmentArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderUniformTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 ShaderStorageTexelBufferArrayNonUniformIndexing;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingUniformBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingSampledImageUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingStorageImageUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingStorageBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingUniformTexelBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingStorageTexelBufferUpdateAfterBind;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingUpdateUnusedWhilePending;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingPartiallyBound;

        [NativeTypeName("Bool32")] public Bool32 DescriptorBindingVariableDescriptorCount;

        [NativeTypeName("Bool32")] public Bool32 RuntimeDescriptorArray;

        [NativeTypeName("Bool32")] public Bool32 SamplerFilterMinmax;

        [NativeTypeName("Bool32")] public Bool32 ScalarBlockLayout;

        [NativeTypeName("Bool32")] public Bool32 ImagelessFramebuffer;

        [NativeTypeName("Bool32")] public Bool32 UniformBufferStandardLayout;

        [NativeTypeName("Bool32")] public Bool32 ShaderSubgroupExtendedTypes;

        [NativeTypeName("Bool32")] public Bool32 SeparateDepthStencilLayouts;

        [NativeTypeName("Bool32")] public Bool32 HostQueryReset;

        [NativeTypeName("Bool32")] public Bool32 TimelineSemaphore;

        [NativeTypeName("Bool32")] public Bool32 BufferDeviceAddress;

        [NativeTypeName("Bool32")] public Bool32 BufferDeviceAddressCaptureReplay;

        [NativeTypeName("Bool32")] public Bool32 BufferDeviceAddressMultiDevice;

        [NativeTypeName("Bool32")] public Bool32 VulkanMemoryModel;

        [NativeTypeName("Bool32")] public Bool32 VulkanMemoryModelDeviceScope;

        [NativeTypeName("Bool32")] public Bool32 VulkanMemoryModelAvailabilityVisibilityChains;

        [NativeTypeName("Bool32")] public Bool32 ShaderOutputViewportIndex;

        [NativeTypeName("Bool32")] public Bool32 ShaderOutputLayer;

        [NativeTypeName("Bool32")] public Bool32 SubgroupBroadcastDynamicId;
    }
}
