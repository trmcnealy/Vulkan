using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceLineRasterizationFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint RectangularLines;

        [NativeTypeName("Bool32")] public uint BresenhamLines;

        [NativeTypeName("Bool32")] public uint SmoothLines;

        [NativeTypeName("Bool32")] public uint StippledRectangularLines;

        [NativeTypeName("Bool32")] public uint StippledBresenhamLines;

        [NativeTypeName("Bool32")] public uint StippledSmoothLines;
    }
}
