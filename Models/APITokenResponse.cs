using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{
	public class APITokenResponse : Response<APITokenRequest>
	{
		[JsonProperty("tokens")]
		public List<String> Tokens
		{
			get;
			set;
		}
		[JsonProperty("new_token")]
		public String NewToken
		{
			get;
			set;
		}
		[JsonProperty("delete_token")]
		public String DeleteToken
		{
			get;
			set;
		}
		[JsonProperty("sub_account")]
		public String SubAccount
		{
			get;
			set;
		}
		public APITokenResponse()
		{
		}
	}
}
