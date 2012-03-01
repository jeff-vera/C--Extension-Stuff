using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ExtensionFun
{
	[TestFixture]
	public class ListExtensionTests
	{
		[Test]
		public void CanPaginateProductsTest()
		{
			Products productsBeforePagination = new Products();
			Products productsAfterPagination =
				productsBeforePagination.Paginate<Product>() as Products;

			Assert.That(productsAfterPagination, Is.Not.Null);
		}

		[Test]
		public void CanPaginateLocationsTest()
		{
			Locations locationsBeforePagination = new Locations();
			Locations locationsAfterPagination =
				locationsBeforePagination.Paginate<Location>() as Locations;

			Assert.That(locationsAfterPagination, Is.Not.Null);
		}
	}
}
