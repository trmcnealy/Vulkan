using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPerformanceCounterDescriptionKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkPerformanceCounterDescriptionFlagsKHR")]
        public uint Flags;

        [NativeTypeName("char [256]")] public fixed sbyte Name[256];

        [NativeTypeName("char [256]")] public fixed sbyte Category[256];

        [NativeTypeName("char [256]")] public fixed sbyte Description[256];
		
		public utf8string NameAsUtf8String()
        {
            fixed(sbyte* ptr = Name)
            {
                return new utf8string(ptr);
            }
        }
		
		public utf8string CategoryAsUtf8String()
        {
            fixed(sbyte* ptr = Category)
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
