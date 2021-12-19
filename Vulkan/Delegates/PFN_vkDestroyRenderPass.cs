using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyRenderPass([NativeTypeName("VkDevice")]         VkDevice     device,
                                                        [NativeTypeName("VkRenderPass")] ref VkRenderPass renderPass,
                                                        [NativeTypeName("const VkAllocationCallbacks *")]
                                                        in VkAllocationCallbacks pAllocator);
}
