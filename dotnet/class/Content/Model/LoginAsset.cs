using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Login asset.
	/// percLoginAsset
	/// {"asset":{"createDate":"2012-05-10T22:21:50.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"show_username","value":null},{"name":"placeholder","value":null},{"name":"password_label","value":"Password"},{"name":"not_logged_in_message","value":"Login"},{"name":"logged_in_message","value":"Welcome,"},{"name":"email_label","value":"Email"},{"name":"submit_label","value":"Submit"}]},"id":"16777215-101-331","language":"en-us","lastModifiedDate":"2012-05-10T22:22:11.000-04:00","lastModifier":"Admin","name":"test-login-asset-export","path":"\/Assets\/uploads\/test-login-asset-export","publishDate":null,"revision":"1","type":"percLoginAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.006-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class LoginAsset : BaseAssetType
	{
		public LoginAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

