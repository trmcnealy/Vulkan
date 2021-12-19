using System;
using System.Diagnostics.CodeAnalysis;

namespace Vulkan
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class Api
    {
        /// <summary>        
        /// VkResult vkCreateInstance(const VkInstanceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkInstance* pInstance);
        /// </summary>
        public static readonly unsafe delegate*<ref VkInstanceCreateInfo, VkAllocationCallbacks*, out VkInstance, VkResult> CreateInstance;
        /// <summary>        
        /// void vkDestroyInstance(VkInstance instance, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        public static readonly unsafe delegate*<VkInstance, VkAllocationCallbacks*, void> DestroyInstance;
        /// <summary>        
        /// VkResult vkEnumeratePhysicalDevices(VkInstance instance, uint32_t* pPhysicalDeviceCount, VkPhysicalDevice* pPhysicalDevices);
        /// </summary>
        internal static readonly unsafe delegate*<VkInstance, out uint, VkPhysicalDevice*, VkResult> _EnumeratePhysicalDevices;
        /// <summary>        
        /// void vkGetPhysicalDeviceFeatures(VkPhysicalDevice physicalDevice, VkPhysicalDeviceFeatures* pFeatures);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, out VkPhysicalDeviceFeatures, void> GetPhysicalDeviceFeatures;
        /// <summary>        
        /// void vkGetPhysicalDeviceFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkFormatProperties* pFormatProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkFormat, out VkFormatProperties, void> GetPhysicalDeviceFormatProperties;
        /// <summary>        
        /// VkResult vkGetPhysicalDeviceImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkImageTiling tiling, VkImageUsageFlags usage, VkImageCreateFlags flags, VkImageFormatProperties* pImageFormatProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, out VkImageFormatProperties, VkResult> GetPhysicalDeviceImageFormatProperties;
        /// <summary>        
        /// void vkGetPhysicalDeviceProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, out VkPhysicalDeviceProperties, void> GetPhysicalDeviceProperties;
        /// <summary>        
        /// void vkGetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice, uint32_t* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties*, void> _GetPhysicalDeviceQueueFamilyProperties;
        /// <summary>        
        /// void vkGetPhysicalDeviceMemoryProperties(VkPhysicalDevice physicalDevice, VkPhysicalDeviceMemoryProperties* pMemoryProperties);
        /// </summary>
        public static readonly unsafe delegate*<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties, void> GetPhysicalDeviceMemoryProperties;
        /// <summary>        
        /// PFN_vkVoidFunction vkGetInstanceProcAddr(VkInstance instance, const char* pName);
        /// </summary>
        public static readonly unsafe delegate*<VkInstance, utf8string, nint> GetInstanceProcAddr;
        /// <summary>        
        /// PFN_vkVoidFunction vkGetDeviceProcAddr(VkDevice device, const char* pName);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, utf8string, nint> GetDeviceProcAddr;
        /// <summary>        
        /// VkResult vkCreateDevice(VkPhysicalDevice physicalDevice, const VkDeviceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkDevice* pDevice);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, ref VkDeviceCreateInfo, VkAllocationCallbacks*, out VkDevice, VkResult> CreateDevice;
        /// <summary>        
        /// void vkDestroyDevice(VkDevice device, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkAllocationCallbacks*, void> DestroyDevice;
        /// <summary>        
        /// VkResult vkEnumerateInstanceExtensionProperties(const char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<utf8string, out uint, VkExtensionProperties*, VkResult> _EnumerateInstanceExtensionProperties;
        /// <summary>        
        /// VkResult vkEnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice, const char* pLayerName, uint32_t* pPropertyCount, VkExtensionProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, utf8string, out uint, VkExtensionProperties*, VkResult> _EnumerateDeviceExtensionProperties;
        /// <summary>        
        /// VkResult vkEnumerateInstanceLayerProperties(uint32_t* pPropertyCount, VkLayerProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<out uint, VkLayerProperties*, VkResult> _EnumerateInstanceLayerProperties;
        /// <summary>        
        /// VkResult vkEnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice, uint32_t* pPropertyCount, VkLayerProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkLayerProperties*, VkResult> _EnumerateDeviceLayerProperties;
        /// <summary>        
        /// void vkGetDeviceQueue(VkDevice device, uint32_t queueFamilyIndex, uint32_t queueIndex, VkQueue* pQueue);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, uint, out VkQueue, void> GetDeviceQueue;
        /// <summary>        
        /// VkResult vkQueueSubmit(VkQueue queue, uint32_t submitCount, const VkSubmitInfo* pSubmits, VkFence fence);
        /// </summary>
        internal static readonly unsafe delegate*<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult> _QueueSubmit;
        /// <summary>        
        /// VkResult vkQueueWaitIdle(VkQueue queue);
        /// </summary>
        internal static readonly unsafe delegate*<VkQueue, VkResult> QueueWaitIdle;
        /// <summary>        
        /// VkResult vkDeviceWaitIdle(VkDevice device);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkResult> DeviceWaitIdle;
        /// <summary>        
        /// VkResult vkAllocateMemory(VkDevice device, const VkMemoryAllocateInfo* pAllocateInfo, const VkAllocationCallbacks* pAllocator, VkDeviceMemory* pMemory);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkMemoryAllocateInfo, VkAllocationCallbacks*, out VkDeviceMemory, VkResult> AllocateMemory;
        /// <summary>        
        /// void vkFreeMemory(VkDevice device, VkDeviceMemory memory, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void> FreeMemory;
        /// <summary>        
        /// VkResult vkMapMemory(VkDevice device, VkDeviceMemory memory, VkDeviceSize offset, VkDeviceSize size VkMemoryMapFlags flags, void** ppData);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDeviceMemory, ulong, ulong, uint, out nint, VkResult> MapMemory;
        /// <summary>        
        /// void vkUnmapMemory(VkDevice device, VkDeviceMemory memory);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDeviceMemory, void> UnmapMemory;
        /// <summary>        
        /// VkResult vkFlushMappedMemoryRanges(VkDevice device, uint32_t memoryRangeCount, const VkMappedMemoryRange* pMemoryRanges);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult> _FlushMappedMemoryRanges;
        /// <summary>        
        /// VkResult vkInvalidateMappedMemoryRanges(VkDevice device, uint32_t memoryRangeCount, const VkMappedMemoryRange* pMemoryRanges);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult> _InvalidateMappedMemoryRanges;
        /// <summary>        
        /// void vkGetDeviceMemoryCommitment(VkDevice device, VkDeviceMemory memory, VkDeviceSize* pCommittedMemoryInBytes);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDeviceMemory, out ulong, void> GetDeviceMemoryCommitment;
        /// <summary>        
        /// VkResult vkBindBufferMemory(VkDevice device, VkBuffer buffer, VkDeviceMemory memory, VkDeviceSize memoryOffset);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult> BindBufferMemory;
        /// <summary>        
        /// VkResult vkBindImageMemory(VkDevice device, VkImage image, VkDeviceMemory memory, VkDeviceSize memoryOffset);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult> BindImageMemory;
        /// <summary>        
        /// void vkGetBufferMemoryRequirements(VkDevice device, VkBuffer buffer, VkMemoryRequirements* pMemoryRequirements);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkBuffer, out VkMemoryRequirements, void> GetBufferMemoryRequirements;
        /// <summary>        
        /// void vkGetImageMemoryRequirements(VkDevice device, VkImage image, VkMemoryRequirements* pMemoryRequirements);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImage, out VkMemoryRequirements, void> GetImageMemoryRequirements;
        /// <summary>        
        /// void vkGetImageSparseMemoryRequirements(VkDevice device, VkImage image, uint32_t* pSparseMemoryRequirementCount, VkSparseImageMemoryRequirements* pSparseMemoryRequirements);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImage, out uint, VkSparseImageMemoryRequirements*, void> _GetImageSparseMemoryRequirements;
        /// <summary>        
        /// void vkGetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, VkImageUsageFlags usage, VkImageTiling tiling, uint32_t* pPropertyCount, VkSparseImageFormatProperties* pProperties);
        /// </summary>
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, out uint, VkSparseImageFormatProperties*, void> _GetPhysicalDeviceSparseImageFormatProperties;
        /// <summary>        
        /// VkResult vkQueueBindSparse(VkQueue queue, uint32_t bindInfoCount, const VkBindSparseInfo* pBindInfo, VkFence fence);
        /// </summary>
        internal static readonly unsafe delegate*<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult> _QueueBindSparse;
        /// <summary>        
        /// VkResult vkCreateFence(VkDevice device, const VkFenceCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkFence* pFence);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkFenceCreateInfo, VkAllocationCallbacks*, out VkFence, VkResult> CreateFence;
        /// <summary>        
        /// void vkDestroyFence(VkDevice device, VkFence fence, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkFence, VkAllocationCallbacks*, void> DestroyFence;
        /// <summary>        
        /// VkResult vkResetFences(VkDevice device, uint32_t fenceCount, const VkFence* pFences);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, VkFence*, VkResult> _ResetFences;
        /// <summary>        
        /// VkResult vkGetFenceStatus(VkDevice device, VkFence fence);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkFence, VkResult> GetFenceStatus;
        /// <summary>        
        /// VkResult vkWaitForFences(VkDevice device, uint32_t fenceCount, const VkFence* pFences, VkBool32 waitAll, uint64_t timeout);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, VkFence*, uint, ulong, VkResult> _WaitForFences;
        /// <summary>        
        /// VkResult vkCreateSemaphore(VkDevice device, const VkSemaphoreCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkSemaphore* pSemaphore);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkSemaphoreCreateInfo, VkAllocationCallbacks*, out VkSemaphore, VkResult> CreateSemaphore;
        /// <summary>        
        /// void vkDestroySemaphore(VkDevice device, VkSemaphore semaphore, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkSemaphore, VkAllocationCallbacks*, void> DestroySemaphore;
        /// <summary>        
        /// VkResult vkCreateEvent(VkDevice device, const VkEventCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkEvent* pEvent);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkEventCreateInfo, VkAllocationCallbacks*, out VkEvent, VkResult> CreateEvent;
        /// <summary>        
        /// void vkDestroyEvent(VkDevice device, VkEvent event, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkEvent, VkAllocationCallbacks*, void> DestroyEvent;
        /// <summary>        
        /// VkResult vkGetEventStatus(VkDevice device, VkEvent event);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkEvent, VkResult> GetEventStatus;
        /// <summary>        
        /// VkResult vkSetEvent(VkDevice device, VkEvent event);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkEvent, VkResult> SetEvent;
        /// <summary>        
        /// VkResult vkResetEvent(VkDevice device, VkEvent event);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkEvent, VkResult> ResetEvent;
        /// <summary>        
        /// VkResult vkCreateQueryPool(VkDevice device, const VkQueryPoolCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkQueryPool* pQueryPool);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkQueryPoolCreateInfo, VkAllocationCallbacks*, out VkQueryPool, VkResult> CreateQueryPool;
        /// <summary>        
        /// void vkDestroyQueryPool(VkDevice device, VkQueryPool queryPool, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkQueryPool, VkAllocationCallbacks*, void> DestroyQueryPool;
        /// <summary>        
        /// VkResult vkGetQueryPoolResults(VkDevice device, VkQueryPool queryPool, uint32_t firstQuery, uint32_t querCount, size_t dataSize, void* pData, VkDeviceSize stride, VkQueryResultFlags flags);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkQueryPool, uint, uint, nuint, nint, ulong, VkQueryResultFlagBits, VkResult> GetQueryPoolResults;
        /// <summary>        
        /// VkResult vkCreateBuffer(VkDevice device, const VkBufferCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkBuffer* pBuffer);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkBufferCreateInfo, VkAllocationCallbacks*, out VkBuffer, VkResult> CreateBuffer;
        /// <summary>        
        /// void vkDestroyBuffer(VkDevice device, VkBuffer buffer, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkBuffer, VkAllocationCallbacks*, void> DestroyBuffer;
        /// <summary>        
        /// VkResult vkCreateBufferView(VkDevice device, const VkBufferViewCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkBufferView* pView);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkBufferViewCreateInfo, VkAllocationCallbacks*, out VkBufferView, VkResult> CreateBufferView;
        /// <summary>        
        /// void vkDestroyBufferView(VkDevice device, VkBufferView bufferView, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkBufferView, VkAllocationCallbacks*, void> DestroyBufferView;
        /// <summary>        
        /// VkResult vkCreateImage(VkDevice device, const VkImageCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkImage* pImage);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkImageCreateInfo, VkAllocationCallbacks*, out VkImage, VkResult> CreateImage;
        /// <summary>        
        /// void vkDestroyImage(VkDevice device, VkImage image, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImage, VkAllocationCallbacks*, void> DestroyImage;
        /// <summary>        
        /// void vkGetImageSubresourceLayout(VkDevice device, VkImage image, const VkImageSubresource* pSubresource, VkSubresourceLayout* pLayout);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImage, ref VkImageSubresource, out VkSubresourceLayout, void> GetImageSubresourceLayout;
        /// <summary>        
        /// VkResult vkCreateImageView(VkDevice device, const VkImageViewCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkImageView* pView);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkImageViewCreateInfo, VkAllocationCallbacks*, out VkImageView, VkResult> CreateImageView;
        /// <summary>        
        /// void vkDestroyImageView(VkDevice device, VkImageView imageView, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkImageView, VkAllocationCallbacks*, void> DestroyImageView;
        /// <summary>        
        /// VkResult vkCreateShaderModule(VkDevice device, const VkShaderModuleCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkShaderModule* pShaderModule);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkShaderModuleCreateInfo, VkAllocationCallbacks*, out VkShaderModule, VkResult> CreateShaderModule;
        /// <summary>        
        /// void vkDestroyShaderModule(VkDevice device, VkShaderModule shaderModule, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkShaderModule, VkAllocationCallbacks*, void> DestroyShaderModule;
        /// <summary>        
        /// VkResult vkCreatePipelineCache(VkDevice device, const VkPipelineCacheCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkPipelineCache* pPipelineCache);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkPipelineCacheCreateInfo, VkAllocationCallbacks*, out VkPipelineCache, VkResult> CreatePipelineCache;
        /// <summary>        
        /// void vkDestroyPipelineCache(VkDevice device, VkPipelineCache pipelineCache, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void> DestroyPipelineCache;
        /// <summary>        
        /// VkResult vkGetPipelineCacheData(VkDevice device, VkPipelineCache pipelineCache, size_t* pDataSize, void* pData);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineCache, ref UIntPtr, nint, VkResult> GetPipelineCacheData;
        /// <summary>        
        /// VkResult vkMergePipelineCaches(VkDevice device, VkPipelineCache dstCache, uint32_t srcCacheCount, const VkPipelineCache* pSrcCaches);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult> _MergePipelineCaches;
        /// <summary>        
        /// VkResult vkCreateGraphicsPipelines(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, const VkGraphicsPipelineCreateInfo* pCreateInfos, const VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _CreateGraphicsPipelines;
        /// <summary>        
        /// VkResult vkCreateComputePipelines(VkDevice device, VkPipelineCache pipelineCache, uint32_t createInfoCount, const VkComputePipelineCreateInfo* pCreateInfos, const VkAllocationCallbacks* pAllocator, VkPipeline* pPipelines);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult> _CreateComputePipelines;
        /// <summary>        
        /// void vkDestroyPipeline(VkDevice device, VkPipeline pipeline, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipeline, VkAllocationCallbacks*, void> DestroyPipeline;
        /// <summary>        
        /// VkResult vkCreatePipelineLayout(VkDevice device, const VkPipelineLayoutCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkPipelineLayout* pPipelineLayout);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkPipelineLayoutCreateInfo, VkAllocationCallbacks*, out VkPipelineLayout, VkResult> CreatePipelineLayout;
        /// <summary>        
        /// void vkDestroyPipelineLayout(VkDevice device, VkPipelineLayout pipelineLayout, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void> DestroyPipelineLayout;
        /// <summary>        
        /// VkResult vkCreateSampler(VkDevice device, const VkSamplerCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkSampler* pSampler);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkSamplerCreateInfo, VkAllocationCallbacks*, out VkSampler, VkResult> CreateSampler;
        /// <summary>        
        /// void vkDestroySampler(VkDevice device, VkSampler sampler, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkSampler, VkAllocationCallbacks*, void> DestroySampler;
        /// <summary>        
        /// VkResult vkCreateDescriptorSetLayout(VkDevice device, const VkDescriptorSetLayoutCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkDescriptorSetLayout* pSetLayout);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, VkAllocationCallbacks*, out VkDescriptorSetLayout, VkResult> CreateDescriptorSetLayout;
        /// <summary>        
        /// void vkDestroyDescriptorSetLayout(VkDevice device, VkDescriptorSetLayout descriptorSetLayout, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void> DestroyDescriptorSetLayout;
        /// <summary>        
        /// VkResult vkCreateDescriptorPool(VkDevice device, const VkDescriptorPoolCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkDescriptorPool* pDescriptorPool);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkDescriptorPoolCreateInfo, VkAllocationCallbacks*, out VkDescriptorPool, VkResult> CreateDescriptorPool;
        /// <summary>        
        /// void vkDestroyDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void> DestroyDescriptorPool;
        /// <summary>        
        /// VkResult vkResetDescriptorPool(VkDevice device, VkDescriptorPool descriptorPool, VkDescriptorPoolResetFlags flags);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDescriptorPool, uint, VkResult> ResetDescriptorPool;
        /// <summary>        
        /// VkResult vkAllocateDescriptorSets(VkDevice device, const VkDescriptorSetAllocateInfo* pAllocateInfo, VkDescriptorSet* pDescriptorSets);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkDescriptorSetAllocateInfo, VkDescriptorSet*, VkResult> _AllocateDescriptorSets;
        /// <summary>        
        /// VkResult vkFreeDescriptorSets(VkDevice device, VkDescriptorPool descriptorPool, uint32_t descriptorSetCount, const VkDescriptorSet* pDescriptorSets);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult> _FreeDescriptorSets;
        /// <summary>        
        /// void vkUpdateDescriptorSets(VkDevice device, uint32_t descriptorWriteCount, const VkWriteDescriptorSet* pDescriptorWrites, uint32_t descriptorCopyCount, const VkCopyDescriptorSet* pDescriptorCopies);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void> _UpdateDescriptorSets;
        /// <summary>        
        /// VkResult vkCreateFramebuffer(VkDevice device, const VkFramebufferCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkFramebuffer* pFramebuffer);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkFramebufferCreateInfo, VkAllocationCallbacks*, out VkFramebuffer, VkResult> CreateFramebuffer;
        /// <summary>        
        /// void vkDestroyFramebuffer(VkDevice device, VkFramebuffer framebuffer, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void> DestroyFramebuffer;
        /// <summary>        
        /// VkResult vkCreateRenderPass(VkDevice device, const VkRenderPassCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkRenderPass* pRenderPass);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkRenderPassCreateInfo, VkAllocationCallbacks*, out VkRenderPass, VkResult> CreateRenderPass;
        /// <summary>        
        /// void vkDestroyRenderPass(VkDevice device, VkRenderPass renderPass, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkRenderPass, VkAllocationCallbacks*, void> DestroyRenderPass;
        /// <summary>        
        /// void vkGetRenderAreaGranularity(VkDevice device, VkRenderPass renderPass, VkExtent2D* pGranularity);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkRenderPass, out VkExtent2D, void> GetRenderAreaGranularity;
        /// <summary>        
        /// VkResult vkCreateCommandPool(VkDevice device, const VkCommandPoolCreateInfo* pCreateInfo, const VkAllocationCallbacks* pAllocator, VkCommandPool* pCommandPool);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkCommandPoolCreateInfo, VkAllocationCallbacks*, out VkCommandPool, VkResult> CreateCommandPool;
        /// <summary>        
        /// void vkDestroyCommandPool(VkDevice device, VkCommandPool commandPool, const VkAllocationCallbacks* pAllocator);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkCommandPool, VkAllocationCallbacks*, void> DestroyCommandPool;
        /// <summary>        
        /// VkResult vkResetCommandPool(VkDevice device, VkCommandPool commandPool, VkCommandPoolResetFlags flags);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult> ResetCommandPool;
        /// <summary>        
        /// VkResult vkAllocateCommandBuffers(VkDevice device, const VkCommandBufferAllocateInfo* pAllocateInfo, VkCommandBuffer* pCommandBuffers);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, ref VkCommandBufferAllocateInfo, VkCommandBuffer*, VkResult> _AllocateCommandBuffers;
        /// <summary>        
        /// void vkFreeCommandBuffers(VkDevice device, VkCommandPool commandPool, uint32_t commandBufferCount, const VkCommandBuffer* pCommandBuffers);
        /// </summary>
        internal static readonly unsafe delegate*<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void> _FreeCommandBuffers;
        /// <summary>        
        /// VkResult vkBeginCommandBuffer(VkCommandBuffer commandBuffer, const VkCommandBufferBeginInfo* pBeginInfo);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, ref VkCommandBufferBeginInfo, VkResult> BeginCommandBuffer;
        /// <summary>        
        /// VkResult vkEndCommandBuffer(VkCommandBuffer commandBuffer);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkResult> EndCommandBuffer;
        /// <summary>        
        /// VkResult vkResetCommandBuffer(VkCommandBuffer commandBuffer, VkCommandBufferResetFlags flags);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, VkResult> ResetCommandBuffer;
        /// <summary>        
        /// void vkCmdBindPipeline(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipeline pipeline);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void> CmdBindPipeline;
        /// <summary>        
        /// void vkCmdSetViewport(VkCommandBuffer commandBuffer, uint32_t firstViewport, uint32_t viewportCount, const VkViewport* pViewports);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, uint, uint, VkViewport*, void> _CmdSetViewport;
        /// <summary>        
        /// void vkCmdSetScissor(VkCommandBuffer commandBuffer, uint32_t firstScissor, uint32_t scissorCount, const VkRect2D* pScissors);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void> _CmdSetScissor;
        /// <summary>        
        /// void vkCmdSetLineWidth(VkCommandBuffer commandBuffer, float lineWidth);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, float, void> CmdSetLineWidth;
        /// <summary>        
        /// void vkCmdSetDepthBias(VkCommandBuffer commandBuffer, float depthBiasConstantFactor, float depthBiasClamp, float depthBiasSlopeFactor);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, float, float, float, void> CmdSetDepthBias;
        /// <summary>        
        /// void vkCmdSetBlendConstants(VkCommandBuffer commandBuffer, const float blendConstants[4]);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, ref float, void> CmdSetBlendConstants;
        /// <summary>        
        /// void vkCmdSetDepthBounds(VkCommandBuffer commandBuffer, float minDepthBounds, float maxDepthBounds);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, float, float, void> CmdSetDepthBounds;
        /// <summary>        
        /// void vkCmdSetStencilCompareMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t compareMask);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, void> CmdSetStencilCompareMask;
        /// <summary>        
        /// void vkCmdSetStencilWriteMask(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t writeMask);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, void> CmdSetStencilWriteMask;
        /// <summary>        
        /// void vkCmdSetStencilReference(VkCommandBuffer commandBuffer, VkStencilFaceFlags faceMask, uint32_t reference);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, void> CmdSetStencilReference;
        /// <summary>        
        /// void vkCmdBindDescriptorSets(VkCommandBuffer commandBuffer, VkPipelineBindPoint pipelineBindPoint, VkPipelineLayout layout, uint32_t firstSet, uint32_t descriptorSetCount, const VkDescriptorSet* pDescriptorSets, uint32_t dynamicOffsetCount, const uint32_t* pDynamicOffsets);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void> _CmdBindDescriptorSets;
        /// <summary>        
        /// void vkCmdBindIndexBuffer(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, VkIndexType indexType);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void> CmdBindIndexBuffer;
        /// <summary>        
        /// void vkCmdBindVertexBuffers(VkCommandBuffer commandBuffer, uint32_t firstBinding, uint32_t bindingCount, const VkBuffer* pBuffers, const VkDeviceSize* pOffsets);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void> _CmdBindVertexBuffers;
        /// <summary>        
        /// void vkCmdDraw(VkCommandBuffer commandBuffer, uint32_t vertexCount, uint32_t instanceCount, uint32_t firstVertex, uint32_t firstInstance);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, uint, uint, void> CmdDraw;
        /// <summary>        
        /// void vkCmdDrawIndexed(VkCommandBuffer commandBuffer, uint32_t indexCount, uint32_t instanceCount, uint32_t firstIndex, int32_t vertexOffset, uint32_t firstInstance);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, uint, int, uint, void> CmdDrawIndexed;
        /// <summary>        
        /// void vkCmdDrawIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> CmdDrawIndirect;
        /// <summary>        
        /// void vkCmdDrawIndexedIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset, uint32_t drawCount, uint32_t stride);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void> CmdDrawIndexedIndirect;
        /// <summary>        
        /// void vkCmdDispatch(VkCommandBuffer commandBuffer, uint32_t groupCountX, uint32_t groupCountY, uint32_t groupCountZ);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, uint, void> CmdDispatch;
        /// <summary>        
        /// void vkCmdDispatchIndirect(VkCommandBuffer commandBuffer, VkBuffer buffer, VkDeviceSize offset);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, void> CmdDispatchIndirect;
        /// <summary>        
        /// void vkCmdCopyBuffer(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkBuffer dstBuffer, uint32_t regionCount, const VkBufferCopy* pRegions);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void> _CmdCopyBuffer;
        /// <summary>        
        /// void vkCmdCopyImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, const VkImageCopy* pRegions);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void> _CmdCopyImage;
        /// <summary>        
        /// void vkCmdBlitImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, const VkImageBlit* pRegions, VkFilter filter);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void> _CmdBlitImage;
        /// <summary>        
        /// void vkCmdCopyBufferToImage(VkCommandBuffer commandBuffer, VkBuffer srcBuffer, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, const VkBufferImageCopy* pRegions);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void> _CmdCopyBufferToImage;
        /// <summary>        
        /// void vkCmdCopyImageToBuffer(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkBuffer dstBuffer, uint32_t regionCount, const VkBufferImageCopy* pRegions);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void> _CmdCopyImageToBuffer;
        /// <summary>        
        /// void vkCmdUpdateBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize dataSize, const void* pData);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, nint, void> CmdUpdateBuffer;
        /// <summary>        
        /// void vkCmdFillBuffer(VkCommandBuffer commandBuffer, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize size, uint32_t data);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void> CmdFillBuffer;
        /// <summary>        
        /// void vkCmdClearColorImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, const VkClearColorValue* pColor, uint32_t rangeCount, const VkImageSubresourceRange* pRanges);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearColorValue, uint, VkImageSubresourceRange*, void> _CmdClearColorImage;
        /// <summary>        
        /// void vkCmdClearDepthStencilImage(VkCommandBuffer commandBuffer, VkImage image, VkImageLayout imageLayout, const VkClearDepthStencilValue* pDepthStencil, uint32_t rangeCount, const VkImageSubresourceRange* pRanges);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void> _CmdClearDepthStencilImage;
        /// <summary>        
        /// void vkCmdClearAttachments(VkCommandBuffer commandBuffer, uint32_t attachmentCount, const VkClearAttachment* pAttachments, uint32_t rectCount, const VkClearRect* pRects);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void> _CmdClearAttachments;
        /// <summary>        
        /// void vkCmdResolveImage(VkCommandBuffer commandBuffer, VkImage srcImage, VkImageLayout srcImageLayout, VkImage dstImage, VkImageLayout dstImageLayout, uint32_t regionCount, const VkImageResolve* pRegions);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void> _CmdResolveImage;
        /// <summary>        
        /// void vkCmdSetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkEvent, uint, void> CmdSetEvent;
        /// <summary>        
        /// void vkCmdResetEvent(VkCommandBuffer commandBuffer, VkEvent event, VkPipelineStageFlags stageMask);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkEvent, uint, void> CmdResetEvent;
        /// <summary>        
        /// void vkCmdWaitEvents(VkCommandBuffer commandBuffer, uint32_t eventCount, const VkEvent* pEvents, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, uint32_t memoryBarrierCount, const VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, const VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, const VkImageMemoryBarrier* pImageMemoryBarriers);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _CmdWaitEvents;
        /// <summary>        
        /// void vkCmdPipelineBarrier(VkCommandBuffer commandBuffer, VkPipelineStageFlags srcStageMask, VkPipelineStageFlags dstStageMask, VkDependencyFlags dependencyFlags, uint32_t memoryBarrierCount, const VkMemoryBarrier* pMemoryBarriers, uint32_t bufferMemoryBarrierCount, const VkBufferMemoryBarrier* pBufferMemoryBarriers, uint32_t imageMemoryBarrierCount, const VkImageMemoryBarrier* pImageMemoryBarriers);
        /// </summary>
        internal static readonly unsafe delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void> _CmdPipelineBarrier;
        /// <summary>        
        /// void vkCmdBeginQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query, VkQueryControlFlags flags);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void> CmdBeginQuery;
        /// <summary>        
        /// void vkCmdEndQuery(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t query);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkQueryPool, uint, void> CmdEndQuery;
        /// <summary>        
        /// void vkCmdResetQueryPool(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void> CmdResetQueryPool;
        /// <summary>        
        /// void vkCmdWriteTimestamp(VkCommandBuffer commandBuffer, VkPipelineStageFlagBits pipelineStage, VkQueryPool queryPool, uint32_t query);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void> CmdWriteTimestamp;
        /// <summary>        
        /// void vkCmdCopyQueryPoolResults(VkCommandBuffer commandBuffer, VkQueryPool queryPool, uint32_t firstQuery, uint32_t queryCount, VkBuffer dstBuffer, VkDeviceSize dstOffset, VkDeviceSize stride, VkQueryResultFlags flags);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, uint, void> CmdCopyQueryPoolResults;
        /// <summary>        
        /// void vkCmdPushConstants(VkCommandBuffer commandBuffer, VkPipelineLayout layout, VkShaderStageFlags stageFlags, uint32_t offset, uint32_t size, const void* pValues);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, nint, void> CmdPushConstants;
        /// <summary>        
        /// void vkCmdBeginRenderPass(VkCommandBuffer commandBuffer, const VkRenderPassBeginInfo* pRenderPassBegin, VkSubpassContents contents);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, VkSubpassContents, void> CmdBeginRenderPass;
        /// <summary>        
        /// void vkCmdNextSubpass(VkCommandBuffer commandBuffer, VkSubpassContents contents);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, VkSubpassContents, void> CmdNextSubpass;
        /// <summary>        
        /// void vkCmdEndRenderPass(VkCommandBuffer commandBuffer);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, void> CmdEndRenderPass;
        /// <summary>        
        /// void vkCmdExecuteCommands(VkCommandBuffer commandBuffer, uint32_t commandBufferCount, const VkCommandBuffer* pCommandBuffers);
        /// </summary>
        public static readonly unsafe delegate*<VkCommandBuffer, uint, ref VkCommandBuffer, void> CmdExecuteCommands;


        public static readonly unsafe delegate*<ref uint, VkResult> EnumerateInstanceVersion;
        public static readonly unsafe delegate*<VkDevice, uint, ref VkBindBufferMemoryInfo, VkResult> BindBufferMemory2;
        public static readonly unsafe delegate*<VkDevice, uint, ref VkBindImageMemoryInfo, VkResult> BindImageMemory2;
        public static readonly unsafe delegate*<VkDevice, uint, uint, uint, ref uint, void> GetDeviceGroupPeerMemoryFeatures;
        public static readonly unsafe delegate*<VkCommandBuffer, uint, void> CmdSetDeviceMask;
        public static readonly unsafe delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void> CmdDispatchBase;
        internal static readonly unsafe delegate*<VkInstance, out uint, VkPhysicalDeviceGroupProperties*, VkResult> _EnumeratePhysicalDeviceGroups;
        public static readonly unsafe delegate*<VkDevice, ref VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> GetImageMemoryRequirements2;
        public static readonly unsafe delegate*<VkDevice, ref VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> GetBufferMemoryRequirements2;
        internal static readonly unsafe delegate*<VkDevice, ref VkImageSparseMemoryRequirementsInfo2, out uint, VkSparseImageMemoryRequirements2*, void> _GetImageSparseMemoryRequirements2;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceFeatures2, void> GetPhysicalDeviceFeatures2;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceProperties2, void> GetPhysicalDeviceProperties2;
        public static readonly unsafe delegate*<VkPhysicalDevice, VkFormat, ref VkFormatProperties2, void> GetPhysicalDeviceFormatProperties2;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult> GetPhysicalDeviceImageFormatProperties2;
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties2*, void> _GetPhysicalDeviceQueueFamilyProperties2;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceMemoryProperties2, void> GetPhysicalDeviceMemoryProperties2;
        internal static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2, out uint, VkSparseImageFormatProperties2*, void> _GetPhysicalDeviceSparseImageFormatProperties2;
        public static readonly unsafe delegate*<VkDevice, VkCommandPool, uint, void> TrimCommandPool;
        public static readonly unsafe delegate*<VkDevice, ref VkDeviceQueueInfo2, ref VkQueue, void> GetDeviceQueue2;
        public static readonly unsafe delegate*<VkDevice, ref VkSamplerYcbcrConversionCreateInfo, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult> CreateSamplerYcbcrConversion;
        public static readonly unsafe delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> DestroySamplerYcbcrConversion;
        public static readonly unsafe delegate*<VkDevice, ref VkDescriptorUpdateTemplateCreateInfo, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult> CreateDescriptorUpdateTemplate;
        public static readonly unsafe delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> DestroyDescriptorUpdateTemplate;
        public static readonly unsafe delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, nint, void> UpdateDescriptorSetWithTemplate;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void> GetPhysicalDeviceExternalBufferProperties;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void> GetPhysicalDeviceExternalFenceProperties;
        public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void> GetPhysicalDeviceExternalSemaphoreProperties;
        public static readonly unsafe delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void> GetDescriptorSetLayoutSupport;

        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> CmdDrawIndirectCount;
        public static readonly unsafe delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void> CmdDrawIndexedIndirectCount;
        public static readonly unsafe delegate*<VkDevice, ref VkRenderPassCreateInfo2, VkAllocationCallbacks*, out VkRenderPass, VkResult> CreateRenderPass2;
        public static readonly unsafe delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, ref VkSubpassBeginInfo, void> CmdBeginRenderPass2;
        public static readonly unsafe delegate*<VkCommandBuffer, ref VkSubpassBeginInfo, ref VkSubpassEndInfo, void> CmdNextSubpass2;
        public static readonly unsafe delegate*<VkCommandBuffer, ref VkSubpassEndInfo, void> CmdEndRenderPass2;
        public static readonly unsafe delegate*<VkDevice, VkQueryPool, uint, uint, void> ResetQueryPool;
        public static readonly unsafe delegate*<VkDevice, VkSemaphore, ref ulong, VkResult> GetSemaphoreCounterValue;
        public static readonly unsafe delegate*<VkDevice, ref VkSemaphoreWaitInfo, ulong, VkResult> WaitSemaphores;
        public static readonly unsafe delegate*<VkDevice, ref VkSemaphoreSignalInfo, VkResult> SignalSemaphore;
        public static readonly unsafe delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong> GetBufferDeviceAddress;
        public static readonly unsafe delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong> GetBufferOpaqueCaptureAddress;
        public static readonly unsafe delegate*<VkDevice, ref VkDeviceMemoryOpaqueCaptureAddressInfo, ulong> GetDeviceMemoryOpaqueCaptureAddress;

        public static readonly unsafe   delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>                  DestroySurfaceKHR;
        public static readonly unsafe   delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, out uint, VkResult>                GetPhysicalDeviceSurfaceSupportKHR;
        public static readonly unsafe   delegate*<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult>  GetPhysicalDeviceSurfaceCapabilitiesKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult> _GetPhysicalDeviceSurfaceFormatsKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkPresentModeKHR*, VkResult>   _GetPhysicalDeviceSurfacePresentModesKHR;

        public static readonly unsafe   delegate*<VkDevice, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> CreateSwapchainKHR;
        public static readonly unsafe   delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>                                       DestroySwapchainKHR;
        internal static readonly unsafe delegate*<VkDevice, VkSwapchainKHR, out uint, VkImage*, VkResult>                                       _GetSwapchainImagesKHR;
        public static readonly unsafe   delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult>                    AcquireNextImageKHR;
        internal static readonly unsafe delegate*<VkQueue, ref VkPresentInfoKHR, VkResult>                                                      QueuePresentKHR;
        public static readonly unsafe   delegate*<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>                                  GetDeviceGroupPresentCapabilitiesKHR;
        public static readonly unsafe   delegate*<VkDevice, VkSurfaceKHR, ref uint, VkResult>                                                   GetDeviceGroupSurfacePresentModesKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkRect2D*, VkResult>                                _GetPhysicalDevicePresentRectanglesKHR;
        public static readonly unsafe   delegate*<VkDevice, ref VkAcquireNextImageInfoKHR, ref uint, VkResult>                                  AcquireNextImage2KHR;

        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPropertiesKHR*, VkResult> _GetPhysicalDeviceDisplayPropertiesKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPlanePropertiesKHR*, VkResult> _GetPhysicalDeviceDisplayPlanePropertiesKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, uint, out uint, VkDisplayKHR*, VkResult> _GetDisplayPlaneSupportedDisplaysKHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModePropertiesKHR*, VkResult> _GetDisplayModePropertiesKHR;
        public static readonly unsafe   delegate*<VkPhysicalDevice, VkDisplayKHR, ref VkDisplayModeCreateInfoKHR, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult> CreateDisplayModeKHR;
        public static readonly unsafe   delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, ref VkDisplayPlaneCapabilitiesKHR, VkResult> GetDisplayPlaneCapabilitiesKHR;
        public static readonly unsafe   delegate*<VkInstance, ref VkDisplaySurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> CreateDisplayPlaneSurfaceKHR;
        public static readonly unsafe   delegate*<VkDevice, uint, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> CreateSharedSwapchainsKHR;

        public static readonly unsafe   delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, ref VkSurfaceCapabilities2KHR, VkResult>  GetPhysicalDeviceSurfaceCapabilities2KHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkSurfaceFormat2KHR*, VkResult> _GetPhysicalDeviceSurfaceFormats2KHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayProperties2KHR*, VkResult>                                  _GetPhysicalDeviceDisplayProperties2KHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPlaneProperties2KHR*, VkResult>                             _GetPhysicalDeviceDisplayPlaneProperties2KHR;
        internal static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModeProperties2KHR*, VkResult>                _GetDisplayModeProperties2KHR;
        public static readonly unsafe   delegate*<VkPhysicalDevice, ref VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>      GetDisplayPlaneCapabilities2KHR;

    }
}
