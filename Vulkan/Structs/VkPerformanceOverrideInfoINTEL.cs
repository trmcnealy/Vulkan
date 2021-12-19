using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        public VkPerformanceOverrideTypeINTEL Type;

        [NativeTypeName("VkBool32")] public uint Enable;

        [NativeTypeName("uint64_t")] public ulong Parameter;
    }
}
