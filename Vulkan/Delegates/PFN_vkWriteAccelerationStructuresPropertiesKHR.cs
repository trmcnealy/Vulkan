using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                                   [NativeTypeName("uint32_t")] uint     accelerationStructureCount,
                                                                                   [NativeTypeName("const VkAccelerationStructureKHR *")]
                                                                                   ref VkAccelerationStructureKHR[] pAccelerationStructures,
                                                                                   VkQueryType                      queryType,
                                                                                   [NativeTypeName("size_t")] nuint dataSize,
                                                                                   [NativeTypeName("void *")] nint  pData,
                                                                                   [NativeTypeName("size_t")] nuint stride);
}
