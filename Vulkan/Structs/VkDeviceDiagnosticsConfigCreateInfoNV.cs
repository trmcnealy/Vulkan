using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceDiagnosticsConfigCreateInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkDeviceDiagnosticsConfigFlagsNV")]
        public uint Flags;
    }
}
