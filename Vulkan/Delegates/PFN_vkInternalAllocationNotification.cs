using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkInternalAllocationNotification([NativeTypeName("void *")] nint  pUserData,
                                                              [NativeTypeName("size_t")] nuint size,
                                                              VkInternalAllocationType         allocationType,
                                                              VkSystemAllocationScope          allocationScope);
}
