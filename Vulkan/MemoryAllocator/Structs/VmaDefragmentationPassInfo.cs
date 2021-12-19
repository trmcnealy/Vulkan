using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// 
/// </summary>
/// <remarks>
/// @brief Parameters for incremental defragmentation steps.To be used with function vmaBeginDefragmentationPass().
/// </remarks>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaDefragmentationPassInfo
{
    public uint moveCount;

    public nint pMoves;
}