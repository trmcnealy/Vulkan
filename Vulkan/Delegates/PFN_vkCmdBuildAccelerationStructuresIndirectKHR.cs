using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBuildAccelerationStructuresIndirectKHR([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                                [NativeTypeName("uint32_t")]        uint            infoCount,
                                                                                [NativeTypeName("const VkAccelerationStructureBuildGeometryInfoKHR *")]
                                                                                VkAccelerationStructureBuildGeometryInfoKHR[] pInfos,
                                                                                [NativeTypeName("const VkDeviceAddress *")]
                                                                                ulong[] pIndirectDeviceAddresses,
                                                                                [NativeTypeName("const uint32_t *")] uint[] pIndirectStrides,
                                                                                [NativeTypeName("const uint32_t *const *")]
                                                                                uint** ppMaxPrimitiveCounts);
}
