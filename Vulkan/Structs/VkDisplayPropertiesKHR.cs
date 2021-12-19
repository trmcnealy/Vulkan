using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDisplayPropertiesKHR
    {
        [NativeTypeName("VkDisplayKHR")] public VkDisplayKHR Display;

        [NativeTypeName("const char *")] 
        public utf8string DisplayName;

        public VkExtent2D PhysicalDimensions;

        public VkExtent2D PhysicalResolution;

        [NativeTypeName("VkSurfaceTransformFlagsKHR")]
        public uint SupportedTransforms;

        [NativeTypeName("VkBool32")] public uint PlaneReorderPossible;

        [NativeTypeName("VkBool32")] public uint PersistentContent;
    }
}
