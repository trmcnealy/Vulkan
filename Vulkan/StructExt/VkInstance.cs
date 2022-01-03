using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Vulkan;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public readonly partial struct VkInstance
{

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VkPhysicalDevice[] EnumeratePhysicalDevices()
    {
        return Api.EnumeratePhysicalDevices(this);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public VkPhysicalDeviceGroupProperties[] EnumeratePhysicalDeviceGroups()
    {
        return Api.EnumeratePhysicalDeviceGroups(this);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkResult CreateDisplayPlaneSurfaceKHR(ref VkDisplaySurfaceCreateInfoKHR createInfo, VkAllocationCallbacks* pAllocator, out VkSurfaceKHR surface)
    {
        return Api.CreateDisplayPlaneSurfaceKHR(this, ref createInfo, pAllocator, out surface);
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe void DestroySurfaceKHR(VkSurfaceKHR surface, VkAllocationCallbacks* pAllocator)
    {
        Api.DestroySurfaceKHR(this, surface, pAllocator);
    }


}
