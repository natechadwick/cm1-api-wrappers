using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// File asset tests.
	/// </summary>
	public class FileAssetTests
	{
		public FileAssetTests ()
		{
		}
		
		[Test]
		public void testFileAsset(){
			FileAsset o= new FileAsset();
			
			Assert.IsNotNull(o);
			
		}
	}
}

