using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetImageSparseMemoryRequirements2([NativeTypeName("VkDevice")] VkDevice device,
                                                                        [NativeTypeName("const VkImageSparseMemoryRequirementsInfo2 *")]
                                                                        in VkImageSparseMemoryRequirementsInfo2 pInfo,
                                                                        [NativeTypeName("uint32_t *")] uint[] pSparseMemoryRequirementCount,
                                                                        VkSparseImageMemoryRequirements2*    pSparseMemoryRequirements);
}
