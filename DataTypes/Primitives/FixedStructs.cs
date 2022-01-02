﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Vulkan
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct Fixed<T, NSize> : IDisposable, IEquatable<Fixed<T, NSize>>
        where T : unmanaged, IEquatable<T>
        where NSize : Const.IUInt
    {
        public static readonly uint ThisSize;
        public static readonly uint ThisTotalSize;

        static Fixed()
        {
            ThisSize      = (uint)Unsafe.SizeOf<T>();
            ThisTotalSize = ThisSize * NSize.Value;
        }

        //[FieldOffset(0)]
        public T* Values;

        public int Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return (int)NSize.Value;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Fixed()
        {
#if NET6_0_OR_GREATER
            Values = (T*)NativeMemory.AllocZeroed(ThisTotalSize + 1);
#else
            Values  = (T*)Marshal.AllocHGlobal(ThisTotalSize + 1);
#endif

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Fixed(Fixed<T, NSize> values)
        {
#if NET6_0_OR_GREATER
            Values = (T*)NativeMemory.AllocZeroed(ThisTotalSize + 1);
#else
            Values  = (T*)Marshal.AllocHGlobal(ThisTotalSize + 1);
#endif
            long bytesToCopy = ThisSize * Math.Min(Length, (uint)values.Length);

            System.Buffer.MemoryCopy(values.Values,
                                     Values,
                                     bytesToCopy,
                                     bytesToCopy);

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Fixed(T* values, int value_length)
        {
#if NET6_0_OR_GREATER
            Values = (T*)NativeMemory.AllocZeroed(ThisTotalSize + 1);
#else
            Valus  = (T*)Marshal.AllocHGlobal(ThisTotalSize + 1);
#endif
            long bytesToCopy = ThisSize * Math.Min(Length, (uint)value_length);

            System.Buffer.MemoryCopy(values,
                                     Values,
                                     bytesToCopy,
                                     bytesToCopy);

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Fixed(T[]? values)
        {
            if (values == null)
            {
                Values = null;
                return;
            }

            if (values.Length == 0)
            {
#if NET6_0_OR_GREATER
                Values = (T*)NativeMemory.AllocZeroed(1);
#else
                Values  = (T*)Marshal.AllocHGlobal(1);
#endif
                return;
            }

#if NET6_0_OR_GREATER
            Values = (T*)NativeMemory.AllocZeroed(ThisTotalSize + 1);
#else
            Values  = (T*)Marshal.AllocHGlobal(ThisTotalSize + 1);
#endif
            int elementsToCopy = Math.Min(Length, values.Length);
            
            for (int i = 0; i < elementsToCopy; i++)
            {
                Values[i] = values[i];
            }

            GC.KeepAlive(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Dispose()
        {
            DisposeUnmanaged();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        private void DisposeUnmanaged()
        {
            if (Values is not null)
            {
#if NET6_0_OR_GREATER
                NativeMemory.Free(Values);
#else
                Marshal.FreeHGlobal((IntPtr)Values);
#endif
            }
        }

        public T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return Values[index];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                Values[index] = value;
            }
        }

        public T this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                return Values[index];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                Values[index] = value;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator T*(Fixed<T, NSize> values)
        {
            return values.Values;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator T[](Fixed<T, NSize> values)
        {
            T[] newT = new T[NSize.Value];

            for (int i = 0; i < NSize.Value; i++)
            {
                newT[i] = values[i];
            }

            return newT;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static explicit operator Fixed<T, NSize>(T[] values)
        {
            return new Fixed<T, NSize>(values);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Values[0].ToString());

            for (int i = 1; i < NSize.Value; i++)
            {
                sb.Append("," + Values[i].ToString());
            }

            return sb.ToString();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(Fixed<T, NSize> other)
        {
            if (Length != other.Length)
            {
                return false;
            }

            T* src = Values;
            T* dst = other.Values;

            for (uint i = 0; i < NSize.Value; i++)
            {
                if (!(*src).Equals(*dst))
                {
                    return false;
                }

                src++;
                dst++;
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(T* other)
        {
            T* src = Values;
            T* dst = other;

            try
            {
                for (uint i = 0; i < NSize.Value; i++)
                {
                    if (!(*src).Equals(*dst))
                    {
                        return false;
                    }

                    src++;
                    dst++;
                }
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Equals(T[] other)
        {
            if (Length != other.Length)
            {
                return false;
            }

            T* src = Values;

            for (uint i = 0; i < NSize.Value; i++)
            {
                if (!(*src).Equals(other[i]))
                {
                    return false;
                }

                src++;
            }

            return true;
        }

        //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //public bool Equals(T* other)
        //{
        //    if (Length != GetLength(other))
        //    {
        //        return false;
        //    }

        //    T* src = Values;
        //    T* dst = other;

        //    while (*dst != 0)
        //    {
        //        if (*src++ != *dst++)
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override bool Equals(object? obj)
        {
            return obj is Fixed<T, NSize> other && Equals(other);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public override int GetHashCode()
        {
            HashCode code = new();

            for(uint i = 0; i < NSize.Value; i++)
            {
                code.Add(Values[i]);
            }

            return code.ToHashCode();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Fixed<T, NSize> left,
                                       Fixed<T, NSize> right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Fixed<T, NSize> left,
                                       Fixed<T, NSize> right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(Fixed<T, NSize> left,
                                       T[]     right)
        {
            return left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(Fixed<T, NSize> left,
                                       T[]             right)
        {
            return !left.Equals(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(T[]             left,
                                       Fixed<T, NSize> right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(T[]             left,
                                       Fixed<T, NSize> right)
        {
            return !right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator ==(T*     left,
                                       Fixed<T, NSize> right)
        {
            return right.Equals(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator !=(T*     left,
                                       Fixed<T, NSize> right)
        {
            return !right.Equals(left);
        }
    }
    
}
