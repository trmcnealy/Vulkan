using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                      [NativeTypeName("VkIndirectCommandsLayoutNV")]
                                                                      ref VkIndirectCommandsLayoutNV indirectCommandsLayout,
                                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                                      in VkAllocationCallbacks pAllocator);
}
