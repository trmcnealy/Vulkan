using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                      "void *")]
    public delegate nint PFN_vkAllocationFunction([NativeTypeName("void *")] nint  pUserData,
                                                  [NativeTypeName("size_t")] nuint size,
                                                  [NativeTypeName("size_t")] nuint alignment,
                                                  VkSystemAllocationScope          allocationScope);
}
