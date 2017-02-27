using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models
{
	public class ActiveSymbolsResponse : Response<ActiveSymbolsRequest>
	{
		[JsonProperty("active_symbols")]
		List<ActiveSymbolsResponseItem> ActiveSymbols
		{
			get;
			set;
		}
		public ActiveSymbolsResponse()
		{
		}
	}
}
