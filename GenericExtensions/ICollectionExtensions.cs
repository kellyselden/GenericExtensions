using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericExtensions
{
	public static class ICollectionExtensions
	{
		public static ICollection<TSource> Add<TSource>(this ICollection<TSource> source, IEnumerable<TSource> collection)
		{
			foreach (TSource element in collection)
			{
				source.Add(element);
			}

			return source;
		}

		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, bool> predicate)
		{
			foreach (TSource element in source.Where(predicate).ToArray())
			{
				source.Remove(element);
			}

			return source;
		}

		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, int, bool> predicate)
		{
			foreach (TSource element in source.Where(predicate).ToArray())
			{
				source.Remove(element);
			}

			return source;
		}
	}
}