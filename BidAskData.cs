using System;

namespace ViewBidAskDB
{
    /// <summary>
    /// Описание отдельной котировки инструмента
    /// </summary>
    public class BidAskData : IComparable<BidAskData>, IEquatable<BidAskData>
    {
        public DateTime Date { get; set; }
        public double Bid { get; set; }
        public int BidDepth { get; set; }
        public double Ask { get; set; }
        public int AskDepth { get; set; }
        public double Step { get; set; }

        public BidAskData() { }
        public BidAskData(DateTime date, double bid = 0, int bidDepth=0, double ask = 0, int askDepth=0, double step = 0)
        {
            Date = date;
            Bid = bid;
            BidDepth = bidDepth;
            Ask = ask;
            AskDepth = askDepth;
            Step = step;
        }

        public int CompareTo(BidAskData other)
        {
            return Date.CompareTo(other.Date);
        }

        public bool Equals(BidAskData other)
        {
            return Date == other.Date;
        }
        //для поддержки IEquatable<RatesData>
        public override int GetHashCode()
        {
            return Date.GetHashCode();
        }
    }
}