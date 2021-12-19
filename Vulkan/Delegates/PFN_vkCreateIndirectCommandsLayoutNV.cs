using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateIndirectCommandsLayoutNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                         [NativeTypeName("const VkIndirectCommandsLayoutCreateInfoNV *")]
                                                                         in VkIndirectCommandsLayoutCreateInfoNV pCreateInfo,
                                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                                         in VkAllocationCallbacks pAllocator,
                                                                         [NativeTypeName("VkIndirectCommandsLayoutNV *")]
                                                                         ref VkIndirectCommandsLayoutNV[] pIndirectCommandsLayout);
}
