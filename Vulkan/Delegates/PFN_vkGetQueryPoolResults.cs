using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetQueryPoolResults([NativeTypeName("VkDevice")]           VkDevice    device,
                                                       [NativeTypeName("VkQueryPool")] ref    VkQueryPool queryPool,
                                                       [NativeTypeName("uint32_t")]           uint        firstQuery,
                                                       [NativeTypeName("uint32_t")]           uint        queryCount,
                                                       [NativeTypeName("size_t")]             nuint       dataSize,
                                                       [NativeTypeName("void *")]             nint        pData,
                                                       [NativeTypeName("VkDeviceSize")]       ulong       stride,
                                                       [NativeTypeName("VkQueryResultFlags")] uint        flags);
}
