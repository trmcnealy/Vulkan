using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAcquirePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] VkDevice device,
                                                                               [NativeTypeName("const VkPerformanceConfigurationAcquireInfoINTEL *")]
                                                                               in VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo,
                                                                               [NativeTypeName("VkPerformanceConfigurationINTEL *")]
                                                                               out VkPerformanceConfigurationINTEL pConfiguration);
}
