using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDescriptorPool([NativeTypeName("VkDevice")]             VkDevice         device,
                                                            [NativeTypeName("VkDescriptorPool")] ref VkDescriptorPool descriptorPool,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator);
}
