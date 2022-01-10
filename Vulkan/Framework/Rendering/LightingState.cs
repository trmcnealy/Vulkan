namespace Vulkan.Framework;

public class LightingState
{
    public Array<Light> DirectionalLights = new Array<Light>();

    public Array<Light> PointLights = new Array<Light>();

    public Array<Light> SpotLights = new Array<Light>();

    public BufferAllocation LightBuffer = new BufferAllocation();
}