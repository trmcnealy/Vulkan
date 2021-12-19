using System;
using System.Runtime.InteropServices;

namespace Vulkan.MemoryAllocator;

/// <summary>
/// Parameters for recording calls to VMA functions. To be used in VmaAllocatorCreateInfo::pRecordSettings.
/// </summary>
[StructLayout(LayoutKind.Sequential,
              CharSet = CharSet.Unicode)]
public partial struct VmaRecordSettings
{
    /// <summary>
    /// Flags for recording. Use #VmaRecordFlagBits enum.
    /// </summary>
    public uint flags;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Path to the file that should be written by the recording.Suggested extension: "csv".
    /// If the file already exists, it will be overwritten.
    /// It will be opened for the whole time #VmaAllocator object is alive.
    /// If opening this file fails, creation of the whole allocator object fails.
    /// </remarks>
    public nint pFilePath;
}