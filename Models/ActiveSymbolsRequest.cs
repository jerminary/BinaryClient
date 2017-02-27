using System;
using Newtonsoft.Json;

namespace Models
{
	public class ActiveSymbolsRequest : Request
	{
		[JsonProperty("active_symbols")]
		public String ActiveSymbols {
			get;
			set;
		}
		[JsonProperty("landing_company")]
		public String LandingCompany
		{
			get;
			set;
		}
		[JsonProperty("product_type")]
		public String ProductType
		{
			get;
			set;
		}
		public ActiveSymbolsRequest() : base()
		{
		}
	}
}
