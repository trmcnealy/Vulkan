using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceQueue2([NativeTypeName("VkDevice")] VkDevice device,
                                                      [NativeTypeName("const VkDeviceQueueInfo2 *")]
                                                      in VkDeviceQueueInfo2 pQueueInfo,
                                                      [NativeTypeName("VkQueue *")] out VkQueue pQueue);
}
