using System.Runtime.InteropServices;

using Vulkan.Windows;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vk_icdEnumerateAdapterPhysicalDevices([NativeTypeName("VkInstance")] VkInstance                    instance,
                                                                              LUID                                                         adapterLUID,
                                                                              [NativeTypeName("uint32_t *")]             uint*             pPhysicalDeviceCount,
                                                                              [NativeTypeName("VkPhysicalDevice *")] ref VkPhysicalDevice[] pPhysicalDevices);
}
