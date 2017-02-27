using System;
using Models;

namespace Repositories
{
	public class FakeRouter : IRouter
	{
		public Boolean ResponseReceived
		{
			get;
			set;
		}
		public String Response
		{
			get;
			set;
		}
		public FakeRouter()
		{
		}

		public void Register(Request request, IMessageReceiver receiver)
		{
		}

		public void Route(string response)
		{
			//Console.WriteLine("" + response);
			ResponseReceived = true;
			Response = response;
		}
	}
}
