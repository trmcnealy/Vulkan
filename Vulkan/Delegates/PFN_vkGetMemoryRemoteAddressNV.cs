using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetMemoryRemoteAddressNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                   [NativeTypeName("const VkMemoryGetRemoteAddressInfoNV *")]
                                                                   VkMemoryGetRemoteAddressInfoNV[] pMemoryGetRemoteAddressInfo,
                                                                   [NativeTypeName("VkRemoteAddressNV *")]
                                                                   nint[] pAddress);
}
