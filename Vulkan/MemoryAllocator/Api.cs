using System;
using System.Diagnostics.CodeAnalysis;

namespace Vulkan.MemoryAllocator
{
    [SuppressMessage("ReSharper",
                     "InconsistentNaming")]
    public static partial class Api
    {
        /// <summary>
        /// Creates Allocator object.
        /// </summary>
        public static unsafe delegate* <in VmaAllocatorCreateInfo, ref VmaAllocator, VkResult> CreateAllocator;

        /// <summary>
        /// Destroys allocator object.
        /// </summary>
        public static unsafe delegate* <VmaAllocator, void> DestroyAllocator;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Returns information about existing #VmaAllocator object - handle to Vulkan device etc.It might be useful if you want to keep just the #VmaAllocator handle and fetch other required handles to
        /// `VkPhysicalDevice`, `VkDevice` etc. every time using this function.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ref VmaAllocatorInfo, void> GetAllocatorInfo;

        /// <summary>
        /// PhysicalDeviceProperties are fetched from physicalDevice by the allocator.
        /// You can access it here, without fetching it again on your own.
        /// </summary>
        public static unsafe delegate* <VmaAllocator, out nint, void> GetPhysicalDeviceProperties;

        /// <summary>
        /// PhysicalDeviceMemoryProperties are fetched from physicalDevice by the allocator.
        /// You can access it here, without fetching it again on your own.
        /// </summary>
        public static unsafe delegate* <VmaAllocator, out nint, void> GetMemoryProperties;

        /// <summary>
        /// @brief Given Memory Type Index, returns Property Flags of this memory type.
        /// </summary>
        /// <remarks>
        /// This is just a convenience function. Same information can be obtained using
        /// vmaGetMemoryProperties().
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, ref uint, void> GetMemoryTypeProperties;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Sets index of the current frame.This function must be used if you make allocations with
        /// #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT and
        /// #VMA_ALLOCATION_CREATE_CAN_MAKE_OTHER_LOST_BIT flags to inform the allocator
        /// when a new frame begins. Allocations queried using vmaGetAllocationInfo() cannot
        /// become lost in the current frame.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, void> SetCurrentFrameIndex;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Retrieves statistics from current state of the Allocator.This function is called "calculate" not "get" because it has to traverse all
        /// internal data structures, so it may be quite slow. For faster but more brief statistics
        /// suitable to be called every frame or every allocation, use vmaGetBudget().Note that when using allocator from multiple threads, returned information may immediately
        /// become outdated.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ref VmaStats, void> CalculateStats;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="pBudget">Must point to array with number of elements at least equal to number of memory heaps in physical device used.</param>
        /// <remarks>
        /// @brief Retrieves information about current memory budget for all memory heaps.This function is called "get" not "calculate" because it is very fast, suitable to be called
        /// every frame or every allocation. For more detailed statistics use vmaCalculateStats().Note that when using allocator from multiple threads, returned information may immediately
        /// become outdated.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ref VmaBudget, void> GetBudget;

        /// <summary>
        /// Builds and returns statistics as a null-terminated string in JSON format.
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="ppStatsString">Must be freed using vmaFreeStatsString() function.</param>
        /// <param name="detailedMap"></param>
        public static unsafe delegate* <VmaAllocator, out nint, uint, void> BuildStatsString;

        public static unsafe delegate* <VmaAllocator, nint, void> FreeStatsString;

        /// <summary>
        /// @brief Helps to find memoryTypeIndex, given memoryTypeBits and VmaAllocationCreateInfo.
        /// </summary>
        /// <returns>Returns VK_ERROR_FEATURE_NOT_PRESENT if not found. Receiving such result
        /// from this function or any other allocating function probably means that your
        /// device doesn't support any memory type with requested features for the specific
        /// type of resource you want to use it for. Please check parameters of your
        /// resource, like image layout (OPTIMAL versus LINEAR) or mip level count.</returns>
        /// <remarks>
        /// This algorithm tries to find a memory type that:- Is allowed by memoryTypeBits.
        /// - Contains all the flags from pAllocationCreateInfo-&gt;requiredFlags.
        /// - Matches intended usage.
        /// - Has as many flags from pAllocationCreateInfo-&gt;preferredFlags as possible.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, in VmaAllocationCreateInfo, ref uint, VkResult> FindMemoryTypeIndex;

