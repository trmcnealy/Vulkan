using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void PFN_vmaAllocateDeviceMemoryFunction(VmaAllocator   allocator,
                                                         uint           memoryType,
                                                         VkDeviceMemory memory,
                                                         ulong          size,
                                                         IntPtr         pUserData);