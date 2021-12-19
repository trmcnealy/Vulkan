using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDescriptorPool([NativeTypeName("VkDevice")] VkDevice device,
                                                               [NativeTypeName("const VkDescriptorPoolCreateInfo *")]
                                                               in VkDescriptorPoolCreateInfo pCreateInfo,
                                                               [NativeTypeName("const VkAllocationCallbacks *")]
                                                               in VkAllocationCallbacks pAllocator,
                                                               [NativeTypeName("VkDescriptorPool *")] ref VkDescriptorPool[] pDescriptorPool);
}
