using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName(                                                         "uint32_t")]
    public delegate uint PFN_vkGetDeferredOperationMaxConcurrencyKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                     [NativeTypeName("VkDeferredOperationKHR")]
                                                                     ref VkDeferredOperationKHR operation);
}
