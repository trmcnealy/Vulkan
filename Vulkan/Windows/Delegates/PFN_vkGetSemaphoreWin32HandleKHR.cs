using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetSemaphoreWin32HandleKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("const VkSemaphoreGetWin32HandleInfoKHR *")]
                                                                     VkSemaphoreGetWin32HandleInfoKHR* pGetWin32HandleInfo,
                                                                     [NativeTypeName("HANDLE *")] void** pHandle);
}
