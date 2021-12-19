using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_PhysDevExt([NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice phys_device);
}
