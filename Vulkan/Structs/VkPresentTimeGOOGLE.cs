using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPresentTimeGOOGLE
    {
        [NativeTypeName("uint32_t")] public uint PresentId;

        [NativeTypeName("uint64_t")] public ulong DesiredPresentTime;
    }
}
