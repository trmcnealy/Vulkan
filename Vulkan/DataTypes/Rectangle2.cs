using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public record Rectangle2
    {
        public static readonly Rectangle2 Empty = new(0f, 0f, 0f, 0f);


        [FieldOffset(0)]
        private float _x;

        [FieldOffset(sizeof(float))]
        private float _y;

        [FieldOffset(sizeof(float) * 2)]
        private float _width;

        [FieldOffset(sizeof(float) * 3)]
        private float _height;


        public float X
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _x; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _x = value; }
        }

        public float Y
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _y; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _y = value; }
        }

        public float Width
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _width; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _width = value; }
        }

        public float Height
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return _height; }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set { _height = value; }
        }

        public float Left
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return X; }
        }


        public float Top
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Y; }
        }


        public float Right
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return X + Width; }
        }

        public float Bottom
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return Y + Height; }
        }

        //public RectangleF(Vector2i pos,
        //                  float width,
        //                  float height)
        //{
        //    _x = pos.X;
        //    _y = pos.Y;
        //    _width = width;
        //    _height = height;
        //}

        //public RectangleF(Vector2i pos,
        //                  SizeI size)
        //{
        //    _x = pos.X;
        //    _y = pos.Y;
        //    _width = size.Width;
        //    _height = size.Height;
        //}

        public Rectangle2(float x,
                          float y,
                          float width,
                          float height)
        {
            _x      = x;
            _y      = y;
            _width  = width;
            _height = height;
        }

        public bool Contains(float x,
                             float y)
        {
            return X <= x && x < X + Width && Y <= y && y < Y + Height;
        }

        public void Intersect(Rectangle2 rect)
        {
            Rectangle2 result = Intersect(rect, this);

            X      = result.X;
            Y      = result.Y;
            Width  = result.Width;
            Height = result.Height;
        }

        public static Rectangle2 Intersect(Rectangle2 a,
                                           Rectangle2 b)
        {
            float x1 = MathF.Max(a.X, b.X);
            float x2 = MathF.Min(a.X + a.Width, b.X + b.Width);
            float y1 = MathF.Max(a.Y, b.Y);
            float y2 = MathF.Min(a.Y + a.Height, b.Y + b.Height);

            if (x2 >= x1 && y2 >= y1)
            {
                return new Rectangle2(x1, y1, x2 - x1, y2 - y1);
            }

            return Empty;
        }

        public static Rectangle2 Union(Rectangle2 a,
                                       Rectangle2 b)
        {
            float x1 = MathF.Min(a.X, b.X);
            float x2 = MathF.Max(a.X + a.Width, b.X + b.Width);
            float y1 = MathF.Min(a.Y, b.Y);
            float y2 = MathF.Max(a.Y + a.Height, b.Y + b.Height);

            return new Rectangle2(x1, y1, x2 - x1, y2 - y1);
        }

        //public void Offset(Vector2i pos)
        //{
        //    Offset(pos.X, pos.Y);
        //}

        public void Offset(float x,
                           float y)
        {
            X += x;
            Y += y;
        }
    }
}
