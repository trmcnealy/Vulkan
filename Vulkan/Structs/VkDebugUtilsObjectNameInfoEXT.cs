using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkDebugUtilsObjectNameInfoEXT
    {
        public VkStructureType SType;

        [NativeTypeName("const void *")]
        public nuint PNext;

        public VkObjectType ObjectType;

        [NativeTypeName("uint64_t")]
        public nuint ObjectHandle;

        [NativeTypeName("const char *")] 
        public utf8string PObjectName;

        public VkDebugUtilsObjectNameInfoEXT(VkStructureType sType,
                                             nuint           pNext,
                                             VkObjectType    objectType,
                                             nuint           objectHandle,
                                             utf8string      pObjectName)
        {
            SType        = sType;
            PNext        = pNext;
            ObjectType   = objectType;
            ObjectHandle = objectHandle;
            PObjectName  = pObjectName;
        }
    }
}
