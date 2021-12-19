using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCopyAccelerationStructureKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                       [NativeTypeName("VkDeferredOperationKHR")]
                                                                       ref VkDeferredOperationKHR deferredOperation,
                                                                       [NativeTypeName("const VkCopyAccelerationStructureInfoKHR *")]
                                                                       in VkCopyAccelerationStructureInfoKHR pInfo);
}
