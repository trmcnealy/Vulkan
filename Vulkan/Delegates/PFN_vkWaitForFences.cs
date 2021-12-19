using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkWaitForFences([NativeTypeName("VkDevice")]            VkDevice device,
                                                        [NativeTypeName("uint32_t")]            uint     fenceCount,
                                                        [NativeTypeName("const VkFence *")] ref VkFence[] pFences,
                                                        [NativeTypeName("VkBool32")]            uint     waitAll,
                                                        [NativeTypeName("uint64_t")]            ulong    timeout);
}
