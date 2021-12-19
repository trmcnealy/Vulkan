using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkEnumerateInstanceExtensionPropertiesChain
    {
        public VkChainHeader Header;

        [NativeTypeName("VkResult (*)(const struct VkEnumerateInstanceExtensionPropertiesChain *, const char *, uint32_t *, VkExtensionProperties *) __attribute__((cdecl))")]
        public nint PfnNextLayer;

        [NativeTypeName("const struct VkEnumerateInstanceExtensionPropertiesChain *")]
        public VkEnumerateInstanceExtensionPropertiesChain* PNextLink;
    }
}
