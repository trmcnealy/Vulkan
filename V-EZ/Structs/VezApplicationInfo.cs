using System;
using System.Runtime.InteropServices;

namespace VEZ;

[StructLayout(LayoutKind.Sequential)]
public struct VezApplicationInfo
{
    public nint pNext;
            
    public nint pApplicationName;
            
    public uint applicationVersion;
            
    public nint pEngineName;
            
    public uint engineVersion;
}