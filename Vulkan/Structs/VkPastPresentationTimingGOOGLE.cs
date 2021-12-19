using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPastPresentationTimingGOOGLE
    {
        [NativeTypeName("uint32_t")] public uint PresentId;

        [NativeTypeName("uint64_t")] public ulong DesiredPresentTime;

        [NativeTypeName("uint64_t")] public ulong ActualPresentTime;

        [NativeTypeName("uint64_t")] public ulong EarliestPresentTime;

        [NativeTypeName("uint64_t")] public ulong PresentMargin;
    }
}
