using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice8BitStorageFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint StorageBuffer8BitAccess;

        [NativeTypeName("VkBool32")] public uint UniformAndStorageBuffer8BitAccess;

        [NativeTypeName("VkBool32")] public uint StoragePushConstant8;
    }
}
