using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkAllocateDescriptorSets([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("const VkDescriptorSetAllocateInfo *")]
                                                                 in VkDescriptorSetAllocateInfo pAllocateInfo,
                                                                 [NativeTypeName("VkDescriptorSet *")] ref VkDescriptorSet[] pDescriptorSets);
}
