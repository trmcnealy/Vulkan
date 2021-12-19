using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                         "VkDeviceSize")]
    public delegate ulong PFN_vkGetRayTracingShaderGroupStackSizeKHR([NativeTypeName("VkDevice")]       VkDevice   device,
                                                                     [NativeTypeName("VkPipeline")] ref VkPipeline pipeline,
                                                                     [NativeTypeName("uint32_t")]       uint       group,
                                                                     VkShaderGroupShaderKHR                        groupShader);
}
