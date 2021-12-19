using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkQueuePresentKHR([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                          [NativeTypeName("const VkPresentInfoKHR *")]
                                                          VkPresentInfoKHR[] pPresentInfo);
}
