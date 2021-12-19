using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkDestroyCuModuleNVX([NativeTypeName("VkDevice")]          VkDevice      device,
                                                         [NativeTypeName("VkCuModuleNVX")] ref VkCuModuleNVX module,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator);
}
