using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Percussion.CM1.API.Content.Model
{
	[DataContract(Name="Asset")]
	public class ImportAsset
	{
		[DataMember(Name="fields")]
		public Dictionary<string, object> Fields{get;set;}
		
		public ImportAsset ()
		{
		}
	}
}

