using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSpecializationInfo
    {
        [NativeTypeName("uint32_t")]
        public uint MapEntryCount;

        [NativeTypeName("const VkSpecializationMapEntry *")]
        public VkSpecializationMapEntry* PMapEntries;

        public VkSpecializationMapEntry[] MapEntries
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(MapEntryCount, PMapEntries);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PMapEntries = NativeIntExtensions.ToPointer(value, out MapEntryCount);
            }
        }

        [NativeTypeName("size_t")] public nuint DataSize;

        [NativeTypeName("const void *")] public nint PData;
    }
}
