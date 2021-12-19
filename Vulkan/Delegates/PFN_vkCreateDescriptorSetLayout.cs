using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDescriptorSetLayout([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")]
                                                                    in VkDescriptorSetLayoutCreateInfo pCreateInfo,
                                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                                    in VkAllocationCallbacks pAllocator,
                                                                    [NativeTypeName("VkDescriptorSetLayout *")]
                                                                    out VkDescriptorSetLayout pSetLayout);
}
