using System;
using Newtonsoft.Json;

namespace Models
{
	public class AppGetRequest
	{
		[JsonProperty("app_get")]
		public String AppGet
		{
			get;
			set;
		}
		public AppGetRequest()
		{
		}
	}
}
