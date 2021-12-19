using System.Runtime.InteropServices;

namespace Vulkan.Windows
{
    public struct SECURITY_ATTRIBUTES
    {
        [NativeTypeName("DWORD")] public uint NLength;

        [NativeTypeName("LPVOID")] public nint LpSecurityDescriptor;

        [NativeTypeName("WINBOOL")] public int BInheritHandle;
    }

    public struct LUID
    {
        public uint LowPart;
        public int  HighPart;
    }
}
