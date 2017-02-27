using System;
using Newtonsoft.Json;

namespace Models
{
	public class AppDeleteRequest : Request
	{
		[JsonProperty("app_delete")]
		public String AppDelete
		{
			get;
			set;
		}
		public AppDeleteRequest()
		{
		}
	}
}
