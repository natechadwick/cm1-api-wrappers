using System;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	[Serializable, DataContract(Name="exportAsset")]
	public class ExportAsset
	{
		[DataMember(Name="exportHeader") ]
		public ExportHeader Header {get;set;}
		
		[DataMember(Name="asset")]
		public AssetSummary Asset {get;set;}
		
		public ExportAsset ()
		{
		}
	}
}

