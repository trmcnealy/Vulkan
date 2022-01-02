using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkShaderStageFlags")] public uint Stages;
        
        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Name;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Description;

        [NativeTypeName("uint32_t")] public uint SubgroupSize;
        
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
