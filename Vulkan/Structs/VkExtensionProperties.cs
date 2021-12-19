using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkExtensionProperties
    {
        [NativeTypeName("char [256]")] public fixed sbyte ExtensionName[256];

        [NativeTypeName("uint32_t")] public uint SpecVersion;
        
        public utf8string ExtensionNameAsUtf8String()
        {
            fixed(sbyte* ptr = ExtensionName)
            {
                return new utf8string(ptr);
            }
        }
    }
}
