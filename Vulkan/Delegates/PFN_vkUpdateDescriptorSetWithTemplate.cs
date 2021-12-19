using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkUpdateDescriptorSetWithTemplate([NativeTypeName("VkDevice")]            VkDevice        device,
                                                               [NativeTypeName("VkDescriptorSet")] ref VkDescriptorSet descriptorSet,
                                                               [NativeTypeName("VkDescriptorUpdateTemplate")]
                                                               ref VkDescriptorUpdateTemplate descriptorUpdateTemplate,
                                                               [NativeTypeName("const void *")] nint pData);
}
