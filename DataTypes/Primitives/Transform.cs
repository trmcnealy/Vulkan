#region

using System.Runtime.InteropServices;

#endregion

namespace Vulkan
{
    [StructLayout(LayoutKind.Explicit,
                  Size = Size)]
    public struct Transform
    {
        public const int Size  = Vector3F.Size + QuaternionF.Size + Vector3F.Size;
        public const int Align = Size;

        [FieldOffset(0)]
        public Vector3F Position;

        [FieldOffset(Vector3F.Size)]
        public QuaternionF Rotation;

        [FieldOffset(Vector3F.Size + QuaternionF.Size)]
        public Vector3F Scale;

        public Transform(Vector3F    position,
                         QuaternionF rotation,
                         Vector3F    scale)
        {
            Position = position;
            Rotation = rotation;
            Scale    = scale;
        }
    }
}
