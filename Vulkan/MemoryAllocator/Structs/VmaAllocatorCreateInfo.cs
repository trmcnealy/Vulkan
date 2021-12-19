using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// Description of a Allocator to be created.
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaAllocatorCreateInfo
{
    /// <summary>
    /// Flags for created allocator. Use #VmaAllocatorCreateFlagBits enum.
    /// </summary>
    public uint flags;

    /// <summary>
    /// Vulkan physical device.
    /// It must be valid throughout whole lifetime of created allocator.
    /// </summary>
    public VkPhysicalDevice physicalDevice;

    /// <summary>
    /// Vulkan device.
    /// It must be valid throughout whole lifetime of created allocator.
    /// </summary>
    public VkDevice device;

    /// <summary>
    /// Preferred size of a single `VkDeviceMemory` block to be allocated from large heaps &gt; 1 GiB. Optional.
    /// Set to 0 to use default, which is currently 256 MiB.
    /// </summary>
    public ulong preferredLargeHeapBlockSize;

    /// <summary>
    /// Custom CPU memory allocation callbacks. Optional.
    /// Optional, can be null. When specified, will also be used for all CPU-side memory allocations.
    /// </summary>
    public nint pAllocationCallbacks;

    /// <summary>
    /// Informative callbacks for `vkAllocateMemory`, `vkFreeMemory`. Optional.
    /// Optional, can be null.
    /// </summary>
    public nint pDeviceMemoryCallbacks;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Maximum number of additional frames that are in use at the same time as current frame.This value is used only when you make allocations with
    /// VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT flag. Such allocation cannot become
    /// lost if allocation.lastUseFrameIndex &gt;= allocator.currentFrameIndex - frameInUseCount.For example, if you double-buffer your command buffers, so resources used for
    /// rendering in previous frame may still be in use by the GPU at the moment you
    /// allocate resources needed for the current frame, set this value to 1.If you want to allow any allocations other than used in the current frame to
    /// become lost, set this value to 0.
    /// </remarks>
    public uint frameInUseCount;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Either null or a pointer to an array of limits on maximum number of bytes that can be allocated out of particular Vulkan memory heap.If not NULL, it must be a pointer to an array of
    /// `VkPhysicalDeviceMemoryProperties::memoryHeapCount` elements, defining limit on
    /// maximum number of bytes that can be allocated out of particular Vulkan memory
    /// heap.Any of the elements may be equal to `VK_WHOLE_SIZE`, which means no limit on that
    /// heap. This is also the default in case of `pHeapSizeLimit` = NULL.If there is a limit defined for a heap:- If user tries to allocate more memory from that heap using this allocator,
    /// the allocation fails with `VK_ERROR_OUT_OF_DEVICE_MEMORY`.
    /// - If the limit is smaller than heap size reported in `VkMemoryHeap::size`, the
    /// value of this limit will be reported instead when using vmaGetMemoryProperties().Warning! Using this feature may not be equivalent to installing a GPU with
    /// smaller amount of memory, because graphics driver doesn't necessary fail new
    /// allocations with `VK_ERROR_OUT_OF_DEVICE_MEMORY` result when memory capacity is
    /// exceeded. It may return success and just silently migrate some device memory
    /// blocks to system RAM. This driver behavior can also be controlled using
    /// VK_AMD_memory_overallocation_behavior extension.
    /// </remarks>
    public nint pHeapSizeLimit;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Pointers to Vulkan functions. Can be null.For details see [Pointers to Vulkan functions](@ref config_Vulkan_functions).
    /// </remarks>
    public nint pVulkanFunctions;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Parameters for recording of VMA calls. Can be null.If not null, it enables recording of calls to VMA functions to a file.
    /// If support for recording is not enabled using `VMA_RECORDING_ENABLED` macro,
    /// creation of the allocator object fails with `VK_ERROR_FEATURE_NOT_PRESENT`.
    /// </remarks>
    public nint pRecordSettings;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Handle to Vulkan instance object.Starting from version 3.0.0 this member is no longer optional, it must be set!
    /// </remarks>
    public VkInstance instance;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Optional. The highest version of Vulkan that the application is designed to use.It must be a value in the format as created by macro `VK_MAKE_VERSION` or a constant like: `VK_API_VERSION_1_1`, `VK_API_VERSION_1_0`.
    /// The patch version number specified is ignored. Only the major and minor versions are considered.
    /// It must be less or equal (preferably equal) to value as passed to `vkCreateInstance` as `VkApplicationInfo::apiVersion`.
    /// Only versions 1.0, 1.1, 1.2 are supported by the current implementation.
    /// Leaving it initialized to zero is equivalent to `VK_API_VERSION_1_0`.
    /// </remarks>
    public uint vulkanApiVersion;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Either null or a pointer to an array of external memory handle types for each Vulkan memory type.If not NULL, it must be a pointer to an array of `VkPhysicalDeviceMemoryProperties::memoryTypeCount`
    /// elements, defining external memory handle types of particular Vulkan memory type,
    /// to be passed using `VkExportMemoryAllocateInfoKHR`.Any of the elements may be equal to 0, which means not to use `VkExportMemoryAllocateInfoKHR` on this memory type.
    /// This is also the default in case of `pTypeExternalMemoryHandleTypes` = NULL.
    /// </remarks>
    public nint pTypeExternalMemoryHandleTypes;
}