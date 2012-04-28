using System;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	[DataContract]
	public class AssetFields
	{
		[DataMember(Name="field")]
		public AssetFieldEntry[] FieldList {get;set;}
			
		public AssetFields ()
		{
		}
	}
}

