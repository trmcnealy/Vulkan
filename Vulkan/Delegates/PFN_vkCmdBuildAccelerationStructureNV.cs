using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdBuildAccelerationStructureNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                                      [NativeTypeName("const VkAccelerationStructureInfoNV *")]
                                                                      in VkAccelerationStructureInfoNV pInfo,
                                                                      [NativeTypeName("VkBuffer")] ref VkBuffer instanceData,
                                                                      [NativeTypeName("VkDeviceSize")] ulong    instanceOffset,
                                                                      [NativeTypeName("VkBool32")]     uint     update,
                                                                      [NativeTypeName("VkAccelerationStructureNV")]
                                                                      ref VkAccelerationStructureNV dst,
                                                                      [NativeTypeName("VkAccelerationStructureNV")]
                                                                      ref VkAccelerationStructureNV src,
                                                                      [NativeTypeName("VkBuffer")] ref VkBuffer scratch,
                                                                      [NativeTypeName("VkDeviceSize")] ulong    scratchOffset);
}
