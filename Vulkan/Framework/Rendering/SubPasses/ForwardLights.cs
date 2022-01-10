// This value is per type of light that we feed into the shader

namespace Vulkan.Framework.SubPasses
{
    public class ForwardLights
    {
        public Light[] directional_lights = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_FORWARD_LIGHT_COUNT);
        public Light[] point_lights       = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_FORWARD_LIGHT_COUNT);
        public Light[] spot_lights        = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_FORWARD_LIGHT_COUNT);
    }
}
