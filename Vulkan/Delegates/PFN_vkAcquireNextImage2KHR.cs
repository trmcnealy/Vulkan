using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAcquireNextImage2KHR([NativeTypeName("VkDevice")] VkDevice device,
                                                               [NativeTypeName("const VkAcquireNextImageInfoKHR *")]
                                                               in VkAcquireNextImageInfoKHR pAcquireInfo,
                                                               [NativeTypeName("uint32_t *")] in uint pImageIndex);
}
