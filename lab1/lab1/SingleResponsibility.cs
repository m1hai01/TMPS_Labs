using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
        public class Report
        {
            public string Text { get; set; } = "";
            public void GoToFirstPage() =>
                Console.WriteLine("Go to first page");

            public void GoToLastPage() =>
                Console.WriteLine("Go to last page");

            public void GoToPage(int pageNumber) =>
                Console.WriteLine($"Go to page {pageNumber}");


            /*public void Print()
            {
                Console.WriteLine("Printing a report");
                Console.WriteLine(Text);
            }*/
        }

        public class Printer
        {
            public void PrintReport(Report report)
            {
                Console.WriteLine("Print port");
                Console.WriteLine(report.Text);
            }
        }
    
}
