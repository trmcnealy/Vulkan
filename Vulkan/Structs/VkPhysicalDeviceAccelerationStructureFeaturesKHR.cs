using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceAccelerationStructureFeaturesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint AccelerationStructure;

        [NativeTypeName("VkBool32")] public uint AccelerationStructureCaptureReplay;

        [NativeTypeName("VkBool32")] public uint AccelerationStructureIndirectBuild;

        [NativeTypeName("VkBool32")] public uint AccelerationStructureHostCommands;

        [NativeTypeName("VkBool32")] public uint DescriptorBindingAccelerationStructureUpdateAfterBind;
    }
}
