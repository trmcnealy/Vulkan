// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Linq;

#if x86
using size_t = System.UInt32;
#else
using size_t = System.UInt64;
#endif


namespace Vulkan
{
    public static partial class Api
    {
        public static readonly uint ApiVersion;

        public static readonly string DLL_NAME;

        public static readonly nint Handle;

        #region RVAs v1.2.189.2

        public static readonly nint vkAcquireNextImage2KHROffset                          = 0x00008410;
        public static readonly nint vkAcquireNextImageKHROffset                           = 0x000096C0;
        public static readonly nint vkAllocateCommandBuffersOffset                        = 0x00001540;
        public static readonly nint vkAllocateDescriptorSetsOffset                        = 0x0000C1B0;
        public static readonly nint vkAllocateMemoryOffset                                = 0x00007740;
        public static readonly nint vkBeginCommandBufferOffset                            = 0x00002F30;
        public static readonly nint vkBindBufferMemoryOffset                              = 0x0000B980;
        public static readonly nint vkBindBufferMemory2Offset                             = 0x000069A0;
        public static readonly nint vkBindImageMemoryOffset                               = 0x0000B9D0;
        public static readonly nint vkBindImageMemory2Offset                              = 0x0000CCE0;
        public static readonly nint vkCmdBeginQueryOffset                                 = 0x0000BEA0;
        public static readonly nint vkCmdBeginRenderPassOffset                            = 0x00001090;
        public static readonly nint vkCmdBeginRenderPass2Offset                           = 0x000013D0;
        public static readonly nint vkCmdBindDescriptorSetsOffset                         = 0x00001D10;
        public static readonly nint vkCmdBindIndexBufferOffset                            = 0x0000B030;
        public static readonly nint vkCmdBindPipelineOffset                               = 0x00007C20;
        public static readonly nint vkCmdBindVertexBuffersOffset                          = 0x0000A010;
        public static readonly nint vkCmdBlitImageOffset                                  = 0x00008820;
        public static readonly nint vkCmdClearAttachmentsOffset                           = 0x000021B0;
        public static readonly nint vkCmdClearColorImageOffset                            = 0x00005880;
        public static readonly nint vkCmdClearDepthStencilImageOffset                     = 0x00008F60;
        public static readonly nint vkCmdCopyBufferOffset                                 = 0x00004A80;
        public static readonly nint vkCmdCopyBufferToImageOffset                          = 0x00008BB0;
        public static readonly nint vkCmdCopyImageOffset                                  = 0x00007510;
        public static readonly nint vkCmdCopyImageToBufferOffset                          = 0x00007D00;
        public static readonly nint vkCmdCopyQueryPoolResultsOffset                       = 0x00005F90;
        public static readonly nint vkCmdDispatchOffset                                   = 0x000056D0;
        public static readonly nint vkCmdDispatchBaseOffset                               = 0x000072D0;
        public static readonly nint vkCmdDispatchIndirectOffset                           = 0x00003A30;
        public static readonly nint vkCmdDrawOffset                                       = 0x000098F0;
        public static readonly nint vkCmdDrawIndexedOffset                                = 0x000018E0;
        public static readonly nint vkCmdDrawIndexedIndirectOffset                        = 0x0000BAA0;
        public static readonly nint vkCmdDrawIndexedIndirectCountOffset                   = 0x00002270;
        public static readonly nint vkCmdDrawIndirectOffset                               = 0x00007FB0;
        public static readonly nint vkCmdDrawIndirectCountOffset                          = 0x00004420;
        public static readonly nint vkCmdEndQueryOffset                                   = 0x00009120;
        public static readonly nint vkCmdEndRenderPassOffset                              = 0x00001CB0;
        public static readonly nint vkCmdEndRenderPass2Offset                             = 0x00008C50;
        public static readonly nint vkCmdExecuteCommandsOffset                            = 0x0000BF50;
        public static readonly nint vkCmdFillBufferOffset                                 = 0x0000A750;
        public static readonly nint vkCmdNextSubpassOffset                                = 0x0000C080;
        public static readonly nint vkCmdNextSubpass2Offset                               = 0x0000CC40;
        public static readonly nint vkCmdPipelineBarrierOffset                            = 0x00008870;
        public static readonly nint vkCmdPushConstantsOffset                              = 0x00003270;
        public static readonly nint vkCmdResetEventOffset                                 = 0x0000A7C0;
        public static readonly nint vkCmdResetQueryPoolOffset                             = 0x0000A840;
        public static readonly nint vkCmdResolveImageOffset                               = 0x000098A0;
        public static readonly nint vkCmdSetBlendConstantsOffset                          = 0x00002FE0;
        public static readonly nint vkCmdSetDepthBiasOffset                               = 0x000013B0;
        public static readonly nint vkCmdSetDepthBoundsOffset                             = 0x000061C0;
        public static readonly nint vkCmdSetDeviceMaskOffset                              = 0x00008070;
        public static readonly nint vkCmdSetEventOffset                                   = 0x00009080;
        public static readonly nint vkCmdSetLineWidthOffset                               = 0x000015A0;
        public static readonly nint vkCmdSetScissorOffset                                 = 0x0000BCE0;
        public static readonly nint vkCmdSetStencilCompareMaskOffset                      = 0x00006930;
        public static readonly nint vkCmdSetStencilReferenceOffset                        = 0x00006DE0;
        public static readonly nint vkCmdSetStencilWriteMaskOffset                        = 0x0000B2C0;
        public static readonly nint vkCmdSetViewportOffset                                = 0x00001A80;
        public static readonly nint vkCmdUpdateBufferOffset                               = 0x000091E0;
        public static readonly nint vkCmdWaitEventsOffset                                 = 0x00001A90;
        public static readonly nint vkCmdWriteTimestampOffset                             = 0x00008510;
        public static readonly nint vkCreateBufferOffset                                  = 0x000098E0;
        public static readonly nint vkCreateBufferViewOffset                              = 0x00006E10;
        public static readonly nint vkCreateCommandPoolOffset                             = 0x0000BBC0;
        public static readonly nint vkCreateComputePipelinesOffset                        = 0x0000BA50;
        public static readonly nint vkCreateDescriptorPoolOffset                          = 0x00005110;
        public static readonly nint vkCreateDescriptorSetLayoutOffset                     = 0x0000C120;
        public static readonly nint vkCreateDescriptorUpdateTemplateOffset                = 0x00008CB0;
        public static readonly nint vkCreateDeviceOffset                                  = 0x000097E0;
        public static readonly nint vkCreateDisplayModeKHROffset                          = 0x0000C600;
        public static readonly nint vkCreateDisplayPlaneSurfaceKHROffset                  = 0x0000A970;
        public static readonly nint vkCreateEventOffset                                   = 0x00003C50;
        public static readonly nint vkCreateFenceOffset                                   = 0x000046C0;
        public static readonly nint vkCreateFramebufferOffset                             = 0x00002650;
        public static readonly nint vkCreateGraphicsPipelinesOffset                       = 0x00003F80;
        public static readonly nint vkCreateImageOffset                                   = 0x00003B00;
        public static readonly nint vkCreateImageViewOffset                               = 0x00003210;
        public static readonly nint vkCreateInstanceOffset                                = 0x00005310;
        public static readonly nint vkCreatePipelineCacheOffset                           = 0x0000A2C0;
        public static readonly nint vkCreatePipelineLayoutOffset                          = 0x0000BD00;
        public static readonly nint vkCreateQueryPoolOffset                               = 0x00003CC0;
        public static readonly nint vkCreateRenderPassOffset                              = 0x00007020;
        public static readonly nint vkCreateRenderPass2Offset                             = 0x0000AD70;
        public static readonly nint vkCreateSamplerOffset                                 = 0x00002B90;
        public static readonly nint vkCreateSamplerYcbcrConversionOffset                  = 0x000093A0;
        public static readonly nint vkCreateSemaphoreOffset                               = 0x00001C30;
        public static readonly nint vkCreateShaderModuleOffset                            = 0x00005810;
        public static readonly nint vkCreateSharedSwapchainsKHROffset                     = 0x00008DB0;
        public static readonly nint vkCreateSwapchainKHROffset                            = 0x00009F70;
        public static readonly nint vkDestroyBufferOffset                                 = 0x00005200;
        public static readonly nint vkDestroyBufferViewOffset                             = 0x000050B0;
        public static readonly nint vkDestroyCommandPoolOffset                            = 0x0000B8A0;
        public static readonly nint vkDestroyDescriptorPoolOffset                         = 0x000070C0;
        public static readonly nint vkDestroyDescriptorSetLayoutOffset                    = 0x00008370;
        public static readonly nint vkDestroyDescriptorUpdateTemplateOffset               = 0x00002D20;
        public static readonly nint vkDestroyDeviceOffset                                 = 0x000050C0;
        public static readonly nint vkDestroyEventOffset                                  = 0x00006DD0;
        public static readonly nint vkDestroyFenceOffset                                  = 0x00007250;
        public static readonly nint vkDestroyFramebufferOffset                            = 0x00006180;
        public static readonly nint vkDestroyImageOffset                                  = 0x00006C20;
        public static readonly nint vkDestroyImageViewOffset                              = 0x00008220;
        public static readonly nint vkDestroyInstanceOffset                               = 0x000055F0;
        public static readonly nint vkDestroyPipelineOffset                               = 0x0000BB70;
        public static readonly nint vkDestroyPipelineCacheOffset                          = 0x00009920;
        public static readonly nint vkDestroyPipelineLayoutOffset                         = 0x00008B90;
        public static readonly nint vkDestroyQueryPoolOffset                              = 0x00003AF0;
        public static readonly nint vkDestroyRenderPassOffset                             = 0x00009EE0;
        public static readonly nint vkDestroySamplerOffset                                = 0x000035D0;
        public static readonly nint vkDestroySamplerYcbcrConversionOffset                 = 0x00007F60;
        public static readonly nint vkDestroySemaphoreOffset                              = 0x00003BE0;
        public static readonly nint vkDestroyShaderModuleOffset                           = 0x0000C070;
        public static readonly nint vkDestroySurfaceKHROffset                             = 0x00003850;
        public static readonly nint vkDestroySwapchainKHROffset                           = 0x00001E40;
        public static readonly nint vkDeviceWaitIdleOffset                                = 0x00008B70;
        public static readonly nint vkEndCommandBufferOffset                              = 0x00007220;
        public static readonly nint vkEnumerateDeviceExtensionPropertiesOffset            = 0x0000B9F0;
        public static readonly nint vkEnumerateDeviceLayerPropertiesOffset                = 0x0000B330;
        public static readonly nint vkEnumerateInstanceExtensionPropertiesOffset          = 0x00003250;
        public static readonly nint vkEnumerateInstanceLayerPropertiesOffset              = 0x0000B6D0;
        public static readonly nint vkEnumerateInstanceVersionOffset                      = 0x0000BF30;
        public static readonly nint vkEnumeratePhysicalDeviceGroupsOffset                 = 0x00007A30;
        public static readonly nint vkEnumeratePhysicalDevicesOffset                      = 0x00004D30;
        public static readonly nint vkFlushMappedMemoryRangesOffset                       = 0x00008740;
        public static readonly nint vkFreeCommandBuffersOffset                            = 0x00007940;
        public static readonly nint vkFreeDescriptorSetsOffset                            = 0x00001430;
        public static readonly nint vkFreeMemoryOffset                                    = 0x00007640;
        public static readonly nint vkGetBufferDeviceAddressOffset                        = 0x00003B60;
        public static readonly nint vkGetBufferMemoryRequirementsOffset                   = 0x00005950;
        public static readonly nint vkGetBufferMemoryRequirements2Offset                  = 0x0000A400;
        public static readonly nint vkGetBufferOpaqueCaptureAddressOffset                 = 0x00008290;
        public static readonly nint vkGetDescriptorSetLayoutSupportOffset                 = 0x0000A2B0;
        public static readonly nint vkGetDeviceGroupPeerMemoryFeaturesOffset              = 0x00004620;
        public static readonly nint vkGetDeviceGroupPresentCapabilitiesKHROffset          = 0x000085B0;
        public static readonly nint vkGetDeviceGroupSurfacePresentModesKHROffset          = 0x0000AC00;
        public static readonly nint vkGetDeviceMemoryCommitmentOffset                     = 0x000039E0;
        public static readonly nint vkGetDeviceMemoryOpaqueCaptureAddressOffset           = 0x0000AC40;
        public static readonly nint vkGetDeviceProcAddrOffset                             = 0x00007420;
        public static readonly nint vkGetDeviceQueueOffset                                = 0x00009FB0;
        public static readonly nint vkGetDeviceQueue2Offset                               = 0x00005D70;
        public static readonly nint vkGetDisplayModeProperties2KHROffset                  = 0x00006390;
        public static readonly nint vkGetDisplayModePropertiesKHROffset                   = 0x00007D40;
        public static readonly nint vkGetDisplayPlaneCapabilities2KHROffset               = 0x000068E0;
        public static readonly nint vkGetDisplayPlaneCapabilitiesKHROffset                = 0x0000CA40;
        public static readonly nint vkGetDisplayPlaneSupportedDisplaysKHROffset           = 0x00009420;
        public static readonly nint vkGetEventStatusOffset                                = 0x00007110;
        public static readonly nint vkGetFenceStatusOffset                                = 0x00009E00;
        public static readonly nint vkGetImageMemoryRequirementsOffset                    = 0x00002140;
        public static readonly nint vkGetImageMemoryRequirements2Offset                   = 0x00008B80;
        public static readonly nint vkGetImageSparseMemoryRequirementsOffset              = 0x0000B740;
        public static readonly nint vkGetImageSparseMemoryRequirements2Offset             = 0x0000CCB0;
        public static readonly nint vkGetImageSubresourceLayoutOffset                     = 0x0000B770;
        public static readonly nint vkGetInstanceProcAddrOffset                           = 0x00002200;
        public static readonly nint vkGetPhysicalDeviceDisplayPlaneProperties2KHROffset   = 0x00007B50;
        public static readonly nint vkGetPhysicalDeviceDisplayPlanePropertiesKHROffset    = 0x000081F0;
        public static readonly nint vkGetPhysicalDeviceDisplayProperties2KHROffset        = 0x00004CB0;
        public static readonly nint vkGetPhysicalDeviceDisplayPropertiesKHROffset         = 0x00004D50;
        public static readonly nint vkGetPhysicalDeviceExternalBufferPropertiesOffset     = 0x00006EF0;
        public static readonly nint vkGetPhysicalDeviceExternalFencePropertiesOffset      = 0x00006190;
        public static readonly nint vkGetPhysicalDeviceExternalSemaphorePropertiesOffset  = 0x0000BFD0;
        public static readonly nint vkGetPhysicalDeviceFeaturesOffset                     = 0x0000A620;
        public static readonly nint vkGetPhysicalDeviceFeatures2Offset                    = 0x00006680;
        public static readonly nint vkGetPhysicalDeviceFormatPropertiesOffset             = 0x00002620;
        public static readonly nint vkGetPhysicalDeviceFormatProperties2Offset            = 0x00008E80;
        public static readonly nint vkGetPhysicalDeviceImageFormatPropertiesOffset        = 0x00001EB0;
        public static readonly nint vkGetPhysicalDeviceImageFormatProperties2Offset       = 0x000092C0;
        public static readonly nint vkGetPhysicalDeviceMemoryPropertiesOffset             = 0x00007F20;
        public static readonly nint vkGetPhysicalDeviceMemoryProperties2Offset            = 0x0000C260;
        public static readonly nint vkGetPhysicalDevicePresentRectanglesKHROffset         = 0x00001A70;
        public static readonly nint vkGetPhysicalDevicePropertiesOffset                   = 0x0000B2B0;
        public static readonly nint vkGetPhysicalDeviceProperties2Offset                  = 0x00007880;
        public static readonly nint vkGetPhysicalDeviceQueueFamilyPropertiesOffset        = 0x000064F0;
        public static readonly nint vkGetPhysicalDeviceQueueFamilyProperties2Offset       = 0x00003C80;
        public static readonly nint vkGetPhysicalDeviceSparseImageFormatPropertiesOffset  = 0x00003C10;
        public static readonly nint vkGetPhysicalDeviceSparseImageFormatProperties2Offset = 0x00008450;
        public static readonly nint vkGetPhysicalDeviceSurfaceCapabilities2KHROffset      = 0x00002B40;
        public static readonly nint vkGetPhysicalDeviceSurfaceCapabilitiesKHROffset       = 0x00009A40;
        public static readonly nint vkGetPhysicalDeviceSurfaceFormats2KHROffset           = 0x000049A0;
        public static readonly nint vkGetPhysicalDeviceSurfaceFormatsKHROffset            = 0x00004940;
        public static readonly nint vkGetPhysicalDeviceSurfacePresentModesKHROffset       = 0x00003040;
        public static readonly nint vkGetPhysicalDeviceSurfaceSupportKHROffset            = 0x00006060;
        public static readonly nint vkGetPipelineCacheDataOffset                          = 0x00009350;
        public static readonly nint vkGetQueryPoolResultsOffset                           = 0x00006910;
        public static readonly nint vkGetRenderAreaGranularityOffset                      = 0x00006870;
        public static readonly nint vkGetSemaphoreCounterValueOffset                      = 0x00007860;
        public static readonly nint vkGetSwapchainImagesKHROffset                         = 0x000071E0;
        public static readonly nint vkInvalidateMappedMemoryRangesOffset                  = 0x000065D0;
        public static readonly nint vkMapMemoryOffset                                     = 0x0000C0F0;
        public static readonly nint vkMergePipelineCachesOffset                           = 0x0000A230;
        public static readonly nint vkQueueBindSparseOffset                               = 0x00009DF0;
        public static readonly nint vkQueuePresentKHROffset                               = 0x0000AFE0;
        public static readonly nint vkQueueSubmitOffset                                   = 0x00001940;
        public static readonly nint vkQueueWaitIdleOffset                                 = 0x000063B0;
        public static readonly nint vkResetCommandBufferOffset                            = 0x0000C2D0;
        public static readonly nint vkResetCommandPoolOffset                              = 0x00006520;
        public static readonly nint vkResetDescriptorPoolOffset                           = 0x00008920;
        public static readonly nint vkResetEventOffset                                    = 0x00004280;
        public static readonly nint vkResetFencesOffset                                   = 0x0000CD70;
        public static readonly nint vkResetQueryPoolOffset                                = 0x000092F0;
        public static readonly nint vkSetEventOffset                                      = 0x00004790;
        public static readonly nint vkSignalSemaphoreOffset                               = 0x000035C0;
        public static readonly nint vkTrimCommandPoolOffset                               = 0x00004CF0;
        public static readonly nint vkUnmapMemoryOffset                                   = 0x00002AC0;
        public static readonly nint vkUpdateDescriptorSetWithTemplateOffset               = 0x000014B0;
        public static readonly nint vkUpdateDescriptorSetsOffset                          = 0x000095B0;
        public static readonly nint vkWaitForFencesOffset                                 = 0x00005090;
        public static readonly nint vkWaitSemaphoresOffset                                = 0x000019E0;

        #endregion
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            ApiVersion = Api.MAKE_API_VERSION(1,
                                              2,
                                              189);
            
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libvulkan.so.1";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libvulkan-1.0.0.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "vulkan-1.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "vulkan-1";
            }
            else
            {
                DLL_NAME = "vulkan";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);

#if LOAD_FROM_DEVICEPROCADDR

