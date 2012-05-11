using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Tag list.
	/// 
	/// percTagList
	//{"asset":{"createDate":"2012-05-10T21:08:44.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Tags Export Asset Test"},{"name":"tag_page_result","value":null},{"name":"end_date","value":null},{"name":"title_contains","value":"Test"},{"name":"start_date","value":null},{"name":"site_path","value":null}]},"id":"16777215-101-319","language":"en-us","lastModifiedDate":"2012-05-10T21:15:21.000-04:00","lastModifier":"Admin","name":"test-tags-asset-export","path":"\/Assets\/uploads\/test-tags-asset-export","publishDate":null,"revision":"1","type":"percTagList"},"exportHeader":{"exportDate":"2012-05-10T23:22:38.136-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class TagList : BaseAssetType
	{
		public TagList ()
		{
			throw new NotFinishedYetException();
		}
	}
}

