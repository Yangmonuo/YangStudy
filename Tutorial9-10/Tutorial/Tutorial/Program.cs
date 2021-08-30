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


            int[] inte = { 3, 45, 7, 8, 9, 9, 65, 7, 45, 34, 40, 3, 23 };
            //Linq 的函数语法
            int[] result1 = inte.Where(aaaaaa => aaaaaa % 2 == 0).ToArray();
            //Linq 的查询语法
            int[] result2 = (from p in inte where p % 2 == 0 select p).ToArray();

            int[] result3 = inte.Where(ints =>
                                {
                                    int item = 9;
                                    return ints == item;
                                }).ToArray();

            Console.WriteLine("lyy：" + string.Join(",", result3));
            Console.WriteLine("偶数：" + string.Join(",", result1));
            Console.WriteLine("偶数：" + string.Join(",", result2));
            Console.WriteLine("------------------------");




            //Linq 对类的例子
            List<Employee> staff = new List<Employee>() {
            new Employee("asdf",2,Gender.F),
            new Employee("Jack",1,Gender.M),
            new Employee("lyy",5,Gender.F),
             new Employee("lyy2",8,Gender.F),
              new Employee("lyy4",3,Gender.M),
               new Employee("lyy7",5,Gender.F)
                    };
            //条件检索
            //staff = staff.Where(a => a.ID % 2 != 0).ToList<Employee>();
            //foreach (var item in staff)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //排序
            //staff = staff.OrderByDescending(a=>a.ID).ToList<Employee>();
            //foreach (var item in staff)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            //求最大值
            //int ii==staff.Max(a => a.ID);
            //求平均值
            //double ii = staff.Average(a => a.ID);

            //逐个改变值
            //staff.Concat(new List<Employee> { } );
            //staff.ForEach(a => a.ID+=9);

            //自操作1
            // staff.ForEach(aa => aa.Name = aa.Name + "-----");

            //自操作2
            staff.ForEach(aa => {
                aa.Name = aa.Name + "-----";
                }
            );
     

            foreach (var item in staff)
            {
                Console.WriteLine(item.ToString());
            }

          //  Console.WriteLine(ii);
            Console.Read();//等待输入下一个字符。
        }
    }
}
