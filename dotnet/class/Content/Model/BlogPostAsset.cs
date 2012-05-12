using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Blog post asset.
	/// 
	/// percBlogPostAsset
	/// {"asset":{"createDate":"2012-05-10T20:44:08.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Blog Post Asset for Export Testing"},{"name":"postbody","value":"<div class=\"rxbodyfield\"><p><strong>Overview<\/strong><\/p><p>This is a test blog post asset for the content API.<\/p><\/div>"},{"name":"authorname","value":"Test Blog Post Asset Byline"}]},"id":"16777215-101-318","language":"en-us","lastModifiedDate":"2012-05-10T20:44:36.000-04:00","lastModifier":"Admin","name":"test-blogpost-asset-export","path":"\/Assets\/uploads\/test-blogpost-asset-export","publishDate":null,"revision":"1","type":"percBlogPostAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.124-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	public class BlogPostAsset : BaseAssetType
	{
		public static String ASSET_TYPE=AssetTypes.BlogPostAsset;
		public static String TARGET_VERSION="2.6";	
		
		public static string DISPLAYTITLE = "displaytitle";
		public static string POSTBODY = "postbody";
		public static string AUTHORNAME = "authorname";
				
		//Private argumentless ctor
		private BlogPostAsset(){}
		
		/// <summary>
		/// Gets or sets the display title.
		/// Maps to the displaytitle of the asset.
		/// </summary>
		/// <value>
		/// The display title.
		/// </value>
		public String DisplayTitle {
			get{
				AssetFieldEntry e = Asset.Fields.FindField(DISPLAYTITLE);		
				return e != null ? e.Value : "";
			}
			
			set{
				Asset.Fields.UpdateField( new AssetFieldEntry(DISPLAYTITLE,value));
			}
		}
		
		/// <summary>
		/// Maps to the postbody of the asset
		/// </summary>
		/// <value>
		/// The post body.
		/// </value>
		public String PostBody{
			get{
				AssetFieldEntry e = Asset.Fields.FindField(POSTBODY);		
				return e != null ? e.Value : "";
			}
			
			set{
				Asset.Fields.UpdateField( new AssetFieldEntry(POSTBODY,value));
			}
		}
		
		/// <summary>
		/// Gets or sets the name of the author.
		/// Maps to the authorname field of the asset. 
		/// </summary>
		/// <value>
		/// The name of the author.
		/// </value>
		public String AuthorName{
			
			get{
				AssetFieldEntry e = Asset.Fields.FindField(AUTHORNAME);		
				return e != null ? e.Value : "";
			}
			
			set{
				Asset.Fields.UpdateField( new AssetFieldEntry(AUTHORNAME,value));
			}
		}
		
		public BlogPostAsset (ExportAsset asset)
		{
			if(asset.Asset.Type != AssetTypes.BlogPostAsset)
				throw new InvalidOperationException("Expected " + AssetTypes.BlogPostAsset + " but got " + asset.Asset.Type);
			
			this.Asset = asset.Asset;
			this.Header = asset.Header;
			
		}
		
		public BlogPostAsset (CreateAsset asset)
		{
			if(asset.Asset.Type != AssetTypes.BlogPostAsset)
				throw new InvalidOperationException("Expected " + AssetTypes.BlogPostAsset + " but got " + asset.Asset.Type);
			
			this.Asset = asset.Asset;
			this.Header = asset.Header;
			
		}
	}
}

