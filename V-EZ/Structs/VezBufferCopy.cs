using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezBufferCopy
{
    public ulong srcOffset;
            
    public ulong dstOffset;
            
    public ulong size;
}