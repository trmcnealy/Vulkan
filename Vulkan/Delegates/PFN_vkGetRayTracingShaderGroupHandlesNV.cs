using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetRayTracingShaderGroupHandlesNV([NativeTypeName("VkDevice")]       VkDevice   device,
                                                                     [NativeTypeName("VkPipeline")] ref VkPipeline pipeline,
                                                                     [NativeTypeName("uint32_t")]       uint       firstGroup,
                                                                     [NativeTypeName("uint32_t")]       uint       groupCount,
                                                                     [NativeTypeName("size_t")]         nuint      dataSize,
                                                                     [NativeTypeName("void *")]         nint       pData);
}
