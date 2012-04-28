using System;
using NUnit.Core;
using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;

namespace Percussion.CM1.API.Content.Model
{
	[TestFixture]
	public class AssetPathTests
	{
		public AssetPathTests ()
		{
		}
		
		[Test]
		public void testProps(){
			
			List<string> c = new List<string>{"c"};
			AssetPaths o = new AssetPaths("p",c);
			Assert.AreEqual(o.Name,c);
			Assert.AreEqual(o.ParentFolder,"p");
		}
	}
}

