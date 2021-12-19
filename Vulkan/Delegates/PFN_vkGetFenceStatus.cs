using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetFenceStatus([NativeTypeName("VkDevice")]    VkDevice device,
                                                  [NativeTypeName("VkFence")] ref VkFence  fence);
}
