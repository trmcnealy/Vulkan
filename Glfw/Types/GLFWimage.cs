using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Image data.This describes a single 2D image.  See the documentation for each related
    /// function what the expected pixel format is.@sa @ref cursor_custom@sa @ref window_icon@since Added in version 2.1.
    /// @glfw3 Removed format and bytes-per-pixel members. window
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GLFWimage
    {
        /// <summary>
        /// The width, in pixels, of this image.
        /// </summary>
        public int width;
            
        /// <summary>
        /// The height, in pixels, of this image.
        /// </summary>
        public int height;
            
        /// <summary>
        /// The pixel data of this image, arranged left-to-right, top-to-bottom.
        /// </summary>
        public nint pixels;
    }
}
