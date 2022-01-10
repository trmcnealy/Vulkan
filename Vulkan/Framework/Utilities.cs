using System;

namespace Vulkan.Framework
{
  public static partial class Utilities
  {
    public static T PreMake<T>()
      where T : notnull
    {
      switch(typeof(T))
      {
        case var t when t == typeof(VkApplicationInfo): { PreMake(out VkApplicationInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceQueueCreateInfo): { PreMake(out VkDeviceQueueCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceCreateInfo): { PreMake(out VkDeviceCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkInstanceCreateInfo): { PreMake(out VkInstanceCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryAllocateInfo): { PreMake(out VkMemoryAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkMappedMemoryRange): { PreMake(out VkMappedMemoryRange obj); return (T)(object)obj; }
        case var t when t == typeof(VkWriteDescriptorSet): { PreMake(out VkWriteDescriptorSet obj); return (T)(object)obj; }
        case var t when t == typeof(VkCopyDescriptorSet): { PreMake(out VkCopyDescriptorSet obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferCreateInfo): { PreMake(out VkBufferCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferViewCreateInfo): { PreMake(out VkBufferViewCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryBarrier): { PreMake(out VkMemoryBarrier obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferMemoryBarrier): { PreMake(out VkBufferMemoryBarrier obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageMemoryBarrier): { PreMake(out VkImageMemoryBarrier obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageCreateInfo): { PreMake(out VkImageCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageViewCreateInfo): { PreMake(out VkImageViewCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindSparseInfo): { PreMake(out VkBindSparseInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkShaderModuleCreateInfo): { PreMake(out VkShaderModuleCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetLayoutCreateInfo): { PreMake(out VkDescriptorSetLayoutCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorPoolCreateInfo): { PreMake(out VkDescriptorPoolCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetAllocateInfo): { PreMake(out VkDescriptorSetAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineShaderStageCreateInfo): { PreMake(out VkPipelineShaderStageCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkComputePipelineCreateInfo): { PreMake(out VkComputePipelineCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineVertexInputStateCreateInfo): { PreMake(out VkPipelineVertexInputStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineInputAssemblyStateCreateInfo): { PreMake(out VkPipelineInputAssemblyStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineTessellationStateCreateInfo): { PreMake(out VkPipelineTessellationStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineViewportStateCreateInfo): { PreMake(out VkPipelineViewportStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineRasterizationStateCreateInfo): { PreMake(out VkPipelineRasterizationStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineMultisampleStateCreateInfo): { PreMake(out VkPipelineMultisampleStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineColorBlendStateCreateInfo): { PreMake(out VkPipelineColorBlendStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineDynamicStateCreateInfo): { PreMake(out VkPipelineDynamicStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineDepthStencilStateCreateInfo): { PreMake(out VkPipelineDepthStencilStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkGraphicsPipelineCreateInfo): { PreMake(out VkGraphicsPipelineCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineCacheCreateInfo): { PreMake(out VkPipelineCacheCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineLayoutCreateInfo): { PreMake(out VkPipelineLayoutCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSamplerCreateInfo): { PreMake(out VkSamplerCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkCommandPoolCreateInfo): { PreMake(out VkCommandPoolCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkCommandBufferAllocateInfo): { PreMake(out VkCommandBufferAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkCommandBufferInheritanceInfo): { PreMake(out VkCommandBufferInheritanceInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkCommandBufferBeginInfo): { PreMake(out VkCommandBufferBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassBeginInfo): { PreMake(out VkRenderPassBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassCreateInfo): { PreMake(out VkRenderPassCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkEventCreateInfo): { PreMake(out VkEventCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkFenceCreateInfo): { PreMake(out VkFenceCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSemaphoreCreateInfo): { PreMake(out VkSemaphoreCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkQueryPoolCreateInfo): { PreMake(out VkQueryPoolCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkFramebufferCreateInfo): { PreMake(out VkFramebufferCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubmitInfo): { PreMake(out VkSubmitInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceFeatures2): { PreMake(out VkPhysicalDeviceFeatures2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceProperties2): { PreMake(out VkPhysicalDeviceProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkFormatProperties2): { PreMake(out VkFormatProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageFormatProperties2): { PreMake(out VkImageFormatProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceImageFormatInfo2): { PreMake(out VkPhysicalDeviceImageFormatInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkQueueFamilyProperties2): { PreMake(out VkQueueFamilyProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceMemoryProperties2): { PreMake(out VkPhysicalDeviceMemoryProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkSparseImageFormatProperties2): { PreMake(out VkSparseImageFormatProperties2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceSparseImageFormatInfo2): { PreMake(out VkPhysicalDeviceSparseImageFormatInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceDriverProperties): { PreMake(out VkPhysicalDeviceDriverProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVariablePointersFeatures): { PreMake(out VkPhysicalDeviceVariablePointersFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceExternalImageFormatInfo): { PreMake(out VkPhysicalDeviceExternalImageFormatInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalImageFormatProperties): { PreMake(out VkExternalImageFormatProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceExternalBufferInfo): { PreMake(out VkPhysicalDeviceExternalBufferInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalBufferProperties): { PreMake(out VkExternalBufferProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceIDProperties): { PreMake(out VkPhysicalDeviceIDProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalMemoryImageCreateInfo): { PreMake(out VkExternalMemoryImageCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalMemoryBufferCreateInfo): { PreMake(out VkExternalMemoryBufferCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExportMemoryAllocateInfo): { PreMake(out VkExportMemoryAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceExternalSemaphoreInfo): { PreMake(out VkPhysicalDeviceExternalSemaphoreInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalSemaphoreProperties): { PreMake(out VkExternalSemaphoreProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkExportSemaphoreCreateInfo): { PreMake(out VkExportSemaphoreCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceExternalFenceInfo): { PreMake(out VkPhysicalDeviceExternalFenceInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkExternalFenceProperties): { PreMake(out VkExternalFenceProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkExportFenceCreateInfo): { PreMake(out VkExportFenceCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceMultiviewFeatures): { PreMake(out VkPhysicalDeviceMultiviewFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceMultiviewProperties): { PreMake(out VkPhysicalDeviceMultiviewProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassMultiviewCreateInfo): { PreMake(out VkRenderPassMultiviewCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceGroupProperties): { PreMake(out VkPhysicalDeviceGroupProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryAllocateFlagsInfo): { PreMake(out VkMemoryAllocateFlagsInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindBufferMemoryInfo): { PreMake(out VkBindBufferMemoryInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindBufferMemoryDeviceGroupInfo): { PreMake(out VkBindBufferMemoryDeviceGroupInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindImageMemoryInfo): { PreMake(out VkBindImageMemoryInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindImageMemoryDeviceGroupInfo): { PreMake(out VkBindImageMemoryDeviceGroupInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupRenderPassBeginInfo): { PreMake(out VkDeviceGroupRenderPassBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupCommandBufferBeginInfo): { PreMake(out VkDeviceGroupCommandBufferBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupSubmitInfo): { PreMake(out VkDeviceGroupSubmitInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupBindSparseInfo): { PreMake(out VkDeviceGroupBindSparseInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupDeviceCreateInfo): { PreMake(out VkDeviceGroupDeviceCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorUpdateTemplateCreateInfo): { PreMake(out VkDescriptorUpdateTemplateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassInputAttachmentAspectCreateInfo): { PreMake(out VkRenderPassInputAttachmentAspectCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDevice16BitStorageFeatures): { PreMake(out VkPhysicalDevice16BitStorageFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceSubgroupProperties): { PreMake(out VkPhysicalDeviceSubgroupProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures): { PreMake(out VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferMemoryRequirementsInfo2): { PreMake(out VkBufferMemoryRequirementsInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageMemoryRequirementsInfo2): { PreMake(out VkImageMemoryRequirementsInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageSparseMemoryRequirementsInfo2): { PreMake(out VkImageSparseMemoryRequirementsInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryRequirements2): { PreMake(out VkMemoryRequirements2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkSparseImageMemoryRequirements2): { PreMake(out VkSparseImageMemoryRequirements2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDevicePointClippingProperties): { PreMake(out VkPhysicalDevicePointClippingProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryDedicatedRequirements): { PreMake(out VkMemoryDedicatedRequirements obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryDedicatedAllocateInfo): { PreMake(out VkMemoryDedicatedAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageViewUsageCreateInfo): { PreMake(out VkImageViewUsageCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPipelineTessellationDomainOriginStateCreateInfo): { PreMake(out VkPipelineTessellationDomainOriginStateCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSamplerYcbcrConversionInfo): { PreMake(out VkSamplerYcbcrConversionInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSamplerYcbcrConversionCreateInfo): { PreMake(out VkSamplerYcbcrConversionCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindImagePlaneMemoryInfo): { PreMake(out VkBindImagePlaneMemoryInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkImagePlaneMemoryRequirementsInfo): { PreMake(out VkImagePlaneMemoryRequirementsInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceSamplerYcbcrConversionFeatures): { PreMake(out VkPhysicalDeviceSamplerYcbcrConversionFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkSamplerYcbcrConversionImageFormatProperties): { PreMake(out VkSamplerYcbcrConversionImageFormatProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkProtectedSubmitInfo): { PreMake(out VkProtectedSubmitInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceProtectedMemoryFeatures): { PreMake(out VkPhysicalDeviceProtectedMemoryFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceProtectedMemoryProperties): { PreMake(out VkPhysicalDeviceProtectedMemoryProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceQueueInfo2): { PreMake(out VkDeviceQueueInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceSamplerFilterMinmaxProperties): { PreMake(out VkPhysicalDeviceSamplerFilterMinmaxProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkSamplerReductionModeCreateInfo): { PreMake(out VkSamplerReductionModeCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageFormatListCreateInfo): { PreMake(out VkImageFormatListCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceMaintenance3Properties): { PreMake(out VkPhysicalDeviceMaintenance3Properties obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetLayoutSupport): { PreMake(out VkDescriptorSetLayoutSupport obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceShaderDrawParametersFeatures): { PreMake(out VkPhysicalDeviceShaderDrawParametersFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceShaderFloat16Int8Features): { PreMake(out VkPhysicalDeviceShaderFloat16Int8Features obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceFloatControlsProperties): { PreMake(out VkPhysicalDeviceFloatControlsProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceHostQueryResetFeatures): { PreMake(out VkPhysicalDeviceHostQueryResetFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceDescriptorIndexingFeatures): { PreMake(out VkPhysicalDeviceDescriptorIndexingFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceDescriptorIndexingProperties): { PreMake(out VkPhysicalDeviceDescriptorIndexingProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetLayoutBindingFlagsCreateInfo): { PreMake(out VkDescriptorSetLayoutBindingFlagsCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetVariableDescriptorCountAllocateInfo): { PreMake(out VkDescriptorSetVariableDescriptorCountAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDescriptorSetVariableDescriptorCountLayoutSupport): { PreMake(out VkDescriptorSetVariableDescriptorCountLayoutSupport obj); return (T)(object)obj; }
        case var t when t == typeof(VkAttachmentDescription2): { PreMake(out VkAttachmentDescription2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkAttachmentReference2): { PreMake(out VkAttachmentReference2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubpassDescription2): { PreMake(out VkSubpassDescription2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubpassDependency2): { PreMake(out VkSubpassDependency2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassCreateInfo2): { PreMake(out VkRenderPassCreateInfo2 obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubpassBeginInfo): { PreMake(out VkSubpassBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubpassEndInfo): { PreMake(out VkSubpassEndInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceTimelineSemaphoreFeatures): { PreMake(out VkPhysicalDeviceTimelineSemaphoreFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceTimelineSemaphoreProperties): { PreMake(out VkPhysicalDeviceTimelineSemaphoreProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkSemaphoreTypeCreateInfo): { PreMake(out VkSemaphoreTypeCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkTimelineSemaphoreSubmitInfo): { PreMake(out VkTimelineSemaphoreSubmitInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSemaphoreWaitInfo): { PreMake(out VkSemaphoreWaitInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkSemaphoreSignalInfo): { PreMake(out VkSemaphoreSignalInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDevice8BitStorageFeatures): { PreMake(out VkPhysicalDevice8BitStorageFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVulkanMemoryModelFeatures): { PreMake(out VkPhysicalDeviceVulkanMemoryModelFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceShaderAtomicInt64Features): { PreMake(out VkPhysicalDeviceShaderAtomicInt64Features obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceDepthStencilResolveProperties): { PreMake(out VkPhysicalDeviceDepthStencilResolveProperties obj); return (T)(object)obj; }
        case var t when t == typeof(VkSubpassDescriptionDepthStencilResolve): { PreMake(out VkSubpassDescriptionDepthStencilResolve obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageStencilUsageCreateInfo): { PreMake(out VkImageStencilUsageCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceScalarBlockLayoutFeatures): { PreMake(out VkPhysicalDeviceScalarBlockLayoutFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceUniformBufferStandardLayoutFeatures): { PreMake(out VkPhysicalDeviceUniformBufferStandardLayoutFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceBufferDeviceAddressFeatures): { PreMake(out VkPhysicalDeviceBufferDeviceAddressFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferDeviceAddressInfo): { PreMake(out VkBufferDeviceAddressInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkBufferOpaqueCaptureAddressCreateInfo): { PreMake(out VkBufferOpaqueCaptureAddressCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceImagelessFramebufferFeatures): { PreMake(out VkPhysicalDeviceImagelessFramebufferFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkFramebufferAttachmentsCreateInfo): { PreMake(out VkFramebufferAttachmentsCreateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkFramebufferAttachmentImageInfo): { PreMake(out VkFramebufferAttachmentImageInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkRenderPassAttachmentBeginInfo): { PreMake(out VkRenderPassAttachmentBeginInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures): { PreMake(out VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures obj); return (T)(object)obj; }
        case var t when t == typeof(VkAttachmentReferenceStencilLayout): { PreMake(out VkAttachmentReferenceStencilLayout obj); return (T)(object)obj; }
        case var t when t == typeof(VkAttachmentDescriptionStencilLayout): { PreMake(out VkAttachmentDescriptionStencilLayout obj); return (T)(object)obj; }
        case var t when t == typeof(VkMemoryOpaqueCaptureAddressAllocateInfo): { PreMake(out VkMemoryOpaqueCaptureAddressAllocateInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceMemoryOpaqueCaptureAddressInfo): { PreMake(out VkDeviceMemoryOpaqueCaptureAddressInfo obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVulkan11Features): { PreMake(out VkPhysicalDeviceVulkan11Features obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVulkan11Properties): { PreMake(out VkPhysicalDeviceVulkan11Properties obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVulkan12Features): { PreMake(out VkPhysicalDeviceVulkan12Features obj); return (T)(object)obj; }
        case var t when t == typeof(VkPhysicalDeviceVulkan12Properties): { PreMake(out VkPhysicalDeviceVulkan12Properties obj); return (T)(object)obj; }
        case var t when t == typeof(VkSwapchainCreateInfoKHR): { PreMake(out VkSwapchainCreateInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkPresentInfoKHR): { PreMake(out VkPresentInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkImageSwapchainCreateInfoKHR): { PreMake(out VkImageSwapchainCreateInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkBindImageMemorySwapchainInfoKHR): { PreMake(out VkBindImageMemorySwapchainInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkAcquireNextImageInfoKHR): { PreMake(out VkAcquireNextImageInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupPresentCapabilitiesKHR): { PreMake(out VkDeviceGroupPresentCapabilitiesKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupPresentInfoKHR): { PreMake(out VkDeviceGroupPresentInfoKHR obj); return (T)(object)obj; }
        case var t when t == typeof(VkDeviceGroupSwapchainCreateInfoKHR): { PreMake(out VkDeviceGroupSwapchainCreateInfoKHR obj); return (T)(object)obj; }
        case var _:
        {
          throw new NotSupportedException();
        }
      }
    }

    public static void PreMake(out VkApplicationInfo obj)
    {
      obj       = new VkApplicationInfo();
      obj.SType = VkStructureType.ApplicationInfo;
    }

    public static void PreMake(out VkDeviceQueueCreateInfo obj)
    {
      obj       = new VkDeviceQueueCreateInfo();
      obj.SType = VkStructureType.DeviceQueueCreateInfo;
    }

    public static void PreMake(out VkDeviceCreateInfo obj)
    {
      obj       = new VkDeviceCreateInfo();
      obj.SType = VkStructureType.DeviceCreateInfo;
    }

    public static void PreMake(out VkInstanceCreateInfo obj)
    {
      obj       = new VkInstanceCreateInfo();
      obj.SType = VkStructureType.InstanceCreateInfo;
    }

    public static void PreMake(out VkMemoryAllocateInfo obj)
    {
      obj       = new VkMemoryAllocateInfo();
      obj.SType = VkStructureType.MemoryAllocateInfo;
    }

    public static void PreMake(out VkMappedMemoryRange obj)
    {
      obj       = new VkMappedMemoryRange();
      obj.SType = VkStructureType.MappedMemoryRange;
    }

    public static void PreMake(out VkWriteDescriptorSet obj)
    {
      obj       = new VkWriteDescriptorSet();
      obj.SType = VkStructureType.WriteDescriptorSet;
    }

    public static void PreMake(out VkCopyDescriptorSet obj)
    {
      obj       = new VkCopyDescriptorSet();
      obj.SType = VkStructureType.CopyDescriptorSet;
    }

    public static void PreMake(out VkBufferCreateInfo obj)
    {
      obj       = new VkBufferCreateInfo();
      obj.SType = VkStructureType.BufferCreateInfo;
    }

    public static void PreMake(out VkBufferViewCreateInfo obj)
    {
      obj       = new VkBufferViewCreateInfo();
      obj.SType = VkStructureType.BufferViewCreateInfo;
    }

    public static void PreMake(out VkMemoryBarrier obj)
    {
      obj       = new VkMemoryBarrier();
      obj.SType = VkStructureType.MemoryBarrier;
    }

    public static void PreMake(out VkBufferMemoryBarrier obj)
    {
      obj       = new VkBufferMemoryBarrier();
      obj.SType = VkStructureType.BufferMemoryBarrier;
    }

    public static void PreMake(out VkImageMemoryBarrier obj)
    {
      obj       = new VkImageMemoryBarrier();
      obj.SType = VkStructureType.ImageMemoryBarrier;
    }

    public static void PreMake(out VkImageCreateInfo obj)
    {
      obj       = new VkImageCreateInfo();
      obj.SType = VkStructureType.ImageCreateInfo;
    }

    public static void PreMake(out VkImageViewCreateInfo obj)
    {
      obj       = new VkImageViewCreateInfo();
      obj.SType = VkStructureType.ImageViewCreateInfo;
    }

    public static void PreMake(out VkBindSparseInfo obj)
    {
      obj       = new VkBindSparseInfo();
      obj.SType = VkStructureType.BindSparseInfo;
    }

    public static void PreMake(out VkShaderModuleCreateInfo obj)
    {
      obj       = new VkShaderModuleCreateInfo();
      obj.SType = VkStructureType.ShaderModuleCreateInfo;
    }

    public static void PreMake(out VkDescriptorSetLayoutCreateInfo obj)
    {
      obj       = new VkDescriptorSetLayoutCreateInfo();
      obj.SType = VkStructureType.DescriptorSetLayoutCreateInfo;
    }

    public static void PreMake(out VkDescriptorPoolCreateInfo obj)
    {
      obj       = new VkDescriptorPoolCreateInfo();
      obj.SType = VkStructureType.DescriptorPoolCreateInfo;
    }

    public static void PreMake(out VkDescriptorSetAllocateInfo obj)
    {
      obj       = new VkDescriptorSetAllocateInfo();
      obj.SType = VkStructureType.DescriptorSetAllocateInfo;
    }

    public static void PreMake(out VkPipelineShaderStageCreateInfo obj)
    {
      obj       = new VkPipelineShaderStageCreateInfo();
      obj.SType = VkStructureType.PipelineShaderStageCreateInfo;
    }

    public static void PreMake(out VkComputePipelineCreateInfo obj)
    {
      obj             = new VkComputePipelineCreateInfo();
      obj.SType       = VkStructureType.ComputePipelineCreateInfo;
      obj.Stage       = new VkPipelineShaderStageCreateInfo();
      obj.Stage.SType = VkStructureType.PipelineShaderStageCreateInfo;
    }

    public static void PreMake(out VkPipelineVertexInputStateCreateInfo obj)
    {
      obj       = new VkPipelineVertexInputStateCreateInfo();
      obj.SType = VkStructureType.PipelineVertexInputStateCreateInfo;
    }

    public static void PreMake(out VkPipelineInputAssemblyStateCreateInfo obj)
    {
      obj       = new VkPipelineInputAssemblyStateCreateInfo();
      obj.SType = VkStructureType.PipelineInputAssemblyStateCreateInfo;
    }

    public static void PreMake(out VkPipelineTessellationStateCreateInfo obj)
    {
      obj       = new VkPipelineTessellationStateCreateInfo();
      obj.SType = VkStructureType.PipelineTessellationStateCreateInfo;
    }

    public static void PreMake(out VkPipelineViewportStateCreateInfo obj)
    {
      obj       = new VkPipelineViewportStateCreateInfo();
      obj.SType = VkStructureType.PipelineViewportStateCreateInfo;
    }

    public static void PreMake(out VkPipelineRasterizationStateCreateInfo obj)
    {
      obj       = new VkPipelineRasterizationStateCreateInfo();
      obj.SType = VkStructureType.PipelineRasterizationStateCreateInfo;
    }

    public static void PreMake(out VkPipelineMultisampleStateCreateInfo obj)
    {
      obj       = new VkPipelineMultisampleStateCreateInfo();
      obj.SType = VkStructureType.PipelineMultisampleStateCreateInfo;
    }

    public static void PreMake(out VkPipelineColorBlendStateCreateInfo obj)
    {
      obj       = new VkPipelineColorBlendStateCreateInfo();
      obj.SType = VkStructureType.PipelineColorBlendStateCreateInfo;
    }

    public static void PreMake(out VkPipelineDynamicStateCreateInfo obj)
    {
      obj       = new VkPipelineDynamicStateCreateInfo();
      obj.SType = VkStructureType.PipelineDynamicStateCreateInfo;
    }

    public static void PreMake(out VkPipelineDepthStencilStateCreateInfo obj)
    {
      obj       = new VkPipelineDepthStencilStateCreateInfo();
      obj.SType = VkStructureType.PipelineDepthStencilStateCreateInfo;
    }

    public static void PreMake(out VkGraphicsPipelineCreateInfo obj)
    {
      obj       = new VkGraphicsPipelineCreateInfo();
      obj.SType = VkStructureType.GraphicsPipelineCreateInfo;
    }

    public static void PreMake(out VkPipelineCacheCreateInfo obj)
    {
      obj       = new VkPipelineCacheCreateInfo();
      obj.SType = VkStructureType.PipelineCacheCreateInfo;
    }

    public static void PreMake(out VkPipelineLayoutCreateInfo obj)
    {
      obj       = new VkPipelineLayoutCreateInfo();
      obj.SType = VkStructureType.PipelineLayoutCreateInfo;
    }

    public static void PreMake(out VkSamplerCreateInfo obj)
    {
      obj       = new VkSamplerCreateInfo();
      obj.SType = VkStructureType.SamplerCreateInfo;
    }

    public static void PreMake(out VkCommandPoolCreateInfo obj)
    {
      obj       = new VkCommandPoolCreateInfo();
      obj.SType = VkStructureType.CommandPoolCreateInfo;
    }

    public static void PreMake(out VkCommandBufferAllocateInfo obj)
    {
      obj       = new VkCommandBufferAllocateInfo();
      obj.SType = VkStructureType.CommandBufferAllocateInfo;
    }

    public static void PreMake(out VkCommandBufferInheritanceInfo obj)
    {
      obj       = new VkCommandBufferInheritanceInfo();
      obj.SType = VkStructureType.CommandBufferInheritanceInfo;
    }

    public static void PreMake(out VkCommandBufferBeginInfo obj)
    {
      obj       = new VkCommandBufferBeginInfo();
      obj.SType = VkStructureType.CommandBufferBeginInfo;
    }

    public static void PreMake(out VkRenderPassBeginInfo obj)
    {
      obj       = new VkRenderPassBeginInfo();
      obj.SType = VkStructureType.RenderPassBeginInfo;
    }

    public static void PreMake(out VkRenderPassCreateInfo obj)
    {
      obj       = new VkRenderPassCreateInfo();
      obj.SType = VkStructureType.RenderPassCreateInfo;
    }

    public static void PreMake(out VkEventCreateInfo obj)
    {
      obj       = new VkEventCreateInfo();
      obj.SType = VkStructureType.EventCreateInfo;
    }

    public static void PreMake(out VkFenceCreateInfo obj)
    {
      obj       = new VkFenceCreateInfo();
      obj.SType = VkStructureType.FenceCreateInfo;
    }

    public static void PreMake(out VkSemaphoreCreateInfo obj)
    {
      obj       = new VkSemaphoreCreateInfo();
      obj.SType = VkStructureType.SemaphoreCreateInfo;
    }

    public static void PreMake(out VkQueryPoolCreateInfo obj)
    {
      obj       = new VkQueryPoolCreateInfo();
      obj.SType = VkStructureType.QueryPoolCreateInfo;
    }

    public static void PreMake(out VkFramebufferCreateInfo obj)
    {
      obj       = new VkFramebufferCreateInfo();
      obj.SType = VkStructureType.FramebufferCreateInfo;
    }

    public static void PreMake(out VkSubmitInfo obj)
    {
      obj       = new VkSubmitInfo();
      obj.SType = VkStructureType.SubmitInfo;
    }

    public static void PreMake(out VkPhysicalDeviceFeatures2 obj)
    {
      obj       = new VkPhysicalDeviceFeatures2();
      obj.SType = VkStructureType.PhysicalDeviceFeatures2;
    }

    public static void PreMake(out VkPhysicalDeviceProperties2 obj)
    {
      obj       = new VkPhysicalDeviceProperties2();
      obj.SType = VkStructureType.PhysicalDeviceProperties2;
    }

    public static void PreMake(out VkFormatProperties2 obj)
    {
      obj       = new VkFormatProperties2();
      obj.SType = VkStructureType.FormatProperties2;
    }

    public static void PreMake(out VkImageFormatProperties2 obj)
    {
      obj       = new VkImageFormatProperties2();
      obj.SType = VkStructureType.ImageFormatProperties2;
    }

    public static void PreMake(out VkPhysicalDeviceImageFormatInfo2 obj)
    {
      obj       = new VkPhysicalDeviceImageFormatInfo2();
      obj.SType = VkStructureType.PhysicalDeviceImageFormatInfo2;
    }

    public static void PreMake(out VkQueueFamilyProperties2 obj)
    {
      obj       = new VkQueueFamilyProperties2();
      obj.SType = VkStructureType.QueueFamilyProperties2;
    }

    public static void PreMake(out VkPhysicalDeviceMemoryProperties2 obj)
    {
      obj       = new VkPhysicalDeviceMemoryProperties2();
      obj.SType = VkStructureType.PhysicalDeviceMemoryProperties2;
    }

    public static void PreMake(out VkSparseImageFormatProperties2 obj)
    {
      obj       = new VkSparseImageFormatProperties2();
      obj.SType = VkStructureType.SparseImageFormatProperties2;
    }

    public static void PreMake(out VkPhysicalDeviceSparseImageFormatInfo2 obj)
    {
      obj       = new VkPhysicalDeviceSparseImageFormatInfo2();
      obj.SType = VkStructureType.PhysicalDeviceSparseImageFormatInfo2;
    }

    public static void PreMake(out VkPhysicalDeviceDriverProperties obj)
    {
      obj       = new VkPhysicalDeviceDriverProperties();
      obj.SType = VkStructureType.PhysicalDeviceDriverProperties;
    }

    public static void PreMake(out VkPhysicalDeviceVariablePointersFeatures obj)
    {
      obj       = new VkPhysicalDeviceVariablePointersFeatures();
      obj.SType = VkStructureType.PhysicalDeviceVariablePointersFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceExternalImageFormatInfo obj)
    {
      obj       = new VkPhysicalDeviceExternalImageFormatInfo();
      obj.SType = VkStructureType.PhysicalDeviceExternalImageFormatInfo;
    }

    public static void PreMake(out VkExternalImageFormatProperties obj)
    {
      obj       = new VkExternalImageFormatProperties();
      obj.SType = VkStructureType.ExternalImageFormatProperties;
    }

    public static void PreMake(out VkPhysicalDeviceExternalBufferInfo obj)
    {
      obj       = new VkPhysicalDeviceExternalBufferInfo();
      obj.SType = VkStructureType.PhysicalDeviceExternalBufferInfo;
    }

    public static void PreMake(out VkExternalBufferProperties obj)
    {
      obj       = new VkExternalBufferProperties();
      obj.SType = VkStructureType.ExternalBufferProperties;
    }

    public static void PreMake(out VkPhysicalDeviceIDProperties obj)
    {
      obj       = new VkPhysicalDeviceIDProperties();
      obj.SType = VkStructureType.PhysicalDeviceIdProperties;
    }

    public static void PreMake(out VkExternalMemoryImageCreateInfo obj)
    {
      obj       = new VkExternalMemoryImageCreateInfo();
      obj.SType = VkStructureType.ExternalMemoryImageCreateInfo;
    }

    public static void PreMake(out VkExternalMemoryBufferCreateInfo obj)
    {
      obj       = new VkExternalMemoryBufferCreateInfo();
      obj.SType = VkStructureType.ExternalMemoryBufferCreateInfo;
    }

    public static void PreMake(out VkExportMemoryAllocateInfo obj)
    {
      obj       = new VkExportMemoryAllocateInfo();
      obj.SType = VkStructureType.ExportMemoryAllocateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceExternalSemaphoreInfo obj)
    {
      obj       = new VkPhysicalDeviceExternalSemaphoreInfo();
      obj.SType = VkStructureType.PhysicalDeviceExternalSemaphoreInfo;
    }

    public static void PreMake(out VkExternalSemaphoreProperties obj)
    {
      obj       = new VkExternalSemaphoreProperties();
      obj.SType = VkStructureType.ExternalSemaphoreProperties;
    }

    public static void PreMake(out VkExportSemaphoreCreateInfo obj)
    {
      obj       = new VkExportSemaphoreCreateInfo();
      obj.SType = VkStructureType.ExportSemaphoreCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceExternalFenceInfo obj)
    {
      obj       = new VkPhysicalDeviceExternalFenceInfo();
      obj.SType = VkStructureType.PhysicalDeviceExternalFenceInfo;
    }

    public static void PreMake(out VkExternalFenceProperties obj)
    {
      obj       = new VkExternalFenceProperties();
      obj.SType = VkStructureType.ExternalFenceProperties;
    }

    public static void PreMake(out VkExportFenceCreateInfo obj)
    {
      obj       = new VkExportFenceCreateInfo();
      obj.SType = VkStructureType.ExportFenceCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceMultiviewFeatures obj)
    {
      obj       = new VkPhysicalDeviceMultiviewFeatures();
      obj.SType = VkStructureType.PhysicalDeviceMultiviewFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceMultiviewProperties obj)
    {
      obj       = new VkPhysicalDeviceMultiviewProperties();
      obj.SType = VkStructureType.PhysicalDeviceMultiviewProperties;
    }

    public static void PreMake(out VkRenderPassMultiviewCreateInfo obj)
    {
      obj       = new VkRenderPassMultiviewCreateInfo();
      obj.SType = VkStructureType.RenderPassMultiviewCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceGroupProperties obj)
    {
      obj       = new VkPhysicalDeviceGroupProperties();
      obj.SType = VkStructureType.PhysicalDeviceGroupProperties;
    }

    public static void PreMake(out VkMemoryAllocateFlagsInfo obj)
    {
      obj       = new VkMemoryAllocateFlagsInfo();
      obj.SType = VkStructureType.MemoryAllocateFlagsInfo;
    }

    public static void PreMake(out VkBindBufferMemoryInfo obj)
    {
      obj       = new VkBindBufferMemoryInfo();
      obj.SType = VkStructureType.BindBufferMemoryInfo;
    }

    public static void PreMake(out VkBindBufferMemoryDeviceGroupInfo obj)
    {
      obj       = new VkBindBufferMemoryDeviceGroupInfo();
      obj.SType = VkStructureType.BindBufferMemoryDeviceGroupInfo;
    }

    public static void PreMake(out VkBindImageMemoryInfo obj)
    {
      obj       = new VkBindImageMemoryInfo();
      obj.SType = VkStructureType.BindImageMemoryInfo;
    }

    public static void PreMake(out VkBindImageMemoryDeviceGroupInfo obj)
    {
      obj       = new VkBindImageMemoryDeviceGroupInfo();
      obj.SType = VkStructureType.BindImageMemoryDeviceGroupInfo;
    }

    public static void PreMake(out VkDeviceGroupRenderPassBeginInfo obj)
    {
      obj       = new VkDeviceGroupRenderPassBeginInfo();
      obj.SType = VkStructureType.DeviceGroupRenderPassBeginInfo;
    }

    public static void PreMake(out VkDeviceGroupCommandBufferBeginInfo obj)
    {
      obj       = new VkDeviceGroupCommandBufferBeginInfo();
      obj.SType = VkStructureType.DeviceGroupCommandBufferBeginInfo;
    }

    public static void PreMake(out VkDeviceGroupSubmitInfo obj)
    {
      obj       = new VkDeviceGroupSubmitInfo();
      obj.SType = VkStructureType.DeviceGroupSubmitInfo;
    }

    public static void PreMake(out VkDeviceGroupBindSparseInfo obj)
    {
      obj       = new VkDeviceGroupBindSparseInfo();
      obj.SType = VkStructureType.DeviceGroupBindSparseInfo;
    }

    public static void PreMake(out VkDeviceGroupDeviceCreateInfo obj)
    {
      obj       = new VkDeviceGroupDeviceCreateInfo();
      obj.SType = VkStructureType.DeviceGroupDeviceCreateInfo;
    }

    public static void PreMake(out VkDescriptorUpdateTemplateCreateInfo obj)
    {
      obj       = new VkDescriptorUpdateTemplateCreateInfo();
      obj.SType = VkStructureType.DescriptorUpdateTemplateCreateInfo;
    }

    public static void PreMake(out VkRenderPassInputAttachmentAspectCreateInfo obj)
    {
      obj       = new VkRenderPassInputAttachmentAspectCreateInfo();
      obj.SType = VkStructureType.RenderPassInputAttachmentAspectCreateInfo;
    }

    public static void PreMake(out VkPhysicalDevice16BitStorageFeatures obj)
    {
      obj       = new VkPhysicalDevice16BitStorageFeatures();
      obj.SType = VkStructureType.PhysicalDevice16BitStorageFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceSubgroupProperties obj)
    {
      obj       = new VkPhysicalDeviceSubgroupProperties();
      obj.SType = VkStructureType.PhysicalDeviceSubgroupProperties;
    }

    public static void PreMake(out VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures obj)
    {
      obj       = new VkPhysicalDeviceShaderSubgroupExtendedTypesFeatures();
      obj.SType = VkStructureType.PhysicalDeviceShaderSubgroupExtendedTypesFeatures;
    }

    public static void PreMake(out VkBufferMemoryRequirementsInfo2 obj)
    {
      obj       = new VkBufferMemoryRequirementsInfo2();
      obj.SType = VkStructureType.BufferMemoryRequirementsInfo2;
    }

    public static void PreMake(out VkImageMemoryRequirementsInfo2 obj)
    {
      obj       = new VkImageMemoryRequirementsInfo2();
      obj.SType = VkStructureType.ImageMemoryRequirementsInfo2;
    }

    public static void PreMake(out VkImageSparseMemoryRequirementsInfo2 obj)
    {
      obj       = new VkImageSparseMemoryRequirementsInfo2();
      obj.SType = VkStructureType.ImageSparseMemoryRequirementsInfo2;
    }

    public static void PreMake(out VkMemoryRequirements2 obj)
    {
      obj       = new VkMemoryRequirements2();
      obj.SType = VkStructureType.MemoryRequirements2;
    }

    public static void PreMake(out VkSparseImageMemoryRequirements2 obj)
    {
      obj       = new VkSparseImageMemoryRequirements2();
      obj.SType = VkStructureType.SparseImageMemoryRequirements2;
    }

    public static void PreMake(out VkPhysicalDevicePointClippingProperties obj)
    {
      obj       = new VkPhysicalDevicePointClippingProperties();
      obj.SType = VkStructureType.PhysicalDevicePointClippingProperties;
    }

    public static void PreMake(out VkMemoryDedicatedRequirements obj)
    {
      obj       = new VkMemoryDedicatedRequirements();
      obj.SType = VkStructureType.MemoryDedicatedRequirements;
    }

    public static void PreMake(out VkMemoryDedicatedAllocateInfo obj)
    {
      obj       = new VkMemoryDedicatedAllocateInfo();
      obj.SType = VkStructureType.MemoryDedicatedAllocateInfo;
    }

    public static void PreMake(out VkImageViewUsageCreateInfo obj)
    {
      obj       = new VkImageViewUsageCreateInfo();
      obj.SType = VkStructureType.ImageViewUsageCreateInfo;
    }

    public static void PreMake(out VkPipelineTessellationDomainOriginStateCreateInfo obj)
    {
      obj       = new VkPipelineTessellationDomainOriginStateCreateInfo();
      obj.SType = VkStructureType.PipelineTessellationDomainOriginStateCreateInfo;
    }

    public static void PreMake(out VkSamplerYcbcrConversionInfo obj)
    {
      obj       = new VkSamplerYcbcrConversionInfo();
      obj.SType = VkStructureType.SamplerYcbcrConversionInfo;
    }

    public static void PreMake(out VkSamplerYcbcrConversionCreateInfo obj)
    {
      obj       = new VkSamplerYcbcrConversionCreateInfo();
      obj.SType = VkStructureType.SamplerYcbcrConversionCreateInfo;
    }

    public static void PreMake(out VkBindImagePlaneMemoryInfo obj)
    {
      obj       = new VkBindImagePlaneMemoryInfo();
      obj.SType = VkStructureType.BindImagePlaneMemoryInfo;
    }

    public static void PreMake(out VkImagePlaneMemoryRequirementsInfo obj)
    {
      obj       = new VkImagePlaneMemoryRequirementsInfo();
      obj.SType = VkStructureType.ImagePlaneMemoryRequirementsInfo;
    }

    public static void PreMake(out VkPhysicalDeviceSamplerYcbcrConversionFeatures obj)
    {
      obj       = new VkPhysicalDeviceSamplerYcbcrConversionFeatures();
      obj.SType = VkStructureType.PhysicalDeviceSamplerYcbcrConversionFeatures;
    }

    public static void PreMake(out VkSamplerYcbcrConversionImageFormatProperties obj)
    {
      obj       = new VkSamplerYcbcrConversionImageFormatProperties();
      obj.SType = VkStructureType.SamplerYcbcrConversionImageFormatProperties;
    }

    public static void PreMake(out VkProtectedSubmitInfo obj)
    {
      obj       = new VkProtectedSubmitInfo();
      obj.SType = VkStructureType.ProtectedSubmitInfo;
    }

    public static void PreMake(out VkPhysicalDeviceProtectedMemoryFeatures obj)
    {
      obj       = new VkPhysicalDeviceProtectedMemoryFeatures();
      obj.SType = VkStructureType.PhysicalDeviceProtectedMemoryFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceProtectedMemoryProperties obj)
    {
      obj       = new VkPhysicalDeviceProtectedMemoryProperties();
      obj.SType = VkStructureType.PhysicalDeviceProtectedMemoryProperties;
    }

    public static void PreMake(out VkDeviceQueueInfo2 obj)
    {
      obj       = new VkDeviceQueueInfo2();
      obj.SType = VkStructureType.DeviceQueueInfo2;
    }

    public static void PreMake(out VkPhysicalDeviceSamplerFilterMinmaxProperties obj)
    {
      obj       = new VkPhysicalDeviceSamplerFilterMinmaxProperties();
      obj.SType = VkStructureType.PhysicalDeviceSamplerFilterMinmaxProperties;
    }

    public static void PreMake(out VkSamplerReductionModeCreateInfo obj)
    {
      obj       = new VkSamplerReductionModeCreateInfo();
      obj.SType = VkStructureType.SamplerReductionModeCreateInfo;
    }

    public static void PreMake(out VkImageFormatListCreateInfo obj)
    {
      obj       = new VkImageFormatListCreateInfo();
      obj.SType = VkStructureType.ImageFormatListCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceMaintenance3Properties obj)
    {
      obj       = new VkPhysicalDeviceMaintenance3Properties();
      obj.SType = VkStructureType.PhysicalDeviceMaintenance3Properties;
    }

    public static void PreMake(out VkDescriptorSetLayoutSupport obj)
    {
      obj       = new VkDescriptorSetLayoutSupport();
      obj.SType = VkStructureType.DescriptorSetLayoutSupport;
    }

    public static void PreMake(out VkPhysicalDeviceShaderDrawParametersFeatures obj)
    {
      obj       = new VkPhysicalDeviceShaderDrawParametersFeatures();
      obj.SType = VkStructureType.PhysicalDeviceShaderDrawParametersFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceShaderFloat16Int8Features obj)
    {
      obj       = new VkPhysicalDeviceShaderFloat16Int8Features();
      obj.SType = VkStructureType.PhysicalDeviceShaderFloat16Int8Features;
    }

    public static void PreMake(out VkPhysicalDeviceFloatControlsProperties obj)
    {
      obj       = new VkPhysicalDeviceFloatControlsProperties();
      obj.SType = VkStructureType.PhysicalDeviceFloatControlsProperties;
    }

    public static void PreMake(out VkPhysicalDeviceHostQueryResetFeatures obj)
    {
      obj       = new VkPhysicalDeviceHostQueryResetFeatures();
      obj.SType = VkStructureType.PhysicalDeviceHostQueryResetFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceDescriptorIndexingFeatures obj)
    {
      obj       = new VkPhysicalDeviceDescriptorIndexingFeatures();
      obj.SType = VkStructureType.PhysicalDeviceDescriptorIndexingFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceDescriptorIndexingProperties obj)
    {
      obj       = new VkPhysicalDeviceDescriptorIndexingProperties();
      obj.SType = VkStructureType.PhysicalDeviceDescriptorIndexingProperties;
    }

    public static void PreMake(out VkDescriptorSetLayoutBindingFlagsCreateInfo obj)
    {
      obj       = new VkDescriptorSetLayoutBindingFlagsCreateInfo();
      obj.SType = VkStructureType.DescriptorSetLayoutBindingFlagsCreateInfo;
    }

    public static void PreMake(out VkDescriptorSetVariableDescriptorCountAllocateInfo obj)
    {
      obj       = new VkDescriptorSetVariableDescriptorCountAllocateInfo();
      obj.SType = VkStructureType.DescriptorSetVariableDescriptorCountAllocateInfo;
    }

    public static void PreMake(out VkDescriptorSetVariableDescriptorCountLayoutSupport obj)
    {
      obj       = new VkDescriptorSetVariableDescriptorCountLayoutSupport();
      obj.SType = VkStructureType.DescriptorSetVariableDescriptorCountLayoutSupport;
    }

    public static void PreMake(out VkAttachmentDescription2 obj)
    {
      obj       = new VkAttachmentDescription2();
      obj.SType = VkStructureType.AttachmentDescription2;
    }

    public static void PreMake(out VkAttachmentReference2 obj)
    {
      obj       = new VkAttachmentReference2();
      obj.SType = VkStructureType.AttachmentReference2;
    }

    public static void PreMake(out VkSubpassDescription2 obj)
    {
      obj       = new VkSubpassDescription2();
      obj.SType = VkStructureType.SubpassDescription2;
    }

    public static void PreMake(out VkSubpassDependency2 obj)
    {
      obj       = new VkSubpassDependency2();
      obj.SType = VkStructureType.SubpassDependency2;
    }

    public static void PreMake(out VkRenderPassCreateInfo2 obj)
    {
      obj       = new VkRenderPassCreateInfo2();
      obj.SType = VkStructureType.RenderPassCreateInfo2;
    }

    public static void PreMake(out VkSubpassBeginInfo obj)
    {
      obj       = new VkSubpassBeginInfo();
      obj.SType = VkStructureType.SubpassBeginInfo;
    }

    public static void PreMake(out VkSubpassEndInfo obj)
    {
      obj       = new VkSubpassEndInfo();
      obj.SType = VkStructureType.SubpassEndInfo;
    }

    public static void PreMake(out VkPhysicalDeviceTimelineSemaphoreFeatures obj)
    {
      obj       = new VkPhysicalDeviceTimelineSemaphoreFeatures();
      obj.SType = VkStructureType.PhysicalDeviceTimelineSemaphoreFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceTimelineSemaphoreProperties obj)
    {
      obj       = new VkPhysicalDeviceTimelineSemaphoreProperties();
      obj.SType = VkStructureType.PhysicalDeviceTimelineSemaphoreProperties;
    }

    public static void PreMake(out VkSemaphoreTypeCreateInfo obj)
    {
      obj       = new VkSemaphoreTypeCreateInfo();
      obj.SType = VkStructureType.SemaphoreTypeCreateInfo;
    }

    public static void PreMake(out VkTimelineSemaphoreSubmitInfo obj)
    {
      obj       = new VkTimelineSemaphoreSubmitInfo();
      obj.SType = VkStructureType.TimelineSemaphoreSubmitInfo;
    }

    public static void PreMake(out VkSemaphoreWaitInfo obj)
    {
      obj       = new VkSemaphoreWaitInfo();
      obj.SType = VkStructureType.SemaphoreWaitInfo;
    }

    public static void PreMake(out VkSemaphoreSignalInfo obj)
    {
      obj       = new VkSemaphoreSignalInfo();
      obj.SType = VkStructureType.SemaphoreSignalInfo;
    }

    public static void PreMake(out VkPhysicalDevice8BitStorageFeatures obj)
    {
      obj       = new VkPhysicalDevice8BitStorageFeatures();
      obj.SType = VkStructureType.PhysicalDevice8BitStorageFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceVulkanMemoryModelFeatures obj)
    {
      obj       = new VkPhysicalDeviceVulkanMemoryModelFeatures();
      obj.SType = VkStructureType.PhysicalDeviceVulkanMemoryModelFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceShaderAtomicInt64Features obj)
    {
      obj       = new VkPhysicalDeviceShaderAtomicInt64Features();
      obj.SType = VkStructureType.PhysicalDeviceShaderAtomicInt64Features;
    }

    public static void PreMake(out VkPhysicalDeviceDepthStencilResolveProperties obj)
    {
      obj       = new VkPhysicalDeviceDepthStencilResolveProperties();
      obj.SType = VkStructureType.PhysicalDeviceDepthStencilResolveProperties;
    }

    public static void PreMake(out VkSubpassDescriptionDepthStencilResolve obj)
    {
      obj       = new VkSubpassDescriptionDepthStencilResolve();
      obj.SType = VkStructureType.SubpassDescriptionDepthStencilResolve;
    }

    public static void PreMake(out VkImageStencilUsageCreateInfo obj)
    {
      obj       = new VkImageStencilUsageCreateInfo();
      obj.SType = VkStructureType.ImageStencilUsageCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceScalarBlockLayoutFeatures obj)
    {
      obj       = new VkPhysicalDeviceScalarBlockLayoutFeatures();
      obj.SType = VkStructureType.PhysicalDeviceScalarBlockLayoutFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceUniformBufferStandardLayoutFeatures obj)
    {
      obj       = new VkPhysicalDeviceUniformBufferStandardLayoutFeatures();
      obj.SType = VkStructureType.PhysicalDeviceUniformBufferStandardLayoutFeatures;
    }

    public static void PreMake(out VkPhysicalDeviceBufferDeviceAddressFeatures obj)
    {
      obj       = new VkPhysicalDeviceBufferDeviceAddressFeatures();
      obj.SType = VkStructureType.PhysicalDeviceBufferDeviceAddressFeatures;
    }

    public static void PreMake(out VkBufferDeviceAddressInfo obj)
    {
      obj       = new VkBufferDeviceAddressInfo();
      obj.SType = VkStructureType.BufferDeviceAddressInfo;
    }

    public static void PreMake(out VkBufferOpaqueCaptureAddressCreateInfo obj)
    {
      obj       = new VkBufferOpaqueCaptureAddressCreateInfo();
      obj.SType = VkStructureType.BufferOpaqueCaptureAddressCreateInfo;
    }

    public static void PreMake(out VkPhysicalDeviceImagelessFramebufferFeatures obj)
    {
      obj       = new VkPhysicalDeviceImagelessFramebufferFeatures();
      obj.SType = VkStructureType.PhysicalDeviceImagelessFramebufferFeatures;
    }

    public static void PreMake(out VkFramebufferAttachmentsCreateInfo obj)
    {
      obj       = new VkFramebufferAttachmentsCreateInfo();
      obj.SType = VkStructureType.FramebufferAttachmentsCreateInfo;
    }

    public static void PreMake(out VkFramebufferAttachmentImageInfo obj)
    {
      obj       = new VkFramebufferAttachmentImageInfo();
      obj.SType = VkStructureType.FramebufferAttachmentImageInfo;
    }

    public static void PreMake(out VkRenderPassAttachmentBeginInfo obj)
    {
      obj       = new VkRenderPassAttachmentBeginInfo();
      obj.SType = VkStructureType.RenderPassAttachmentBeginInfo;
    }

    public static void PreMake(out VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures obj)
    {
      obj       = new VkPhysicalDeviceSeparateDepthStencilLayoutsFeatures();
      obj.SType = VkStructureType.PhysicalDeviceSeparateDepthStencilLayoutsFeatures;
    }

    public static void PreMake(out VkAttachmentReferenceStencilLayout obj)
    {
      obj       = new VkAttachmentReferenceStencilLayout();
      obj.SType = VkStructureType.AttachmentReferenceStencilLayout;
    }

    public static void PreMake(out VkAttachmentDescriptionStencilLayout obj)
    {
      obj       = new VkAttachmentDescriptionStencilLayout();
      obj.SType = VkStructureType.AttachmentDescriptionStencilLayout;
    }

    public static void PreMake(out VkMemoryOpaqueCaptureAddressAllocateInfo obj)
    {
      obj       = new VkMemoryOpaqueCaptureAddressAllocateInfo();
      obj.SType = VkStructureType.MemoryOpaqueCaptureAddressAllocateInfo;
    }

    public static void PreMake(out VkDeviceMemoryOpaqueCaptureAddressInfo obj)
    {
      obj       = new VkDeviceMemoryOpaqueCaptureAddressInfo();
      obj.SType = VkStructureType.DeviceMemoryOpaqueCaptureAddressInfo;
    }

    public static void PreMake(out VkPhysicalDeviceVulkan11Features obj)
    {
      obj       = new VkPhysicalDeviceVulkan11Features();
      obj.SType = VkStructureType.PhysicalDeviceVulkan11Features;
    }

    public static void PreMake(out VkPhysicalDeviceVulkan11Properties obj)
    {
      obj       = new VkPhysicalDeviceVulkan11Properties();
      obj.SType = VkStructureType.PhysicalDeviceVulkan11Properties;
    }

    public static void PreMake(out VkPhysicalDeviceVulkan12Features obj)
    {
      obj       = new VkPhysicalDeviceVulkan12Features();
      obj.SType = VkStructureType.PhysicalDeviceVulkan12Features;
    }

    public static void PreMake(out VkPhysicalDeviceVulkan12Properties obj)
    {
      obj       = new VkPhysicalDeviceVulkan12Properties();
      obj.SType = VkStructureType.PhysicalDeviceVulkan12Properties;
    }

    public static void PreMake(out VkSwapchainCreateInfoKHR obj)
    {
      obj       = new VkSwapchainCreateInfoKHR();
      obj.SType = VkStructureType.SwapchainCreateInfoKhr;
    }

    public static void PreMake(out VkPresentInfoKHR obj)
    {
      obj       = new VkPresentInfoKHR();
      obj.SType = VkStructureType.PresentInfoKhr;
    }

    public static void PreMake(out VkImageSwapchainCreateInfoKHR obj)
    {
      obj       = new VkImageSwapchainCreateInfoKHR();
      obj.SType = VkStructureType.ImageSwapchainCreateInfoKhr;
    }

    public static void PreMake(out VkBindImageMemorySwapchainInfoKHR obj)
    {
      obj       = new VkBindImageMemorySwapchainInfoKHR();
      obj.SType = VkStructureType.BindImageMemorySwapchainInfoKhr;
    }

    public static void PreMake(out VkAcquireNextImageInfoKHR obj)
    {
      obj       = new VkAcquireNextImageInfoKHR();
      obj.SType = VkStructureType.AcquireNextImageInfoKhr;
    }

    public static void PreMake(out VkDeviceGroupPresentCapabilitiesKHR obj)
    {
      obj       = new VkDeviceGroupPresentCapabilitiesKHR();
      obj.SType = VkStructureType.DeviceGroupPresentCapabilitiesKhr;
    }

    public static void PreMake(out VkDeviceGroupPresentInfoKHR obj)
    {
      obj       = new VkDeviceGroupPresentInfoKHR();
      obj.SType = VkStructureType.DeviceGroupPresentInfoKhr;
    }

    public static void PreMake(out VkDeviceGroupSwapchainCreateInfoKHR obj)
    {
      obj       = new VkDeviceGroupSwapchainCreateInfoKHR();
      obj.SType = VkStructureType.DeviceGroupSwapchainCreateInfoKhr;
    }
  }

    public static partial class Utilities
    {
        public static void Resize<T>(this Array<T> list,
                                     int           newSize,
                                     T             value = default!)
            where T : notnull
        {
            if(list.Count > newSize)
            {
                list.RemoveRange(newSize, list.Count - newSize);
            }
            else if(list.Count < newSize)
            {
                for(int i = list.Count; i < newSize; i++)
                {
                    list.Add(value);
                }
            }
        }

        public static void Swap<T>(this Array<T> list1,
                                   Array<T>      list2)
            where T : notnull
        {
            Array<T> temp = new Array<T>(list1);
            list1.Clear();
            list1.AddRange(list2);
            list2.Clear();
            list2.AddRange(temp);
        }

        public static Array<T> InitializedList<T>(int size,
                                                  T   value)
            where T : notnull
        {
            Array<T> temp = new Array<T>();

            for(int count = 1; count <= size; count++)
            {
                temp.Add(value);
            }

            return temp;
        }

        public static Array<Array<T>> NestedList<T>(int outerSize,
                                                    int innerSize)
            where T : notnull
        {
            Array<Array<T>> temp = new Array<Array<T>>();

            for(int count = 1; count <= outerSize; count++)
            {
                temp.Add(new Array<T>(innerSize));
            }

            return temp;
        }

        public static Array<Array<T>> NestedList<T>(int outerSize,
                                                    int innerSize,
                                                    T   value)
            where T : notnull
        {
            Array<Array<T>> temp = new();

            for(int count = 1; count <= outerSize; count++)
            {
                temp.Add(InitializedList(innerSize, value));
            }

            return temp;
        }
    }
}
