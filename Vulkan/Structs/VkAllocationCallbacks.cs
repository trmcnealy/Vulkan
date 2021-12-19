using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct VkAllocationCallbacks
    {
        public static readonly VkAllocationCallbacks* Null = null;


        [NativeTypeName("void *")]
        public nint PUserData;

        [NativeTypeName("PFN_vkAllocationFunction")]
        public delegate*<nuint /*pUserData*/, nint /* size*/,nint /*alignment*/, VkSystemAllocationScope /*allocationScope*/,nuint> /*PFN_vkAllocationFunction*/ PfnAllocation;

        [NativeTypeName("PFN_vkReallocationFunction")]
        public delegate*<nuint /*pUserData*/, nuint /*pOriginal*/, nint /* size*/,nint /*alignment*/, VkSystemAllocationScope /*allocationScope*/,nuint> /*PFN_vkReallocationFunction*/ PfnReallocation;

        [NativeTypeName("PFN_vkFreeFunction")]
        public delegate*<nuint /*pUserData*/, nuint /*pMemory*/,void> /*PFN_vkFreeFunction*/ PfnFree;

        [NativeTypeName("PFN_vkInternalAllocationNotification")]
        public delegate*<nuint /*pUserData*/, nint /*size*/, VkInternalAllocationType /*allocationType*/, VkSystemAllocationScope /*allocationScope*/,void> /*PFN_vkInternalAllocationNotification*/ PfnInternalAllocation;

        [NativeTypeName("PFN_vkInternalFreeNotification")]
        public delegate*<nuint /*pUserData*/, nint /* size*/,VkInternalAllocationType /*allocationType*/, VkSystemAllocationScope /*allocationScope*/,void> /*PFN_vkInternalFreeNotification*/ PfnInternalFree;

    }
}