            #region LOAD_FROM_DEVICEPROCADDR
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset); //NativeLibrary.GetExport(Handle, "vkGetInstanceProcAddr");
            GetDeviceProcAddr = (delegate*<VkDevice, utf8string, nint>)(Handle + vkGetDeviceProcAddrOffset);   //NativeLibrary.GetExport(Handle, "vkGetDeviceProcAddr");
            CreateInstance = (delegate*<ref VkInstanceCreateInfo, VkAllocationCallbacks*, out VkInstance, VkResult>)(Handle + vkCreateInstanceOffset); //NativeLibrary.GetExport(Handle, "vkCreateInstance");

            VkApplicationInfo applicationInfo = new()
            {
                SType = VkStructureType.ApplicationInfo,
                ApiVersion = Api.ApiVersion
            };

            VkInstanceCreateInfo instanceCreateInfo = new()
            {
                SType = VkStructureType.InstanceCreateInfo,
                PApplicationInfo = &applicationInfo
            };

            Api.CreateInstance(ref instanceCreateInfo,
                               VkAllocationCallbacks.Null,
                               out VkInstance instance);

            DestroyInstance = (delegate*<VkInstance, VkAllocationCallbacks*, void>)GetInstanceProcAddr(instance, "vkDestroyInstance");

            _EnumeratePhysicalDevices = (delegate*<VkInstance, out uint, VkPhysicalDevice*, VkResult>)GetInstanceProcAddr(instance, "vkEnumeratePhysicalDevices");//(Handle + vkEnumeratePhysicalDevicesOffset); //NativeLibrary.GetExport(Handle, "vkEnumeratePhysicalDevices");
            _EnumeratePhysicalDeviceGroups = (delegate*<VkInstance, out uint, VkPhysicalDeviceGroupProperties*, VkResult>)GetInstanceProcAddr(instance, "vkEnumeratePhysicalDeviceGroups");//(Handle + vkEnumeratePhysicalDeviceGroupsOffset); //NativeLibrary.GetExport(Handle, "vkEnumeratePhysicalDeviceGroups");

            VkPhysicalDevice[] physicalDevices = Api.GetEnumeratePhysicalDevices(instance);

            VkPhysicalDevice physicalDevice = physicalDevices.First();

            //foreach (VkPhysicalDevice phyDevice in physicalDevices)
            //{
            //    VkPhysicalDeviceProperties physicalDeviceProperties = phyDevice.GetPhysicalDeviceProperties();
            //    if (physicalDeviceProperties.DeviceId == 0)
            //    {
            //        physicalDevice = phyDevice;
            //        break;
            //    }
            //}

            CreateDevice = (delegate*<VkPhysicalDevice, ref VkDeviceCreateInfo, VkAllocationCallbacks*, out VkDevice, VkResult>)GetInstanceProcAddr(instance, "vkCreateDevice");//(Handle + vkCreateDeviceOffset); //NativeLibrary.GetExport(Handle, "vkCreateDevice");

            VkDeviceCreateInfo deviceCreateInfo = new()
            {
                SType = VkStructureType.DeviceCreateInfo
            };

            Api.CreateDevice(physicalDevice,
                             ref deviceCreateInfo,
                             VkAllocationCallbacks.Null,
                             out VkDevice device);

            _EnumerateInstanceExtensionProperties = (delegate*<utf8string, out uint, VkExtensionProperties*, VkResult>)GetDeviceProcAddr(device, "vkEnumerateInstanceExtensionProperties");
            _EnumerateInstanceLayerProperties = (delegate*<out uint, VkLayerProperties*, VkResult>)GetDeviceProcAddr(device, "vkEnumerateInstanceLayerProperties");
            _EnumerateDeviceExtensionProperties = (delegate*<VkPhysicalDevice, utf8string, out uint, VkExtensionProperties*, VkResult>)GetDeviceProcAddr(device, "vkEnumerateDeviceExtensionProperties");
            _EnumerateDeviceLayerProperties = (delegate*<VkPhysicalDevice, out uint, VkLayerProperties*, VkResult>)GetDeviceProcAddr(device, "vkEnumerateDeviceLayerProperties");

            GetPhysicalDeviceFeatures = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceFeatures, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceFeatures");
            GetPhysicalDeviceFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, out VkFormatProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceFormatProperties");
            GetPhysicalDeviceImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, out VkImageFormatProperties, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceImageFormatProperties");
            GetPhysicalDeviceProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceProperties");
            _GetPhysicalDeviceQueueFamilyProperties = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties*, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceQueueFamilyProperties");
            GetPhysicalDeviceMemoryProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceMemoryProperties");

            CreateDisplayPlaneSurfaceKHR = (delegate*<VkInstance, ref VkDisplaySurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult>)GetDeviceProcAddr(device, "vkCreateDisplayPlaneSurfaceKHR");

            DestroyDevice = (delegate*<VkDevice, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyDevice");
            DestroySurfaceKHR = (delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroySurfaceKHR");

            GetDeviceQueue = (delegate*<VkDevice, uint, uint, out VkQueue, void>)GetDeviceProcAddr(device, "vkGetDeviceQueue");
            _QueueSubmit = (delegate*<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult>)GetDeviceProcAddr(device, "vkQueueSubmit");
            QueueWaitIdle = (delegate*<VkQueue, VkResult>)GetDeviceProcAddr(device, "vkQueueWaitIdle");
            DeviceWaitIdle = (delegate*<VkDevice, VkResult>)GetDeviceProcAddr(device, "vkDeviceWaitIdle");

            AllocateMemory = (delegate*<VkDevice, ref VkMemoryAllocateInfo, VkAllocationCallbacks*, out VkDeviceMemory, VkResult>)GetDeviceProcAddr(device, "vkAllocateMemory");
            FreeMemory = (delegate*<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkFreeMemory");
            MapMemory = (delegate*<VkDevice, VkDeviceMemory, ulong, ulong, uint, out nint, VkResult>)GetDeviceProcAddr(device, "vkMapMemory");
            UnmapMemory = (delegate*<VkDevice, VkDeviceMemory, void>)GetDeviceProcAddr(device, "vkUnmapMemory");

            _FlushMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)GetDeviceProcAddr(device, "vkFlushMappedMemoryRanges");
            _InvalidateMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)GetDeviceProcAddr(device, "vkInvalidateMappedMemoryRanges");

            GetDeviceMemoryCommitment = (delegate*<VkDevice, VkDeviceMemory, out ulong, void>)GetDeviceProcAddr(device, "vkGetDeviceMemoryCommitment");
            BindBufferMemory = (delegate*<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult>)GetDeviceProcAddr(device, "vkBindBufferMemory");
            BindImageMemory = (delegate*<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult>)GetDeviceProcAddr(device, "vkBindImageMemory");
            GetBufferMemoryRequirements = (delegate*<VkDevice, VkBuffer, out VkMemoryRequirements, void>)GetDeviceProcAddr(device, "vkGetBufferMemoryRequirements");
            GetImageMemoryRequirements = (delegate*<VkDevice, VkImage, out VkMemoryRequirements, void>)GetDeviceProcAddr(device, "vkGetImageMemoryRequirements");
            _GetImageSparseMemoryRequirements = (delegate*<VkDevice, VkImage, out uint, VkSparseImageMemoryRequirements*, void>)GetDeviceProcAddr(device, "vkGetImageSparseMemoryRequirements");
            _GetPhysicalDeviceSparseImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, out uint, VkSparseImageFormatProperties*, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSparseImageFormatProperties");
            _QueueBindSparse = (delegate*<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)GetDeviceProcAddr(device, "vkQueueBindSparse");
            CreateFence = (delegate*<VkDevice, ref VkFenceCreateInfo, VkAllocationCallbacks*, out VkFence, VkResult>)GetDeviceProcAddr(device, "vkCreateFence");
            DestroyFence = (delegate*<VkDevice, VkFence, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyFence");
            _ResetFences = (delegate*<VkDevice, uint, VkFence*, VkResult>)GetDeviceProcAddr(device, "vkResetFences");
            GetFenceStatus = (delegate*<VkDevice, VkFence, VkResult>)GetDeviceProcAddr(device, "vkGetFenceStatus");
            _WaitForFences = (delegate*<VkDevice, uint, VkFence*, uint, ulong, VkResult>)GetDeviceProcAddr(device, "vkWaitForFences");
            CreateSemaphore = (delegate*<VkDevice, ref VkSemaphoreCreateInfo, VkAllocationCallbacks*, out VkSemaphore, VkResult>)GetDeviceProcAddr(device, "vkCreateSemaphore");
            DestroySemaphore = (delegate*<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroySemaphore");
            CreateEvent = (delegate*<VkDevice, ref VkEventCreateInfo, VkAllocationCallbacks*, out VkEvent, VkResult>)GetDeviceProcAddr(device, "vkCreateEvent");
            DestroyEvent = (delegate*<VkDevice, VkEvent, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyEvent");
            GetEventStatus = (delegate*<VkDevice, VkEvent, VkResult>)GetDeviceProcAddr(device, "vkGetEventStatus");
            SetEvent = (delegate*<VkDevice, VkEvent, VkResult>)GetDeviceProcAddr(device, "vkSetEvent");
            ResetEvent = (delegate*<VkDevice, VkEvent, VkResult>)GetDeviceProcAddr(device, "vkResetEvent");
            CreateQueryPool = (delegate*<VkDevice, ref VkQueryPoolCreateInfo, VkAllocationCallbacks*, out VkQueryPool, VkResult>)GetDeviceProcAddr(device, "vkCreateQueryPool");
            DestroyQueryPool = (delegate*<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyQueryPool");
            GetQueryPoolResults = (delegate*<VkDevice, VkQueryPool, uint, uint, nuint, nint, ulong, VkQueryResultFlagBits, VkResult>)GetDeviceProcAddr(device, "vkGetQueryPoolResults");
            CreateBuffer = (delegate*<VkDevice, ref VkBufferCreateInfo, VkAllocationCallbacks*, out VkBuffer, VkResult>)GetDeviceProcAddr(device, "vkCreateBuffer");
            DestroyBuffer = (delegate*<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyBuffer");
            CreateBufferView = (delegate*<VkDevice, ref VkBufferViewCreateInfo, VkAllocationCallbacks*, out VkBufferView, VkResult>)GetDeviceProcAddr(device, "vkCreateBufferView");
            DestroyBufferView = (delegate*<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyBufferView");
            CreateImage = (delegate*<VkDevice, ref VkImageCreateInfo, VkAllocationCallbacks*, out VkImage, VkResult>)GetDeviceProcAddr(device, "vkCreateImage");
            DestroyImage = (delegate*<VkDevice, VkImage, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyImage");
            GetImageSubresourceLayout = (delegate*<VkDevice, VkImage, ref VkImageSubresource, out VkSubresourceLayout, void>)GetDeviceProcAddr(device, "vkGetImageSubresourceLayout");
            CreateImageView = (delegate*<VkDevice, ref VkImageViewCreateInfo, VkAllocationCallbacks*, out VkImageView, VkResult>)GetDeviceProcAddr(device, "vkCreateImageView");
            DestroyImageView = (delegate*<VkDevice, VkImageView, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyImageView");
            CreateShaderModule = (delegate*<VkDevice, ref VkShaderModuleCreateInfo, VkAllocationCallbacks*, out VkShaderModule, VkResult>)GetDeviceProcAddr(device, "vkCreateShaderModule");
            DestroyShaderModule = (delegate*<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyShaderModule");
            CreatePipelineCache = (delegate*<VkDevice, ref VkPipelineCacheCreateInfo, VkAllocationCallbacks*, out VkPipelineCache, VkResult>)GetDeviceProcAddr(device, "vkCreatePipelineCache");
            DestroyPipelineCache = (delegate*<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyPipelineCache");
            GetPipelineCacheData = (delegate*<VkDevice, VkPipelineCache, ref UIntPtr, nint, VkResult>)GetDeviceProcAddr(device, "vkGetPipelineCacheData");
            _MergePipelineCaches = (delegate*<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult>)GetDeviceProcAddr(device, "vkMergePipelineCaches");
            _CreateGraphicsPipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)GetDeviceProcAddr(device, "vkCreateGraphicsPipelines");
            _CreateComputePipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)GetDeviceProcAddr(device, "vkCreateComputePipelines");
            DestroyPipeline = (delegate*<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyPipeline");
            CreatePipelineLayout = (delegate*<VkDevice, ref VkPipelineLayoutCreateInfo, VkAllocationCallbacks*, out VkPipelineLayout, VkResult>)GetDeviceProcAddr(device, "vkCreatePipelineLayout");
            DestroyPipelineLayout = (delegate*<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyPipelineLayout");
            CreateSampler = (delegate*<VkDevice, ref VkSamplerCreateInfo, VkAllocationCallbacks*, out VkSampler, VkResult>)GetDeviceProcAddr(device, "vkCreateSampler");
            DestroySampler = (delegate*<VkDevice, VkSampler, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroySampler");
            CreateDescriptorSetLayout = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, VkAllocationCallbacks*, out VkDescriptorSetLayout, VkResult>)GetDeviceProcAddr(device, "vkCreateDescriptorSetLayout");
            DestroyDescriptorSetLayout = (delegate*<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyDescriptorSetLayout");
            CreateDescriptorPool = (delegate*<VkDevice, ref VkDescriptorPoolCreateInfo, VkAllocationCallbacks*, out VkDescriptorPool, VkResult>)GetDeviceProcAddr(device, "vkCreateDescriptorPool");
            DestroyDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyDescriptorPool");
            ResetDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, uint, VkResult>)GetDeviceProcAddr(device, "vkResetDescriptorPool");
            _AllocateDescriptorSets = (delegate*<VkDevice, ref VkDescriptorSetAllocateInfo, VkDescriptorSet*, VkResult>)GetDeviceProcAddr(device, "vkAllocateDescriptorSets");
            _FreeDescriptorSets = (delegate*<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult>)GetDeviceProcAddr(device, "vkFreeDescriptorSets");
            _UpdateDescriptorSets = (delegate*<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void>)GetDeviceProcAddr(device, "vkUpdateDescriptorSets");
            CreateFramebuffer = (delegate*<VkDevice, ref VkFramebufferCreateInfo, VkAllocationCallbacks*, out VkFramebuffer, VkResult>)GetDeviceProcAddr(device, "vkCreateFramebuffer");
            DestroyFramebuffer = (delegate*<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyFramebuffer");
            CreateRenderPass = (delegate*<VkDevice, ref VkRenderPassCreateInfo, VkAllocationCallbacks*, out VkRenderPass, VkResult>)GetDeviceProcAddr(device, "vkCreateRenderPass");
            DestroyRenderPass = (delegate*<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyRenderPass");
            GetRenderAreaGranularity = (delegate*<VkDevice, VkRenderPass, out VkExtent2D, void>)GetDeviceProcAddr(device, "vkGetRenderAreaGranularity");
            CreateCommandPool = (delegate*<VkDevice, ref VkCommandPoolCreateInfo, VkAllocationCallbacks*, out VkCommandPool, VkResult>)GetDeviceProcAddr(device, "vkCreateCommandPool");
            DestroyCommandPool = (delegate*<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyCommandPool");
            ResetCommandPool = (delegate*<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult>)GetDeviceProcAddr(device, "vkResetCommandPool");
            _AllocateCommandBuffers = (delegate*<VkDevice, ref VkCommandBufferAllocateInfo, VkCommandBuffer*, VkResult>)GetDeviceProcAddr(device, "vkAllocateCommandBuffers");
            _FreeCommandBuffers = (delegate*<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void>)GetDeviceProcAddr(device, "vkFreeCommandBuffers");
            BeginCommandBuffer = (delegate*<VkCommandBuffer, ref VkCommandBufferBeginInfo, VkResult>)GetDeviceProcAddr(device, "vkBeginCommandBuffer");
            EndCommandBuffer = (delegate*<VkCommandBuffer, VkResult>)GetDeviceProcAddr(device, "vkEndCommandBuffer");
            ResetCommandBuffer = (delegate*<VkCommandBuffer, uint, VkResult>)GetDeviceProcAddr(device, "vkResetCommandBuffer");
            CmdBindPipeline = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)GetDeviceProcAddr(device, "vkCmdBindPipeline");
            _CmdSetViewport = (delegate*<VkCommandBuffer, uint, uint, VkViewport*, void>)GetDeviceProcAddr(device, "vkCmdSetViewport");
            _CmdSetScissor = (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>)GetDeviceProcAddr(device, "vkCmdSetScissor");
            CmdSetLineWidth = (delegate*<VkCommandBuffer, float, void>)GetDeviceProcAddr(device, "vkCmdSetLineWidth");
            CmdSetDepthBias = (delegate*<VkCommandBuffer, float, float, float, void>)GetDeviceProcAddr(device, "vkCmdSetDepthBias");
            CmdSetBlendConstants = (delegate*<VkCommandBuffer, ref float, void>)GetDeviceProcAddr(device, "vkCmdSetBlendConstants");
            CmdSetDepthBounds = (delegate*<VkCommandBuffer, float, float, void>)GetDeviceProcAddr(device, "vkCmdSetDepthBounds");
            CmdSetStencilCompareMask = (delegate*<VkCommandBuffer, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdSetStencilCompareMask");
            CmdSetStencilWriteMask = (delegate*<VkCommandBuffer, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdSetStencilWriteMask");
            CmdSetStencilReference = (delegate*<VkCommandBuffer, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdSetStencilReference");
            _CmdBindDescriptorSets = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void>)GetDeviceProcAddr(device, "vkCmdBindDescriptorSets");
            CmdBindIndexBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void>)GetDeviceProcAddr(device, "vkCmdBindIndexBuffer");
            _CmdBindVertexBuffers = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)GetDeviceProcAddr(device, "vkCmdBindVertexBuffers");
            CmdDraw = (delegate*<VkCommandBuffer, uint, uint, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDraw");
            CmdDrawIndexed = (delegate*<VkCommandBuffer, uint, uint, uint, int, uint, void>)GetDeviceProcAddr(device, "vkCmdDrawIndexed");
            CmdDrawIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDrawIndirect");
            CmdDrawIndexedIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirect");
            CmdDispatch = (delegate*<VkCommandBuffer, uint, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDispatch");
            CmdDispatchIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, void>)GetDeviceProcAddr(device, "vkCmdDispatchIndirect");
            _CmdCopyBuffer = (delegate*<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void>)GetDeviceProcAddr(device, "vkCmdCopyBuffer");
            _CmdCopyImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void>)GetDeviceProcAddr(device, "vkCmdCopyImage");
            _CmdBlitImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void>)GetDeviceProcAddr(device, "vkCmdBlitImage");
            _CmdCopyBufferToImage = (delegate*<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void>)GetDeviceProcAddr(device, "vkCmdCopyBufferToImage");
            _CmdCopyImageToBuffer = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)GetDeviceProcAddr(device, "vkCmdCopyImageToBuffer");
            CmdUpdateBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, nint, void>)GetDeviceProcAddr(device, "vkCmdUpdateBuffer");
            CmdFillBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void>)GetDeviceProcAddr(device, "vkCmdFillBuffer");
            _CmdClearColorImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearColorValue, uint, VkImageSubresourceRange*, void>)GetDeviceProcAddr(device, "vkCmdClearColorImage");
            _CmdClearDepthStencilImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void>)GetDeviceProcAddr(device, "vkCmdClearDepthStencilImage");
            _CmdClearAttachments = (delegate*<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void>)GetDeviceProcAddr(device, "vkCmdClearAttachments");
            _CmdResolveImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void>)GetDeviceProcAddr(device, "vkCmdResolveImage");
            CmdSetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)GetDeviceProcAddr(device, "vkCmdSetEvent");
            CmdResetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)GetDeviceProcAddr(device, "vkCmdResetEvent");
            _CmdWaitEvents = (delegate*<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)GetDeviceProcAddr(device, "vkCmdWaitEvents");
            _CmdPipelineBarrier = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)GetDeviceProcAddr(device, "vkCmdPipelineBarrier");
            CmdBeginQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdBeginQuery");
            CmdEndQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, void>)GetDeviceProcAddr(device, "vkCmdEndQuery");
            CmdResetQueryPool = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdResetQueryPool");
            CmdWriteTimestamp = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void>)GetDeviceProcAddr(device, "vkCmdWriteTimestamp");
            CmdCopyQueryPoolResults = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, uint, void>)GetDeviceProcAddr(device, "vkCmdCopyQueryPoolResults");
            CmdPushConstants = (delegate*<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, nint, void>)GetDeviceProcAddr(device, "vkCmdPushConstants");
            CmdBeginRenderPass = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, VkSubpassContents, void>)GetDeviceProcAddr(device, "vkCmdBeginRenderPass");
            CmdNextSubpass = (delegate*<VkCommandBuffer, VkSubpassContents, void>)GetDeviceProcAddr(device, "vkCmdNextSubpass");
            CmdEndRenderPass = (delegate*<VkCommandBuffer, void>)GetDeviceProcAddr(device, "vkCmdEndRenderPass");
            CmdExecuteCommands = (delegate*<VkCommandBuffer, uint, ref VkCommandBuffer, void>)GetDeviceProcAddr(device, "vkCmdExecuteCommands");
            EnumerateInstanceVersion = (delegate*<ref uint, VkResult>)GetDeviceProcAddr(device, "vkEnumerateInstanceVersion");
            BindBufferMemory2 = (delegate*<VkDevice, uint, ref VkBindBufferMemoryInfo, VkResult>)GetDeviceProcAddr(device, "vkBindBufferMemory2");
            BindImageMemory2 = (delegate*<VkDevice, uint, ref VkBindImageMemoryInfo, VkResult>)GetDeviceProcAddr(device, "vkBindImageMemory2");
            GetDeviceGroupPeerMemoryFeatures = (delegate*<VkDevice, uint, uint, uint, ref uint, void>)GetDeviceProcAddr(device, "vkGetDeviceGroupPeerMemoryFeatures");
            CmdSetDeviceMask = (delegate*<VkCommandBuffer, uint, void>)GetDeviceProcAddr(device, "vkCmdSetDeviceMask");
            CmdDispatchBase = (delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDispatchBase");
            GetImageMemoryRequirements2 = (delegate*<VkDevice, ref VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)GetDeviceProcAddr(device, "vkGetImageMemoryRequirements2");
            GetBufferMemoryRequirements2 = (delegate*<VkDevice, ref VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)GetDeviceProcAddr(device, "vkGetBufferMemoryRequirements2");
            _GetImageSparseMemoryRequirements2 = (delegate*<VkDevice, ref VkImageSparseMemoryRequirementsInfo2, out uint, VkSparseImageMemoryRequirements2*, void>)GetDeviceProcAddr(device, "vkGetImageSparseMemoryRequirements2");
            GetPhysicalDeviceFeatures2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceFeatures2, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceFeatures2");
            GetPhysicalDeviceProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceProperties2, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceProperties2");
            GetPhysicalDeviceFormatProperties2 = (delegate*<VkPhysicalDevice, VkFormat, ref VkFormatProperties2, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceFormatProperties2");
            GetPhysicalDeviceImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceImageFormatProperties2");
            _GetPhysicalDeviceQueueFamilyProperties2 = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties2*, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceQueueFamilyProperties2");
            GetPhysicalDeviceMemoryProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceMemoryProperties2, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceMemoryProperties2");
            _GetPhysicalDeviceSparseImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2, out uint, VkSparseImageFormatProperties2*, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSparseImageFormatProperties2");
            TrimCommandPool = (delegate*<VkDevice, VkCommandPool, uint, void>)GetDeviceProcAddr(device, "vkTrimCommandPool");
            GetDeviceQueue2 = (delegate*<VkDevice, ref VkDeviceQueueInfo2, ref VkQueue, void>)GetDeviceProcAddr(device, "vkGetDeviceQueue2");
            CreateSamplerYcbcrConversion = (delegate*<VkDevice, ref VkSamplerYcbcrConversionCreateInfo, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult>)GetDeviceProcAddr(device, "vkCreateSamplerYcbcrConversion");
            DestroySamplerYcbcrConversion = (delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroySamplerYcbcrConversion");
            CreateDescriptorUpdateTemplate = (delegate*<VkDevice, ref VkDescriptorUpdateTemplateCreateInfo, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult>)GetDeviceProcAddr(device, "vkCreateDescriptorUpdateTemplate");
            DestroyDescriptorUpdateTemplate = (delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroyDescriptorUpdateTemplate");
            UpdateDescriptorSetWithTemplate = (delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, nint, void>)GetDeviceProcAddr(device, "vkUpdateDescriptorSetWithTemplate");
            GetPhysicalDeviceExternalBufferProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceExternalBufferProperties");
            GetPhysicalDeviceExternalFenceProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceExternalFenceProperties");
            GetPhysicalDeviceExternalSemaphoreProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceExternalSemaphoreProperties");
            GetDescriptorSetLayoutSupport = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)GetDeviceProcAddr(device, "vkGetDescriptorSetLayoutSupport");
            CmdDrawIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDrawIndirectCount");
            CmdDrawIndexedIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)GetDeviceProcAddr(device, "vkCmdDrawIndexedIndirectCount");
            CreateRenderPass2 = (delegate*<VkDevice, ref VkRenderPassCreateInfo2, VkAllocationCallbacks*, out VkRenderPass, VkResult>)GetDeviceProcAddr(device, "vkCreateRenderPass2");
            CmdBeginRenderPass2 = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, ref VkSubpassBeginInfo, void>)GetDeviceProcAddr(device, "vkCmdBeginRenderPass2");
            CmdNextSubpass2 = (delegate*<VkCommandBuffer, ref VkSubpassBeginInfo, ref VkSubpassEndInfo, void>)GetDeviceProcAddr(device, "vkCmdNextSubpass2");
            CmdEndRenderPass2 = (delegate*<VkCommandBuffer, ref VkSubpassEndInfo, void>)GetDeviceProcAddr(device, "vkCmdEndRenderPass2");
            ResetQueryPool = (delegate*<VkDevice, VkQueryPool, uint, uint, void>)GetDeviceProcAddr(device, "vkResetQueryPool");
            GetSemaphoreCounterValue = (delegate*<VkDevice, VkSemaphore, ref ulong, VkResult>)GetDeviceProcAddr(device, "vkGetSemaphoreCounterValue");
            WaitSemaphores = (delegate*<VkDevice, ref VkSemaphoreWaitInfo, ulong, VkResult>)GetDeviceProcAddr(device, "vkWaitSemaphores");
            SignalSemaphore = (delegate*<VkDevice, ref VkSemaphoreSignalInfo, VkResult>)GetDeviceProcAddr(device, "vkSignalSemaphore");
            GetBufferDeviceAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)GetDeviceProcAddr(device, "vkGetBufferDeviceAddress");
            GetBufferOpaqueCaptureAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)GetDeviceProcAddr(device, "vkGetBufferOpaqueCaptureAddress");
            GetDeviceMemoryOpaqueCaptureAddress = (delegate*<VkDevice, ref VkDeviceMemoryOpaqueCaptureAddressInfo, ulong>)GetDeviceProcAddr(device, "vkGetDeviceMemoryOpaqueCaptureAddress");
            GetPhysicalDeviceSurfaceSupportKHR = (delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, out uint, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfaceSupportKHR");
            GetPhysicalDeviceSurfaceCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
            _GetPhysicalDeviceSurfaceFormatsKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfaceFormatsKHR");
            _GetPhysicalDeviceSurfacePresentModesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkPresentModeKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfacePresentModesKHR");
            CreateSwapchainKHR = (delegate*<VkDevice, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)GetDeviceProcAddr(device, "vkCreateSwapchainKHR");
            DestroySwapchainKHR = (delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)GetDeviceProcAddr(device, "vkDestroySwapchainKHR");
            _GetSwapchainImagesKHR = (delegate*<VkDevice, VkSwapchainKHR, out uint, VkImage*, VkResult>)GetDeviceProcAddr(device, "vkGetSwapchainImagesKHR");
            AcquireNextImageKHR = (delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult>)GetDeviceProcAddr(device, "vkAcquireNextImageKHR");
            QueuePresentKHR = (delegate*<VkQueue, ref VkPresentInfoKHR, VkResult>)GetDeviceProcAddr(device, "vkQueuePresentKHR");
            GetDeviceGroupPresentCapabilitiesKHR = (delegate*<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>)GetDeviceProcAddr(device, "vkGetDeviceGroupPresentCapabilitiesKHR");
            GetDeviceGroupSurfacePresentModesKHR = (delegate*<VkDevice, VkSurfaceKHR, ref uint, VkResult>)GetDeviceProcAddr(device, "vkGetDeviceGroupSurfacePresentModesKHR");
            _GetPhysicalDevicePresentRectanglesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkRect2D*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDevicePresentRectanglesKHR");
            AcquireNextImage2KHR = (delegate*<VkDevice, ref VkAcquireNextImageInfoKHR, ref uint, VkResult>)GetDeviceProcAddr(device, "vkAcquireNextImage2KHR");
            _GetPhysicalDeviceDisplayPropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPropertiesKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceDisplayPropertiesKHR");
            _GetPhysicalDeviceDisplayPlanePropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlanePropertiesKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
            _GetDisplayPlaneSupportedDisplaysKHR = (delegate*<VkPhysicalDevice, uint, out uint, VkDisplayKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetDisplayPlaneSupportedDisplaysKHR");
            _GetDisplayModePropertiesKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModePropertiesKHR*, VkResult>)GetDeviceProcAddr(device, "vkGetDisplayModePropertiesKHR");
            CreateDisplayModeKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, ref VkDisplayModeCreateInfoKHR, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult>)GetDeviceProcAddr(device, "vkCreateDisplayModeKHR");
            GetDisplayPlaneCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, ref VkDisplayPlaneCapabilitiesKHR, VkResult>)GetDeviceProcAddr(device, "vkGetDisplayPlaneCapabilitiesKHR");
            CreateSharedSwapchainsKHR = (delegate*<VkDevice, uint, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)GetDeviceProcAddr(device, "vkCreateSharedSwapchainsKHR");
            GetPhysicalDeviceSurfaceCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, ref VkSurfaceCapabilities2KHR, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfaceCapabilities2KHR");
            _GetPhysicalDeviceSurfaceFormats2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkSurfaceFormat2KHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceSurfaceFormats2KHR");
            _GetPhysicalDeviceDisplayProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayProperties2KHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceDisplayProperties2KHR");
            _GetPhysicalDeviceDisplayPlaneProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlaneProperties2KHR*, VkResult>)GetDeviceProcAddr(device, "vkGetPhysicalDeviceDisplayPlaneProperties2KHR");
            _GetDisplayModeProperties2KHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModeProperties2KHR*, VkResult>)GetDeviceProcAddr(device, "vkGetDisplayModeProperties2KHR");
            GetDisplayPlaneCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>)GetDeviceProcAddr(device, "vkGetDisplayPlaneCapabilities2KHR");

            DestroyDevice(device, null);
            DestroyInstance(instance, null); 
            #endregion

