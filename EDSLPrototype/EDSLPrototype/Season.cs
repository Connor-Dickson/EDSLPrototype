using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDSLPrototype
{
    class Season
    {
        public string Name { get; set; }
        public int noOfRounds { get; set; }
        public string startDate { get; set; }
        public List<string> dateList { get; set; }
        
        public Season(string name, int roundNo, string start, List<string> dates)
        {
            name = Name;
            roundNo = noOfRounds;
            start = startDate;
            dates = dateList;
            
        }

        public List<DateTime> populateRoundDates(DateTime startDate)
        {
            //grab the current date and make a number of rounds starting from that date
            List<DateTime> dates = new List<DateTime>();
            dates.Add(startDate);
            for (int i = 0; i < noOfRounds - 1; i++)
            {
                DateTime date = GetNextSaturday(DateTime.Today.AddDays(1), DayOfWeek.Saturday);
                dates.Add(date);
            }
            return dates;
        }

        public List<int> populateRounds(int noOfRounds)
        {
            List<int> rounds = new List<int>();
            return rounds;
            //create the round numbers for the table
            
        }

        public static DateTime GetNextSaturday(DateTime start, DayOfWeek day)
        {
            
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            return start.AddDays(daysToAdd);
        }
    }
}
