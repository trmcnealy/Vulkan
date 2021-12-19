using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumeratePhysicalDeviceGroupsKHR([NativeTypeName("VkInstance")] VkInstance instance,
                                                                           [NativeTypeName("uint32_t *")] uint*      pPhysicalDeviceGroupCount,
                                                                           VkPhysicalDeviceGroupProperties*          pPhysicalDeviceGroupProperties);
}
