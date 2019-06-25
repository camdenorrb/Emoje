﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordHackWeek2019.Models
{
    public class Investment
    {
        public ulong InvestmendId { get; set; }
        public float PurchasePrice { get; set; }
        public DateTimeOffset PurchaseTimestamp { get; set; }
        public float? SellPrice { get; set; }
        public DateTimeOffset? SellTimestamp { get; set; }
    }

    public class InvestmentPortfolio
    {
        Dictionary<string, IEnumerable<Investment>> Items { get; set; }
    }

    public class PortfolioCollection
    {
        public InvestmentPortfolio Stocks { get; set; }
        public InvestmentPortfolio Crypto { get; set; }
    }
}
