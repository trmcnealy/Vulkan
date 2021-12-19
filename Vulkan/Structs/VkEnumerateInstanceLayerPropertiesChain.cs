using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkEnumerateInstanceLayerPropertiesChain
    {
        public VkChainHeader Header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceLayerPropertiesChain *, uint32_t *, VkLayerProperties *) __attribute__((cdecl))")]
        public nint PfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceLayerPropertiesChain *")]
        public VkEnumerateInstanceLayerPropertiesChain* PNextLink;
    }
}
