using System.Collections.Generic;
using QuantConnect.Algorithm;
using QuantConnect.Data;
using QuantConnect.Indicators;

namespace QuantConnect.Tests.Common.Capacity.Strategies
{
    public class EmaPortfolioRebalance100 : QCAlgorithm
    {
    	public List<SymbolData> Data;

        public override void Initialize()
        {
            SetStartDate(2020, 1, 1);
            SetEndDate(2020, 2, 5);
            SetWarmup(1000);
            SetCash(100000);

            Data = new List<SymbolData> {
				new SymbolData(this, AddEquity("AADR", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAMC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAU", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ABDC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ABIO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ABUS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACER", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACES", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACGLO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACH", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACHV", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACIO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACIU", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACNB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACRS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACSI", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACT", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACT", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACTG", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZYNE", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZYME", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZUO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZUMZ", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZTR", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZSL", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZSAN", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZROZ", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZLAB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZIXI", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZIV", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZIOP", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZGNX", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZG", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZEUS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZAGG", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("YYY", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("YRD", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("YRCW", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("YPF", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AA", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAN", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAP", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAXN", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ABB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ABC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACAD", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACGL", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACIW", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACWV", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ACWX", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ADM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ADPT", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ADS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ADUS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AEM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AEO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AEP", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ZTS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("YUM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLY", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLV", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLRE", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLP", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLNX", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLF", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XLB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XEL", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("XBI", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("X", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WYNN", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WW", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WORK", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WMB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WELL", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("WEC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AAPL", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("ADBE", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AGG", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AMD", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("AMZN", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("BA", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("BABA", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("BAC", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("BMY", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("C", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("CMCSA", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("CRM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("CSCO", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("DIS", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("EEM", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("EFA", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("FB", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("GDX", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("GE", Resolution.Minute).Symbol),
				new SymbolData(this, AddEquity("SPY", Resolution.Minute).Symbol)
            };
        }

        public override void OnData(Slice data)
        {
        	var fastFactor = 0.005m;

			foreach (var sd in Data)
			{
				if (!Portfolio.Invested && sd.Fast * (1 + fastFactor) > sd.Slow)
				{
					SetHoldings(sd.Symbol, 0.01);
				}
				else if (Portfolio.Invested && sd.Fast * (1 - fastFactor) < sd.Slow)
				{
					Liquidate(sd.Symbol);
				}
			}
        }

        public class SymbolData {

        	public Symbol Symbol;
        	public ExponentialMovingAverage Fast;
        	public ExponentialMovingAverage Slow;
        	public bool IsCrossed => Fast > Slow;

        	public SymbolData(QCAlgorithm algorithm, Symbol symbol) {
        		Symbol = symbol;
        		Fast = algorithm.EMA(symbol, 20);
        		Slow = algorithm.EMA(symbol, 300);
        	}
        }
    }
}
