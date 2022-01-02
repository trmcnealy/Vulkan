using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")]
        public nint PNext;

        [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
        public uint Flags;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Name;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Category;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Description;
        
        public utf8string NameAsUtf8String()
        {
            //fixed(sbyte* ptr = Name)
            {
                return Name.ToString();
            }
        }
        
        public utf8string CategoryAsUtf8String()
        {
            //fixed(sbyte* ptr = Category)
            {
                return Category.ToString();
            }
        }
        
        public utf8string DescriptionAsUtf8String()
        {
            //fixed(sbyte* ptr = Description)
            {
                return Description.ToString();
            }
        }
    }
}
