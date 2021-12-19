using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkResetFences([NativeTypeName("VkDevice")]            VkDevice device,
                                                      [NativeTypeName("uint32_t")]            uint     fenceCount,
                                                      [NativeTypeName("const VkFence *")] ref VkFence[] pFences);
}
