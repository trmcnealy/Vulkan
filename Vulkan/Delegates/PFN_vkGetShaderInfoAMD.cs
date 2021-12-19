using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetShaderInfoAMD([NativeTypeName("VkDevice")]       VkDevice   device,
                                                           [NativeTypeName("VkPipeline")] ref VkPipeline pipeline,
                                                           VkShaderStageFlagBits                         shaderStage,
                                                           VkShaderInfoTypeAMD                           infoType,
                                                           [NativeTypeName("size_t *")] UIntPtr*         pInfoSize,
                                                           [NativeTypeName("void *")]   nint             pInfo);
}
