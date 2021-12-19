using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkCmdSetColorWriteEnableEXT([NativeTypeName("VkCommandBuffer")]  VkCommandBuffer commandBuffer,
                                                                [NativeTypeName("uint32_t")]         uint            attachmentCount,
                                                                [NativeTypeName("const VkBool32 *")] uint*           pColorWriteEnables);
}
