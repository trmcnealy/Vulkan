using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDeviceMemoryReportCallbackDataEXT
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkDeviceMemoryReportFlagsEXT")]
        public uint Flags;

        public VkDeviceMemoryReportEventTypeEXT Type;

        [NativeTypeName("uint64_t")] public ulong MemoryObjectId;

        [NativeTypeName("ulong")] public ulong Size;

        public VkObjectType ObjectType;

        [NativeTypeName("uint64_t")] public ulong ObjectHandle;

        [NativeTypeName("uint32_t")] public uint HeapIndex;
    }
}
