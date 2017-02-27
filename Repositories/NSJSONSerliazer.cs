using System;
using Models;
using Newtonsoft.Json;

namespace Repositories
{
	public class NSJSONSerliazer : ISerializer
	{
		public NSJSONSerliazer()
		{
		}

		public string Serialize(Request request)
		{
			return JsonConvert.SerializeObject(request,
							  Newtonsoft.Json.Formatting.None,
							new JsonSerializerSettings
							{
								NullValueHandling = NullValueHandling.Ignore
							});
		}
	}
}
