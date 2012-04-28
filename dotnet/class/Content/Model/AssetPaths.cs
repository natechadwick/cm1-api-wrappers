using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Represents an Available Asset Path
	/// </summary>
	[DataContract(Name="files")]
	public class AssetPaths
	{
		[DataMember(Name="parentFolder")]
		public string ParentFolder{get;set;}
		
		[DataMember(Name="name")]
		public List<string> Name{get;set;}
		
		public AssetPaths ()
		{
		}
		
		public AssetPaths(string parent, List<string> name){
			ParentFolder = parent;
			Name = name;
		}
		
	}
}

