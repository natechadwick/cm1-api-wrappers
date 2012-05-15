using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Category list tests.
	/// </summary>
	public class CategoryListTests
	{
		public CategoryListTests ()
		{
		}
		
		public void testCategoryLists(){
			CategoryList o = new CategoryList();
			
			Assert.IsNotNull(o);
		}
	}
}

