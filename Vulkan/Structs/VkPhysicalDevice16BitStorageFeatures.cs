using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDevice16BitStorageFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint StorageBuffer16BitAccess;

        [NativeTypeName("Bool32")] public uint UniformAndStorageBuffer16BitAccess;

        [NativeTypeName("Bool32")] public uint StoragePushConstant16;

        [NativeTypeName("Bool32")] public uint StorageInputOutput16;
    }
}
