using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkImportSemaphoreFdKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                               [NativeTypeName("const VkImportSemaphoreFdInfoKHR *")]
                                                               in VkImportSemaphoreFdInfoKHR pImportSemaphoreFdInfo);
}
