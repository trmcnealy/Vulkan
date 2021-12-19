using System;
using System.Runtime.InteropServices;

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Gamma ramp.This describes the gamma ramp for a monitor.@sa @ref monitor_gamma@sa @ref glfwGetGammaRamp@sa @ref glfwSetGammaRamp@since Added in version 3.0. monitor
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GLFWgammaramp
    {
        /// <summary>
        /// An array of value describing the response of the red channel.
        /// </summary>
        public nint red;
            
        /// <summary>
        /// An array of value describing the response of the green channel.
        /// </summary>
        public nint green;
            
        /// <summary>
        /// An array of value describing the response of the blue channel.
        /// </summary>
        public nint blue;
            
        /// <summary>
        /// The number of elements in each array.
        /// </summary>
        public uint size;
    }
}
