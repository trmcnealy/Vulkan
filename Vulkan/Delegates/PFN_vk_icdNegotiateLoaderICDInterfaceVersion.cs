using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vk_icdNegotiateLoaderICDInterfaceVersion([NativeTypeName("uint32_t *")] uint[] pVersion);
}
