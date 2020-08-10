using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Journal_Pluralsight
{
    public class Statistics
    {
        public Statistics(List<double> grades)
        {
            low = grades.Min();
            average = grades.Average();
            high = grades.Max();
        }
        public double low;
        public double average;
        public double high;
    }
}
