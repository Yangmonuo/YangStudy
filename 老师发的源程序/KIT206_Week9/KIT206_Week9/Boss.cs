using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIT206_Week9
{
    class Boss
    {
        List<Employee> staff;
        public List<Employee> Workers { get { return staff; } }

        public Boss()
        {
            staff = Agency.LoadAll();

            //Part of step 2.3.2 in Week 9 tutorial
            foreach (Employee e in staff)
            {
                e.WorkTimes = Agency.LoadRosterItems(e.ID);
            }
        }


        //For step 1.1 in Week 9 tutorial
        //Cannot be used with the live data as no direct equivalent of gender in database, but
        //perhaps you can think of some other (categorical) information used in the case study?
        public List<Employee> Filter(Gender gender)
        {
            var selected = from Employee e in staff
                           where e.Gender == gender
                           select e;
            return new List<Employee>(selected);
        }

        /// <summary>
        /// Displays the list of employees on the console.
        /// </summary>
        public void Display()
        {
            staff.ForEach(Console.WriteLine);
        }

        //The following, from the Week 8 tutorial, were not used or modified in Week 9

        /// <summary>
        /// Returns the Employee with the given ID, or null if no such employee exists.
        /// </summary>
        public Employee Use(int id)
        {
            foreach (Employee e in staff) {
                if (e.ID == id) {
                    return e;
                }
            }
            return null;
            //FYI, if you have an interest in lambda expressions the above could be achieved with:
            //return staff.First(e => e.ID == id);
        }

        /// <summary>
        /// Removes the Employee with the given ID from the staff list; if a
        /// matching Employee was found it is returned, otherwise returns null.
        /// </summary>
        public Employee Fire(int id)
        {
            Employee target = Use(id);
            if (target != null)
            {
                staff.Remove(target);
            }
            return target;
        }

    }
}
