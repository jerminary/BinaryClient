using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{
	public class APITokenRequest : Request
	{
		[JsonProperty("api_token")]
		public int ApiToken
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
		[JsonProperty("new_token_scopes")]
		public List<String> NewTokenScopes
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
		public APITokenRequest()
		{
		}
	}
}
