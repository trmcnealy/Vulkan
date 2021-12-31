
using System.Collections.Generic;
using System.Linq;

namespace Vulkan
{
    public static class ArrayExtensions
    {
        //public static TSource[] ToArray<TSource>(this Array<TSource> source)
        //{
        //    if (source == null)
        //    {
        //        ThrowHelper.ThrowArgumentNullException(ExceptionArgument.source);
        //    }
        //
        //    return source is IIListProvider<TSource> arrayProvider
        //               ? arrayProvider.ToArray()
        //               : EnumerableHelpers.ToArray(source);
        //}
 
        public static Array<TSource> ToArrayList<TSource>(this IEnumerable<TSource> source)
            where TSource : notnull
        {
            return new Array<TSource>(source.ToArray());
        }
    }
}
