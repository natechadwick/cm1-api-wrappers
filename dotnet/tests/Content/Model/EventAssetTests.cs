using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Event asset tests.
	/// </summary>
	public class EventAssetTests
	{
		public EventAssetTests ()
		{
		}
		
		[Test]
		public void testEventAssets(){
			EventAsset o = new EventAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

