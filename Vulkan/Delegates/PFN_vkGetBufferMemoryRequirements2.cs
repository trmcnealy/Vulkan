using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetBufferMemoryRequirements2([NativeTypeName("VkDevice")] VkDevice device,
                                                                   [NativeTypeName("const VkBufferMemoryRequirementsInfo2 *")]
                                                                   in VkBufferMemoryRequirementsInfo2 pInfo,
                                                                   VkMemoryRequirements2[] pMemoryRequirements);
}
