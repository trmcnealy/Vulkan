using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetFenceWin32HandleKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("const VkFenceGetWin32HandleInfoKHR *")]
                                                                 VkFenceGetWin32HandleInfoKHR* pGetWin32HandleInfo,
                                                                 [NativeTypeName("HANDLE *")] void** pHandle);
}
