using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkBindImageMemory2KHR([NativeTypeName("VkDevice")] VkDevice device,
                                                              [NativeTypeName("uint32_t")] uint     bindInfoCount,
                                                              [NativeTypeName("const VkBindImageMemoryInfo *")]
                                                              VkBindImageMemoryInfo[] pBindInfos);
}
