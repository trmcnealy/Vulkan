using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetCheckpointNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                  [NativeTypeName("const void *")]    nint            pCheckpointMarker);
}
