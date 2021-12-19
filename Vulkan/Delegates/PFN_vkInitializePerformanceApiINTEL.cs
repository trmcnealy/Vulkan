using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkInitializePerformanceApiINTEL([NativeTypeName("VkDevice")] VkDevice device,
                                                                        [NativeTypeName("const VkInitializePerformanceApiInfoINTEL *")]
                                                                        in VkInitializePerformanceApiInfoINTEL pInitializeInfo);
}
