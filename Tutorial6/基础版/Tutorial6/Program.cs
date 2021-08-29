using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial6
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            //初始化类
            Employee em = new Employee("Jack", 1, Gender.F);
            //显示类的内容，默认显示类名，如果有重载ToString函数的话，调用函数并显示。
          //  Console.WriteLine(em);


            //初始化泛型列表，容纳Employee
            List<Employee> ltEp = new List<Employee>();

            //给列表添加数据
            ltEp.Add(new Employee("Lyy", 2, Gender.F));
            ltEp.Add(new Employee("Rose3", 5, Gender.M));
            ltEp.Add(new Employee("Coke66", 4, Gender.X));
            ltEp.Add(new Employee("Lyy34455",7, Gender.F));
            ltEp.Add(new Employee("Rose", 3, Gender.M));
            ltEp.Add(new Employee("Coke", 1, Gender.X));

           
       

            foreach (var item in ltEp)
            {
                Console.WriteLine(item.ID + " " + item.name + " " + item.gender);
            }
         


            //等待输入下一个字符。
            Console.Read();
        }
        /// <summary>
        /// Emploee 比较函数
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        private static int CompareDinosByLength(Employee x, Employee y)
        {
            return x.name.Length.CompareTo(y.name.Length);
        }

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
