using System;
using System.Runtime.CompilerServices;

namespace Vulkan
{
    public class Iterator<T> : IIterator<T>
        where T : notnull
    {
        private Array<T>? _array;

        private int _offset;

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Iterator()
        {
            _array = null;
            _offset = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Iterator(Array<T> iterator)
        {
            _array = iterator;
            _offset = 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Iterator(Array<T> iterator, int offset)
        {
            _array = iterator;
            _offset = offset;
        }

        public T this[int _Pos]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                Move(_Pos);

                if(_array != null)
                {
                    return _array[_offset];
                }

                return default!;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                Move(_Pos);

                if(/*value != null &&*/ _array != null)
                {
                    _array[_offset] = value;
                }
            }
        }

        public T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                if(_array != null)
                {
                    return _array[_offset];
                }
                return default!;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator T(Iterator<T> _Left)
        {
            return _Left.Current;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array<T>? Container()
        {
            return _array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int GetBias()
        {
            return _offset;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Valid()
        {
            int num;
            if(Container() != null && ValidBias(GetBias()))
            {
                num = 1;
            }
            else
            {
                num = 0;
            }
            return (byte)num != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        bool ValidBias(int _Pos)
        {
            return _array != null && (0 <= _Pos && _Pos <= _array.Count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Next()
        {
            _offset++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Prev()
        {
            if(!ValidBias(_offset - 1))
            {
                throw new InvalidOperationException();
            }
            _offset--;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int Move(int _Offset)
        {
            int num = _offset + _Offset;
            //if(!_Mycont.valid_bias(num))
            //{
            //    throw new InvalidOperationException();
            //}
            _offset = num;
            return num;
        }

        //public int distance(IRandomAccessIterator<TValue> _Right)
        //{
        //    if(container() != null && container() == _Right.container())
        //    {
        //        return get_bias() - _Right.get_bias();
        //    }
        //    throw new ArgumentException();
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int Distance(Iterator<T> _Right)
        {
            if(Container() != null && Container() == _Right.Container())
            {
                return GetBias() - _Right.GetBias();
            }
            throw new ArgumentException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool LessThan(Iterator<T> otherIterator)
        {
            if(Container() != null && Container() == otherIterator.Container())
            {
                return ((GetBias() >= otherIterator.GetBias()) ? 0 : 1) != 0;
            }
            throw new ArgumentException();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> operator +(Iterator<T> iterator, int offset)
        {
            iterator.Move(offset);
            return iterator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> operator ++(Iterator<T> iterator)
        {
            iterator.Next();
            return iterator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> operator -(Iterator<T> iterator, int offset)
        {
            iterator.Move(offset);
            return iterator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> operator --(Iterator<T> iterator)
        {
            iterator.Prev();
            return iterator;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <(Iterator<T> left, Iterator<T> right)
        {
            return left.LessThan(right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator <=(Iterator<T> left, Iterator<T> right)
        {
            return (right.LessThan(left) ? 0 : 1) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >(Iterator<T> left, Iterator<T> right)
        {
            return right.LessThan(left);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static bool operator >=(Iterator<T> left, Iterator<T> right)
        {
            return (left.LessThan(right) ? 0 : 1) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> Move(Iterator<T> iterator)
        {
            iterator.Next();
            return iterator;
        }

        // find first matching value; choose optimization
        // activate optimization for pointers to (const) bytes and integral values
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> _Find_unchecked(Iterator<T> first, Iterator<T> last, T value)
        {
            for(; first != last; ++first)
            {
                if(/*first.Current != null &&*/ first.Current.Equals(value))
                {
                    break;
                }
            }
            return (first);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static Iterator<T> Remove(Iterator<T> first, Iterator<T> last, T value)
        {
            first = _Find_unchecked(first, last, value);
            Iterator<T> _Next = first;

            if(first != last)
            {
                while(++first != last)
                {
                    if(/*first.Current != null &&*/ !(first.Current.Equals(value)))
                    {
                        _Next = Move(first);
                        ++_Next;
                    }
                }
            }

            return (_Next);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static int Distance(Iterator<T> _First, Iterator<T> _Last)
        {
            int _Off = 0;
            for(; _First != _Last; ++_First)
            {
                ++_Off;
            }

            return (_Off);
        }
    }
}
