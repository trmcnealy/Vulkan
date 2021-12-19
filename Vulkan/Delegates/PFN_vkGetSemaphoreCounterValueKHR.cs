using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSemaphoreCounterValueKHR([NativeTypeName("VkDevice")]        VkDevice    device,
                                                                      [NativeTypeName("VkSemaphore")] ref VkSemaphore semaphore,
                                                                      [NativeTypeName("uint64_t *")]      ulong*      pValue);
}
