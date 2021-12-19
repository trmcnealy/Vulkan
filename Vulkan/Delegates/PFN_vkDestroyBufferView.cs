using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyBufferView([NativeTypeName("VkDevice")]         VkDevice     device,
                                                        [NativeTypeName("VkBufferView")] ref VkBufferView bufferView,
                                                        [NativeTypeName("const VkAllocationCallbacks *")]
                                                        in VkAllocationCallbacks pAllocator);
}
