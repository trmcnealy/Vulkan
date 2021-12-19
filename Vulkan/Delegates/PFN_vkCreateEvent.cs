using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateEvent([NativeTypeName("VkDevice")] VkDevice device,
                                                      [NativeTypeName("const VkEventCreateInfo *")]
                                                      in VkEventCreateInfo pCreateInfo,
                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                      in VkAllocationCallbacks pAllocator,
                                                      [NativeTypeName("VkEvent *")] out VkEvent pEvent);
}
