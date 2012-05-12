using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	[DataContract(Name="createAsset")]
	public class CreateAsset {
		
		[DataMember(Name="exportHeader") ]
		public ExportHeader Header {get;set;}
		
		[DataMember(Name="asset")]
		public AssetSummary Asset {get;set;}
		
		public CreateAsset(AssetSummary asset, ExportHeader header){
			this.Asset = asset;
			this.Header = header;
		}
		
		public CreateAsset(){}
		
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
			DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(CreateAsset));
			ser.WriteObject(stream1, this);

			stream1.Position = 0;
			StreamReader sr = new StreamReader(stream1);
			return sr.ReadToEnd();
		}
	}
}

