using System;

namespace RangeTask
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public Range()
        {

        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return number >= From && number <= To;
        }

        public Range? GetIntervalsIntersection(Range interval1, Range interval2)
        {
            if (interval1.From >= interval2.From && interval1.To <= interval2.To)
            {
                Range result = new(interval1.From, interval1.To);

                return result;
            }

            if (interval2.From >= interval1.From && interval2.To <= interval1.To)
            {
                Range result = new(interval2.From, interval2.To);

                return result;
            }

            if (interval1.To > interval2.From && interval1.From <= interval2.From)
            {
                Range result = new(interval2.From, interval1.To);

                return result;
            }

            if (interval1.To >= interval2.To && interval1.From < interval2.To)
            {
                Range result = new(interval1.From, interval2.To);

                return result;
            }

            return null;
        }

        public Range[] GetIntervalsJoining(Range interval1, Range interval2)
        {
            if (interval1.To > interval2.From && interval1.From <= interval2.From)
            {
                Range[] result = { new(interval1.From, interval2.To) };

                return result;
            }

            if (interval2.To > interval1.From && interval2.From <= interval1.From)
            {
                Range[] result = { new(interval2.From, interval1.To) };

                return result;
            }

            Range[] _result = { interval1, interval2 };

            return _result;
        }

        public Range[]? GetIntervalsDifference(Range interval1, Range interval2)
        {
            if (interval1.From > interval2.From && interval1.To < interval2.To)
            {
                Range[] result = { new(interval2.From, interval1.From), new(interval1.To, interval2.To) };

                return result;
            }

            if (interval2.From > interval1.From && interval2.To < interval1.To)
            {
                Range[] result = { new(interval1.From, interval2.From), new(interval2.To, interval1.To) };

                return result;
            }

            if (interval1.To > interval2.From && interval1.From <= interval2.From)
            {
                Range[] result = { new(interval1.From, interval2.From) };

                return result;
            }

            if (interval2.To > interval1.From && interval2.From <= interval1.To)
            {
                Range[] result = { new(interval2.To, interval1.To) };

                return result;
            }

            Range[] _result = { new(0, 0) };

            return _result;
        }
    }
}