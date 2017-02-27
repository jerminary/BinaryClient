using System;
using Models;
using Newtonsoft.Json;
using Repositories;

namespace BinaryClient
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			IRouter router = new FakeRouter();
			ISerializer serializer = new NSJSONSerliazer();
			IMessageReceiver receiver = new FakeMessageReceiver();
			IConnectionManager conn = new ConnectionManager("wss://ws.binaryws.com/websockets/v3?app_id=1",
															router,
															serializer);
			ActiveSymbolsRequest asr = new ActiveSymbolsRequest()
			{
				ActiveSymbols = "brief"
			};
			conn.Send(asr, receiver);

			Console.ReadKey(true);
			
		}
	}
}
