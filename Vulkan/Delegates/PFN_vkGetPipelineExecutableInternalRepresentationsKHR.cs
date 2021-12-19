using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPipelineExecutableInternalRepresentationsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                                          [NativeTypeName("const VkPipelineExecutableInfoKHR *")]
                                                                                          in VkPipelineExecutableInfoKHR pExecutableInfo,
                                                                                          [NativeTypeName("uint32_t *")] uint*           pInternalRepresentationCount,
                                                                                          VkPipelineExecutableInternalRepresentationKHR[] pInternalRepresentations);
}
