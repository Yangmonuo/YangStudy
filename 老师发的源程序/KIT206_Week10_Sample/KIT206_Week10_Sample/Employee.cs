using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Week9
{

    //As an example, this includes an additional 'gender' called Any that could be used in a GUI drop-down list.
    //The filtering could then be modified that if Gender.Any is selected that the full list is returned with no filtering performed.
    public enum Gender { Any, M, F, X };

    /// <summary>
    /// A class baring a striking resemblance to a staff member
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public List<RosterItem> WorkTimes { get; set; }

		//Step 2.3.4 in Week 9 tutorial, but now as a calculated property
        public bool BusyNow
        {
            get
            {
                if (WorkTimes != null)
                {
                    DateTime now = DateTime.Now;
                    var overlapping = from RosterItem work in WorkTimes
                                      where work.Overlaps(now)
                                      select work;
                    return overlapping.Count() > 0;
    
                    //which could be rewritten as a single expression:
                    //return (from RosterItem work in WorkTimes
                    //        where work.Overlaps(now)
                    //        select work).Count() > 0;
                }
                return false;
			}
		}

        public double TotalWorkHours
        {
            get
            {
                double total = 0;
                foreach (RosterItem item in WorkTimes)
                {
                    total += (item.End - item.Start).TotalHours;
                }
                return total;

                //Which can be done using LINQ
                //return (from RosterItem item in WorkTimes
                //        select (item.End - item.Start).TotalHours).Sum();
            }
        }

        public double Workload
        {
            //This is equivalent to TotalWorkHours / 4 * 100
            get { return TotalWorkHours / 0.04; }
        }

        public override string ToString()
        {
            //For the purposes of this week's demonstration this returns only the name
            return Name;
        }
    }
}
