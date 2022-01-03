using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceVulkan11Features
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint StorageBuffer16BitAccess;

        [NativeTypeName("Bool32")] public uint UniformAndStorageBuffer16BitAccess;

        [NativeTypeName("Bool32")] public uint StoragePushConstant16;

        [NativeTypeName("Bool32")] public uint StorageInputOutput16;

        [NativeTypeName("Bool32")] public uint Multiview;

        [NativeTypeName("Bool32")] public uint MultiviewGeometryShader;

        [NativeTypeName("Bool32")] public uint MultiviewTessellationShader;

        [NativeTypeName("Bool32")] public uint VariablePointersStorageBuffer;

        [NativeTypeName("Bool32")] public uint VariablePointers;

        [NativeTypeName("Bool32")] public uint ProtectedMemory;

        [NativeTypeName("Bool32")] public uint SamplerYcbcrConversion;

        [NativeTypeName("Bool32")] public uint ShaderDrawParameters;
    }
}
