using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// HTML asset tests.
	/// </summary>
	public class HTMLAssetTests
	{
		public HTMLAssetTests ()
		{
		}
		
		[Test]
		public void testHTMLAsset(){
			HTMLAsset o = new HTMLAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

