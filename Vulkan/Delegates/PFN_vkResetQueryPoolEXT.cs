using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkResetQueryPoolEXT([NativeTypeName("VkDevice")]        VkDevice    device,
                                                 [NativeTypeName("VkQueryPool")] ref VkQueryPool queryPool,
                                                 [NativeTypeName("uint32_t")]        uint        firstQuery,
                                                 [NativeTypeName("uint32_t")]        uint        queryCount);
}
