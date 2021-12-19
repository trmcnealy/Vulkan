using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate VkResult PFN_vkNegotiateLoaderICDInterfaceVersion([NativeTypeName("uint32_t *")] uint[] pVersion);
}
