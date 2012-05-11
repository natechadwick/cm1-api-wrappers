using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Image auto list.
	/// 
	/// percImageAutoList
	///{"asset":{"createDate":"2012-05-10T22:21:02.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"asset_library_path","value":null},{"name":"displaytitle","value":"Test Image Autolist"},{"name":"end_date","value":null},{"name":"title_contains","value":"Test"},{"name":"start_date","value":null}]},"id":"16777215-101-330","language":"en-us","lastModifiedDate":"2012-05-10T22:21:37.000-04:00","lastModifier":"Admin","name":"test-imageautolist-asset-export","path":"\/Assets\/uploads\/test-imageautolist-asset-export","publishDate":null,"revision":"1","type":"percImageAutoList"},"exportHeader":{"exportDate":"2012-05-10T23:22:36.832-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class ImageAutoList : BaseAssetType
	{
		public ImageAutoList ()
		{
			throw new NotFinishedYetException();
		}
	}
}

