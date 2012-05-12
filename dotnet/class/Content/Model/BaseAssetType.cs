using System;

namespace Percussion.CM1.API.Content.Model
{
	public class BaseAssetType : ExportAsset, IAsset
	{
		
		
		public CreateAsset ToCreateAsset ()
		{
			return new CreateAsset(base.Asset, base.Header);
		}
	
		public ExportAsset ToExportAsset ()
		{
			return new ExportAsset(base.Asset, base.Header);
		}
		
		public BaseAssetType ()
		{
		}
	}
}