        /// <summary>
        /// @brief Helps to find memoryTypeIndex, given VkBufferCreateInfo and VmaAllocationCreateInfo.
        /// </summary>
        /// <remarks>
        /// It can be useful e.g. to determine value to be used as VmaPoolCreateInfo::memoryTypeIndex.
        /// It internally creates a temporary, dummy buffer that never has memory bound.
        /// It is just a convenience function, equivalent to calling:- `vkCreateBuffer`
        /// - `vkGetBufferMemoryRequirements`
        /// - `vmaFindMemoryTypeIndex`
        /// - `vkDestroyBuffer`
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ref uint, VkResult> FindMemoryTypeIndexForBufferInfo;

        /// <summary>
        /// @brief Helps to find memoryTypeIndex, given VkImageCreateInfo and VmaAllocationCreateInfo.
        /// </summary>
        /// <remarks>
        /// It can be useful e.g. to determine value to be used as VmaPoolCreateInfo::memoryTypeIndex.
        /// It internally creates a temporary, dummy image that never has memory bound.
        /// It is just a convenience function, equivalent to calling:- `vkCreateImage`
        /// - `vkGetImageMemoryRequirements`
        /// - `vmaFindMemoryTypeIndex`
        /// - `vkDestroyImage`
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkImageCreateInfo, in VmaAllocationCreateInfo, ref uint, VkResult> FindMemoryTypeIndexForImageInfo;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">Allocator object.</param>
        /// <param name="pCreateInfo">Parameters of pool to create.</param>
        /// <param name="pPool">Handle to created pool.</param>
        /// <remarks>
        /// @brief Allocates Vulkan device memory and creates #VmaPool object.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VmaPoolCreateInfo, ref VmaPool, VkResult> CreatePool;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Destroys #VmaPool object and frees Vulkan device memory.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, void> DestroyPool;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">Allocator object.</param>
        /// <param name="pool">Pool object.</param>
        /// <param name="pPoolStats">Statistics of specified pool.</param>
        /// <remarks>
        /// @brief Retrieves statistics of existing #VmaPool object.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, ref VmaPoolStats, void> GetPoolStats;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">Allocator object.</param>
        /// <param name="pool">Pool.</param>
        /// <param name="pLostAllocationCount">Number of allocations marked as lost. Optional - pass null if you don't need this information.</param>
        /// <remarks>
        /// @brief Marks all allocations in given pool as lost if they are not used in current frame or VmaPoolCreateInfo::frameInUseCount back from now.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, ref ulong, void> MakePoolAllocationsLost;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Checks magic number in margins around all allocations in given memory pool in search for corruptions.Corruption detection is enabled only when `VMA_DEBUG_DETECT_CORRUPTION` macro is defined to nonzero,
        /// `VMA_DEBUG_MARGIN` is defined to nonzero and the pool is created in memory type that is
        /// `HOST_VISIBLE` and `HOST_COHERENT`. For more information, see [Corruption detection](@ref debugging_memory_usage_corruption_detection).Possible return values:- `VK_ERROR_FEATURE_NOT_PRESENT` - corruption detection is not enabled for specified pool.
        /// - `VK_SUCCESS` - corruption detection has been performed and succeeded.
        /// - `VK_ERROR_UNKNOWN` - corruption detection has been performed and found memory corruptions around one of the allocations.
        /// `VMA_ASSERT` is also fired in that case.
        /// - Other value: Error returned by Vulkan, e.g. memory mapping failure.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, VkResult> CheckPoolCorruption;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Retrieves name of a custom pool.After the call `ppName` is either null or points to an internally-owned null-terminated string
        /// containing name of the pool that was previously set. The pointer becomes invalid when the pool is
        /// destroyed or its name is changed using vmaSetPoolName().
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, out nint, void> GetPoolName;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Sets name of a custom pool.`pName` can be either null or pointer to a null-terminated string with new name for the pool.
        /// Function makes internal copy of the string, so it can be changed or freed immediately after this call.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaPool, nint, void> SetPoolName;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="pVkMemoryRequirements"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pAllocation">Handle to allocated memory.</param>
        /// <param name="pAllocationInfo">Optional. Information about allocated memory. It can be later fetched using function vmaGetAllocationInfo().</param>
        /// <remarks>
        /// @brief General purpose memory allocation.You should free the memory using vmaFreeMemory() or vmaFreeMemoryPages().It is recommended to use vmaAllocateMemoryForBuffer(), vmaAllocateMemoryForImage(),
        /// vmaCreateBuffer(), vmaCreateImage() instead whenever possible.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkMemoryRequirements, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult> AllocateMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">Allocator object.</param>
        /// <param name="pVkMemoryRequirements">Memory requirements for each allocation.</param>
        /// <param name="pCreateInfo">Creation parameters for each alloction.</param>
        /// <param name="allocationCount">Number of allocations to make.</param>
        /// <param name="pAllocations">Pointer to array that will be filled with handles to created allocations.</param>
        /// <param name="pAllocationInfo">Optional. Pointer to array that will be filled with parameters of created allocations.</param>
        /// <remarks>
        /// @brief General purpose memory allocation for multiple allocation objects at once.You should free the memory using vmaFreeMemory() or vmaFreeMemoryPages().Word "pages" is just a suggestion to use this function to allocate pieces of memory needed for sparse binding.
        /// It is just a general purpose allocation function able to make multiple allocations at once.
        /// It may be internally optimized to be more efficient than calling vmaAllocateMemory() `allocationCount` times.All allocations are made using same parameters. All of them are created out of the same memory pool and type.
        /// If any allocation fails, all allocations already made within this function call are also freed, so that when
        /// returned result is not `VK_SUCCESS`, `pAllocation` array is always entirely filled with `VK_NULL_HANDLE`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkMemoryRequirements, in VmaAllocationCreateInfo, ulong, ref VmaAllocation, ref VmaAllocationInfo, VkResult> AllocateMemoryPages;

