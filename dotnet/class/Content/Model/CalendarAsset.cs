using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Calendar asset.
	/// 
	/// percCalendarAsset
	/// {"asset":{"createDate":"2012-05-10T21:17:07.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"calendar_unique_name","value":null},{"name":"calendar_title","value":"test-calendar-asset-export"},{"name":"full_calendar_page","value":null},{"name":"calendar_start_date","value":"2012-05-10 00:00:00.0"},{"name":"sys_title","value":"test-calendar-asset-export"}]},"id":"16777215-101-321","language":"en-us","lastModifiedDate":"2012-05-10T21:17:15.000-04:00","lastModifier":"Admin","name":"test-calendar-asset-export","path":"\/Assets\/uploads\/test-calendar-asset-export","publishDate":null,"revision":"1","type":"percCalendarAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.266-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class CalendarAsset : BaseAssetType
	{
		public CalendarAsset ()
		{
			//TODO: Finish me
			throw new NotFinishedYetException();
		}
	}
}

