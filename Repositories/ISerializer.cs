using System;
using Models;

namespace Repositories
{
	public interface ISerializer
	{
		String Serialize(Request request);
	}
}
