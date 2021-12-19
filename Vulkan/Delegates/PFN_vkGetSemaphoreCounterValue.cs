using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSemaphoreCounterValue([NativeTypeName("VkDevice")]        VkDevice    device,
                                                                   [NativeTypeName("VkSemaphore")] ref VkSemaphore semaphore,
                                                                   [NativeTypeName("uint64_t *")]      ulong*      pValue);
}
