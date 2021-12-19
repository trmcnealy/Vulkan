using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetLineStippleEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                    [NativeTypeName("uint32_t")]        uint            lineStippleFactor,
                                                    [NativeTypeName("uint16_t")]        ushort          lineStipplePattern);
}
