using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkFreeDescriptorSets([NativeTypeName("VkDevice")]             VkDevice         device,
                                                             [NativeTypeName("VkDescriptorPool")] ref VkDescriptorPool descriptorPool,
                                                             [NativeTypeName("uint32_t")]             uint             descriptorSetCount,
                                                             [NativeTypeName("const VkDescriptorSet *")]
                                                             ref VkDescriptorSet[] pDescriptorSets);
}
