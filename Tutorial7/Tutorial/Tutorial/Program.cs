using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    class Program
    {
        public delegate Employee ManageWorker(int id);
        static void Main(string[] args)
        {
            Console.WriteLine("Part1    属性-------------------");
            Employee em = new Employee("Jack", 1, Gender.F);
            em.Name = "Jack";//第一种方法访问
            //第二种方法，因为有private的存在，所以不允许访问
            //em.Name2 = "Jack2";
            em.Name3 = "Jack3";//第三种方法访问
            Console.WriteLine(em.ToString());


            Console.WriteLine("Part2     抽象类----------------------");

            Boss bos = new Boss();
            //bos.Fire(1); 
            em = bos.Use(1);
            Console.WriteLine(em.ToString());
            bos.Display();

            Console.WriteLine("Part3     委托(难度大，老师不要求)----------------------");

            Action doSomething = bos.Display;
            ManageWorker manage = bos.Use;
            Console.WriteLine(manage(1));
            doSomething();
           
            Console.WriteLine(em.ToString());
            Console.Read();//等待输入下一个字符。
        }

       public static void newman(int i)
        {
            return ;
        }

    }
}
