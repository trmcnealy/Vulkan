using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkCreateInstance([NativeTypeName("const VkInstanceCreateInfo *")] in VkInstanceCreateInfo pCreateInfo,
                                                         [NativeTypeName("const VkAllocationCallbacks *")]
                                                         in VkAllocationCallbacks pAllocator,
                                                         [NativeTypeName("VkInstance *")] ref VkInstance[] pInstance);
}
