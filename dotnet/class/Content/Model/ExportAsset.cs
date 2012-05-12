using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

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
		
		public ExportAsset(AssetSummary asset, ExportHeader header){
			this.Asset = asset;
			this.Header = header;
		}

		/// <summary>
		/// Returns a <see cref="System.String"/> that represents the current <see cref="Percussion.CM1.API.Content.Model.ExportAsset"/>.
		/// in JSON form.
		/// </summary>
		/// <returns>
		/// A <see cref="System.String"/> that represents the current <see cref="Percussion.CM1.API.Content.Model.ExportAsset"/>.
		/// </returns>
		public override string ToString ()
		{
			MemoryStream stream1 = new MemoryStream();
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(ExportAsset));
			ser.WriteObject(stream1, this);

			stream1.Position = 0;
			StreamReader sr = new StreamReader(stream1);
			return sr.ReadToEnd();
		}
	}
}

