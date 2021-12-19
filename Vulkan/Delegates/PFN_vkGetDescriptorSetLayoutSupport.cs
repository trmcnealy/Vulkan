using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDescriptorSetLayoutSupport([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("const VkDescriptorSetLayoutCreateInfo *")]
                                                                    in VkDescriptorSetLayoutCreateInfo pCreateInfo,
                                                                    in VkDescriptorSetLayoutSupport pSupport);
}
