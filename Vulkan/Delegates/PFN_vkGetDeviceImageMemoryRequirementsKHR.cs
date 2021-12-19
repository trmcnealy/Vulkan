using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceImageMemoryRequirementsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                          [NativeTypeName("const VkDeviceImageMemoryRequirementsKHR *")]
                                                                          in VkDeviceImageMemoryRequirementsKHR pInfo,
                                                                          VkMemoryRequirements2[] pMemoryRequirements);
}
