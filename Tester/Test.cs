using System;
using DnsMxsRecord;

namespace Tester
{
	
	class Class1
	{
		
		[STAThread]
		static void Main(string[] args)
		{			
		 
		string[] s= DnsMx.GetMXRecords("umom.org"); //change the string to fit whatever server we're looking for
		foreach (string st in s)
				Console.WriteLine("Server: {0}",st);
			Console.ReadLine();	
		}
	}
}

