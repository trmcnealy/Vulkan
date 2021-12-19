using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkSignalSemaphoreKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                             [NativeTypeName("const VkSemaphoreSignalInfo *")]
                                                             in VkSemaphoreSignalInfo pSignalInfo);
}
