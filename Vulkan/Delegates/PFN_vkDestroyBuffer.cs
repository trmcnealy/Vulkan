using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyBuffer([NativeTypeName("VkDevice")]     VkDevice device,
                                                    [NativeTypeName("VkBuffer")] ref VkBuffer buffer,
                                                    [NativeTypeName("const VkAllocationCallbacks *")]
                                                    in VkAllocationCallbacks pAllocator);
}
