//using System.Runtime.InteropServices;

//namespace Vulkan.MemoryAllocator;

///// <summary>
///// 
///// </summary>
///// <remarks>
///// @brief Pointers to some Vulkan functions - a subset used by the library.Used in VmaAllocatorCreateInfo::pVulkanFunctions.
///// </remarks>
//[StructLayout(LayoutKind.Sequential,
//              CharSet = CharSet.Unicode)]
//public partial struct VmaVulkanFunctions
//{
//    /// <summary>
//    /// Required when using VMA_DYNAMIC_VULKAN_FUNCTIONS.
//    /// </summary>
//    public PFN_vkGetInstanceProcAddr vkGetInstanceProcAddr;

//    /// <summary>
//    /// Required when using VMA_DYNAMIC_VULKAN_FUNCTIONS.
//    /// </summary>
//    public PFN_vkGetDeviceProcAddr vkGetDeviceProcAddr;

//    public PFN_vkGetPhysicalDeviceProperties vkGetPhysicalDeviceProperties;

//    public PFN_vkGetPhysicalDeviceMemoryProperties vkGetPhysicalDeviceMemoryProperties;

//    public PFN_vkAllocateMemory vkAllocateMemory;

//    public PFN_vkFreeMemory vkFreeMemory;

//    public PFN_vkMapMemory vkMapMemory;

//    public PFN_vkUnmapMemory vkUnmapMemory;

//    public PFN_vkFlushMappedMemoryRanges vkFlushMappedMemoryRanges;

//    public PFN_vkInvalidateMappedMemoryRanges vkInvalidateMappedMemoryRanges;

//    public PFN_vkBindBufferMemory vkBindBufferMemory;

//    public PFN_vkBindImageMemory vkBindImageMemory;

//    public PFN_vkGetBufferMemoryRequirements vkGetBufferMemoryRequirements;

//    public PFN_vkGetImageMemoryRequirements vkGetImageMemoryRequirements;

//    public PFN_vkCreateBuffer vkCreateBuffer;

//    public PFN_vkDestroyBuffer vkDestroyBuffer;

//    public PFN_vkCreateImage vkCreateImage;

//    public PFN_vkDestroyImage vkDestroyImage;

//    public PFN_vkCmdCopyBuffer vkCmdCopyBuffer;

//    /// <summary>
//    /// Fetch "vkGetBufferMemoryRequirements2" on Vulkan &gt;= 1.1, fetch "vkGetBufferMemoryRequirements2KHR" when using VK_KHR_dedicated_allocation extension.
//    /// </summary>
//    public PFN_vkGetBufferMemoryRequirements2KHR vkGetBufferMemoryRequirements2KHR;

//    /// <summary>
//    /// Fetch "vkGetImageMemoryRequirements 2" on Vulkan &gt;= 1.1, fetch "vkGetImageMemoryRequirements2KHR" when using VK_KHR_dedicated_allocation extension.
//    /// </summary>
//    public PFN_vkGetImageMemoryRequirements2KHR vkGetImageMemoryRequirements2KHR;

//    /// <summary>
//    /// Fetch "vkBindBufferMemory2" on Vulkan &gt;= 1.1, fetch "vkBindBufferMemory2KHR" when using VK_KHR_bind_memory2 extension.
//    /// </summary>
//    public PFN_vkBindBufferMemory2KHR vkBindBufferMemory2KHR;

//    /// <summary>
//    /// Fetch "vkBindImageMemory2" on Vulkan &gt;= 1.1, fetch "vkBindImageMemory2KHR" when using VK_KHR_bind_memory2 extension.
//    /// </summary>
//    public PFN_vkBindImageMemory2KHR vkBindImageMemory2KHR;

//    public PFN_vkGetPhysicalDeviceMemoryProperties2KHR vkGetPhysicalDeviceMemoryProperties2KHR;
//}