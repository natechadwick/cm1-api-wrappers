using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Flash asset.
	/// 
	/// percFlashAsset
	/// {"asset":{"createDate":"2012-05-10T21:25:10.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Test Flash Asset"},{"name":"flashversion","value":"10"},{"name":"usage","value":null}]},"id":"16777215-101-326","language":"en-us","lastModifiedDate":"2012-05-10T21:25:10.000-04:00","lastModifier":"Admin","name":"flash-asset-export.flv","path":"\/Assets\/uploads\/flash-asset-export.flv","publishDate":null,"revision":"1","type":"percFlashAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.995-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class FlashAsset : BaseAssetType
	{
		public FlashAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

