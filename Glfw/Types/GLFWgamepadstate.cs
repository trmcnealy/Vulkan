using System.Runtime.InteropServices;

namespace Glfw
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// @brief Gamepad input stateThis describes the input state of a gamepad.@sa @ref gamepad@sa @ref glfwGetGamepadState@since Added in version 3.3. input
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public unsafe struct GLFWgamepadstate
    {
        /// <summary>
        /// The states of each [gamepad button](@ref gamepad_buttons), `GLFW_PRESS`
        /// or `GLFW_RELEASE`.
        /// </summary>
        public fixed byte buttons[15];
            
        /// <summary>
        /// The states of each [gamepad axis](@ref gamepad_axes), in the range -1.0
        /// to 1.0 inclusive.
        /// </summary>
        public fixed float axes[6];
    }
}
