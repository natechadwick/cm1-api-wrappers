using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Simple text asset.
	/// 
	/// percSimpleTextAsset
	///{"asset":{"createDate":"2012-05-10T22:33:51.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"text","value":"<div class=\"rxbodyfield\"><p><strong>simple text<\/strong><\/p><\/div>"}]},"id":"16777215-101-336","language":"en-us","lastModifiedDate":"2012-05-10T22:37:14.000-04:00","lastModifier":"Admin","name":"test-simpletext-asset-export","path":"\/Assets\/uploads\/test-simpletext-asset-export","publishDate":null,"revision":"1","type":"percSimpleTextAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.954-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}

	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class SimpleTextAsset : BaseAssetType
	{
		public SimpleTextAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

