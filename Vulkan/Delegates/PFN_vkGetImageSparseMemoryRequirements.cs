using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetImageSparseMemoryRequirements([NativeTypeName("VkDevice")]    VkDevice device,
                                                                       [NativeTypeName("VkImage")] ref VkImage  image,
                                                                       [NativeTypeName("uint32_t *")]  uint*    pSparseMemoryRequirementCount,
                                                                       VkSparseImageMemoryRequirements*         pSparseMemoryRequirements);
}
