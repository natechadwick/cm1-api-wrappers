using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Image asset tests.
	/// </summary>
	public class ImageAssetTests
	{
		public ImageAssetTests ()
		{
		}
		
		public void testImageAsset(){
			ImageAsset o = new ImageAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

