using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Vulkan;

[SuppressMessage("ReSharper", "InconsistentNaming")]
public readonly partial struct VkQueue
{
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkResult QueuePresentKHR(ref VkPresentInfoKHR presentInfoKHR)
    {
        return Api.QueuePresentKHR(this, ref presentInfoKHR);
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void QueueSubmit(VkSubmitInfo[] pSubmits,
                            VkFence        fence)
    {
        Api.QueueSubmit(this, pSubmits, fence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public unsafe VkResult QueueWaitIdle()
    {
        return Api.QueueWaitIdle(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void QueueBindSparse(VkBindSparseInfo[] pBindInfo,
                                VkFence            fence)
    {
        Api.QueueBindSparse(this, pBindInfo, fence);
    }
}
