// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using Vulkan;


#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace VEZ
{
    public static partial class Api
    {
        public static readonly string DLL_NAME;

        public static readonly nint Handle;

        #region RVAs

        public static readonly nint vezAllocateCommandBuffersOffset                 = 0x0005BB50;
        public static readonly nint vezBeginCommandBufferOffset                     = 0x0005BCC0;
        public static readonly nint vezBufferSubDataOffset                          = 0x0005B6A0;
        public static readonly nint vezCmdBeginRenderPassOffset                     = 0x0005BD80;
        public static readonly nint vezCmdBindBufferOffset                          = 0x0005BE60;
        public static readonly nint vezCmdBindBufferViewOffset                      = 0x0005BF10;
        public static readonly nint vezCmdBindImageViewOffset                       = 0x0005BF60;
        public static readonly nint vezCmdBindIndexBufferOffset                     = 0x0005C140;
        public static readonly nint vezCmdBindPipelineOffset                        = 0x0005BDF0;
        public static readonly nint vezCmdBindSamplerOffset                         = 0x0005BFC0;
        public static readonly nint vezCmdBindVertexBuffersOffset                   = 0x0005C000;
        public static readonly nint vezCmdBlitImageOffset                           = 0x0005C8A0;
        public static readonly nint vezCmdClearAttachmentsOffset                    = 0x0005CC40;
        public static readonly nint vezCmdClearColorImageOffset                     = 0x0005CBA0;
        public static readonly nint vezCmdClearDepthStencilImageOffset              = 0x0005CBF0;
        public static readonly nint vezCmdCopyBufferOffset                          = 0x0005C750;
        public static readonly nint vezCmdCopyBufferToImageOffset                   = 0x0005C910;
        public static readonly nint vezCmdCopyImageOffset                           = 0x0005C840;
        public static readonly nint vezCmdCopyImageToBufferOffset                   = 0x0005C9C0;
        public static readonly nint vezCmdDispatchOffset                            = 0x0005C690;
        public static readonly nint vezCmdDispatchIndirectOffset                    = 0x0005C6D0;
        public static readonly nint vezCmdDrawOffset                                = 0x0005C520;
        public static readonly nint vezCmdDrawIndexedOffset                         = 0x0005C560;
        public static readonly nint vezCmdDrawIndexedIndirectOffset                 = 0x0005C600;
        public static readonly nint vezCmdDrawIndirectOffset                        = 0x0005C5B0;
        public static readonly nint vezCmdEndRenderPassOffset                       = 0x0005BDD0;
        public static readonly nint vezCmdFillBufferOffset                          = 0x0005CB00;
        public static readonly nint vezCmdNextSubpassOffset                         = 0x0005BDB0;
        public static readonly nint vezCmdPushConstantsOffset                       = 0x0005BE20;
        public static readonly nint vezCmdResetEventOffset                          = 0x0005CD10;
        public static readonly nint vezCmdResolveImageOffset                        = 0x0005CC80;
        public static readonly nint vezCmdSetBlendConstantsOffset                   = 0x0005C420;
        public static readonly nint vezCmdSetColorBlendStateOffset                  = 0x0005C2F0;
        public static readonly nint vezCmdSetDepthBiasOffset                        = 0x0005C3D0;
        public static readonly nint vezCmdSetDepthBoundsOffset                      = 0x0005C450;
        public static readonly nint vezCmdSetDepthStencilStateOffset                = 0x0005C2C0;
        public static readonly nint vezCmdSetEventOffset                            = 0x0005CCE0;
        public static readonly nint vezCmdSetInputAssemblyStateOffset               = 0x0005C230;
        public static readonly nint vezCmdSetLineWidthOffset                        = 0x0005C3A0;
        public static readonly nint vezCmdSetMultisampleStateOffset                 = 0x0005C290;
        public static readonly nint vezCmdSetRasterizationStateOffset               = 0x0005C260;
        public static readonly nint vezCmdSetScissorOffset                          = 0x0005C360;
        public static readonly nint vezCmdSetStencilCompareMaskOffset               = 0x0005C490;
        public static readonly nint vezCmdSetStencilReferenceOffset                 = 0x0005C4F0;
        public static readonly nint vezCmdSetStencilWriteMaskOffset                 = 0x0005C4C0;
        public static readonly nint vezCmdSetVertexInputFormatOffset                = 0x0005C1D0;
        public static readonly nint vezCmdSetViewportOffset                         = 0x0005C320;
        public static readonly nint vezCmdSetViewportStateOffset                    = 0x0005C200;
        public static readonly nint vezCmdUpdateBufferOffset                        = 0x0005CA60;
        public static readonly nint vezCreateBufferOffset                           = 0x0005B5F0;
        public static readonly nint vezCreateBufferViewOffset                       = 0x0005B820;
        public static readonly nint vezCreateComputePipelineOffset                  = 0x0005B410;
        public static readonly nint vezCreateDeviceOffset                           = 0x0005AA40;
        public static readonly nint vezCreateEventOffset                            = 0x0005B080;
        public static readonly nint vezCreateFramebufferOffset                      = 0x0005BAE0;
        public static readonly nint vezCreateGraphicsPipelineOffset                 = 0x0005B3D0;
        public static readonly nint vezCreateImageOffset                            = 0x0005B920;
        public static readonly nint vezCreateImageViewOffset                        = 0x0005BA10;
        public static readonly nint vezCreateInstanceOffset                         = 0x0005A830;
        public static readonly nint vezCreateQueryPoolOffset                        = 0x0005B1A0;
        public static readonly nint vezCreateSamplerOffset                          = 0x0005B500;
        public static readonly nint vezCreateShaderModuleOffset                     = 0x0005B280;
        public static readonly nint vezCreateSwapchainOffset                        = 0x0005AE50;
        public static readonly nint vezCreateVertexInputFormatOffset                = 0x0005B4A0;
        public static readonly nint vezDestroyBufferOffset                          = 0x0005B650;
        public static readonly nint vezDestroyBufferViewOffset                      = 0x0005B8E0;
        public static readonly nint vezDestroyDeviceOffset                          = 0x0005ABC0;
        public static readonly nint vezDestroyEventOffset                           = 0x0005B0E0;
        public static readonly nint vezDestroyFenceOffset                           = 0x0005AFA0;
        public static readonly nint vezDestroyFramebufferOffset                     = 0x0005BB20;
        public static readonly nint vezDestroyImageOffset                           = 0x0005B980;
        public static readonly nint vezDestroyImageViewOffset                       = 0x0005BAA0;
        public static readonly nint vezDestroyInstanceOffset                        = 0x0005A8B0;
        public static readonly nint vezDestroyPipelineOffset                        = 0x0005B450;
        public static readonly nint vezDestroyQueryPoolOffset                       = 0x0005B210;
        public static readonly nint vezDestroySamplerOffset                         = 0x0005B5C0;
        public static readonly nint vezDestroySemaphoreOffset                       = 0x0005B050;
        public static readonly nint vezDestroyShaderModuleOffset                    = 0x0005B2E0;
        public static readonly nint vezDestroySwapchainOffset                       = 0x0005AEA0;
        public static readonly nint vezDestroyVertexInputFormatOffset               = 0x0005B4B0;
        public static readonly nint vezDeviceWaitIdleOffset                         = 0x0005AD20;
        public static readonly nint vezEndCommandBufferOffset                       = 0x0005BD00;
        public static readonly nint vezEnumerateDeviceExtensionPropertiesOffset     = 0x0005AA20;
        public static readonly nint vezEnumerateDeviceLayerPropertiesOffset         = 0x0005AA30;
        public static readonly nint vezEnumerateInstanceExtensionPropertiesOffset   = 0x0005A810;
        public static readonly nint vezEnumerateInstanceLayerPropertiesOffset       = 0x0005A820;
        public static readonly nint vezEnumeratePhysicalDevicesOffset               = 0x0005A920;
        public static readonly nint vezEnumeratePipelineResourcesOffset             = 0x0005B480;
        public static readonly nint vezFlushMappedBufferRangesOffset                = 0x0005B7A0;
        public static readonly nint vezFreeCommandBuffersOffset                     = 0x0005BC50;
        public static readonly nint vezGetDeviceComputeQueueOffset                  = 0x0005ADD0;
        public static readonly nint vezGetDeviceGraphicsQueueOffset                 = 0x0005AD90;
        public static readonly nint vezGetDeviceQueueOffset                         = 0x0005AD50;
        public static readonly nint vezGetDeviceTransferQueueOffset                 = 0x0005AE10;
        public static readonly nint vezGetEventStatusOffset                         = 0x0005B110;
        public static readonly nint vezGetFenceStatusOffset                         = 0x0005AFE0;
        public static readonly nint vezGetImageLayoutOffset                         = 0x0005CE00;
        public static readonly nint vezGetPhysicalDeviceFeaturesOffset              = 0x0005A9C0;
        public static readonly nint vezGetPhysicalDeviceFormatPropertiesOffset      = 0x0005A9D0;
        public static readonly nint vezGetPhysicalDeviceImageFormatPropertiesOffset = 0x0005A9E0;
        public static readonly nint vezGetPhysicalDevicePresentSupportOffset        = 0x0005AA10;
        public static readonly nint vezGetPhysicalDevicePropertiesOffset            = 0x0005A9B0;
        public static readonly nint vezGetPhysicalDeviceQueueFamilyPropertiesOffset = 0x0005A9F0;
        public static readonly nint vezGetPhysicalDeviceSurfaceFormatsOffset        = 0x0005AA00;
        public static readonly nint vezGetPipelineResourceOffset                    = 0x0005B490;
        public static readonly nint vezGetQueryPoolResultsOffset                    = 0x0005B240;
        public static readonly nint vezGetShaderModuleBinaryOffset                  = 0x0005B390;
        public static readonly nint vezGetShaderModuleInfoLogOffset                 = 0x0005B320;
        public static readonly nint vezGetSwapchainSurfaceFormatOffset              = 0x0005AEE0;
        public static readonly nint vezImageSubDataOffset                           = 0x0005B9C0;
        public static readonly nint vezImportVkImageOffset                          = 0x0005CD40;
        public static readonly nint vezInvalidateMappedBufferRangesOffset           = 0x0005B7E0;
        public static readonly nint vezMapBufferOffset                              = 0x0005B700;
        public static readonly nint vezQueuePresentOffset                           = 0x0005AF40;
        public static readonly nint vezQueueSubmitOffset                            = 0x0005AF00;
        public static readonly nint vezQueueWaitIdleOffset                          = 0x0005AF70;
        public static readonly nint vezRemoveImportedVkImageOffset                  = 0x0005CDD0;
        public static readonly nint vezResetCommandBufferOffset                     = 0x0005BD50;
        public static readonly nint vezResetEventOffset                             = 0x0005B170;
        public static readonly nint vezSetEventOffset                               = 0x0005B140;
        public static readonly nint vezSwapchainSetVSyncOffset                      = 0x0005AEF0;
        public static readonly nint vezUnmapBufferOffset                            = 0x0005B760;
        public static readonly nint vezWaitForFencesOffset                          = 0x0005B010;

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libVEZ.so.1";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libVEZ-1.0.0.dylib";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "VEZ.dll";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "VEZ";
            }
            else
            {
                DLL_NAME = "VEZ";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);

#if LOAD_FROM_DEVICEPROCADDR
            #region LOAD_FROM_DEVICEPROCADDR
            
            vezEnumerateInstanceExtensionProperties = (delegate* <nint,out uint, VkExtensionProperties*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumerateInstanceExtensionProperties");
            vezEnumerateInstanceLayerProperties = (delegate* <out uint, VkLayerProperties*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumerateInstanceLayerProperties");
            vezCreateInstance = (delegate* <ref VezInstanceCreateInfo,ref VkInstance,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateInstance");
            vezDestroyInstance = (delegate* <VkInstance,void>)NativeLibrary.GetExport(Handle, "vezDestroyInstance");
            vezEnumeratePhysicalDevices = (delegate* <VkInstance,out uint, VkPhysicalDevice*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumeratePhysicalDevices");
            vezGetPhysicalDeviceProperties = (delegate* <VkPhysicalDevice,ref VkPhysicalDeviceProperties,void>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceProperties");
            vezGetPhysicalDeviceFeatures = (delegate* <VkPhysicalDevice,ref VkPhysicalDeviceFeatures,void>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceFeatures");
            vezGetPhysicalDeviceFormatProperties = (delegate* <VkPhysicalDevice,VkFormat,ref VkFormatProperties,void>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceFormatProperties");
            vezGetPhysicalDeviceImageFormatProperties = (delegate* <VkPhysicalDevice,VkFormat,VkImageType,VkImageTiling,VkImageUsageFlags,VkImageCreateFlags,ref VkImageFormatProperties,VkResult>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceImageFormatProperties");
            vezGetPhysicalDeviceQueueFamilyProperties = (delegate* <VkPhysicalDevice,out uint, VkQueueFamilyProperties*,void>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceQueueFamilyProperties");
            vezGetPhysicalDeviceSurfaceFormats = (delegate* <VkPhysicalDevice,VkSurfaceKHR,out uint, VkSurfaceFormatKHR*,VkResult>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDeviceSurfaceFormats");
            vezGetPhysicalDevicePresentSupport = (delegate* <VkPhysicalDevice,uint,VkSurfaceKHR,ref uint,VkResult>)NativeLibrary.GetExport(Handle, "vezGetPhysicalDevicePresentSupport");
            vezEnumerateDeviceExtensionProperties = (delegate* <VkPhysicalDevice,nint,out uint, VkExtensionProperties*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumerateDeviceExtensionProperties");
            vezEnumerateDeviceLayerProperties = (delegate* <VkPhysicalDevice,out uint, VkLayerProperties*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumerateDeviceLayerProperties");
            vezCreateDevice = (delegate* <VkPhysicalDevice,ref VezDeviceCreateInfo,ref VkDevice,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateDevice");
            vezDestroyDevice = (delegate* <VkDevice,void>)NativeLibrary.GetExport(Handle, "vezDestroyDevice");
            vezDeviceWaitIdle = (delegate* <VkDevice,VkResult>)NativeLibrary.GetExport(Handle, "vezDeviceWaitIdle");
            vezGetDeviceQueue = (delegate* <VkDevice,uint,uint,ref VkQueue,void>)NativeLibrary.GetExport(Handle, "vezGetDeviceQueue");
            vezGetDeviceGraphicsQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)NativeLibrary.GetExport(Handle, "vezGetDeviceGraphicsQueue");
            vezGetDeviceComputeQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)NativeLibrary.GetExport(Handle, "vezGetDeviceComputeQueue");
            vezGetDeviceTransferQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)NativeLibrary.GetExport(Handle, "vezGetDeviceTransferQueue");
            vezCreateSwapchain = (delegate* <VkDevice,ref VezSwapchainCreateInfo,ref VezSwapchain,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateSwapchain");
            vezDestroySwapchain = (delegate* <VkDevice,VezSwapchain,void>)NativeLibrary.GetExport(Handle, "vezDestroySwapchain");
            vezGetSwapchainSurfaceFormat = (delegate* <VezSwapchain,ref VkSurfaceFormatKHR,void>)NativeLibrary.GetExport(Handle, "vezGetSwapchainSurfaceFormat");
            vezSwapchainSetVSync = (delegate* <VezSwapchain,uint,VkResult>)NativeLibrary.GetExport(Handle, "vezSwapchainSetVSync");
            vezQueueSubmit = (delegate* <VkQueue,uint,ref VezSubmitInfo,ref VkFence,VkResult>)NativeLibrary.GetExport(Handle, "vezQueueSubmit");
            vezQueuePresent = (delegate* <VkQueue,ref VezPresentInfo,VkResult>)NativeLibrary.GetExport(Handle, "vezQueuePresent");
            vezQueueWaitIdle = (delegate* <VkQueue,VkResult>)NativeLibrary.GetExport(Handle, "vezQueueWaitIdle");
            vezDestroyFence = (delegate* <VkDevice,VkFence,void>)NativeLibrary.GetExport(Handle, "vezDestroyFence");
            vezGetFenceStatus = (delegate* <VkDevice,VkFence,VkResult>)NativeLibrary.GetExport(Handle, "vezGetFenceStatus");
            vezWaitForFences = (delegate* <VkDevice,uint,ref VkFence,uint,uint64_t,VkResult>)NativeLibrary.GetExport(Handle, "vezWaitForFences");
            vezDestroySemaphore = (delegate* <VkDevice,VkSemaphore,void>)NativeLibrary.GetExport(Handle, "vezDestroySemaphore");
            vezCreateEvent = (delegate* <VkDevice,ref VkEvent,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateEvent");
            vezDestroyEvent = (delegate* <VkDevice,VkEvent,void>)NativeLibrary.GetExport(Handle, "vezDestroyEvent");
            vezGetEventStatus = (delegate* <VkDevice,VkEvent,VkResult>)NativeLibrary.GetExport(Handle, "vezGetEventStatus");
            vezSetEvent = (delegate* <VkDevice,VkEvent,VkResult>)NativeLibrary.GetExport(Handle, "vezSetEvent");
            vezResetEvent = (delegate* <VkDevice,VkEvent,VkResult>)NativeLibrary.GetExport(Handle, "vezResetEvent");
            vezCreateQueryPool = (delegate* <VkDevice,ref VezQueryPoolCreateInfo,ref VkQueryPool,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateQueryPool");
            vezDestroyQueryPool = (delegate* <VkDevice,VkQueryPool,void>)NativeLibrary.GetExport(Handle, "vezDestroyQueryPool");
            vezGetQueryPoolResults = (delegate* <VkDevice,VkQueryPool,uint,uint,size_t,nint,ulong,VkQueryResultFlags,VkResult>)NativeLibrary.GetExport(Handle, "vezGetQueryPoolResults");
            vezCreateShaderModule = (delegate* <VkDevice,ref VezShaderModuleCreateInfo,ref VkShaderModule,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateShaderModule");
            vezDestroyShaderModule = (delegate* <VkDevice,VkShaderModule,void>)NativeLibrary.GetExport(Handle, "vezDestroyShaderModule");
            vezGetShaderModuleInfoLog = (delegate* <VkShaderModule,ref uint,nint,void>)NativeLibrary.GetExport(Handle, "vezGetShaderModuleInfoLog");
            vezGetShaderModuleBinary = (delegate* <VkShaderModule,ref uint,ref uint,VkResult>)NativeLibrary.GetExport(Handle, "vezGetShaderModuleBinary");
            vezCreateGraphicsPipeline = (delegate* <VkDevice,ref VezGraphicsPipelineCreateInfo,ref VezPipeline,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateGraphicsPipeline");
            vezCreateComputePipeline = (delegate* <VkDevice,ref VezComputePipelineCreateInfo,ref VezPipeline,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateComputePipeline");
            vezDestroyPipeline = (delegate* <VkDevice,VezPipeline,void>)NativeLibrary.GetExport(Handle, "vezDestroyPipeline");
            vezEnumeratePipelineResources = (delegate* <VezPipeline,out uint, VezPipelineResource*,VkResult>)NativeLibrary.GetExport(Handle, "vezEnumeratePipelineResources");
            vezGetPipelineResource = (delegate* <VezPipeline,nint,ref VezPipelineResource,VkResult>)NativeLibrary.GetExport(Handle, "vezGetPipelineResource");
            vezCreateVertexInputFormat = (delegate* <VkDevice,ref VezVertexInputFormatCreateInfo,ref VezVertexInputFormat,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateVertexInputFormat");
            vezDestroyVertexInputFormat = (delegate* <VkDevice,VezVertexInputFormat,void>)NativeLibrary.GetExport(Handle, "vezDestroyVertexInputFormat");
            vezCreateSampler = (delegate* <VkDevice,ref VezSamplerCreateInfo,ref VkSampler,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateSampler");
            vezDestroySampler = (delegate* <VkDevice,VkSampler,void>)NativeLibrary.GetExport(Handle, "vezDestroySampler");
            vezCreateBuffer = (delegate* <VkDevice,VezMemoryFlags,ref VezBufferCreateInfo,ref VkBuffer,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateBuffer");
            vezDestroyBuffer = (delegate* <VkDevice,VkBuffer,void>)NativeLibrary.GetExport(Handle, "vezDestroyBuffer");
            vezBufferSubData = (delegate* <VkDevice,VkBuffer,ulong,ulong,nint,VkResult>)NativeLibrary.GetExport(Handle, "vezBufferSubData");
            vezMapBuffer = (delegate* <VkDevice,VkBuffer,ulong,ulong,out nint,VkResult>)NativeLibrary.GetExport(Handle, "vezMapBuffer");
            vezUnmapBuffer = (delegate* <VkDevice,VkBuffer,void>)NativeLibrary.GetExport(Handle, "vezUnmapBuffer");
            vezFlushMappedBufferRanges = (delegate* <VkDevice,uint,ref VezMappedBufferRange,VkResult>)NativeLibrary.GetExport(Handle, "vezFlushMappedBufferRanges");
            vezInvalidateMappedBufferRanges = (delegate* <VkDevice,uint,ref VezMappedBufferRange,VkResult>)NativeLibrary.GetExport(Handle, "vezInvalidateMappedBufferRanges");
            vezCreateBufferView = (delegate* <VkDevice,ref VezBufferViewCreateInfo,ref VkBufferView,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateBufferView");
            vezDestroyBufferView = (delegate* <VkDevice,VkBufferView,void>)NativeLibrary.GetExport(Handle, "vezDestroyBufferView");
            vezCreateImage = (delegate* <VkDevice,VezMemoryFlags,ref VezImageCreateInfo,ref VkImage,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateImage");
            vezDestroyImage = (delegate* <VkDevice,VkImage,void>)NativeLibrary.GetExport(Handle, "vezDestroyImage");
            vezImageSubData = (delegate* <VkDevice,VkImage,ref VezImageSubDataInfo,nint,VkResult>)NativeLibrary.GetExport(Handle, "vezImageSubData");
            vezCreateImageView = (delegate* <VkDevice,ref VezImageViewCreateInfo,ref VkImageView,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateImageView");
            vezDestroyImageView = (delegate* <VkDevice,VkImageView,void>)NativeLibrary.GetExport(Handle, "vezDestroyImageView");
            vezCreateFramebuffer = (delegate* <VkDevice,ref VezFramebufferCreateInfo,ref VezFramebuffer,VkResult>)NativeLibrary.GetExport(Handle, "vezCreateFramebuffer");
            vezDestroyFramebuffer = (delegate* <VkDevice,VezFramebuffer,void>)NativeLibrary.GetExport(Handle, "vezDestroyFramebuffer");
            vezAllocateCommandBuffers = (delegate* <VkDevice,ref VezCommandBufferAllocateInfo,ref VkCommandBuffer,VkResult>)NativeLibrary.GetExport(Handle, "vezAllocateCommandBuffers");
            vezFreeCommandBuffers = (delegate* <VkDevice,uint,ref VkCommandBuffer,void>)NativeLibrary.GetExport(Handle, "vezFreeCommandBuffers");
            vezBeginCommandBuffer = (delegate* <VkCommandBuffer,VkCommandBufferUsageFlags,VkResult>)NativeLibrary.GetExport(Handle, "vezBeginCommandBuffer");
            vezEndCommandBuffer = (delegate* <VkResult>)NativeLibrary.GetExport(Handle, "vezEndCommandBuffer");
            vezResetCommandBuffer = (delegate* <VkCommandBuffer,VkResult>)NativeLibrary.GetExport(Handle, "vezResetCommandBuffer");
            vezCmdBeginRenderPass = (delegate* <ref VezRenderPassBeginInfo,void>)NativeLibrary.GetExport(Handle, "vezCmdBeginRenderPass");
            vezCmdNextSubpass = (delegate* <void>)NativeLibrary.GetExport(Handle, "vezCmdNextSubpass");
            vezCmdEndRenderPass = (delegate* <void>)NativeLibrary.GetExport(Handle, "vezCmdEndRenderPass");
            vezCmdBindPipeline = (delegate* <VezPipeline,void>)NativeLibrary.GetExport(Handle, "vezCmdBindPipeline");
            vezCmdPushConstants = (delegate* <uint,uint,nint,void>)NativeLibrary.GetExport(Handle, "vezCmdPushConstants");
            vezCmdBindBuffer = (delegate* <VkBuffer,ulong,ulong,uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdBindBuffer");
            vezCmdBindBufferView = (delegate* <VkBufferView,uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdBindBufferView");
            vezCmdBindImageView = (delegate* <VkImageView,VkSampler,uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdBindImageView");
            vezCmdBindSampler = (delegate* <VkSampler,uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdBindSampler");
            vezCmdBindVertexBuffers = (delegate* <uint,uint,ref VkBuffer,ref ulong,void>)NativeLibrary.GetExport(Handle, "vezCmdBindVertexBuffers");
            vezCmdBindIndexBuffer = (delegate* <VkBuffer,ulong,VkIndexType,void>)NativeLibrary.GetExport(Handle, "vezCmdBindIndexBuffer");
            vezCmdSetVertexInputFormat = (delegate* <VezVertexInputFormat,void>)NativeLibrary.GetExport(Handle, "vezCmdSetVertexInputFormat");
            vezCmdSetViewportState = (delegate* <uint,void>)NativeLibrary.GetExport(Handle, "vezCmdSetViewportState");
            vezCmdSetInputAssemblyState = (delegate* <ref VezInputAssemblyState,void>)NativeLibrary.GetExport(Handle, "vezCmdSetInputAssemblyState");
            vezCmdSetRasterizationState = (delegate* <ref VezRasterizationState,void>)NativeLibrary.GetExport(Handle, "vezCmdSetRasterizationState");
            vezCmdSetMultisampleState = (delegate* <ref VezMultisampleState,void>)NativeLibrary.GetExport(Handle, "vezCmdSetMultisampleState");
            vezCmdSetDepthStencilState = (delegate* <ref VezDepthStencilState,void>)NativeLibrary.GetExport(Handle, "vezCmdSetDepthStencilState");
            vezCmdSetColorBlendState = (delegate* <ref VezColorBlendState,void>)NativeLibrary.GetExport(Handle, "vezCmdSetColorBlendState");
            vezCmdSetViewport = (delegate* <uint,uint,ref VkViewport,void>)NativeLibrary.GetExport(Handle, "vezCmdSetViewport");
            vezCmdSetScissor = (delegate* <uint,uint,ref VkRect2D,void>)NativeLibrary.GetExport(Handle, "vezCmdSetScissor");
            vezCmdSetLineWidth = (delegate* <float,void>)NativeLibrary.GetExport(Handle, "vezCmdSetLineWidth");
            vezCmdSetDepthBias = (delegate* <float,float,float,void>)NativeLibrary.GetExport(Handle, "vezCmdSetDepthBias");
            vezCmdSetBlendConstants = (delegate* <float[],void>)NativeLibrary.GetExport(Handle, "vezCmdSetBlendConstants");
            vezCmdSetDepthBounds = (delegate* <float,float,void>)NativeLibrary.GetExport(Handle, "vezCmdSetDepthBounds");
            vezCmdSetStencilCompareMask = (delegate* <VkStencilFaceFlags,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdSetStencilCompareMask");
            vezCmdSetStencilWriteMask = (delegate* <VkStencilFaceFlags,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdSetStencilWriteMask");
            vezCmdSetStencilReference = (delegate* <VkStencilFaceFlags,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdSetStencilReference");
            vezCmdDraw = (delegate* <uint,uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdDraw");
            vezCmdDrawIndexed = (delegate* <uint,uint,uint,int32_t,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdDrawIndexed");
            vezCmdDrawIndirect = (delegate* <VkBuffer,ulong,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdDrawIndirect");
            vezCmdDrawIndexedIndirect = (delegate* <VkBuffer,ulong,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdDrawIndexedIndirect");
            vezCmdDispatch = (delegate* <uint,uint,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdDispatch");
            vezCmdDispatchIndirect = (delegate* <VkBuffer,ulong,void>)NativeLibrary.GetExport(Handle, "vezCmdDispatchIndirect");
            vezCmdCopyBuffer = (delegate* <VkBuffer,VkBuffer,uint,ref VezBufferCopy,void>)NativeLibrary.GetExport(Handle, "vezCmdCopyBuffer");
            vezCmdCopyImage = (delegate* <VkImage,VkImage,uint,ref VezImageCopy,void>)NativeLibrary.GetExport(Handle, "vezCmdCopyImage");
            vezCmdBlitImage = (delegate* <VkImage,VkImage,uint,ref VezImageBlit,VkFilter,void>)NativeLibrary.GetExport(Handle, "vezCmdBlitImage");
            vezCmdCopyBufferToImage = (delegate* <VkBuffer,VkImage,uint,ref VezBufferImageCopy,void>)NativeLibrary.GetExport(Handle, "vezCmdCopyBufferToImage");
            vezCmdCopyImageToBuffer = (delegate* <VkImage,VkBuffer,uint,ref VezBufferImageCopy,void>)NativeLibrary.GetExport(Handle, "vezCmdCopyImageToBuffer");
            vezCmdUpdateBuffer = (delegate* <VkBuffer,ulong,ulong,nint,void>)NativeLibrary.GetExport(Handle, "vezCmdUpdateBuffer");
            vezCmdFillBuffer = (delegate* <VkBuffer,ulong,ulong,uint,void>)NativeLibrary.GetExport(Handle, "vezCmdFillBuffer");
            vezCmdClearColorImage = (delegate* <VkImage,ref VkClearColorValue,uint,ref VezImageSubresourceRange,void>)NativeLibrary.GetExport(Handle, "vezCmdClearColorImage");
            vezCmdClearDepthStencilImage = (delegate* <VkImage,ref VkClearDepthStencilValue,uint,ref VezImageSubresourceRange,void>)NativeLibrary.GetExport(Handle, "vezCmdClearDepthStencilImage");
            vezCmdClearAttachments = (delegate* <uint,ref VezClearAttachment,uint,ref VkClearRect,void>)NativeLibrary.GetExport(Handle, "vezCmdClearAttachments");
            vezCmdResolveImage = (delegate* <VkImage,VkImage,uint,ref VezImageResolve,void>)NativeLibrary.GetExport(Handle, "vezCmdResolveImage");
            vezCmdSetEvent = (delegate* <VkEvent,VkPipelineStageFlags,void>)NativeLibrary.GetExport(Handle, "vezCmdSetEvent");
            vezCmdResetEvent = (delegate* <VkEvent,VkPipelineStageFlags,void>)NativeLibrary.GetExport(Handle, "vezCmdResetEvent");
            vezImportVkImage = (delegate* <VkDevice,VkImage,VkFormat,VkExtent3D,VkSampleCountFlagBits,VkImageLayout,VkResult>)NativeLibrary.GetExport(Handle, "vezImportVkImage");
            vezRemoveImportedVkImage = (delegate* <VkDevice,VkImage,VkResult>)NativeLibrary.GetExport(Handle, "vezRemoveImportedVkImage");
            vezGetImageLayout = (delegate* <VkDevice,VkImage,ref VkImageLayout,VkResult>)NativeLibrary.GetExport(Handle, "vezGetImageLayout");
            
            #endregion

#elif true //LOAD_FROM_RVA

            #region LOAD_FROM_RVA

            vezEnumerateInstanceExtensionProperties = (delegate* <nint, out uint, VkExtensionProperties*,VkResult>)(Handle + vezEnumerateInstanceExtensionPropertiesOffset);
            vezEnumerateInstanceLayerProperties = (delegate* <out uint, VkLayerProperties*,VkResult>)(Handle + vezEnumerateInstanceLayerPropertiesOffset);
            vezCreateInstance = (delegate* <ref VezInstanceCreateInfo,ref VkInstance,VkResult>)(Handle + vezCreateInstanceOffset);
            vezDestroyInstance = (delegate* <VkInstance,void>)(Handle + vezDestroyInstanceOffset);
            vezEnumeratePhysicalDevices = (delegate* <VkInstance,out uint, VkPhysicalDevice*,VkResult>)(Handle + vezEnumeratePhysicalDevicesOffset);
            vezGetPhysicalDeviceProperties = (delegate* <VkPhysicalDevice,ref VkPhysicalDeviceProperties,void>)(Handle + vezGetPhysicalDevicePropertiesOffset);
            vezGetPhysicalDeviceFeatures = (delegate* <VkPhysicalDevice,ref VkPhysicalDeviceFeatures,void>)(Handle + vezGetPhysicalDeviceFeaturesOffset);
            vezGetPhysicalDeviceFormatProperties = (delegate* <VkPhysicalDevice,VkFormat,ref VkFormatProperties,void>)(Handle + vezGetPhysicalDeviceFormatPropertiesOffset);
            vezGetPhysicalDeviceImageFormatProperties = (delegate* <VkPhysicalDevice,VkFormat,VkImageType,VkImageTiling,VkImageUsageFlagBits,VkImageCreateFlagBits,ref VkImageFormatProperties,VkResult>)(Handle + vezGetPhysicalDeviceImageFormatPropertiesOffset);
            vezGetPhysicalDeviceQueueFamilyProperties = (delegate* <VkPhysicalDevice,out uint, VkQueueFamilyProperties*,void>)(Handle + vezGetPhysicalDeviceQueueFamilyPropertiesOffset);
            vezGetPhysicalDeviceSurfaceFormats = (delegate* <VkPhysicalDevice,VkSurfaceKHR,out uint, VkSurfaceFormatKHR*,VkResult>)(Handle + vezGetPhysicalDeviceSurfaceFormatsOffset);
            vezGetPhysicalDevicePresentSupport = (delegate* <VkPhysicalDevice,uint,VkSurfaceKHR,ref uint,VkResult>)(Handle + vezGetPhysicalDevicePresentSupportOffset);
            vezEnumerateDeviceExtensionProperties = (delegate* <VkPhysicalDevice,nint,out uint, VkExtensionProperties*,VkResult>)(Handle + vezEnumerateDeviceExtensionPropertiesOffset);
            vezEnumerateDeviceLayerProperties = (delegate* <VkPhysicalDevice,out uint, VkLayerProperties*,VkResult>)(Handle + vezEnumerateDeviceLayerPropertiesOffset);
            vezCreateDevice = (delegate* <VkPhysicalDevice,ref VezDeviceCreateInfo,ref VkDevice,VkResult>)(Handle + vezCreateDeviceOffset);
            vezDestroyDevice = (delegate* <VkDevice,void>)(Handle + vezDestroyDeviceOffset);
            vezDeviceWaitIdle = (delegate* <VkDevice,VkResult>)(Handle + vezDeviceWaitIdleOffset);
            vezGetDeviceQueue = (delegate* <VkDevice,uint,uint,ref VkQueue,void>)(Handle + vezGetDeviceQueueOffset);
            vezGetDeviceGraphicsQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)(Handle + vezGetDeviceGraphicsQueueOffset);
            vezGetDeviceComputeQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)(Handle + vezGetDeviceComputeQueueOffset);
            vezGetDeviceTransferQueue = (delegate* <VkDevice,uint,ref VkQueue,void>)(Handle + vezGetDeviceTransferQueueOffset);
            vezCreateSwapchain = (delegate* <VkDevice,ref VezSwapchainCreateInfo,ref VezSwapchain,VkResult>)(Handle + vezCreateSwapchainOffset);
            vezDestroySwapchain = (delegate* <VkDevice,VezSwapchain,void>)(Handle + vezDestroySwapchainOffset);
            vezGetSwapchainSurfaceFormat = (delegate* <VezSwapchain,ref VkSurfaceFormatKHR,void>)(Handle + vezGetSwapchainSurfaceFormatOffset);
            vezSwapchainSetVSync = (delegate* <VezSwapchain,uint,VkResult>)(Handle + vezSwapchainSetVSyncOffset);
            vezQueueSubmit = (delegate* <VkQueue,uint,ref VezSubmitInfo,ref VkFence,VkResult>)(Handle + vezQueueSubmitOffset);
            vezQueuePresent = (delegate* <VkQueue,ref VezPresentInfo,VkResult>)(Handle + vezQueuePresentOffset);
            vezQueueWaitIdle = (delegate* <VkQueue,VkResult>)(Handle + vezQueueWaitIdleOffset);
            vezDestroyFence = (delegate* <VkDevice,VkFence,void>)(Handle + vezDestroyFenceOffset);
            vezGetFenceStatus = (delegate* <VkDevice,VkFence,VkResult>)(Handle + vezGetFenceStatusOffset);
            vezWaitForFences = (delegate* <VkDevice,uint,ref VkFence,uint,ulong,VkResult>)(Handle + vezWaitForFencesOffset);
            vezDestroySemaphore = (delegate* <VkDevice,VkSemaphore,void>)(Handle + vezDestroySemaphoreOffset);
            vezCreateEvent = (delegate* <VkDevice,ref VkEvent,VkResult>)(Handle + vezCreateEventOffset);
            vezDestroyEvent = (delegate* <VkDevice,VkEvent,void>)(Handle + vezDestroyEventOffset);
            vezGetEventStatus = (delegate* <VkDevice,VkEvent,VkResult>)(Handle + vezGetEventStatusOffset);
            vezSetEvent = (delegate* <VkDevice,VkEvent,VkResult>)(Handle + vezSetEventOffset);
            vezResetEvent = (delegate* <VkDevice,VkEvent,VkResult>)(Handle + vezResetEventOffset);
            vezCreateQueryPool = (delegate* <VkDevice,ref VezQueryPoolCreateInfo,ref VkQueryPool,VkResult>)(Handle + vezCreateQueryPoolOffset);
            vezDestroyQueryPool = (delegate* <VkDevice,VkQueryPool,void>)(Handle + vezDestroyQueryPoolOffset);
            vezGetQueryPoolResults = (delegate* <VkDevice,VkQueryPool,uint,uint,size_t,nint,ulong,VkQueryResultFlagBits,VkResult>)(Handle + vezGetQueryPoolResultsOffset);
            vezCreateShaderModule = (delegate* <VkDevice,ref VezShaderModuleCreateInfo,ref VkShaderModule,VkResult>)(Handle + vezCreateShaderModuleOffset);
            vezDestroyShaderModule = (delegate* <VkDevice,VkShaderModule,void>)(Handle + vezDestroyShaderModuleOffset);
            vezGetShaderModuleInfoLog = (delegate* <VkShaderModule,ref uint,nint,void>)(Handle + vezGetShaderModuleInfoLogOffset);
            vezGetShaderModuleBinary = (delegate* <VkShaderModule,ref uint,ref uint,VkResult>)(Handle + vezGetShaderModuleBinaryOffset);
            vezCreateGraphicsPipeline = (delegate* <VkDevice,ref VezGraphicsPipelineCreateInfo,ref VezPipeline,VkResult>)(Handle + vezCreateGraphicsPipelineOffset);
            vezCreateComputePipeline = (delegate* <VkDevice,ref VezComputePipelineCreateInfo,ref VezPipeline,VkResult>)(Handle + vezCreateComputePipelineOffset);
            vezDestroyPipeline = (delegate* <VkDevice,VezPipeline,void>)(Handle + vezDestroyPipelineOffset);
            vezEnumeratePipelineResources = (delegate* <VezPipeline,out uint, VezPipelineResource*,VkResult>)(Handle + vezEnumeratePipelineResourcesOffset);
            vezGetPipelineResource = (delegate* <VezPipeline,nint,ref VezPipelineResource,VkResult>)(Handle + vezGetPipelineResourceOffset);
            vezCreateVertexInputFormat = (delegate* <VkDevice,ref VezVertexInputFormatCreateInfo,ref VezVertexInputFormat,VkResult>)(Handle + vezCreateVertexInputFormatOffset);
            vezDestroyVertexInputFormat = (delegate* <VkDevice,VezVertexInputFormat,void>)(Handle + vezDestroyVertexInputFormatOffset);
            vezCreateSampler = (delegate* <VkDevice,ref VezSamplerCreateInfo,ref VkSampler,VkResult>)(Handle + vezCreateSamplerOffset);
            vezDestroySampler = (delegate* <VkDevice,VkSampler,void>)(Handle + vezDestroySamplerOffset);
            vezCreateBuffer = (delegate* <VkDevice,VezMemoryFlags,ref VezBufferCreateInfo,ref VkBuffer,VkResult>)(Handle + vezCreateBufferOffset);
            vezDestroyBuffer = (delegate* <VkDevice,VkBuffer,void>)(Handle + vezDestroyBufferOffset);
            vezBufferSubData = (delegate* <VkDevice,VkBuffer,ulong,ulong,nint,VkResult>)(Handle + vezBufferSubDataOffset);
            vezMapBuffer = (delegate* <VkDevice,VkBuffer,ulong,ulong,out nint,VkResult>)(Handle + vezMapBufferOffset);
            vezUnmapBuffer = (delegate* <VkDevice,VkBuffer,void>)(Handle + vezUnmapBufferOffset);
            vezFlushMappedBufferRanges = (delegate* <VkDevice,uint,ref VezMappedBufferRange,VkResult>)(Handle + vezFlushMappedBufferRangesOffset);
            vezInvalidateMappedBufferRanges = (delegate* <VkDevice,uint,ref VezMappedBufferRange,VkResult>)(Handle + vezInvalidateMappedBufferRangesOffset);
            vezCreateBufferView = (delegate* <VkDevice,ref VezBufferViewCreateInfo,ref VkBufferView,VkResult>)(Handle + vezCreateBufferViewOffset);
            vezDestroyBufferView = (delegate* <VkDevice,VkBufferView,void>)(Handle + vezDestroyBufferViewOffset);
            vezCreateImage = (delegate* <VkDevice,VezMemoryFlags,ref VezImageCreateInfo,ref VkImage,VkResult>)(Handle + vezCreateImageOffset);
            vezDestroyImage = (delegate* <VkDevice,VkImage,void>)(Handle + vezDestroyImageOffset);
            vezImageSubData = (delegate* <VkDevice,VkImage,ref VezImageSubDataInfo,nint,VkResult>)(Handle + vezImageSubDataOffset);
            vezCreateImageView = (delegate* <VkDevice,ref VezImageViewCreateInfo,ref VkImageView,VkResult>)(Handle + vezCreateImageViewOffset);
            vezDestroyImageView = (delegate* <VkDevice,VkImageView,void>)(Handle + vezDestroyImageViewOffset);
            vezCreateFramebuffer = (delegate* <VkDevice,ref VezFramebufferCreateInfo,ref VezFramebuffer,VkResult>)(Handle + vezCreateFramebufferOffset);
            vezDestroyFramebuffer = (delegate* <VkDevice,VezFramebuffer,void>)(Handle + vezDestroyFramebufferOffset);
            vezAllocateCommandBuffers = (delegate* <VkDevice,ref VezCommandBufferAllocateInfo,ref VkCommandBuffer,VkResult>)(Handle + vezAllocateCommandBuffersOffset);
            vezFreeCommandBuffers = (delegate* <VkDevice,uint,ref VkCommandBuffer,void>)(Handle + vezFreeCommandBuffersOffset);
            vezBeginCommandBuffer = (delegate* <VkCommandBuffer,VkCommandBufferUsageFlagBits,VkResult>)(Handle + vezBeginCommandBufferOffset);
            vezEndCommandBuffer = (delegate* <VkResult>)(Handle + vezEndCommandBufferOffset);
            vezResetCommandBuffer = (delegate* <VkCommandBuffer,VkResult>)(Handle + vezResetCommandBufferOffset);
            vezCmdBeginRenderPass = (delegate* <ref VezRenderPassBeginInfo,void>)(Handle + vezCmdBeginRenderPassOffset);
            vezCmdNextSubpass = (delegate* <void>)(Handle + vezCmdNextSubpassOffset);
            vezCmdEndRenderPass = (delegate* <void>)(Handle + vezCmdEndRenderPassOffset);
            vezCmdBindPipeline = (delegate* <VezPipeline,void>)(Handle + vezCmdBindPipelineOffset);
            vezCmdPushConstants = (delegate* <uint,uint,nint,void>)(Handle + vezCmdPushConstantsOffset);
            vezCmdBindBuffer = (delegate* <VkBuffer,ulong,ulong,uint,uint,uint,void>)(Handle + vezCmdBindBufferOffset);
            vezCmdBindBufferView = (delegate* <VkBufferView,uint,uint,uint,void>)(Handle + vezCmdBindBufferViewOffset);
            vezCmdBindImageView = (delegate* <VkImageView,VkSampler,uint,uint,uint,void>)(Handle + vezCmdBindImageViewOffset);
            vezCmdBindSampler = (delegate* <VkSampler,uint,uint,uint,void>)(Handle + vezCmdBindSamplerOffset);
            vezCmdBindVertexBuffers = (delegate* <uint,uint,ref VkBuffer,ref ulong,void>)(Handle + vezCmdBindVertexBuffersOffset);
            vezCmdBindIndexBuffer = (delegate* <VkBuffer,ulong,VkIndexType,void>)(Handle + vezCmdBindIndexBufferOffset);
            vezCmdSetVertexInputFormat = (delegate* <VezVertexInputFormat,void>)(Handle + vezCmdSetVertexInputFormatOffset);
            vezCmdSetViewportState = (delegate* <uint,void>)(Handle + vezCmdSetViewportStateOffset);
            vezCmdSetInputAssemblyState = (delegate* <ref VezInputAssemblyState,void>)(Handle + vezCmdSetInputAssemblyStateOffset);
            vezCmdSetRasterizationState = (delegate* <ref VezRasterizationState,void>)(Handle + vezCmdSetRasterizationStateOffset);
            vezCmdSetMultisampleState = (delegate* <ref VezMultisampleState,void>)(Handle + vezCmdSetMultisampleStateOffset);
            vezCmdSetDepthStencilState = (delegate* <ref VezDepthStencilState,void>)(Handle + vezCmdSetDepthStencilStateOffset);
            vezCmdSetColorBlendState = (delegate* <ref VezColorBlendState,void>)(Handle + vezCmdSetColorBlendStateOffset);
            vezCmdSetViewport = (delegate* <uint,uint,ref VkViewport,void>)(Handle + vezCmdSetViewportOffset);
            vezCmdSetScissor = (delegate* <uint,uint,ref VkRect2D,void>)(Handle + vezCmdSetScissorOffset);
            vezCmdSetLineWidth = (delegate* <float,void>)(Handle + vezCmdSetLineWidthOffset);
            vezCmdSetDepthBias = (delegate* <float,float,float,void>)(Handle + vezCmdSetDepthBiasOffset);
            vezCmdSetBlendConstants = (delegate* <float[],void>)(Handle + vezCmdSetBlendConstantsOffset);
            vezCmdSetDepthBounds = (delegate* <float,float,void>)(Handle + vezCmdSetDepthBoundsOffset);
            vezCmdSetStencilCompareMask = (delegate* <VkStencilFaceFlagBits,uint,void>)(Handle + vezCmdSetStencilCompareMaskOffset);
            vezCmdSetStencilWriteMask = (delegate* <VkStencilFaceFlagBits,uint,void>)(Handle + vezCmdSetStencilWriteMaskOffset);
            vezCmdSetStencilReference = (delegate* <VkStencilFaceFlagBits,uint,void>)(Handle + vezCmdSetStencilReferenceOffset);
            vezCmdDraw = (delegate* <uint,uint,uint,uint,void>)(Handle + vezCmdDrawOffset);
            vezCmdDrawIndexed = (delegate* <uint,uint,uint,int,uint,void>)(Handle + vezCmdDrawIndexedOffset);
            vezCmdDrawIndirect = (delegate* <VkBuffer,ulong,uint,uint,void>)(Handle + vezCmdDrawIndirectOffset);
            vezCmdDrawIndexedIndirect = (delegate* <VkBuffer,ulong,uint,uint,void>)(Handle + vezCmdDrawIndexedIndirectOffset);
            vezCmdDispatch = (delegate* <uint,uint,uint,void>)(Handle + vezCmdDispatchOffset);
            vezCmdDispatchIndirect = (delegate* <VkBuffer,ulong,void>)(Handle + vezCmdDispatchIndirectOffset);
            vezCmdCopyBuffer = (delegate* <VkBuffer,VkBuffer,uint,ref VezBufferCopy,void>)(Handle + vezCmdCopyBufferOffset);
            vezCmdCopyImage = (delegate* <VkImage,VkImage,uint,ref VezImageCopy,void>)(Handle + vezCmdCopyImageOffset);
            vezCmdBlitImage = (delegate* <VkImage,VkImage,uint,ref VezImageBlit,VkFilter,void>)(Handle + vezCmdBlitImageOffset);
            vezCmdCopyBufferToImage = (delegate* <VkBuffer,VkImage,uint,ref VezBufferImageCopy,void>)(Handle + vezCmdCopyBufferToImageOffset);
            vezCmdCopyImageToBuffer = (delegate* <VkImage,VkBuffer,uint,ref VezBufferImageCopy,void>)(Handle + vezCmdCopyImageToBufferOffset);
            vezCmdUpdateBuffer = (delegate* <VkBuffer,ulong,ulong,nint,void>)(Handle + vezCmdUpdateBufferOffset);
            vezCmdFillBuffer = (delegate* <VkBuffer,ulong,ulong,uint,void>)(Handle + vezCmdFillBufferOffset);
            vezCmdClearColorImage = (delegate* <VkImage,ref VkClearColorValue,uint,ref VezImageSubresourceRange,void>)(Handle + vezCmdClearColorImageOffset);
            vezCmdClearDepthStencilImage = (delegate* <VkImage,ref VkClearDepthStencilValue,uint,ref VezImageSubresourceRange,void>)(Handle + vezCmdClearDepthStencilImageOffset);
            vezCmdClearAttachments = (delegate* <uint,ref VezClearAttachment,uint,ref VkClearRect,void>)(Handle + vezCmdClearAttachmentsOffset);
            vezCmdResolveImage = (delegate* <VkImage,VkImage,uint,ref VezImageResolve,void>)(Handle + vezCmdResolveImageOffset);
            vezCmdSetEvent = (delegate* <VkEvent,VkPipelineStageFlagBits,void>)(Handle + vezCmdSetEventOffset);
            vezCmdResetEvent = (delegate* <VkEvent,VkPipelineStageFlagBits,void>)(Handle + vezCmdResetEventOffset);
            vezImportVkImage = (delegate* <VkDevice,VkImage,VkFormat,VkExtent3D,VkSampleCountFlagBits,VkImageLayout,VkResult>)(Handle + vezImportVkImageOffset);
            vezRemoveImportedVkImage = (delegate* <VkDevice,VkImage,VkResult>)(Handle + vezRemoveImportedVkImageOffset);
            vezGetImageLayout = (delegate* <VkDevice,VkImage,ref VkImageLayout,VkResult>)(Handle + vezGetImageLayoutOffset);

            #endregion

#elif LOAD_FROM_GETEXPORT
            #region LOAD_FROM_GETEXPORT
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)NativeLibrary.GetExport(Handle, "vkGetInstanceProcAddr");
            
            #endregion

#endif
        }
    }
}
