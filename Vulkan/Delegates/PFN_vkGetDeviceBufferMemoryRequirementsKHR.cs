using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceBufferMemoryRequirementsKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                           [NativeTypeName("const VkDeviceBufferMemoryRequirementsKHR *")]
                                                                           in VkDeviceBufferMemoryRequirementsKHR pInfo,
                                                                           VkMemoryRequirements2[] pMemoryRequirements);
}
