using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkMemoryDedicatedRequirements
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint PrefersDedicatedAllocation;

        [NativeTypeName("VkBool32")] public uint RequiresDedicatedAllocation;
    }
}
