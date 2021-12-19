using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumeratePhysicalDevices([NativeTypeName("VkInstance")]             VkInstance        instance,
                                                                   [NativeTypeName("uint32_t *")]             uint*             pPhysicalDeviceCount,
                                                                   [NativeTypeName("VkPhysicalDevice *")] ref VkPhysicalDevice[] pPhysicalDevices);
}
