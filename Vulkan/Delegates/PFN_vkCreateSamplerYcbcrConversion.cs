using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateSamplerYcbcrConversion([NativeTypeName("VkDevice")] VkDevice device,
                                                                       [NativeTypeName("const VkSamplerYcbcrConversionCreateInfo *")]
                                                                       in VkSamplerYcbcrConversionCreateInfo pCreateInfo,
                                                                       [NativeTypeName("const VkAllocationCallbacks *")]
                                                                       in VkAllocationCallbacks pAllocator,
                                                                       [NativeTypeName("VkSamplerYcbcrConversion *")]
                                                                       ref VkSamplerYcbcrConversion[] pYcbcrConversion);
}
