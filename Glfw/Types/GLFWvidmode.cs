using System.Runtime.InteropServices;

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Video mode type.This describes a single video mode.@sa @ref monitor_modes@sa @ref glfwGetVideoMode@sa @ref glfwGetVideoModes@since Added in version 1.0.
    /// @glfw3 Added refresh rate member. monitor
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GLFWvidmode
    {
        /// <summary>
        /// The width, in screen coordinates, of the video mode.
        /// </summary>
        public int width;
            
        /// <summary>
        /// The height, in screen coordinates, of the video mode.
        /// </summary>
        public int height;
            
        /// <summary>
        /// The bit depth of the red channel of the video mode.
        /// </summary>
        public int redBits;
            
        /// <summary>
        /// The bit depth of the green channel of the video mode.
        /// </summary>
        public int greenBits;
            
        /// <summary>
        /// The bit depth of the blue channel of the video mode.
        /// </summary>
        public int blueBits;
            
        /// <summary>
        /// The refresh rate, in Hz, of the video mode.
        /// </summary>
        public int refreshRate;
    }
}
