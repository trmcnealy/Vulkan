using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetAccelerationStructureMemoryRequirementsNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                                   [NativeTypeName("const VkAccelerationStructureMemoryRequirementsInfoNV *")]
                                                                                   in VkAccelerationStructureMemoryRequirementsInfoNV pInfo,
                                                                                   [NativeTypeName("VkMemoryRequirements2KHR *")]
                                                                                   VkMemoryRequirements2[] pMemoryRequirements);
}
