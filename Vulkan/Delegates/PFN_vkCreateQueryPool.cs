using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateQueryPool([NativeTypeName("VkDevice")] VkDevice device,
                                                          [NativeTypeName("const VkQueryPoolCreateInfo *")]
                                                          in VkQueryPoolCreateInfo pCreateInfo,
                                                          [NativeTypeName("const VkAllocationCallbacks *")]
                                                          in VkAllocationCallbacks pAllocator,
                                                          [NativeTypeName("VkQueryPool *")] out VkQueryPool pQueryPool);
}
