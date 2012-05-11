using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Page auto list.
	/// 
	/// percPageAutoList
	///{"asset":{"createDate":"2012-05-10T22:22:40.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"feed_description","value":null},{"name":"displaytitle","value":"Test Page Auto List Asset Export"},{"name":"end_date","value":null},{"name":"title_contains","value":"Test"},{"name":"enable_rss_feed","value":null},{"name":"feed_title","value":null},{"name":"feed_name","value":null},{"name":"start_date","value":null},{"name":"site_path","value":null}]},"id":"16777215-101-332","language":"en-us","lastModifiedDate":"2012-05-10T22:23:04.000-04:00","lastModifier":"Admin","name":"test-pageautolist-asset-export","path":"\/Assets\/uploads\/test-pageautolist-asset-export","publishDate":null,"revision":"1","type":"percPageAutoList"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.219-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class PageAutoList : BaseAssetType
	{
		public PageAutoList ()
		{
			throw new NotFinishedYetException();
		}
	}
}

