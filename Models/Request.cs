using System;
using Newtonsoft.Json;

namespace Models
{
	public abstract class Request : BinaryBase
 	{
		[JsonProperty("req_id")]
		public int RequestID
		{
			get;
			set;
		}
	}
}
