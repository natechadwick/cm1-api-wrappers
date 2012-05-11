using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// File asset.
	/// 
	/// percFileAsset
	/// {"asset":{"createDate":"2012-04-28T13:09:55.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"displaytitle","value":"Widget Development Quick Start.doc"},{"name":"usage","value":null}]},"id":"16777215-101-311","language":"en-us","lastModifiedDate":"2012-04-28T13:09:58.000-04:00","lastModifier":"Admin","name":"Widget Development Quick Start.doc","path":"\/Assets\/uploads\/Widget Development Quick Start.doc","publishDate":null,"revision":"1","type":"percFileAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:35.776-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class FileAsset : BaseAssetType
	{
		public FileAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

