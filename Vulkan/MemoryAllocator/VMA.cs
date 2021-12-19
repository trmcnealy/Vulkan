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

namespace Vulkan.MemoryAllocator
{
    public static partial class Api
    {
        public static readonly string DLL_NAME;
        public static readonly nint   Handle;

        #region RVAs v

        //public static readonly nint vkAcquireNextImage2KHROffset                          = 0x00008410;

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static unsafe Api()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libVulkanMemoryAllocator.so.1";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libVulkanMemoryAllocator.0.0.dylib";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "VulkanMemoryAllocator.dll";
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "VulkanMemoryAllocator";
            }
            else
            {
                DLL_NAME = "VulkanMemoryAllocator";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);
#if LOAD_FROM_DEVICEPROCADDR
            #region LOAD_FROM_DEVICEPROCADDR
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset); //NativeLibrary.GetExport(Handle, "vkGetInstanceProcAddr");
            
            #endregion
#elif LOAD_FROM_RVA
            #region LOAD_FROM_RVA
            GetInstanceProcAddr = (delegate*<VkInstance, utf8string, nint>)(Handle + vkGetInstanceProcAddrOffset);
            
            #endregion
#elif true // LOAD_FROM_GETEXPORT

            #region LOAD_FROM_GETEXPORT

            CreateAllocator = (delegate* <in VmaAllocatorCreateInfo, ref VmaAllocator, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                           "vmaCreateAllocator");
            DestroyAllocator = (delegate* <VmaAllocator, void>)NativeLibrary.GetExport(Handle,
                                                                                         "vmaDestroyAllocator");
            GetAllocatorInfo = (delegate* <VmaAllocator, ref VmaAllocatorInfo, void>)NativeLibrary.GetExport(Handle,
                                                                                                               "vmaGetAllocatorInfo");
            GetPhysicalDeviceProperties = (delegate* <VmaAllocator, out nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                              "vmaGetPhysicalDeviceProperties");
            GetMemoryProperties = (delegate* <VmaAllocator, out nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                      "vmaGetMemoryProperties");
            GetMemoryTypeProperties = (delegate* <VmaAllocator, uint, ref uint, void>)NativeLibrary.GetExport(Handle,
                                                                                                                "vmaGetMemoryTypeProperties");
            SetCurrentFrameIndex = (delegate* <VmaAllocator, uint, void>)NativeLibrary.GetExport(Handle,
                                                                                                   "vmaSetCurrentFrameIndex");
            CalculateStats = (delegate* <VmaAllocator, ref VmaStats, void>)NativeLibrary.GetExport(Handle,
                                                                                                     "vmaCalculateStats");
            GetBudget = (delegate* <VmaAllocator, ref VmaBudget, void>)NativeLibrary.GetExport(Handle,
                                                                                                 "vmaGetBudget");
            BuildStatsString = (delegate* <VmaAllocator, out nint, uint, void>)NativeLibrary.GetExport(Handle,
                                                                                                         "vmaBuildStatsString");
            FreeStatsString = (delegate* <VmaAllocator, nint, void>)NativeLibrary.GetExport(Handle,
                                                                                              "vmaFreeStatsString");
            FindMemoryTypeIndex = (delegate* <VmaAllocator, uint, in VmaAllocationCreateInfo, ref uint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                            "vmaFindMemoryTypeIndex");
            FindMemoryTypeIndexForBufferInfo = (delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ref uint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                          "vmaFindMemoryTypeIndexForBufferInfo");
            FindMemoryTypeIndexForImageInfo = (delegate* <VmaAllocator, in VkImageCreateInfo, in VmaAllocationCreateInfo, ref uint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                        "vmaFindMemoryTypeIndexForImageInfo");
            CreatePool = (delegate* <VmaAllocator, in VmaPoolCreateInfo, ref VmaPool, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                            "vmaCreatePool");
            DestroyPool = (delegate* <VmaAllocator, VmaPool, void>)NativeLibrary.GetExport(Handle,
                                                                                               "vmaDestroyPool");
            GetPoolStats = (delegate* <VmaAllocator, VmaPool, ref VmaPoolStats, void>)NativeLibrary.GetExport(Handle,
                                                                                                                  "vmaGetPoolStats");
            MakePoolAllocationsLost = (delegate* <VmaAllocator, VmaPool, ref ulong, void>)NativeLibrary.GetExport(Handle,
                                                                                                                      "vmaMakePoolAllocationsLost");
            CheckPoolCorruption = (delegate* <VmaAllocator, VmaPool, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                           "vmaCheckPoolCorruption");
            GetPoolName = (delegate* <VmaAllocator, VmaPool, out nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                         "vmaGetPoolName");
            SetPoolName = (delegate* <VmaAllocator, VmaPool, nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                     "vmaSetPoolName");
            AllocateMemory = (delegate* <VmaAllocator, in VkMemoryRequirements, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                            "vmaAllocateMemory");
            AllocateMemoryPages = (delegate* <VmaAllocator, in VkMemoryRequirements, in VmaAllocationCreateInfo, ulong, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                                        "vmaAllocateMemoryPages");
            AllocateMemoryForBuffer = (delegate* <VmaAllocator, VkBuffer, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                        "vmaAllocateMemoryForBuffer");
            AllocateMemoryForImage = (delegate* <VmaAllocator, VkImage, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                      "vmaAllocateMemoryForImage");
            FreeMemory = (delegate* <VmaAllocator, VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                    "vmaFreeMemory");
            FreeMemoryPages = (delegate* <VmaAllocator, ulong, ref VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                                    "vmaFreeMemoryPages");
            GetAllocationInfo = (delegate* <VmaAllocator, VmaAllocation, ref VmaAllocationInfo, void>)NativeLibrary.GetExport(Handle,
                                                                                                                                  "vmaGetAllocationInfo");
            TouchAllocation = (delegate* <VmaAllocator, VmaAllocation, uint>)NativeLibrary.GetExport(Handle,
                                                                                                         "vmaTouchAllocation");
            SetAllocationUserData = (delegate* <VmaAllocator, VmaAllocation, nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                                     "vmaSetAllocationUserData");
            CreateLostAllocation = (delegate* <VmaAllocator, ref VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                                  "vmaCreateLostAllocation");
            GetAllocationMemoryProperties = (delegate* <VmaAllocator, VmaAllocation, ref uint, void>)NativeLibrary.GetExport(Handle,
                                                                                                                                 "vmaGetAllocationMemoryProperties");
            MapMemory = (delegate* <VmaAllocator, VmaAllocation, out nint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                 "vmaMapMemory");
            UnmapMemory = (delegate* <VmaAllocator, VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                     "vmaUnmapMemory");
            FlushAllocation = (delegate* <VmaAllocator, VmaAllocation, ulong, ulong, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                           "vmaFlushAllocation");
            InvalidateAllocation = (delegate* <VmaAllocator, VmaAllocation, ulong, ulong, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                "vmaInvalidateAllocation");
            FlushAllocations = (delegate* <VmaAllocator, uint, ref VmaAllocation, ref ulong, ref ulong, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                              "vmaFlushAllocations");
            InvalidateAllocations = (delegate* <VmaAllocator, uint, ref VmaAllocation, ref ulong, ref ulong, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                   "vmaInvalidateAllocations");
            CheckCorruption = (delegate* <VmaAllocator, uint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                  "vmaCheckCorruption");
            DefragmentationBegin = (delegate* <VmaAllocator, in VmaDefragmentationInfo2, ref VmaDefragmentationStats, ref VmaDefragmentationContext, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                           "vmaDefragmentationBegin");
            DefragmentationEnd = (delegate* <VmaAllocator, VmaDefragmentationContext, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                            "vmaDefragmentationEnd");
            BeginDefragmentationPass = (delegate* <VmaAllocator, VmaDefragmentationContext, ref VmaDefragmentationPassInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                  "vmaBeginDefragmentationPass");
            EndDefragmentationPass = (delegate* <VmaAllocator, VmaDefragmentationContext, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                "vmaEndDefragmentationPass");
            Defragment = (delegate* <VmaAllocator, ref VmaAllocation, ulong, ref uint, in VmaDefragmentationInfo, ref VmaDefragmentationStats, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                     "vmaDefragment");
            BindBufferMemory = (delegate* <VmaAllocator, VmaAllocation, VkBuffer, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                          "vmaBindBufferMemory");
            BindBufferMemory2 = (delegate* <VmaAllocator, VmaAllocation, ulong, VkBuffer, nint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                        "vmaBindBufferMemory2");
            BindImageMemory = (delegate* <VmaAllocator, VmaAllocation, VkImage, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                        "vmaBindImageMemory");
            BindImageMemory2 = (delegate* <VmaAllocator, VmaAllocation, ulong, VkImage, nint, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                      "vmaBindImageMemory2");
            CreateBuffer = (delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ref VkBuffer, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                                        "vmaCreateBuffer");
            CreateBufferWithAlignment = (delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ulong, ref VkBuffer, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                                                            "vmaCreateBufferWithAlignment");
            DestroyBuffer = (delegate* <VmaAllocator, VkBuffer, VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                                   "vmaDestroyBuffer");
            CreateImage = (delegate* <VmaAllocator, in VkImageCreateInfo, in VmaAllocationCreateInfo, ref VkImage, ref VmaAllocation, ref VmaAllocationInfo, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                                                                                     "vmaCreateImage");
            DestroyImage = (delegate* <VmaAllocator, VkImage, VmaAllocation, void>)NativeLibrary.GetExport(Handle,
                                                                                                                 "vmaDestroyImage");
            CreateVirtualBlock = (delegate* <in VmaVirtualBlockCreateInfo, ref VmaVirtualBlock, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                    "vmaCreateVirtualBlock");
            DestroyVirtualBlock = (delegate* <VmaVirtualBlock, void>)NativeLibrary.GetExport(Handle,
                                                                                               "vmaDestroyVirtualBlock");
            IsVirtualBlockEmpty = (delegate* <VmaVirtualBlock, uint>)NativeLibrary.GetExport(Handle,
                                                                                               "vmaIsVirtualBlockEmpty");
            GetVirtualAllocationInfo = (delegate* <VmaVirtualBlock, ulong, ref VmaVirtualAllocationInfo, void>)NativeLibrary.GetExport(Handle,
                                                                                                                                         "vmaGetVirtualAllocationInfo");
            VirtualAllocate = (delegate* <VmaVirtualBlock, in VmaVirtualAllocationCreateInfo, ref ulong, VkResult>)NativeLibrary.GetExport(Handle,
                                                                                                                                             "vmaVirtualAllocate");
            VirtualFree = (delegate* <VmaVirtualBlock, ulong, void>)NativeLibrary.GetExport(Handle,
                                                                                              "vmaVirtualFree");
            ClearVirtualBlock = (delegate* <VmaVirtualBlock, void>)NativeLibrary.GetExport(Handle,
                                                                                             "vmaClearVirtualBlock");
            SetVirtualAllocationUserData = (delegate* <VmaVirtualBlock, ulong, nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                                     "vmaSetVirtualAllocationUserData");
            CalculateVirtualBlockStats = (delegate* <VmaVirtualBlock, ref VmaStatInfo, void>)NativeLibrary.GetExport(Handle,
                                                                                                                       "vmaCalculateVirtualBlockStats");
            BuildVirtualBlockStatsString = (delegate* <VmaVirtualBlock, out nint, uint, void>)NativeLibrary.GetExport(Handle,
                                                                                                                        "vmaBuildVirtualBlockStatsString");
            FreeVirtualBlockStatsString = (delegate* <VmaVirtualBlock, nint, void>)NativeLibrary.GetExport(Handle,
                                                                                                             "vmaFreeVirtualBlockStatsString");

            #endregion

#endif
        }
    }
}
