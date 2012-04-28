using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Represents a Content Asset
	/// </summary>
	[Serializable, DataContract(Name="Asset")]
	public class AssetSummary
	{
		[DataMember(Name="id")]
		public string Id{ get; set; }
		
		[DataMember(Name="path")]
		public string Path{ get; set; }
		
		[DataMember(Name="name")]
		public string Name{get;set;}
		
		[DataMember(Name="type")]
		public string Type{get;set;}
		
		[DataMember(Name="revision")]
		public string Revision{get;set;}
	
		[DataMember(Name="createDate")]
		public string CreateDate{get;set;}
		
		[DataMember(Name="lastModifiedDate")]
		public string LastModifiedDate{get;set;}
		
		[DataMember(Name="publishDate")]
		public string PublishDate{get;set;}
		
		[DataMember(Name="createdBy")]
		public string CreatedBy{get;set;}
		
		[DataMember(Name="lastModifier")]
		public string LastModifier{get;set;}
		
		[DataMember(Name="language")]
		public string Language{get;set;}
		
		[DataMember(Name="fields")]
		public AssetFields Fields {get;set;}
		
		public AssetSummary ()
		{
		}
		
	}
}

