using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                                    "VkDeviceAddress")]
    public unsafe delegate ulong PFN_vkGetAccelerationStructureDeviceAddressKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                                [NativeTypeName("const VkAccelerationStructureDeviceAddressInfoKHR *")]
                                                                                in VkAccelerationStructureDeviceAddressInfoKHR pInfo);
}
