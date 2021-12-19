using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyDevice([NativeTypeName("VkDevice")] VkDevice device,
                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                    in VkAllocationCallbacks pAllocator);
}
