using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Calendar asset tests.
	/// </summary>
	public class CalendarAssetTests
	{
		public CalendarAssetTests ()
		{
		}
		
		[Test]
		public void testCalendar(){
			CalendarAsset  o = new CalendarAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

