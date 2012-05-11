using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// HTML asset.
	/// 
	/// percRawHtmlAsset
	/// {"asset":{"createDate":"2012-05-10T22:13:59.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"html","value":"<marquee>Do I still Work!??!!!<\/marquee>"}]},"id":"16777215-101-328","language":"en-us","lastModifiedDate":"2012-05-10T22:17:18.000-04:00","lastModifier":"Admin","name":"test-html-asset-export","path":"\/Assets\/uploads\/test-html-asset-export","publishDate":null,"revision":"1","type":"percRawHtmlAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:36.381-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class HTMLAsset : BaseAssetType
	{
		public HTMLAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

