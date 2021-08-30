using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Week9
{

    //As an example, this includes an additional 'gender' called Any that could be used in a GUI drop-down list.
    //The filtering could then be modified that if Gender.Any is selected that the full list is returned with no filtering performed.
    public enum Gender { M, F, X, Any };

    /// <summary>
    /// A class baring a striking resemblance to a university staff member
    /// </summary>
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public List<RosterItem> WorkTimes { get; set; }

        //Step 2.3.4 in Week 9 tutorial
        public bool BusyNow()
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

        public override string ToString()
        {
            //As part of step 2.3.2 and 2.3.4 in Week 9 tutorial, have modified this to display the work times and if the employee is currently busy
            return String.Format("{0}\t{1}\tWork times: {2}\tBusy right now: {3}", ID, Name, String.Join(", ", WorkTimes), BusyNow() );
            //previous version: return Name + '\t' + ID + '\t' + Gender;
        }
    }
}
