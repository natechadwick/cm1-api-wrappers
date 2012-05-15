using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Simple text asset tests.
	/// </summary>
	public class SimpleTextAssetTests
	{
		public SimpleTextAssetTests ()
		{
		}
		
		[Test]
		public void testSimpleTextAsset(){
			SimpleTextAsset o = new SimpleTextAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

