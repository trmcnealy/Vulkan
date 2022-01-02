using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkPhysicalDeviceDriverProperties
    {
        public VkStructureType SType;

        [NativeTypeName("void *")]
        public nint PNext;

        public VkDriverId DriverId;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> DriverName;

        [NativeTypeName("char [256]")]
        public utf8string<Const.UInt256> DriverInfo;

        public VkConformanceVersion ConformanceVersion;
        
        public utf8string DriverNameAsUtf8String()
        {
            //fixed(sbyte* ptr = DriverName)
            {
                return DriverName.ToString();
            }
        }
        
        public utf8string DriverInfoAsUtf8String()
        {
            //fixed(sbyte* ptr = DriverInfo)
            {
                return DriverInfo.ToString();
            }
        }
    }
}
