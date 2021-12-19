using System;

#if x86
using size_t = System.UInt32;
#else
#endif


namespace Cglm
{
    [Flags]
    public enum glm_euler_seq : uint
    {
        GLM_EULER_XYZ = (0 << 0 | 1 << 2 | 2 << 4),

        GLM_EULER_XZY = (0 << 0 | 2 << 2 | 1 << 4),

        GLM_EULER_YZX = (1 << 0 | 2 << 2 | 0 << 4),

        GLM_EULER_YXZ = (1 << 0 | 0 << 2 | 2 << 4),

        GLM_EULER_ZXY = (2 << 0 | 0 << 2 | 1 << 4),

        GLM_EULER_ZYX = (2 << 0 | 1 << 2 | 0 << 4),
    }



}
