using System;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Contains meta information about an Asset;
	/// </summary>
	[Serializable, DataContract(Name="ExportHeader")]
	public class ExportHeader
	{
		[DataMember(Name="exportDate")]
		public string SystemVersion{get;set;}
		
		[DataMember(Name="systemVersion")]
		public string ExportDate{get;set;}
		
		public ExportHeader ()
		{
		}
		
		public ExportHeader(string version, string date){
			SystemVersion = version;
			ExportDate = date;
		}
	}
}

