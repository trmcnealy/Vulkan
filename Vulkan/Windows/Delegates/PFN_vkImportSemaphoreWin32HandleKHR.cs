using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkImportSemaphoreWin32HandleKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                        [NativeTypeName("const VkImportSemaphoreWin32HandleInfoKHR *")]
                                                                        VkImportSemaphoreWin32HandleInfoKHR* pImportSemaphoreWin32HandleInfo);
}
