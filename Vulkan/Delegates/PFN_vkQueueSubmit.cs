using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkQueueSubmit([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                      [NativeTypeName("uint32_t")]    uint    submitCount,
                                                      [NativeTypeName("const VkSubmitInfo *")]
                                                      VkSubmitInfo[] pSubmits,
                                                      [NativeTypeName("VkFence")] ref VkFence fence);
}
