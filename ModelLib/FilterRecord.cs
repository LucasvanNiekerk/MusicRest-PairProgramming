using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class FilterRecord
    {
        private int _minimumLength;
        private int _maximumLength;

        public FilterRecord(int minimumLength, int maximumLength)
        {
            MinimumLength = minimumLength;
            MaximumLength = maximumLength;
        }

        public int MinimumLength { get => _minimumLength; set => _minimumLength = value; }
        public int MaximumLength { get => _maximumLength; set => _maximumLength = value; }
    }
}
