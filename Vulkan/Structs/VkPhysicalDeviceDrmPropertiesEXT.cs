using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceDrmPropertiesEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint HasPrimary;

        [NativeTypeName("Bool32")] public uint HasRender;

        [NativeTypeName("int64_t")] public long PrimaryMajor;

        [NativeTypeName("int64_t")] public long PrimaryMinor;

        [NativeTypeName("int64_t")] public long RenderMajor;

        [NativeTypeName("int64_t")] public long RenderMinor;
    }
}
