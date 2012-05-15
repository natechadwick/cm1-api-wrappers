using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Registration asset tests.
	/// </summary>
	public class RegistrationAssetTests
	{
		public RegistrationAssetTests ()
		{
		}

		public void testRegistrationAsset(){
			RegistrationAsset o = new RegistrationAsset();
			
			Assert.IsNotNull(o);
		}
	}
}

