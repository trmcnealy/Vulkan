using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkQueueInsertDebugUtilsLabelEXT([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                                    [NativeTypeName("const VkDebugUtilsLabelEXT *")]
                                                                    in VkDebugUtilsLabelEXT pLabelInfo);
}
