using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkEnumerateInstanceVersion([NativeTypeName("uint32_t *")] uint[] pApiVersion);
}
