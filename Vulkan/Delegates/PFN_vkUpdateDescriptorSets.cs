using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkUpdateDescriptorSets([NativeTypeName("VkDevice")] VkDevice device,
                                                           [NativeTypeName("uint32_t")] uint     descriptorWriteCount,
                                                           [NativeTypeName("const VkWriteDescriptorSet *")]
                                                           VkWriteDescriptorSet[] pDescriptorWrites,
                                                           [NativeTypeName("uint32_t")] uint descriptorCopyCount,
                                                           [NativeTypeName("const VkCopyDescriptorSet *")]
                                                           VkCopyDescriptorSet[] pDescriptorCopies);
}
