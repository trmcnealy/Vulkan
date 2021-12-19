using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetFenceFdKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                        [NativeTypeName("const VkFenceGetFdInfoKHR *")]
                                                        in VkFenceGetFdInfoKHR pGetFdInfo,
                                                        in int pFd);
}
