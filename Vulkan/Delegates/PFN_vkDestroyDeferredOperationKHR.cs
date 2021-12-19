using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDeferredOperationKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                  [NativeTypeName("VkDeferredOperationKHR")]
                                                                  ref VkDeferredOperationKHR operation,
                                                                  [NativeTypeName("const VkAllocationCallbacks *")]
                                                                  in VkAllocationCallbacks pAllocator);
}
