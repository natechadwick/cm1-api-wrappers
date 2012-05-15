using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	
	/// <summary>
	/// Tag list tests.
	/// </summary>
	public class TagListTests
	{
		public TagListTests ()
		{
		}
		
		[Test]
		public void testTagList(){
			TagList o = new TagList();
			
			Assert.IsNotNull(o);
		}
	
	}
}

