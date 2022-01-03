using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice4444FormatsFeaturesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint FormatA4R4G4B4;

        [NativeTypeName("Bool32")] public uint FormatA4B4G4R4;
    }
}
