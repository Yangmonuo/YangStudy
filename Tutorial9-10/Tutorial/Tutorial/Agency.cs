using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    abstract class Agency
    {
        public abstract List<Employee> Generate();   //抽象类
    }

    class Boss : Agency
    {
        public List<Employee> staff = new List<Employee>();


        public Boss()
        {
            staff = this.Generate();
        }

        public override List<Employee> Generate()
        {
            List<Employee> staff = new List<Employee>() {
            new Employee("asdf",2,Gender.F),
                      new Employee("Jack",1,Gender.M),
            new Employee("lyy",5,Gender.F)
                    };
            return staff;
        }

        public void Display()
        {
            foreach (var item in staff)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public Employee Use(int id)
        {
            foreach (var item in staff)
            {
                if (item.ID == id)
                    return item;
            }
            return null;
        }
        public Employee Fire(int id)
        {
            foreach (var item in staff)
            {
                if (item.ID == id)
                {
                    staff.Remove(item);
                    return item;
                }
            }
            return null;
        }
    }
}
