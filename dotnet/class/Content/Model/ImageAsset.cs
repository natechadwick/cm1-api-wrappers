using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Image asset.
	/// 
	/// percImageAsset
	///{"asset":{"createDate":"2012-05-10T22:19:54.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"test-image-asset-export"},{"name":"resource_link_title","value":null},{"name":"thumbprefix","value":"thumb_"},{"name":"alttext","value":"Tes Image Asset Export"}]},"id":"16777215-101-329","language":"en-us","lastModifiedDate":"2012-05-10T22:20:31.000-04:00","lastModifier":"Admin","name":"IMG_0037.JPG","path":"\/Assets\/uploads\/IMG_0037.JPG","publishDate":null,"revision":"1","type":"percImageAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:36.620-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class ImageAsset : BaseAssetType
	{
		public ImageAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

