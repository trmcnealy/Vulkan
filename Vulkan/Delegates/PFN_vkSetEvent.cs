using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkSetEvent([NativeTypeName("VkDevice")]    VkDevice device,
                                            [NativeTypeName("VkEvent")] ref VkEvent  @event);
}
