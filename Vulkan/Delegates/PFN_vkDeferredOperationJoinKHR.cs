using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkDeferredOperationJoinKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                            [NativeTypeName("VkDeferredOperationKHR")]
                                                            ref VkDeferredOperationKHR operation);
}
