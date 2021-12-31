using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkFilterCubicImageViewImageFormatPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint FilterCubic;

        [NativeTypeName("Bool32")] public uint FilterCubicMinmax;
    }
}
