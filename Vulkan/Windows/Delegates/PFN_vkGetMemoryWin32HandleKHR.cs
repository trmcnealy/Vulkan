using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryWin32HandleKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                  [NativeTypeName("const VkMemoryGetWin32HandleInfoKHR *")]
                                                                  VkMemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo,
                                                                  [NativeTypeName("HANDLE *")] void** pHandle);
}
