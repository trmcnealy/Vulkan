#region

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#endregion

namespace Vulkan;

[SuppressMessage("ReSharper",
                 "InconsistentNaming")]
public readonly partial struct VkPhysicalDevice
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkPhysicalDeviceFeatures GetPhysicalDeviceFeatures()
    {
        Api.GetPhysicalDeviceFeatures(this,
                                      out VkPhysicalDeviceFeatures result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkFormatProperties GetPhysicalDeviceFormatProperties(VkFormat format)
    {
        Api.GetPhysicalDeviceFormatProperties(this,
                                              format,
                                              out VkFormatProperties result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkImageFormatProperties GetPhysicalDeviceImageFormatProperties(VkFormat              format,
                                                                                 VkImageType           type,
                                                                                 VkImageTiling         tiling,
                                                                                 VkImageUsageFlagBits  usage,
                                                                                 VkImageCreateFlagBits flags)
    {
        Api.GetPhysicalDeviceImageFormatProperties(this,
                                                   format,
                                                   type,
                                                   tiling,
                                                   usage,
                                                   flags,
                                                   out VkImageFormatProperties result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkPhysicalDeviceProperties GetPhysicalDeviceProperties()
    {
        Api.GetPhysicalDeviceProperties(this,
                                        out VkPhysicalDeviceProperties result);

        return result;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VkQueueFamilyProperties[] GetPhysicalDeviceQueueFamilyProperties()
    {
        return Api.GetPhysicalDeviceQueueFamilyProperties(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkPhysicalDeviceMemoryProperties GetPhysicalDeviceMemoryProperties()
    {
        Api.GetPhysicalDeviceMemoryProperties(this,
                                              out VkPhysicalDeviceMemoryProperties result);

        return result;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkDevice CreateDevice(ref VkDeviceCreateInfo pCreateInfo,
                                        VkAllocationCallbacks* pAllocator)
    {
        Api.CreateDevice(this,
                         ref pCreateInfo,
                         pAllocator,
                         out VkDevice result);

        return result;
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VkExtensionProperties[] EnumerateDeviceExtensionProperties()
    {
        return Api.EnumerateDeviceExtensionProperties(this);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VkLayerProperties[] EnumerateDeviceLayerProperties()
    {
        return Api.EnumerateDeviceLayerProperties(this);
    }


    //TODO
    //public static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPlaneProperties2KHR*, VkResult> GetPhysicalDeviceDisplayPlaneProperties2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPlanePropertiesKHR*, VkResult> GetPhysicalDeviceDisplayPlanePropertiesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayProperties2KHR*, VkResult> GetPhysicalDeviceDisplayProperties2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkDisplayPropertiesKHR*, VkResult> GetPhysicalDeviceDisplayPropertiesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, out uint, VkQueueFamilyProperties2*, void> GetPhysicalDeviceQueueFamilyProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult> GetDisplayPlaneCapabilities2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalBufferInfo, ref VkExternalBufferProperties, void> GetPhysicalDeviceExternalBufferProperties;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalFenceInfo, ref VkExternalFenceProperties, void> GetPhysicalDeviceExternalFenceProperties;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceExternalSemaphoreInfo, ref VkExternalSemaphoreProperties, void> GetPhysicalDeviceExternalSemaphoreProperties;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceFeatures2, void> GetPhysicalDeviceFeatures2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceImageFormatInfo2, ref VkImageFormatProperties2, VkResult> GetPhysicalDeviceImageFormatProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceMemoryProperties2, void> GetPhysicalDeviceMemoryProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceProperties2, void> GetPhysicalDeviceProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSparseImageFormatInfo2, out uint, VkSparseImageFormatProperties2*, void> GetPhysicalDeviceSparseImageFormatProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkSurfaceFormat2KHR*, VkResult> GetPhysicalDeviceSurfaceFormats2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, ref VkPhysicalDeviceSurfaceInfo2KHR, ref VkSurfaceCapabilities2KHR, VkResult> GetPhysicalDeviceSurfaceCapabilities2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, uint, out uint, VkDisplayKHR*, VkResult> GetDisplayPlaneSupportedDisplaysKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, uint, VkSurfaceKHR, out uint, VkResult> GetPhysicalDeviceSurfaceSupportKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModeProperties2KHR*, VkResult> GetDisplayModeProperties2KHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayKHR, out uint, VkDisplayModePropertiesKHR*, VkResult> GetDisplayModePropertiesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayKHR, ref VkDisplayModeCreateInfoKHR, VkAllocationCallbacks*, out VkDisplayModeKHR, VkResult> CreateDisplayModeKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkDisplayModeKHR, uint, ref VkDisplayPlaneCapabilitiesKHR, VkResult> GetDisplayPlaneCapabilitiesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkFormat, ref VkFormatProperties2, void> GetPhysicalDeviceFormatProperties2;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkPresentModeKHR*, VkResult> GetPhysicalDeviceSurfacePresentModesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkRect2D*, VkResult> GetPhysicalDevicePresentRectanglesKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out uint, VkSurfaceFormatKHR*, VkResult> GetPhysicalDeviceSurfaceFormatsKHR;
    //public static readonly unsafe delegate*<VkPhysicalDevice, VkSurfaceKHR, out VkSurfaceCapabilitiesKHR, VkResult> GetPhysicalDeviceSurfaceCapabilitiesKHR;
}
