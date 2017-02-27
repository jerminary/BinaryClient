using System;
using Models;

namespace Repositories
{
	public interface IConnectionManager
	{
		void Send(Request request, IMessageReceiver receiver);
	}
}
