using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVariablePointersFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint VariablePointersStorageBuffer;

        [NativeTypeName("VkBool32")] public uint VariablePointers;
    }
}
