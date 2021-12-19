using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkTrimCommandPool([NativeTypeName("VkDevice")]          VkDevice      device,
                                               [NativeTypeName("VkCommandPool")] ref VkCommandPool commandPool,
                                               [NativeTypeName("VkCommandPoolTrimFlags")]
                                               uint flags);
}