        /// <summary>
        /// @param allocator
        /// </summary>
        /// <param name="buffer"></param>
        /// <param name="pCreateInfo"></param>
        /// <param name="pAllocation">Handle to allocated memory.</param>
        /// <param name="pAllocationInfo">Optional. Information about allocated memory. It can be later fetched using function vmaGetAllocationInfo().</param>
        /// <remarks>
        /// You should free the memory using vmaFreeMemory().
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VkBuffer, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult> AllocateMemoryForBuffer;

        /// <summary>
        /// Function similar to vmaAllocateMemoryForBuffer().
        /// </summary>
        public static unsafe delegate* <VmaAllocator, VkImage, in VmaAllocationCreateInfo, ref VmaAllocation, ref VmaAllocationInfo, VkResult> AllocateMemoryForImage;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Frees memory previously allocated using vmaAllocateMemory(), vmaAllocateMemoryForBuffer(), or vmaAllocateMemoryForImage().Passing `VK_NULL_HANDLE` as `allocation` is valid. Such function call is just skipped.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, void> FreeMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Frees memory and destroys multiple allocations.Word "pages" is just a suggestion to use this function to free pieces of memory used for sparse binding.
        /// It is just a general purpose function to free memory and destroy allocations made using e.g. vmaAllocateMemory(),
        /// vmaAllocateMemoryPages() and other functions.
        /// It may be internally optimized to be more efficient than calling vmaFreeMemory() `allocationCount` times.Allocations in `pAllocations` array can come from any memory pools and types.
        /// Passing `VK_NULL_HANDLE` as elements of `pAllocations` array is valid. Such entries are just skipped.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ulong, ref VmaAllocation, void> FreeMemoryPages;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Returns current information about specified allocation and atomically marks it as used in current frame.Current paramteres of given allocation are returned in `pAllocationInfo`.This function also atomically "touches" allocation - marks it as used in current frame,
        /// just like vmaTouchAllocation().
        /// If the allocation is in lost state, `pAllocationInfo-&gt;deviceMemory == VK_NULL_HANDLE`.Although this function uses atomics and doesn't lock any mutex, so it should be quite efficient,
        /// you can avoid calling it too often.- You can retrieve same VmaAllocationInfo structure while creating your resource, from function
        /// vmaCreateBuffer(), vmaCreateImage(). You can remember it if you are sure parameters don't change
        /// (e.g. due to defragmentation or allocation becoming lost).
        /// - If you just want to check if allocation is not lost, vmaTouchAllocation() will work faster.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ref VmaAllocationInfo, void> GetAllocationInfo;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Returns `VKRUE` if allocation is not lost and atomically marks it as used in current frame.If the allocation has been created with #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT flag,
        /// this function returns `VKRUE` if it is not in lost state, so it can still be used.
        /// It then also atomically "touches" the allocation - marks it as used in current frame,
        /// so that you can be sure it won't become lost in current frame or next `frameInUseCount` frames.If the allocation is in lost state, the function returns `VK_FALSE`.
        /// Memory of such allocation, as well as buffer or image bound to it, should not be used.
        /// Lost allocation and the buffer/image still need to be destroyed.If the allocation has been created without #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT flag,
        /// this function always returns `VKRUE`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, uint> TouchAllocation;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Sets pUserData in given allocation to new value.If the allocation was created with VMA_ALLOCATION_CREATE_USER_DATA_COPY_STRING_BIT,
        /// pUserData must be either null, or pointer to a null-terminated string. The function
        /// makes local copy of the string and sets it as allocation's `pUserData`. String
        /// passed as pUserData doesn't need to be valid for whole lifetime of the allocation -
        /// you can free it after this call. String previously pointed by allocation's
        /// pUserData is freed from memory.If the flag was not used, the value of pointer `pUserData` is just copied to
        /// allocation's `pUserData`. It is opaque, so you can use it however you want - e.g.
        /// as a pointer, ordinal number or some handle to you own data.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, nint, void> SetAllocationUserData;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Creates new allocation that is in lost state from the beginning.It can be useful if you need a dummy, non-null allocation.You still need to destroy created object using vmaFreeMemory().Returned allocation is not tied to any specific memory pool or memory type and
        /// not bound to any image or buffer. It has size = 0. It cannot be turned into
        /// a real, non-empty allocation.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ref VmaAllocation, void> CreateLostAllocation;

