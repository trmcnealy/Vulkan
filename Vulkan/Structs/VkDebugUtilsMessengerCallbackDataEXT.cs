using System.Runtime.InteropServices;

namespace Vulkan
{
    public unsafe struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")] public nint PNext;

        [NativeTypeName("VkDebugUtilsMessengerCallbackDataFlagsEXT")]
        public uint Flags;

        [NativeTypeName("const char *")] 
        public utf8string PMessageIdName;

        [NativeTypeName("int32_t")] public int MessageIdNumber;

        [NativeTypeName("const char *")] 
        public utf8string PMessage;

        [NativeTypeName("uint32_t")]
        public uint QueueLabelCount;

        [NativeTypeName("const VkDebugUtilsLabelEXT *")]
        public VkDebugUtilsLabelEXT* PQueueLabels;

        public VkDebugUtilsLabelEXT[] QueueLabels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(QueueLabelCount, PQueueLabels);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PQueueLabels = NativeIntExtensions.ToPointer(value, out QueueLabelCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint CmdBufLabelCount;

        [NativeTypeName("const VkDebugUtilsLabelEXT *")]
        public VkDebugUtilsLabelEXT* PCmdBufLabels;

        public VkDebugUtilsLabelEXT[] CmdBufLabels
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(CmdBufLabelCount, PCmdBufLabels);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PCmdBufLabels = NativeIntExtensions.ToPointer(value, out CmdBufLabelCount);
            }
        }

        [NativeTypeName("uint32_t")]
        public uint ObjectCount;

        [NativeTypeName("const VkDebugUtilsObjectNameInfoEXT *")]
        public VkDebugUtilsObjectNameInfoEXT* PObjects;

        public VkDebugUtilsObjectNameInfoEXT[] Objects
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return NativeIntExtensions.ToManagedArray(ObjectCount, PObjects);    
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                PObjects = NativeIntExtensions.ToPointer(value, out ObjectCount);
            }
        }
    }
}
