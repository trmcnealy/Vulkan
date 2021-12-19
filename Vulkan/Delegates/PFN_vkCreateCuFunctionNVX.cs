using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateCuFunctionNVX([NativeTypeName("VkDevice")] VkDevice device,
                                                              [NativeTypeName("const VkCuFunctionCreateInfoNVX *")]
                                                              in VkCuFunctionCreateInfoNVX pCreateInfo,
                                                              [NativeTypeName("const VkAllocationCallbacks *")]
                                                              in VkAllocationCallbacks pAllocator,
                                                              [NativeTypeName("VkCuFunctionNVX *")] ref VkCuFunctionNVX pFunction);
}
