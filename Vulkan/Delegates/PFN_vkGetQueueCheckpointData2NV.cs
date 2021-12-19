using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetQueueCheckpointData2NV([NativeTypeName("VkQueue")] ref VkQueue queue,
                                                                [NativeTypeName("uint32_t *")]  uint*   pCheckpointDataCount,
                                                                VkCheckpointData2NV*                    pCheckpointData);
}
