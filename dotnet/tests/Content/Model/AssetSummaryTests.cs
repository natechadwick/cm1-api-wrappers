using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	[TestFixture]
	public class AssetSummaryTests
	{
		public AssetSummaryTests ()
		{
		}
		
		[Test]
		public void testAssetSummary(){
		
		AssetSummary o = new AssetSummary();
			
			DateTime create = DateTime.Now;
			o.CreateDate = create.ToString();
			
			o.CreatedBy = "createbytest";
			o.Id = "idtest";
			o.Language = "langtest";
			DateTime lastmod = DateTime.Now;
			o.LastModifiedDate = lastmod.ToString();
			o.LastModifier = "lastmod";
			o.Name = "nametes";
			o.Path = "/tsh/";
			
			DateTime pubdate = DateTime.Now;
			o.PublishDate = pubdate.ToString();
			
			o.Revision = "testrev";
			o.Type = "testtype";
			
			AssetFieldEntry f1 = new AssetFieldEntry("name1","val1");
			AssetFieldEntry f2 = new AssetFieldEntry("name2","val2");
			
		//	o.Fields.Add(f1.Name,f1);
		//	o.Fields.Add(f2.Name,f2);
			
			Assert.AreEqual(create.ToString(),o.CreateDate);
			Assert.AreEqual("createbytest",o.CreatedBy);
			Assert.AreEqual("idtest",o.Id);
			Assert.AreEqual("langtest",o.Language);
			Assert.AreEqual(lastmod.ToString(),o.LastModifiedDate);
			Assert.AreEqual("lastmod",o.LastModifier);
			Assert.AreEqual("nametes",o.Name);
			Assert.AreEqual("/tsh/",o.Path);
			Assert.AreEqual(pubdate.ToString(), o.PublishDate);
			Assert.AreEqual("testrev",o.Revision);
			Assert.AreEqual("testtype",o.Type);
		//	Assert.AreEqual(2, o.Fields.Count);
			
			
			
		}
		
	}
}

