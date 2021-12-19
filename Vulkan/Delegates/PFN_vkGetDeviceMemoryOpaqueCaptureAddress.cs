using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                               "uint64_t")]
    public unsafe delegate ulong PFN_vkGetDeviceMemoryOpaqueCaptureAddress([NativeTypeName("VkDevice")] VkDevice device,
                                                                           [NativeTypeName("const VkDeviceMemoryOpaqueCaptureAddressInfo *")]
                                                                           in VkDeviceMemoryOpaqueCaptureAddressInfo pInfo);
}
