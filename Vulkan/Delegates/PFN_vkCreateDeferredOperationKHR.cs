using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateDeferredOperationKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("const VkAllocationCallbacks *")]
                                                                     in VkAllocationCallbacks pAllocator,
                                                                     [NativeTypeName("VkDeferredOperationKHR *")]
                                                                     out VkDeferredOperationKHR pDeferredOperation);
}
