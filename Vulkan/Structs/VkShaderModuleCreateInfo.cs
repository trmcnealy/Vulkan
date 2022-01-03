using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkShaderModuleCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        [NativeTypeName("VkShaderModuleCreateFlags")]
        public uint Flags;

        [NativeTypeName("size_t")] public nuint CodeSize;

        [NativeTypeName("const uint32_t *")] public uint* PCode;
        
        public uint[] Code
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CodeSize, PCode);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCode = NativeIntExtensions.ToPointer(value, out CodeSize);
            }
        }
    }
}
