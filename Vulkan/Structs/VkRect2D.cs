using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public struct VkRect2D
    {
        public VkOffset2D Offset;

        public VkExtent2D Extent;

        public int X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Offset.X; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Offset.X = value; }
        }

        public int Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Offset.Y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Offset.Y = value; }
        }

        public int CenterX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return (Offset.X + (int)(Extent.Width / 2f)); }
        }

        public int CenterY
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return (Offset.Y + (int)(Extent.Height / 2f)); }
        }

        public uint Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Extent.Width; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Extent.Width = value; }
        }

        public uint Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Extent.Height; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { Extent.Height = value; }
        }

        public int Left
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return X; }
        }


        public int Top
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Y; }
        }


        public int Right
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return (Offset.X + (int)Extent.Width); }
        }

        public int Bottom
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return (Offset.Y + (int)Extent.Height); }
        }

        public VkRect2D(int x, int y, uint width, uint height)
        {
            Offset = new VkOffset2D(x, y);
            Extent = new VkExtent2D(width, height);
        }
    }
}
