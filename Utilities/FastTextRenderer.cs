using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan
{
    public struct VertexPositionNormalTexture
    {
        public Vector3F Position;
        public Vector3F Normal;
        public Vector2F TextureCoordinate;

        public VertexPositionNormalTexture(Vector3F position,
                                           Vector3F normal,
                                           Vector2F textureCoordinate)
        {
            Position          = position;
            Normal            = normal;
            TextureCoordinate = textureCoordinate;
        }
    }

    public static class FastTextRenderer
    {
        public static readonly VertexPositionNormalTexture[] BaseVertexBufferData =
        {
            //  Position           Normal           UV Coordinates
            new(new(-1f,  1f, 0f), new(0f, 0f, 1f), new(0f, 0f)),
            new(new( 1f,  1f, 0f), new(0f, 0f, 1f), new(1f, 0f)),
            new(new(-1f, -1f, 0f), new(0f, 0f, 1f), new(0f, 1f)) ,
            new(new( 1f, -1f, 0f), new(0f, 0f, 1f), new(1f, 1f)),
        };

        public static void xnGraphicsFastTextRendererGenerateVertices(Rectangle2 constantInfos, Rectangle2 renderInfos, utf8string textPointer, ref int textLength, ref VertexPositionNormalTexture[] vertexBufferPointer)
        {
            float fX = renderInfos.X / renderInfos.Width;
            float fY = renderInfos.Y / renderInfos.Height;
            float fW = constantInfos.X / renderInfos.Width;
            float fH = constantInfos.Y / renderInfos.Height;

            Rectangle2 destination = new( fX, fY, fW, fH);
            Rectangle2 source      = new( 0.0f, 0.0f, constantInfos.X, constantInfos.Y );

            // Copy the array length (since it may change during an iteration)
            int textCharCount = textLength;

            float scaledDestinationX = 0.0f;
            float scaledDestinationY = -(destination.Y * 2.0f - 1.0f);

            float invertedWidth = 1.0f / constantInfos.Width;
            float invertedHeight = 1.0f / constantInfos.Height;

            uint vertexBufferPointerIndex = 0;

            for (int i = 0; i < textCharCount; i++)
            {
                sbyte currentChar = textPointer[i];

                if (currentChar == 11)
                {
                    // Tabulation
                    destination.X += 8 * fX;
                    --textLength;
                    continue;
                }

                if (currentChar is >= 10 and <= 13)
                {
                    // New Line
                    destination.X      =  fX;
                    destination.Y      += fH;
                    scaledDestinationY =  -(destination.Y * 2.0f - 1.0f);
                    --textLength;
                    continue;
                }

                if (currentChar is < 32 or > 126)
                {
                    currentChar = 32;
                }

                source.X = currentChar        % 32 * constantInfos.X;
                source.Y = (currentChar / 32) % 4  * constantInfos.Y;

                scaledDestinationX = (destination.X * 2.0f - 1.0f);

                // 0
                vertexBufferPointer[vertexBufferPointerIndex].Position.X = scaledDestinationX + BaseVertexBufferData[0].Position.X * destination.Width;
                vertexBufferPointer[vertexBufferPointerIndex].Position.Y = scaledDestinationY + BaseVertexBufferData[0].Position.Y * destination.Height;

                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.X = (source.X + BaseVertexBufferData[0].TextureCoordinate.X * source.Width) * invertedWidth;
                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.Y = (source.Y + BaseVertexBufferData[0].TextureCoordinate.Y * source.Height) * invertedHeight;

                ++vertexBufferPointerIndex;

                // 1
                vertexBufferPointer[vertexBufferPointerIndex].Position.X = scaledDestinationX + BaseVertexBufferData[1].Position.X * destination.Width;
                vertexBufferPointer[vertexBufferPointerIndex].Position.Y = scaledDestinationY + BaseVertexBufferData[1].Position.Y * destination.Height;

                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.X = (source.X + BaseVertexBufferData[1].TextureCoordinate.X * source.Width) * invertedWidth;
                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.Y = (source.Y + BaseVertexBufferData[1].TextureCoordinate.Y * source.Height) * invertedHeight;

                ++vertexBufferPointerIndex;

                // 2
                vertexBufferPointer[vertexBufferPointerIndex].Position.X = scaledDestinationX + BaseVertexBufferData[2].Position.X * destination.Width;
                vertexBufferPointer[vertexBufferPointerIndex].Position.Y = scaledDestinationY + BaseVertexBufferData[2].Position.Y * destination.Height;

                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.X = (source.X + BaseVertexBufferData[2].TextureCoordinate.X * source.Width) * invertedWidth;
                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.Y = (source.Y + BaseVertexBufferData[2].TextureCoordinate.Y * source.Height) * invertedHeight;

                ++vertexBufferPointerIndex;

                // 3
                vertexBufferPointer[vertexBufferPointerIndex].Position.X = scaledDestinationX + BaseVertexBufferData[3].Position.X * destination.Width;
                vertexBufferPointer[vertexBufferPointerIndex].Position.Y = scaledDestinationY + BaseVertexBufferData[3].Position.Y * destination.Height;

                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.X = (source.X + BaseVertexBufferData[3].TextureCoordinate.X * source.Width) * invertedWidth;
                vertexBufferPointer[vertexBufferPointerIndex].TextureCoordinate.Y = (source.Y + BaseVertexBufferData[3].TextureCoordinate.Y * source.Height) * invertedHeight;

                ++vertexBufferPointerIndex;

                destination.X += destination.Width;
            }
        }
    }
}
