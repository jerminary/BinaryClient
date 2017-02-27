using System;
using Newtonsoft.Json;

namespace Models
{
	public class ActiveSymbolsResponseItem
	{
		[JsonProperty("symbol")]
		public string Symbol
		{
			get;
			set;
		}
		[JsonProperty("interaday_interval_minutes")]
		public int InteradayIntervalMinutes
		{
			get;
			set;
		}
		[JsonProperty("symbol_type")]
		public string SymbolType
		{
			get;
			set;
		}
		[JsonProperty("exchange_is_open")]
		public int ExchangeIsOpen
		{
			get;
			set;
		}
		[JsonProperty("exchange_name")]
		public string ExchangeName
		{
			get;
			set;
		}
		[JsonProperty("delay_amount")]
		public int DelayAmount
		{
			get;
			set;
		}
		[JsonProperty("display_name")]
		public string DisplayName
		{
			get;
			set;
		}
		[JsonProperty("spot")]
		public decimal Spot
		{
			get;
			set;
		}
		[JsonProperty("spot_time")]
		public string SpotTime
		{
			get;
			set;
		}
		[JsonProperty("is_trading_suspended")]
		public int IsTradingSuspended
		{
			get;
			set;
		}
		[JsonProperty("quoted_currency_symbol")]
		public string QuotedCurrencySymbol
		{
			get;
			set;
		}
		[JsonProperty("spot_age")]
		public string SpotAge
		{
			get;
			set;
		}
		[JsonProperty("market")]
		public string Market
		{
			get;
			set;
		}
		[JsonProperty("market_display_name")]
		public string MarketDisplayName
		{
			get;
			set;
		}
		[JsonProperty("submarket")]
		public string Submarket
		{
			get;
			set;
		}
		[JsonProperty("submarket_display_name")]
		public string SubmarketDisplayName
		{
			get;
			set;
		}
		[JsonProperty("pip")]
		public decimal Pip
		{
			get;
			set;
		}
		public ActiveSymbolsResponseItem()
		{
		}
	}
}
