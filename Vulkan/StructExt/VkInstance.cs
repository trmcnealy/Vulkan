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


    //TODO
    //public static readonly unsafe delegate*<VkInstance, out uint, VkPhysicalDeviceGroupProperties*, VkResult>                                  EnumeratePhysicalDeviceGroups;
    //public static readonly unsafe delegate*<VkInstance, ref VkDisplaySurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult> CreateDisplayPlaneSurfaceKHR;
    //public static readonly unsafe delegate*<VkInstance, VkSurfaceKHR, VkAllocationCallbacks*, void>                                            DestroySurfaceKHR;
}
