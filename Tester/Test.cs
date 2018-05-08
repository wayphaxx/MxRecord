using System;
using PAB.DnsUtils;

namespace Tester
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{			
		 
		string[] s=	PAB.DnsUtils.DnsMx.GetMXRecords("umom.org");
		foreach (string st in s)
				Console.WriteLine("Server: {0}",st);
			Console.ReadLine();	
		}
	}
}
