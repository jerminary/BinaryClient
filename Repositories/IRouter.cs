using System;
using Models;

namespace Repositories
{
	public interface IRouter
	{
		void Register(Request request, IMessageReceiver receiver);
		void Route(string response);
	}
}
