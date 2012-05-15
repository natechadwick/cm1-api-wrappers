using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Image auto list tests.
	/// </summary>
	public class ImageAutoListTests
	{
		public ImageAutoListTests ()
		{
		}
		
		[Test]
		public void testImageAutoList(){
			ImageAutoList o = new ImageAutoList();
			
			Assert.IsNotNull(o);
		}
	}
}

