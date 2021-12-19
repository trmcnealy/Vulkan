using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate VkResult PFN_vkGetDeferredOperationResultKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                 [NativeTypeName("VkDeferredOperationKHR")]
                                                                 ref VkDeferredOperationKHR operation);
}
