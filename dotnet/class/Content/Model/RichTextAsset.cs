using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Rich text asset.
	/// 
	/// percRichTextAsset
	///{"asset":{"createDate":"2012-05-10T22:33:11.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"text","value":"<div class=\"rxbodyfield\"><p>Test rich text.&#160;<\/p><\/div>"}]},"id":"16777215-101-335","language":"en-us","lastModifiedDate":"2012-05-10T22:33:27.000-04:00","lastModifier":"Admin","name":"test-richtext-asset-export","path":"\/Assets\/uploads\/test-richtext-asset-export","publishDate":null,"revision":"1","type":"percRichTextAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.612-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class RichTextAsset : BaseAssetType
	{
		public RichTextAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

