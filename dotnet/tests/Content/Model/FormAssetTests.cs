using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	public class FormAssetTests
	{
		public FormAssetTests ()
		{
		}
		
		[Test]
		public void testFormAsset(){
			FormAsset o= new FormAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

