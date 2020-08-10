using System;
using System.Collections.Generic;

namespace Journal_Pluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Maks");
            book.addGrade(66.5);
            book.addGrade(77.1);
            book.ShowStatistcs();
        }
    }
}
