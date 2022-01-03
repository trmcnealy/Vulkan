namespace Vulkan.Framework;

public enum QueueType
{
    TRANSFER = 0x01,
    GRAPHICS = 0x02,
    COMPUTE  = 0x04,
    PRESENT  = 0x08,
    RENDER   = 0x07,
    ALL      = 0x0F
}