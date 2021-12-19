using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdWriteAccelerationStructuresPropertiesKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                                  [NativeTypeName("uint32_t")]        uint            accelerationStructureCount,
                                                                                  [NativeTypeName("const VkAccelerationStructureKHR *")]
                                                                                  ref VkAccelerationStructureKHR[] pAccelerationStructures,
                                                                                  VkQueryType                                     queryType,
                                                                                  [NativeTypeName("VkQueryPool")] ref VkQueryPool queryPool,
                                                                                  [NativeTypeName("uint32_t")]        uint        firstQuery);
}
