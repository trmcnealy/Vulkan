namespace Vulkan.Framework.SubPasses
{
    public class DeferredLights
    {
        public Light[] directional_lights = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_DEFERRED_LIGHT_COUNT);
        public Light[] point_lights       = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_DEFERRED_LIGHT_COUNT);
        public Light[] spot_lights        = Arrays.InitializeWithDefaultInstances<Light>(DefineConstants.MAX_DEFERRED_LIGHT_COUNT);
    }
}
