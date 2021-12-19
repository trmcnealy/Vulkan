using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkReleaseProfilingLockKHR([NativeTypeName("VkDevice")] VkDevice device);
}
