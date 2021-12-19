using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetBufferMemoryRequirements([NativeTypeName("VkDevice")]     VkDevice device,
                                                                  [NativeTypeName("VkBuffer")] ref VkBuffer buffer,
                                                                  VkMemoryRequirements*                     pMemoryRequirements);
}
