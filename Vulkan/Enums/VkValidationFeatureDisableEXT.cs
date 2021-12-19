namespace Vulkan
{
    public enum VkValidationFeatureDisableEXT : uint
    {
        All                   = 0,
        Shaders               = 1,
        ThreadSafety          = 2,
        ApiParameters         = 3,
        ObjectLifetimes       = 4,
        CoreChecks            = 5,
        UniqueHandles         = 6,
        ShaderValidationCache = 7,
        MaxEnumFlag           = 0x7FFFFFFF
    }
}
