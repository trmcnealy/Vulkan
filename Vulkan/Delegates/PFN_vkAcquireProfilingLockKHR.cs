using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAcquireProfilingLockKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                  [NativeTypeName("const VkAcquireProfilingLockInfoKHR *")]
                                                                  in VkAcquireProfilingLockInfoKHR pInfo);
}
