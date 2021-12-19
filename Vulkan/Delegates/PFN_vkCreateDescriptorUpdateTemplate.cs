using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDescriptorUpdateTemplate([NativeTypeName("VkDevice")] VkDevice device,
                                                                         [NativeTypeName("const VkDescriptorUpdateTemplateCreateInfo *")]
                                                                         in VkDescriptorUpdateTemplateCreateInfo pCreateInfo,
                                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                                         in VkAllocationCallbacks pAllocator,
                                                                         [NativeTypeName("VkDescriptorUpdateTemplate *")]
                                                                         ref VkDescriptorUpdateTemplate[] pDescriptorUpdateTemplate);
}
