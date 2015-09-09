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

			list.Remove(x => x == 2 || x == 3);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
		}

		[TestMethod]
		public void ICollectionExtensions_RemoveWithIndex()
		{
			var list = new List<int>(new[] { 0, 1, 2, 3 });

			list.Remove((x, i) => i == 2 || i == 3);

			AssertHelper.AreDeeplyEqual(new[] { 0, 1 }, list);
		}
	}
}