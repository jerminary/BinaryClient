using NUnit.Framework;
using Repositories;
using Models;
using System.Threading;
using System;

namespace RepositoriesTest
{
	[TestFixture()]
	public class RepositoriesTest
	{
		[Test()]
		public void TestSerializerSerialize()
		{
			ISerializer serializer = new NSJSONSerliazer();
			ActiveSymbolsRequest asr = new ActiveSymbolsRequest()
			{
				ActiveSymbols = "brief"
			};
			var result = serializer.Serialize(asr);
			Assert.IsNotEmpty(result);
		}
		
		[Test()]
		public void TestConnectionManagerSend()
		{
			FakeRouter router = new FakeRouter();
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
			var are = new AutoResetEvent(false);
			are.WaitOne(timeout: TimeSpan.FromSeconds(2));
			Assert.IsNotEmpty(router.Response);

		}
	}
}
