using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkSparseBufferMemoryBindInfo
    {
        [NativeTypeName("VkBuffer")] public VkBuffer Buffer;

        [NativeTypeName("uint32_t")]
        public uint BindCount;

        [NativeTypeName("const VkSparseMemoryBind *")]
        public VkSparseMemoryBind* PBinds;

        public VkSparseMemoryBind[] Binds
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
