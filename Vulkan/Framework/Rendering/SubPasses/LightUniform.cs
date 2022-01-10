using System.Collections.Generic;


namespace Vulkan.Framework.SubPasses
{
    public class LightUniform
    {
        public Matrix4x4 inv_view_proj;
        public Vector2F  inv_resolution;

        public LightUniform()
        {
            inv_view_proj  = new Matrix4x4();
            inv_resolution = new Vector2F();
        }
    }
}
