using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSemaphoreFdKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkSemaphoreGetFdInfoKHR *")]
                                                            in VkSemaphoreGetFdInfoKHR pGetFdInfo,
                                                            in int pFd);
}
