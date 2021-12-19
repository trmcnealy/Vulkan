using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkQueueSubmit2KHR([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                          [NativeTypeName("uint32_t")]    uint    submitCount,
                                                          [NativeTypeName("const VkSubmitInfo2KHR *")]
                                                          VkSubmitInfo2KHR[] pSubmits,
                                                          [NativeTypeName("VkFence")] ref VkFence fence);
}
