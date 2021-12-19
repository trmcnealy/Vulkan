using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkQueueBeginDebugUtilsLabelEXT([NativeTypeName("VkQueue")] VkQueue queue,
                                                                   [NativeTypeName("const VkDebugUtilsLabelEXT *")]
                                                                   in VkDebugUtilsLabelEXT pLabelInfo);
}
