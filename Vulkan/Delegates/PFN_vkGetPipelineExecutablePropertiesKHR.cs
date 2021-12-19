using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPipelineExecutablePropertiesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                             [NativeTypeName("const VkPipelineInfoKHR *")]
                                                                             in VkPipelineInfoKHR pPipelineInfo,
                                                                             [NativeTypeName("uint32_t *")] in uint pExecutableCount,
                                                                             VkPipelineExecutablePropertiesKHR*   pProperties);
}
