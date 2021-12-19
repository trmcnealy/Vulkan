using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetImageMemoryRequirements2KHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("const VkImageMemoryRequirementsInfo2 *")]
                                                                     in VkImageMemoryRequirementsInfo2 pInfo,
                                                                     VkMemoryRequirements2[] pMemoryRequirements);
}
