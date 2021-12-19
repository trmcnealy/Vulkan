using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetGeneratedCommandsMemoryRequirementsNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                               [NativeTypeName("const VkGeneratedCommandsMemoryRequirementsInfoNV *")]
                                                                               in VkGeneratedCommandsMemoryRequirementsInfoNV pInfo,
                                                                               VkMemoryRequirements2[] pMemoryRequirements);
}
