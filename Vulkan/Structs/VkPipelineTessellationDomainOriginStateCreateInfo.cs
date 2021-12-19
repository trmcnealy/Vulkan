using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPipelineTessellationDomainOriginStateCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkTessellationDomainOrigin DomainOrigin;
    }
}
