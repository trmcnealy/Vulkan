using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Size2
    {
        [FieldOffset(0)]
        private float _width;

        [FieldOffset(sizeof(float))]
        private float _height;


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

        public Size2(float width,
                      float height)
        {
            _width  = width;
            _height = height;
        }
    }
}
