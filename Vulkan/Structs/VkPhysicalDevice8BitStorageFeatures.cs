using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint StorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public uint UniformAndStorageBuffer8BitAccess;

        [NativeTypeName("Bool32")] public uint StoragePushConstant8;
    }
}
