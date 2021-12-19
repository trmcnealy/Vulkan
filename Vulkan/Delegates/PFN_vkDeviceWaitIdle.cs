using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkDeviceWaitIdle([NativeTypeName("VkDevice")] VkDevice device);
}
