using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateFence([NativeTypeName("VkDevice")] VkDevice device,
                                                      [NativeTypeName("const VkFenceCreateInfo *")]
                                                      in VkFenceCreateInfo pCreateInfo,
                                                      [NativeTypeName("const VkAllocationCallbacks *")]
                                                      in VkAllocationCallbacks pAllocator,
                                                      [NativeTypeName("VkFence *")] out VkFence pFence);
}
