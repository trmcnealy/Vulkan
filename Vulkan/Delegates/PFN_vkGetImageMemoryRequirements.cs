using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetImageMemoryRequirements([NativeTypeName("VkDevice")]    VkDevice device,
                                                                 [NativeTypeName("VkImage")] ref VkImage  image,
                                                                 VkMemoryRequirements*                    pMemoryRequirements);
}
