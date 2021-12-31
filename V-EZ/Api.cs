using System;
using System.Diagnostics.CodeAnalysis;
using Vulkan;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace VEZ
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class Api
    {

        public static unsafe T ManagedCombine<T>(delegate* managed<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe T CDeclCombine<T>(delegate* unmanaged[Cdecl]<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe T StdcallCombine<T>(delegate* unmanaged[Stdcall]<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe T FastcallCombine<T>(delegate* unmanaged[Fastcall]<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe T ThiscallCombine<T>(delegate* unmanaged[Thiscall]<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe T UnmanagedCombine<T>(delegate* unmanaged<T, T, T> combinator, T left, T right)
        {
            return combinator(left, right);
        }

        public static unsafe delegate* <nint, out uint, VkExtensionProperties*, VkResult>                                                                                           vezEnumerateInstanceExtensionProperties;
        public static unsafe delegate* <out uint,  VkLayerProperties*, VkResult>                                                                                                    vezEnumerateInstanceLayerProperties;
        public static unsafe delegate* <ref VezInstanceCreateInfo, ref VkInstance, VkResult>                                                                                         vezCreateInstance;
        public static unsafe delegate* <VkInstance, void>                                                                                                                           vezDestroyInstance;
        public static unsafe delegate* <VkInstance, out uint,  VkPhysicalDevice*, VkResult>                                                                                         vezEnumeratePhysicalDevices;
        public static unsafe delegate* <VkPhysicalDevice, ref VkPhysicalDeviceProperties, void>                                                                                     vezGetPhysicalDeviceProperties;
        public static unsafe delegate* <VkPhysicalDevice, ref VkPhysicalDeviceFeatures, void>                                                                                       vezGetPhysicalDeviceFeatures;
        public static unsafe delegate* <VkPhysicalDevice, VkFormat, ref VkFormatProperties, void>                                                                                   vezGetPhysicalDeviceFormatProperties;
        public static unsafe delegate* <VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, ref VkImageFormatProperties, VkResult> vezGetPhysicalDeviceImageFormatProperties;
        public static unsafe delegate* <VkPhysicalDevice, out uint, VkQueueFamilyProperties*, void>                                                                             vezGetPhysicalDeviceQueueFamilyProperties;
        public static unsafe delegate* <VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult>                                                                vezGetPhysicalDeviceSurfaceFormats;
        public static unsafe delegate* <VkPhysicalDevice, uint, VkSurfaceKHR, ref uint, VkResult>                                                                                   vezGetPhysicalDevicePresentSupport;
        public static unsafe delegate* <VkPhysicalDevice, nint, out uint, VkExtensionProperties*, VkResult>                                                                     vezEnumerateDeviceExtensionProperties;
        public static unsafe delegate* <VkPhysicalDevice, out uint, VkLayerProperties*, VkResult>                                                                               vezEnumerateDeviceLayerProperties;
        public static unsafe delegate* <VkPhysicalDevice, ref VezDeviceCreateInfo, ref VkDevice, VkResult>                                                                           vezCreateDevice;
        public static unsafe delegate* <VkDevice, void>                                                                                                                             vezDestroyDevice;
        public static unsafe delegate* <VkDevice, VkResult>                                                                                                                         vezDeviceWaitIdle;
        public static unsafe delegate* <VkDevice, uint, uint, ref VkQueue, void>                                                                                                    vezGetDeviceQueue;
        public static unsafe delegate* <VkDevice, uint, ref VkQueue, void>                                                                                                          vezGetDeviceGraphicsQueue;
        public static unsafe delegate* <VkDevice, uint, ref VkQueue, void>                                                                                                          vezGetDeviceComputeQueue;
        public static unsafe delegate* <VkDevice, uint, ref VkQueue, void>                                                                                                          vezGetDeviceTransferQueue;
        public static unsafe delegate* <VkDevice, ref VezSwapchainCreateInfo, ref VezSwapchain, VkResult>                                                                            vezCreateSwapchain;
        public static unsafe delegate* <VkDevice, VezSwapchain, void>                                                                                                               vezDestroySwapchain;
        public static unsafe delegate* <VezSwapchain, ref VkSurfaceFormatKHR, void>                                                                                                 vezGetSwapchainSurfaceFormat;
        public static unsafe delegate* <VezSwapchain, uint, VkResult>                                                                                                               vezSwapchainSetVSync;
        public static unsafe delegate* <VkQueue, uint, ref VezSubmitInfo, ref VkFence, VkResult>                                                                                     vezQueueSubmit;
        public static unsafe delegate* <VkQueue, ref VezPresentInfo, VkResult>                                                                                                       vezQueuePresent;
        public static unsafe delegate* <VkQueue, VkResult>                                                                                                                          vezQueueWaitIdle;
        public static unsafe delegate* <VkDevice, VkFence, void>                                                                                                                    vezDestroyFence;
        public static unsafe delegate* <VkDevice, VkFence, VkResult>                                                                                                                vezGetFenceStatus;
        public static unsafe delegate* <VkDevice, uint, ref VkFence, uint, ulong, VkResult>                                                                                         vezWaitForFences;
        public static unsafe delegate* <VkDevice, VkSemaphore, void>                                                                                                                vezDestroySemaphore;
        public static unsafe delegate* <VkDevice, ref VkEvent, VkResult>                                                                                                            vezCreateEvent;
        public static unsafe delegate* <VkDevice, VkEvent, void>                                                                                                                    vezDestroyEvent;
        public static unsafe delegate* <VkDevice, VkEvent, VkResult>                                                                                                                vezGetEventStatus;
        public static unsafe delegate* <VkDevice, VkEvent, VkResult>                                                                                                                vezSetEvent;
        public static unsafe delegate* <VkDevice, VkEvent, VkResult>                                                                                                                vezResetEvent;
        public static unsafe delegate* <VkDevice, ref VezQueryPoolCreateInfo, ref VkQueryPool, VkResult>                                                                             vezCreateQueryPool;
        public static unsafe delegate* <VkDevice, VkQueryPool, void>                                                                                                                vezDestroyQueryPool;
        public static unsafe delegate* <VkDevice, VkQueryPool, uint, uint, size_t, nint, ulong, VkQueryResultFlagBits, VkResult>                                                    vezGetQueryPoolResults;
        public static unsafe delegate* <VkDevice, ref VezShaderModuleCreateInfo, ref VkShaderModule, VkResult>                                                                       vezCreateShaderModule;
        public static unsafe delegate* <VkDevice, VkShaderModule, void>                                                                                                             vezDestroyShaderModule;
        public static unsafe delegate* <VkShaderModule, ref uint, nint, void>                                                                                                       vezGetShaderModuleInfoLog;
        public static unsafe delegate* <VkShaderModule, ref uint, ref uint, VkResult>                                                                                               vezGetShaderModuleBinary;
        public static unsafe delegate* <VkDevice, ref VezGraphicsPipelineCreateInfo, ref VezPipeline, VkResult>                                                                      vezCreateGraphicsPipeline;
        public static unsafe delegate* <VkDevice, ref VezComputePipelineCreateInfo, ref VezPipeline, VkResult>                                                                       vezCreateComputePipeline;
        public static unsafe delegate* <VkDevice, VezPipeline, void>                                                                                                                vezDestroyPipeline;
        public static unsafe delegate* <VezPipeline, out uint, VezPipelineResource*, VkResult>                                                                                   vezEnumeratePipelineResources;
        public static unsafe delegate* <VezPipeline, nint, ref VezPipelineResource, VkResult>                                                                                       vezGetPipelineResource;
        public static unsafe delegate* <VkDevice, ref VezVertexInputFormatCreateInfo, ref VezVertexInputFormat, VkResult>                                                            vezCreateVertexInputFormat;
        public static unsafe delegate* <VkDevice, VezVertexInputFormat, void>                                                                                                       vezDestroyVertexInputFormat;
        public static unsafe delegate* <VkDevice, ref VezSamplerCreateInfo, ref VkSampler, VkResult>                                                                                 vezCreateSampler;
        public static unsafe delegate* <VkDevice, VkSampler, void>                                                                                                                  vezDestroySampler;
        public static unsafe delegate* <VkDevice, VezMemoryFlags, ref VezBufferCreateInfo, ref VkBuffer, VkResult>                                                                   vezCreateBuffer;
        public static unsafe delegate* <VkDevice, VkBuffer, void>                                                                                                                   vezDestroyBuffer;
        public static unsafe delegate* <VkDevice, VkBuffer, ulong, ulong, nint, VkResult>                                                                                           vezBufferSubData;
        public static unsafe delegate* <VkDevice, VkBuffer, ulong, ulong, out nint, VkResult>                                                                                       vezMapBuffer;
        public static unsafe delegate* <VkDevice, VkBuffer, void>                                                                                                                   vezUnmapBuffer;
        public static unsafe delegate* <VkDevice, uint, ref VezMappedBufferRange, VkResult>                                                                                          vezFlushMappedBufferRanges;
        public static unsafe delegate* <VkDevice, uint, ref VezMappedBufferRange, VkResult>                                                                                          vezInvalidateMappedBufferRanges;
        public static unsafe delegate* <VkDevice, ref VezBufferViewCreateInfo, ref VkBufferView, VkResult>                                                                           vezCreateBufferView;
        public static unsafe delegate* <VkDevice, VkBufferView, void>                                                                                                               vezDestroyBufferView;
        public static unsafe delegate* <VkDevice, VezMemoryFlags, ref VezImageCreateInfo, ref VkImage, VkResult>                                                                     vezCreateImage;
        public static unsafe delegate* <VkDevice, VkImage, void>                                                                                                                    vezDestroyImage;
        public static unsafe delegate* <VkDevice, VkImage, ref VezImageSubDataInfo, nint, VkResult>                                                                                  vezImageSubData;
        public static unsafe delegate* <VkDevice, ref VezImageViewCreateInfo, ref VkImageView, VkResult>                                                                             vezCreateImageView;
        public static unsafe delegate* <VkDevice, VkImageView, void>                                                                                                                vezDestroyImageView;
        public static unsafe delegate* <VkDevice, ref VezFramebufferCreateInfo, ref VezFramebuffer, VkResult>                                                                        vezCreateFramebuffer;
        public static unsafe delegate* <VkDevice, VezFramebuffer, void>                                                                                                             vezDestroyFramebuffer;
        public static unsafe delegate* <VkDevice, ref VezCommandBufferAllocateInfo, ref VkCommandBuffer, VkResult>                                                                   vezAllocateCommandBuffers;
        public static unsafe delegate* <VkDevice, uint, ref VkCommandBuffer, void>                                                                                                  vezFreeCommandBuffers;
        public static unsafe delegate* <VkCommandBuffer, VkCommandBufferUsageFlagBits, VkResult>                                                                                    vezBeginCommandBuffer;
        public static unsafe delegate* <VkResult>                                                                                                                                   vezEndCommandBuffer;
        public static unsafe delegate* <VkCommandBuffer, VkResult>                                                                                                                  vezResetCommandBuffer;
        public static unsafe delegate* <ref VezRenderPassBeginInfo, void>                                                                                                            vezCmdBeginRenderPass;
        public static unsafe delegate* <void>                                                                                                                                       vezCmdNextSubpass;
        public static unsafe delegate* <void>                                                                                                                                       vezCmdEndRenderPass;
        public static unsafe delegate* <VezPipeline, void>                                                                                                                          vezCmdBindPipeline;
        public static unsafe delegate* <uint, uint, nint, void>                                                                                                                     vezCmdPushConstants;
        public static unsafe delegate* <VkBuffer, ulong, ulong, uint, uint, uint, void>                                                                                             vezCmdBindBuffer;
        public static unsafe delegate* <VkBufferView, uint, uint, uint, void>                                                                                                       vezCmdBindBufferView;
        public static unsafe delegate* <VkImageView, VkSampler, uint, uint, uint, void>                                                                                             vezCmdBindImageView;
        public static unsafe delegate* <VkSampler, uint, uint, uint, void>                                                                                                          vezCmdBindSampler;
        public static unsafe delegate* <uint, uint, ref VkBuffer, ref ulong, void>                                                                                                  vezCmdBindVertexBuffers;
        public static unsafe delegate* <VkBuffer, ulong, VkIndexType, void>                                                                                                         vezCmdBindIndexBuffer;
        public static unsafe delegate* <VezVertexInputFormat, void>                                                                                                                 vezCmdSetVertexInputFormat;
        public static unsafe delegate* <uint, void>                                                                                                                                 vezCmdSetViewportState;
        public static unsafe delegate* <ref VezInputAssemblyState, void>                                                                                                             vezCmdSetInputAssemblyState;
        public static unsafe delegate* <ref VezRasterizationState, void>                                                                                                             vezCmdSetRasterizationState;
        public static unsafe delegate* <ref VezMultisampleState, void>                                                                                                               vezCmdSetMultisampleState;
        public static unsafe delegate* <ref VezDepthStencilState, void>                                                                                                              vezCmdSetDepthStencilState;
        public static unsafe delegate* <ref VezColorBlendState, void>                                                                                                                vezCmdSetColorBlendState;
        public static unsafe delegate* <uint, uint, ref VkViewport, void>                                                                                                            vezCmdSetViewport;
        public static unsafe delegate* <uint, uint, ref VkRect2D, void>                                                                                                              vezCmdSetScissor;
        public static unsafe delegate* <float, void>                                                                                                                                vezCmdSetLineWidth;
        public static unsafe delegate* <float, float, float, void>                                                                                                                  vezCmdSetDepthBias;
        public static unsafe delegate* <float[], void>                                                                                                                              vezCmdSetBlendConstants;
        public static unsafe delegate* <float, float, void>                                                                                                                         vezCmdSetDepthBounds;
        public static unsafe delegate* <VkStencilFaceFlagBits, uint, void>                                                                                                          vezCmdSetStencilCompareMask;
        public static unsafe delegate* <VkStencilFaceFlagBits, uint, void>                                                                                                          vezCmdSetStencilWriteMask;
        public static unsafe delegate* <VkStencilFaceFlagBits, uint, void>                                                                                                          vezCmdSetStencilReference;
        public static unsafe delegate* <uint, uint, uint, uint, void>                                                                                                               vezCmdDraw;
        public static unsafe delegate* <uint, uint, uint, int, uint, void>                                                                                                          vezCmdDrawIndexed;
        public static unsafe delegate* <VkBuffer, ulong, uint, uint, void>                                                                                                          vezCmdDrawIndirect;
        public static unsafe delegate* <VkBuffer, ulong, uint, uint, void>                                                                                                          vezCmdDrawIndexedIndirect;
        public static unsafe delegate* <uint, uint, uint, void>                                                                                                                     vezCmdDispatch;
        public static unsafe delegate* <VkBuffer, ulong, void>                                                                                                                      vezCmdDispatchIndirect;
        public static unsafe delegate* <VkBuffer, VkBuffer, uint, ref VezBufferCopy, void>                                                                                           vezCmdCopyBuffer;
        public static unsafe delegate* <VkImage, VkImage, uint, ref VezImageCopy, void>                                                                                              vezCmdCopyImage;
        public static unsafe delegate* <VkImage, VkImage, uint, ref VezImageBlit, VkFilter, void>                                                                                    vezCmdBlitImage;
        public static unsafe delegate* <VkBuffer, VkImage, uint, ref VezBufferImageCopy, void>                                                                                       vezCmdCopyBufferToImage;
        public static unsafe delegate* <VkImage, VkBuffer, uint, ref VezBufferImageCopy, void>                                                                                       vezCmdCopyImageToBuffer;
        public static unsafe delegate* <VkBuffer, ulong, ulong, nint, void>                                                                                                         vezCmdUpdateBuffer;
        public static unsafe delegate* <VkBuffer, ulong, ulong, uint, void>                                                                                                         vezCmdFillBuffer;
        public static unsafe delegate* <VkImage, ref VkClearColorValue, uint, ref VezImageSubresourceRange, void>                                                                     vezCmdClearColorImage;
        public static unsafe delegate* <VkImage, ref VkClearDepthStencilValue, uint, ref VezImageSubresourceRange, void>                                                              vezCmdClearDepthStencilImage;
        public static unsafe delegate* <uint, ref VezClearAttachment, uint, ref VkClearRect, void>                                                                                    vezCmdClearAttachments;
        public static unsafe delegate* <VkImage, VkImage, uint, ref VezImageResolve, void>                                                                                           vezCmdResolveImage;
        public static unsafe delegate* <VkEvent, VkPipelineStageFlagBits, void>                                                                                                     vezCmdSetEvent;
        public static unsafe delegate* <VkEvent, VkPipelineStageFlagBits, void>                                                                                                     vezCmdResetEvent;
        public static unsafe delegate* <VkDevice, VkImage, VkFormat, VkExtent3D, VkSampleCountFlagBits, VkImageLayout, VkResult>                                                    vezImportVkImage;
        public static unsafe delegate* <VkDevice, VkImage, VkResult>                                                                                                                vezRemoveImportedVkImage;
        public static unsafe delegate* <VkDevice, VkImage, ref VkImageLayout, VkResult>                                                                                             vezGetImageLayout;
    }
}
