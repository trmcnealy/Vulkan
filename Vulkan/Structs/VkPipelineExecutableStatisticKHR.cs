using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineExecutableStatisticKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;
        
        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Name;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Description;

        public VkPipelineExecutableStatisticFormatKHR Format;

        public VkPipelineExecutableStatisticValueKHR Value;
        
        public utf8string NameAsUtf8String()
        {
            //fixed(sbyte* ptr = Name)
            {
                return Name.ToString();
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
