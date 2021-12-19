using System.Runtime.InteropServices;


namespace VMA
{
    /// <summary>
    /// Flags for created #VmaAllocator.
    /// </summary>
    public enum VmaAllocatorCreateFlagBits : uint
    {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Allocator and all objects created from it will not be synchronized internally, so you must guarantee they are used from only one thread at a time or synchronized externally by you.Using this flag may increase performance because internal mutexes are not used.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_EXTERNALLY_SYNCHRONIZED_BIT = 0x00000001,
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// @brief Enables usage of VK_KHR_dedicated_allocation extension.The flag works only if VmaAllocatorCreateInfo::vulkanApiVersion `== VK_API_VERSION_1_0`.
        /// When it is `VK_API_VERSION_1_1`, the flag is ignored because the extension has been promoted to Vulkan 1.1.Using this extension will automatically allocate dedicated blocks of memory for
        /// some buffers and images instead of suballocating place for them out of bigger
        /// memory blocks (as if you explicitly used #VMA_ALLOCATION_CREATE_DEDICATED_MEMORY_BIT
        /// flag) when it is recommended by the driver. It may improve performance on some
        /// GPUs.You may set this flag only if you found out that following device extensions are
        /// supported, you enabled them while creating Vulkan device passed as
        /// VmaAllocatorCreateInfo::device, and you want them to be used internally by this
        /// library:- VK_KHR_get_memory_requirements2 (device extension)
        /// - VK_KHR_dedicated_allocation (device extension)When this flag is set, you can experience following warnings reported by Vulkan
        /// validation layer. You can ignore them.&gt; vkBindBufferMemory(): Binding memory to buffer 0x2d but vkGetBufferMemoryRequirements() has not been called on that buffer.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_KHR_DEDICATED_ALLOCATION_BIT = 0x00000002,
        
        /// <summary>
        /// Enables usage of VK_KHR_bind_memory2 extension.
        /// </summary>
        /// <remarks>
        /// The flag works only if VmaAllocatorCreateInfo::vulkanApiVersion `== VK_API_VERSION_1_0`.
        /// When it is `VK_API_VERSION_1_1`, the flag is ignored because the extension has been promoted to Vulkan 1.1.You may set this flag only if you found out that this device extension is supported,
        /// you enabled it while creating Vulkan device passed as VmaAllocatorCreateInfo::device,
        /// and you want it to be used internally by this library.The extension provides functions `vkBindBufferMemory2KHR` and `vkBindImageMemory2KHR`,
        /// which allow to pass a chain of `pNext` structures while binding.
        /// This flag is required if you use `pNext` parameter in vmaBindBufferMemory2() or vmaBindImageMemory2().
        /// </remarks>
        VMA_ALLOCATOR_CREATE_KHR_BIND_MEMORY2_BIT = 0x00000004,
        
        /// <summary>
        /// Enables usage of VK_EXT_memory_budget extension.
        /// </summary>
        /// <remarks>
        /// You may set this flag only if you found out that this device extension is supported,
        /// you enabled it while creating Vulkan device passed as VmaAllocatorCreateInfo::device,
        /// and you want it to be used internally by this library, along with another instance extension
        /// VK_KHR_get_physical_device_properties2, which is required by it (or Vulkan 1.1, where this extension is promoted).The extension provides query for current memory usage and budget, which will probably
        /// be more accurate than an estimation used by the library otherwise.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_EXT_MEMORY_BUDGET_BIT = 0x00000008,
        
