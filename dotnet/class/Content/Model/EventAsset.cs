using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Event asset.
	/// 
	/// percEventAsset
	/// {"asset":{"createDate":"2012-05-10T21:20:15.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Test Event Asset Export"},{"name":"body","value":"<div class=\"rxbodyfield\"><p>Test Body<\/p><\/div>"},{"name":"callout","value":"Test Summary"},{"name":"end_time","value":"2012-06-01 00:00:00.0"},{"name":"location","value":"Test Location"},{"name":"start_time","value":"2012-05-25 00:00:00.0"}]},"id":"16777215-101-325","language":"en-us","lastModifiedDate":"2012-05-10T21:20:39.000-04:00","lastModifier":"Admin","name":"test-event-asset-export","path":"\/Assets\/uploads\/test-event-asset-export","publishDate":null,"revision":"1","type":"percEventAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.590-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class EventAsset : BaseAssetType
	{
		public EventAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

