using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkSwapchainCreateInfoKHR
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nint PNext;

        [NativeTypeName("VkSwapchainCreateFlagsKHR")]
        public VkSwapchainCreateFlagBitsKHR Flags;

        [NativeTypeName("VkSurfaceKHR")]
        public VkSurfaceKHR Surface;

        [NativeTypeName("uint32_t")]
        public uint MinImageCount;

        public VkFormat ImageFormat;

        public VkColorSpaceKHR ImageColorSpace;

        public VkExtent2D ImageExtent;

        [NativeTypeName("uint32_t")]
        public uint ImageArrayLayers;

        [NativeTypeName("VkImageUsageFlags")]
        public VkImageUsageFlagBits ImageUsage;

        public VkSharingMode ImageSharingMode;

        [NativeTypeName("uint32_t")]
        public uint QueueFamilyIndexCount;

        [NativeTypeName("const uint32_t *")]
        public uint* PQueueFamilyIndices;

        public uint[] QueueFamilyIndices
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(QueueFamilyIndexCount, PQueueFamilyIndices);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PQueueFamilyIndices = NativeIntExtensions.ToPointer(value, out QueueFamilyIndexCount);
            }
        }

        public VkSurfaceTransformFlagBitsKHR PreTransform;

        public VkCompositeAlphaFlagBitsKHR CompositeAlpha;

        public VkPresentModeKHR PresentMode;

        [NativeTypeName("Bool32")]
        public uint Clipped;

        [NativeTypeName("VkSwapchainKHR")]
        public VkSwapchainKHR OldSwapchain;
    }
}
