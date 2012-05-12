using System;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	[DataContract]
	public class AssetFields
	{
		[DataMember(Name="field")]
		public AssetFieldEntry[] FieldList {get;set;}
			
		public AssetFields ()
		{
		}
		
		/// <summary>
		/// Finds the field.
		/// 
		/// </summary>
		/// <returns>
		/// The field.
		/// </returns>
		/// <param name='name'>
		/// Name.
		/// </param>
		public AssetFieldEntry FindField(string name){
			//Note: This implementation might be improved to use a dictionary or something key value based
			foreach (AssetFieldEntry f in FieldList){
					if( f.Name.Equals(name))
						return f;
				}
			return null;
		}
	
		/// <summary>
		/// Updates the field.
		/// </summary>
		/// <param name='f'>
		/// F.
		/// </param>
		/// <exception cref='ArgumentNullException'>
		/// Is thrown when an argument passed to a method is invalid because it is <see langword="null" /> .
		/// </exception>
		public void UpdateField(AssetFieldEntry f){
			if(f==null)
				throw new ArgumentNullException();
		
			int i = 0;
			foreach (AssetFieldEntry d in FieldList){
					if( d.Name.Equals(f.Name)){
						FieldList.SetValue(f,i);
						break;
					}
				i++;
			}
			
		}
	}
}

