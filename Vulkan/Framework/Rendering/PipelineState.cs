using System.Diagnostics;

namespace Vulkan.Framework;

public class PipelineState
{
    public void Reset()
    {
        ClearDirty();

        _PipelineLayout = null;

        _RenderPass = null;

        _SpecializationConstantState.Reset();

        _VertexInputState = new VertexInputState();

        _InputAssemblyState = new InputAssemblyState();

        _RasterizationState = new RasterizationState();

        _MultisampleState = new MultisampleState();

        _DepthStencilState = new DepthStencilState();

        _ColorBlendState = new ColorBlendState();

        _SubpassIndex = new uint(0U);
    }

    public void SetPipelineLayout(PipelineLayout new_pipeline_layout)
    {
        if (_PipelineLayout != null)
        {
            if (_PipelineLayout.GetHandle() != new_pipeline_layout.GetHandle())
            {
                _PipelineLayout = new_pipeline_layout;

                _Dirty = true;
            }
        }
        else
        {
            _PipelineLayout = new_pipeline_layout;

            _Dirty = true;
        }
    }

    public void SetRenderPass(in RenderPass new_render_pass)
    {
        if (_RenderPass != null)
        {
            if (_RenderPass.GetHandle() != new_render_pass.get_handle())
            {
                _RenderPass = new_render_pass;

                _Dirty = true;
            }
        }
        else
        {
            _RenderPass = new_render_pass;

            _Dirty = true;
        }
    }

    public void SetSpecializationConstant(uint constant_id, Array<byte> data)
    {
        _SpecializationConstantState.SetConstant(constant_id, data);

        if (_SpecializationConstantState.IsDirty())
        {
            _Dirty = true;
        }
    }

    public void SetVertexInputState(in VertexInputState new_vertex_input_state)
    {
        if (_VertexInputState != new_vertex_input_state)
        {
            _VertexInputState = new_vertex_input_state;

            _Dirty = true;
        }
    }

    public void SetInputAssemblyState(in InputAssemblyState new_input_assembly_state)
    {
        if (_InputAssemblyState != new_input_assembly_state)
        {
            _InputAssemblyState = new_input_assembly_state;

            _Dirty = true;
        }
    }

    public void SetRasterizationState(in RasterizationState new_rasterization_state)
    {
        if (_RasterizationState != new_rasterization_state)
        {
            _RasterizationState = new_rasterization_state;

            _Dirty = true;
        }
    }

    public void SetViewportState(in ViewportState new_viewport_state)
    {
        if (_ViewportState != new_viewport_state)
        {
            _ViewportState = new_viewport_state;

            _Dirty = true;
        }
    }

    public void SetMultisampleState(in MultisampleState new_multisample_state)
    {
        if (_MultisampleState != new_multisample_state)
        {
            _MultisampleState = new_multisample_state;

            _Dirty = true;
        }
    }

    public void SetDepthStencilState(in DepthStencilState new_depth_stencil_state)
    {
        if (_DepthStencilState != new_depth_stencil_state)
        {
            _DepthStencilState = new_depth_stencil_state;

            _Dirty = true;
        }
    }

    public void SetColorBlendState(in ColorBlendState new_color_blend_state)
    {
        if (_ColorBlendState != new_color_blend_state)
        {
            _ColorBlendState = new_color_blend_state;

            _Dirty = true;
        }
    }

    public void SetSubpassIndex(uint new_subpass_index)
    {
        if (_SubpassIndex != new_subpass_index)
        {
            _SubpassIndex = new_subpass_index;

            _Dirty = true;
        }
    }

    public PipelineLayout GetPipelineLayout()
    {
        Debug.Assert(_PipelineLayout && "Graphics state Pipeline layout is not set");
        return _PipelineLayout;
    }

    public RenderPass GetRenderPass()
    {
        return _RenderPass;
    }

    public SpecializationConstantState GetSpecializationConstantState()
    {
        return _SpecializationConstantState;
    }

    public VertexInputState GetVertexInputState()
    {
        return _VertexInputState;
    }

    public InputAssemblyState GetInputAssemblyState()
    {
        return _InputAssemblyState;
    }

    public RasterizationState GetRasterizationState()
    {
        return _RasterizationState;
    }

    public ViewportState GetViewportState()
    {
        return _ViewportState;
    }

    public MultisampleState GetMultisampleState()
    {
        return _MultisampleState;
    }

    public DepthStencilState GetDepthStencilState()
    {
        return _DepthStencilState;
    }

    public ColorBlendState GetColorBlendState()
    {
        return _ColorBlendState;
    }

    public uint GetSubpassIndex()
    {
        return _SubpassIndex;
    }

    public bool IsDirty()
    {
        return _Dirty || _SpecializationConstantState.IsDirty();
    }

    public void ClearDirty()
    {
        _Dirty = false;
        _SpecializationConstantState.ClearDirty();
    }

    private bool _Dirty = false;

    private PipelineLayout _PipelineLayout = new PipelineLayout(null);

    private readonly RenderPass _RenderPass = new RenderPass(null);

    private SpecializationConstantState _SpecializationConstantState = new SpecializationConstantState();

    private VertexInputState _VertexInputState = new VertexInputState();

    private InputAssemblyState _InputAssemblyState = new InputAssemblyState();

    private RasterizationState _RasterizationState = new RasterizationState();

    private ViewportState _ViewportState = new ViewportState();

    private MultisampleState _MultisampleState = new MultisampleState();

    private DepthStencilState _DepthStencilState = new DepthStencilState();

    private ColorBlendState _ColorBlendState = new ColorBlendState();

    private uint _SubpassIndex = new uint(0U);
}