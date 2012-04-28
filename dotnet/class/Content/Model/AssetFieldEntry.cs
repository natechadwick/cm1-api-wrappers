using System;
using System.Runtime.Serialization;


namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Represents an Asset field.
	/// </summary>
	[Serializable, DataContract(Name="field")]
	public class AssetFieldEntry
	{
		[DataMember(Name="name")]
		public string Name { get;set;}
		[DataMember(Name="value")]
		public string Value { get; set; }
		
		public AssetFieldEntry (string name, string val)
		{
			this.Name = name;
			this.Value = val;
		}
		
	}
}

