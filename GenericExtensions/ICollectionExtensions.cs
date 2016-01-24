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

		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, IEnumerable<TSource> collection)
		{
			foreach (TSource element in collection)
			{
				source.Remove(element);
			}

			return source;
		}

		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, bool> predicate)
		{
			IEnumerable<TSource> removed;
			return Remove(source, predicate, out removed);
		}
		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, bool> predicate, out IEnumerable<TSource> removed)
		{
			removed = source.Where(predicate).ToArray();

			foreach (TSource element in removed)
			{
				source.Remove(element);
			}

			return source;
		}

		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, int, bool> predicate)
		{
			IEnumerable<TSource> removed;
			return Remove(source, predicate, out removed);
		}
		public static ICollection<TSource> Remove<TSource>(this ICollection<TSource> source, Func<TSource, int, bool> predicate, out IEnumerable<TSource> removed)
		{
			removed = source.Where(predicate).ToArray();

			foreach (TSource element in removed)
			{
				source.Remove(element);
			}

			return source;
		}
	}
}