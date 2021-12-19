using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Statistics of current memory usage and available budget, in bytes, for specific memory heap.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaBudget
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Sum size of all `VkDeviceMemory` blocks allocated from particular heap, in bytes.
    /// </remarks>
    public ulong blockBytes;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Sum size of all allocations created in particular heap, in bytes.Usually less or equal than `blockBytes`.
    /// Difference `blockBytes - allocationBytes` is the amount of memory allocated but unused -
    /// available for new allocations or wasted due to fragmentation.It might be greater than `blockBytes` if there are some allocations in lost state, as they account
    /// to this value as well.
    /// </remarks>
    public ulong allocationBytes;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Estimated current memory usage of the program, in bytes.Fetched from system using `VK_EXT_memory_budget` extension if enabled.It might be different than `blockBytes` (usually higher) due to additional implicit objects
    /// also occupying the memory, like swapchain, pipelines, descriptor heaps, command buffers, or
    /// `VkDeviceMemory` blocks allocated outside of this library, if any.
    /// </remarks>
    public ulong usage;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Estimated amount of memory available to the program, in bytes.Fetched from system using `VK_EXT_memory_budget` extension if enabled.It might be different (most probably smaller) than `VkMemoryHeap::size[heapIndex]` due to factors
    /// external to the program, like other programs also consuming system resources.
    /// Difference `budget - usage` is the amount of additional memory that can probably
    /// be allocated without problems. Exceeding the budget may result in various problems.
    /// </remarks>
    public ulong budget;
}