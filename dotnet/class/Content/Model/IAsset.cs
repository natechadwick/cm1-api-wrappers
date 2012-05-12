using System;

namespace Percussion.CM1.API.Content.Model
{
	/// <summary>
	/// Defines an interface that all Asset Types must implement. 
	/// </summary>
	public interface IAsset
	{
		
		CreateAsset ToCreateAsset();
		ExportAsset ToExportAsset();
		
	}
}

