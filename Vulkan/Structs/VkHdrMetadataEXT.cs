using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkHdrMetadataEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkXYColorEXT DisplayPrimaryRed;

        public VkXYColorEXT DisplayPrimaryGreen;

        public VkXYColorEXT DisplayPrimaryBlue;

        public VkXYColorEXT WhitePoint;

        public float MaxLuminance;

        public float MinLuminance;

        public float MaxContentLightLevel;

        public float MaxFrameAverageLightLevel;
    }
}
