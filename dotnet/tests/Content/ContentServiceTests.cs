using System;
using NUnit.Core;
using NUnit.Framework;
using Percussion.CM1.API.Content.Model;

namespace Percussion.CM1.API.Content
{
	[TestFixture]
	public class ContentServiceTests
	{
		
		public static string TEST_URL = "http://127.0.0.1:9992";
		public static string TEST_UID = "Admin";
		public static string TEST_PASS = "demo";
		
		public ContentServiceTests ()
		{
		}
		
		[Test]
		public void testExport(){
			ContentService export = new ContentService(TEST_URL,TEST_UID,TEST_PASS);
			
			ExportAsset asset = export.GetAsset("/uploads/Widget Development Quick Start.doc");
			
			Assert.NotNull(asset);
			
			
		}
		
		[Test]
		public void testPaths(){
			ContentService x = new ContentService(TEST_URL,TEST_UID,TEST_PASS);
			
			AssetPaths paths = x.GetPaths("/Assets/uploads");
	
			Assert.NotNull(paths);
		}
		
	}
}

