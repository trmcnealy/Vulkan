using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkSetHdrMetadataEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                        [NativeTypeName("uint32_t")] uint     swapchainCount,
                                                        [NativeTypeName("const VkSwapchainKHR *")]
                                                        ref VkSwapchainKHR[] pSwapchains,
                                                        [NativeTypeName("const VkHdrMetadataEXT *")]
                                                        in VkHdrMetadataEXT pMetadata);
}
