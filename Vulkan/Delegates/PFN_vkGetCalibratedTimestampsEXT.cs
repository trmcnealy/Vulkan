using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkGetCalibratedTimestampsEXT([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("uint32_t")] uint     timestampCount,
                                                                     [NativeTypeName("const VkCalibratedTimestampInfoEXT *")]
                                                                     VkCalibratedTimestampInfoEXT[] pTimestampInfos,
                                                                     [NativeTypeName("uint64_t *")] ulong[] pTimestamps,
                                                                     [NativeTypeName("uint64_t *")] in ulong pMaxDeviation);
}
