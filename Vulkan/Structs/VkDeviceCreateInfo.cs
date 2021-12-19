using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDeviceCreateInfo
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkDeviceCreateFlags")]
        public uint Flags;

        [NativeTypeName("uint32_t")]
        public uint QueueCreateInfoCount;

        [NativeTypeName("const VkDeviceQueueCreateInfo *")]        
        public VkDeviceQueueCreateInfo* PQueueCreateInfos;
        
        public VkDeviceQueueCreateInfo[] QueueCreateInfos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(QueueCreateInfoCount, PQueueCreateInfos);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PQueueCreateInfos = NativeIntExtensions.ToPointer(value, out QueueCreateInfoCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint EnabledLayerCount;

        [NativeTypeName("const char *const *")]
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

        [NativeTypeName("uint32_t")]
        public uint EnabledExtensionCount;        

        [NativeTypeName("const char *const *")]
        public utf8string* PpEnabledExtensionNames;
        
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

        [NativeTypeName("const VkPhysicalDeviceFeatures *")]
        public VkPhysicalDeviceFeatures* PEnabledFeatures;
        
        public VkPhysicalDeviceFeatures[] EnabledFeatures
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(EnabledExtensionCount, PEnabledFeatures);
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PEnabledFeatures = NativeIntExtensions.ToPointer(value, out EnabledExtensionCount);
            }
        }
        
    }
}
