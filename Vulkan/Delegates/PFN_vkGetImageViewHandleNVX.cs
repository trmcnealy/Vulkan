using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                "uint32_t")]
    public unsafe delegate uint PFN_vkGetImageViewHandleNVX([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkImageViewHandleInfoNVX *")]
                                                            in VkImageViewHandleInfoNVX pInfo);
}