        /// <summary>
        /// Enables usage of VK_AMD_device_coherent_memory extension.
        /// </summary>
        /// <remarks>
        /// You may set this flag only if you:- found out that this device extension is supported and enabled it while creating Vulkan device passed as VmaAllocatorCreateInfo::device,
        /// - checked that `VkPhysicalDeviceCoherentMemoryFeaturesAMD::deviceCoherentMemory` is true and set it while creating the Vulkan device,
        /// - want it to be used internally by this library.The extension and accompanying device feature provide access to memory types with
        /// `VK_MEMORY_PROPERTY_DEVICE_COHERENT_BIT_AMD` and `VK_MEMORY_PROPERTY_DEVICE_UNCACHED_BIT_AMD` flags.
        /// They are useful mostly for writing breadcrumb markers - a common method for debugging GPU crash/hang/TDR.When the extension is not enabled, such memory types are still enumerated, but their usage is illegal.
        /// To protect from this error, if you don't create the allocator with this flag, it will refuse to allocate any memory or create a custom pool in such memory type,
        /// returning `VK_ERROR_FEATURE_NOT_PRESENT`.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_AMD_DEVICE_COHERENT_MEMORY_BIT = 0x00000010,
        
        /// <summary>
        /// Enables usage of "buffer device address" feature, which allows you to use function
        /// `vkGetBufferDeviceAddress*` to get raw GPU pointer to a buffer and pass it for usage inside a shader.
        /// </summary>
        /// <remarks>
        /// You may set this flag only if you:1. (For Vulkan version 
        /// &lt;
        /// 1.2) Found as available and enabled device extension
        /// VK_KHR_buffer_device_address.
        /// This extension is promoted to core Vulkan 1.2.
        /// 2. Found as available and enabled device feature `VkPhysicalDeviceBufferDeviceAddressFeatures::bufferDeviceAddress`.When this flag is set, you can create buffers with `VK_BUFFER_USAGE_SHADER_DEVICE_ADDRESS_BIT` using VMA.
        /// The library automatically adds `VK_MEMORY_ALLOCATE_DEVICE_ADDRESS_BIT` to
        /// allocated memory blocks wherever it might be needed.For more information, see documentation chapter @ref enabling_buffer_device_address.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_BUFFER_DEVICE_ADDRESS_BIT = 0x00000020,
        
        /// <summary>
        /// Enables usage of VK_EXT_memory_priority extension in the library.
        /// </summary>
        /// <remarks>
        /// You may set this flag only if you found available and enabled this device extension,
        /// along with `VkPhysicalDeviceMemoryPriorityFeaturesEXT::memoryPriority == VK_TRUE`,
        /// while creating Vulkan device passed as VmaAllocatorCreateInfo::device.When this flag is used, VmaAllocationCreateInfo::priority and VmaPoolCreateInfo::priority
        /// are used to set priorities of allocated Vulkan memory. Without it, these variables are ignored.A priority must be a floating-point value between 0 and 1, indicating the priority of the allocation relative to other memory allocations.
        /// Larger values are higher priority. The granularity of the priorities is implementation-dependent.
        /// It is automatically passed to every call to `vkAllocateMemory` done by the library using structure `VkMemoryPriorityAllocateInfoEXT`.
        /// The value to be used for default priority is 0.5.
        /// For more details, see the documentation of the VK_EXT_memory_priority extension.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_EXT_MEMORY_PRIORITY_BIT = 0x00000040,
        
        /// <summary>
        /// Enables usage of VK_EXT_memory_priority extension in the library.
        /// </summary>
        /// <remarks>
        /// You may set this flag only if you found available and enabled this device extension,
        /// along with `VkPhysicalDeviceMemoryPriorityFeaturesEXT::memoryPriority == VK_TRUE`,
        /// while creating Vulkan device passed as VmaAllocatorCreateInfo::device.When this flag is used, VmaAllocationCreateInfo::priority and VmaPoolCreateInfo::priority
        /// are used to set priorities of allocated Vulkan memory. Without it, these variables are ignored.A priority must be a floating-point value between 0 and 1, indicating the priority of the allocation relative to other memory allocations.
        /// Larger values are higher priority. The granularity of the priorities is implementation-dependent.
        /// It is automatically passed to every call to `vkAllocateMemory` done by the library using structure `VkMemoryPriorityAllocateInfoEXT`.
        /// The value to be used for default priority is 0.5.
        /// For more details, see the documentation of the VK_EXT_memory_priority extension.
        /// </remarks>
        VMA_ALLOCATOR_CREATE_FLAG_BITS_MAX_ENUM = 0x7FFFFFFF,
    }
}