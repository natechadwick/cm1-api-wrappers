using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Registration asset.
	/// 
	/// percRegistrationAsset
	/// {"asset":{"createDate":"2012-05-10T22:32:28.000-04:00","createdBy":"Admin","fields":{"field":[{"name":"confirm_password_label","value":"Confirm password"},{"name":"password_label","value":"Password"},{"name":"email_label","value":"Email"},{"name":"submit_label","value":"Submit"}]},"id":"16777215-101-334","language":"en-us","lastModifiedDate":"2012-05-10T22:32:46.000-04:00","lastModifier":"Admin","name":"test-registration-asset-export","path":"\/Assets\/uploads\/test-registration-asset-export","publishDate":null,"revision":"1","type":"percRegistrationAsset"},"exportHeader":{"exportDate":"2012-05-10T23:22:37.404-04:00","systemVersion":"Version 2.6.0  Build 201204X16 (421)"}}
	/// </summary>
	/// <exception cref='NotFinishedYetException'>
	/// Is thrown when the not finished yet exception.
	/// </exception>
	public class RegistrationAsset : BaseAssetType
	{
		public RegistrationAsset ()
		{
			throw new NotFinishedYetException();
		}
	}
}

