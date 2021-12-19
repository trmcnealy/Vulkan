using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkWaitSemaphores([NativeTypeName("VkDevice")] VkDevice device,
                                                         [NativeTypeName("const VkSemaphoreWaitInfo *")]
                                                         in VkSemaphoreWaitInfo pWaitInfo,
                                                         [NativeTypeName("uint64_t")] ulong timeout);
}