#elif true //LOAD_FROM_RVA

            #region LOAD_FROM_RVA
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset);
            GetDeviceProcAddr = (delegate*<VkDevice, utf8string, nint>)(Handle + vkGetDeviceProcAddrOffset);

            _EnumeratePhysicalDevices = (delegate*<VkInstance, out uint, VkPhysicalDevice*, VkResult>)(Handle + vkEnumeratePhysicalDevicesOffset);
            _EnumeratePhysicalDeviceGroups = (delegate*<VkInstance, out uint, VkPhysicalDeviceGroupProperties*, VkResult>)(Handle + vkEnumeratePhysicalDeviceGroupsOffset);

            CreateInstance = (delegate*<ref VkInstanceCreateInfo, VkAllocationCallbacks*, out VkInstance, VkResult>)(Handle + vkCreateInstanceOffset);
            CreateDevice = (delegate*<VkPhysicalDevice, ref VkDeviceCreateInfo, VkAllocationCallbacks*, out VkDevice, VkResult>)(Handle + vkCreateDeviceOffset);

            _EnumerateInstanceExtensionProperties = (delegate*<utf8string, out uint, VkExtensionProperties*, VkResult>)(Handle + vkEnumerateInstanceExtensionPropertiesOffset);
            _EnumerateInstanceLayerProperties = (delegate*<out uint, VkLayerProperties*, VkResult>)(Handle + vkEnumerateInstanceLayerPropertiesOffset);
            _EnumerateDeviceExtensionProperties = (delegate*<VkPhysicalDevice, utf8string, out uint, VkExtensionProperties*, VkResult>)(Handle + vkEnumerateDeviceExtensionPropertiesOffset);
            _EnumerateDeviceLayerProperties = (delegate*<VkPhysicalDevice, out uint, VkLayerProperties*, VkResult>)(Handle + vkEnumerateDeviceLayerPropertiesOffset);

            GetPhysicalDeviceFeatures = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceFeatures, void>)(Handle + vkGetPhysicalDeviceFeaturesOffset);
            GetPhysicalDeviceFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, out VkFormatProperties, void>)(Handle + vkGetPhysicalDeviceFormatPropertiesOffset);
            GetPhysicalDeviceImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, out VkImageFormatProperties, VkResult>)(Handle + vkGetPhysicalDeviceImageFormatPropertiesOffset);
            GetPhysicalDeviceProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceProperties, void>)(Handle + vkGetPhysicalDevicePropertiesOffset);
            _GetPhysicalDeviceQueueFamilyProperties = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties*, void>)(Handle + vkGetPhysicalDeviceQueueFamilyPropertiesOffset);
            GetPhysicalDeviceMemoryProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties, void>)(Handle + vkGetPhysicalDeviceMemoryPropertiesOffset);

            CreateDisplayPlaneSurfaceKHR = (delegate*<VkInstance, ref VkDisplaySurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult>)(Handle + vkCreateDisplayPlaneSurfaceKHROffset);

            DestroyInstance = (delegate*<VkInstance, VkAllocationCallbacks*, void>)(Handle + vkDestroyInstanceOffset);
            DestroyDevice = (delegate*<VkDevice, VkAllocationCallbacks*, void>)(Handle + vkDestroyDeviceOffset);
            DestroySurfaceKHR = (delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)(Handle + vkDestroySurfaceKHROffset);

            GetDeviceQueue = (delegate*<VkDevice, uint, uint, out VkQueue, void>)(Handle + vkGetDeviceQueueOffset);
            _QueueSubmit = (delegate*<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult>)(Handle + vkQueueSubmitOffset);
            QueueWaitIdle = (delegate*<VkQueue, VkResult>)(Handle + vkQueueWaitIdleOffset);
            DeviceWaitIdle = (delegate*<VkDevice, VkResult>)(Handle + vkDeviceWaitIdleOffset);

            AllocateMemory = (delegate*<VkDevice, ref VkMemoryAllocateInfo, VkAllocationCallbacks*, out VkDeviceMemory, VkResult>)(Handle + vkAllocateMemoryOffset);
            FreeMemory = (delegate*<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)(Handle + vkFreeMemoryOffset);
            MapMemory = (delegate*<VkDevice, VkDeviceMemory, ulong, ulong, uint, out nint, VkResult>)(Handle + vkMapMemoryOffset);
            UnmapMemory = (delegate*<VkDevice, VkDeviceMemory, void>)(Handle + vkUnmapMemoryOffset);

            _FlushMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)(Handle + vkFlushMappedMemoryRangesOffset);
            _InvalidateMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)(Handle + vkInvalidateMappedMemoryRangesOffset);

            GetDeviceMemoryCommitment = (delegate*<VkDevice, VkDeviceMemory, out ulong, void>)(Handle + vkGetDeviceMemoryCommitmentOffset);
            BindBufferMemory = (delegate*<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult>)(Handle + vkBindBufferMemoryOffset);
            BindImageMemory = (delegate*<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult>)(Handle + vkBindImageMemoryOffset);
            GetBufferMemoryRequirements = (delegate*<VkDevice, VkBuffer, out VkMemoryRequirements, void>)(Handle + vkGetBufferMemoryRequirementsOffset);
            GetImageMemoryRequirements = (delegate*<VkDevice, VkImage, out VkMemoryRequirements, void>)(Handle + vkGetImageMemoryRequirementsOffset);
            _GetImageSparseMemoryRequirements = (delegate*<VkDevice, VkImage, out uint, VkSparseImageMemoryRequirements*, void>)(Handle + vkGetImageSparseMemoryRequirementsOffset);
            _GetPhysicalDeviceSparseImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, out uint, VkSparseImageFormatProperties*, void>)(Handle + vkGetPhysicalDeviceSparseImageFormatPropertiesOffset);
            _QueueBindSparse = (delegate*<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)(Handle + vkQueueBindSparseOffset);
            CreateFence = (delegate*<VkDevice, ref VkFenceCreateInfo, VkAllocationCallbacks*, out VkFence, VkResult>)(Handle + vkCreateFenceOffset);
            DestroyFence = (delegate*<VkDevice, VkFence, VkAllocationCallbacks*, void>)(Handle + vkDestroyFenceOffset);
            _ResetFences = (delegate*<VkDevice, uint, VkFence*, VkResult>)(Handle + vkResetFencesOffset);
            GetFenceStatus = (delegate*<VkDevice, VkFence, VkResult>)(Handle + vkGetFenceStatusOffset);
            _WaitForFences = (delegate*<VkDevice, uint, VkFence*, uint, ulong, VkResult>)(Handle + vkWaitForFencesOffset);
            CreateSemaphore = (delegate*<VkDevice, ref VkSemaphoreCreateInfo, VkAllocationCallbacks*, out VkSemaphore, VkResult>)(Handle + vkCreateSemaphoreOffset);
            DestroySemaphore = (delegate*<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)(Handle + vkDestroySemaphoreOffset);
            CreateEvent = (delegate*<VkDevice, ref VkEventCreateInfo, VkAllocationCallbacks*, out VkEvent, VkResult>)(Handle + vkCreateEventOffset);
            DestroyEvent = (delegate*<VkDevice, VkEvent, VkAllocationCallbacks*, void>)(Handle + vkDestroyEventOffset);
            GetEventStatus = (delegate*<VkDevice, VkEvent, VkResult>)(Handle + vkGetEventStatusOffset);
            SetEvent = (delegate*<VkDevice, VkEvent, VkResult>)(Handle + vkSetEventOffset);
            ResetEvent = (delegate*<VkDevice, VkEvent, VkResult>)(Handle + vkResetEventOffset);
            CreateQueryPool = (delegate*<VkDevice, ref VkQueryPoolCreateInfo, VkAllocationCallbacks*, out VkQueryPool, VkResult>)(Handle + vkCreateQueryPoolOffset);
            DestroyQueryPool = (delegate*<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)(Handle + vkDestroyQueryPoolOffset);
            GetQueryPoolResults = (delegate*<VkDevice, VkQueryPool, uint, uint, nuint, nint, ulong, VkQueryResultFlagBits, VkResult>)(Handle + vkGetQueryPoolResultsOffset);
            CreateBuffer = (delegate*<VkDevice, ref VkBufferCreateInfo, VkAllocationCallbacks*, out VkBuffer, VkResult>)(Handle + vkCreateBufferOffset);
            DestroyBuffer = (delegate*<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)(Handle + vkDestroyBufferOffset);
            CreateBufferView = (delegate*<VkDevice, ref VkBufferViewCreateInfo, VkAllocationCallbacks*, out VkBufferView, VkResult>)(Handle + vkCreateBufferViewOffset);
            DestroyBufferView = (delegate*<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)(Handle + vkDestroyBufferViewOffset);
            CreateImage = (delegate*<VkDevice, ref VkImageCreateInfo, VkAllocationCallbacks*, out VkImage, VkResult>)(Handle + vkCreateImageOffset);
            DestroyImage = (delegate*<VkDevice, VkImage, VkAllocationCallbacks*, void>)(Handle + vkDestroyImageOffset);
            GetImageSubresourceLayout = (delegate*<VkDevice, VkImage, ref VkImageSubresource, out VkSubresourceLayout, void>)(Handle + vkGetImageSubresourceLayoutOffset);
            CreateImageView = (delegate*<VkDevice, ref VkImageViewCreateInfo, VkAllocationCallbacks*, out VkImageView, VkResult>)(Handle + vkCreateImageViewOffset);
            DestroyImageView = (delegate*<VkDevice, VkImageView, VkAllocationCallbacks*, void>)(Handle + vkDestroyImageViewOffset);
            CreateShaderModule = (delegate*<VkDevice, ref VkShaderModuleCreateInfo, VkAllocationCallbacks*, out VkShaderModule, VkResult>)(Handle + vkCreateShaderModuleOffset);
            DestroyShaderModule = (delegate*<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)(Handle + vkDestroyShaderModuleOffset);
            CreatePipelineCache = (delegate*<VkDevice, ref VkPipelineCacheCreateInfo, VkAllocationCallbacks*, out VkPipelineCache, VkResult>)(Handle + vkCreatePipelineCacheOffset);
            DestroyPipelineCache = (delegate*<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)(Handle + vkDestroyPipelineCacheOffset);
            GetPipelineCacheData = (delegate*<VkDevice, VkPipelineCache, ref UIntPtr, nint, VkResult>)(Handle + vkGetPipelineCacheDataOffset);
            _MergePipelineCaches = (delegate*<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult>)(Handle + vkMergePipelineCachesOffset);
            _CreateGraphicsPipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)(Handle + vkCreateGraphicsPipelinesOffset);
            _CreateComputePipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)(Handle + vkCreateComputePipelinesOffset);
            DestroyPipeline = (delegate*<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)(Handle + vkDestroyPipelineOffset);
            CreatePipelineLayout = (delegate*<VkDevice, ref VkPipelineLayoutCreateInfo, VkAllocationCallbacks*, out VkPipelineLayout, VkResult>)(Handle + vkCreatePipelineLayoutOffset);
            DestroyPipelineLayout = (delegate*<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)(Handle + vkDestroyPipelineLayoutOffset);
            CreateSampler = (delegate*<VkDevice, ref VkSamplerCreateInfo, VkAllocationCallbacks*, out VkSampler, VkResult>)(Handle + vkCreateSamplerOffset);
            DestroySampler = (delegate*<VkDevice, VkSampler, VkAllocationCallbacks*, void>)(Handle + vkDestroySamplerOffset);
            CreateDescriptorSetLayout = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, VkAllocationCallbacks*, out VkDescriptorSetLayout, VkResult>)(Handle + vkCreateDescriptorSetLayoutOffset);
            DestroyDescriptorSetLayout = (delegate*<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)(Handle + vkDestroyDescriptorSetLayoutOffset);
            CreateDescriptorPool = (delegate*<VkDevice, ref VkDescriptorPoolCreateInfo, VkAllocationCallbacks*, out VkDescriptorPool, VkResult>)(Handle + vkCreateDescriptorPoolOffset);
            DestroyDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)(Handle + vkDestroyDescriptorPoolOffset);
            ResetDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, uint, VkResult>)(Handle + vkResetDescriptorPoolOffset);
            _AllocateDescriptorSets = (delegate*<VkDevice, ref VkDescriptorSetAllocateInfo, VkDescriptorSet*, VkResult>)(Handle + vkAllocateDescriptorSetsOffset);
            _FreeDescriptorSets = (delegate*<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult>)(Handle + vkFreeDescriptorSetsOffset);
            _UpdateDescriptorSets = (delegate*<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void>)(Handle + vkUpdateDescriptorSetsOffset);
            CreateFramebuffer = (delegate*<VkDevice, ref VkFramebufferCreateInfo, VkAllocationCallbacks*, out VkFramebuffer, VkResult>)(Handle + vkCreateFramebufferOffset);
            DestroyFramebuffer = (delegate*<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)(Handle + vkDestroyFramebufferOffset);
            CreateRenderPass = (delegate*<VkDevice, ref VkRenderPassCreateInfo, VkAllocationCallbacks*, out VkRenderPass, VkResult>)(Handle + vkCreateRenderPassOffset);
            DestroyRenderPass = (delegate*<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)(Handle + vkDestroyRenderPassOffset);
            GetRenderAreaGranularity = (delegate*<VkDevice, VkRenderPass, out VkExtent2D, void>)(Handle + vkGetRenderAreaGranularityOffset);
            CreateCommandPool = (delegate*<VkDevice, ref VkCommandPoolCreateInfo, VkAllocationCallbacks*, out VkCommandPool, VkResult>)(Handle + vkCreateCommandPoolOffset);
            DestroyCommandPool = (delegate*<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)(Handle + vkDestroyCommandPoolOffset);
            ResetCommandPool = (delegate*<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult>)(Handle + vkResetCommandPoolOffset);
            _AllocateCommandBuffers = (delegate*<VkDevice, ref VkCommandBufferAllocateInfo, VkCommandBuffer*, VkResult>)(Handle + vkAllocateCommandBuffersOffset);
            _FreeCommandBuffers = (delegate*<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void>)(Handle + vkFreeCommandBuffersOffset);
            BeginCommandBuffer = (delegate*<VkCommandBuffer, ref VkCommandBufferBeginInfo, VkResult>)(Handle + vkBeginCommandBufferOffset);
            EndCommandBuffer = (delegate*<VkCommandBuffer, VkResult>)(Handle + vkEndCommandBufferOffset);
            ResetCommandBuffer = (delegate*<VkCommandBuffer, uint, VkResult>)(Handle + vkResetCommandBufferOffset);
            CmdBindPipeline = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)(Handle + vkCmdBindPipelineOffset);
            _CmdSetViewport = (delegate*<VkCommandBuffer, uint, uint, VkViewport*, void>)(Handle + vkCmdSetViewportOffset);
            _CmdSetScissor = (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>)(Handle + vkCmdSetScissorOffset);
            CmdSetLineWidth = (delegate*<VkCommandBuffer, float, void>)(Handle + vkCmdSetLineWidthOffset);
            CmdSetDepthBias = (delegate*<VkCommandBuffer, float, float, float, void>)(Handle + vkCmdSetDepthBiasOffset);
            CmdSetBlendConstants = (delegate*<VkCommandBuffer, ref float, void>)(Handle + vkCmdSetBlendConstantsOffset);
            CmdSetDepthBounds = (delegate*<VkCommandBuffer, float, float, void>)(Handle + vkCmdSetDepthBoundsOffset);
            CmdSetStencilCompareMask = (delegate*<VkCommandBuffer, uint, uint, void>)(Handle + vkCmdSetStencilCompareMaskOffset);
            CmdSetStencilWriteMask = (delegate*<VkCommandBuffer, uint, uint, void>)(Handle + vkCmdSetStencilWriteMaskOffset);
            CmdSetStencilReference = (delegate*<VkCommandBuffer, uint, uint, void>)(Handle + vkCmdSetStencilReferenceOffset);
            _CmdBindDescriptorSets = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void>)(Handle + vkCmdBindDescriptorSetsOffset);
            CmdBindIndexBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void>)(Handle + vkCmdBindIndexBufferOffset);
            _CmdBindVertexBuffers = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)(Handle + vkCmdBindVertexBuffersOffset);
            CmdDraw = (delegate*<VkCommandBuffer, uint, uint, uint, uint, void>)(Handle + vkCmdDrawOffset);
            CmdDrawIndexed = (delegate*<VkCommandBuffer, uint, uint, uint, int, uint, void>)(Handle + vkCmdDrawIndexedOffset);
            CmdDrawIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)(Handle + vkCmdDrawIndirectOffset);
            CmdDrawIndexedIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)(Handle + vkCmdDrawIndexedIndirectOffset);
            CmdDispatch = (delegate*<VkCommandBuffer, uint, uint, uint, void>)(Handle + vkCmdDispatchOffset);
            CmdDispatchIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, void>)(Handle + vkCmdDispatchIndirectOffset);
            _CmdCopyBuffer = (delegate*<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void>)(Handle + vkCmdCopyBufferOffset);
            _CmdCopyImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void>)(Handle + vkCmdCopyImageOffset);
            _CmdBlitImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void>)(Handle + vkCmdBlitImageOffset);
            _CmdCopyBufferToImage = (delegate*<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void>)(Handle + vkCmdCopyBufferToImageOffset);
            _CmdCopyImageToBuffer = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)(Handle + vkCmdCopyImageToBufferOffset);
            CmdUpdateBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, nint, void>)(Handle + vkCmdUpdateBufferOffset);
            CmdFillBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void>)(Handle + vkCmdFillBufferOffset);
            _CmdClearColorImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearColorValue, uint, VkImageSubresourceRange*, void>)(Handle + vkCmdClearColorImageOffset);
            _CmdClearDepthStencilImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void>)(Handle + vkCmdClearDepthStencilImageOffset);
            _CmdClearAttachments = (delegate*<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void>)(Handle + vkCmdClearAttachmentsOffset);
            _CmdResolveImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void>)(Handle + vkCmdResolveImageOffset);
            CmdSetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)(Handle + vkCmdSetEventOffset);
            CmdResetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)(Handle + vkCmdResetEventOffset);
            _CmdWaitEvents = (delegate*<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)(Handle + vkCmdWaitEventsOffset);
            _CmdPipelineBarrier = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)(Handle + vkCmdPipelineBarrierOffset);
            CmdBeginQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)(Handle + vkCmdBeginQueryOffset);
            CmdEndQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, void>)(Handle + vkCmdEndQueryOffset);
            CmdResetQueryPool = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)(Handle + vkCmdResetQueryPoolOffset);
            CmdWriteTimestamp = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void>)(Handle + vkCmdWriteTimestampOffset);
            CmdCopyQueryPoolResults = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, uint, void>)(Handle + vkCmdCopyQueryPoolResultsOffset);
            CmdPushConstants = (delegate*<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, nint, void>)(Handle + vkCmdPushConstantsOffset);
            CmdBeginRenderPass = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, VkSubpassContents, void>)(Handle + vkCmdBeginRenderPassOffset);
            CmdNextSubpass = (delegate*<VkCommandBuffer, VkSubpassContents, void>)(Handle + vkCmdNextSubpassOffset);
            CmdEndRenderPass = (delegate*<VkCommandBuffer, void>)(Handle + vkCmdEndRenderPassOffset);
            CmdExecuteCommands = (delegate*<VkCommandBuffer, uint, ref VkCommandBuffer, void>)(Handle + vkCmdExecuteCommandsOffset);
            EnumerateInstanceVersion = (delegate*<ref uint, VkResult>)(Handle + vkEnumerateInstanceVersionOffset);
            BindBufferMemory2 = (delegate*<VkDevice, uint, ref VkBindBufferMemoryInfo, VkResult>)(Handle + vkBindBufferMemory2Offset);
            BindImageMemory2 = (delegate*<VkDevice, uint, ref VkBindImageMemoryInfo, VkResult>)(Handle + vkBindImageMemory2Offset);
            GetDeviceGroupPeerMemoryFeatures = (delegate*<VkDevice, uint, uint, uint, ref uint, void>)(Handle + vkGetDeviceGroupPeerMemoryFeaturesOffset);
            CmdSetDeviceMask = (delegate*<VkCommandBuffer, uint, void>)(Handle + vkCmdSetDeviceMaskOffset);
            CmdDispatchBase = (delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)(Handle + vkCmdDispatchBaseOffset);
            GetImageMemoryRequirements2 = (delegate*<VkDevice, ref VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)(Handle + vkGetImageMemoryRequirements2Offset);
            GetBufferMemoryRequirements2 = (delegate*<VkDevice, ref VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)(Handle + vkGetBufferMemoryRequirements2Offset);
            _GetImageSparseMemoryRequirements2 = (delegate*<VkDevice, ref VkImageSparseMemoryRequirementsInfo2, out uint, VkSparseImageMemoryRequirements2*, void>)(Handle + vkGetImageSparseMemoryRequirements2Offset);
            GetPhysicalDeviceFeatures2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceFeatures2, void>)(Handle + vkGetPhysicalDeviceFeatures2Offset);
            GetPhysicalDeviceProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceProperties2, void>)(Handle + vkGetPhysicalDeviceProperties2Offset);
            GetPhysicalDeviceFormatProperties2 = (delegate*<VkPhysicalDevice, VkFormat, ref VkFormatProperties2, void>)(Handle + vkGetPhysicalDeviceFormatProperties2Offset);
            GetPhysicalDeviceImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult>)(Handle + vkGetPhysicalDeviceImageFormatProperties2Offset);
            _GetPhysicalDeviceQueueFamilyProperties2 = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties2*, void>)(Handle + vkGetPhysicalDeviceQueueFamilyProperties2Offset);
            GetPhysicalDeviceMemoryProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceMemoryProperties2, void>)(Handle + vkGetPhysicalDeviceMemoryProperties2Offset);
            _GetPhysicalDeviceSparseImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2, out uint, VkSparseImageFormatProperties2*, void>)(Handle + vkGetPhysicalDeviceSparseImageFormatProperties2Offset);
            TrimCommandPool = (delegate*<VkDevice, VkCommandPool, uint, void>)(Handle + vkTrimCommandPoolOffset);
            GetDeviceQueue2 = (delegate*<VkDevice, ref VkDeviceQueueInfo2, ref VkQueue, void>)(Handle + vkGetDeviceQueue2Offset);
            CreateSamplerYcbcrConversion = (delegate*<VkDevice, ref VkSamplerYcbcrConversionCreateInfo, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult>)(Handle + vkCreateSamplerYcbcrConversionOffset);
            DestroySamplerYcbcrConversion = (delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)(Handle + vkDestroySamplerYcbcrConversionOffset);
            CreateDescriptorUpdateTemplate = (delegate*<VkDevice, ref VkDescriptorUpdateTemplateCreateInfo, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult>)(Handle + vkCreateDescriptorUpdateTemplateOffset);
            DestroyDescriptorUpdateTemplate = (delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)(Handle + vkDestroyDescriptorUpdateTemplateOffset);
            UpdateDescriptorSetWithTemplate = (delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, nint, void>)(Handle + vkUpdateDescriptorSetWithTemplateOffset);
            GetPhysicalDeviceExternalBufferProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void>)(Handle + vkGetPhysicalDeviceExternalBufferPropertiesOffset);
            GetPhysicalDeviceExternalFenceProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void>)(Handle + vkGetPhysicalDeviceExternalFencePropertiesOffset);
            GetPhysicalDeviceExternalSemaphoreProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)(Handle + vkGetPhysicalDeviceExternalSemaphorePropertiesOffset);
            GetDescriptorSetLayoutSupport = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)(Handle + vkGetDescriptorSetLayoutSupportOffset);
            CmdDrawIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)(Handle + vkCmdDrawIndirectCountOffset);
            CmdDrawIndexedIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)(Handle + vkCmdDrawIndexedIndirectCountOffset);
            CreateRenderPass2 = (delegate*<VkDevice, ref VkRenderPassCreateInfo2, VkAllocationCallbacks*, out VkRenderPass, VkResult>)(Handle + vkCreateRenderPass2Offset);
            CmdBeginRenderPass2 = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, ref VkSubpassBeginInfo, void>)(Handle + vkCmdBeginRenderPass2Offset);
            CmdNextSubpass2 = (delegate*<VkCommandBuffer, ref VkSubpassBeginInfo, ref VkSubpassEndInfo, void>)(Handle + vkCmdNextSubpass2Offset);
            CmdEndRenderPass2 = (delegate*<VkCommandBuffer, ref VkSubpassEndInfo, void>)(Handle + vkCmdEndRenderPass2Offset);
            ResetQueryPool = (delegate*<VkDevice, VkQueryPool, uint, uint, void>)(Handle + vkResetQueryPoolOffset);
            GetSemaphoreCounterValue = (delegate*<VkDevice, VkSemaphore, ref ulong, VkResult>)(Handle + vkGetSemaphoreCounterValueOffset);
            WaitSemaphores = (delegate*<VkDevice, ref VkSemaphoreWaitInfo, ulong, VkResult>)(Handle + vkWaitSemaphoresOffset);
            SignalSemaphore = (delegate*<VkDevice, ref VkSemaphoreSignalInfo, VkResult>)(Handle + vkSignalSemaphoreOffset);
            GetBufferDeviceAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)(Handle + vkGetBufferDeviceAddressOffset);
            GetBufferOpaqueCaptureAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)(Handle + vkGetBufferOpaqueCaptureAddressOffset);
            GetDeviceMemoryOpaqueCaptureAddress = (delegate*<VkDevice, ref VkDeviceMemoryOpaqueCaptureAddressInfo, ulong>)(Handle + vkGetDeviceMemoryOpaqueCaptureAddressOffset);
            GetPhysicalDeviceSurfaceSupportKHR = (delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, out uint, VkResult>)(Handle + vkGetPhysicalDeviceSurfaceSupportKHROffset);
            GetPhysicalDeviceSurfaceCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult>)(Handle + vkGetPhysicalDeviceSurfaceCapabilitiesKHROffset);
            _GetPhysicalDeviceSurfaceFormatsKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult>)(Handle + vkGetPhysicalDeviceSurfaceFormatsKHROffset);
            _GetPhysicalDeviceSurfacePresentModesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkPresentModeKHR*, VkResult>)(Handle + vkGetPhysicalDeviceSurfacePresentModesKHROffset);
            CreateSwapchainKHR = (delegate*<VkDevice, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)(Handle + vkCreateSwapchainKHROffset);
            DestroySwapchainKHR = (delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)(Handle + vkDestroySwapchainKHROffset);
            _GetSwapchainImagesKHR = (delegate*<VkDevice, VkSwapchainKHR, out uint, VkImage*, VkResult>)(Handle + vkGetSwapchainImagesKHROffset);
            AcquireNextImageKHR = (delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult>)(Handle + vkAcquireNextImageKHROffset);
            QueuePresentKHR = (delegate*<VkQueue, ref VkPresentInfoKHR, VkResult>)(Handle + vkQueuePresentKHROffset);
            GetDeviceGroupPresentCapabilitiesKHR = (delegate*<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>)(Handle + vkGetDeviceGroupPresentCapabilitiesKHROffset);
            GetDeviceGroupSurfacePresentModesKHR = (delegate*<VkDevice, VkSurfaceKHR, ref uint, VkResult>)(Handle + vkGetDeviceGroupSurfacePresentModesKHROffset);
            _GetPhysicalDevicePresentRectanglesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkRect2D*, VkResult>)(Handle + vkGetPhysicalDevicePresentRectanglesKHROffset);
            AcquireNextImage2KHR = (delegate*<VkDevice, ref VkAcquireNextImageInfoKHR, ref uint, VkResult>)(Handle + vkAcquireNextImage2KHROffset);
            _GetPhysicalDeviceDisplayPropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPropertiesKHR*, VkResult>)(Handle + vkGetPhysicalDeviceDisplayPropertiesKHROffset);
            _GetPhysicalDeviceDisplayPlanePropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlanePropertiesKHR*, VkResult>)(Handle + vkGetPhysicalDeviceDisplayPlanePropertiesKHROffset);
            _GetDisplayPlaneSupportedDisplaysKHR = (delegate*<VkPhysicalDevice, uint, out uint, VkDisplayKHR*, VkResult>)(Handle + vkGetDisplayPlaneSupportedDisplaysKHROffset);
            _GetDisplayModePropertiesKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModePropertiesKHR*, VkResult>)(Handle + vkGetDisplayModePropertiesKHROffset);
            CreateDisplayModeKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, ref VkDisplayModeCreateInfoKHR, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult>)(Handle + vkCreateDisplayModeKHROffset);
            GetDisplayPlaneCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, ref VkDisplayPlaneCapabilitiesKHR, VkResult>)(Handle + vkGetDisplayPlaneCapabilitiesKHROffset);
            CreateSharedSwapchainsKHR = (delegate*<VkDevice, uint, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)(Handle + vkCreateSharedSwapchainsKHROffset);
            GetPhysicalDeviceSurfaceCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, ref VkSurfaceCapabilities2KHR, VkResult>)(Handle + vkGetPhysicalDeviceSurfaceCapabilities2KHROffset);
            _GetPhysicalDeviceSurfaceFormats2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkSurfaceFormat2KHR*, VkResult>)(Handle + vkGetPhysicalDeviceSurfaceFormats2KHROffset);
            _GetPhysicalDeviceDisplayProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayProperties2KHR*, VkResult>)(Handle + vkGetPhysicalDeviceDisplayProperties2KHROffset);
            _GetPhysicalDeviceDisplayPlaneProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlaneProperties2KHR*, VkResult>)(Handle + vkGetPhysicalDeviceDisplayPlaneProperties2KHROffset);
            _GetDisplayModeProperties2KHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModeProperties2KHR*, VkResult>)(Handle + vkGetDisplayModeProperties2KHROffset);
            GetDisplayPlaneCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>)(Handle + vkGetDisplayPlaneCapabilities2KHROffset); 
            #endregion

