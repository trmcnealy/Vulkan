using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateCommandPool([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkCommandPoolCreateInfo *")]
                                                            in VkCommandPoolCreateInfo pCreateInfo,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator,
                                                            [NativeTypeName("VkCommandPool *")] out VkCommandPool pCommandPool);
}
