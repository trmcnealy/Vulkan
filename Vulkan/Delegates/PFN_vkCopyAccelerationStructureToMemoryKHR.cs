using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCopyAccelerationStructureToMemoryKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                               [NativeTypeName("VkDeferredOperationKHR")]
                                                                               ref VkDeferredOperationKHR deferredOperation,
                                                                               [NativeTypeName("const VkCopyAccelerationStructureToMemoryInfoKHR *")]
                                                                               in VkCopyAccelerationStructureToMemoryInfoKHR pInfo);
}
