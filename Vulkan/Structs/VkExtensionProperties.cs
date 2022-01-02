using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkExtensionProperties
    {
        [NativeTypeName("char [256]")]
        //public fixed sbyte ExtensionName[256];
        public utf8string<Const.UInt256> ExtensionName;

        [NativeTypeName("uint32_t")]
        public uint SpecVersion;
        
        public utf8string ExtensionNameAsUtf8String()
        {
            //fixed(sbyte* ptr = ExtensionName)
            //{
            //    return new utf8string(ptr);
            //}
            return ExtensionName.ToString();
        }
    }
}