        /// <summary>
        /// @brief Given an allocation, returns Property Flags of its memory type.
        /// </summary>
        /// <remarks>
        /// This is just a convenience function. Same information can be obtained using
        /// vmaGetAllocationInfo() + vmaGetMemoryProperties().
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ref uint, void> GetAllocationMemoryProperties;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Maps memory represented by given allocation and returns pointer to it.Maps memory represented by given allocation to make it accessible to CPU code.
        /// When succeeded, `*ppData` contains pointer to first byte of this memory.
        /// If the allocation is part of bigger `VkDeviceMemory` block, the pointer is
        /// correctly offsetted to the beginning of region assigned to this particular
        /// allocation.Mapping is internally reference-counted and synchronized, so despite raw Vulkan
        /// function `vkMapMemory()` cannot be used to map same block of `VkDeviceMemory`
        /// multiple times simultaneously, it is safe to call this function on allocations
        /// assigned to the same memory block. Actual Vulkan memory will be mapped on first
        /// mapping and unmapped on last unmapping.If the function succeeded, you must call vmaUnmapMemory() to unmap the
        /// allocation when mapping is no longer needed or before freeing the allocation, at
        /// the latest.It also safe to call this function multiple times on the same allocation. You
        /// must call vmaUnmapMemory() same number of times as you called vmaMapMemory().It is also safe to call this function on allocation created with
        /// #VMA_ALLOCATION_CREATE_MAPPED_BIT flag. Its memory stays mapped all the time.
        /// You must still call vmaUnmapMemory() same number of times as you called
        /// vmaMapMemory(). You must not call vmaUnmapMemory() additional time to free the
        /// "0-th" mapping made automatically due to #VMA_ALLOCATION_CREATE_MAPPED_BIT flag.This function fails when used on allocation made in memory type that is not
        /// `HOST_VISIBLE`.This function always fails when called for allocation that was created with
        /// #VMA_ALLOCATION_CREATE_CAN_BECOME_LOST_BIT flag. Such allocations cannot be
        /// mapped.This function doesn't automatically flush or invalidate caches.
        /// If the allocation is made from a memory types that is not `HOST_COHERENT`,
        /// you also need to use vmaInvalidateAllocation() / vmaFlushAllocation(), as required by Vulkan specification.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, out nint, VkResult> MapMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Unmaps memory represented by given allocation, mapped previously using vmaMapMemory().For details, see description of vmaMapMemory().This function doesn't automatically flush or invalidate caches.
        /// If the allocation is made from a memory types that is not `HOST_COHERENT`,
        /// you also need to use vmaInvalidateAllocation() / vmaFlushAllocation(), as required by Vulkan specification.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, void> UnmapMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Flushes memory of given allocation.Calls `vkFlushMappedMemoryRanges()` for memory associated with given range of given allocation.
        /// It needs to be called after writing to a mapped memory for memory types that are not `HOST_COHERENT`.
        /// Unmap operation doesn't do that automatically.- `offset` must be relative to the beginning of allocation.
        /// - `size` can be `VK_WHOLE_SIZE`. It means all memory from `offset` the the end of given allocation.
        /// - `offset` and `size` don't have to be aligned.
        /// They are internally rounded down/up to multiply of `nonCoherentAtomSize`.
        /// - If `size` is 0, this call is ignored.
        /// - If memory type that the `allocation` belongs to is not `HOST_VISIBLE` or it is `HOST_COHERENT`,
        /// this call is ignored.Warning! `offset` and `size` are relative to the contents of given `allocation`.
        /// If you mean whole allocation, you can pass 0 and `VK_WHOLE_SIZE`, respectively.
        /// Do not pass allocation's offset as `offset`!!!This function returns the `VkResult` from `vkFlushMappedMemoryRanges` if it is
        /// called, otherwise `VK_SUCCESS`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ulong, ulong, VkResult> FlushAllocation;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Invalidates memory of given allocation.Calls `vkInvalidateMappedMemoryRanges()` for memory associated with given range of given allocation.
        /// It needs to be called before reading from a mapped memory for memory types that are not `HOST_COHERENT`.
        /// Map operation doesn't do that automatically.- `offset` must be relative to the beginning of allocation.
        /// - `size` can be `VK_WHOLE_SIZE`. It means all memory from `offset` the the end of given allocation.
        /// - `offset` and `size` don't have to be aligned.
        /// They are internally rounded down/up to multiply of `nonCoherentAtomSize`.
        /// - If `size` is 0, this call is ignored.
        /// - If memory type that the `allocation` belongs to is not `HOST_VISIBLE` or it is `HOST_COHERENT`,
        /// this call is ignored.Warning! `offset` and `size` are relative to the contents of given `allocation`.
        /// If you mean whole allocation, you can pass 0 and `VK_WHOLE_SIZE`, respectively.
        /// Do not pass allocation's offset as `offset`!!!This function returns the `VkResult` from `vkInvalidateMappedMemoryRanges` if
        /// it is called, otherwise `VK_SUCCESS`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ulong, ulong, VkResult> InvalidateAllocation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="allocationCount"></param>
        /// <param name="allocations"></param>
        /// <param name="offsets">If not null, it must point to an array of offsets of regions to flush, relative to the beginning of respective allocations. Null means all ofsets are zero.</param>
        /// <param name="sizes">If not null, it must point to an array of sizes of regions to flush in respective allocations. Null means `VK_WHOLE_SIZE` for all allocations.</param>
        /// <remarks>
        /// @brief Flushes memory of given set of allocations.Calls `vkFlushMappedMemoryRanges()` for memory associated with given ranges of given allocations.
        /// For more information, see documentation of vmaFlushAllocation().This function returns the `VkResult` from `vkFlushMappedMemoryRanges` if it is
        /// called, otherwise `VK_SUCCESS`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, ref VmaAllocation, ref ulong, ref ulong, VkResult> FlushAllocations;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="allocationCount"></param>
        /// <param name="allocations"></param>
        /// <param name="offsets">If not null, it must point to an array of offsets of regions to flush, relative to the beginning of respective allocations. Null means all ofsets are zero.</param>
        /// <param name="sizes">If not null, it must point to an array of sizes of regions to flush in respective allocations. Null means `VK_WHOLE_SIZE` for all allocations.</param>
        /// <remarks>
        /// @brief Invalidates memory of given set of allocations.Calls `vkInvalidateMappedMemoryRanges()` for memory associated with given ranges of given allocations.
        /// For more information, see documentation of vmaInvalidateAllocation().This function returns the `VkResult` from `vkInvalidateMappedMemoryRanges` if it is
        /// called, otherwise `VK_SUCCESS`.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, ref VmaAllocation, ref ulong, ref ulong, VkResult> InvalidateAllocations;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="memoryTypeBits">Bit mask, where each bit set means that a memory type with that index should be checked.</param>
        /// <remarks>
        /// @brief Checks magic number in margins around all allocations in given memory types (in both default and custom pools) in search for corruptions.Corruption detection is enabled only when `VMA_DEBUG_DETECT_CORRUPTION` macro is defined to nonzero,
        /// `VMA_DEBUG_MARGIN` is defined to nonzero and only for memory types that are
        /// `HOST_VISIBLE` and `HOST_COHERENT`. For more information, see [Corruption detection](@ref debugging_memory_usage_corruption_detection).Possible return values:- `VK_ERROR_FEATURE_NOT_PRESENT` - corruption detection is not enabled for any of specified memory types.
        /// - `VK_SUCCESS` - corruption detection has been performed and succeeded.
        /// - `VK_ERROR_UNKNOWN` - corruption detection has been performed and found memory corruptions around one of the allocations.
        /// `VMA_ASSERT` is also fired in that case.
        /// - Other value: Error returned by Vulkan, e.g. memory mapping failure.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, uint, VkResult> CheckCorruption;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator">Allocator object.</param>
        /// <param name="pInfo">Structure filled with parameters of defragmentation.</param>
        /// <param name="pStats">Optional. Statistics of defragmentation. You can pass null if you are not interested in this information.</param>
        /// <param name="pContext">Context object that must be passed to vmaDefragmentationEnd() to finish defragmentation.</param>
        /// <returns>`VK_SUCCESS` and `*pContext == null` if defragmentation finished within this function call. `VK_NOT_READY` and `*pContext != null` if defragmentation has been started and you need to call vmaDefragmentationEnd() to finish it. Negative value in case of error.</returns>
        /// <remarks>
        /// @brief Begins defragmentation process.Use this function instead of old, deprecated vmaDefragment().Warning! Between the call to vmaDefragmentationBegin() and vmaDefragmentationEnd():- You should not use any of allocations passed as `pInfo-&gt;pAllocations` or
        /// any allocations that belong to pools passed as `pInfo-&gt;pPools`,
        /// including calling vmaGetAllocationInfo(), vmaTouchAllocation(), or access
        /// their data.
        /// - Some mutexes protecting internal data structures may be locked, so trying to
        /// make or free any allocations, bind buffers or images, map memory, or launch
        /// another simultaneous defragmentation in between may cause stall (when done on
        /// another thread) or deadlock (when done on the same thread), unless you are
        /// 100% sure that defragmented allocations are in different pools.
        /// - Information returned via `pStats` and `pInfo-&gt;pAllocationsChanged` are undefined.
        /// They become valid after call to vmaDefragmentationEnd().
        /// - If `pInfo-&gt;commandBuffer` is not null, you must submit that command buffer
        /// and make sure it finished execution before calling vmaDefragmentationEnd().For more information and important limitations regarding defragmentation, see documentation chapter:
        /// [Defragmentation](@ref defragmentation).
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VmaDefragmentationInfo2, ref VmaDefragmentationStats, ref VmaDefragmentationContext, VkResult> DefragmentationBegin;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Ends defragmentation process.Use this function to finish defragmentation started by vmaDefragmentationBegin().
        /// It is safe to pass `context == null`. The function then does nothing.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaDefragmentationContext, VkResult> DefragmentationEnd;

