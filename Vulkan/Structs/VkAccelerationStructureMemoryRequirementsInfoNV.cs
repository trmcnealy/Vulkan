using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkAccelerationStructureMemoryRequirementsInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkAccelerationStructureMemoryRequirementsTypeNV Type;

        [NativeTypeName("VkAccelerationStructureNV")]
        public VkAccelerationStructureNV AccelerationStructure;
    }
}
