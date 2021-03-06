using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint VariablePointersStorageBuffer;

        [NativeTypeName("Bool32")] public uint VariablePointers;
    }
}
