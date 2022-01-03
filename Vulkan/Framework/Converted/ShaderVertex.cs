using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    [StructLayout(LayoutKind.Explicit, Pack = Align, Size = Size)]
    [VertexInputBinding(Size, VkVertexInputRate.Vertex)]
    public struct ShaderVertex
    {
        public const int Size  = Vector3F.Size + Color4.Size;
        public const int Align = Vector3F.Align;

        [FieldOffset(0)]
        [VertexInput(0, VkFormat.R32G32B32A32Sfloat, 0)]
        public Vector3F Position;

        [FieldOffset(Vector3F.Size)]
        [VertexInput(1, VkFormat.R32G32B32A32Sfloat, Vector3F.Size)]
        public Color4 Color;

        public ShaderVertex(Vector3F position,
                            Color4   color)
        {
            Position = position;
            Color    = color;
        }
    }
}
