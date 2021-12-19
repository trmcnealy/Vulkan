using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetAccelerationStructureHandleNV([NativeTypeName("VkDevice")] VkDevice device,
                                                                    [NativeTypeName("VkAccelerationStructureNV")]
                                                                    ref VkAccelerationStructureNV accelerationStructure,
                                                                    [NativeTypeName("size_t")] nuint dataSize,
                                                                    [NativeTypeName("void *")] nint  pData);
}
