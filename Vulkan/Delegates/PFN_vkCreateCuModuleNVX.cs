using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateCuModuleNVX([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("const VkCuModuleCreateInfoNVX *")]
                                                            in VkCuModuleCreateInfoNVX pCreateInfo,
                                                            [NativeTypeName("const VkAllocationCallbacks *")]
                                                            in VkAllocationCallbacks pAllocator,
                                                            [NativeTypeName("VkCuModuleNVX *")] out VkCuModuleNVX pModule);
}
