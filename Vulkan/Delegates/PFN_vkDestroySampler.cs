using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroySampler([NativeTypeName("VkDevice")]      VkDevice  device,
                                                     [NativeTypeName("VkSampler")] ref VkSampler sampler,
                                                     [NativeTypeName("const VkAllocationCallbacks *")]
                                                     in VkAllocationCallbacks pAllocator);
}