        public static unsafe delegate* <VmaAllocator, VmaDefragmentationContext, ref VmaDefragmentationPassInfo, VkResult> BeginDefragmentationPass;

        public static unsafe delegate* <VmaAllocator, VmaDefragmentationContext, VkResult> EndDefragmentationPass;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="pAllocations">Array of allocations that can be moved during this compation.</param>
        /// <param name="allocationCount">Number of elements in pAllocations and pAllocationsChanged arrays.</param>
        /// <param name="pAllocationsChanged">Array of boolean values that will indicate whether matching allocation in pAllocations array has been moved. This parameter is optional. Pass null if you don't need this information.</param>
        /// <param name="pDefragmentationInfo">Configuration parameters. Optional - pass null to use default values.</param>
        /// <param name="pDefragmentationStats">Statistics returned by the function. Optional - pass null if you don't need this information.</param>
        /// <returns>`VK_SUCCESS` if completed, negative error code in case of error.</returns>
        /// <remarks>
        /// @brief Deprecated. Compacts memory by moving allocations.@deprecated This is a part of the old interface. It is recommended to use structure #VmaDefragmentationInfo2 and function vmaDefragmentationBegin() instead.This function works by moving allocations to different places (different
        /// `VkDeviceMemory` objects and/or different offsets) in order to optimize memory
        /// usage. Only allocations that are in `pAllocations` array can be moved. All other
        /// allocations are considered nonmovable in this call. Basic rules:- Only allocations made in memory types that have
        /// `VK_MEMORY_PROPERTY_HOST_VISIBLE_BIT` and `VK_MEMORY_PROPERTY_HOST_COHERENT_BIT`
        /// flags can be compacted. You may pass other allocations but it makes no sense -
        /// these will never be moved.
        /// - Custom pools created with #VMA_POOL_CREATE_LINEAR_ALGORITHM_BIT or
        /// #VMA_POOL_CREATE_BUDDY_ALGORITHM_BIT flag are not defragmented. Allocations
        /// passed to this function that come from such pools are ignored.
        /// - Allocations created with #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT or
        /// created as dedicated allocations for any other reason are also ignored.
        /// - Both allocations made with or without #VMA_ALLOCATION_CREATE_MAPPED_BIT
        /// flag can be compacted. If not persistently mapped, memory will be mapped
        /// temporarily inside this function if needed.
        /// - You must not pass same #VmaAllocation object multiple times in `pAllocations` array.The function also frees empty `VkDeviceMemory` blocks.Warning: This function may be time-consuming, so you shouldn't call it too often
        /// (like after every resource creation/destruction).
        /// You can call it on special occasions (like when reloading a game level or
        /// when you just destroyed a lot of objects). Calling it every frame may be OK, but
        /// you should measure that on your platform.For more information, see [Defragmentation](@ref defragmentation) chapter.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, ref VmaAllocation, ulong, ref uint, in VmaDefragmentationInfo, ref VmaDefragmentationStats, VkResult> Defragment;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Binds buffer to allocation.Binds specified buffer to region of memory represented by specified allocation.
        /// Gets `VkDeviceMemory` handle and offset from the allocation.
        /// If you want to create a buffer, allocate memory for it and bind them together separately,
        /// you should use this function for binding instead of standard `vkBindBufferMemory()`,
        /// because it ensures proper synchronization so that when a `VkDeviceMemory` object is used by multiple
        /// allocations, calls to `vkBind*Memory()` or `vkMapMemory()` won't happen from multiple threads simultaneously
        /// (which is illegal in Vulkan).It is recommended to use function vmaCreateBuffer() instead of this one.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, VkBuffer, VkResult> BindBufferMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="allocation"></param>
        /// <param name="allocationLocalOffset">Additional offset to be added while binding, relative to the beginning of the `allocation`. Normally it should be 0.</param>
        /// <param name="buffer"></param>
        /// <param name="pNext">A chain of structures to be attached to `VkBindBufferMemoryInfoKHR` structure used internally. Normally it should be null.</param>
        /// <remarks>
        /// @brief Binds buffer to allocation with additional parameters.This function is similar to vmaBindBufferMemory(), but it provides additional parameters.If `pNext` is not null, #VmaAllocator object must have been created with #VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT flag
        /// or with VmaAllocatorCreateInfo::vulkanApiVersion `&gt;= VK_API_VERSION_1_1`. Otherwise the call fails.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ulong, VkBuffer, nint, VkResult> BindBufferMemory2;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Binds image to allocation.Binds specified image to region of memory represented by specified allocation.
        /// Gets `VkDeviceMemory` handle and offset from the allocation.
        /// If you want to create an image, allocate memory for it and bind them together separately,
        /// you should use this function for binding instead of standard `vkBindImageMemory()`,
        /// because it ensures proper synchronization so that when a `VkDeviceMemory` object is used by multiple
        /// allocations, calls to `vkBind*Memory()` or `vkMapMemory()` won't happen from multiple threads simultaneously
        /// (which is illegal in Vulkan).It is recommended to use function vmaCreateImage() instead of this one.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, VkImage, VkResult> BindImageMemory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="allocator"></param>
        /// <param name="allocation"></param>
        /// <param name="allocationLocalOffset">Additional offset to be added while binding, relative to the beginning of the `allocation`. Normally it should be 0.</param>
        /// <param name="image"></param>
        /// <param name="pNext">A chain of structures to be attached to `VkBindImageMemoryInfoKHR` structure used internally. Normally it should be null.</param>
        /// <remarks>
        /// @brief Binds image to allocation with additional parameters.This function is similar to vmaBindImageMemory(), but it provides additional parameters.If `pNext` is not null, #VmaAllocator object must have been created with #VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT flag
        /// or with VmaAllocatorCreateInfo::vulkanApiVersion `&gt;= VK_API_VERSION_1_1`. Otherwise the call fails.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VmaAllocation, ulong, VkImage, nint, VkResult> BindImageMemory2;

