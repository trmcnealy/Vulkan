using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFN_vkCmdSetBlendConstants([NativeTypeName("VkCommandBuffer")] VkCommandBuffer commandBuffer,
                                                    [NativeTypeName("const float [4]")] [MarshalAs(UnmanagedType.LPArray, SizeConst = 4)]
                                                    float[] blendConstants);
}
