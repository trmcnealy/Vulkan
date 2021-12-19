using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkQueueEndDebugUtilsLabelEXT([NativeTypeName("VkQueue")] ref VkQueue queue);
}
