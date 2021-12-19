using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkImportFenceWin32HandleKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("const VkImportFenceWin32HandleInfoKHR *")]
                                                                    VkImportFenceWin32HandleInfoKHR* pImportFenceWin32HandleInfo);
}
