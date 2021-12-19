using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkQueueBindSparse([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                          [NativeTypeName("uint32_t")]    uint    bindInfoCount,
                                                          [NativeTypeName("const VkBindSparseInfo *")]
                                                          in VkBindSparseInfo pBindInfo,
                                                          [NativeTypeName("VkFence")] ref VkFence fence);
}
