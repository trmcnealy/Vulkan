using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                        "void *")]
    public delegate nint PFN_vkReallocationFunction([NativeTypeName("void *")] nint  pUserData,
                                                    [NativeTypeName("void *")] nint  pOriginal,
                                                    [NativeTypeName("size_t")] nuint size,
                                                    [NativeTypeName("size_t")] nuint alignment,
                                                    VkSystemAllocationScope          allocationScope);
}
