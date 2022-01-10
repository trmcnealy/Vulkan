namespace Vulkan.Framework;

public class ShaderModule
{
    private Device _Device;

    /// Shader unique id
    private nint _Id = new nint();

    /// Stage of the shader (vertex, fragment, etc)
    private VkShaderStageFlagBits _Stage = new VkShaderStageFlagBits();

    /// Name of the main function
    private utf8string _EntryPoint = "";

    /// Compiled source
    private Array<uint> _Spirv = new Array<uint>();

    private Array<ShaderResource> _Resources = new Array<ShaderResource>();

    private utf8string _InfoLog = "";
}
