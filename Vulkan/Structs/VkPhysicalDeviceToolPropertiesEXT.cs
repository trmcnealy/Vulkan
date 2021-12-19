using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceToolPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("char [256]")] public fixed sbyte Name[256];

        [NativeTypeName("char [256]")] public fixed sbyte Version[256];

        [NativeTypeName("VkToolPurposeFlagsEXT")]
        public uint Purposes;

        [NativeTypeName("char [256]")] public fixed sbyte Description[256];

        [NativeTypeName("char [256]")] public fixed sbyte Layer[256];
		
		public utf8string NameAsUtf8String()
        {
            fixed(sbyte* ptr = Name)
            {
                return new utf8string(ptr);
            }
        }
		
		public utf8string VersionAsUtf8String()
        {
            fixed(sbyte* ptr = Version)
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
		
		public utf8string LayerAsUtf8String()
        {
            fixed(sbyte* ptr = Layer)
            {
                return new utf8string(ptr);
            }
        }
    }
}
