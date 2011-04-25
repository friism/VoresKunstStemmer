using System;
using System.IO;
using System.Net;
using System.Threading;

namespace VoresKunstStemmer
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				var request = (HttpWebRequest)WebRequest.Create(
					@"http://www.dr.dk/tjenester/kunstmaerker/Place/Like?placeid=1758");
				request.Method = "GET";
				var response = request.GetResponse();
				var streamReader = new StreamReader(response.GetResponseStream(), System.Text.Encoding.UTF8);
				string result = streamReader.ReadToEnd();
				Console.WriteLine(result);
				streamReader.Close();
				response.Close();
				Thread.Sleep(1000);
			}
		}
	}
}
