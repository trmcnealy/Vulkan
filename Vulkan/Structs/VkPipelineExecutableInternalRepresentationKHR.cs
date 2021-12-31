using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPipelineExecutableInternalRepresentationKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("char [256]")] public fixed sbyte Name[256];

        [NativeTypeName("char [256]")] public fixed sbyte Description[256];

        [NativeTypeName("Bool32")] public uint IsText;

        [NativeTypeName("size_t")] public nuint DataSize;

        [NativeTypeName("void *")] public nint PData;
        
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
