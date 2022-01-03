using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkInstanceCreateInfo
    {
        public VkStructureType SType;
        
        public nuint PNext;
        
        public uint Flags;

        public VkApplicationInfo* PApplicationInfo;

        public uint EnabledLayerCount;
        
        public utf8string* PpEnabledLayerNames;

        public utf8string[] EnabledLayerNames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(EnabledLayerCount, PpEnabledLayerNames);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PpEnabledLayerNames = NativeIntExtensions.ToPointer(value, out EnabledLayerCount);
            }
        }

        public uint              EnabledExtensionCount;
        public utf8string*       PpEnabledExtensionNames;

        public utf8string[] EnabledExtensionNames
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(EnabledExtensionCount, PpEnabledExtensionNames);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PpEnabledExtensionNames = NativeIntExtensions.ToPointer(value, out EnabledExtensionCount);
            }
        }
    }
}
