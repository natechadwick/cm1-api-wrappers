using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// RSS asset tests.
	/// </summary>
	public class RSSAssetTests
	{
		public RSSAssetTests ()
		{
		}
		
		[Test]
		public void testRSSAsset(){
			RSSAsset o = new RSSAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

