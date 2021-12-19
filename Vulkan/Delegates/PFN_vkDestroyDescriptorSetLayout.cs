using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDescriptorSetLayout([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("VkDescriptorSetLayout")]
                                                                 ref VkDescriptorSetLayout descriptorSetLayout,
                                                                 [NativeTypeName("const VkAllocationCallbacks *")]
                                                                 in VkAllocationCallbacks pAllocator);
}
