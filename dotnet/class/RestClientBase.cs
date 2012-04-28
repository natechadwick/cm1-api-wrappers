using System;
using System.IO;  
using System.Net;  
using System.Text;  
using System.Runtime.Serialization;

namespace Percussion.CM1.API
{
	/// <summary>
	/// Provides a lightweight client for invoking REST methods. 
	/// </summary>
	public abstract class RestClientBase {
		
		public string ServerURL{get;set;}
		public string UserName{get;set;}
		public string Password{get;set;}
		
		public RestClientBase ()
		{
		}
		
		
	
		
		protected string BuildRequestURL(string path){
			
			if(String.IsNullOrEmpty(ServerURL) || String.IsNullOrEmpty(path))
				throw new InvalidOperationException("Invalid Service URL or Resource Path");
			
			if(!ServerURL.EndsWith("/")){
				ServerURL += "/";
			}
		
			if(path.StartsWith("/"))
				path = path.Remove(0,1);
			
			return ServerURL + path;
		}
	
		protected CredentialCache GetCredential(String url)
		{
		    CredentialCache credentialCache = new CredentialCache();
		    credentialCache.Add(new System.Uri(url), "Basic", new NetworkCredential(UserName, Password));
		    return credentialCache;
		}

		
		
	}
	
	
}

