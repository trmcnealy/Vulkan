using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdTraceRaysNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                              [NativeTypeName("VkBuffer")] ref    VkBuffer        raygenShaderBindingTableBuffer,
                                              [NativeTypeName("VkDeviceSize")]    ulong           raygenShaderBindingOffset,
                                              [NativeTypeName("VkBuffer")] ref    VkBuffer        missShaderBindingTableBuffer,
                                              [NativeTypeName("VkDeviceSize")]    ulong           missShaderBindingOffset,
                                              [NativeTypeName("VkDeviceSize")]    ulong           missShaderBindingStride,
                                              [NativeTypeName("VkBuffer")] ref    VkBuffer        hitShaderBindingTableBuffer,
                                              [NativeTypeName("VkDeviceSize")]    ulong           hitShaderBindingOffset,
                                              [NativeTypeName("VkDeviceSize")]    ulong           hitShaderBindingStride,
                                              [NativeTypeName("VkBuffer")] ref    VkBuffer        callableShaderBindingTableBuffer,
                                              [NativeTypeName("VkDeviceSize")]    ulong           callableShaderBindingOffset,
                                              [NativeTypeName("VkDeviceSize")]    ulong           callableShaderBindingStride,
                                              [NativeTypeName("uint32_t")]        uint            width,
                                              [NativeTypeName("uint32_t")]        uint            height,
                                              [NativeTypeName("uint32_t")]        uint            depth);
}
