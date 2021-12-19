using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        public VkDriverId DriverId;

        [NativeTypeName("char [256]")] public fixed sbyte DriverName[256];

        [NativeTypeName("char [256]")] public fixed sbyte DriverInfo[256];

        public VkConformanceVersion ConformanceVersion;
		
		public utf8string DriverNameAsUtf8String()
        {
            fixed(sbyte* ptr = DriverName)
            {
                return new utf8string(ptr);
            }
        }
		
		public utf8string DriverInfoAsUtf8String()
        {
            fixed(sbyte* ptr = DriverInfo)
            {
                return new utf8string(ptr);
            }
        }
    }
}
