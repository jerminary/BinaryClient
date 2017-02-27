using System;
using Newtonsoft.Json;

namespace Models
{
	public class AppDeleteResponse : Response<AppDeleteRequest>
	{
		[JsonProperty("app_delete")]
		public String AppDelete
		{
			get;
			set;
		}
		public AppDeleteResponse()
		{
		}
	}
}
