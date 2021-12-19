using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkReleasePerformanceConfigurationINTEL([NativeTypeName("VkDevice")] VkDevice device,
                                                                        [NativeTypeName("VkPerformanceConfigurationINTEL")]
                                                                        ref VkPerformanceConfigurationINTEL configuration);
}
