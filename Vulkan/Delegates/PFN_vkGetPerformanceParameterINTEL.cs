using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetPerformanceParameterINTEL([NativeTypeName("VkDevice")] VkDevice device,
                                                                       VkPerformanceParameterTypeINTEL       parameter,
                                                                       VkPerformanceValueINTEL*              pValue);
}
