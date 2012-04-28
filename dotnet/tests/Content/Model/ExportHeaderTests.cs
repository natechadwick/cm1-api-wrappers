using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	[TestFixture]
	public class ExportHeaderTests
	{
		public ExportHeaderTests ()
		{
		}
		
		[Test]
		public void testProps(){
			DateTime date = DateTime.Now;
			ExportHeader o = new ExportHeader("2.6", date.ToString());
			Assert.AreEqual(date.ToString(), o.ExportDate);
			Assert.AreEqual("2.6", o.SystemVersion);
		}			
	}
}

