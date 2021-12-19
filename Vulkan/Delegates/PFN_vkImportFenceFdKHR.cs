using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkImportFenceFdKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                           [NativeTypeName("const VkImportFenceFdInfoKHR *")]
                                                           in VkImportFenceFdInfoKHR pImportFenceFdInfo);
}
