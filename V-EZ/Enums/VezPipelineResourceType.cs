namespace VEZ;

public enum VezPipelineResourceType : uint
{
    VEZ_PIPELINE_RESOURCE_TYPE_INPUT = unchecked((uint)0),
            
    VEZ_PIPELINE_RESOURCE_TYPE_OUTPUT = unchecked((uint)1),
            
    VEZ_PIPELINE_RESOURCE_TYPE_SAMPLER = unchecked((uint)2),
            
    VEZ_PIPELINE_RESOURCE_TYPE_COMBINED_IMAGE_SAMPLER = unchecked((uint)3),
            
    VEZ_PIPELINE_RESOURCE_TYPE_SAMPLED_IMAGE = unchecked((uint)4),
            
    VEZ_PIPELINE_RESOURCE_TYPE_STORAGE_IMAGE = unchecked((uint)5),
            
    VEZ_PIPELINE_RESOURCE_TYPE_UNIFORM_TEXEL_BUFFER = unchecked((uint)6),
            
    VEZ_PIPELINE_RESOURCE_TYPE_STORAGE_TEXEL_BUFFER = unchecked((uint)7),
            
    VEZ_PIPELINE_RESOURCE_TYPE_UNIFORM_BUFFER = unchecked((uint)8),
            
    VEZ_PIPELINE_RESOURCE_TYPE_STORAGE_BUFFER = unchecked((uint)9),
            
    VEZ_PIPELINE_RESOURCE_TYPE_INPUT_ATTACHMENT = unchecked((uint)10),
            
    VEZ_PIPELINE_RESOURCE_TYPE_PUSH_CONSTANT_BUFFER = unchecked((uint)11),
}