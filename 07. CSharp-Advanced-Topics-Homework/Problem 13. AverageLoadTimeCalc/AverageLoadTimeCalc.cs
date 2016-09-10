// Calculate the average load time for each URL
using System;
using System.Collections.Generic;
using System.Linq;

class Report
{
    public DateTime date { get; set; }
    public string URL { get; set; }
    public double loadTime { get; set; }
}

class AverageLoadTimeCalc
{
    static void Main()
    {
        List<Report> list = new List<Report>();
        Report report;
        string input;
        Console.WriteLine("Leave a blank line to calculate");
        do
        {
            Console.Write("Please enter a report: ");
            input = Console.ReadLine();

            if (input == "")
            {
                break;
            }

            string[] inputArray = input.Split();

            DateTime date = Convert.ToDateTime(inputArray[0]);
            var dateTime = new DateTime(date.Year, date.Month, date.Day, int.Parse(inputArray[1].Substring(0, 2)), int.Parse(inputArray[1].Substring(3, 2)), 0);
            report = new Report();
            report.date = dateTime;
            report.URL = inputArray[2];
            report.loadTime = Double.Parse(inputArray[3]);
            list.Add(report);
        } while(true);

        List<List<Report>> sortedReports = new List<List<Report>>();
        sortedReports.Add(new List<Report>());
        sortedReports[0].Add(list[0]);
        bool foundList = false;

        // Sort reports by URL in different lists
        for (int i = 1; i < list.Count; i++)
        {
            for (int j = 0; j < sortedReports.Count; j++)
            {
                if (list[i].URL == sortedReports[j][0].URL)
                {
                    sortedReports[j].Add(list[i]);
                    foundList = true;
                }
            }

            if (!foundList)
            {
                List<Report> newList = new List<Report>();
                newList.Add(list[i]);
                sortedReports.Add(newList);
            }
            foundList = false;
        }

        double sum = 0;
        foreach (var currList in sortedReports)
        {
            Console.Write(currList[0].URL + " -> ");
            foreach (var currReport in currList)
            {
                sum += currReport.loadTime;
            }
            Console.WriteLine((double)sum / currList.Count);
            sum = 0;
        }
    }
}