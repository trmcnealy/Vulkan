using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceBorderColorSwizzleFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint BorderColorSwizzle;

        [NativeTypeName("Bool32")] public uint BorderColorSwizzleFromImage;
    }
}
