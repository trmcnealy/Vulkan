using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryDedicatedRequirements
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint PrefersDedicatedAllocation;

        [NativeTypeName("Bool32")] public uint RequiresDedicatedAllocation;
    }
}
