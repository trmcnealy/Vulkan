using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint AccelerationStructure;

        [NativeTypeName("Bool32")] public uint AccelerationStructureCaptureReplay;

        [NativeTypeName("Bool32")] public uint AccelerationStructureIndirectBuild;

        [NativeTypeName("Bool32")] public uint AccelerationStructureHostCommands;

        [NativeTypeName("Bool32")] public uint DescriptorBindingAccelerationStructureUpdateAfterBind;
    }
}
