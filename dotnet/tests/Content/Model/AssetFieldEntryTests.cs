using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	[TestFixture]
	public class AssetFieldEntryTests
	{
		
		public AssetFieldEntryTests ()
		{
		}
	
		[Test]
		public void testAssetFieldEntry(){
			
			AssetFieldEntry o = new AssetFieldEntry("test-name","test-val");
			
			Assert.AreEqual("test-name",o.Name);
			Assert.AreEqual("test-val",o.Value);
		}
	
	}	
}

