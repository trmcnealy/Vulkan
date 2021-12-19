using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkFlushMappedMemoryRanges([NativeTypeName("VkDevice")] VkDevice device,
                                                                  [NativeTypeName("uint32_t")] uint     memoryRangeCount,
                                                                  [NativeTypeName("const VkMappedMemoryRange *")]
                                                                  VkMappedMemoryRange[] pMemoryRanges);
}
