using System.Runtime.CompilerServices;

namespace Vulkan
{
    public static class Module
    {
        //[ModuleInitializer]
        //internal static void Initialize()
        //{
        //    DllMap.Register();
        //}
    }
}


namespace System
{
    public static class DoubleExt
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static double FMod(this double a, double b)
        {
            return a - b * Math.Truncate(a / b);
        }
    }
}
