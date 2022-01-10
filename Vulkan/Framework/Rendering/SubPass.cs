using System.Collections.Generic;
using System.Diagnostics;










namespace Vulkan.Framework
{
//class CommandBuffer;

/**
 * @brief This class defines an interface for subpasses
 *        where they need to implement the draw function.
 *        It is used to construct a RenderPipeline
 */
public abstract class Subpass : System.IDisposable
{
    public Subpass(RenderContext render_context, ShaderSource && vertex_source, ShaderSource && fragment_source)
    {
        this.RenderContext = new RenderContext(render_context);
        this._VertexShader = new ShaderSource(std::move(vertex_source));
        this._FragmentShader = new ShaderSource(std::move(fragment_source));
    }

//    Subpass(@in Subpass) = delete;

//    Subpass(Subpass &&) = default;

//    virtual ~Subpass() = default;

//    Subpass &operator =(@in Subpass) = delete;

//    Subpass &operator =(Subpass &&) = delete;

    /**
     * @brief Prepares the shaders and shader variants for a subpass
     */
    public abstract void Prepare();

    /**
     * @brief Updates the render target attachments with the ones stored in this subpass
     *        This function is called by the RenderPipeline before beginning the render
     *        pass and before proceeding with a new subpass.
     */
    public void UpdateRenderTargetAttachments(RenderTarget render_target)
    {
        render_target.SetInputAttachments(_InputAttachments);
        render_target.SetOutputAttachments(_OutputAttachments);
    }

    /**
     * @brief Draw virtual function
     * @param command_buffer Command buffer to use to record draw commands
     */
    public abstract void Draw(CommandBuffer command_buffer);

    public RenderContext GetRenderContext()
    {
        return RenderContext;
    }

    public ShaderSource GetVertexShader()
    {
        return _VertexShader;
    }

    public ShaderSource GetFragmentShader()
    {
        return _FragmentShader;
    }

    public DepthStencilState GetDepthStencilState()
    {
        return _DepthStencilState;
    }

    public Array<uint> GetInputAttachments()
    {
        return _InputAttachments;
    }

    public void SetInputAttachments(Array<uint> input)
    {
        _InputAttachments = input;
    }

    public Array<uint> GetOutputAttachments()
    {
        return _OutputAttachments;
    }

    public void SetOutputAttachments(Array<uint> output)
    {
        _OutputAttachments = output;
    }

    public void SetSampleCount(VkSampleCountFlagBits sample_count)
    {
        this.SampleCount = sample_count;
    }

    public Array<uint> GetColorResolveAttachments()
    {
        return _ColorResolveAttachments;
    }

    public void SetColorResolveAttachments(Array<uint> color_resolve)
    {
        _ColorResolveAttachments = color_resolve;
    }

    public bool GetDisableDepthStencilAttachment()
    {
        return _DisableDepthStencilAttachment;
    }

    public void SetDisableDepthStencilAttachment(bool disable_depth_stencil)
    {
        _DisableDepthStencilAttachment = disable_depth_stencil;
    }

    public uint GetDepthStencilResolveAttachment()
    {
        return _DepthStencilResolveAttachment;
    }

    public void SetDepthStencilResolveAttachment(uint depth_stencil_resolve)
    {
        _DepthStencilResolveAttachment = depth_stencil_resolve;
    }

    public VkResolveModeFlagBits GetDepthStencilResolveMode()
    {
        return _DepthStencilResolveMode;
    }

    public void SetDepthStencilResolveMode(VkResolveModeFlagBits mode)
    {
        _DepthStencilResolveMode = mode;
    }

    public LightingState GetLightingState()
    {
        return LightingState;
    }

