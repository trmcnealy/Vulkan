using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint StorageBuffer16BitAccess;

        [NativeTypeName("VkBool32")] public uint UniformAndStorageBuffer16BitAccess;

        [NativeTypeName("VkBool32")] public uint StoragePushConstant16;

        [NativeTypeName("VkBool32")] public uint StorageInputOutput16;

        [NativeTypeName("VkBool32")] public uint Multiview;

        [NativeTypeName("VkBool32")] public uint MultiviewGeometryShader;

        [NativeTypeName("VkBool32")] public uint MultiviewTessellationShader;

        [NativeTypeName("VkBool32")] public uint VariablePointersStorageBuffer;

        [NativeTypeName("VkBool32")] public uint VariablePointers;

        [NativeTypeName("VkBool32")] public uint ProtectedMemory;

        [NativeTypeName("VkBool32")] public uint SamplerYcbcrConversion;

        [NativeTypeName("VkBool32")] public uint ShaderDrawParameters;
    }
}
