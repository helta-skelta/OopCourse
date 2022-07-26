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

            double maxFrom = Math.Max(From, range.From);
            double minTo = Math.Min(To, range.To);

            return new Range(maxFrom, minTo);
        }

        public Range[] GetUnion(Range range)
        {
            if (To < range.From || range.To < From)
            {
                return new Range[] { this, range };
            }

            double minFrom = Math.Min(From, range.From);
            double maxTo = Math.Max(To, range.To);

            return new Range[] { new Range(minFrom, maxTo) };
        }

        public Range[] GetDifference(Range range)
        {
            if (range.From < To && range.To >= To)
            {
                return new Range[] { new Range(From, range.From) };
            }

            if (range.To > From && range.From <= From)
            {
                return new Range[] { new Range(range.To, To) };
            }

            if (range.To <= From || range.From >= To)
            {
                return new Range[] { this };
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            return Array.Empty<Range>();
        }

        public override string ToString()
        {
            return $"Диапазон ({From},{To})";
        }
    }
}