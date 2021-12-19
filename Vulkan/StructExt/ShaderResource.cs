namespace Vulkan
{
    public enum ResourceBaseType : uint
    {
        BOOL   = 0,
        CHAR   = 1,
        INT    = 2,
        UINT   = 3,
        UINT64 = 4,
        HALF   = 5,
        FLOAT  = 6,
        DOUBLE = 7,
        STRUCT = 8
    }

    public enum ShaderResourceType : uint
    {
        Input,
        InputAttachment,
        Output,
        Image,
        ImageSampler,
        ImageStorage,
        Sampler,
        BufferUniform,
        BufferStorage,
        PushConstant,
        SpecializationConstant,
        All
    }

    public enum ShaderResourceMode
    {
        Static,
        Dynamic,
        UpdateAfterBind
    }
    
    public struct ShaderResourceQualifiers
    {
        public const uint None        = 0;
        public const uint NonReadable = 1;
        public const uint NonWritable = 2;
    }

    public unsafe struct ShaderMemberInfo
    {
        public       ResourceBaseType  BaseType;
        public       uint              Offset;
        public       uint              Size;
        public       uint              VecSize;
        public       uint              Columns;
        public       uint              ArraySize;
        public fixed sbyte             Name[256];
        public       ShaderMemberInfo* PNext;
        public       ShaderMemberInfo* PMembers;
    }

    public unsafe struct ShaderResource
    {
        public       VkShaderStageFlagBits Stages;
        public       ShaderResourceType    ResourceType;
        public       ResourceBaseType      BaseType;
        public       VkAccessFlagBits      Access;
        public       uint                  Set;
        public       uint                  Binding;
        public       uint                  Location;
        public       uint                  InputAttachmentIndex;
        public       uint                  VecSize;
        public       uint                  Columns;
        public       uint                  ArraySize;
        public       uint                  Offset;
        public       uint                  Size;
        public fixed sbyte                 Name[256];
        public       ShaderMemberInfo*     PMembers;
    }
}