#elif LOAD_FROM_GETEXPORT

            #region LOAD_FROM_GETEXPORT
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)NativeLibrary.GetExport(Handle, "vkGetInstanceProcAddr");
            GetDeviceProcAddr = (delegate*<VkDevice, utf8string, nint>)NativeLibrary.GetExport(Handle, "vkGetDeviceProcAddr");

            _EnumeratePhysicalDevices = (delegate*<VkInstance, out uint, VkPhysicalDevice*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumeratePhysicalDevices");
            _EnumeratePhysicalDeviceGroups = (delegate*<VkInstance, out uint, VkPhysicalDeviceGroupProperties*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumeratePhysicalDeviceGroups");

            CreateInstance = (delegate*<ref VkInstanceCreateInfo, VkAllocationCallbacks*, out VkInstance, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateInstance");
            CreateDevice = (delegate*<VkPhysicalDevice, ref VkDeviceCreateInfo, VkAllocationCallbacks*, out VkDevice, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDevice");

            _EnumerateInstanceExtensionProperties = (delegate*<utf8string, out uint, VkExtensionProperties*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumerateInstanceExtensionProperties");
            _EnumerateInstanceLayerProperties = (delegate*<out uint, VkLayerProperties*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumerateInstanceLayerProperties");
            _EnumerateDeviceExtensionProperties = (delegate*<VkPhysicalDevice, utf8string, out uint, VkExtensionProperties*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumerateDeviceExtensionProperties");
            _EnumerateDeviceLayerProperties = (delegate*<VkPhysicalDevice, out uint, VkLayerProperties*, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumerateDeviceLayerProperties");

            GetPhysicalDeviceFeatures = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceFeatures, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceFeatures");
            GetPhysicalDeviceFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, out VkFormatProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceFormatProperties");
            GetPhysicalDeviceImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlagBits, VkImageCreateFlagBits, out VkImageFormatProperties, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceImageFormatProperties");
            GetPhysicalDeviceProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceProperties");
            _GetPhysicalDeviceQueueFamilyProperties = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties*, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceQueueFamilyProperties");
            GetPhysicalDeviceMemoryProperties = (delegate*<VkPhysicalDevice, out VkPhysicalDeviceMemoryProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceMemoryProperties");

            CreateDisplayPlaneSurfaceKHR = (delegate*<VkInstance, ref VkDisplaySurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDisplayPlaneSurfaceKHR");

            DestroyInstance = (delegate*<VkInstance, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyInstance");
            DestroyDevice = (delegate*<VkDevice, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyDevice");
            DestroySurfaceKHR = (delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroySurfaceKHR");

            GetDeviceQueue = (delegate*<VkDevice, uint, uint, out VkQueue, void>)NativeLibrary.GetExport(Handle, "vkGetDeviceQueue");
            _QueueSubmit = (delegate*<VkQueue, uint, VkSubmitInfo*, VkFence, VkResult>)NativeLibrary.GetExport(Handle, "vkQueueSubmit");
            QueueWaitIdle = (delegate*<VkQueue, VkResult>)NativeLibrary.GetExport(Handle, "vkQueueWaitIdle");
            DeviceWaitIdle = (delegate*<VkDevice, VkResult>)NativeLibrary.GetExport(Handle, "vkDeviceWaitIdle");

            AllocateMemory = (delegate*<VkDevice, ref VkMemoryAllocateInfo, VkAllocationCallbacks*, out VkDeviceMemory, VkResult>)NativeLibrary.GetExport(Handle, "vkAllocateMemory");
            FreeMemory = (delegate*<VkDevice, VkDeviceMemory, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkFreeMemory");
            MapMemory = (delegate*<VkDevice, VkDeviceMemory, ulong, ulong, uint, out nint, VkResult>)NativeLibrary.GetExport(Handle, "vkMapMemory");
            UnmapMemory = (delegate*<VkDevice, VkDeviceMemory, void>)NativeLibrary.GetExport(Handle, "vkUnmapMemory");

            _FlushMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)NativeLibrary.GetExport(Handle, "vkFlushMappedMemoryRanges");
            _InvalidateMappedMemoryRanges = (delegate*<VkDevice, uint, VkMappedMemoryRange*, VkResult>)NativeLibrary.GetExport(Handle, "vkInvalidateMappedMemoryRanges");

            GetDeviceMemoryCommitment = (delegate*<VkDevice, VkDeviceMemory, out ulong, void>)NativeLibrary.GetExport(Handle, "vkGetDeviceMemoryCommitment");
            BindBufferMemory = (delegate*<VkDevice, VkBuffer, VkDeviceMemory, ulong, VkResult>)NativeLibrary.GetExport(Handle, "vkBindBufferMemory");
            BindImageMemory = (delegate*<VkDevice, VkImage, VkDeviceMemory, ulong, VkResult>)NativeLibrary.GetExport(Handle, "vkBindImageMemory");
            GetBufferMemoryRequirements = (delegate*<VkDevice, VkBuffer, out VkMemoryRequirements, void>)NativeLibrary.GetExport(Handle, "vkGetBufferMemoryRequirements");
            GetImageMemoryRequirements = (delegate*<VkDevice, VkImage, out VkMemoryRequirements, void>)NativeLibrary.GetExport(Handle, "vkGetImageMemoryRequirements");
            _GetImageSparseMemoryRequirements = (delegate*<VkDevice, VkImage, out uint, VkSparseImageMemoryRequirements*, void>)NativeLibrary.GetExport(Handle, "vkGetImageSparseMemoryRequirements");
            _GetPhysicalDeviceSparseImageFormatProperties = (delegate*<VkPhysicalDevice, VkFormat, VkImageType, VkSampleCountFlagBits, VkImageUsageFlagBits, VkImageTiling, out uint, VkSparseImageFormatProperties*, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSparseImageFormatProperties");
            _QueueBindSparse = (delegate*<VkQueue, uint, VkBindSparseInfo*, VkFence, VkResult>)NativeLibrary.GetExport(Handle, "vkQueueBindSparse");
            CreateFence = (delegate*<VkDevice, ref VkFenceCreateInfo, VkAllocationCallbacks*, out VkFence, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateFence");
            DestroyFence = (delegate*<VkDevice, VkFence, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyFence");
            _ResetFences = (delegate*<VkDevice, uint, VkFence*, VkResult>)NativeLibrary.GetExport(Handle, "vkResetFences");
            GetFenceStatus = (delegate*<VkDevice, VkFence, VkResult>)NativeLibrary.GetExport(Handle, "vkGetFenceStatus");
            _WaitForFences = (delegate*<VkDevice, uint, VkFence*, uint, ulong, VkResult>)NativeLibrary.GetExport(Handle, "vkWaitForFences");
            CreateSemaphore = (delegate*<VkDevice, ref VkSemaphoreCreateInfo, VkAllocationCallbacks*, out VkSemaphore, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateSemaphore");
            DestroySemaphore = (delegate*<VkDevice, VkSemaphore, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroySemaphore");
            CreateEvent = (delegate*<VkDevice, ref VkEventCreateInfo, VkAllocationCallbacks*, out VkEvent, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateEvent");
            DestroyEvent = (delegate*<VkDevice, VkEvent, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyEvent");
            GetEventStatus = (delegate*<VkDevice, VkEvent, VkResult>)NativeLibrary.GetExport(Handle, "vkGetEventStatus");
            SetEvent = (delegate*<VkDevice, VkEvent, VkResult>)NativeLibrary.GetExport(Handle, "vkSetEvent");
            ResetEvent = (delegate*<VkDevice, VkEvent, VkResult>)NativeLibrary.GetExport(Handle, "vkResetEvent");
            CreateQueryPool = (delegate*<VkDevice, ref VkQueryPoolCreateInfo, VkAllocationCallbacks*, out VkQueryPool, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateQueryPool");
            DestroyQueryPool = (delegate*<VkDevice, VkQueryPool, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyQueryPool");
            GetQueryPoolResults = (delegate*<VkDevice, VkQueryPool, uint, uint, nuint, nint, ulong, VkQueryResultFlagBits, VkResult>)NativeLibrary.GetExport(Handle, "vkGetQueryPoolResults");
            CreateBuffer = (delegate*<VkDevice, ref VkBufferCreateInfo, VkAllocationCallbacks*, out VkBuffer, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateBuffer");
            DestroyBuffer = (delegate*<VkDevice, VkBuffer, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyBuffer");
            CreateBufferView = (delegate*<VkDevice, ref VkBufferViewCreateInfo, VkAllocationCallbacks*, out VkBufferView, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateBufferView");
            DestroyBufferView = (delegate*<VkDevice, VkBufferView, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyBufferView");
            CreateImage = (delegate*<VkDevice, ref VkImageCreateInfo, VkAllocationCallbacks*, out VkImage, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateImage");
            DestroyImage = (delegate*<VkDevice, VkImage, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyImage");
            GetImageSubresourceLayout = (delegate*<VkDevice, VkImage, ref VkImageSubresource, out VkSubresourceLayout, void>)NativeLibrary.GetExport(Handle, "vkGetImageSubresourceLayout");
            CreateImageView = (delegate*<VkDevice, ref VkImageViewCreateInfo, VkAllocationCallbacks*, out VkImageView, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateImageView");
            DestroyImageView = (delegate*<VkDevice, VkImageView, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyImageView");
            CreateShaderModule = (delegate*<VkDevice, ref VkShaderModuleCreateInfo, VkAllocationCallbacks*, out VkShaderModule, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateShaderModule");
            DestroyShaderModule = (delegate*<VkDevice, VkShaderModule, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyShaderModule");
            CreatePipelineCache = (delegate*<VkDevice, ref VkPipelineCacheCreateInfo, VkAllocationCallbacks*, out VkPipelineCache, VkResult>)NativeLibrary.GetExport(Handle, "vkCreatePipelineCache");
            DestroyPipelineCache = (delegate*<VkDevice, VkPipelineCache, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyPipelineCache");
            GetPipelineCacheData = (delegate*<VkDevice, VkPipelineCache, ref UIntPtr, nint, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPipelineCacheData");
            _MergePipelineCaches = (delegate*<VkDevice, VkPipelineCache, uint, VkPipelineCache*, VkResult>)NativeLibrary.GetExport(Handle, "vkMergePipelineCaches");
            _CreateGraphicsPipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkGraphicsPipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateGraphicsPipelines");
            _CreateComputePipelines = (delegate*<VkDevice, VkPipelineCache, uint, VkComputePipelineCreateInfo*, VkAllocationCallbacks*, VkPipeline*, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateComputePipelines");
            DestroyPipeline = (delegate*<VkDevice, VkPipeline, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyPipeline");
            CreatePipelineLayout = (delegate*<VkDevice, ref VkPipelineLayoutCreateInfo, VkAllocationCallbacks*, out VkPipelineLayout, VkResult>)NativeLibrary.GetExport(Handle, "vkCreatePipelineLayout");
            DestroyPipelineLayout = (delegate*<VkDevice, VkPipelineLayout, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyPipelineLayout");
            CreateSampler = (delegate*<VkDevice, ref VkSamplerCreateInfo, VkAllocationCallbacks*, out VkSampler, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateSampler");
            DestroySampler = (delegate*<VkDevice, VkSampler, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroySampler");
            CreateDescriptorSetLayout = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, VkAllocationCallbacks*, out VkDescriptorSetLayout, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDescriptorSetLayout");
            DestroyDescriptorSetLayout = (delegate*<VkDevice, VkDescriptorSetLayout, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyDescriptorSetLayout");
            CreateDescriptorPool = (delegate*<VkDevice, ref VkDescriptorPoolCreateInfo, VkAllocationCallbacks*, out VkDescriptorPool, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDescriptorPool");
            DestroyDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyDescriptorPool");
            ResetDescriptorPool = (delegate*<VkDevice, VkDescriptorPool, uint, VkResult>)NativeLibrary.GetExport(Handle, "vkResetDescriptorPool");
            _AllocateDescriptorSets = (delegate*<VkDevice, ref VkDescriptorSetAllocateInfo, VkDescriptorSet*, VkResult>)NativeLibrary.GetExport(Handle, "vkAllocateDescriptorSets");
            _FreeDescriptorSets = (delegate*<VkDevice, VkDescriptorPool, uint, VkDescriptorSet*, VkResult>)NativeLibrary.GetExport(Handle, "vkFreeDescriptorSets");
            _UpdateDescriptorSets = (delegate*<VkDevice, uint, VkWriteDescriptorSet*, uint, VkCopyDescriptorSet*, void>)NativeLibrary.GetExport(Handle, "vkUpdateDescriptorSets");
            CreateFramebuffer = (delegate*<VkDevice, ref VkFramebufferCreateInfo, VkAllocationCallbacks*, out VkFramebuffer, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateFramebuffer");
            DestroyFramebuffer = (delegate*<VkDevice, VkFramebuffer, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyFramebuffer");
            CreateRenderPass = (delegate*<VkDevice, ref VkRenderPassCreateInfo, VkAllocationCallbacks*, out VkRenderPass, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateRenderPass");
            DestroyRenderPass = (delegate*<VkDevice, VkRenderPass, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyRenderPass");
            GetRenderAreaGranularity = (delegate*<VkDevice, VkRenderPass, out VkExtent2D, void>)NativeLibrary.GetExport(Handle, "vkGetRenderAreaGranularity");
            CreateCommandPool = (delegate*<VkDevice, ref VkCommandPoolCreateInfo, VkAllocationCallbacks*, out VkCommandPool, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateCommandPool");
            DestroyCommandPool = (delegate*<VkDevice, VkCommandPool, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyCommandPool");
            ResetCommandPool = (delegate*<VkDevice, VkCommandPool, VkCommandPoolResetFlagBits, VkResult>)NativeLibrary.GetExport(Handle, "vkResetCommandPool");
            _AllocateCommandBuffers = (delegate*<VkDevice, ref VkCommandBufferAllocateInfo, VkCommandBuffer*, VkResult>)NativeLibrary.GetExport(Handle, "vkAllocateCommandBuffers");
            _FreeCommandBuffers = (delegate*<VkDevice, VkCommandPool, uint, VkCommandBuffer*, void>)NativeLibrary.GetExport(Handle, "vkFreeCommandBuffers");
            BeginCommandBuffer = (delegate*<VkCommandBuffer, ref VkCommandBufferBeginInfo, VkResult>)NativeLibrary.GetExport(Handle, "vkBeginCommandBuffer");
            EndCommandBuffer = (delegate*<VkCommandBuffer, VkResult>)NativeLibrary.GetExport(Handle, "vkEndCommandBuffer");
            ResetCommandBuffer = (delegate*<VkCommandBuffer, uint, VkResult>)NativeLibrary.GetExport(Handle, "vkResetCommandBuffer");
            CmdBindPipeline = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipeline, void>)NativeLibrary.GetExport(Handle, "vkCmdBindPipeline");
            _CmdSetViewport = (delegate*<VkCommandBuffer, uint, uint, VkViewport*, void>)NativeLibrary.GetExport(Handle, "vkCmdSetViewport");
            _CmdSetScissor = (delegate*<VkCommandBuffer, uint, uint, VkRect2D*, void>)NativeLibrary.GetExport(Handle, "vkCmdSetScissor");
            CmdSetLineWidth = (delegate*<VkCommandBuffer, float, void>)NativeLibrary.GetExport(Handle, "vkCmdSetLineWidth");
            CmdSetDepthBias = (delegate*<VkCommandBuffer, float, float, float, void>)NativeLibrary.GetExport(Handle, "vkCmdSetDepthBias");
            CmdSetBlendConstants = (delegate*<VkCommandBuffer, ref float, void>)NativeLibrary.GetExport(Handle, "vkCmdSetBlendConstants");
            CmdSetDepthBounds = (delegate*<VkCommandBuffer, float, float, void>)NativeLibrary.GetExport(Handle, "vkCmdSetDepthBounds");
            CmdSetStencilCompareMask = (delegate*<VkCommandBuffer, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdSetStencilCompareMask");
            CmdSetStencilWriteMask = (delegate*<VkCommandBuffer, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdSetStencilWriteMask");
            CmdSetStencilReference = (delegate*<VkCommandBuffer, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdSetStencilReference");
            _CmdBindDescriptorSets = (delegate*<VkCommandBuffer, VkPipelineBindPoint, VkPipelineLayout, uint, uint, VkDescriptorSet*, uint, uint*, void>)NativeLibrary.GetExport(Handle, "vkCmdBindDescriptorSets");
            CmdBindIndexBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkIndexType, void>)NativeLibrary.GetExport(Handle, "vkCmdBindIndexBuffer");
            _CmdBindVertexBuffers = (delegate*<VkCommandBuffer, uint, uint, VkBuffer*, ulong*, void>)NativeLibrary.GetExport(Handle, "vkCmdBindVertexBuffers");
            CmdDraw = (delegate*<VkCommandBuffer, uint, uint, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDraw");
            CmdDrawIndexed = (delegate*<VkCommandBuffer, uint, uint, uint, int, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDrawIndexed");
            CmdDrawIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDrawIndirect");
            CmdDrawIndexedIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDrawIndexedIndirect");
            CmdDispatch = (delegate*<VkCommandBuffer, uint, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDispatch");
            CmdDispatchIndirect = (delegate*<VkCommandBuffer, VkBuffer, ulong, void>)NativeLibrary.GetExport(Handle, "vkCmdDispatchIndirect");
            _CmdCopyBuffer = (delegate*<VkCommandBuffer, VkBuffer, VkBuffer, uint, VkBufferCopy*, void>)NativeLibrary.GetExport(Handle, "vkCmdCopyBuffer");
            _CmdCopyImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageCopy*, void>)NativeLibrary.GetExport(Handle, "vkCmdCopyImage");
            _CmdBlitImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageBlit*, VkFilter, void>)NativeLibrary.GetExport(Handle, "vkCmdBlitImage");
            _CmdCopyBufferToImage = (delegate*<VkCommandBuffer, VkBuffer, VkImage, VkImageLayout, uint, VkBufferImageCopy*, void>)NativeLibrary.GetExport(Handle, "vkCmdCopyBufferToImage");
            _CmdCopyImageToBuffer = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkBuffer, uint, VkBufferImageCopy*, void>)NativeLibrary.GetExport(Handle, "vkCmdCopyImageToBuffer");
            CmdUpdateBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, nint, void>)NativeLibrary.GetExport(Handle, "vkCmdUpdateBuffer");
            CmdFillBuffer = (delegate*<VkCommandBuffer, VkBuffer, ulong, ulong, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdFillBuffer");
            _CmdClearColorImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearColorValue, uint, VkImageSubresourceRange*, void>)NativeLibrary.GetExport(Handle, "vkCmdClearColorImage");
            _CmdClearDepthStencilImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, ref VkClearDepthStencilValue, uint, VkImageSubresourceRange*, void>)NativeLibrary.GetExport(Handle, "vkCmdClearDepthStencilImage");
            _CmdClearAttachments = (delegate*<VkCommandBuffer, uint, VkClearAttachment*, uint, VkClearRect*, void>)NativeLibrary.GetExport(Handle, "vkCmdClearAttachments");
            _CmdResolveImage = (delegate*<VkCommandBuffer, VkImage, VkImageLayout, VkImage, VkImageLayout, uint, VkImageResolve*, void>)NativeLibrary.GetExport(Handle, "vkCmdResolveImage");
            CmdSetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdSetEvent");
            CmdResetEvent = (delegate*<VkCommandBuffer, VkEvent, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdResetEvent");
            _CmdWaitEvents = (delegate*<VkCommandBuffer, uint, VkEvent*, VkPipelineStageFlagBits, VkPipelineStageFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)NativeLibrary.GetExport(Handle, "vkCmdWaitEvents");
            _CmdPipelineBarrier = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkPipelineStageFlagBits, VkDependencyFlagBits, uint, VkMemoryBarrier*, uint, VkBufferMemoryBarrier*, uint, VkImageMemoryBarrier*, void>)NativeLibrary.GetExport(Handle, "vkCmdPipelineBarrier");
            CmdBeginQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdBeginQuery");
            CmdEndQuery = (delegate*<VkCommandBuffer, VkQueryPool, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdEndQuery");
            CmdResetQueryPool = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdResetQueryPool");
            CmdWriteTimestamp = (delegate*<VkCommandBuffer, VkPipelineStageFlagBits, VkQueryPool, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdWriteTimestamp");
            CmdCopyQueryPoolResults = (delegate*<VkCommandBuffer, VkQueryPool, uint, uint, VkBuffer, ulong, ulong, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdCopyQueryPoolResults");
            CmdPushConstants = (delegate*<VkCommandBuffer, VkPipelineLayout, VkShaderStageFlagBits, uint, uint, nint, void>)NativeLibrary.GetExport(Handle, "vkCmdPushConstants");
            CmdBeginRenderPass = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, VkSubpassContents, void>)NativeLibrary.GetExport(Handle, "vkCmdBeginRenderPass");
            CmdNextSubpass = (delegate*<VkCommandBuffer, VkSubpassContents, void>)NativeLibrary.GetExport(Handle, "vkCmdNextSubpass");
            CmdEndRenderPass = (delegate*<VkCommandBuffer, void>)NativeLibrary.GetExport(Handle, "vkCmdEndRenderPass");
            CmdExecuteCommands = (delegate*<VkCommandBuffer, uint, ref VkCommandBuffer, void>)NativeLibrary.GetExport(Handle, "vkCmdExecuteCommands");
            EnumerateInstanceVersion = (delegate*<ref uint, VkResult>)NativeLibrary.GetExport(Handle, "vkEnumerateInstanceVersion");
            BindBufferMemory2 = (delegate*<VkDevice, uint, ref VkBindBufferMemoryInfo, VkResult>)NativeLibrary.GetExport(Handle, "vkBindBufferMemory2");
            BindImageMemory2 = (delegate*<VkDevice, uint, ref VkBindImageMemoryInfo, VkResult>)NativeLibrary.GetExport(Handle, "vkBindImageMemory2");
            GetDeviceGroupPeerMemoryFeatures = (delegate*<VkDevice, uint, uint, uint, ref uint, void>)NativeLibrary.GetExport(Handle, "vkGetDeviceGroupPeerMemoryFeatures");
            CmdSetDeviceMask = (delegate*<VkCommandBuffer, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdSetDeviceMask");
            CmdDispatchBase = (delegate*<VkCommandBuffer, uint, uint, uint, uint, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDispatchBase");
            GetImageMemoryRequirements2 = (delegate*<VkDevice, ref VkImageMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)NativeLibrary.GetExport(Handle, "vkGetImageMemoryRequirements2");
            GetBufferMemoryRequirements2 = (delegate*<VkDevice, ref VkBufferMemoryRequirementsInfo2, ref VkMemoryRequirements2, void>)NativeLibrary.GetExport(Handle, "vkGetBufferMemoryRequirements2");
            _GetImageSparseMemoryRequirements2 = (delegate*<VkDevice, ref VkImageSparseMemoryRequirementsInfo2, out uint, VkSparseImageMemoryRequirements2*, void>)NativeLibrary.GetExport(Handle, "vkGetImageSparseMemoryRequirements2");
            GetPhysicalDeviceFeatures2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceFeatures2, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceFeatures2");
            GetPhysicalDeviceProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceProperties2, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceProperties2");
            GetPhysicalDeviceFormatProperties2 = (delegate*<VkPhysicalDevice, VkFormat, ref VkFormatProperties2, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceFormatProperties2");
            GetPhysicalDeviceImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceImageFormatProperties2");
            _GetPhysicalDeviceQueueFamilyProperties2 = (delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties2*, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceQueueFamilyProperties2");
            GetPhysicalDeviceMemoryProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceMemoryProperties2, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceMemoryProperties2");
            _GetPhysicalDeviceSparseImageFormatProperties2 = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2, out uint, VkSparseImageFormatProperties2*, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSparseImageFormatProperties2");
            TrimCommandPool = (delegate*<VkDevice, VkCommandPool, uint, void>)NativeLibrary.GetExport(Handle, "vkTrimCommandPool");
            GetDeviceQueue2 = (delegate*<VkDevice, ref VkDeviceQueueInfo2, ref VkQueue, void>)NativeLibrary.GetExport(Handle, "vkGetDeviceQueue2");
            CreateSamplerYcbcrConversion = (delegate*<VkDevice, ref VkSamplerYcbcrConversionCreateInfo, VkAllocationCallbacks*, out VkSamplerYcbcrConversion, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateSamplerYcbcrConversion");
            DestroySamplerYcbcrConversion = (delegate*<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroySamplerYcbcrConversion");
            CreateDescriptorUpdateTemplate = (delegate*<VkDevice, ref VkDescriptorUpdateTemplateCreateInfo, VkAllocationCallbacks*, out VkDescriptorUpdateTemplate, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDescriptorUpdateTemplate");
            DestroyDescriptorUpdateTemplate = (delegate*<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroyDescriptorUpdateTemplate");
            UpdateDescriptorSetWithTemplate = (delegate*<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, nint, void>)NativeLibrary.GetExport(Handle, "vkUpdateDescriptorSetWithTemplate");
            GetPhysicalDeviceExternalBufferProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceExternalBufferProperties");
            GetPhysicalDeviceExternalFenceProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceExternalFenceProperties");
            GetPhysicalDeviceExternalSemaphoreProperties = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceExternalSemaphoreProperties");
            GetDescriptorSetLayoutSupport = (delegate*<VkDevice, ref VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)NativeLibrary.GetExport(Handle, "vkGetDescriptorSetLayoutSupport");
            CmdDrawIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDrawIndirectCount");
            CmdDrawIndexedIndirectCount = (delegate*<VkCommandBuffer, VkBuffer, ulong, VkBuffer, ulong, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkCmdDrawIndexedIndirectCount");
            CreateRenderPass2 = (delegate*<VkDevice, ref VkRenderPassCreateInfo2, VkAllocationCallbacks*, out VkRenderPass, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateRenderPass2");
            CmdBeginRenderPass2 = (delegate*<VkCommandBuffer, ref VkRenderPassBeginInfo, ref VkSubpassBeginInfo, void>)NativeLibrary.GetExport(Handle, "vkCmdBeginRenderPass2");
            CmdNextSubpass2 = (delegate*<VkCommandBuffer, ref VkSubpassBeginInfo, ref VkSubpassEndInfo, void>)NativeLibrary.GetExport(Handle, "vkCmdNextSubpass2");
            CmdEndRenderPass2 = (delegate*<VkCommandBuffer, ref VkSubpassEndInfo, void>)NativeLibrary.GetExport(Handle, "vkCmdEndRenderPass2");
            ResetQueryPool = (delegate*<VkDevice, VkQueryPool, uint, uint, void>)NativeLibrary.GetExport(Handle, "vkResetQueryPool");
            GetSemaphoreCounterValue = (delegate*<VkDevice, VkSemaphore, ref ulong, VkResult>)NativeLibrary.GetExport(Handle, "vkGetSemaphoreCounterValue");
            WaitSemaphores = (delegate*<VkDevice, ref VkSemaphoreWaitInfo, ulong, VkResult>)NativeLibrary.GetExport(Handle, "vkWaitSemaphores");
            SignalSemaphore = (delegate*<VkDevice, ref VkSemaphoreSignalInfo, VkResult>)NativeLibrary.GetExport(Handle, "vkSignalSemaphore");
            GetBufferDeviceAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)NativeLibrary.GetExport(Handle, "vkGetBufferDeviceAddress");
            GetBufferOpaqueCaptureAddress = (delegate*<VkDevice, ref VkBufferDeviceAddressInfo, ulong>)NativeLibrary.GetExport(Handle, "vkGetBufferOpaqueCaptureAddress");
            GetDeviceMemoryOpaqueCaptureAddress = (delegate*<VkDevice, ref VkDeviceMemoryOpaqueCaptureAddressInfo, ulong>)NativeLibrary.GetExport(Handle, "vkGetDeviceMemoryOpaqueCaptureAddress");
            GetPhysicalDeviceSurfaceSupportKHR = (delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, out uint, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfaceSupportKHR");
            GetPhysicalDeviceSurfaceCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfaceCapabilitiesKHR");
            _GetPhysicalDeviceSurfaceFormatsKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfaceFormatsKHR");
            _GetPhysicalDeviceSurfacePresentModesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkPresentModeKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfacePresentModesKHR");
            CreateSwapchainKHR = (delegate*<VkDevice, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateSwapchainKHR");
            DestroySwapchainKHR = (delegate*<VkDevice, VkSwapchainKHR, VkAllocationCallbacks*, void>)NativeLibrary.GetExport(Handle, "vkDestroySwapchainKHR");
            _GetSwapchainImagesKHR = (delegate*<VkDevice, VkSwapchainKHR, out uint, VkImage*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetSwapchainImagesKHR");
            AcquireNextImageKHR = (delegate*<VkDevice, VkSwapchainKHR, ulong, VkSemaphore, VkFence, out uint, VkResult>)NativeLibrary.GetExport(Handle, "vkAcquireNextImageKHR");
            QueuePresentKHR = (delegate*<VkQueue, ref VkPresentInfoKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkQueuePresentKHR");
            GetDeviceGroupPresentCapabilitiesKHR = (delegate*<VkDevice, ref VkDeviceGroupPresentCapabilitiesKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDeviceGroupPresentCapabilitiesKHR");
            GetDeviceGroupSurfacePresentModesKHR = (delegate*<VkDevice, VkSurfaceKHR, ref uint, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDeviceGroupSurfacePresentModesKHR");
            _GetPhysicalDevicePresentRectanglesKHR = (delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkRect2D*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDevicePresentRectanglesKHR");
            AcquireNextImage2KHR = (delegate*<VkDevice, ref VkAcquireNextImageInfoKHR, ref uint, VkResult>)NativeLibrary.GetExport(Handle, "vkAcquireNextImage2KHR");
            _GetPhysicalDeviceDisplayPropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPropertiesKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceDisplayPropertiesKHR");
            _GetPhysicalDeviceDisplayPlanePropertiesKHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlanePropertiesKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceDisplayPlanePropertiesKHR");
            _GetDisplayPlaneSupportedDisplaysKHR = (delegate*<VkPhysicalDevice, uint, out uint, VkDisplayKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDisplayPlaneSupportedDisplaysKHR");
            _GetDisplayModePropertiesKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModePropertiesKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDisplayModePropertiesKHR");
            CreateDisplayModeKHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, ref VkDisplayModeCreateInfoKHR, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateDisplayModeKHR");
            GetDisplayPlaneCapabilitiesKHR = (delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, ref VkDisplayPlaneCapabilitiesKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDisplayPlaneCapabilitiesKHR");
            CreateSharedSwapchainsKHR = (delegate*<VkDevice, uint, ref VkSwapchainCreateInfoKHR, VkAllocationCallbacks*, out VkSwapchainKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkCreateSharedSwapchainsKHR");
            GetPhysicalDeviceSurfaceCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, ref VkSurfaceCapabilities2KHR, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfaceCapabilities2KHROffset");
            _GetPhysicalDeviceSurfaceFormats2KHR = (delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkSurfaceFormat2KHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfaceFormats2KHROffset");
            _GetPhysicalDeviceDisplayProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayProperties2KHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceDisplayProperties2KHROffset");
            _GetPhysicalDeviceDisplayPlaneProperties2KHR = (delegate*<VkPhysicalDevice, out uint, VkDisplayPlaneProperties2KHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceDisplayPlaneProperties2KHROffset");
            _GetDisplayModeProperties2KHR = (delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModeProperties2KHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDisplayModeProperties2KHROffset");
            GetDisplayPlaneCapabilities2KHR = (delegate*<VkPhysicalDevice, ref VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDisplayPlaneCapabilities2KHROffset"); 
            #endregion

#endif
        }


        //public static extern ([a-zA-Z0-9_]+) vk([a-zA-Z0-9_]+)\((.*?)\);
        //public static unsafe delegate* <$3, $1> $2 = \(delegate* <$3, $1>\)NativeLibrary.GetExport\(Handle, "vk$2"\);


//        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
//        public static void Trace(Action result,
//                                 [CallerMemberName] string memberName = "",
//                                 [CallerFilePath] string sourceFilePath = "",
//                                 [CallerLineNumber] int sourceLineNumber = 0)
//        {
//#if DEBUG
//            Debug.WriteLine($"Vulkan call in {sourceFilePath} @{memberName}:{sourceLineNumber}");
//#endif
//        }

//        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
//        public static T Trace<T>(Func<T> result,
//                                 [CallerMemberName] string memberName = "",
//                                 [CallerFilePath] string sourceFilePath = "",
//                                 [CallerLineNumber] int sourceLineNumber = 0)
//        {
//#if DEBUG
//            Debug.WriteLine($"Vulkan call in {sourceFilePath} @{memberName}:{sourceLineNumber}");
//#endif
//            return result();
//        }

//        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
//        public static T Trace<T>(T result,
//                                 [CallerMemberName] string memberName = "",
//                                 [CallerFilePath] string sourceFilePath = "",
//                                 [CallerLineNumber] int sourceLineNumber = 0)
//        {
//#if DEBUG
//            Debug.WriteLine($"Vulkan call in {sourceFilePath} @{memberName}:{sourceLineNumber}");
//#endif
//            return result;
//        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static void Check(VkResult                                    result,
                                 [CallerMemberName]                   string memberName       = "",
                                 [CallerFilePath]                     string sourceFilePath   = "",
                                 [CallerLineNumber]                   int    sourceLineNumber = 0,
                                 [CallerArgumentExpression("result")] string resultExpression = "")
        {
//#if DEBUG
//            Debug.WriteLine($"Vulkan call in {sourceFilePath} @{memberName}:{sourceLineNumber}");
//#endif
            if (result != VkResult.Success)
            {
                throw new Exception($"Vulkan Error [{resultExpression}]({result.ToString()}) in {sourceFilePath} @{memberName}:{sourceLineNumber}");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IfSuccess(VkResult result)
        {
            if (result == VkResult.Success)
            {
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool IfFailed(VkResult result)
        {
            if (result != VkResult.Success)
            {
                return true;
            }
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint MAKE_API_VERSION(int major,
                                            int minor,
                                            int patch)
        {
            return (((uint)(major)) << 22) | (((uint)(minor)) << 12) | ((uint)(patch));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint MAKE_API_VERSION(int variant,
                                            int major,
                                            int minor,
                                            int patch)
        {
            return ((((uint)(variant)) << 29) | (((uint)(major)) << 22) | (((uint)(minor)) << 12) | ((uint)(patch)));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkPipeline[] CreateGraphicsPipelines(VkDevice                       device,
                                                                  VkPipelineCache                pipelineCache,
                                                                  VkGraphicsPipelineCreateInfo[] createInfos,
                                                                  VkAllocationCallbacks*         pAllocator)
        {
            int         byteSize = (Marshal.SizeOf<VkPipeline>() * createInfos.Length);
            VkPipeline* pArray   = (VkPipeline*)Marshal.AllocHGlobal(byteSize);
            
            ArrayPointer<VkGraphicsPipelineCreateInfo> pcreateInfos = createInfos.ToArrayPointer();

            Check(_CreateGraphicsPipelines(device, pipelineCache, (uint)createInfos.Length, pcreateInfos.Pointer, pAllocator, pArray));

            VkPipeline[] array = new VkPipeline[createInfos.Length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkPipeline[] CreateComputePipelines(VkDevice                      device,
                                                                 VkPipelineCache               pipelineCache,
                                                                 VkComputePipelineCreateInfo[] createInfos,
                                                                 VkAllocationCallbacks*        pAllocator)
        {
            int         byteSize = (Marshal.SizeOf<VkPipeline>() * createInfos.Length);
            VkPipeline* pArray   = (VkPipeline*)Marshal.AllocHGlobal(byteSize);
            
            ArrayPointer<VkComputePipelineCreateInfo> pcreateInfos = createInfos.ToArrayPointer();

            Check(_CreateComputePipelines(device, pipelineCache, (uint)createInfos.Length, pcreateInfos.Pointer, pAllocator, pArray));

            VkPipeline[] array = new VkPipeline[createInfos.Length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);

            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static VkPhysicalDevice[] GetEnumeratePhysicalDevices(VkInstance instance)
        {
            unsafe
            {
                Check(_EnumeratePhysicalDevices(instance, out uint pPhysicalDeviceCount, null));

                int byteSize = (Marshal.SizeOf<VkPhysicalDevice>() * (int)pPhysicalDeviceCount);
                VkPhysicalDevice* pPhysicalDevices = (VkPhysicalDevice*)Marshal.AllocHGlobal(byteSize);

                Check(_EnumeratePhysicalDevices(instance, out pPhysicalDeviceCount, pPhysicalDevices));
                
                VkPhysicalDevice[] physicalDevices = new VkPhysicalDevice[(int)pPhysicalDeviceCount];

                Buffer.MemoryCopy(pPhysicalDevices, Unsafe.AsPointer(ref physicalDevices[0]), byteSize, byteSize);
                Marshal.FreeHGlobal((IntPtr)pPhysicalDevices);

                return physicalDevices;


                //if(result != Result.Success)
                //{
                //    throw new ResultException(result);
                //}

                //if(pPhysicalDeviceCount <= 0)
                //{
                //    return null;
                //}

                //int size                = Marshal.SizeOf(typeof(IntPtr));

                //var refpPhysicalDevices = new NativeReference((int)(size * pPhysicalDeviceCount));

                //var ptrpPhysicalDevices = refpPhysicalDevices.Handle;

                //result = Interop.NativeMethods.vkEnumeratePhysicalDevices(instance, &pPhysicalDeviceCount, (IntPtr*)ptrpPhysicalDevices);

                //if(result != Result.Success)
                //{
                //    throw new ResultException(result);
                //}

                //if(pPhysicalDeviceCount <= 0)
                //{
                //    return null;
                //}

                //var arr = new PhysicalDevice[pPhysicalDeviceCount];

                //for(int i = 0; i < pPhysicalDeviceCount; i++)
                //{
                //    arr[i]   = new PhysicalDevice();
                //    arr[i].m = ((IntPtr*)ptrpPhysicalDevices)[i];
                //}

                //return arr;
            }
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static unsafe VkPhysicalDevice[] EnumeratePhysicalDevices(VkInstance instance)
        {
            Check(_EnumeratePhysicalDevices(instance, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkPhysicalDevice>() * (int)length);
            VkPhysicalDevice* pArray = (VkPhysicalDevice*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumeratePhysicalDevices(instance, out length, pArray));
            
            VkPhysicalDevice[] array = new VkPhysicalDevice[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static unsafe VkQueueFamilyProperties[] GetPhysicalDeviceQueueFamilyProperties(VkPhysicalDevice physicalDevice)
        {
            _GetPhysicalDeviceQueueFamilyProperties(physicalDevice, out uint length, null);

            int byteSize = (Marshal.SizeOf<VkQueueFamilyProperties>() * (int)length);
            VkQueueFamilyProperties* pArray = (VkQueueFamilyProperties*)Marshal.AllocHGlobal(byteSize);

            _GetPhysicalDeviceQueueFamilyProperties(physicalDevice, out length, pArray);
            
            VkQueueFamilyProperties[] array = new VkQueueFamilyProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkExtensionProperties[] EnumerateInstanceExtensionProperties()
        {
            Check(_EnumerateInstanceExtensionProperties(utf8string.Null, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkExtensionProperties>() * (int)length);
            VkExtensionProperties* pArray = (VkExtensionProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateInstanceExtensionProperties(utf8string.Null, out length, pArray));
            
            VkExtensionProperties[] array = new VkExtensionProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkExtensionProperties[] EnumerateInstanceExtensionProperties(utf8string str)
        {
            Check(_EnumerateInstanceExtensionProperties(str, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkExtensionProperties>() * (int)length);
            VkExtensionProperties* pArray = (VkExtensionProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateInstanceExtensionProperties(str, out length, pArray));
            
            VkExtensionProperties[] array = new VkExtensionProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static unsafe VkExtensionProperties[] EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice)
        {
            Check(_EnumerateDeviceExtensionProperties(physicalDevice, utf8string.Null, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkExtensionProperties>() * (int)length);
            VkExtensionProperties* pArray = (VkExtensionProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateDeviceExtensionProperties(physicalDevice, utf8string.Null, out length, pArray));
            
            VkExtensionProperties[] array = new VkExtensionProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkExtensionProperties[] EnumerateDeviceExtensionProperties(VkPhysicalDevice physicalDevice,
                                                                                        utf8string str)
        {
            Check(_EnumerateDeviceExtensionProperties(physicalDevice, str, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkExtensionProperties>() * (int)length);
            VkExtensionProperties* pArray = (VkExtensionProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateDeviceExtensionProperties(physicalDevice, str, out length, pArray));

            VkExtensionProperties[] array = new VkExtensionProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkLayerProperties[] EnumerateInstanceLayerProperties()
        {
            Check(_EnumerateInstanceLayerProperties(out uint length, null));

            int byteSize = (Marshal.SizeOf<VkLayerProperties>() * (int)length);
            VkLayerProperties* pArray = (VkLayerProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateInstanceLayerProperties(out length, pArray));
            
            VkLayerProperties[] array = new VkLayerProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkLayerProperties[] EnumerateDeviceLayerProperties(VkPhysicalDevice physicalDevice)
        {
            Check(_EnumerateDeviceLayerProperties(physicalDevice, out uint length, null));

            int byteSize = (Marshal.SizeOf<VkLayerProperties>() * (int)length);
            VkLayerProperties* pArray = (VkLayerProperties*)Marshal.AllocHGlobal(byteSize);

            Check(_EnumerateDeviceLayerProperties(physicalDevice, out length, pArray));

            VkLayerProperties[] array = new VkLayerProperties[(int)length];

            Buffer.MemoryCopy(pArray, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);
            Marshal.FreeHGlobal((IntPtr)pArray);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSparseImageMemoryRequirements[] GetImageSparseMemoryRequirements(VkDevice device,
                                                                                                VkImage image)
        {
            _GetImageSparseMemoryRequirements(device, image, out uint length, null);

            ArrayPointer<VkSparseImageMemoryRequirements> pArray = NativeIntExtensions.CreateArrayPointer<VkSparseImageMemoryRequirements>(length);

            _GetImageSparseMemoryRequirements(device, image, out length, pArray.Pointer);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSparseImageFormatProperties[] GetPhysicalDeviceSparseImageFormatProperties(VkPhysicalDevice physicalDevice,
                                                                                                          VkFormat format,
                                                                                                          VkImageType imageType,
                                                                                                          VkSampleCountFlagBits sampleCountFlagBits,
                                                                                                          VkImageUsageFlagBits usage,
                                                                                                          VkImageTiling imageTiling)
        {
            _GetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, imageType, sampleCountFlagBits, usage, imageTiling, out uint length, null);

            ArrayPointer<VkSparseImageFormatProperties> pArray = NativeIntExtensions.CreateArrayPointer<VkSparseImageFormatProperties>(length);

            _GetPhysicalDeviceSparseImageFormatProperties(physicalDevice, format, imageType, sampleCountFlagBits, usage, imageTiling, out length, pArray.Pointer);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkCommandBuffer[] AllocateCommandBuffers(VkDevice device,
                                                                      ref VkCommandBufferAllocateInfo commandBufferAllocateInfo)
        {
            ArrayPointer<VkCommandBuffer> pCommandBuffers = NativeIntExtensions.CreateArrayPointer<VkCommandBuffer>(commandBufferAllocateInfo.CommandBufferCount);

            Check(_AllocateCommandBuffers(device, ref commandBufferAllocateInfo, pCommandBuffers.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pCommandBuffers);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkPhysicalDeviceGroupProperties[] EnumeratePhysicalDeviceGroups(VkInstance instance)
        {
            Check(_EnumeratePhysicalDeviceGroups(instance, out uint length, null));

            ArrayPointer<VkPhysicalDeviceGroupProperties> pArray = NativeIntExtensions.CreateArrayPointer<VkPhysicalDeviceGroupProperties>(length);

            Check(_EnumeratePhysicalDeviceGroups(instance, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSparseImageMemoryRequirements2[] GetImageSparseMemoryRequirements2(VkDevice device,
                                                                                                  ref VkImageSparseMemoryRequirementsInfo2 imageSparseMemoryRequirementsInfo2)
        {
            _GetImageSparseMemoryRequirements2(device, ref imageSparseMemoryRequirementsInfo2, out uint length, null);

            ArrayPointer<VkSparseImageMemoryRequirements2> pArray = NativeIntExtensions.CreateArrayPointer<VkSparseImageMemoryRequirements2>(length);

            _GetImageSparseMemoryRequirements2(device, ref imageSparseMemoryRequirementsInfo2, out length, pArray.Pointer);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkQueueFamilyProperties2[] GetPhysicalDeviceQueueFamilyProperties2(VkPhysicalDevice physicalDevice)
        {
            _GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, out uint length, null);

            ArrayPointer<VkQueueFamilyProperties2> pArray = NativeIntExtensions.CreateArrayPointer<VkQueueFamilyProperties2>(length);

            _GetPhysicalDeviceQueueFamilyProperties2(physicalDevice, out length, pArray.Pointer);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSparseImageFormatProperties2[] GetPhysicalDeviceSparseImageFormatProperties2(VkPhysicalDevice physicalDevice,
                                                                                                            ref VkPhysicalDeviceSparseImageFormatInfo2 physicalDeviceSparseImageFormatInfo2)
        {
            _GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, ref physicalDeviceSparseImageFormatInfo2, out uint length, null);

            ArrayPointer<VkSparseImageFormatProperties2> pArray = NativeIntExtensions.CreateArrayPointer<VkSparseImageFormatProperties2>(length);

            _GetPhysicalDeviceSparseImageFormatProperties2(physicalDevice, ref physicalDeviceSparseImageFormatInfo2, out length, pArray.Pointer);

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSurfaceFormatKHR[] GetPhysicalDeviceSurfaceFormatsKHR(VkPhysicalDevice physicalDevice,
                                                                                     VkSurfaceKHR surfaceKHR)
        {
            Check(_GetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surfaceKHR, out uint length, null));

            ArrayPointer<VkSurfaceFormatKHR> pArray = NativeIntExtensions.CreateArrayPointer<VkSurfaceFormatKHR>(length);

            Check(_GetPhysicalDeviceSurfaceFormatsKHR(physicalDevice, surfaceKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkPresentModeKHR[] GetPhysicalDeviceSurfacePresentModesKHR(VkPhysicalDevice physicalDevice,
                                                                                        VkSurfaceKHR surfaceKHR)
        {
            Check(_GetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surfaceKHR, out uint length, null));

            ArrayPointer<VkPresentModeKHR> pArray = NativeIntExtensions.CreateEnumArrayPointer<VkPresentModeKHR>(length);

            Check(_GetPhysicalDeviceSurfacePresentModesKHR(physicalDevice, surfaceKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteEnumArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkImage[] GetSwapchainImagesKHR(VkDevice device,
                                                             VkSwapchainKHR swapchainKHR)
        {
            Check(_GetSwapchainImagesKHR(device, swapchainKHR, out uint length, null));

            ArrayPointer<VkImage> pArray = NativeIntExtensions.CreateArrayPointer<VkImage>(length);

            Check(_GetSwapchainImagesKHR(device, swapchainKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkRect2D[] GetPhysicalDevicePresentRectanglesKHR(VkPhysicalDevice physicalDevice,
                                                                              VkSurfaceKHR surfaceKHR)
        {
            Check(_GetPhysicalDevicePresentRectanglesKHR(physicalDevice, surfaceKHR, out uint length, null));

            ArrayPointer<VkRect2D> pArray = NativeIntExtensions.CreateArrayPointer<VkRect2D>(length);

            Check(_GetPhysicalDevicePresentRectanglesKHR(physicalDevice, surfaceKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayPropertiesKHR[] GetPhysicalDeviceDisplayPropertiesKHR(VkPhysicalDevice physicalDevice)
        {
            Check(_GetPhysicalDeviceDisplayPropertiesKHR(physicalDevice, out uint length, null));

            ArrayPointer<VkDisplayPropertiesKHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayPropertiesKHR>(length);

            Check(_GetPhysicalDeviceDisplayPropertiesKHR(physicalDevice, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayPlanePropertiesKHR[] GetPhysicalDeviceDisplayPlanePropertiesKHR(VkPhysicalDevice physicalDevice)
        {
            Check(_GetPhysicalDeviceDisplayPlanePropertiesKHR(physicalDevice, out uint length, null));

            ArrayPointer<VkDisplayPlanePropertiesKHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayPlanePropertiesKHR>(length);

            Check(_GetPhysicalDeviceDisplayPlanePropertiesKHR(physicalDevice, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayKHR[] GetDisplayPlaneSupportedDisplaysKHR(VkPhysicalDevice physicalDevice,
                                                                                uint planeIndex)
        {
            Check(_GetDisplayPlaneSupportedDisplaysKHR(physicalDevice, planeIndex, out uint length, null));

            ArrayPointer<VkDisplayKHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayKHR>(length);

            Check(_GetDisplayPlaneSupportedDisplaysKHR(physicalDevice, planeIndex, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayModePropertiesKHR[] GetDisplayModePropertiesKHR(VkPhysicalDevice physicalDevice,
                                                                                      VkDisplayKHR displayKHR)
        {
            Check(_GetDisplayModePropertiesKHR(physicalDevice, displayKHR, out uint length, null));

            ArrayPointer<VkDisplayModePropertiesKHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayModePropertiesKHR>(length);

            Check(_GetDisplayModePropertiesKHR(physicalDevice, displayKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkSurfaceFormat2KHR[] GetPhysicalDeviceSurfaceFormats2KHR(VkPhysicalDevice physicalDevice,
                                                                                       ref VkPhysicalDeviceSurfaceInfo2KHR physicalDeviceSurfaceInfo2KHR)
        {
            Check(_GetPhysicalDeviceSurfaceFormats2KHR(physicalDevice, ref physicalDeviceSurfaceInfo2KHR, out uint length, null));

            ArrayPointer<VkSurfaceFormat2KHR> pArray = NativeIntExtensions.CreateArrayPointer<VkSurfaceFormat2KHR>(length);

            Check(_GetPhysicalDeviceSurfaceFormats2KHR(physicalDevice, ref physicalDeviceSurfaceInfo2KHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayProperties2KHR[] GetPhysicalDeviceDisplayProperties2KHR(VkPhysicalDevice physicalDevice)
        {
            Check(_GetPhysicalDeviceDisplayProperties2KHR(physicalDevice, out uint length, null));

            ArrayPointer<VkDisplayProperties2KHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayProperties2KHR>(length);

            Check(_GetPhysicalDeviceDisplayProperties2KHR(physicalDevice, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayPlaneProperties2KHR[] GetPhysicalDeviceDisplayPlaneProperties2KHR(VkPhysicalDevice physicalDevice)
        {
            Check(_GetPhysicalDeviceDisplayPlaneProperties2KHR(physicalDevice, out uint length, null));

            ArrayPointer<VkDisplayPlaneProperties2KHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayPlaneProperties2KHR>(length);

            Check(_GetPhysicalDeviceDisplayPlaneProperties2KHR(physicalDevice, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDisplayModeProperties2KHR[] GetDisplayModeProperties2KHR(VkPhysicalDevice physicalDevice,
                                                                                        VkDisplayKHR displayKHR)
        {
            Check(_GetDisplayModeProperties2KHR(physicalDevice, displayKHR, out uint length, null));

            ArrayPointer<VkDisplayModeProperties2KHR> pArray = NativeIntExtensions.CreateArrayPointer<VkDisplayModeProperties2KHR>(length);

            Check(_GetDisplayModeProperties2KHR(physicalDevice, displayKHR, out length, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        internal static unsafe void QueueSubmit(VkQueue queue,
                                              VkSubmitInfo[] submitInfo,
                                              VkFence fence)
        {
            ArrayPointer<VkSubmitInfo> psubmitInfo = submitInfo.ToArrayPointer();

            Check(_QueueSubmit(queue, (uint)submitInfo.Length, psubmitInfo.Pointer, fence));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void MergePipelineCaches(VkDevice device, VkPipelineCache dstCache, VkPipelineCache[] srcCaches)
        {
            ArrayPointer<VkPipelineCache> pSrcCaches = srcCaches.ToArrayPointer();

            Check(_MergePipelineCaches(device, dstCache, (uint)srcCaches.Length, pSrcCaches.Pointer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void FlushMappedMemoryRanges(VkDevice device,
                                                          VkMappedMemoryRange[] mappedMemoryRange)
        {
            ArrayPointer<VkMappedMemoryRange> pMappedMemoryRange = mappedMemoryRange.ToArrayPointer();

            Check(_FlushMappedMemoryRanges(device, (uint)mappedMemoryRange.Length, pMappedMemoryRange.Pointer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void InvalidateMappedMemoryRanges(VkDevice device,
                                                               VkMappedMemoryRange[] mappedMemoryRange)
        {
            ArrayPointer<VkMappedMemoryRange> pArray = mappedMemoryRange.ToArrayPointer();

            Check(_InvalidateMappedMemoryRanges(device, pArray.Length, pArray.Pointer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void QueueBindSparse(VkQueue queue,
                                                  VkBindSparseInfo[] bindSparseInfo,
                                                  VkFence fence)
        {
            ArrayPointer<VkBindSparseInfo> pBindSparseInfo = bindSparseInfo.ToArrayPointer();

            Check(_QueueBindSparse(queue, pBindSparseInfo.Length, pBindSparseInfo.Pointer, fence));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void ResetFences(VkDevice device,
                                              VkFence[] fences)
        {
            ArrayPointer<VkFence> pFences = fences.ToArrayPointer();

            Check(_ResetFences(device, pFences.Length, pFences.Pointer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void WaitForFences(VkDevice  device,
                                                VkFence[] fences,
                                                uint      waitAll,
                                                ulong     timeout)
        {
            ArrayPointer<VkFence> pFences = fences.ToArrayPointer();

            Check(_WaitForFences(device, pFences.Length, pFences.Pointer, waitAll, timeout));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe VkDescriptorSet[] AllocateDescriptorSets(VkDevice                        device,
                                                                      ref VkDescriptorSetAllocateInfo pAllocateInfo)
        {
            ArrayPointer<VkDescriptorSet> pArray = NativeIntExtensions.CreateArrayPointer<VkDescriptorSet>(pAllocateInfo.DescriptorSetCount);

            Check(_AllocateDescriptorSets(device, ref pAllocateInfo, pArray.Pointer));

            return NativeIntExtensions.CopyAndDeleteArrayPointer(pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void FreeDescriptorSets(VkDevice device,
                                                     VkDescriptorPool descriptorPool,
                                                     VkDescriptorSet[] descriptorSet)
        {
            ArrayPointer<VkDescriptorSet> pDescriptorSet = descriptorSet.ToArrayPointer();

            Check(_FreeDescriptorSets(device, descriptorPool, pDescriptorSet.Length, pDescriptorSet.Pointer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void UpdateDescriptorSets(VkDevice device,
                                                       VkWriteDescriptorSet[] descriptorWrites,
                                                       VkCopyDescriptorSet[] descriptorCopies)
        {
            if (descriptorWrites.Length > 0 && descriptorCopies.Length > 0)
            {
                ArrayPointer<VkWriteDescriptorSet> pWriteDescriptorSet = descriptorWrites.ToArrayPointer();
                ArrayPointer<VkCopyDescriptorSet> pCopyDescriptorSet = descriptorCopies.ToArrayPointer();

                _UpdateDescriptorSets(device, pWriteDescriptorSet.Length, pWriteDescriptorSet.Pointer, pCopyDescriptorSet.Length, pCopyDescriptorSet.Pointer);
            }
            else if (descriptorWrites.Length == 0)
            {
                ArrayPointer<VkCopyDescriptorSet>  pCopyDescriptorSet  = descriptorCopies.ToArrayPointer();

                _UpdateDescriptorSets(device, 0, null, pCopyDescriptorSet.Length, pCopyDescriptorSet.Pointer);
            }
            else
            {
                ArrayPointer<VkWriteDescriptorSet> pWriteDescriptorSet = descriptorWrites.ToArrayPointer();

                _UpdateDescriptorSets(device, pWriteDescriptorSet.Length, pWriteDescriptorSet.Pointer, 0, null);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void FreeCommandBuffer(VkDevice device,
                                                    VkCommandPool commandPool,
                                                    ref VkCommandBuffer commandBuffer)
        {
            _FreeCommandBuffers(device, commandPool, 1, (VkCommandBuffer*)Unsafe.AsPointer(ref commandBuffer));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void FreeCommandBuffers(VkDevice          device,
                                                     VkCommandPool     commandPool,
                                                     VkCommandBuffer[] commandBuffers)
        {
            ArrayPointer<VkCommandBuffer> pCommandBuffers = commandBuffers.ToArrayPointer();

            _FreeCommandBuffers(device, commandPool, pCommandBuffers.Length, pCommandBuffers.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdSetViewport(VkCommandBuffer commandBuffer,
                                                 uint            firstViewport,
                                                 ref VkViewport      viewport)
        {
            _CmdSetViewport(commandBuffer, firstViewport, 1, (VkViewport*)Unsafe.AsPointer(ref viewport));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdSetViewport(VkCommandBuffer commandBuffer,
                                                 uint            firstViewport,
                                                 VkViewport[]    viewports)
        {
            ArrayPointer<VkViewport> pViewports = viewports.ToArrayPointer();

            _CmdSetViewport(commandBuffer, firstViewport, pViewports.Length, pViewports.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdSetScissor(VkCommandBuffer commandBuffer,
                                                uint            firstScissor,
                                                ref VkRect2D      scissor)
        {
            _CmdSetScissor(commandBuffer, firstScissor, 1, (VkRect2D*)Unsafe.AsPointer(ref scissor));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdSetScissor(VkCommandBuffer commandBuffer,
                                                uint            firstScissor,
                                                VkRect2D[]      scissors)
        {
            ArrayPointer<VkRect2D> pScissors = scissors.ToArrayPointer();

            _CmdSetScissor(commandBuffer, firstScissor, pScissors.Length, pScissors.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdBindDescriptorSets(VkCommandBuffer commandBuffer,
                                                        VkPipelineBindPoint pipelineBindPoint,
                                                        VkPipelineLayout layout,
                                                        uint firstSet,
                                                        VkDescriptorSet[] descriptorSets,
                                                        uint[] dynamicOffsets)
        {
            ArrayPointer<VkDescriptorSet> pDescriptorSets = descriptorSets.ToArrayPointer();

            if (dynamicOffsets.Length == 0)
            {
                _CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, pDescriptorSets.Length, pDescriptorSets.Pointer, 0, null);
            }
            else
            {
                ArrayPointer<uint> pDynamicOffsets = dynamicOffsets.ToArrayPointer();
                
                _CmdBindDescriptorSets(commandBuffer, pipelineBindPoint, layout, firstSet, pDescriptorSets.Length, pDescriptorSets.Pointer, pDynamicOffsets.Length, pDynamicOffsets.Pointer);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdBindVertexBuffers(VkCommandBuffer commandBuffer,
                                                       uint firstBinding,
                                                       VkBuffer[] buffers,
                                                       ulong[] offsets)
        {
            ArrayPointer<VkBuffer> pBuffers = buffers.ToArrayPointer();
            ArrayPointer<ulong> pOffsets = offsets.ToArrayPointer();

            _CmdBindVertexBuffers(commandBuffer, firstBinding, pBuffers.Length, pBuffers.Pointer, pOffsets.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdCopyBuffer(VkCommandBuffer commandBuffer,
                                                VkBuffer srcBuffer,
                                                VkBuffer dstBuffer,
                                                VkBufferCopy[] regions)
        {
            ArrayPointer<VkBufferCopy> pRegions = regions.ToArrayPointer();

            _CmdCopyBuffer(commandBuffer, srcBuffer, dstBuffer, pRegions.Length, pRegions.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdCopyImage(VkCommandBuffer commandBuffer,
                                               VkImage srcImage,
                                               VkImageLayout srcImageLayout,
                                               VkImage dstImage,
                                               VkImageLayout dstImageLayout,
                                               VkImageCopy[] regions)
        {
            ArrayPointer<VkImageCopy> pRegions = regions.ToArrayPointer();

            _CmdCopyImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, pRegions.Length, pRegions.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdBlitImage(VkCommandBuffer commandBuffer,
                                               VkImage srcImage,
                                               VkImageLayout srcImageLayout,
                                               VkImage dstImage,
                                               VkImageLayout dstImageLayout,
                                               VkImageBlit[] regions,
                                               VkFilter filter)
        {
            ArrayPointer<VkImageBlit> pRegions = regions.ToArrayPointer();

            _CmdBlitImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, pRegions.Length, pRegions.Pointer, filter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdCopyBufferToImage(VkCommandBuffer commandBuffer,
                                                       VkBuffer srcBuffer,
                                                       VkImage dstImage,
                                                       VkImageLayout dstImageLayout,
                                                       VkBufferImageCopy[] regions)
        {
            ArrayPointer<VkBufferImageCopy> pRegions = regions.ToArrayPointer();

            _CmdCopyBufferToImage(commandBuffer, srcBuffer, dstImage, dstImageLayout, pRegions.Length, pRegions.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdCopyImageToBuffer(VkCommandBuffer commandBuffer,
                                                       VkImage srcImage,
                                                       VkImageLayout srcImageLayout,
                                                       VkBuffer dstBuffer,
                                                       VkBufferImageCopy[] regions)
        {
            ArrayPointer<VkBufferImageCopy> pRegions = regions.ToArrayPointer();

            _CmdCopyImageToBuffer(commandBuffer, srcImage, srcImageLayout, dstBuffer, pRegions.Length, pRegions.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdClearColorImage(VkCommandBuffer commandBuffer,
                                                     VkImage image,
                                                     VkImageLayout imageLayout,
                                                     ref VkClearColorValue pColor,
                                                     VkImageSubresourceRange[] ranges)
        {
            ArrayPointer<VkImageSubresourceRange> pRanges = ranges.ToArrayPointer();

            _CmdClearColorImage(commandBuffer, image, imageLayout, ref pColor, pRanges.Length, pRanges.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdClearDepthStencilImage(VkCommandBuffer commandBuffer,
                                                            VkImage image,
                                                            VkImageLayout imageLayout,
                                                            ref VkClearDepthStencilValue pDepthStencil,
                                                            VkImageSubresourceRange[] ranges)
        {
            ArrayPointer<VkImageSubresourceRange> pRanges = ranges.ToArrayPointer();

            _CmdClearDepthStencilImage(commandBuffer, image, imageLayout, ref pDepthStencil, pRanges.Length, pRanges.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdClearAttachments(VkCommandBuffer commandBuffer,
                                                      VkClearAttachment[] attachments,
                                                      VkClearRect[] rects)
        {
            ArrayPointer<VkClearAttachment> pAttachments = attachments.ToArrayPointer();
            ArrayPointer<VkClearRect> pRects = rects.ToArrayPointer();

            _CmdClearAttachments(commandBuffer, pAttachments.Length, pAttachments.Pointer, pRects.Length, pRects.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdResolveImage(VkCommandBuffer commandBuffer,
                                                  VkImage srcImage,
                                                  VkImageLayout srcImageLayout,
                                                  VkImage dstImage,
                                                  VkImageLayout dstImageLayout,
                                                  VkImageResolve[] regions)
        {
            ArrayPointer<VkImageResolve> pRegions = regions.ToArrayPointer();

            _CmdResolveImage(commandBuffer, srcImage, srcImageLayout, dstImage, dstImageLayout, pRegions.Length, pRegions.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdWaitEvents(VkCommandBuffer commandBuffer,
                                                VkEvent[] events,
                                                VkPipelineStageFlagBits srcStageMask,
                                                VkPipelineStageFlagBits dstStageMask,
                                                VkMemoryBarrier[] memoryBarriers,
                                                VkBufferMemoryBarrier[] bufferMemoryBarriers,
                                                VkImageMemoryBarrier[] imageMemoryBarriers)
        {
            ArrayPointer<VkEvent> pEvents = events.ToArrayPointer();

            ArrayPointer<VkMemoryBarrier> pMemoryBarriers = memoryBarriers.ToArrayPointer();

            ArrayPointer<VkBufferMemoryBarrier> pBufferMemoryBarriers = bufferMemoryBarriers.ToArrayPointer();

            ArrayPointer<VkImageMemoryBarrier> pImageMemoryBarriers = imageMemoryBarriers.ToArrayPointer();

            _CmdWaitEvents(commandBuffer, pEvents.Length, pEvents.Pointer,
                srcStageMask, dstStageMask,
                pMemoryBarriers.Length, pMemoryBarriers.Pointer,
                pBufferMemoryBarriers.Length, pBufferMemoryBarriers.Pointer,
                pImageMemoryBarriers.Length, pImageMemoryBarriers.Pointer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void CmdPipelineBarrier(VkCommandBuffer commandBuffer,
                                                     VkPipelineStageFlagBits srcStageMask,
                                                     VkPipelineStageFlagBits dstStageMask,
                                                     VkDependencyFlagBits dependencyFlags,
                                                     VkMemoryBarrier[] memoryBarriers,
                                                     VkBufferMemoryBarrier[] bufferMemoryBarriers,
                                                     VkImageMemoryBarrier[] imageMemoryBarriers)
        {
            ArrayPointer<VkMemoryBarrier> pMemoryBarriers = memoryBarriers.ToArrayPointer();
            ArrayPointer<VkBufferMemoryBarrier> pBufferMemoryBarriers = bufferMemoryBarriers.ToArrayPointer();
            ArrayPointer<VkImageMemoryBarrier> pImageMemoryBarriers = imageMemoryBarriers.ToArrayPointer();

            _CmdPipelineBarrier(commandBuffer, srcStageMask, dstStageMask, dependencyFlags,
                pMemoryBarriers.Length, pMemoryBarriers.Pointer,
                pBufferMemoryBarriers.Length, pBufferMemoryBarriers.Pointer,
                pImageMemoryBarriers.Length, pImageMemoryBarriers.Pointer);
        }



        //public static LayerProperties[] EnumerateInstanceLayerProperties()
        //{
        //    Result result;
        //    unsafe
        //    {
        //        UInt32 pPropertyCount;
        //        result = Interop.NativeMethods.vkEnumerateInstanceLayerProperties(&pPropertyCount, null);
        //        if(result != Result.Success)
        //            throw new ResultException(result);
        //        if(pPropertyCount <= 0)
        //            return null;

        //        int size = Marshal.SizeOf(typeof(Interop.LayerProperties));
        //        var refpProperties = new NativeReference((int)(size * pPropertyCount));
        //        var ptrpProperties = refpProperties.Handle;
        //        result = Interop.NativeMethods.vkEnumerateInstanceLayerProperties(&pPropertyCount, (Interop.LayerProperties*)ptrpProperties);
        //        if(result != Result.Success)
        //            throw new ResultException(result);

        //        if(pPropertyCount <= 0)
        //            return null;
        //        var arr = new LayerProperties[pPropertyCount];
        //        for(int i = 0; i < pPropertyCount; i++)
        //        {
        //            arr[i] = new LayerProperties(new NativePointer(refpProperties, (IntPtr)(&((Interop.LayerProperties*)ptrpProperties)[i])));
        //        }

        //        return arr;
        //    }
        //}

        //public static ExtensionProperties[] EnumerateInstanceExtensionProperties(string pLayerName = null)
        //{
        //    Result result;
        //    unsafe
        //    {
        //        UInt32 pPropertyCount;
        //        result = Interop.NativeMethods.vkEnumerateInstanceExtensionProperties(pLayerName, &pPropertyCount, null);
        //        if(result != Result.Success)
        //            throw new ResultException(result);
        //        if(pPropertyCount <= 0)
        //            return null;

        //        int size = Marshal.SizeOf(typeof(Interop.ExtensionProperties));
        //        var refpProperties = new NativeReference((int)(size * pPropertyCount));
        //        var ptrpProperties = refpProperties.Handle;
        //        result = Interop.NativeMethods.vkEnumerateInstanceExtensionProperties(pLayerName, &pPropertyCount, (Interop.ExtensionProperties*)ptrpProperties);
        //        if(result != Result.Success)
        //            throw new ResultException(result);

        //        if(pPropertyCount <= 0)
        //            return null;
        //        var arr = new ExtensionProperties[pPropertyCount];
        //        for(int i = 0; i < pPropertyCount; i++)
        //        {
        //            arr[i] = new ExtensionProperties(new NativePointer(refpProperties, (IntPtr)(&((Interop.ExtensionProperties*)ptrpProperties)[i])));
        //        }

        //        return arr;
        //    }
        //}


        //public static unsafe delegate* <nint,HINSTANCE>         LoadLibraryA   = (delegate* <nint,HINSTANCE>)NativeLibrary.GetExport(Handle,         "LoadLibraryA");
        //public static unsafe delegate* <HINSTANCE,int>          FreeLibrary    = (delegate* <HINSTANCE,int>)NativeLibrary.GetExport(Handle,          "FreeLibrary");
        //public static unsafe delegate* <HINSTANCE,nint,FARPROC> GetProcAddress = (delegate* <HINSTANCE,nint,FARPROC>)NativeLibrary.GetExport(Handle, "GetProcAddress");
    }




    //public readonly partial struct VkPhysicalDevice
    //{
    //    public void GetFeatures(ref VkPhysicalDeviceFeatures pFeatures) { return Api.vkGetPhysicalDeviceFeatures(this, pFeatures); }
    //    public void GetFormatProperties(VkFormat format, VkFormatProperties* pFormatProperties) { return Api.vkGetPhysicalDeviceFormatProperties(this, VkFormat format, VkFormatProperties * pFormatProperties); }
    //    public VkResult GetImageFormatProperties(VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, VkImageFormatProperties* pImageFormatProperties) { return Api.vkGetPhysicalDeviceImageFormatProperties(this, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, VkImageFormatProperties * pImageFormatProperties); }
    //    public void GetProperties(VkPhysicalDeviceProperties* pProperties) { return Api.vkGetPhysicalDeviceProperties(this, VkPhysicalDeviceProperties * pProperties); }
    //    public void GetQueueFamilyProperties(uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties* pQueueFamilyProperties) { return Api.vkGetPhysicalDeviceQueueFamilyProperties(this, uint * pQueueFamilyPropertyCount, VkQueueFamilyProperties * pQueueFamilyProperties); }
    //    public void GetMemoryProperties(VkPhysicalDeviceMemoryProperties* pMemoryProperties) { return Api.vkGetPhysicalDeviceMemoryProperties(this, VkPhysicalDeviceMemoryProperties * pMemoryProperties); }
    //    public VkResult vkCreateDevice(ref VkDeviceCreateInfo pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice* pDevice) { return Api.vkCreateDevice(this, ref VkDeviceCreateInfo pCreateInfo, VkAllocationCallbacks* pAllocator, VkDevice * pDevice); }
    //    public VkResult vkEnumerateDeviceExtensionProperties(utf8string pLayerName, uint* pPropertyCount, VkExtensionProperties* pProperties) { return Api.vkEnumerateDeviceExtensionProperties(this, utf8string pLayerName, uint * pPropertyCount, VkExtensionProperties * pProperties); }
    //    public VkResult vkEnumerateDeviceLayerProperties(uint* pPropertyCount, VkLayerProperties* pProperties) { return Api.vkEnumerateDeviceLayerProperties(this, uint * pPropertyCount, VkLayerProperties * pProperties); }
    //    public void GetSparseImageFormatProperties(VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint* pPropertyCount, VkSparseImageFormatProperties* pProperties) { return Api.vkGetPhysicalDeviceSparseImageFormatProperties(this, VkFormat format, VkImageType type, VkSampleCountFlagBits samples, uint usage, VkImageTiling tiling, uint * pPropertyCount, VkSparseImageFormatProperties * pProperties); }
    //    public void GetFeatures2(VkPhysicalDeviceFeatures2* pFeatures) { return Api.vkGetPhysicalDeviceFeatures2(this, VkPhysicalDeviceFeatures2 * pFeatures); }
    //    public void GetProperties2(VkPhysicalDeviceProperties2* pProperties) { return Api.vkGetPhysicalDeviceProperties2(this, VkPhysicalDeviceProperties2 * pProperties); }
    //    public void GetFormatProperties2(VkFormat format, VkFormatProperties2* pFormatProperties) { return Api.vkGetPhysicalDeviceFormatProperties2(this, VkFormat format, VkFormatProperties2 * pFormatProperties); }
    //    public VkResult GetImageFormatProperties2(ref VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) { return Api.vkGetPhysicalDeviceImageFormatProperties2(this, ref VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, VkImageFormatProperties2 * pImageFormatProperties); }
    //    public void GetQueueFamilyProperties2(uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) { return Api.vkGetPhysicalDeviceQueueFamilyProperties2(this, uint * pQueueFamilyPropertyCount, VkQueueFamilyProperties2 * pQueueFamilyProperties); }
    //    public void GetMemoryProperties2(VkPhysicalDeviceMemoryProperties2* pMemoryProperties) { return Api.vkGetPhysicalDeviceMemoryProperties2(this, VkPhysicalDeviceMemoryProperties2 * pMemoryProperties); }
    //    public void GetSparseImageFormatProperties2(ref VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties) { return Api.vkGetPhysicalDeviceSparseImageFormatProperties2(this, ref VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, uint * pPropertyCount, VkSparseImageFormatProperties2 * pProperties); }
    //    public void GetExternalBufferProperties(ref VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) { return Api.vkGetPhysicalDeviceExternalBufferProperties(this, ref VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, VkExternalBufferProperties * pExternalBufferProperties); }
    //    public void GetExternalFenceProperties(ref VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) { return Api.vkGetPhysicalDeviceExternalFenceProperties(this, ref VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, VkExternalFenceProperties * pExternalFenceProperties); }
    //    public void GetExternalSemaphoreProperties(ref VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) { return Api.vkGetPhysicalDeviceExternalSemaphoreProperties(this, ref VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, VkExternalSemaphoreProperties * pExternalSemaphoreProperties); }
    //    public VkResult GetSurfaceSupportKHR(uint queueFamilyIndex, VkSurfaceKHR surface, uint* pSupported) { return Api.vkGetPhysicalDeviceSurfaceSupportKHR(this, uint queueFamilyIndex, VkSurfaceKHR surface, uint * pSupported); }
    //    public VkResult GetSurfaceCapabilitiesKHR(VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR* pSurfaceCapabilities) { return Api.vkGetPhysicalDeviceSurfaceCapabilitiesKHR(this, VkSurfaceKHR surface, VkSurfaceCapabilitiesKHR * pSurfaceCapabilities); }
    //    public VkResult GetSurfaceFormatsKHR(VkSurfaceKHR surface, uint* pSurfaceFormatCount, VkSurfaceFormatKHR* pSurfaceFormats) { return Api.vkGetPhysicalDeviceSurfaceFormatsKHR(this, VkSurfaceKHR surface, uint * pSurfaceFormatCount, VkSurfaceFormatKHR * pSurfaceFormats); }
    //    public VkResult GetSurfacePresentModesKHR(VkSurfaceKHR surface, uint* pPresentModeCount, VkPresentModeKHR* pPresentModes) { return Api.vkGetPhysicalDeviceSurfacePresentModesKHR(this, VkSurfaceKHR surface, uint * pPresentModeCount, VkPresentModeKHR * pPresentModes); }
    //    public VkResult GetPresentRectanglesKHR(VkSurfaceKHR surface, uint* pRectCount, VkRect2D* pRects) { return Api.vkGetPhysicalDevicePresentRectanglesKHR(this, VkSurfaceKHR surface, uint * pRectCount, VkRect2D * pRects); }
    //    public VkResult GetDisplayPropertiesKHR(uint* pPropertyCount, ref VkDisplayPropertiesKHR pProperties) { return Api.vkGetPhysicalDeviceDisplayPropertiesKHR(this, uint * pPropertyCount, ref VkDisplayPropertiesKHR pProperties); }
    //    public VkResult GetDisplayPlanePropertiesKHR(uint* pPropertyCount, ref VkDisplayPlanePropertiesKHR pProperties) { return Api.vkGetPhysicalDeviceDisplayPlanePropertiesKHR(this, uint * pPropertyCount, ref VkDisplayPlanePropertiesKHR pProperties); }
    //    public VkResult vkGetDisplayPlaneSupportedDisplaysKHR(uint planeIndex, uint* pDisplayCount, VkDisplayKHR* pDisplays) { return Api.vkGetDisplayPlaneSupportedDisplaysKHR(this, uint planeIndex, uint * pDisplayCount, VkDisplayKHR * pDisplays); }
    //    public VkResult vkGetDisplayModePropertiesKHR(VkDisplayKHR display, uint* pPropertyCount, VkDisplayModePropertiesKHR* pProperties) { return Api.vkGetDisplayModePropertiesKHR(this, VkDisplayKHR display, uint * pPropertyCount, VkDisplayModePropertiesKHR * pProperties); }
    //    public VkResult vkCreateDisplayModeKHR(VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR* pMode) { return Api.vkCreateDisplayModeKHR(this, VkDisplayKHR display, ref VkDisplayModeCreateInfoKHR pCreateInfo, VkAllocationCallbacks* pAllocator, VkDisplayModeKHR * pMode); }
    //    public VkResult vkGetDisplayPlaneCapabilitiesKHR(VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR* pCapabilities) { return Api.vkGetDisplayPlaneCapabilitiesKHR(this, VkDisplayModeKHR mode, uint planeIndex, VkDisplayPlaneCapabilitiesKHR * pCapabilities); }
    //    public void GetFeatures2KHR(VkPhysicalDeviceFeatures2* pFeatures) { return Api.vkGetPhysicalDeviceFeatures2KHR(this, VkPhysicalDeviceFeatures2 * pFeatures); }
    //    public void GetProperties2KHR(VkPhysicalDeviceProperties2* pProperties) { return Api.vkGetPhysicalDeviceProperties2KHR(this, VkPhysicalDeviceProperties2 * pProperties); }
    //    public void GetFormatProperties2KHR(VkFormat format, VkFormatProperties2* pFormatProperties) { return Api.vkGetPhysicalDeviceFormatProperties2KHR(this, VkFormat format, VkFormatProperties2 * pFormatProperties); }
    //    public VkResult GetImageFormatProperties2KHR(ref VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, VkImageFormatProperties2* pImageFormatProperties) { return Api.vkGetPhysicalDeviceImageFormatProperties2KHR(this, ref VkPhysicalDeviceImageFormatInfo2 pImageFormatInfo, VkImageFormatProperties2 * pImageFormatProperties); }
    //    public void GetQueueFamilyProperties2KHR(uint* pQueueFamilyPropertyCount, VkQueueFamilyProperties2* pQueueFamilyProperties) { return Api.vkGetPhysicalDeviceQueueFamilyProperties2KHR(this, uint * pQueueFamilyPropertyCount, VkQueueFamilyProperties2 * pQueueFamilyProperties); }
    //    public void GetMemoryProperties2KHR(VkPhysicalDeviceMemoryProperties2* pMemoryProperties) { return Api.vkGetPhysicalDeviceMemoryProperties2KHR(this, VkPhysicalDeviceMemoryProperties2 * pMemoryProperties); }
    //    public void GetSparseImageFormatProperties2KHR(ref VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, uint* pPropertyCount, VkSparseImageFormatProperties2* pProperties) { return Api.vkGetPhysicalDeviceSparseImageFormatProperties2KHR(this, ref VkPhysicalDeviceSparseImageFormatInfo2 pFormatInfo, uint * pPropertyCount, VkSparseImageFormatProperties2 * pProperties); }
    //    public void GetExternalBufferPropertiesKHR(ref VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, VkExternalBufferProperties* pExternalBufferProperties) { return Api.vkGetPhysicalDeviceExternalBufferPropertiesKHR(this, ref VkPhysicalDeviceExternalBufferInfo pExternalBufferInfo, VkExternalBufferProperties * pExternalBufferProperties); }
    //    public void GetExternalSemaphorePropertiesKHR(ref VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, VkExternalSemaphoreProperties* pExternalSemaphoreProperties) { return Api.vkGetPhysicalDeviceExternalSemaphorePropertiesKHR(this, ref VkPhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, VkExternalSemaphoreProperties * pExternalSemaphoreProperties); }
    //    public void GetExternalFencePropertiesKHR(ref VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, VkExternalFenceProperties* pExternalFenceProperties) { return Api.vkGetPhysicalDeviceExternalFencePropertiesKHR(this, ref VkPhysicalDeviceExternalFenceInfo pExternalFenceInfo, VkExternalFenceProperties * pExternalFenceProperties); }
    //    public VkResult vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(uint queueFamilyIndex, uint* pCounterCount, VkPerformanceCounterKHR* pCounters, VkPerformanceCounterDescriptionKHR* pCounterDescriptions) { return Api.vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR(this, uint queueFamilyIndex, uint * pCounterCount, VkPerformanceCounterKHR * pCounters, VkPerformanceCounterDescriptionKHR * pCounterDescriptions); }
    //    public void GetQueueFamilyPerformanceQueryPassesKHR(ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, uint* pNumPasses) { return Api.vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR(this, ref VkQueryPoolPerformanceCreateInfoKHR pPerformanceQueryCreateInfo, uint * pNumPasses); }
    //    public VkResult GetSurfaceCapabilities2KHR(ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkSurfaceCapabilities2KHR* pSurfaceCapabilities) { return Api.vkGetPhysicalDeviceSurfaceCapabilities2KHR(this, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, VkSurfaceCapabilities2KHR * pSurfaceCapabilities); }
    //    public VkResult GetSurfaceFormats2KHR(ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint* pSurfaceFormatCount, VkSurfaceFormat2KHR* pSurfaceFormats) { return Api.vkGetPhysicalDeviceSurfaceFormats2KHR(this, ref VkPhysicalDeviceSurfaceInfo2KHR pSurfaceInfo, uint * pSurfaceFormatCount, VkSurfaceFormat2KHR * pSurfaceFormats); }
    //    public VkResult GetDisplayProperties2KHR(uint* pPropertyCount, ref VkDisplayProperties2KHR pProperties) { return Api.vkGetPhysicalDeviceDisplayProperties2KHR(this, uint * pPropertyCount, ref VkDisplayProperties2KHR pProperties); }
    //    public VkResult GetDisplayPlaneProperties2KHR(uint* pPropertyCount, ref VkDisplayPlaneProperties2KHR pProperties) { return Api.vkGetPhysicalDeviceDisplayPlaneProperties2KHR(this, uint * pPropertyCount, ref VkDisplayPlaneProperties2KHR pProperties); }
    //    public VkResult vkGetDisplayModeProperties2KHR(VkDisplayKHR display, uint* pPropertyCount, ref VkDisplayModeProperties2KHR pProperties) { return Api.vkGetDisplayModeProperties2KHR(this, VkDisplayKHR display, uint * pPropertyCount, ref VkDisplayModeProperties2KHR pProperties); }
    //    public VkResult vkGetDisplayPlaneCapabilities2KHR(ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR* pCapabilities) { return Api.vkGetDisplayPlaneCapabilities2KHR(this, ref VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, VkDisplayPlaneCapabilities2KHR * pCapabilities); }
    //    public VkResult GetFragmentShadingRatesKHR(uint* pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates) { return Api.vkGetPhysicalDeviceFragmentShadingRatesKHR(this, uint * pFragmentShadingRateCount, VkPhysicalDeviceFragmentShadingRateKHR * pFragmentShadingRates); }
    //    public VkResult GetExternalImageFormatPropertiesNV(VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, VkExternalImageFormatPropertiesNV* pExternalImageFormatProperties) { return Api.vkGetPhysicalDeviceExternalImageFormatPropertiesNV(this, VkFormat format, VkImageType type, VkImageTiling tiling, uint usage, uint flags, uint externalHandleType, VkExternalImageFormatPropertiesNV * pExternalImageFormatProperties); }
    //    public VkResult vkReleaseDisplayEXT(VkDisplayKHR display) { return Api.vkReleaseDisplayEXT(this, VkDisplayKHR display); }
    //    public VkResult GetSurfaceCapabilities2EXT(VkSurfaceKHR surface, VkSurfaceCapabilities2EXT* pSurfaceCapabilities) { return Api.vkGetPhysicalDeviceSurfaceCapabilities2EXT(this, VkSurfaceKHR surface, VkSurfaceCapabilities2EXT * pSurfaceCapabilities); }
    //    public void GetMultisamplePropertiesEXT(VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT* pMultisampleProperties) { return Api.vkGetPhysicalDeviceMultisamplePropertiesEXT(this, VkSampleCountFlagBits samples, VkMultisamplePropertiesEXT * pMultisampleProperties); }
    //    public VkResult GetCalibrateableTimeDomainsEXT(uint* pTimeDomainCount, VkTimeDomainEXT* pTimeDomains) { return Api.vkGetPhysicalDeviceCalibrateableTimeDomainsEXT(this, uint * pTimeDomainCount, VkTimeDomainEXT * pTimeDomains); }
    //    public VkResult GetToolPropertiesEXT(uint* pToolCount, ref VkPhysicalDeviceToolPropertiesEXT pToolProperties) { return Api.vkGetPhysicalDeviceToolPropertiesEXT(this, uint * pToolCount, ref VkPhysicalDeviceToolPropertiesEXT pToolProperties); }
    //    public VkResult GetCooperativeMatrixPropertiesNV(uint* pPropertyCount, ref VkCooperativeMatrixPropertiesNV pProperties) { return Api.vkGetPhysicalDeviceCooperativeMatrixPropertiesNV(this, uint * pPropertyCount, ref VkCooperativeMatrixPropertiesNV pProperties); }
    //    public VkResult GetSupportedFramebufferMixedSamplesCombinationsNV(uint* pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations) { return Api.vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(this, uint * pCombinationCount, VkFramebufferMixedSamplesCombinationNV * pCombinations); }
    //    public VkResult vkAcquireDrmDisplayEXT(int drmFd, VkDisplayKHR display) { return Api.vkAcquireDrmDisplayEXT(this, int drmFd, VkDisplayKHR display); }
    //    public VkResult vkGetDrmDisplayEXT(int drmFd, uint connectorId, VkDisplayKHR* display) { return Api.vkGetDrmDisplayEXT(this, int drmFd, uint connectorId, VkDisplayKHR * display); }
    //    public VkResult vkAcquireWinrtDisplayNV(VkDisplayKHR display) { return Api.vkAcquireWinrtDisplayNV(this, VkDisplayKHR display); }
    //    public VkResult vkGetWinrtDisplayNV(uint deviceRelativeId, VkDisplayKHR* pDisplay) { return Api.vkGetWinrtDisplayNV(this, uint deviceRelativeId, VkDisplayKHR * pDisplay); }

    //}



}
