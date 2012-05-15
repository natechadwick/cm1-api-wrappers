using System;
using NUnit.Core;
using NUnit.Framework;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Login asset tests.
	/// </summary>
	public class LoginAssetTests
	{
		public LoginAssetTests ()
		{
		}
		
		public void testLoginAsset(){
			LoginAsset o = new LoginAsset();
			
			Assert.IsNotNull(o);
		}
		
	}
}

