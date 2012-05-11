using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// RSS asset.
	/// 
	/// percRssAsset
	///{"asset":{"createDate":"2012-05-10T22:31:56.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"placeholder","value":null},{"name":"rss_url","value":"https:\/\/github.com\/natechadwick\/cm1-api-wrappers\/commits\/master.atom"}]},"id":"16777215-101-333","language":"en-us","lastModifiedDate":"2012-05-10T22:32:14.000-04:00","lastModifier":"Admin","name":"test-rss-asset-export","path":"\/Assets\/uploads\/test-rss-asset-export","publishDate":null,"revision":"1","type":"percRssAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.781-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class RSSAsset : BaseAssetType
	{
		public RSSAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

