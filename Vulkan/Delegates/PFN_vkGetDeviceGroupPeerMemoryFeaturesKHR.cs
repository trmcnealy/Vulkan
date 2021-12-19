using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceGroupPeerMemoryFeaturesKHR([NativeTypeName("VkDevice")] VkDevice device,
                                                                          [NativeTypeName("uint32_t")] uint     heapIndex,
                                                                          [NativeTypeName("uint32_t")] uint     localDeviceIndex,
                                                                          [NativeTypeName("uint32_t")] uint     remoteDeviceIndex,
                                                                          [NativeTypeName("VkPeerMemoryFeatureFlags *")]
                                                                          uint[] pPeerMemoryFeatures);
}
