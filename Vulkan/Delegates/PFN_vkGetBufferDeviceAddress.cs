using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                  "VkDeviceAddress")]
    public unsafe delegate ulong PFN_vkGetBufferDeviceAddress([NativeTypeName("VkDevice")] VkDevice device,
                                                              [NativeTypeName("const VkBufferDeviceAddressInfo *")]
                                                              in VkBufferDeviceAddressInfo pInfo);
}
