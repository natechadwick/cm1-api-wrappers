using System;  
using System.IO;  
using System.Net;  
using System.Text;  
using System.Runtime.Serialization.Json; 
using Percussion.CM1.API.Content.Model;

namespace Percussion.CM1.API.Content
{
	/// <summary>
	/// Provides the ability to Export Assets from CM1.
	/// </summary>
	public class ContentService : RestClientBase
	{
		public static string EXPORT_URI = "/Rhythmyx/content/";
		public static string EXPORT_ASSET_URI = "Assets/";
		public static string CREATE_ASSET_URI = EXPORT_ASSET_URI;
		public static string EXPORT_PATH_URI = "pathlist/";
		public static string EMPTY_ASSET_URI = "empty/";
		
		public ContentService(string server, string uid, string pass){
			this.ServerURL = server;
			this.Password = pass;
			this.UserName = uid;
		}
		
		
		/// <summary>
		/// Gets the all of the paths in the specified path. 
		/// </summary>
		/// <returns>
		/// The paths.
		/// </returns>
		/// <param name='path'>
		/// Path.
		/// </param>
		public AssetPaths GetPaths(string path){
		
			if(String.IsNullOrEmpty(path))
				throw new InvalidOperationException("Path is required");
			
			if(path.StartsWith("/"))
				path = path.Remove(0,1);
	
			AssetPaths paths = null;
			
			string url = BuildRequestURL(EXPORT_URI + EXPORT_PATH_URI + path);
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;	
	
			request.Accept = "application/json";
			request.ContentType = "application/json";
			request.Credentials = GetCredential(url);  
			
			// Get response  
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
			{  	
    			//Marshal the response into an asset object.
				 DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(AssetPaths));
				
       			 object result= serializer.ReadObject(response.GetResponseStream());
       			 paths = result as AssetPaths;
			}
			
			return paths;
			
		}
		
		/// <summary>
		/// Gets the Asset at the specified path. 
		/// </summary>
		/// <returns>
		/// The asset.
		/// </returns>
		/// <param name='path'>
		/// Path.
		/// </param>
		public ExportAsset GetAsset(String path){
			
			if(String.IsNullOrEmpty(path))
				throw new InvalidOperationException("Path is required");
			
			if(path.StartsWith("/"))
				path = path.Remove(0,1);
	
			ExportAsset asset = null;
			
			string url = BuildRequestURL(EXPORT_URI + EXPORT_ASSET_URI + path);
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;	
			
			request.Accept = "application/json";
			request.ContentType = "application/json";
			request.Credentials = GetCredential(url);  
		
			
			// Get response  
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
			{  	
    			//Marshal the response into an asset object.
				 DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ExportAsset));
				
       			 object result= serializer.ReadObject(response.GetResponseStream());
       			 asset = result as ExportAsset;
			}  
			
			return asset;
		}
		
		
		
		public CreateAsset GetEmptyAsset(string assetType){
			if(assetType==null)
				throw new ArgumentNullException();
			
			string url = BuildRequestURL(EXPORT_URI + EMPTY_ASSET_URI + assetType);
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;	
			
			request.Accept = "application/json";
			request.ContentType = "application/json";
			request.Credentials = GetCredential(url);  
			request.Method = "GET";
			
			CreateAsset asset = null;
			// Get response  
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
			{
				//Marshal the response into an asset object.
				 DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(CreateAsset));
				
       			 object result= serializer.ReadObject(response.GetResponseStream());
       			 asset = result as CreateAsset;
				
			}
			
			return asset;
		}
		/// <summary>
		/// Creates the asset.
		/// </summary>
		/// <param name='asset'>
		/// Asset.
		/// </param>
		/// <exception cref='InvalidOperationException'>
		/// Is thrown when an operation cannot be performed.
		/// </exception>
		public void CreateAsset(CreateAsset asset ){
	
			if(asset == null)
				throw new InvalidOperationException("Asset is required");
			
				
			string url = BuildRequestURL(EXPORT_URI + CREATE_ASSET_URI);
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;	
			
			request.Accept = "application/json";
			request.ContentType = "application/json";
			request.Credentials = GetCredential(url);  
			request.Method = "POST";
		
			byte[] byteData = UTF8Encoding.UTF8.GetBytes(asset.ToString());  
 			
			// Set the content length in the request headers  
			request.ContentLength = byteData.Length;  
  
			// Write data  
			using (Stream postStream = request.GetRequestStream())  
			{  
    			postStream.Write(byteData, 0, byteData.Length);  
			}  
  
			// Get response  
			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)  
			{  	
				if(response.StatusCode != HttpStatusCode.OK)
					throw new Exception(response.StatusCode.ToString());
			
				 // Get the response stream  
    			StreamReader reader = new StreamReader(response.GetResponseStream());  
  
			    // Console application output  
    			Console.WriteLine(reader.ReadToEnd());
			
			}  
			
		}
	
	}
}