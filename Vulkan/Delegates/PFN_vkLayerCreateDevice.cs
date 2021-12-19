using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkLayerCreateDevice([NativeTypeName("VkInstance")]           VkInstance       instance,
                                                            [NativeTypeName("VkPhysicalDevice")] ref VkPhysicalDevice physicalDevice,
                                                            [NativeTypeName("const VkDeviceCreateInfo *")]
                                                            in VkDeviceCreateInfo pCreateInfo,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator,
                                                            [NativeTypeName("VkDevice *")] out VkDevice pDevice,
                                                            [NativeTypeName("PFN_vkGetInstanceProcAddr")]
                                                            nint layerGIPA,
                                                            [NativeTypeName("PFN_vkGetDeviceProcAddr *")]
                                                            in nint nextGdpa);
}
