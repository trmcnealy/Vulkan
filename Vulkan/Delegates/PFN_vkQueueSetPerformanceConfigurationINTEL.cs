using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkQueueSetPerformanceConfigurationINTEL([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                                         [NativeTypeName("VkPerformanceConfigurationINTEL")]
                                                                         ref VkPerformanceConfigurationINTEL configuration);
}
