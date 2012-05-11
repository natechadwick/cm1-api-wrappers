using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Category list.
	/// 
	/// percCategoryList
	/// {"asset":{"createDate":"2012-05-10T21:18:04.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Test Categories Asset Export"},{"name":"end_date","value":null},{"name":"title_contains","value":"Test"},{"name":"category_page_result","value":null},{"name":"start_date","value":null},{"name":"site_path","value":null}]},"id":"16777215-101-322","language":"en-us","lastModifiedDate":"2012-05-10T21:18:36.000-04:00","lastModifier":"Admin","name":"test-categories-asset-export","path":"\/Assets\/uploads\/test-categories-asset-export","publishDate":null,"revision":"1","type":"percCategoryList"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.411-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class CategoryList : BaseAssetType
	{
		public CategoryList ()
		{
			throw new NotFinishedYetException();
		}
	}
}

