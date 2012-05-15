using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Flash asset tests.
	/// </summary>
	public class FlashAssetTests
	{
		public FlashAssetTests ()
		{
		}
		
		[Test]
		public void testFlashAsset(){
			FlashAsset o = new FlashAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

