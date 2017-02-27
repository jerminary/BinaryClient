using System;
using Newtonsoft.Json;

namespace Models
{
	public abstract class Response<T> : BinaryBase where T : BinaryBase
	{
		[JsonProperty("echo_req")]
		public T EchoRequest
		{
			get;
			set;
		}
		[JsonProperty("req_id")]
		public int RequestID
		{
			get;
			set;
		}
		[JsonProperty("msg_type")]
		public string MessageType
		{
			get;
			set;
		}
		public Response()
		{
		}
	}
}
