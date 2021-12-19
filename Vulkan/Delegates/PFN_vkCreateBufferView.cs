using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateBufferView([NativeTypeName("VkDevice")] VkDevice device,
                                                           [NativeTypeName("const VkBufferViewCreateInfo *")]
                                                           in VkBufferViewCreateInfo pCreateInfo,
                                                           [NativeTypeName("const VkAllocationCallbacks *")]
                                                           in VkAllocationCallbacks pAllocator,
                                                           [NativeTypeName("VkBufferView *")] out VkBufferView pView);
}
