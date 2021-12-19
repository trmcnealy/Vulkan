using System;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkCuLaunchInfoNVX
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkCuFunctionNVX")] public VkCuFunctionNVX Function;

        [NativeTypeName("uint32_t")] public uint GridDimX;

        [NativeTypeName("uint32_t")] public uint GridDimY;

        [NativeTypeName("uint32_t")] public uint GridDimZ;

        [NativeTypeName("uint32_t")] public uint BlockDimX;

        [NativeTypeName("uint32_t")] public uint BlockDimY;

        [NativeTypeName("uint32_t")] public uint BlockDimZ;

        [NativeTypeName("uint32_t")] public uint SharedMemBytes;

        [NativeTypeName("size_t")] public nuint ParamCount;

        [NativeTypeName("const void *const *")]
        public nint* PParams;

        [NativeTypeName("size_t")] public nuint ExtraCount;

        [NativeTypeName("const void *const *")]
        public nint* PExtras;
    }
}
