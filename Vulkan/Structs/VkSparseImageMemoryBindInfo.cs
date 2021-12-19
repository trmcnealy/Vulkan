using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSparseImageMemoryBindInfo
    {
        [NativeTypeName("VkImage")] public VkImage Image;

        [NativeTypeName("uint32_t")]
        public uint BindCount;

        [NativeTypeName("const VkSparseImageMemoryBind *")]
        public VkSparseImageMemoryBind* PBinds;

        public VkSparseImageMemoryBind[] Binds
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(BindCount, PBinds);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PBinds = NativeIntExtensions.ToPointer(value, out BindCount);
            }
        }
    }
}
