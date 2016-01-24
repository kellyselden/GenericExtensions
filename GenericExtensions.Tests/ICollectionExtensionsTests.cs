using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestHelper;

namespace GenericExtensions.Tests
{
	[TestClass]
	public class ICollectionExtensionsTests
	{
		[TestMethod]
		public void ICollectionExtensions_Add()
		{
			var list = new List<int>(new[] { 0, 1 });

			list.Add(new[] { 2, 3 });

			AssertHelper.AreDeeplyEqual(new[] { 0, 1, 2, 3 }, list);
		}

		[TestMethod]
		public void ICollectionExtensions_Remove()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			var remove = new[] { 2, 3 };

			list.Remove(remove);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
		}

		[TestMethod]
		public void ICollectionExtensions_RemoveWhere()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			list.Remove(x => x == 2 || x == 3);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
		}

		[TestMethod]
		public void ICollectionExtensions_RemoveWhereOut()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			IEnumerable<int> removed;
			list.Remove(x => x == 2 || x == 3, out removed);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
			AssertHelper.AreDeeplyEqual(new[] { 2, 3 }, removed);
		}

		[TestMethod]
		public void ICollectionExtensions_RemoveWhereWithIndex()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			list.Remove((x, i) => i == 2 || i == 3);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
		}

		[TestMethod]
		public void ICollectionExtensions_RemoveWhereWithIndexOut()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			IEnumerable<int> removed;
			list.Remove((x, i) => i == 2 || i == 3, out removed);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
			AssertHelper.AreDeeplyEqual(new[] { 2, 3 }, removed);
		}
	}
}