using System.Collections.Generic;


namespace Vulkan.Framework.SubPasses
{
    /**
 * @brief Global uniform structure for base shader
 */
    public class GlobalUniform
    {
        public Matrix4x4 model = new Matrix4x4();

        public Matrix4x4 camera_view_proj = new Matrix4x4();

        public Vector3F camera_position = new Vector3F();
    }
}
