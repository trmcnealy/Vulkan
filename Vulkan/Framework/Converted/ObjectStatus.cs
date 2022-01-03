namespace Vulkan.Framework;

public enum ObjectStatus
{
    NONE,
    ALLOC,
    DESTROYED,
    INIT,
    CREATED,
    NEED_RECREATE,
    NEED_UPDATE,
    NEED_DESTROY,
    INACTIVE,
    INVALID
}