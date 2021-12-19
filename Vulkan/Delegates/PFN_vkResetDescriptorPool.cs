using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkResetDescriptorPool([NativeTypeName("VkDevice")]             VkDevice         device,
                                                       [NativeTypeName("VkDescriptorPool")] ref VkDescriptorPool descriptorPool,
                                                       [NativeTypeName("VkDescriptorPoolResetFlags")]
                                                       uint flags);
}
