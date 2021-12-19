using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyEvent([NativeTypeName("VkDevice")]    VkDevice device,
                                                   [NativeTypeName("VkEvent")] ref VkEvent  @event,
                                                   [NativeTypeName("const VkAllocationCallbacks *")]
                                                   in VkAllocationCallbacks pAllocator);
}
