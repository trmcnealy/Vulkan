using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceAccelerationStructureCompatibilityKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                                     [NativeTypeName("const VkAccelerationStructureVersionInfoKHR *")]
                                                                                     VkAccelerationStructureVersionInfoKHR[] pVersionInfo,
                                                                                     in VkAccelerationStructureCompatibilityKHR pCompatibility);
}
