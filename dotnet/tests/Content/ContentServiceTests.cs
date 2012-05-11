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
		
		/// <summary>
		/// Tests the export asset helper.  Used primary to collect JSON for the various Asset Types.
		/// </summary>
		/// <param name='assetType'>
		/// Asset type.
		/// </param>
		/// <param name='assetPath'>
		/// Asset path.
		/// </param>
		private void testExportAssetHelper(string assetPath, string assetType){
			ContentService export = new ContentService(TEST_URL,TEST_UID,TEST_PASS);
			
			ExportAsset asset = export.GetAsset(assetPath);
			
			Assert.NotNull(asset);
			
			Console.WriteLine();
			Console.WriteLine(assetType);
			Console.WriteLine(asset.ToString());
			Console.WriteLine();
			
		}
		
		
		/// <summary>
		/// Tests the export blog post asset.
		/// </summary>
		[Test]
		public void testExportBlogPostAsset(){
			testExportAssetHelper("/uploads/test-blogpost-asset-export",AssetTypes.BlogPostAsset);                  
		}
		
		
		/// <summary>
		/// Tests the export archives asset.
		/// </summary>
		[Test]
		public void testExportArchivesAsset(){
			testExportAssetHelper("/uploads/test-archives-asset-export",AssetTypes.ArchiveList);                  
		}		
		
		[Test]
		public void testExportCalendarAsset(){
			testExportAssetHelper("/uploads/test-calendar-asset-export",AssetTypes.CalendarAsset);                  
		}
		
		[Test]
		public void testExportCategoriesAsset(){
			testExportAssetHelper("/uploads/test-categories-asset-export",AssetTypes.CategoryList);                  
		}
		
		[Test]
		public void testExportEventAsset(){
			testExportAssetHelper("/uploads/test-event-asset-export",AssetTypes.EventAsset);                  
		}
		
		[Test]
		public void testExportFileAsset(){
			testExportAssetHelper("/uploads/Widget Development Quick Start.doc",AssetTypes.FileAsset);                  
		}
		
		[Test]
		public void testExportFlashAsset(){
			testExportAssetHelper("/uploads/flash-asset-export.flv",AssetTypes.FlashAsset);                  
		}
		
		[Test]
		public void testExportFormsAsset(){
			testExportAssetHelper("/uploads/test-forms-asset-export",AssetTypes.FormAsset);                  
		}
		
		[Test]
		public void testExportHTMLAsset(){
			testExportAssetHelper("/uploads/test-html-asset-export",AssetTypes.HTMLAsset);                  
		}
		
		[Test]
		public void testExportImageAsset(){
			testExportAssetHelper("/uploads/IMG_0037.JPG",AssetTypes.ImageAsset);                  
		}
		
		[Test]
		public void testExportImageAutolistAsset(){
			testExportAssetHelper("/uploads/test-imageautolist-asset-export",AssetTypes.ImageAutoList);                  
		}
		
		[Test]
		public void testExportLoginAsset(){
			testExportAssetHelper("/uploads/test-login-asset-export",AssetTypes.LoginAsset);                  
		}
		
		[Test]
		public void testExportPageAutoListAsset(){
			testExportAssetHelper("/uploads/test-pageautolist-asset-export",AssetTypes.PageAutoList);                  
		}
		
		[Test]
		public void testExportRegistrationAsset(){
			testExportAssetHelper("/uploads/test-registration-asset-export",AssetTypes.RegistrationAsset);                  
		}
		
		[Test]
		public void testExportRichTextAsset(){
			testExportAssetHelper("/uploads/test-richtext-asset-export",AssetTypes.RichTextAsset);                  
		}
		
		[Test]
		public void testExportRSSAsset(){
			testExportAssetHelper("/uploads/test-rss-asset-export",AssetTypes.RSSAsset);                  
		}
		
		[Test]
		public void testExportSimpleTextAsset(){
			testExportAssetHelper("/uploads/test-simpletext-asset-export",AssetTypes.SimpleTextAsset);                  
		}
		
		[Test]
		public void testExportTagsAsset(){
			testExportAssetHelper("/uploads/test-tags-asset-export",AssetTypes.TagList);                  
		}
		
		
		[Test]
		public void testPaths(){
			ContentService x = new ContentService(TEST_URL,TEST_UID,TEST_PASS);
			
			AssetPaths paths = x.GetPaths("/Assets/uploads");
	
			Assert.NotNull(paths);
		}
		
	}
}

