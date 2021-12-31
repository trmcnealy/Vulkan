using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Vulkan;

public interface IArray<T> : IArray, IList<T>
where T : notnull
{
    //T this[int index] { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set; }
    T this[long index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set;
    }

    T this[uint index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        get;
        [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
        set;
    }

    //int Capacity { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get; [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] set; }
    //int Count { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get; }
    //bool IsReadOnly { [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)] get; }

    //void Add(T item);
    void AddRange(IEnumerable<T> collection);

    void Assign(int            count,
                IEnumerable<T> collection);

    void Assign(int count,
                T   value);

    void Assign(Predicate<T> condition,
                T            value);

    T At(int index);

    T At(uint index);

    Iterator<T> Begin();

    int BinarySearch(int          index,
                     int          count,
                     T            item,
                     IComparer<T> comparer);

    int BinarySearch(T item);

    int BinarySearch(T            item,
                     IComparer<T> comparer);

    //void Clear();
    int CompareTo(Array<T> other);

    //bool Contains(T item);
    Array<TOutput> ConvertAll<TOutput>(Converter<T, TOutput> converter)
        where TOutput : IComparable<TOutput>;

    void CopyTo(Array<T> array);

    void CopyTo(int index,
                T[] array,
                int arrayIndex,
                int count);

    void CopyTo(T[] array);

    //void CopyTo(T[] array, int arrayIndex);
    void DeepCopy(Array<T> av);

    Iterator<T> End();

    bool Exists(Predicate<T> match);

    T? Find(Predicate<T>? match);

    Array<T> FindAll(Predicate<T> match);

    int FindIndex(int          startIndex,
                  int          count,
                  Predicate<T> match);

    int FindIndex(int          startIndex,
                  Predicate<T> match);

    int FindIndex(Predicate<T> match);

    T? FindLast(Predicate<T>? match);

    int FindLastIndex(int          startIndex,
                      int          count,
                      Predicate<T> match);

    int FindLastIndex(int          startIndex,
                      Predicate<T> match);

    int FindLastIndex(Predicate<T> match);

    void ForEach(Action<T> action);

    //Array<T>.Enumerator GetEnumerator();
    Array<T> GetRange(int index,
                      int count);

    Array<T> GetRange(uint index,
                      uint count);

    //int IndexOf(T item);
    int IndexOf(T   item,
                int index);

    int IndexOf(T   item,
                int index,
                int count);

    //void Insert(int index, T item);
    void Insert(uint index,
                T    item);

    void InsertRange(int            index,
                     IEnumerable<T> collection);

    void InsertRange(int index,
                     int count,
                     T   collection);

    int LastIndexOf(T item);

    int LastIndexOf(T   item,
                    int index);

    int LastIndexOf(T   item,
                    int index,
                    int count);

    //bool Remove(T item);
    int RemoveAll(Predicate<T> match);

    //void RemoveAt(int index);
    //void RemoveRange(int index, int count);
    //void Resize(int size);
    //void Resize(int size, T value);
    //void Resize(uint size);
    T[] Reverse(bool copy = true);

    //void Reverse(int index, int count);
    //void Sort();
    void Sort(Comparison<T> comparison);

    void Sort(IComparer<T> comparer);

    void Sort(int          index,
              int          count,
              IComparer<T> comparer);

    //void Swap(int indexA, int indexB);
    void Swap(T leftItem,
              T rightItem);

    T[] ToArray();

    //void TrimExcess();
    bool TrueForAll(Predicate<T> match);
}
