using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdDrawMeshTasksNV([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                  [NativeTypeName("uint32_t")]        uint            taskCount,
                                                  [NativeTypeName("uint32_t")]        uint            firstTask);
}
