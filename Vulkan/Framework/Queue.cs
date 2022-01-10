namespace Vulkan.Framework;

public class Queue
{
    private Device _Device;

    private VkQueue _Handle = new VkQueue(0);

    private uint _FamilyIndex = new uint();

    private uint _Index = new uint();

    private Bool32 _CanPresent = false;

    private VkQueueFamilyProperties _Properties = new VkQueueFamilyProperties();
}
