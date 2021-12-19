using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateImage([NativeTypeName("VkDevice")] VkDevice device,
                                                      [NativeTypeName("const VkImageCreateInfo *")]
                                                      in VkImageCreateInfo pCreateInfo,
                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                      in VkAllocationCallbacks pAllocator,
                                                      [NativeTypeName("VkImage *")] out VkImage pImage);
}
