using System;

namespace Percussion.CM1.API
{
	/// <summary>
	/// When thrown, the code being used should be considered to be not finished yet.
	/// 
	/// Is an executable reminder of a TODO:
	/// 
	/// </summary>
	public class NotFinishedYetException : Exception
	{
		public NotFinishedYetException ()
		{
		}
	}
}

