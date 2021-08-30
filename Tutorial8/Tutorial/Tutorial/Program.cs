using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    class Program
    {
        static void Main(string[] args)
        {


            //Linq 对类的例子
            List<RosterItem> staff = new List<RosterItem>() {
            new RosterItem(DayOfWeek.Monday,new TimeSpan(8,0,0),new TimeSpan(17,0,0)),
                  new RosterItem(DayOfWeek.Tuesday,new TimeSpan(8,0,0),new TimeSpan(17,0,0)),
                 new RosterItem(DayOfWeek.Wednesday,new TimeSpan(8,0,0),new TimeSpan(17,0,0)),
                 new RosterItem(DayOfWeek.Thursday,new TimeSpan(8,0,0),new TimeSpan(17,0,0)),
                 new RosterItem(DayOfWeek.Friday,new TimeSpan(8,0,0),new TimeSpan(17,0,0))

                    };

            staff = staff.FindAll(aaa => aaa.overlaps(new DateTime(2021,8,31,11,1,11)));


            foreach (var item in staff)
            {
                Console.WriteLine(item.Day + "---" + item.start + "------" + item.end);
            }
            DayOfWeek dd=ParseEnum< DayOfWeek >("Monday");

            int ddddd = ParseEnum<int>("1");

            Console.Read();//等待输入下一个字符。
        }
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }
    }
}
