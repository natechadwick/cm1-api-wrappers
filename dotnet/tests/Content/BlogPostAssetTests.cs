using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Blog post asset tests.
	/// </summary>
	public class BlogPostAssetTests
	{
		
		[Test]
		public void testCreateBlogPost(){
			
			CreateAsset asset = new CreateAsset();
			asset.Asset.Type = AssetTypes.BlogPostAsset;
			
			BlogPostAsset o = new BlogPostAsset(asset);
			
			Assert.IsNotNull(o);
		}
		
		[Test]
		public void testProps(){
		
			CreateAsset asset = new CreateAsset();
			asset.Asset.Type = AssetTypes.BlogPostAsset;
			
			BlogPostAsset o = new BlogPostAsset(asset);
				
			o.AuthorName = "nate";
			Assert.AreEqual("nate",o.AuthorName);
			
			o.DisplayTitle = "unit test";
			Assert.AreEqual("unit test",o.DisplayTitle);
			
			o.PostBody  = "blah";
			Assert.AreEqual("blah",o.PostBody);
			
			Assert.AreEqual(asset.Asset, o.Asset);
			Assert.AreEqual(asset.Header, o.Header);
			
		}
		
		
		public BlogPostAssetTests ()
		{
		}
	}
}

