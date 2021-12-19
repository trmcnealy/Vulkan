using System.Runtime.InteropServices;

namespace Vulkan
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFN_vkGetDeviceMemoryCommitment([NativeTypeName("VkDevice")]           VkDevice       device,
                                                                [NativeTypeName("VkDeviceMemory")] ref VkDeviceMemory memory,
                                                                [NativeTypeName("VkDeviceSize *")]     ulong*         pCommittedMemoryInBytes);
}
