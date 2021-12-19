using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCopyMemoryToAccelerationStructureKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                               [NativeTypeName("VkDeferredOperationKHR")]
                                                                               ref VkDeferredOperationKHR deferredOperation,
                                                                               [NativeTypeName("const VkCopyMemoryToAccelerationStructureInfoKHR *")]
                                                                               in VkCopyMemoryToAccelerationStructureInfoKHR pInfo);
}
