namespace Vulkan.Framework.SubPasses
{
    public class PBRMaterialUniform
    {
        public Vector4F base_color_factor;

        public float metallic_factor;

        public float roughness_factor;

        public PBRMaterialUniform()
        {
            base_color_factor = Vector4F.Zero;
            metallic_factor   = 0f;
            roughness_factor  = 0f;
        }
    }
}
