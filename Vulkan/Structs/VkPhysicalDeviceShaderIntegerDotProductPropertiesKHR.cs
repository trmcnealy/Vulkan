using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct8BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct8BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct8BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct4X8BitPackedUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct4X8BitPackedSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct4X8BitPackedMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct16BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct16BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct16BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct32BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct32BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct32BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct64BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct64BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProduct64BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;

        [NativeTypeName("VkBool32")] public uint IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    }
}
