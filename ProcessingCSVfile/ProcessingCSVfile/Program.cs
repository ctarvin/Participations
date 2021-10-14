using System;
using System.IO;

namespace ProcessingCSVfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linesOfFile = File.ReadAllLines("sales_data_sample.csv");
            double totalsales = 0;
            double totalSales2003 = 0;
            double totalSales2004 = 0;
            double totalSales2005 = 0;
            double totalSalesJan = 0;
            double totalSalesFeb = 0;
            
            for (int i = 1; i < linesOfFile.Length; i++)
            {
                string line = linesOfFile[i];
                string[] piecesOfLine = line.Split(',');

                string status = piecesOfLine[6];
                double sales = Convert.ToDouble(piecesOfLine[4]);
                int year = Convert.ToInt32(piecesOfLine[9]);
                int month = Convert.ToInt32(piecesOfLine[8]);

                if (status.ToLower() == "shipped")
                {
                    if (year == 2003)
                    {
                        totalSales2003 += sales;  
                    }

                    if (year == 2004)
                    {
                        totalSales2004 += sales;
                    }
                    if (year == 2005)
                    {
                        totalSales2005 += sales;
                    }
                    if (month == 1)
                    {
                        totalSalesJan += sales;
                    }
                    if (month == 2)
                    {
                        totalSalesFeb += sales;
                    }
                    totalsales += sales;
                }
                
            }
                Console.WriteLine($"The total sales for all orders shipped is {totalsales.ToString("c")}");
                Console.WriteLine($"The total sales for all orders shipped in 2003 is {totalSales2003.ToString("c")}");
                Console.WriteLine($"The total sales for all orders shipped in 2004 is {totalSales2004.ToString("c")}");
                Console.WriteLine($"The total sales for all orders shipped in 2005 is {totalSales2005.ToString("c")}");
                Console.WriteLine($"The total sales for all orders shipped in January of 2003-2005 is {totalSalesJan.ToString("c")}");
                Console.WriteLine($"The total sales for all orders shipped in February 2003-2005 is {totalSalesFeb.ToString("c")}");
        }   
    }
}
