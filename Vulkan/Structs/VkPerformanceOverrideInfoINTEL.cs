using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPerformanceOverrideInfoINTEL
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkPerformanceOverrideTypeINTEL Type;

        [NativeTypeName("Bool32")] public uint Enable;

        [NativeTypeName("uint64_t")] public ulong Parameter;
    }
}
