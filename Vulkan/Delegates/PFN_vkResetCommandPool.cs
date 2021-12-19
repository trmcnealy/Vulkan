using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkResetCommandPool([NativeTypeName("VkDevice")]          VkDevice      device,
                                                    [NativeTypeName("VkCommandPool")] ref VkCommandPool commandPool,
                                                    [NativeTypeName("VkCommandPoolResetFlags")]
                                                    uint flags);
}
