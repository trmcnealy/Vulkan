using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public readonly partial struct VkDevice
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe nint GetDeviceProcAddr(utf8string pName)
        {
            return Api.GetDeviceProcAddr(this, pName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkCommandBuffer[] AllocateCommandBuffers(ref VkCommandBufferAllocateInfo pAllocateInfo)
        {
            return Api.AllocateCommandBuffers(this, ref pAllocateInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkDescriptorSet[] AllocateDescriptorSets(ref VkDescriptorSetAllocateInfo pAllocateInfo)
        {
            return Api.AllocateDescriptorSets(this, ref pAllocateInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkDeviceMemory AllocateMemory(ref VkMemoryAllocateInfo pAllocateInfo,
                                                    VkAllocationCallbacks*   pAllocator)
        {
            Api.IfFailed(Api.AllocateMemory(this, ref pAllocateInfo, pAllocator, out VkDeviceMemory pMemory));

            return pMemory;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult BindBufferMemory(VkBuffer       buffer,
                                                VkDeviceMemory memory,
                                                uint           memoryOffset)
        {
            return Api.BindBufferMemory(this, buffer, memory, memoryOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult BindImageMemory(VkImage        image,
                                               VkDeviceMemory memory,
                                               uint           memoryOffset)
        {
            return Api.BindImageMemory(this, image, memory, memoryOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkBuffer CreateBuffer(ref VkBufferCreateInfo pCreateInfo,
                                            VkAllocationCallbacks* pAllocator)
        {
            Api.IfFailed(Api.CreateBuffer(this, ref pCreateInfo, pAllocator, out VkBuffer pBuffer));

            return pBuffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkBufferView CreateBufferView(ref VkBufferViewCreateInfo pCreateInfo,
                                                    VkAllocationCallbacks*     pAllocator)
        {
            Api.IfFailed(Api.CreateBufferView(this, ref pCreateInfo, pAllocator, out VkBufferView pView));

            return pView;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkCommandPool CreateCommandPool(ref VkCommandPoolCreateInfo pCreateInfo,
                                                      VkAllocationCallbacks*      pAllocator)
        {
            Api.IfFailed(Api.CreateCommandPool(this, ref pCreateInfo, pAllocator, out VkCommandPool pCommandPool));

            return pCommandPool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkPipeline CreateComputePipeline(VkPipelineCache             pipelineCache,
                                                       VkComputePipelineCreateInfo pCreateInfos,
                                                       VkAllocationCallbacks* pAllocator)
        {
            return Api.CreateComputePipelines(this, pipelineCache, new []{pCreateInfos}, pAllocator).First();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkPipeline[] CreateComputePipelines(VkPipelineCache               pipelineCache,
                                                          VkComputePipelineCreateInfo[] pCreateInfos,
                                                          VkAllocationCallbacks*        pAllocator)
        {
            return Api.CreateComputePipelines(this, pipelineCache, pCreateInfos, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkDescriptorPool CreateDescriptorPool(ref VkDescriptorPoolCreateInfo pCreateInfo,
                                                            VkAllocationCallbacks*         pAllocator)
        {
            Api.IfFailed(Api.CreateDescriptorPool(this, ref pCreateInfo, pAllocator, out VkDescriptorPool pDescriptorPool));

            return pDescriptorPool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkDescriptorSetLayout CreateDescriptorSetLayout(ref VkDescriptorSetLayoutCreateInfo pCreateInfo,
                                                                      VkAllocationCallbacks*              pAllocator)
        {
            Api.IfFailed(Api.CreateDescriptorSetLayout(this, ref pCreateInfo, pAllocator, out VkDescriptorSetLayout pSetLayout));

            return pSetLayout;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkEvent CreateEvent(ref VkEventCreateInfo  pCreateInfo,
                                          VkAllocationCallbacks* pAllocator)
        {
            Api.IfFailed(Api.CreateEvent(this, ref pCreateInfo, pAllocator, out VkEvent pEvent));

            return pEvent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkFence CreateFence(ref VkFenceCreateInfo  pCreateInfo,
                                          VkAllocationCallbacks* pAllocator)
        {
            Api.IfFailed(Api.CreateFence(this, ref pCreateInfo, pAllocator, out VkFence pFence));

            return pFence;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkFramebuffer CreateFramebuffer(ref VkFramebufferCreateInfo pCreateInfo,
                                                      VkAllocationCallbacks*      pAllocator)
        {
            Api.IfFailed(Api.CreateFramebuffer(this, ref pCreateInfo, pAllocator, out VkFramebuffer pFramebuffer));

            return pFramebuffer;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkPipeline[] CreateGraphicsPipelines(VkPipelineCache                pipelineCache,
                                                           VkGraphicsPipelineCreateInfo[] pCreateInfos,
                                                           VkAllocationCallbacks*         pAllocator)
        {
            return Api.CreateGraphicsPipelines(this, pipelineCache, pCreateInfos, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkImage CreateImage(ref VkImageCreateInfo  pCreateInfo,
                                          VkAllocationCallbacks* pAllocator)
        {
            Api.IfFailed(Api.CreateImage(this, ref pCreateInfo, pAllocator, out VkImage pImage));

            return pImage;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkImageView CreateImageView(ref VkImageViewCreateInfo pCreateInfo,
                                                  VkAllocationCallbacks*    pAllocator)
        {
            Api.IfFailed(Api.CreateImageView(this, ref pCreateInfo, pAllocator, out VkImageView pView));

            return pView;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkPipelineCache CreatePipelineCache(ref VkPipelineCacheCreateInfo pCreateInfo,
                                                          VkAllocationCallbacks*        pAllocator)
        {
            Api.IfFailed(Api.CreatePipelineCache(this, ref pCreateInfo, pAllocator, out VkPipelineCache pPipelineCache));

            return pPipelineCache;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkPipelineLayout CreatePipelineLayout(ref VkPipelineLayoutCreateInfo pCreateInfo,
                                                            VkAllocationCallbacks*         pAllocator)
        {
            Api.IfFailed(Api.CreatePipelineLayout(this, ref pCreateInfo, pAllocator, out VkPipelineLayout pPipelineLayout));

            return pPipelineLayout;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkQueryPool CreateQueryPool(ref VkQueryPoolCreateInfo pCreateInfo,
                                                  VkAllocationCallbacks*    pAllocator)
        {
            Api.IfFailed(Api.CreateQueryPool(this, ref pCreateInfo, pAllocator, out VkQueryPool pQueryPool));

            return pQueryPool;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkRenderPass CreateRenderPass(ref VkRenderPassCreateInfo pCreateInfo,
                                                    VkAllocationCallbacks*     pAllocator)
        {
            Api.IfFailed(Api.CreateRenderPass(this, ref pCreateInfo, pAllocator, out VkRenderPass pRenderPass));

            return pRenderPass;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkSampler CreateSampler(ref VkSamplerCreateInfo pCreateInfo,
                                              VkAllocationCallbacks*  pAllocator)
        {
            Api.IfFailed(Api.CreateSampler(this, ref pCreateInfo, pAllocator, out VkSampler pSampler));

            return pSampler;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkSemaphore CreateSemaphore(ref VkSemaphoreCreateInfo pCreateInfo,
                                                  VkAllocationCallbacks*    pAllocator)
        {
            Api.IfFailed(Api.CreateSemaphore(this, ref pCreateInfo, pAllocator, out VkSemaphore pSemaphore));

            return pSemaphore;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkShaderModule CreateShaderModule(ref VkShaderModuleCreateInfo pCreateInfo,
                                                        VkAllocationCallbacks*       pAllocator)
        {
            Api.IfFailed(Api.CreateShaderModule(this, ref pCreateInfo, pAllocator, out VkShaderModule pShaderModule));

            return pShaderModule;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult DeviceWaitIdle()
        {
            return Api.DeviceWaitIdle(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult GetEventStatus(VkEvent @event)
        {
            return Api.GetEventStatus(this, @event);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult GetFenceStatus(VkFence fence)
        {
            return Api.GetFenceStatus(this, fence);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult GetPipelineCacheData(VkPipelineCache pipelineCache,
                                                    ref UIntPtr     pDataSize,
                                                    nint            pData)
        {
            return Api.GetPipelineCacheData(this, pipelineCache, ref pDataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult GetQueryPoolResults(VkQueryPool           queryPool,
                                                   uint                  firstQuery,
                                                   uint                  querCount,
                                                   nuint                 dataSize,
                                                   nint                  pData,
                                                   uint                  stride,
                                                   VkQueryResultFlagBits flags)
        {
            return Api.GetQueryPoolResults(this, queryPool, firstQuery, querCount, dataSize, pData, stride, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe nint MapMemory(VkDeviceMemory memory,
                                     ulong          offset,
                                     ulong          size,
                                     uint           flags)
        {
            Api.IfFailed(Api.MapMemory(this, memory, offset, size, flags, out nint ppData));
            return ppData;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult ResetCommandPool(VkCommandPool              commandPool,
                                                VkCommandPoolResetFlagBits flags)
        {
            return Api.ResetCommandPool(this, commandPool, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult ResetDescriptorPool(VkDescriptorPool descriptorPool,
                                                   uint             flags)
        {
            return Api.ResetDescriptorPool(this, descriptorPool, flags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult ResetEvent(VkEvent @event)
        {
            return Api.ResetEvent(this, @event);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkResult SetEvent(VkEvent @event)
        {
            return Api.SetEvent(this, @event);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkQueue GetDeviceQueue(uint queueFamilyIndex,
                                             uint queueIndex)
        {
            Api.GetDeviceQueue(this, queueFamilyIndex, queueIndex, out VkQueue pQueue);

            return pQueue;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkMemoryRequirements GetBufferMemoryRequirements(VkBuffer buffer)
        {
            Api.GetBufferMemoryRequirements(this, buffer, out VkMemoryRequirements pMemoryRequirements);

            return pMemoryRequirements;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe ulong GetDeviceMemoryCommitment(VkDeviceMemory memory)
        {
            Api.GetDeviceMemoryCommitment(this, memory, out ulong pCommittedMemoryInBytes);

            return pCommittedMemoryInBytes;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkMemoryRequirements GetImageMemoryRequirements(VkImage image)
        {
            Api.GetImageMemoryRequirements(this, image, out VkMemoryRequirements pMemoryRequirements);

            return pMemoryRequirements;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkSparseImageMemoryRequirements[] GetImageSparseMemoryRequirements(VkImage image)
        {
            return Api.GetImageSparseMemoryRequirements(this, image);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkSubresourceLayout GetImageSubresourceLayout(VkImage                image,
                                                                    ref VkImageSubresource pSubresource)
        {
            Api.GetImageSubresourceLayout(this, image, ref pSubresource, out VkSubresourceLayout pLayout);

            return pLayout;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe VkExtent2D GetRenderAreaGranularity(VkRenderPass renderPass)
        {
            Api.GetRenderAreaGranularity(this, renderPass, out VkExtent2D pGranularity);

            return pGranularity;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void WaitForFences(VkFence[] pFences,
                                         Bool      waitAll,
                                         ulong     timeout)
        {
            Api.WaitForFences(this, pFences, waitAll, timeout);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void MergePipelineCaches(VkPipelineCache   dstCache,
                                               VkPipelineCache[] pSrcCaches)
        {
            Api.MergePipelineCaches(this, dstCache, pSrcCaches);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void ResetFences(VkFence[] pFences)
        {
            Api.ResetFences(this, pFences);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void InvalidateMappedMemoryRanges(VkMappedMemoryRange[] pMemoryRanges)
        {
            Api.InvalidateMappedMemoryRanges(this, pMemoryRanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void FreeDescriptorSets(VkDescriptorPool  descriptorPool,
                                              VkDescriptorSet[] pDescriptorSets)
        {
            Api.FreeDescriptorSets(this, descriptorPool, pDescriptorSets);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void FlushMappedMemoryRanges(VkMappedMemoryRange[] pMemoryRanges)
        {
            Api.FlushMappedMemoryRanges(this, pMemoryRanges);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyBuffer(VkBuffer               buffer,
                                         VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyBuffer(this, buffer, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyBufferView(VkBufferView           bufferView,
                                             VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyBufferView(this, bufferView, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyCommandPool(VkCommandPool          commandPool,
                                              VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyCommandPool(this, commandPool, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyDescriptorPool(VkDescriptorPool       descriptorPool,
                                                 VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyDescriptorPool(this, descriptorPool, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyDescriptorSetLayout(VkDescriptorSetLayout  descriptorSetLayout,
                                                      VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyDescriptorSetLayout(this, descriptorSetLayout, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyDevice(VkAllocationCallbacks* pAllocator) { Api.DestroyDevice(this, pAllocator); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyEvent(VkEvent                @event,
                                        VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyEvent(this, @event, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyFence(VkFence                fence,
                                        VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyFence(this, fence, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyFramebuffer(VkFramebuffer          framebuffer,
                                              VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyFramebuffer(this, framebuffer, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyImage(VkImage                image,
                                        VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyImage(this, image, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyImageView(VkImageView            imageView,
                                            VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyImageView(this, imageView, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyPipeline(VkPipeline             pipeline,
                                           VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyPipeline(this, pipeline, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyPipelineCache(VkPipelineCache        pipelineCache,
                                                VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyPipelineCache(this, pipelineCache, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyPipelineLayout(VkPipelineLayout       pipelineLayout,
                                                 VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyPipelineLayout(this, pipelineLayout, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyQueryPool(VkQueryPool            queryPool,
                                            VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyQueryPool(this, queryPool, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyRenderPass(VkRenderPass           renderPass,
                                             VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyRenderPass(this, renderPass, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroySampler(VkSampler              sampler,
                                          VkAllocationCallbacks* pAllocator)
        {
            Api.DestroySampler(this, sampler, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroySemaphore(VkSemaphore            semaphore,
                                            VkAllocationCallbacks* pAllocator)
        {
            Api.DestroySemaphore(this, semaphore, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void DestroyShaderModule(VkShaderModule         shaderModule,
                                               VkAllocationCallbacks* pAllocator)
        {
            Api.DestroyShaderModule(this, shaderModule, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void FreeCommandBuffers(VkCommandPool     commandPool,
                                              VkCommandBuffer[] pCommandBuffers)
        {
            Api.FreeCommandBuffers(this, commandPool, pCommandBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void FreeMemory(VkDeviceMemory         memory,
                                      VkAllocationCallbacks* pAllocator)
        {
            Api.FreeMemory(this, memory, pAllocator);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void UnmapMemory(VkDeviceMemory memory) { Api.UnmapMemory(this, memory); }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public unsafe void UpdateDescriptorSets(VkWriteDescriptorSet[] pDescriptorWrites,
                                                VkCopyDescriptorSet[]  pDescriptorCopies)
        {
            Api.UpdateDescriptorSets(this, pDescriptorWrites, pDescriptorCopies);
        }

        //TODO
        //public static readonly unsafe delegate*<VkDevice, ref VkAcquireNextImageInfoKHR, ref uint, VkResult> AcquireNextImage2KHR;
        //public static readonly unsafe delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong> GetBufferDeviceAddress;
        //public static readonly unsafe delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong> GetBufferOpaqueCaptureAddress;
        //public static readonly unsafe delegate*<VkDevice, ref VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> GetBufferMemoryRequirements2;
        //public static readonly unsafe delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void> GetDescriptorSetLayoutSupport;
        //public static readonly unsafe delegate*<VkDevice, ref VkDescriptorUpdateTemplateCreateInfo, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult> CreateDescriptorUpdateTemplate;
        //public static readonly unsafe delegate*<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult> GetDeviceGroupPresentCapabilitiesKHR;
        //public static readonly unsafe delegate*<VkDevice, ref VkDeviceMemoryOpaqueCaptureAddressInfo, ulong> GetDeviceMemoryOpaqueCaptureAddress;
        //public static readonly unsafe delegate*<VkDevice, ref VkDeviceQueueInfo2, ref VkQueue, void> GetDeviceQueue2;
        //public static readonly unsafe delegate*<VkDevice, ref VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void> GetImageMemoryRequirements2;
        //public static readonly unsafe delegate*<VkDevice, ref VkImageSparseMemoryRequirementsInfo2, out uint, VkSparseImageMemoryRequirements2*, void> GetImageSparseMemoryRequirements2;
        //public static readonly unsafe delegate*<VkDevice, ref VkRenderPassCreateInfo2, VkAllocationCallbacks*, out VkRenderPass, VkResult> CreateRenderPass2;
        //public static readonly unsafe delegate*<VkDevice, ref VkSamplerYcbcrConversionCreateInfo, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult> CreateSamplerYcbcrConversion;
        //public static readonly unsafe delegate*<VkDevice, ref VkSemaphoreSignalInfo, VkResult> SignalSemaphore;
        //public static readonly unsafe delegate*<VkDevice, ref VkSemaphoreWaitInfo, ulong, VkResult> WaitSemaphores;
        //public static readonly unsafe delegate*<VkDevice, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> CreateSwapchainKHR;
        //public static readonly unsafe delegate*<VkDevice, uint, ref VkBindBufferMemoryInfo, VkResult> BindBufferMemory2;
        //public static readonly unsafe delegate*<VkDevice, uint, ref VkBindImageMemoryInfo, VkResult> BindImageMemory2;
        //public static readonly unsafe delegate*<VkDevice, uint, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult> CreateSharedSwapchainsKHR;
        //public static readonly unsafe delegate*<VkDevice, uint, uint, uint, ref uint, void> GetDeviceGroupPeerMemoryFeatures;
        //public static readonly unsafe delegate*<VkDevice, VkCommandPool, uint, void> TrimCommandPool;
        //public static readonly unsafe delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, nint, void> UpdateDescriptorSetWithTemplate;
        //public static readonly unsafe delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> DestroyDescriptorUpdateTemplate;
        //public static readonly unsafe delegate*<VkDevice, VkQueryPool, uint, uint, void> ResetQueryPool;
        //public static readonly unsafe delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> DestroySamplerYcbcrConversion;
        //public static readonly unsafe delegate*<VkDevice, VkSemaphore, ref ulong, VkResult> GetSemaphoreCounterValue;
        //public static readonly unsafe delegate*<VkDevice, VkSurfaceKHR, ref uint, VkResult> GetDeviceGroupSurfacePresentModesKHR;
        //public static readonly unsafe delegate*<VkDevice, VkSwapchainKHR, out uint, VkImage*, VkResult> GetSwapchainImagesKHR;
        //public static readonly unsafe delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult> AcquireNextImageKHR;
        //public static readonly unsafe delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void> DestroySwapchainKHR;
    }
}