        /// <summary>
        /// @param allocator
        /// </summary>
        /// <param name="pBufferCreateInfo"></param>
        /// <param name="pAllocationCreateInfo"></param>
        /// <param name="pBuffer">Buffer that was created.</param>
        /// <param name="pAllocation">Allocation that was created.</param>
        /// <param name="pAllocationInfo">Optional. Information about allocated memory. It can be later fetched using function vmaGetAllocationInfo().</param>
        /// <remarks>
        /// This function automatically:-# Creates buffer.
        /// -# Allocates appropriate memory for it.
        /// -# Binds the buffer with the memory.If any of these operations fail, buffer and allocation are not created,
        /// returned value is negative error code, *pBuffer and *pAllocation are null.If the function succeeded, you must destroy both buffer and allocation when you
        /// no longer need them using either convenience function vmaDestroyBuffer() or
        /// separately, using `vkDestroyBuffer()` and vmaFreeMemory().If #VMA_ALLOCATOR_CREATE_KHR_DEDICATED_ALLOCATION_BIT flag was used,
        /// VK_KHR_dedicated_allocation extension is used internally to query driver whether
        /// it requires or prefers the new buffer to have dedicated allocation. If yes,
        /// and if dedicated allocation is possible (VmaAllocationCreateInfo::pool is null
        /// and #VMA_ALLOCATION_CREATE_NEVER_ALLOCATE_BIT is not used), it creates dedicated
        /// allocation for this buffer, just like when using
        /// #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT.@note This function creates a new `VkBuffer`. Sub-allocation of parts of one large buffer,
        /// although recommended as a good practice, is out of scope of this library and could be implemented
        /// by the user as a higher-level logic on top of VMA.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ref VkBuffer, ref VmaAllocation, ref VmaAllocationInfo, VkResult> CreateBuffer;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Creates a buffer with additional minimum alignment.Similar to vmaCreateBuffer() but provides additional parameter `minAlignment` which allows to specify custom,
        /// minimum alignment to be used when placing the buffer inside a larger memory block, which may be needed e.g.
        /// for interop with OpenGL.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, in VkBufferCreateInfo, in VmaAllocationCreateInfo, ulong, ref VkBuffer, ref VmaAllocation, ref VmaAllocationInfo, VkResult> CreateBufferWithAlignment;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Destroys Vulkan buffer and frees allocated memory.This is just a convenience function equivalent to:@code vkDestroyBuffer(device, buffer, allocationCallbacks);
        /// vmaFreeMemory(allocator, allocation);
        /// @endcodeIt it safe to pass null as buffer and/or allocation.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VkBuffer, VmaAllocation, void> DestroyBuffer;

