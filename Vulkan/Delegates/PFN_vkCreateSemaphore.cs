using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateSemaphore([NativeTypeName("VkDevice")] VkDevice device,
                                                          [NativeTypeName("const VkSemaphoreCreateInfo *")]
                                                          in VkSemaphoreCreateInfo pCreateInfo,
                                                          [NativeTypeName("const VkAllocationCallbacks *")]
                                                          in VkAllocationCallbacks pAllocator,
                                                          [NativeTypeName("VkSemaphore *")] out VkSemaphore pSemaphore);
}
