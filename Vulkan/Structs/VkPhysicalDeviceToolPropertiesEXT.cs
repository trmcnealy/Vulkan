using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> Name;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> Version;

        [NativeTypeName("VkToolPurposeFlagsEXT")]
        public uint Purposes;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> Description;

        [NativeTypeName("char [256]")] public utf8string<Const.UInt256> Layer;
        
        public utf8string NameAsUtf8String()
        {
            //fixed(sbyte* ptr = Name)
            {
                return Name.ToString();
            }
        }
        
        public utf8string VersionAsUtf8String()
        {
            //fixed(sbyte* ptr = Version)
            {
                return Version.ToString();
            }
        }
        
        public utf8string DescriptionAsUtf8String()
        {
            //fixed(sbyte* ptr = Description)
            {
                return Description.ToString();
            }
        }
        
        public utf8string LayerAsUtf8String()
        {
            //fixed(sbyte* ptr = Layer)
            {
                return Layer.ToString();
            }
        }
    }
}
