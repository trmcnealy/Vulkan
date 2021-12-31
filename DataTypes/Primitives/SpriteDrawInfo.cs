using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    public struct SpriteDrawInfo
    {
        public Rectangle2 Source;
        public Rectangle2 Destination;
        public Vector2F   Origin;
        public float      Rotation;
        public float      Depth;
        public int        SpriteEffects;
        public Color4     ColorScale;
        public Color4     ColorAdd;
        public int        Swizzle;
        public Vector2F   TextureSize;
        public int        Orientation;
    }
}
