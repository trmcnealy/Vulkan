using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Vulkan
{
    [DebuggerDisplay("Count = {Count}")]
    [DataContract, Serializable]
    public class Array<T> : IArray<T>, IComparable<Array<T>>, ICollection //, IEnumerable<T> //, IList<T>, IList, IReadOnlyList<T> //where T : IComparable<T>
        where T : notnull
    {
        protected const int DefaultCapacity = 4;

        protected const int MaxArrayLength = 0X7FEFFFFF;

        protected static readonly T[] EmptyArray = new T[0];

        [DataMember]
        //volatile
        public T[] _items;

        [ContractPublicPropertyName("Count")]
        [DataMember]
        protected uint _size;

        [DataMember]
        public bool LockSize;

        [NonSerialized]
        protected object _syncRoot = new();

        [DataMember]
        protected int _version;

        [DataMember]
        protected int[] _arrayversion;

        //Object System.Collections.IList.this[int index]
        //{
        //	get
        //	{
        //		return this[index];
        //	}
        //	set
        //	{
        //		//ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(value, ExceptionArgument.value);

        //		try
        //		{
        //			this[index] = (T)value;
        //		}
        //		catch (InvalidCastException)
        //		{
        //			//ThrowHelper.ThrowWrongValueTypeArgumentException(value, typeof(T));
        //		}
        //	}
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array()
        {
            _items        = EmptyArray;
            _arrayversion = new int[Capacity];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(int  capacity,
                     bool init = false)
        {
            //if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            //Contract.EndContractBlock();

            if(typeof(T).IsClass && !typeof(T).IsAbstract)
            {
                init = true;
            }

            if(init)
            {
                _items = capacity == 0 ? EmptyArray : new T[capacity];

                for(int i = 0; i < capacity; ++i)
                {
                    _items[i] = Activator.CreateInstance<T>();
                }

                _size = (uint)capacity;
            }
            else
            {
                _items = capacity == 0 ? EmptyArray : new T[capacity];
            }

            _arrayversion = new int[Capacity];
        }

        //      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //      public Array(int capacity)
        //{
        //	//if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
        //	//Contract.EndContractBlock();

        //	_items = capacity == 0 ? EmptyArray : new T[capacity];
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(int capacity,
                     T   value)
        {
            //if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            //Contract.EndContractBlock();

            _items        = capacity == 0 ? EmptyArray : new T[capacity];
            _arrayversion = new int[Capacity];

            for(int i = 0; i < capacity; ++i)
            {
                _items[i] = value;
                _arrayversion[i]++;
            }

            _size = (uint)capacity;
        }

        public Array(T[] collection)
        {
            if(collection is null)
                throw new ArgumentNullException(nameof(collection));

            int count = collection.Length;

            if(count == 0)
            {
                _items        = EmptyArray;
                _arrayversion = new int[Capacity];
            }
            else
            {
                _items        = new T[count];
                _arrayversion = new int[Capacity];
                collection.CopyTo(_items, 0);
                _size = (uint)count;
            }
        }

        //      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //      public Array(int capacity, T value)
        //{
        //	//if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
        //	//Contract.EndContractBlock();

        //	_items = capacity == 0 ? EmptyArray : new T[capacity];

        //	for(int i = 0; i < capacity; ++i)
        //		_items[i] = value;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(IEnumerable<T> collection)
        {
            if(collection is null)
                throw new ArgumentNullException(nameof(collection));

            //Contract.EndContractBlock();

            if(collection is ICollection<T> c)
            {
                int count = c.Count;

                if(count == 0)
                {
                    _items        = EmptyArray;
                    _arrayversion = new int[Capacity];
                }
                else
                {
                    _items        = new T[count];
                    _arrayversion = new int[Capacity];
                    c.CopyTo(_items, 0);
                    _size = (uint)count;
                }
            }
            else
            {
                _size         = 0;
                _items        = EmptyArray;
                _arrayversion = new int[Capacity];

                // This enumerable could be empty.  Let Add allocate a new array, if needed.
                // Note it will also go to _defaultCapacity first, not 1, then 2, etc.

                using(IEnumerator<T> en = collection.GetEnumerator())
                {
                    while(en.MoveNext())
                    {
                        Add(en.Current);
                    }
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(uint capacity)
        {
            //if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            //Contract.EndContractBlock();

            _items        = capacity == 0 ? EmptyArray : new T[capacity];
            _arrayversion = new int[Capacity];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(long capacity)
        {
            //if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            //Contract.EndContractBlock();

            _items        = capacity == 0 ? EmptyArray : new T[capacity];
            _arrayversion = new int[Capacity];
        }

        //      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //      public Array(int capacity)
        //{
        //	//if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
        //	//Contract.EndContractBlock();

        //	_items = capacity == 0 ? EmptyArray : new T[capacity];
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array(uint capacity,
                     T    value)
        {
            //if (capacity < 0) throw new ArgumentOutOfRangeException(nameof(capacity));
            //Contract.EndContractBlock();

            _items        = capacity == 0 ? EmptyArray : new T[capacity];
            _arrayversion = new int[Capacity];

            for(int i = 0; i < capacity; ++i)
            {
                _items[i] = value;
                _arrayversion[i]++;
            }
        }

        //public Array(ArraySlice1D<T> slice,
        //             bool allItems = true)
        //{
        //    if(allItems)
        //    {
        //        _items = slice._values;
        //    }
        //    else
        //    {
        //        _items = slice.ToArray(Count);
        //    }
        //    _arrayversion = new int[Capacity];
        //}

        public int Capacity
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                //Contract.Ensures(Contract.Result<int>() >= 0);
                return _items.Length;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                //if(value < _size)
                //{
                //    throw new ArgumentOutOfRangeException(nameof(value), "ArgumentOutOfRange_SmallCapacity");
                //}

                //Contract.EndContractBlock();

                if(value != _items.Length)
                {
                    if(value > 0)
                    {
                        T[] newItems = new T[value];

                        if(_size > 0)
                        {
                            Array.Copy(_items, 0, newItems, 0, Math.Min((int)_size, newItems.Length));
                        }

                        if(typeof(T).IsClass && !typeof(T).IsAbstract)
                        {
                            _items = newItems;

                            for(int i = 0; i < _items.Length; ++i)
                            {
                                _items[i] = Activator.CreateInstance<T>();
                            }
                        }
                        else
                        {
                            _items = newItems;
                        }

                        _arrayversion = new int[Capacity];
                    }
                    else
                    {
                        _items        = EmptyArray;
                        _arrayversion = new int[Capacity];
                    }
                }
            }
        }

        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                //Contract.Ensures(//Contract.Result<int>() >= 0);
                return (int)_size;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public T this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                // Following trick can reduce the range check by one
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                return _items[index];
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                if(index >= _size)
                {
                    EnsureCapacity(_size + 1);
                }

                //Contract.EndContractBlock();
                _items[index] = value;

                if(_arrayversion[index] == 0)
                {
                    _size++;
                }

                _arrayversion[index]++;
                _version++;
            }
        }
        
        public T this[uint index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                // Following trick can reduce the range check by one
                if(index >= _size)
                {
                    EnsureCapacity(_size + (index - _size));
                }

                //Contract.EndContractBlock();
                return _items[index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                _items[index] = value;

                if(_arrayversion[index] == 0)
                {
                    _size++;
                }

                _arrayversion[index]++;
                _version++;
            }
        }

        public T this[long index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                // Following trick can reduce the range check by one
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                return _items[index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                _items[index] = value;

                if(_arrayversion[index] == 0)
                {
                    _size++;
                }

                _arrayversion[index]++;
                _version++;
            }
        }

        public T this[ulong index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                // Following trick can reduce the range check by one
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                return _items[index];
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                //if (index >= _size)
                //{
                //throw new ArgumentOutOfRangeException();

                //}
                //Contract.EndContractBlock();
                _items[index] = value;

                if(_arrayversion[index] == 0)
                {
                    _size++;
                }

                _arrayversion[index]++;
                _version++;
            }
        }

        
        public Array<T> this[Range range]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            get
            {
                uint count = (uint)(range.End.Value - range.Start.Value);

                Array<T> list = new(count);

                Array.Copy(_items, range.Start.Value, list._items, 0, count);

                list._size = count;

                return list;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            set
            {
                uint count = (uint)(range.End.Value - range.Start.Value);

                Array.Copy(value._items, range.Start.Value, _items, 0, count);
                
                for (int i = range.Start.Value; i < count; i++)
                {
                    if(_arrayversion[i] == 0)
                    {
                        _size++;
                    }

                    _arrayversion[i]++;
                }

                _version++;
            }
        }
        

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref T Ref(int index)
        {
            return ref _items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref T Ref(uint index)
        {
            return ref _items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref T Ref(long index)
        {
            return ref _items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public ref T Ref(ulong index)
        {
            return ref _items[index];
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Add(T item)
        {
            if(_size == _items.Length)
                EnsureCapacity(_size + 1);

            _items[_size++] = item;
            _version++;
        }

        //int System.Collections.IList.Add(Object item)
        //{
        //	//ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);

        //	try
        //	{
        //		Add((T)item);
        //	}
        //	catch (InvalidCastException)
        //	{
        //		//ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
        //	}

        //	return (int)Count - 1;
        //}
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void AddRange(IEnumerable<T> collection)
        {
            //Contract.Ensures(Count >= //Contract.OldValue(Count));

            InsertRange((int)_size, collection);
        }

        //public ReadOnlyCollection<T> AsReadOnly()
        //{
        //	//Contract.Ensures(//Contract.Result<ReadOnlyCollection<T>>() != null);
        //	return new ReadOnlyCollection<T>(this);
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Assign(Predicate<T> condition,
                           T            value)
        {
            bool valueWasAssigned = false;

            for(int i = 0; i < _size; i++)
            {
                if(condition(_items[i]))
                {
                    _items[i]        = value;
                    valueWasAssigned = true;

                    break;
                }
            }

            if(!valueWasAssigned)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }
        }

        public void Assign(int count,
                           T   value)
        {
            // assign _Count * _Val
            if(Capacity < count)
            {
                Resize(count);
            }
            else
            {
                Clear();
            }

            if(value != null)
            {
                _size = 0;

                for(int i = 0; i < count; i++)
                {
                    _items[_size++] = value;
                }

                //InsertRange(0, count, value);
            }
            else
            {
                _size = 0;

                for(int i = 0; i < count; i++)
                {
                    _items[_size++] = Activator.CreateInstance<T>();
                }

                //InsertRange(0, count, Activator.CreateInstance<T>());
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Assign(int            count,
                           IEnumerable<T> collection)
        {
            // assign _Count * _Val
            if(Capacity < count)
            {
                Resize(count);
            }
            else
            {
                Clear();
            }

            _size = 0;

            if(collection is IList<T> c)
            {
                for(int i = 0; i < count; i++)
                {
                    _items[_size++] = c[i];
                }
            }
            else
            {
                foreach(T item in collection)
                {
                    if(_size == count)
                    {
                        break;
                    }

                    _items[_size++] = item;
                }
            }
        }

        //public void Assign(IEnumerator<double> first, IEnumerator<double> last)
        //{
        //    if(_Iter_container(first) != this)
        //    {
        //        Clear();
        //    }

        //    int _Oldsize = Count;

        //    using(IEnumerator<double> en = first->GetEnumerator())
        //    {
        //        while(en->MoveNext())
        //        {
        //            _Func(en->Current);
        //        }
        //    }

        //    for(; !first->equal_to(last); first->next())
        //    {
        //        Insert(Count, 1, (value_type)first->get_cref()); // append new stuff
        //    }
        //    erase_n(0, _Oldsize);   // erase any leftover old stuff
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int BinarySearch(int          index,
                                int          count,
                                T            item,
                                IComparer<T>? comparer)
        {
            if(index < 0)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(count < 0)
                throw new ArgumentOutOfRangeException(nameof(count));

            if(_size - index < count)
                throw new ArgumentException("Argument_InvalidOffLen");

            //Contract.Ensures(//Contract.Result<int>() <= index + count);
            //Contract.EndContractBlock();

            //if(_items != null)
            {
                return Array.BinarySearch(_items, index, count, item, comparer);
            }

            //return -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int BinarySearch(T item)
        {
            //Contract.Ensures(//Contract.Result<int>() <= Count);
            return BinarySearch(0, Count, item, null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int BinarySearch(T            item,
                                IComparer<T> comparer)
        {
            //Contract.Ensures(//Contract.Result<int>() <= Count);
            return BinarySearch(0, Count, item, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Clear()
        {
            if(_size > 0)
            {
                Array.Clear(_items, 0, (int)_size); // Don't need to doc this but we clear the elements so that the gc can reclaim the references.
                _arrayversion = new int[Capacity];
                _size         = 0;
            }

            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Contains(T item)
        {
            if(item is null)
            {
                for(int i = 0; i < _size; i++)
                    if(_items[i] is null)
                        return true;

                return false;
            }

            EqualityComparer<T> c = EqualityComparer<T>.Default;

            for(int i = 0; i < _size; i++)
            {
                if(c.Equals(_items[i], item))
                    return true;
            }

            return false;
        }

        //bool System.Collections.IList.Contains(Object item)
        //{
        //	if (IsCompatibleObject(item))
        //	{
        //		return Contains((T)item);
        //	}
        //	return false;
        //}

        //public Array<TDestination> ArrayCast<TDestination>()
        //{
        //    Array<TDestination> typedSource = _items as Array<TDestination>;

        //    if(typedSource != null)
        //    {
        //        return typedSource;
        //    }

        //    if(_items is null)
        //    {
        //        throw new ArgumentNullException(nameof(_items));
        //    }

        //    return CastIterator<T, TDestination>(_items);
        //}

        //private static Array<TDestination> CastIterator<TSource, TDestination>(Array<TSource> source)
        //{
        //    Array<TDestination> toArray = new Array<TDestination>(source.Count);

        //    foreach(TSource obj in source)
        //    {
        //        toArray.Add((TDestination)(object)obj);
        //    }

        //    return toArray;
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
            where TOutput : IComparable<TOutput>
        {
            if(converter is null)
            {
                throw new ArgumentNullException(nameof(converter));
            }

            //Contract.EndContractBlock();

            Array<TOutput> list = new Array<TOutput>(_size);

            for(int i = 0; i < _size; i++)
            {
                list._items[i] = converter(_items[i]);
            }

            list._size = _size;

            return list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTo(T[] array)
        {
            CopyTo(array, 0);
        }

        void ICollection.CopyTo(Array? array,
                                int   arrayIndex)
        {
            if((array != null) && (array.Rank != 1))
            {
                throw new ArgumentException("Arg RankMultiDimNotSupported");
            }

            Contract.EndContractBlock();

            try
            {
                // Array.Copy will check for NULL.
                Array.Copy(_items, 0, array!, arrayIndex, _size);
            }
            catch(ArrayTypeMismatchException)
            {
                throw new ArgumentException("Argument InvalidArrayType");
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTo(int index,
                           T[] array,
                           int arrayIndex,
                           int count)
        {
            if(_size - index < count)
            {
                throw new ArgumentException("Argument_InvalidOffLen");
            }

            //Contract.EndContractBlock();

            // Delegate rest of error checking to Array.Copy.
            Array.Copy(_items, index, array, arrayIndex, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTo(T[] array,
                           int arrayIndex)
        {
            // Delegate rest of error checking to Array.Copy.
            Array.Copy(_items, 0, array, arrayIndex, _size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Exists(Predicate<T> match)
        {
            return FindIndex(match) != -1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T? Find(Predicate<T>? match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            if(_items is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            for(int i = 0; i < _size; i++)
            {
                if(match(_items[i]))
                {
                    return _items[i];
                }
            }

            return default!;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array<T> FindAll(Predicate<T> match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.EndContractBlock();

            Array<T> list = new Array<T>();

            for(int i = 0; i < _size; i++)
            {
                if(match(_items[i]))
                {
                    list.Add(_items[i]);
                }
            }

            return list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindIndex(Predicate<T> match)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            return FindIndex(0, (int)_size, match);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindIndex(int          startIndex,
                             Predicate<T> match)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < startIndex + Count);
            return FindIndex(startIndex, (int)_size - startIndex, match);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindIndex(int          startIndex,
                             int          count,
                             Predicate<T> match)
        {
            if(startIndex > _size)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if(startIndex > _size - count) //count < 0 ||
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < startIndex + count);
            //Contract.EndContractBlock();

            int endIndex = startIndex + count;

            for(int i = startIndex; i < endIndex; i++)
            {
                if(match(_items[i]))
                    return i;
            }

            throw new Exception();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T FindLast(Predicate<T>? match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.EndContractBlock();

            for(uint i = _size - 1; i > 0; i--)
            {
                if(match(_items[i]))
                {
                    return _items[i];
                }
            }

            return default!;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindLastIndex(Predicate<T> match)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            return FindLastIndex((int)_size - 1, (int)_size, match);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindLastIndex(int          startIndex,
                                 Predicate<T> match)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() <= startIndex);
            return FindLastIndex(startIndex, startIndex + 1, match);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int FindLastIndex(int          startIndex,
                                 int          count,
                                 Predicate<T> match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() <= startIndex);
            //Contract.EndContractBlock();

            if(_size == 0)
            {
                // Special case for 0 length Array
                if(startIndex != -1)
                {
                    throw new ArgumentOutOfRangeException(nameof(startIndex));
                }
            }
            else
            {
                // Make sure we're not out of range
                if(startIndex >= _size)
                {
                    throw new ArgumentOutOfRangeException(nameof(startIndex));
                }
            }

            // 2nd have of this also catches when startIndex == MAXINT, so MAXINT - 0 + 1 == -1, which is < 0.
            //if (startIndex - count + 1 < 0) //count < 0 ||
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count), "ArgumentOutOfRange_Count");
            //}

            int endIndex = startIndex - count;

            for(int i = startIndex; i > endIndex; i--)
            {
                if(match(_items[i]))
                {
                    return i;
                }
            }

            throw new Exception();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void ForEach(Action<T> action)
        {
            if(action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            //Contract.EndContractBlock();

            int version = _version;

            for(int i = 0; i < _size; i++)
            {
                if(version != _version) // && BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
                {
                    break;
                }

                action(_items[i]);
            }

            if(version != _version) // && BinaryCompatibility.TargetsAtLeast_Desktop_V4_5)
                throw new InvalidOperationException("InvalidOperation_EnumFailedVersion");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T At(int index)
        {
            return _items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T At(uint index)
        {
            return _items[index];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Array<T> GetRange(int index,
                                 int count)
        {
            //if (index < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(index));
            //}

            //if (count < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count));
            //}

            if(_size - index < count)
            {
                throw new ArgumentException("Argument_InvalidOffLen");
            }

            //Contract.Ensures(//Contract.Result<Array<T>>() != null);
            //Contract.EndContractBlock();

            Array<T> list = new Array<T>(count);
            Array.Copy(_items, index, list._items, 0, count);
            list._size = (uint)count;

            return list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]

        //[CLSCompliant(false)]
        public Array<T> GetRange(uint index,
                                 uint count)

        {
            //if (index < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(index));
            //}

            //if (count < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count));
            //}

            if(_size - index < count)
            {
                throw new ArgumentException("Argument_InvalidOffLen");
            }

            //Contract.Ensures(//Contract.Result<Array<T>>() != null);
            //Contract.EndContractBlock();

            Array<T> list = new Array<T>(count);
            Array.Copy(_items, index, list._items, 0, count);
            list._size = count;

            return list;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int IndexOf(T item)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            return Array.IndexOf(_items, item, 0, (int)_size);
        }

        //int System.Collections.IList.IndexOf(Object item)
        //{
        //	if (IsCompatibleObject(item))
        //	{
        //		return (int)IndexOf((T)item);
        //	}
        //	throw new Exception();
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int IndexOf(T   item,
                           int index)
        {
            if(index > _size)
                throw new ArgumentOutOfRangeException(nameof(index));

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            //Contract.EndContractBlock();
            return Array.IndexOf(_items, item, index, (int)_size - index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int IndexOf(T   item,
                           int index,
                           int count)
        {
            if(index > _size)
                throw new ArgumentOutOfRangeException(nameof(index));

            if(index > _size - count) //count < 0 ||
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            //Contract.EndContractBlock();

            return Array.IndexOf(_items, item, index, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Insert(int index,
                           T   item)
        {
            // Note that insertions at the end are legal.
            if(index > _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            //Contract.EndContractBlock();
            if(_size == _items.Length)
                EnsureCapacity(_size + 1);

            if(index < _size)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }

            _items[index] = item;
            _size++;
            _version++;
        }

        //[CLSCompliant(false)]
        public void Insert(uint index,
                           T    item)
        {
            // Note that insertions at the end are legal.
            if(index > _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            //Contract.EndContractBlock();
            if(_size == _items.Length)
                EnsureCapacity(_size + 1);

            if(index < _size)
            {
                Array.Copy(_items, index, _items, index + 1, _size - index);
            }

            _items[index] = item;
            _size++;
            _version++;
        }

        public Iterator<T> Iterator { get { return new Iterator<T>(this); } }

        //void System.Collections.IList.Insert(int index, Object item)
        //{
        //	//ThrowHelper.IfNullAndNullsAreIllegalThenThrow<T>(item, ExceptionArgument.item);

        //	try
        //	{
        //		Insert((int)index, (T)item);
        //	}
        //	catch (InvalidCastException)
        //	{
        //		//ThrowHelper.ThrowWrongValueTypeArgumentException(item, typeof(T));
        //	}
        //}
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void InsertRange(int index,
                                int count,
                                T   collection)
        {
            if(collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if(index > _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            //Contract.EndContractBlock();

            if(collection is ICollection<T> c)
            {
                // if collection is ICollection<T>
                if(c.Count < count)
                {
                    throw new ArgumentOutOfRangeException(nameof(count));
                }

                //int count = (int)c.Count;
                if(count > 0)
                {
                    EnsureCapacity(_size + (uint)count);

                    if(index < _size)
                    {
                        Array.Copy(_items, index, _items, index + count, _size - index);
                    }

                    // If we're inserting a Array into itself, we want to be able to deal with that.
                    if(Equals(this, c))
                    {
                        // Copy first part of _items to insert location
                        Array.Copy(_items, 0, _items, index, index);

                        // Copy last part of _items back to inserted location
                        Array.Copy(_items, index + count, _items, index * 2, _size - index);
                    }
                    else
                    {
                        T[] itemsToInsert = new T[count];
                        c.CopyTo(itemsToInsert, 0);
                        itemsToInsert.CopyTo(_items, index);
                    }

                    _size += (uint)count;
                }
            }
            else
            {
                if(collection is IEnumerable enumerable)
                {
                    IEnumerator en = enumerable.GetEnumerator();

                    //{
                    while(en.MoveNext())
                    {
                        Insert(index++, (T)en.Current);
                    }

                    //}
                }
            }

            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void InsertRange(int            index,
                                IEnumerable<T> collection)
        {
            if(collection is null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if(index > Capacity)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            //Contract.EndContractBlock();

            if(collection is ICollection<T> c)
            {
                // if collection is ICollection<T>
                int count = c.Count;

                if(count > 0)
                {
                    EnsureCapacity(_size + (uint)count);

                    if(index < _size)
                    {
                        Array.Copy(_items, index, _items, index + count, _size - index);
                    }

                    // If we're inserting a Array into itself, we want to be able to deal with that.
                    if(Equals(this, c))
                    {
                        // Copy first part of _items to insert location
                        Array.Copy(_items, 0, _items, index, index);

                        // Copy last part of _items back to inserted location
                        Array.Copy(_items, index + count, _items, index * 2, _size - index);
                    }
                    else
                    {
                        T[] itemsToInsert = new T[count];
                        c.CopyTo(itemsToInsert, 0);
                        itemsToInsert.CopyTo(_items, index);
                    }

                    _size += (uint)count;
                }
            }
            else
            {
                using(IEnumerator<T> en = collection.GetEnumerator())
                {
                    while(en.MoveNext())
                    {
                        Insert(index++, en.Current);
                    }
                }
            }

            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int LastIndexOf(T item)
        {
            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(//Contract.Result<int>() < Count);
            if(_size == 0)
            {
                // Special case for empty list
                throw new Exception();
            }

            return LastIndexOf(item, (int)_size - 1, (int)_size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int LastIndexOf(T   item,
                               int index)
        {
            if(index >= _size)
                throw new ArgumentOutOfRangeException(nameof(index));

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(((Count == 0) && (//Contract.Result<int>() == -1)) || ((Count > 0) && (//Contract.Result<int>() <= index)));
            //Contract.EndContractBlock();
            return LastIndexOf(item, index, index + 1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int LastIndexOf(T   item,
                               int index,
                               int count)
        {
            if(Count != 0) // && (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if(Count != 0) // && (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            //Contract.Ensures(//Contract.Result<int>() >= -1);
            //Contract.Ensures(((Count == 0) && (//Contract.Result<int>() == -1)) || ((Count > 0) && (//Contract.Result<int>() <= index)));
            //Contract.EndContractBlock();

            if(_size == 0)
            {
                // Special case for empty list
                throw new Exception();
            }

            if(index >= _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if(count > index + 1)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            return Array.LastIndexOf(_items, item, index, count);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool Remove(T item)
        {
            int index = IndexOf(item);

            //if (index >= 0)
            //{
            RemoveAt(index);

            return true;

            //}

            //return false;
        }

        public Iterator<T> Remove(Iterator<T> iterator)
        {
            int _Bias = iterator.GetBias();

            return new Iterator<T>(this, Remove(_Bias, _Bias + 1));
        }

        public Iterator<T> Remove(Iterator<T> first,
                                  Iterator<T> last)
        {
            return new Iterator<T>(this, Remove(first.GetBias(), last.GetBias()));
        }

        public int Remove(int first,
                          int last)
        {
            if(first < 0 || last < first || Count < last)
            {
                throw new InvalidOperationException();
            }

            if(first != last)
            {
                for(int _Next = first; _Next != last; ++_Next)
                {
                    RemoveAt(_Next);
                }

                _size = (uint)Copy(_items, last, Count, first);
                ++_version;
            }

            return first;
        }

        //void System.Collections.IList.Remove(Object item)
        //{
        //	if (IsCompatibleObject(item))
        //	{
        //		Remove((T)item);
        //	}
        //}

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public int RemoveAll(Predicate<T> match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.Ensures(//Contract.Result<int>() >= 0);
            //Contract.Ensures(//Contract.Result<int>() <= //Contract.OldValue(Count));
            //Contract.EndContractBlock();

            int freeIndex = 0; // the first free slot in items array

            // Find the first item which needs to be removed.
            while(freeIndex < _size && !match(_items[freeIndex]))
                freeIndex++;

            if(freeIndex >= _size)
                return 0;

            int current = freeIndex + 1;

            while(current < _size)
            {
                // Find the first item which needs to be kept.
                while(current < _size && match(_items[current]))
                    current++;

                if(current < _size)
                {
                    // copy item to the free slot.
                    _items[freeIndex++] = _items[current++];
                }
            }

            Array.Clear(_items, freeIndex, (int)_size - freeIndex);
            int result = (int)_size                   - freeIndex;
            _size = (uint)freeIndex;
            _version++;

            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RemoveAt(int index)
        {
            if(index >= _size)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Contract.EndContractBlock();
            _size--;

            if(index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }

            _items[_size] = default!;
            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void RemoveRange(int index,
                                int count)
        {
            //if (index < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(index));
            //}

            //if (count < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count));
            //}

            if(_size - index < count)
                throw new ArgumentException("Argument_InvalidOffLen");

            //Contract.EndContractBlock();

            if(count > 0)
            {
                //int i = _size;
                _size -= (uint)count;

                if(index < _size)
                {
                    Array.Copy(_items, index + count, _items, index, _size - index);
                }

                Array.Clear(_items, (int)_size, count);
                _version++;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Resize(int size)
        {
            Capacity = size;
            _size    = 0; // (uint)size;

            for(int i = 0; i < _arrayversion.Length; i++)
            {
                _arrayversion[i] = 1;
            }
        }

        public void Resize(int size,
                           T   value)
        {
            int orgCapacity = Capacity;

            Capacity = size;
            _size    = (uint)size;

            for(int i = orgCapacity; i < Capacity; ++i)
            {
                _items[i] = value;
            }

            for(int i = 0; i < _arrayversion.Length; i++)
            {
                _arrayversion[i] = 1;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Reverse(int index,
                            int count)
        {
            //if (index < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(index));
            //}

            //if (count < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count));
            //}

            if(_size - index < count)
                throw new ArgumentException("Argument_InvalidOffLen");

            //Contract.EndContractBlock();
            Array.Reverse(_items, index, count);
            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T[] Reverse(bool copy = true)
        {
            if(copy)
            {
                T[] newItems = new T[Count];
                Array.Copy(_items, newItems, Count);
                Array.Reverse(newItems, 0, Count);

                return newItems;
            }

            Reverse(0, Count);

            return _items;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Sort()
        {
            Sort(0, Count, null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Sort(IComparer<T>? comparer)
        {
            Sort(0, Count, comparer);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Sort(int          index,
                         int          count,
                         IComparer<T>? comparer)
        {
            //if (index < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(index));
            //}

            //if (count < 0)
            //{
            //	throw new ArgumentOutOfRangeException(nameof(count));
            //}

            if(_size - index < count)
                throw new ArgumentException("Argument_InvalidOffLen");

            //Contract.EndContractBlock();

            //if(_items != null)
            //{
                Array.Sort(_items, index, count, comparer);
            //}

            _version++;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Sort(Comparison<T> comparison)
        {
            if(comparison is null)
            {
                throw new ArgumentNullException(nameof(comparison));
            }

            //Contract.EndContractBlock();

            if(_size > 0)// && _items is not null)
            {
                IComparer<T> comparer = new FunctorComparer(comparison);
                Array.Sort(_items, 0, (int)_size, comparer);
            }
        }

        public void Swap(T leftItem,
                         T rightItem)
        {
            int indexA = IndexOf(leftItem);
            int indexB = IndexOf(rightItem);

            Swap(indexA, indexB);
        }

        public void Swap(int indexA,
                         int indexB)
        {
            T tmp = _items[indexA];
            _items[indexA] = _items[indexB];
            _items[indexB] = tmp;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public T[] ToArray()
        {
            //Contract.Ensures(//Contract.Result<T[]>() != null);
            //Contract.Ensures(//Contract.Result<T[]>().Count == Count);

            T[] array = new T[_size];
            Array.Copy(_items, 0, array, 0, _size);

            return array;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void TrimExcess()
        {
            int threshold = (int)(_items.Length * 0.9);

            if(_size < threshold)
            {
                Capacity = (int)_size;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public bool TrueForAll(Predicate<T> match)
        {
            if(match is null)
            {
                throw new ArgumentNullException(nameof(match));
            }

            //Contract.EndContractBlock();

            for(int i = 0; i < _size; i++)
            {
                if(!match(_items[i]))
                {
                    return false;
                }
            }

            return true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new Enumerator(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new Enumerator(this);
        }

        //public static implicit operator Array<T>(ArraySlice1D<T> slice)
        //{
        //    return new Array<T>(slice);
        //}

        public int Copy(T[] _Source,
                        int first,
                        int last,
                        int _Dest)
        {
            for(; first != last; ++first, ++_Dest)
            {
                _items[_Dest] = _Source[first];
            }

            return _Dest;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void CopyTo(Array<T> array)
        {
            CopyTo(array._items, 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void DeepCopy(Array<T> av)
        {
            if(av.Count == 0)
            {
                return;
            }

            Capacity = av.Count - 0 + 1;

            //if(_items != null)
            //{
                av.CopyTo(_items, 0);
            //}
        }

        //[CLSCompliant(false), MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public T At(uint index)
        //{
        //    return _items[index];
        //}

        //bool System.Collections.IList.IsFixedSize
        //{
        //	get { return false; }
        //}
        //bool ICollection<T>.IsReadOnly
        //{
        //	get { return false; }
        //}

        //bool System.Collections.IList.IsReadOnly
        //{
        //	get { return false; }
        //}

        bool ICollection.IsSynchronized { get { return false; } }

        object ICollection.SyncRoot
        {
            get
            {
                System.Threading.Interlocked.CompareExchange(ref _syncRoot, new object(), null);

                return _syncRoot;
            }
        }

        //      public T this[int index]
        //{
        //          [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //          get
        //	{
        //		// Following trick can reduce the range check by one
        //		if (index >= _size)
        //		{
        //			throw new ArgumentOutOfRangeException();
        //		}
        //		//Contract.EndContractBlock();
        //		return _items[index];
        //	}
        //          [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        //          set
        //	{
        //		if (index >= _size)
        //		{
        //			throw new ArgumentOutOfRangeException();
        //		}
        //		//Contract.EndContractBlock();
        //		_items[index] = value;
        //		_version++;
        //	}
        //}

        public Iterator<T> Begin()
        {
            return new Iterator<T>(this, 0);
        }

        public Iterator<T> End()
        {
            return new Iterator<T>(this, Count);
        }

        // Returns an enumerator for this list with the given
        // permission for removal of elements. If modifications made to the list
        // while an enumeration is in progress, the MoveNext and
        // GetObject methods of the enumerator will throw an exception.
        //
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public Enumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public void Resize(uint size)
        {
            Capacity = (int)size;
            _size    = 0;

            for(int i = 0; i < _arrayversion.Length; i++)
            {
                _arrayversion[i] = 1;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static implicit operator Array<T>(T[] array)
        {
            return new Array<T>(array);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        protected static bool IsCompatibleObject(object value)
        {
            // Non-null values are fine.  Only accept nulls if T is a class or Nullable<U>.
            // Note that default(T) is not equal to null for value types except when T is Nullable<U>.
            return value is T || (/*value is null &&*/ default(T) is null);
        }

        // Ensures that the capacity of this list is at least the given minimum
        // value. If the currect capacity of the list is less than min, the
        // capacity is increased to twice the current capacity or to min,
        // whichever is larger.

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        protected void EnsureCapacity(int min)
        {
            if(_items.Length < min && !LockSize)
            {
                int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;

                // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
                // Note that this check works even when _items.Count overflowed thanks to the (int) cast
                if(newCapacity > MaxArrayLength)
                    newCapacity = MaxArrayLength;

                if(newCapacity < min)
                    newCapacity = min;

                Capacity = newCapacity;
            }
        }

        protected void EnsureCapacity(uint min)
        {
            if(_items.Length < min && !LockSize)
            {
                int newCapacity = _items.Length == 0 ? DefaultCapacity : _items.Length * 2;

                // Allow the list to grow to maximum possible capacity (~2G elements) before encountering overflow.
                // Note that this check works even when _items.Count overflowed thanks to the (int) cast
                if(newCapacity > MaxArrayLength)
                    newCapacity = MaxArrayLength;

                if(newCapacity < min)
                    newCapacity = (int)min;

                Capacity = newCapacity;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        public static IArray<T> Synchronized(Array<T> array)
        {
            return new SynchronizedArray(array);
        }

        protected sealed class FunctorComparer : IComparer<T>
        {
            public readonly Comparison<T> _comparison;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public FunctorComparer(Comparison<T> comparison)
            {
                _comparison = comparison;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            int IComparer<T>.Compare(T? x,
                                     T? y)
            {
                if(x is not null && y is not null)
                {
                    return _comparison(x, y);
                }

                return -1;
            }
        }

        [Serializable]
        internal class SynchronizedArray : IArray<T>
        {
            protected readonly Array<T> _array;

            protected readonly object _root;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            internal SynchronizedArray(Array<T> array)
            {
                _array = array;

                if(array is ICollection collection)
                {
                    _root = collection.SyncRoot;
                }
                else
                {
                    _root = new();
                }
            }

            public int Count
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array.Count;
                    }
                }
            }

            public bool IsReadOnly
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array is ICollection<T> {IsReadOnly: true};
                    }
                }
            }

            public int Capacity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array.Capacity;
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_root)
                    {
                        _array.Capacity = value;
                    }
                }
            }

            public T this[uint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array[index];
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_root)
                    {
                        _array[index] = value;
                    }
                }
            }

            public T this[long index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array[index];
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_root)
                    {
                        _array[index] = value;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Add(T item)
            {
                lock(_root)
                {
                    _array.Add(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Clear()
            {
                lock(_root)
                {
                    _array.Clear();
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Contains(T item)
            {
                lock(_root)
                {
                    return _array.Contains(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void CopyTo(T[] array,
                               int arrayIndex)
            {
                lock(_root)
                {
                    _array.CopyTo(array, arrayIndex);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool Remove(T item)
            {
                lock(_root)
                {
                    return _array.Remove(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            IEnumerator IEnumerable.GetEnumerator()
            {
                lock(_root)
                {
                    return _array.GetEnumerator();
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            IEnumerator<T> IEnumerable<T>.GetEnumerator()
            {
                lock(_root)
                {
                    return ((IEnumerable<T>)_array).GetEnumerator();
                }
            }

            public T this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_root)
                    {
                        return _array[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_root)
                    {
                        _array[index] = value;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public int IndexOf(T item)
            {
                lock(_root)
                {
                    return _array.IndexOf(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Insert(int index,
                               T   item)
            {
                lock(_root)
                {
                    _array.Insert(index, item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void RemoveAt(int index)
            {
                lock(_root)
                {
                    _array.RemoveAt(index);
                }
            }

            public void AddRange(IEnumerable<T> collection)
            {
                lock(_root)
                {
                    _array.AddRange(collection);
                }
            }

            public void Assign(int count,
                               T   value)
            {
                lock(_root)
                {
                    _array.Assign(count, value);
                }
            }

            public int BinarySearch(int          index,
                                    int          count,
                                    T            item,
                                    IComparer<T> comparer)
            {
                lock(_root)
                {
                    return _array.BinarySearch(index, count, item, comparer);
                }
            }

            public int BinarySearch(T item)
            {
                lock(_root)
                {
                    return _array.BinarySearch(item);
                }
            }

            public int BinarySearch(T            item,
                                    IComparer<T> comparer)
            {
                lock(_root)
                {
                    return _array.BinarySearch(item, comparer);
                }
            }

            public Array<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
                where TOutput : IComparable<TOutput>
            {
                lock(_root)
                {
                    return _array.ConvertAll<TOutput>(converter);
                }
            }

            public void CopyTo(T[] array)
            {
                lock(_root)
                {
                    _array.CopyTo(array);
                }
            }

            public void CopyTo(int index,
                               T[] array,
                               int arrayIndex,
                               int count)
            {
                lock(_root)
                {
                    _array.CopyTo(index, array, arrayIndex, count);
                }
            }

            public bool Exists(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.Exists(match);
                }
            }

            public T? Find(Predicate<T>? match)
            {
                if(match is null)
                {
                    return default!;
                }

                lock(_root)
                {
                    return _array.Find(match);
                }
            }

            public Array<T> FindAll(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindAll(match);
                }
            }

            public int FindIndex(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindIndex(match);
                }
            }

            public int FindIndex(int          startIndex,
                                 Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindIndex(startIndex, match);
                }
            }

            public int FindIndex(int          startIndex,
                                 int          count,
                                 Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindIndex(startIndex, count, match);
                }
            }

            public T? FindLast(Predicate<T>? match)
            {
                if(match is null)
                {
                    return default!;
                }

                lock(_root)
                {
                    return _array.FindLast(match);
                }
            }

            public int FindLastIndex(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindLastIndex(match);
                }
            }

            public int FindLastIndex(int          startIndex,
                                     Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindLastIndex(startIndex, match);
                }
            }

            public int FindLastIndex(int          startIndex,
                                     int          count,
                                     Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.FindLastIndex(startIndex, count, match);
                }
            }

            public void ForEach(Action<T> action)
            {
                lock(_root)
                {
                    _array.ForEach(action);
                }
            }

            public T At(int index)
            {
                lock(_root)
                {
                    return _array.At(index);
                }
            }

            public Array<T> GetRange(int index,
                                     int count)
            {
                lock(_root)
                {
                    return _array.GetRange(index, count);
                }
            }

            public int IndexOf(T   item,
                               int index)
            {
                lock(_root)
                {
                    return _array.IndexOf(item, index);
                }
            }

            public int IndexOf(T   item,
                               int index,
                               int count)
            {
                lock(_root)
                {
                    return _array.IndexOf(item, index, count);
                }
            }

            public void InsertRange(int index,
                                    int count,
                                    T   collection)
            {
                lock(_root)
                {
                    _array.InsertRange(index, count, collection);
                }
            }

            public void InsertRange(int            index,
                                    IEnumerable<T> collection)
            {
                lock(_root)
                {
                    _array.InsertRange(index, collection);
                }
            }

            public int LastIndexOf(T item)
            {
                lock(_root)
                {
                    return _array.LastIndexOf(item);
                }
            }

            public int LastIndexOf(T   item,
                                   int index)
            {
                lock(_root)
                {
                    return _array.LastIndexOf(item, index);
                }
            }

            public int LastIndexOf(T   item,
                                   int index,
                                   int count)
            {
                lock(_root)
                {
                    return _array.LastIndexOf(item, index, count);
                }
            }

            public int RemoveAll(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.RemoveAll(match);
                }
            }

            public void RemoveRange(int index,
                                    int count)
            {
                lock(_root)
                {
                    _array.RemoveRange(index, count);
                }
            }

            public void Resize(int size)
            {
                lock(_root)
                {
                    _array.Resize(size);
                }
            }

            public void Reverse(int index,
                                int count)
            {
                lock(_root)
                {
                    _array.Reverse(index, count);
                }
            }

            public T[] Reverse(bool copy = true)
            {
                lock(_root)
                {
                    return _array.Reverse(copy);
                }
            }

            public void Sort()
            {
                lock(_root)
                {
                    _array.Sort();
                }
            }

            public void Sort(IComparer<T> comparer)
            {
                lock(_root)
                {
                    _array.Sort(comparer);
                }
            }

            public void Sort(int          index,
                             int          count,
                             IComparer<T> comparer)
            {
                lock(_root)
                {
                    _array.Sort(index, count, comparer);
                }
            }

            public void Sort(Comparison<T> comparison)
            {
                lock(_root)
                {
                    _array.Sort(comparison);
                }
            }

            public T[] ToArray()
            {
                lock(_root)
                {
                    return _array.ToArray();
                }
            }

            public void TrimExcess()
            {
                lock(_root)
                {
                    _array.TrimExcess();
                }
            }

            public bool TrueForAll(Predicate<T> match)
            {
                lock(_root)
                {
                    return _array.TrueForAll(match);
                }
            }

            public void Assign(int            count,
                               IEnumerable<T> collection)
            {
                lock(_root)
                {
                    _array.Assign(count, collection);
                }
            }

            public void Assign(Predicate<T> condition,
                               T            value)
            {
                lock(_root)
                {
                    _array.Assign(condition, value);
                }
            }

            public T At(uint index)
            {
                lock(_root)
                {
                    return _array.At(index);
                }
            }

            public Iterator<T> Begin()
            {
                lock(_root)
                {
                    return _array.Begin();
                }
            }

            public int CompareTo(Array<T> other)
            {
                lock(_root)
                {
                    return _array.CompareTo(other);
                }
            }

            public void CopyTo(Array<T> array)
            {
                lock(_root)
                {
                    _array.CopyTo(array);
                }
            }

            public void DeepCopy(Array<T> av)
            {
                lock(_root)
                {
                    _array.DeepCopy(av);
                }
            }

            public Iterator<T> End()
            {
                lock(_root)
                {
                    return _array.End();
                }
            }

            public Array<T> GetRange(uint index,
                                     uint count)
            {
                lock(_root)
                {
                    return _array.GetRange(index, count);
                }
            }

            public void Insert(uint index,
                               T    item)
            {
                lock(_root)
                {
                    _array.Insert(index, item);
                }
            }

            public void Resize(int size,
                               T   value)
            {
                lock(_root)
                {
                    _array.Resize(size, value);
                }
            }

            public void Resize(uint size)
            {
                lock(_root)
                {
                    _array.Resize(size);
                }
            }

            public void Swap(int indexA,
                             int indexB)
            {
                lock(_root)
                {
                    _array.Swap(indexA, indexB);
                }
            }

            public void Swap(T leftItem,
                             T rightItem)
            {
                lock(_root)
                {
                    _array.Swap(leftItem, rightItem);
                }
            }
        }

        [DebuggerDisplay("Count = {Count}")]
        [DataContract, Serializable]
        public class SynchronizedArray<TType> : Array<TType>
            where TType : notnull
        {
            protected readonly Array<TType> _array;

            //protected readonly object _root;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            internal SynchronizedArray(Array<TType> array)
            {
                _items        = array._items;
                _size         = array._size;
                LockSize      = array.LockSize;
                _syncRoot     = new object();
                _version      = array._version;
                _arrayversion = array._arrayversion;

                _array = array;

                //var collection = array as ICollection;
                //if(collection != null)
                //{
                //    _root = collection.SyncRoot;
                //}
            }

            public new int Count
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_syncRoot)
                    {
                        return base.Count;
                    }
                }
            }

            public new bool IsReadOnly
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get { return _array.IsReadOnly; }
            }

            public new int Capacity
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_syncRoot)
                    {
                        return base.Capacity;
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_syncRoot)
                    {
                        base.Capacity = value;
                    }
                }
            }

            public new TType? this[uint index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_syncRoot)
                    {
                        return base[index];
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_syncRoot)
                    {
                        base[index] = value!;
                    }
                }
            }

            public new TType? this[long index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_syncRoot)
                    {
                        return base[index];
                    }
                }
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_syncRoot)
                    {
                        base[index] = value!;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new void Add(TType item)
            {
                lock(_syncRoot)
                {
                    base.Add(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new void Clear()
            {
                lock(_syncRoot)
                {
                    base.Clear();
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new bool Contains(TType item)
            {
                lock(_syncRoot)
                {
                    return base.Contains(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new void CopyTo(TType[] array,
                                   int     arrayIndex)
            {
                lock(_syncRoot)
                {
                    base.CopyTo(array, arrayIndex);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new bool Remove(TType item)
            {
                lock(_syncRoot)
                {
                    return base.Remove(item);
                }
            }

            //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            //IEnumerator IEnumerable.GetEnumerator()
            //{
            //    lock(_syncRoot)
            //    {
            //        return base.GetEnumerator();
            //    }
            //}

            //[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            //IEnumerator<TType> IEnumerable<TType>.GetEnumerator()
            //{
            //    lock(_syncRoot)
            //    {
            //        return base.GetEnumerator();
            //    }
            //}

            public new TType this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    lock(_syncRoot)
                    {
                        return base[index];
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                set
                {
                    lock(_syncRoot)
                    {
                        base[index] = value;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new int IndexOf(TType item)
            {
                lock(_syncRoot)
                {
                    return base.IndexOf(item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new void Insert(int   index,
                                   TType item)
            {
                lock(_syncRoot)
                {
                    base.Insert(index, item);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public new void RemoveAt(int index)
            {
                lock(_syncRoot)
                {
                    base.RemoveAt(index);
                }
            }

            public new void AddRange(IEnumerable<TType> collection)
            {
                lock(_syncRoot)
                {
                    base.AddRange(collection);
                }
            }

            public new void Assign(int   count,
                                   TType value)
            {
                lock(_syncRoot)
                {
                    base.Assign(count, value);
                }
            }

            public new int BinarySearch(int              index,
                                        int              count,
                                        TType            item,
                                        IComparer<TType> comparer)
            {
                lock(_syncRoot)
                {
                    return base.BinarySearch(index, count, item, comparer);
                }
            }

            public new int BinarySearch(TType item)
            {
                lock(_syncRoot)
                {
                    return base.BinarySearch(item);
                }
            }

            public new int BinarySearch(TType            item,
                                        IComparer<TType> comparer)
            {
                lock(_syncRoot)
                {
                    return base.BinarySearch(item, comparer);
                }
            }

            public new Array<TOutput> ConvertAll<TOutput>(Converter<TType, TOutput> converter)
                where TOutput : IComparable<TOutput>
            {
                lock(_syncRoot)
                {
                    return base.ConvertAll<TOutput>(converter);
                }
            }

            public new void CopyTo(TType[] array)
            {
                lock(_syncRoot)
                {
                    base.CopyTo(array);
                }
            }

            public new void CopyTo(int     index,
                                   TType[] array,
                                   int     arrayIndex,
                                   int     count)
            {
                lock(_syncRoot)
                {
                    base.CopyTo(index, array, arrayIndex, count);
                }
            }

            public new bool Exists(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.Exists(match);
                }
            }

            public new TType? Find(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.Find(match);
                }
            }

            public new Array<TType> FindAll(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindAll(match);
                }
            }

            public new int FindIndex(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindIndex(match);
                }
            }

            public new int FindIndex(int              startIndex,
                                     Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindIndex(startIndex, match);
                }
            }

            public new int FindIndex(int              startIndex,
                                     int              count,
                                     Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindIndex(startIndex, count, match);
                }
            }

            public new TType? FindLast(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindLast(match);
                }
            }

            public new int FindLastIndex(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindLastIndex(match);
                }
            }

            public new int FindLastIndex(int              startIndex,
                                         Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindLastIndex(startIndex, match);
                }
            }

            public new int FindLastIndex(int              startIndex,
                                         int              count,
                                         Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.FindLastIndex(startIndex, count, match);
                }
            }

            public new void ForEach(Action<TType> action)
            {
                lock(_syncRoot)
                {
                    base.ForEach(action);
                }
            }

            public new TType At(int index)
            {
                lock(_syncRoot)
                {
                    return base.At(index);
                }
            }

            public new Array<TType> GetRange(int index,
                                             int count)
            {
                lock(_syncRoot)
                {
                    return base.GetRange(index, count);
                }
            }

            public new int IndexOf(TType item,
                                   int   index)
            {
                lock(_syncRoot)
                {
                    return base.IndexOf(item, index);
                }
            }

            public new int IndexOf(TType item,
                                   int   index,
                                   int   count)
            {
                lock(_syncRoot)
                {
                    return base.IndexOf(item, index, count);
                }
            }

            public new void InsertRange(int   index,
                                        int   count,
                                        TType collection)
            {
                lock(_syncRoot)
                {
                    base.InsertRange(index, count, collection);
                }
            }

            public new void InsertRange(int                index,
                                        IEnumerable<TType> collection)
            {
                lock(_syncRoot)
                {
                    base.InsertRange(index, collection);
                }
            }

            public new int LastIndexOf(TType item)
            {
                lock(_syncRoot)
                {
                    return base.LastIndexOf(item);
                }
            }

            public new int LastIndexOf(TType item,
                                       int   index)
            {
                lock(_syncRoot)
                {
                    return base.LastIndexOf(item, index);
                }
            }

            public new int LastIndexOf(TType item,
                                       int   index,
                                       int   count)
            {
                lock(_syncRoot)
                {
                    return base.LastIndexOf(item, index, count);
                }
            }

            public new int RemoveAll(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.RemoveAll(match);
                }
            }

            public new void RemoveRange(int index,
                                        int count)
            {
                lock(_syncRoot)
                {
                    base.RemoveRange(index, count);
                }
            }

            public new void Resize(int size)
            {
                lock(_syncRoot)
                {
                    base.Resize(size);
                }
            }

            public new void Reverse(int index,
                                    int count)
            {
                lock(_syncRoot)
                {
                    base.Reverse(index, count);
                }
            }

            public new TType[] Reverse(bool copy = true)
            {
                lock(_syncRoot)
                {
                    return base.Reverse(copy);
                }
            }

            public new void Sort()
            {
                lock(_syncRoot)
                {
                    base.Sort();
                }
            }

            public new void Sort(IComparer<TType> comparer)
            {
                lock(_syncRoot)
                {
                    base.Sort(comparer);
                }
            }

            public new void Sort(int              index,
                                 int              count,
                                 IComparer<TType> comparer)
            {
                lock(_syncRoot)
                {
                    base.Sort(index, count, comparer);
                }
            }

            public new void Sort(Comparison<TType> comparison)
            {
                lock(_syncRoot)
                {
                    base.Sort(comparison);
                }
            }

            public new TType[] ToArray()
            {
                lock(_syncRoot)
                {
                    return base.ToArray();
                }
            }

            public new void TrimExcess()
            {
                lock(_syncRoot)
                {
                    base.TrimExcess();
                }
            }

            public new bool TrueForAll(Predicate<TType> match)
            {
                lock(_syncRoot)
                {
                    return base.TrueForAll(match);
                }
            }

            public new void Assign(int                count,
                                   IEnumerable<TType> collection)
            {
                lock(_syncRoot)
                {
                    base.Assign(count, collection);
                }
            }

            public new void Assign(Predicate<TType> condition,
                                   TType            value)
            {
                lock(_syncRoot)
                {
                    base.Assign(condition, value);
                }
            }

            public new TType At(uint index)
            {
                lock(_syncRoot)
                {
                    return base.At(index);
                }
            }

            public new Iterator<TType> Begin()
            {
                lock(_syncRoot)
                {
                    return base.Begin();
                }
            }

            public new int CompareTo(Array<TType> other)
            {
                lock(_syncRoot)
                {
                    return base.CompareTo(other);
                }
            }

            public new void CopyTo(Array<TType> array)
            {
                lock(_syncRoot)
                {
                    base.CopyTo(array);
                }
            }

            public new void DeepCopy(Array<TType> av)
            {
                lock(_syncRoot)
                {
                    base.DeepCopy(av);
                }
            }

            public new Iterator<TType> End()
            {
                lock(_syncRoot)
                {
                    return base.End();
                }
            }

            public new Array<TType> GetRange(uint index,
                                             uint count)
            {
                lock(_syncRoot)
                {
                    return base.GetRange(index, count);
                }
            }

            public new void Insert(uint  index,
                                   TType item)
            {
                lock(_syncRoot)
                {
                    base.Insert(index, item);
                }
            }

            public new void Resize(int   size,
                                   TType value)
            {
                lock(_syncRoot)
                {
                    base.Resize(size, value);
                }
            }

            public new void Resize(uint size)
            {
                lock(_syncRoot)
                {
                    base.Resize(size);
                }
            }

            public new void Swap(int indexA,
                                 int indexB)
            {
                lock(_syncRoot)
                {
                    base.Swap(indexA, indexB);
                }
            }

            public new void Swap(TType leftItem,
                                 TType rightItem)
            {
                lock(_syncRoot)
                {
                    base.Swap(leftItem, rightItem);
                }
            }
        }

        [Serializable]
        public struct Enumerator : IEnumerator<T>
        {
            private readonly Array<T> _list;

            private int _index;

            private readonly int version;

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            internal Enumerator(Array<T> list)
            {
                _list   = list;
                _index  = 0;
                version = list._version;
                Current = default!;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void Dispose()
            {
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public bool MoveNext()
            {
                Array<T>? localList = _list;

                if(version == localList._version && (_index < localList._size))
                {
                    Current = localList._items[_index];
                    _index++;

                    return true;
                }

                return MoveNextRare();
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            private bool MoveNextRare()
            {
                if(version != _list._version)
                {
                    throw new InvalidOperationException("InvalidOperation_EnumFailedVersion");
                }

                _index  = (int)_list._size + 1;
                Current = default!;

                return false;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public void SetIndex(int index)
            {
                _index = index;
            }

            public T Current
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get;
                private set;
            }

            object? IEnumerator.Current
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
                get
                {
                    if(_index == 0 || _index == _list._size + 1)
                    {
                        throw new InvalidOperationException("InvalidOperation_EnumOpCantHappen");
                    }

                    return Current;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            void IEnumerator.Reset()
            {
                if(version != _list._version)
                {
                    throw new InvalidOperationException("InvalidOperation_EnumFailedVersion");
                }

                _index  = 0;
                Current = default!;
            }
        }

        #region Implementation of IComparable<in Array<T>>

        public int CompareTo(Array<T>? other)
        {
            return Lexicographical(this, other);
        }

        protected int Lexicographical(Array<T>? operand1,
                                      Array<T>? operand2)
        {
            if(operand1 == null || operand2 == null)
            {
                return 0;
            }

            int first1 = 0;              // operand1.Begin();
            int last1  = operand1.Count; // operand1.End();
            int first2 = 0;              // operand2.Begin();
            int last2  = operand2.Count; //operand2.End();

            int compare;

            for(; first1 != last1 && first2 != last2; ++first1, ++first2)
            {
                compare = Compare(operand1[first1], operand2[first2]);

                if(compare != 0)
                {
                    return compare;
                }
            }

            return 0;
        }

        protected bool Lexicographical_Compare(Array<T> operand1,
                                               Array<T> operand2)
        {
            int first1 = 0;              //operand1.Begin();
            int last1  = operand1.Count; //operand1.End();
            int first2 = 0;              //operand2.Begin();
            int last2  = operand2.Count; //operand2.End();

            int compare;

            for(; first1 != last1 && first2 != last2; ++first1, ++first2)
            {
                compare = Compare(operand1[first1], operand2[first2]);

                if(compare == 1)
                {
                    return true;
                }

                if(compare == -1)
                {
                    return false;
                }
            }

            return first1 == last1 && first2 != last2;
        }

        protected static int Compare(T? x,
                                     T? y)
        {
            if(x is null || y is null)
            {
                return 0;
            }

            if(x is IComparable<T> comparable)
            {
                return comparable.CompareTo(y);
            }
            return ((IComparable)x).CompareTo(y);
        }

        // Define the is greater than operator.
        public static bool operator >(Array<T> operand1,
                                      Array<T> operand2)
        {
            return operand1.CompareTo(operand2) == 1;
        }

        // Define the is less than operator.
        public static bool operator <(Array<T> operand1,
                                      Array<T> operand2)
        {
            return operand1.CompareTo(operand2) == -1;
        }

        // Define the is greater than or equal to operator.
        public static bool operator >=(Array<T> operand1,
                                       Array<T> operand2)
        {
            return operand1.CompareTo(operand2) >= 0;
        }

        // Define the is less than or equal to operator.
        public static bool operator <=(Array<T> operand1,
                                       Array<T> operand2)
        {
            return operand1.CompareTo(operand2) <= 0;
        }

        #endregion Implementation of IComparable<in Array<T>>
    }
}
