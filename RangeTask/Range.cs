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
                Range newInterval = new(interval1.From, interval2.To);

                Range[] result = { newInterval };

                return result;
            }

            if (interval2.To > interval1.From && interval2.From <= interval1.From)
            {
                Range newInterval = new(interval2.From, interval1.To);

                Range[] result = { newInterval };

                return result;
            }

            Range[] _result = { interval1, interval2 };

            return _result;
        }

        public Range[]? GetIntervalsDifference(Range interval1, Range interval2)
        {
            if (interval1.From > interval2.From && interval1.To < interval2.To)
            {
                Range newInterval1 = new(interval2.From, interval1.From);
                Range newInterval2 = new(interval1.To, interval2.To);

                Range[] result = { newInterval1, newInterval2 };

                return result;
            }

            if (interval2.From > interval1.From && interval2.To < interval1.To)
            {
                Range newInterval1 = new(interval1.From, interval2.From);
                Range newInterval2 = new(interval2.To, interval1.To);

                Range[] result = { newInterval1, newInterval2 };

                return result;
            }

            if (interval1.To > interval2.From && interval1.From <= interval2.From)
            {
                Range newInterval = new(interval1.From, interval2.From);

                Range[] result = { newInterval };

                return result;
            }

            if (interval2.To > interval1.From && interval2.From <= interval1.To)
            {
                Range newInterval = new(interval2.To, interval1.To);

                Range[] result = { newInterval };

                return result;
            }

            Range _newInterval = new(0, 0);

            Range[] _result = { _newInterval };

            return _result;
        }
    }
}