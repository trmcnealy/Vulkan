using System;

namespace Vulkan.Framework
{
    public sealed class Graphics
    {
        public static readonly Graphics Null = new();

        public GraphicsType                 type                { get; set; }
        public int                          flags               { get; set; }
        public bool                         support_pick        { get; set; }
        public nint                         user_data           { get; set; }
        public Renderpass                   renderpass          { get; set; }
        public uint                         subpass             { get; set; }
        public VkPrimitiveTopology          topology            { get; set; }
        public BlendType                    blend_type          { get; set; }
        public DepthTest                    depth_test          { get; set; }
        public VkPolygonMode                polygon_mode        { get; set; }
        public VkCullModeFlagBits           cull_mode           { get; set; }
        public VkFrontFace                  front_face          { get; set; }
        public VkPipeline                   pipeline            { get; set; }
        public Slots                        slots               { get; set; }
        public Array<Type>                  VertexInputs        { get; set; }
        public Array<Type>                  VertexInputBindings { get; set; }
        public Array<VkShaderStageFlagBits> shader_stages       { get; set; }
        public Array<VkShaderModule>        shader_modules      { get; set; }

        public unsafe delegate*<ref GraphicsData, uint, nint, void> callback { get; set; }

        private Graphics()
        {
            renderpass = Renderpass.Null;
            slots      = Slots.Null;

            VertexInputs        = Array.Empty<Type>();
            VertexInputBindings = Array.Empty<Type>();
            shader_stages       = Array.Empty<VkShaderStageFlagBits>();
            shader_modules      = Array.Empty<VkShaderModule>();
        }

        public Graphics(GraphicsType graphicsType)
        {
            type                = graphicsType;
            renderpass          = Renderpass.Null;
            slots               = Slots.Null;
            VertexInputs        = new();
            VertexInputBindings = new();
            shader_stages       = new();
            shader_modules      = new();
        }
    }
}
