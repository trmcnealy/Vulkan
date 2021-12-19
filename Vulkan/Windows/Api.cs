using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static unsafe class Api
    {
        public static readonly string DLL_NAME;

        public static readonly nint Handle;

        public static readonly nint vkCreateWin32SurfaceKHROffset                        = 0x00006070;
        public static readonly nint vkGetPhysicalDeviceWin32PresentationSupportKHROffset = 0x00004840;


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        static Api()
        {
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                DLL_NAME = "libvulkan.so.1";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                DLL_NAME = "libvulkan-1.0.0.dylib";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                DLL_NAME = "vulkan-1.dll";
            }
            else if(RuntimeInformation.IsOSPlatform(OSPlatform.FreeBSD))
            {
                DLL_NAME = "vulkan-1";
            }
            else
            {
                DLL_NAME = "vulkan";
            }

            Handle = DllMap.MapAndLoad(DLL_NAME);


            CreateWin32SurfaceKHR = (delegate* <VkInstance, ref VkWin32SurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult>)(Handle + vkCreateWin32SurfaceKHROffset);//NativeLibrary.GetExport(Handle, "vkCreateWin32SurfaceKHR");

            GetPhysicalDeviceWin32PresentationSupportKHR = (delegate*<ref VkPhysicalDevice, uint, uint >)(Handle + vkGetPhysicalDeviceWin32PresentationSupportKHROffset);//NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceWin32PresentationSupportKHR");

            //GetMemoryWin32HandleKHR = (delegate*<VkDevice, in VkMemoryGetWin32HandleInfoKHR, out nint, VkResult >)NativeLibrary.GetExport(Handle, "vkGetMemoryWin32HandleKHR");

            //GetMemoryWin32HandlePropertiesKHR = (delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, nint, out VkMemoryWin32HandlePropertiesKHR, VkResult >)NativeLibrary.GetExport(Handle, "vkGetMemoryWin32HandlePropertiesKHR");

            //ImportSemaphoreWin32HandleKHR = (delegate*<VkDevice, in VkImportSemaphoreWin32HandleInfoKHR, VkResult >)NativeLibrary.GetExport(Handle, "vkImportSemaphoreWin32HandleKHR");

            //GetSemaphoreWin32HandleKHR = (delegate*<VkDevice, in VkSemaphoreGetWin32HandleInfoKHR, out nint, VkResult >)NativeLibrary.GetExport(Handle, "vkGetSemaphoreWin32HandleKHR");

            //ImportFenceWin32HandleKHR = (delegate*<VkDevice, in VkImportFenceWin32HandleInfoKHR, VkResult >)NativeLibrary.GetExport(Handle, "vkImportFenceWin32HandleKHR");

            //GetFenceWin32HandleKHR = (delegate*<VkDevice, in VkFenceGetWin32HandleInfoKHR, out nint, VkResult>)NativeLibrary.GetExport(Handle, "vkGetFenceWin32HandleKHR");

            //GetMemoryWin32HandleNV = (delegate*<VkDevice, ref VkDeviceMemory, uint, out nint, VkResult >)NativeLibrary.GetExport(Handle, "vkGetMemoryWin32HandleNV");

            //GetPhysicalDeviceSurfacePresentModes2EXT = (delegate*<ref VkPhysicalDevice, in VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkPresentModeKHR*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetPhysicalDeviceSurfacePresentModes2EXT");

            //AcquireFullScreenExclusiveModeEXT = (delegate*<VkDevice, ref VkSwapchainKHR, VkResult >)NativeLibrary.GetExport(Handle, "vkAcquireFullScreenExclusiveModeEXT");

            //ReleaseFullScreenExclusiveModeEXT = (delegate*<VkDevice, ref VkSwapchainKHR, VkResult>)NativeLibrary.GetExport(Handle, "vkReleaseFullScreenExclusiveModeEXT");

            //GetDeviceGroupSurfacePresentModes2EXT = (delegate*<VkDevice, in VkPhysicalDeviceSurfaceInfo2KHR, uint*, VkResult>)NativeLibrary.GetExport(Handle, "vkGetDeviceGroupSurfacePresentModes2EXT");
        }


        public static readonly delegate*<VkInstance, ref VkWin32SurfaceCreateInfoKHR, VkAllocationCallbacks*, out VkSurfaceKHR, VkResult>      CreateWin32SurfaceKHR;
        public static readonly delegate*<ref VkPhysicalDevice, uint, uint>                                                                     GetPhysicalDeviceWin32PresentationSupportKHR;
        //public static readonly delegate*<VkDevice, in VkMemoryGetWin32HandleInfoKHR, out nint, VkResult>                                     GetMemoryWin32HandleKHR;
        //public static readonly delegate*<VkDevice, VkExternalMemoryHandleTypeFlagBits, nint, out VkMemoryWin32HandlePropertiesKHR, VkResult> GetMemoryWin32HandlePropertiesKHR;
        //public static readonly delegate*<VkDevice, in VkImportSemaphoreWin32HandleInfoKHR, VkResult>                                         ImportSemaphoreWin32HandleKHR;
        //public static readonly delegate*<VkDevice, in VkSemaphoreGetWin32HandleInfoKHR, out nint, VkResult>                                  GetSemaphoreWin32HandleKHR;
        //public static readonly delegate*<VkDevice, in VkImportFenceWin32HandleInfoKHR, VkResult>                                             ImportFenceWin32HandleKHR;
        //public static readonly delegate*<VkDevice, in VkFenceGetWin32HandleInfoKHR, out nint, VkResult>                                      GetFenceWin32HandleKHR;
        //public static readonly delegate*<VkDevice, ref VkDeviceMemory, uint, out nint, VkResult>                                             GetMemoryWin32HandleNV;
        //public static readonly delegate*<ref VkPhysicalDevice, in VkPhysicalDeviceSurfaceInfo2KHR, out uint, VkPresentModeKHR*, VkResult>    GetPhysicalDeviceSurfacePresentModes2EXT;
        //public static readonly delegate*<VkDevice, ref VkSwapchainKHR, VkResult>                                                             AcquireFullScreenExclusiveModeEXT;
        //public static readonly delegate*<VkDevice, ref VkSwapchainKHR, VkResult>                                                             ReleaseFullScreenExclusiveModeEXT;
        //public static readonly delegate*<VkDevice, in VkPhysicalDeviceSurfaceInfo2KHR, uint*, VkResult>                                      GetDeviceGroupSurfacePresentModes2EXT;


        [NativeTypeName("#define VULKAN_WIN32_H_ 1")]
        public const int VULKAN_WIN32_H_ = 1;

        [NativeTypeName("#define VK_KHR_win32_surface 1")]
        public const int VK_KHR_win32_surface = 1;

        [NativeTypeName("#define VK_KHR_WIN32_SURFACE_SPEC_VERSION 6")]
        public const int VK_KHR_WIN32_SURFACE_SPEC_VERSION = 6;

        [NativeTypeName("#define VK_KHR_WIN32_SURFACE_EXTENSION_NAME \"VK_KHR_win32_surface\"")]
        public static ReadOnlySpan<byte> VK_KHR_WIN32_SURFACE_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x73, 0x75, 0x72, 0x66, 0x61, 0x63, 0x65, 0x00 }; }
        }

        [NativeTypeName("#define VK_KHR_external_memory_win32 1")]
        public const int VK_KHR_external_memory_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_KHR_external_memory_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 }; }
        }

        [NativeTypeName("#define VK_KHR_win32_keyed_mutex 1")]
        public const int VK_KHR_win32_keyed_mutex = 1;

        [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION 1")]
        public const int VK_KHR_WIN32_KEYED_MUTEX_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_KHR_win32_keyed_mutex\"")]
        public static ReadOnlySpan<byte> VK_KHR_WIN32_KEYED_MUTEX_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x6B, 0x65, 0x79, 0x65, 0x64, 0x5F, 0x6D, 0x75, 0x74, 0x65, 0x78, 0x00 }; }
        }

        [NativeTypeName("#define VK_KHR_external_semaphore_win32 1")]
        public const int VK_KHR_external_semaphore_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_SEMAPHORE_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME \"VK_KHR_external_semaphore_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_SEMAPHORE_WIN32_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x73, 0x65, 0x6D, 0x61, 0x70, 0x68, 0x6F, 0x72, 0x65, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 }; }
        }

        [NativeTypeName("#define VK_KHR_external_fence_win32 1")]
        public const int VK_KHR_external_fence_win32 = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION 1")]
        public const int VK_KHR_EXTERNAL_FENCE_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME \"VK_KHR_external_fence_win32\"")]
        public static ReadOnlySpan<byte> VK_KHR_EXTERNAL_FENCE_WIN32_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4B, 0x48, 0x52, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x66, 0x65, 0x6E, 0x63, 0x65, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 }; }
        }

        [NativeTypeName("#define VK_NV_external_memory_win32 1")]
        public const int VK_NV_external_memory_win32 = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION 1")]
        public const int VK_NV_EXTERNAL_MEMORY_WIN32_SPEC_VERSION = 1;

        [NativeTypeName("#define VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME \"VK_NV_external_memory_win32\"")]
        public static ReadOnlySpan<byte> VK_NV_EXTERNAL_MEMORY_WIN32_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x65, 0x78, 0x74, 0x65, 0x72, 0x6E, 0x61, 0x6C, 0x5F, 0x6D, 0x65, 0x6D, 0x6F, 0x72, 0x79, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x00 }; }
        }

        [NativeTypeName("#define VK_NV_win32_keyed_mutex 1")]
        public const int VK_NV_win32_keyed_mutex = 1;

        [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION 2")]
        public const int VK_NV_WIN32_KEYED_MUTEX_SPEC_VERSION = 2;

        [NativeTypeName("#define VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME \"VK_NV_win32_keyed_mutex\"")]
        public static ReadOnlySpan<byte> VK_NV_WIN32_KEYED_MUTEX_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x4E, 0x56, 0x5F, 0x77, 0x69, 0x6E, 0x33, 0x32, 0x5F, 0x6B, 0x65, 0x79, 0x65, 0x64, 0x5F, 0x6D, 0x75, 0x74, 0x65, 0x78, 0x00 }; }
        }

        [NativeTypeName("#define VK_EXT_full_screen_exclusive 1")]
        public const int VK_EXT_full_screen_exclusive = 1;

        [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION 4")]
        public const int VK_EXT_FULL_SCREEN_EXCLUSIVE_SPEC_VERSION = 4;

        [NativeTypeName("#define VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME \"VK_EXT_full_screen_exclusive\"")]
        public static ReadOnlySpan<byte> VK_EXT_FULL_SCREEN_EXCLUSIVE_EXTENSION_NAME
        {
            get { return new byte[] { 0x56, 0x4B, 0x5F, 0x45, 0x58, 0x54, 0x5F, 0x66, 0x75, 0x6C, 0x6C, 0x5F, 0x73, 0x63, 0x72, 0x65, 0x65, 0x6E, 0x5F, 0x65, 0x78, 0x63, 0x6C, 0x75, 0x73, 0x69, 0x76, 0x65, 0x00 }; }
        }
    }
}
