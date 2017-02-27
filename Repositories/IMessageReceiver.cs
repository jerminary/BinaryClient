using System;
using Models;

namespace Repositories
{
	public interface IMessageReceiver
	{
		void Receive(BinaryBase response);
	}
}
