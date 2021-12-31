using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezSubresourceLayout
{
    public ulong offset;
            
    public ulong size;
            
    public ulong rowPitch;
            
    public ulong arrayPitch;
            
    public ulong depthPitch;
}