using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkGeneratedCommandsInfoNV
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nuint PNext;

        public VkPipelineBindPoint PipelineBindPoint;

        [NativeTypeName("VkPipeline")] public VkPipeline Pipeline;

        [NativeTypeName("VkIndirectCommandsLayoutNV")]
        public VkIndirectCommandsLayoutNV IndirectCommandsLayout;

        [NativeTypeName("uint32_t")]
        public uint StreamCount;

        [NativeTypeName("const VkIndirectCommandsStreamNV *")]
        public VkIndirectCommandsStreamNV* PStreams;

        public VkIndirectCommandsStreamNV[] Streams
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(StreamCount, PStreams);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PStreams = NativeIntExtensions.ToPointer(value, out StreamCount);
            }
        }

        [NativeTypeName("uint32_t")] public uint SequencesCount;

        [NativeTypeName("VkBuffer")] public VkBuffer PreprocessBuffer;

        [NativeTypeName("ulong")] public ulong PreprocessOffset;

        [NativeTypeName("ulong")] public ulong PreprocessSize;

        [NativeTypeName("VkBuffer")] public VkBuffer SequencesCountBuffer;

        [NativeTypeName("ulong")] public ulong SequencesCountOffset;

        [NativeTypeName("VkBuffer")] public VkBuffer SequencesIndexBuffer;

        [NativeTypeName("ulong")] public ulong SequencesIndexOffset;
    }
}
