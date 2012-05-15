using System;
using System.Runtime.Serialization;

namespace Percussion.CM1.API.Content.Model
{
	[DataContract]
	public class AssetFields
	{
		private AssetFieldEntry[] fields;
		
		[DataMember(Name="field")]
		public AssetFieldEntry[] FieldList {get{return fields;} set{fields = value;}}
		
		/// <summary>
		/// Initializes a new instance of the <see cref="Percussion.CM1.API.Content.Model.AssetFields"/> class.
		/// </summary>
		public AssetFields ()
		{
			FieldList = new AssetFieldEntry[]{};
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
						return;
					}
				i++;
			}
			
			//if we got this far then we will add the field - and as these are tiny, just resize the array
			Array.Resize<AssetFieldEntry>(ref fields, fields.Length +1);
	
			FieldList.SetValue(f,fields.Length-1);

			
		}
	}
}

