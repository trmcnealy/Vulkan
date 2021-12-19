using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateBuffer([NativeTypeName("VkDevice")] VkDevice device,
                                                       [NativeTypeName("const VkBufferCreateInfo *")]
                                                       in VkBufferCreateInfo pCreateInfo,
                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                       in VkAllocationCallbacks pAllocator,
                                                       [NativeTypeName("VkBuffer *")] out VkBuffer pBuffer);
}
