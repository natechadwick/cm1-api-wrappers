using System;

namespace Percussion.CM1.API.Content.Model
{
	public class BaseAssetType : ExportAsset, IAsset
	{
		//TODO: Come up with a generic way to cast a derived class to any of the 4 json types.
		
		/// <summary>
		/// Converts the Asset to a generic CreateAsset
		/// </summary>
		/// <returns>
		/// The create asset.
		/// </returns>
	//	public CreateAsset AsCreateAsset(){
		
	//		return this as CreateAsset;
	//	}
		
		/// <summary>
		/// Returns the Asset as an ExportAsset
		/// </summary>
		/// <returns>
		/// The export asset.
		/// </returns>
	//	public ExportAsset AsExportAsset(){
	//		return this as ExportAsset;
	//	}
		
		
		public BaseAssetType ()
		{
		}
	}
}

