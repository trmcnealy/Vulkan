using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRefreshCycleDurationGOOGLE
    {
        [NativeTypeName("uint64_t")] public ulong RefreshDuration;
    }
}
