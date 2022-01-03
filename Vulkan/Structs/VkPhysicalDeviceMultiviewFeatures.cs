using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceMultiviewFeatures
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nuint PNext;

        [NativeTypeName("Bool32")] public uint Multiview;

        [NativeTypeName("Bool32")] public uint MultiviewGeometryShader;

        [NativeTypeName("Bool32")] public uint MultiviewTessellationShader;
    }
}
