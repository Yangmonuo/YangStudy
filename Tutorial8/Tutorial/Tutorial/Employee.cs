using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    /// <summary>
    /// 
    /// </summary>
    public class RosterItem
    {

        public DayOfWeek Day { get; set; }

        public TimeSpan start { get; set; }
        public TimeSpan end { get; set; }
        /// <summary>
        /// 类的初始化函数
        /// </summary>
        /// <param name="sname"></param>
        /// <param name="sid"></param>
        /// <param name="sgender"></param>
        public RosterItem(DayOfWeek asname, TimeSpan astart, TimeSpan aend)
        {
            Day = asname;
            start = astart;
            end = aend;
        }
        /// <summary>
        /// 这个类重载了ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Day:" + Day + " start:" + start + " end:" + end;
        }

        //工作是否重叠
        public  bool overlaps(DateTime dt)
        {
            return dt.DayOfWeek == Day && dt.Hour > start.Hours && dt.Hour < end.Hours;
        }
    }

}
