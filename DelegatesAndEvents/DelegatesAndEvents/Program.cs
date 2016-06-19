using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);


    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public enum WorkType
    {
        GoToMeetings, Golf, GenerateReports
    }
}