        /// <summary>
        /// Function similar to vmaCreateBuffer().
        /// </summary>
        public static unsafe delegate* <VmaAllocator, in VkImageCreateInfo, in VmaAllocationCreateInfo, ref VkImage, ref VmaAllocation, ref VmaAllocationInfo, VkResult> CreateImage;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Destroys Vulkan image and frees allocated memory.This is just a convenience function equivalent to:@code vkDestroyImage(device, image, allocationCallbacks);
        /// vmaFreeMemory(allocator, allocation);
        /// @endcodeIt it safe to pass null as image and/or allocation.
        /// </remarks>
        public static unsafe delegate* <VmaAllocator, VkImage, VmaAllocation, void> DestroyImage;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pCreateInfo">Parameters for creation.</param>
        /// <param name="pVirtualBlock">Returned virtual block object or `VMA_NULL` if creation failed.</param>
        /// <remarks>
        /// @brief Creates new #VmaVirtualBlock object.
        /// </remarks>
        public static unsafe delegate* <in VmaVirtualBlockCreateInfo, ref VmaVirtualBlock, VkResult> CreateVirtualBlock;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Destroys #VmaVirtualBlock object.Please note that you should consciously handle virtual allocations that could remain unfreed in the block.
        /// You should either free them individually using vmaVirtualFree() or call vmaClearVirtualBlock()
        /// if you are sure this is what you want. If you do neither, an assert is called.If you keep pointers to some additional metadata associated with your virtual allocations in their `pUserData`,
        /// don't forget to free them.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, void> DestroyVirtualBlock;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Returns true of the #VmaVirtualBlock is empty - contains 0 virtual allocations and has all its space available for new allocations.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, uint> IsVirtualBlockEmpty;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Returns information about a specific virtual allocation within a virtual block, like its size and `pUserData` pointer.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, ulong, ref VmaVirtualAllocationInfo, void> GetVirtualAllocationInfo;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Allocates new virtual allocation inside given #VmaVirtualBlock.There is no handle type for a virtual allocation.
        /// Virtual allocations within a specific virtual block are uniquely identified by their offsets.If the allocation fails due to not enough free space available, `VK_ERROR_OUT_OF_DEVICE_MEMORY` is returned
        /// (despite the function doesn't ever allocate actual GPU memory).
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, in VmaVirtualAllocationCreateInfo, ref ulong, VkResult> VirtualAllocate;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Frees virtual allocation inside given #VmaVirtualBlock.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, ulong, void> VirtualFree;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Frees all virtual allocations inside given #VmaVirtualBlock.You must either call this function or free each virtual allocation individually with vmaVirtualFree()
        /// before destroying a virtual block. Otherwise, an assert is called.If you keep pointer to some additional metadata associated with your virtual allocation in its `pUserData`,
        /// don't forget to free it as well.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, void> ClearVirtualBlock;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Changes custom pointer associated with given virtual allocation.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, ulong, nint, void> SetVirtualAllocationUserData;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Calculates and returns statistics about virtual allocations and memory usage in given #VmaVirtualBlock.
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, ref VmaStatInfo, void> CalculateVirtualBlockStats;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="virtualBlock">Virtual block.</param>
        /// <param name="ppStatsString">Returned string.</param>
        /// <param name="detailedMap">Pass `VK_FALSE` to only obtain statistics as returned by vmaCalculateVirtualBlockStats(). Pass `VKRUE` to also obtain full list of allocations and free spaces.</param>
        /// <remarks>
        /// @brief Builds and returns a null-terminated string in JSON format with information about given #VmaVirtualBlock.Returned string must be freed using vmaFreeVirtualBlockStatsString().
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, out nint, uint, void> BuildVirtualBlockStatsString;

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Frees a string returned by vmaBuildVirtualBlockStatsString().
        /// </remarks>
        public static unsafe delegate* <VmaVirtualBlock, nint, void> FreeVirtualBlockStatsString;
    }
}
