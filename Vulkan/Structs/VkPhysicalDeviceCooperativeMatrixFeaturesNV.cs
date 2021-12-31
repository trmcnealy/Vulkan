using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceCooperativeMatrixFeaturesNV
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint CooperativeMatrix;

        [NativeTypeName("Bool32")] public uint CooperativeMatrixRobustBufferAccess;
    }
}
