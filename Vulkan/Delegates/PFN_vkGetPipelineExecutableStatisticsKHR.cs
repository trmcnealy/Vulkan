using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPipelineExecutableStatisticsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                             [NativeTypeName("const VkPipelineExecutableInfoKHR *")]
                                                                             in VkPipelineExecutableInfoKHR pExecutableInfo,
                                                                             [NativeTypeName("uint32_t *")] uint[] pStatisticCount,
                                                                             VkPipelineExecutableStatisticKHR*    pStatistics);
}
