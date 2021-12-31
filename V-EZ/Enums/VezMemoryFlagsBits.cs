namespace VEZ;

public enum VezMemoryFlagsBits : uint
{
    VEZ_MEMORY_GPU_ONLY = unchecked((uint)0x00000000),
            
    VEZ_MEMORY_CPU_ONLY = unchecked((uint)0x00000001),
            
    VEZ_MEMORY_CPU_TO_GPU = unchecked((uint)0x00000002),
            
    VEZ_MEMORY_GPU_TO_CPU = unchecked((uint)0x00000004),
            
    VEZ_MEMORY_DEDICATED_ALLOCATION = unchecked((uint)0x00000008),
            
    VEZ_MEMORY_NO_ALLOCATION = unchecked((uint)0x000000010),
}