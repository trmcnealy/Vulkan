using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroySamplerYcbcrConversion([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("VkSamplerYcbcrConversion")]
                                                                    ref VkSamplerYcbcrConversion ycbcrConversion,
                                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                                    in VkAllocationCallbacks pAllocator);
}
