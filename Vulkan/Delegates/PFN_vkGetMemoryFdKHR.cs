using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryFdKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                         [NativeTypeName("const VkMemoryGetFdInfoKHR *")]
                                                         in VkMemoryGetFdInfoKHR pGetFdInfo,
                                                         in int pFd);
}
