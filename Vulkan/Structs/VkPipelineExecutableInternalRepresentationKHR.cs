using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Name;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> Description;

        [NativeTypeName("Bool32")] public uint IsText;

        [NativeTypeName("size_t")] public nuint DataSize;

        [NativeTypeName("void *")] public nint PData;
        
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
