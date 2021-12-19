using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceImageSparseMemoryRequirementsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                                [NativeTypeName("const VkDeviceImageMemoryRequirementsKHR *")]
                                                                                in VkDeviceImageMemoryRequirementsKHR pInfo,
                                                                                [NativeTypeName("uint32_t *")] uint[] pSparseMemoryRequirementCount,
                                                                                VkSparseImageMemoryRequirements2*    pSparseMemoryRequirements);
}
