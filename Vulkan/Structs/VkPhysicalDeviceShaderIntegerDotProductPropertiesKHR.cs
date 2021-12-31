using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkPhysicalDeviceShaderIntegerDotProductPropertiesKHR
    {
        public VkStructureType SType;

        [NativeTypeName("void *")] public nint PNext;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct8BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct8BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct8BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct4X8BitPackedUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct4X8BitPackedSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct4X8BitPackedMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct16BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct16BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct16BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct32BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct32BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct32BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct64BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct64BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProduct64BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating8BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating8BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating8BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating4X8BitPackedMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating16BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating16BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating16BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating32BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating32BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating32BitMixedSignednessAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating64BitUnsignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating64BitSignedAccelerated;

        [NativeTypeName("Bool32")] public uint IntegerDotProductAccumulatingSaturating64BitMixedSignednessAccelerated;
    }
}
