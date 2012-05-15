using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Page auto list tests.
	/// </summary>
	public class PageAutoListTests
	{
		public PageAutoListTests ()
		{
		}
		
		[Test]
		public void testPageAutoList(){
			PageAutoList o = new PageAutoList();
			
			Assert.IsNotNull(o);
		}
	}
}