    /**
     * @brief Prepares the lighting state to have its lights 
     * 
     * @tparam A light structure that has 'directional_lights', 'point_lights' and 'spot_light' array fields defined.
     * @param scene_lights All of the light components from the scene graph
     * @param light_count The maximum amount of lights allowed for any given type of light.
     */
    public void AllocateLights<T>(Array<Sg.Light > scene_lights, nint light_count)
    {
        Debug.Assert(scene_lights.Count <= (light_count * Sg.LightType.Max) && "Exceeding Max Light Capacity");

        LightingState.DirectionalLights.Clear();
        LightingState.PointLights.Clear();
        LightingState.SpotLights.Clear();

        foreach (var scene_light in scene_lights)
        {
            in auto properties = scene_light.GetProperties();
            var transform = scene_light.GetNode().GetTransform();

            Light light = new Light()
            {
                position = {transform.GetTranslation(), (float)scene_light.GetLightType()},
                color = {properties.color, properties.intensity},
                direction = {transform.GetRotation() * properties.direction, properties.range},
                info = {properties.inner_cone_angle, properties.outer_cone_angle}
            };

            switch (scene_light.GetLightType())
            {
                case Sg.LightType.Directional:
                {
                    if (LightingState.DirectionalLights.Count < light_count)
                    {
                        LightingState.DirectionalLights.Add(light);
                    }
                    break;
                }
                case Sg.LightType.Point:
                {
                    if (LightingState.PointLights.Count < light_count)
                    {
                        LightingState.PointLights.Add(light);
                    }
                    break;
                }
                case Sg.LightType.Spot:
                {
                    if (LightingState.SpotLights.Count < light_count)
                    {
                        LightingState.SpotLights.Add(light);
                    }
                    break;
                }
                default:
                    break;
            }
        }

        T light_info = new default(T);

        std::copy(LightingState.DirectionalLights.GetEnumerator(), LightingState.DirectionalLights.end(), light_info.directional_lights);
        std::copy(LightingState.PointLights.GetEnumerator(), LightingState.PointLights.end(), light_info.point_lights);
        std::copy(LightingState.SpotLights.GetEnumerator(), LightingState.SpotLights.end(), light_info.spot_lights);

        var render_frame = GetRenderContext().GetActiveFrame();
        LightingState.LightBuffer = render_frame.AllocateBuffer(VK_BUFFER_USAGE_UNIFORM_BUFFER_BIT, sizeof(T));
        LightingState.LightBuffer.update(light_info);
    }

    protected RenderContext RenderContext;

    protected VkSampleCountFlagBits SampleCount = new VkSampleCountFlagBits(VK_SAMPLE_COUNT_1_BIT);

    // A map of shader resource names and the mode of constant data
    protected Dictionary<utf8string, ShaderResourceMode> ResourceModeMap = new Dictionary<utf8string, ShaderResourceMode>();

    /// The structure containing all the requested render-ready lights for the scene
    protected LightingState LightingState = new LightingState();

    private ShaderSource _VertexShader = new ShaderSource();

    private ShaderSource _FragmentShader = new ShaderSource();

    private DepthStencilState _DepthStencilState = new DepthStencilState();

    /**
     * @brief When creating the renderpass, pDepthStencilAttachment will
     *        be set to nullptr, which disables depth testing
     */
    private bool _DisableDepthStencilAttachment = false;

    /**
     * @brief When creating the renderpass, if not None, the resolve
     *        of the multisampled depth attachment will be enabled,
     *        with this mode, to depth_stencil_resolve_attachment
     */
    private VkResolveModeFlagBits _DepthStencilResolveMode = new VkResolveModeFlagBits(VK_RESOLVE_MODE_NONE);

    /// Default to no input attachments
    private Array<uint> _InputAttachments = new Array<uint>();

    /// Default to swapchain output attachment
    private Array<uint> _OutputAttachments = new Array<uint>() {0};

    /// Default to no color resolve attachments
    private Array<uint> _ColorResolveAttachments = new Array<uint>();

    /// Default to no depth stencil resolve attachment
    private uint _DepthStencilResolveAttachment = new uint(VK_ATTACHMENT_UNUSED);
}

} // namespace vkb





namespace Vulkan.Framework
{
    //public partial class GlobalMembers
    //{
    //    /**
    //     * @brief Calculates the vulkan style projection matrix
    //     * @param proj The projection matrix
    //     * @return The vulkan style projection matrix
    //     */
    //    public static Matrix4x4 vulkan_style_projection(Matrix4x4 proj)
    //    {
    //        // Flip Y in clipspace. X = -1, Y = -1 is topLeft in Vulkan.
    //        Matrix4x4 mat = proj;
    //        mat[1][1] *= -1;

    //        return mat;
    //    }

    //    //extern const System.Collections.Generic.List<utf8string> light_type_definitions;
    //    public static readonly Array<utf8string> LightTypeDefinitions = new Array<utf8string>() {"DIRECTIONAL_LIGHT " + std::to_string(static_cast<float>(Sg.LightType.Directional)), "POINT_LIGHT " + std::to_string(static_cast<float>(Sg.LightType.Point)), "SPOT_LIGHT " + std::to_string(static_cast<float>(Sg.LightType.Spot))};
    //}
}