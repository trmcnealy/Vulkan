using System.Runtime.InteropServices;
using Vulkan;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezAttachmentInfo
{
    public VkAttachmentLoadOp loadOp;
            
    public VkAttachmentStoreOp storeOp;
            
    public VkClearValue clearValue;
}