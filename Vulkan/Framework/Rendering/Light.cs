namespace Vulkan.Framework;

public class  Light
{
    public Vector4F Position  = new Vector4F(); // position.w represents type of light
    public Vector4F Color     = new Vector4F(); // color.w represents light intensity
    public Vector4F Direction = new Vector4F(); // direction.w represents range
    public Vector2F Info      = new Vector2F(); // (only used for spot lights) info.x represents light inner cone angle, info.y represents light outer cone angle
}