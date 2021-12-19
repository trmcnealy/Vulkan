using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetFrontFaceEXT([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                  VkFrontFace                                         frontFace);
}
