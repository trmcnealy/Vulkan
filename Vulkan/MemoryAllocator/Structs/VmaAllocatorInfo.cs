using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Information about existing #VmaAllocator object.
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaAllocatorInfo
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Handle to Vulkan instance object.This is the same value as has been passed through VmaAllocatorCreateInfo::instance.
    /// </remarks>
    public VkInstance instance;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Handle to Vulkan physical device object.This is the same value as has been passed through VmaAllocatorCreateInfo::physicalDevice.
    /// </remarks>
    public VkPhysicalDevice physicalDevice;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Handle to Vulkan device object.This is the same value as has been passed through VmaAllocatorCreateInfo::device.
    /// </remarks>
    public VkDevice device;
}