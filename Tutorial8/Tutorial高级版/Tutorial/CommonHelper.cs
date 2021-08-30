using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public static class CommonHelper
    {
        //+1重载，通过string对列表排序
        static List<Employee> FilterByGender(List<Employee> staff, string gender)
        {
            // staff.Sort(new Comparison<string>(>;
            return staff;
        }
        //+2重载，通过Gender对列表排序
        static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            return new List<Employee>();
        }
    }
     

}
