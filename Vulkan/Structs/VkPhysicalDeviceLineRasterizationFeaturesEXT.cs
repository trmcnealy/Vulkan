using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint RectangularLines;

        [NativeTypeName("VkBool32")] public uint BresenhamLines;

        [NativeTypeName("VkBool32")] public uint SmoothLines;

        [NativeTypeName("VkBool32")] public uint StippledRectangularLines;

        [NativeTypeName("VkBool32")] public uint StippledBresenhamLines;

        [NativeTypeName("VkBool32")] public uint StippledSmoothLines;
    }
}
