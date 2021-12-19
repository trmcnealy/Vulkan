using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkCompileDeferredNV([NativeTypeName("VkDevice")]       VkDevice   device,
                                                     [NativeTypeName("VkPipeline")] ref VkPipeline pipeline,
                                                     [NativeTypeName("uint32_t")]       uint       shader);
}
