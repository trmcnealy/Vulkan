namespace Vulkan.Framework;

public class SubpassInfo
{
    public Array<uint> InputAttachments = new Array<uint>();

    public Array<uint> OutputAttachments = new Array<uint>();

    public Array<uint> ColorResolveAttachments = new Array<uint>();

    public bool DisableDepthStencilAttachment;

    public uint DepthStencilResolveAttachment = new uint();

    public VkResolveModeFlagBits DepthStencilResolveMode = new VkResolveModeFlagBits();
}
