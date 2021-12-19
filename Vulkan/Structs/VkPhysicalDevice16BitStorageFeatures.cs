using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint StorageBuffer16BitAccess;

        [NativeTypeName("VkBool32")] public uint UniformAndStorageBuffer16BitAccess;

        [NativeTypeName("VkBool32")] public uint StoragePushConstant16;

        [NativeTypeName("VkBool32")] public uint StorageInputOutput16;
    }
}
