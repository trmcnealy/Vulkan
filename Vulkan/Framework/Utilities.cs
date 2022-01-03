using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vulkan.Framework
{
    public static class Utilities
    {
        public static void Resize<T>(this Array<T> list,
                                     int           newSize,
                                     T             value = default!)
            where T : notnull
        {
            if(list.Count > newSize)
            {
                list.RemoveRange(newSize, list.Count - newSize);
            }
            else if(list.Count < newSize)
            {
                for(int i = list.Count; i < newSize; i++)
                {
                    list.Add(value);
                }
            }
        }

        public static void Swap<T>(this Array<T> list1,
                                   Array<T>      list2)
            where T : notnull
        {
            Array<T> temp = new Array<T>(list1);
            list1.Clear();
            list1.AddRange(list2);
            list2.Clear();
            list2.AddRange(temp);
        }

        public static Array<T> InitializedList<T>(int size,
                                                  T   value)
            where T : notnull
        {
            Array<T> temp = new Array<T>();

            for(int count = 1; count <= size; count++)
            {
                temp.Add(value);
            }

            return temp;
        }

        public static Array<Array<T>> NestedList<T>(int outerSize,
                                                    int innerSize)
            where T : notnull
        {
            Array<Array<T>> temp = new Array<Array<T>>();

            for(int count = 1; count <= outerSize; count++)
            {
                temp.Add(new Array<T>(innerSize));
            }

            return temp;
        }

        public static Array<Array<T>> NestedList<T>(int outerSize,
                                                    int innerSize,
                                                    T   value)
            where T : notnull
        {
            Array<Array<T>> temp = new Array<Array<T>>();

            for(int count = 1; count <= outerSize; count++)
            {
                temp.Add(InitializedList(innerSize, value));
            }

            return temp;
        }
    }
}
