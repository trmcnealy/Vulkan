namespace Vulkan.Framework;

public class ShaderResource
{
    public VkShaderStageFlagBits Stages = new VkShaderStageFlagBits();

    public ShaderResourceType Type = new ShaderResourceType();

    public ShaderResourceMode Mode;

    public uint Set = new uint();

    public uint Binding = new uint();

    public uint Location = new uint();

    public uint InputAttachmentIndex = new uint();

    public uint VecSize = new uint();

    public uint Columns = new uint();

    public uint ArraySize = new uint();

    public uint Offset = new uint();

    public uint Size = new uint();

    public uint ConstantId = new uint();

    public uint Qualifiers = new uint();

    public utf8string Name = "";
}
