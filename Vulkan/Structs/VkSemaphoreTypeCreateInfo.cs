using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkSemaphoreTypeCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkSemaphoreType SemaphoreType;

        [NativeTypeName("uint64_t")] public ulong InitialValue;
    }
}
