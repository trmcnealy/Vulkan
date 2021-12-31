using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Text;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace System
{
    [NonVersionable]
    public static class NativeInt
    {
        [Intrinsic]
        public static readonly nint Zero = 0;
    }


    [NonVersionable]
    public static class NativeIntExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe void* ToPointer(this nint @this)
        {
            return (void*)@this;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T* ToPointer<T>(this T[] array,
                                             out  int length)
            where T : unmanaged
        {
            length = array.Length;

            //GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);
            //IntPtr   ptr    = handle.AddrOfPinnedObject();
            //handle.Free();


            return (T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data);
            //return (T*)Unsafe.AsPointer(ref array[0]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T* ToPointer<T>(this T[]  array,
                                             out  uint length)
            where T : unmanaged
        {
            length = (uint)array.Length;

            return (T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data);
            //return (T*)Unsafe.AsPointer(ref array[0]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T* ToPointer<T>(this T[]   array,
                                             out  nuint length)
            where T : unmanaged
        {
            length = (nuint)array.Length;

            return (T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data);
            //return (T*)Unsafe.AsPointer(ref array[0]);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static uint ULength<T>(this T[] @this)
        {
            return (uint)@this.Length;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ArrayPointer<T> ToArrayPointer<T>(this T[] array)
            where T : unmanaged
        {
            return new ArrayPointer<T>((uint)array.Length, (T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data));
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T[] ToManagedArray<T>(uint length,
                                                   T*   arrayPtr)
            where T : unmanaged
        {
            T[] array = new T[(int)length];

            //int byteSize = (Unsafe.SizeOf<T>() * (int)length);
            //Buffer.MemoryCopy(arrayPtr, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);

            T*   src     = arrayPtr;
            uint counter = 0;

            while (counter < length)
            {
                Unsafe.Write(Unsafe.AsPointer(ref array[counter++]),
                             *src++);
            }

            //Unsafe.Write(Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data), *arrayPtr);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T[] ToManagedArray<T>(nuint length,
                                                   T*    arrayPtr)
            where T : unmanaged
        {
            T[] array = new T[(int)length];

            T*   src     = arrayPtr;
            uint counter = 0;

            while (counter < length)
            {
                Unsafe.Write(Unsafe.AsPointer(ref array[counter++]),
                             *src++);
            }

            //Unsafe.Write(Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data), *arrayPtr);

            return array;

            //RawArrayData rawArray = new RawArrayData
            //{
            //    Length = (uint)length,
            //    Data = Unsafe.AsRef<byte>(arrayPtr)
            //};


            //return Unsafe.As<T[]>(rawArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ArrayPointer<T> CreateArrayPointer<T>(int length)
            where T : unmanaged
        {
            int byteSize = (Unsafe.SizeOf<T>() * length);
            T*  pArray   = (T*)Marshal.AllocHGlobal(byteSize);

            return new ArrayPointer<T>((uint)length, pArray);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ArrayPointer<T> CreateArrayPointer<T>(uint length)
            where T : unmanaged
        {
            int byteSize = (Unsafe.SizeOf<T>() * (int)length);
            T*  pArray   = (T*)Marshal.AllocHGlobal(byteSize);

            return new ArrayPointer<T>((uint)length, pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ArrayPointer<T> CreateEnumArrayPointer<T>(int length)
            where T : unmanaged
        {
            int byteSize = (Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T))) * length);
            T*  pArray   = (T*)Marshal.AllocHGlobal(byteSize);

            return new ArrayPointer<T>((uint)length, pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe ArrayPointer<T> CreateEnumArrayPointer<T>(uint length)
            where T : unmanaged
        {
            int byteSize = (Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T))) * (int)length);
            T*  pArray   = (T*)Marshal.AllocHGlobal(byteSize);

            return new ArrayPointer<T>(length, pArray);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T[] CopyAndDeleteArrayPointer<T>(ArrayPointer<T> arrayPointer)
            where T : unmanaged
        {
            int byteSize = (Unsafe.SizeOf<T>() * (int)arrayPointer.Length);

            T[] array = new T[(int)arrayPointer.Length];

            Buffer.MemoryCopy(arrayPointer.Pointer, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);

            Marshal.FreeHGlobal((IntPtr)arrayPointer.Pointer);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static unsafe T[] CopyAndDeleteEnumArrayPointer<T>(ArrayPointer<T> arrayPointer)
            where T : unmanaged
        {
            int byteSize = (Marshal.SizeOf(Enum.GetUnderlyingType(typeof(T))) * (int)arrayPointer.Length);

            T[] array = new T[(int)arrayPointer.Length];

            Buffer.MemoryCopy(arrayPointer.Pointer, Unsafe.AsPointer(ref array[0]), byteSize, byteSize);

            Marshal.FreeHGlobal((IntPtr)arrayPointer.Pointer);

            return array;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ArrayPointer<T> : IDisposable
        where T : unmanaged
    {
        private static readonly int TSize;

        static ArrayPointer()
        {
            TSize = Unsafe.SizeOf<T>();
        }


        public uint Length;

        public T* Pointer;

        public ArrayPointer(T[] array)
        {
            Length  = (uint)array.Length;
            Pointer = Unsafe.As <RawArrayData<T>>(array).Data; //(T*)NativeMemory.AlignedAlloc((nuint)(Length * TSize), (nuint)TSize);

            GC.KeepAlive(this);
        }

        //(T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(array).Data)

        public ArrayPointer(uint length,
                            T*   pointer)
        {
            Length  = length;
            Pointer = pointer;

            GC.KeepAlive(this);
        }

        public void Dispose()
        {
        }
    }


    [NonVersionable]
    public static unsafe class NArray
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        [SuppressUnmanagedCodeSecurity]
        [SuppressGCTransition]
        [DllImport("kernel32.dll", ExactSpelling = true, EntryPoint = "VirtualAlloc", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern unsafe void* VirtualAlloc(void* lpAddress,
                                                         nuint dwSize,
                                                         uint  flAllocationType,
                                                         uint  flProtect);

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        [SuppressUnmanagedCodeSecurity]
        [SuppressGCTransition]
        [DllImport("kernel32.dll", ExactSpelling = true, EntryPoint = "VirtualFree", CharSet = CharSet.Unicode, SetLastError = true)]
        internal static extern unsafe uint VirtualFree(void* lpAddress,
                                                       nuint dwSize,
                                                       uint  dwFreeType);


        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public static T* Alloc<T>(uint numberOfElements)
        //    where T : unmanaged
        //{
        //    int sizeOfElement = Unsafe.SizeOf<T>();

        //    T* nArray = (T*)VirtualAlloc(null, sizeOfElement * (int)numberOfElements, 0x00001000 | 0x00002000, 0x10);
        //        //Marshal.AllocHGlobal(sizeOfElement * (int)numberOfElements);

        //    return nArray;
        //}
    }
    
    // Helper class to assist with unsafe pinning of arbitrary objects.
    // It's used by VM code.
    internal sealed class RawData
    {
        public byte Data;
    }
    
    public sealed class RawArrayData
    {
        public uint Length;
#if !X86 || TARGET_64BIT
        public uint Padding;
#endif
        public byte Data;
    }
    public sealed class RawArrayData<T>
        where T : unmanaged
    {
        public uint Length;
#if !X86 || TARGET_64BIT
        public uint Padding;
#endif
        public unsafe T* Data;
    }

    //[StructLayout(LayoutKind.Explicit)]
    //public struct ArrayUnion_nint
    //{
    //    [FieldOffset(0)]
    //    public nint[] Array;

    //    [FieldOffset(0)]
    //    public RawArrayData RawArray;
    //}


    //[NonVersionable]
    //public sealed unsafe class NativeArray<T> : IDisposable
    //    where T : unmanaged
    //{
    //    private static readonly Type _T = typeof(T);

    //    private static readonly int elementSize;


    //    public RawArrayData RawArray;

    //    public uint Length
    //    {
    //        get { return RawArray.Length; }
    //    }

    //    public T this[int index]
    //    {
    //        get { return ((T*)Unsafe.AsPointer(ref RawArray.Data))[index]; }
    //        set { ((T*)Unsafe.AsPointer(ref RawArray.Data))[index] = value; }
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    static NativeArray()
    //    {
    //        elementSize = Unsafe.SizeOf<T>();
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public NativeArray(uint numberOfElements)
    //    {
    //        uint byteSize = (uint)(elementSize * numberOfElements);

    //        RawArray = new RawArrayData
    //        {
    //            Length = numberOfElements, Data = Unsafe.AsRef<byte>(NArray.VirtualAlloc(null, byteSize, 0x00001000 | 0x00002000, 0x10)) //(void*)Marshal.AllocHGlobal(byteSize))
    //        };

    //        //void* ptrData = Unsafe.AsPointer(ref RawArray.Data);

    //        //ptrData = (void*)Marshal.AllocHGlobal(byteSize);

    //        GC.KeepAlive(this);
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public NativeArray(uint length,
    //                       nint nativePointer)
    //    {
    //        uint byteSize = (uint)(elementSize * length);

    //        RawArray = new RawArrayData
    //        {
    //            Length = length, Data = Unsafe.AsRef<byte>(NArray.VirtualAlloc(null, byteSize, 0x00001000 | 0x00002000, 0x10)) //(void*)Marshal.AllocHGlobal(byteSize))
    //        };

    //        void* ptrData = Unsafe.AsPointer(ref RawArray.Data);

    //        //int byteSize = (int)(elementSize * length);

    //        //ptrData = (void*)Marshal.AllocHGlobal(byteSize);

    //        Buffer.MemoryCopy((void*)nativePointer, ptrData, byteSize, byteSize);

    //        GC.KeepAlive(this);
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public NativeArray(uint length,
    //                       T*   nativePointer)
    //    {
    //        uint byteSize = (uint)(elementSize * length);

    //        RawArray = new RawArrayData
    //        {
    //            Length = length, Data = Unsafe.AsRef<byte>(NArray.VirtualAlloc(null, byteSize, 0x00001000 | 0x00002000, 0x10)) //(void*)Marshal.AllocHGlobal(byteSize))
    //        };

    //        void* ptrData = Unsafe.AsPointer(ref RawArray.Data);

    //        //ptrData = (void*)nativePointer;

    //        Buffer.MemoryCopy(nativePointer, ptrData, byteSize, byteSize);

    //        GC.KeepAlive(this);
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public NativeArray(T[] array)
    //    {
    //        RawArray = Unsafe.As<RawArrayData>(array);

    //        GC.KeepAlive(this);
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public static implicit operator T*(NativeArray<T> value)
    //    {
    //        return (T*)Unsafe.AsPointer(ref value.RawArray.Data);
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public static implicit operator T[](NativeArray<T> value)
    //    {
    //        T[] newT = new T[value.Length];

    //        //for(int i = 0; i < value.Length; i++)
    //        //{
    //        //    newT[i] = value[i];
    //        //}

    //        int byteSize = elementSize * (int)value.Length;

    //        Buffer.MemoryCopy(Unsafe.AsPointer(ref value.RawArray.Data), Unsafe.AsPointer(ref newT[0]), byteSize, byteSize);

    //        return newT; //Unsafe.As<RawArrayData, T[]>(ref value.RawArray);
    //    }

    //    //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    //public static implicit operator NativeArray<T>(T[] value)
    //    //{
    //    //    return new NativeArray<T>(value);
    //    //}

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public static T* GetPointer(T[]     value,
    //                                out int length)
    //    {
    //        length = (int)Unsafe.As<RawArrayData>(value).Length;

    //        RawArrayData rawArray = Unsafe.As<RawArrayData>(value);

    //        uint byteSize = (uint)(Unsafe.SizeOf<T>() * length);

    //        T* data = (T*)NArray.VirtualAlloc(null, byteSize, 0x00001000 | 0x00002000, 0x10); //Marshal.AllocHGlobal(Unsafe.SizeOf<T>() * (int)length);

    //        Buffer.MemoryCopy(Unsafe.AsPointer(ref rawArray.Data), data, byteSize, byteSize);

    //        return data;
    //    }

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    public static T* GetPointer(T[]      value,
    //                                out uint length)
    //    {
    //        length = Unsafe.As<RawArrayData>(value).Length;

    //        T* ptrData = (T*)Unsafe.AsPointer(ref Unsafe.As<RawArrayData>(value).Data);

    //        //RawArrayData rawArray = Unsafe.As<RawArrayData>(value);


    //        //long byteSize = (long)(Unsafe.SizeOf<T>() * length);

    //        //T* data = (T*)Marshal.AllocHGlobal(Unsafe.SizeOf<T>() * (int)length);

    //        //Buffer.MemoryCopy(ptrData, data, byteSize, byteSize);

    //        return ptrData;
    //    }

    //    //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    //public T[] ToManaged()
    //    //{
    //    //    T[] result = new T[Length];
    //    //    if(Instance == 0)
    //    //    {
    //    //        return result;
    //    //    }
    //    //    for(int i = 0; i < Length; ++i)
    //    //    {
    //    //        result[i] = data_pointer[i];
    //    //    }
    //    //    return result;
    //    //}

    //    //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    //public static T[] ToManaged(nint nativeArray,
    //    //                            uint length)
    //    //{
    //    //    RawArrayData rawArray = new()
    //    //    {
    //    //        Length = length,
    //    //        Data   = (byte*)nativeArray
    //    //    };

    //    //    return Unsafe.As<RawArrayData, T[]>(ref rawArray);
    //    //}

    //    #region IDisposable

    //    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    //    private void ReleaseUnmanagedResources()
    //    {
    //        NArray.VirtualFree(Unsafe.AsPointer(ref RawArray.Data), (uint)elementSize * RawArray.Length, 0x00008000);
    //        //Marshal.FreeHGlobal((IntPtr)Unsafe.AsPointer(ref RawArray.Data));
    //    }

    //    public void Dispose()
    //    {
    //        ReleaseUnmanagedResources();
    //        GC.SuppressFinalize(this);
    //    }

    //    ~NativeArray()
    //    {
    //        ReleaseUnmanagedResources();
    //    }

    //    #endregion
    //}


    [StructLayout(LayoutKind.Sequential)]
    public readonly struct Bool : IEquatable<Bool>
    {
        private static Bool _null = new(0);

        public static ref Bool Null
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get { return ref _null; }
        }

        public readonly uint Value;

        public Bool(bool value)
        {
            Value = value ? 1u : 0u;
        }

        public Bool(int value)
        {
            Value = (uint)value;
        }

        public Bool(uint value)
        {
            Value = value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Bool other)
        {
            return Value.Equals(other.Value);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Bool other && Equals(other);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            return Value.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator bool(Bool from)
        {
            return @from.Value == 1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator int(Bool from)
        {
            return (int)@from.Value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator uint(Bool from)
        {
            return @from.Value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Bool(bool from)
        {
            return new Bool(@from);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Bool(int from)
        {
            return new Bool(@from);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Bool(uint from)
        {
            return new Bool(@from);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Bool left,
                                       Bool right)
        {
            return left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Bool left,
                                       Bool right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(bool left,
                                       Bool right)
        {
            return left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(bool left,
                                       Bool right)
        {
            return !left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Bool left,
                                       bool right)
        {
            return left.Equals(right);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Bool left,
                                       bool right)
        {
            return !left.Equals(right);
        }
    }
}
