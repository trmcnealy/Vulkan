using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkQueueWaitIdle([NativeTypeName("VkQueue")] ref VkQueue queue);
}
