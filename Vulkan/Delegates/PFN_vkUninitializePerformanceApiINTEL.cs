using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkUninitializePerformanceApiINTEL([NativeTypeName("VkDevice")] VkDevice device);
}
