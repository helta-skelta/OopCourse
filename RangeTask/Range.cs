using System.Text;

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

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return number >= From && number <= To;
        }

        public Range? GetIntersection(Range range)
        {
            if (To <= range.From || range.To <= From)
            {
                return null;
            }

            return new Range(Math.Max(From, range.From), Math.Min(To, range.To));
        }

        public Range[] GetUnion(Range range)
        {
            if (To < range.From || range.To < From)
            {
                return new Range[] { new Range(From, To), new Range(range.From, range.To) };
            }

            return new Range[] { new Range(Math.Min(From, range.From), Math.Max(To, range.To)) };
        }

        public Range[] GetDifference(Range range)
        {
            if (To <= range.From || From >= range.To)
            {
                return new Range[] { new Range(From, To) };
            }

            if (From >= range.From && To <= range.To)
            {
                return Array.Empty<Range>();
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            if (To <= range.To && From < range.From)
            {
                return new Range[] { new Range(From, range.From) };
            }

            return new Range[] { new Range(range.To, To) };
        }

        public override string ToString()
        {
            return $"({From}, {To})";
        }

        public static string PrintRanges(Range[] ranges)
        {
            if (ranges.Length == 0)
            {
                return "[]";
            }

            StringBuilder stringBuilder = new();

            stringBuilder.Append('[');

            foreach (Range range in ranges)
            {
                stringBuilder.Append(range)
                .Append(", ");
            }

            stringBuilder.Remove(stringBuilder.Length - 2, 2)
            .Append(']');

            return stringBuilder.ToString();
        }
    }
}