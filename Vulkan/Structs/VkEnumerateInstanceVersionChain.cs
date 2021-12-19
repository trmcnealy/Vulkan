using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkEnumerateInstanceVersionChain
    {
        public VkChainHeader Header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceVersionChain *, uint32_t *) __attribute__((cdecl))")]
        public nint PfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceVersionChain *")]
        public VkEnumerateInstanceVersionChain* PNextLink;
    }
}
