using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDescriptorUpdateTemplateKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                         [NativeTypeName("VkDescriptorUpdateTemplate")]
                                                                         ref VkDescriptorUpdateTemplate descriptorUpdateTemplate,
                                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                                         in VkAllocationCallbacks pAllocator);
}
