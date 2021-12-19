using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineExecutablePropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkShaderStageFlags")] public uint Stages;

        [NativeTypeName("char [256]")] public fixed sbyte Name[256];

        [NativeTypeName("char [256]")] public fixed sbyte Description[256];

        [NativeTypeName("uint32_t")] public uint SubgroupSize;
        
        public utf8string NameAsUtf8String()
        {
            fixed(sbyte* ptr = Name)
            {
                return new utf8string(ptr);
            }
        }	
        
        public utf8string DescriptionAsUtf8String()
        {
            fixed(sbyte* ptr = Description)
            {
                return new utf8string(ptr);
            }
        }
    }
}
