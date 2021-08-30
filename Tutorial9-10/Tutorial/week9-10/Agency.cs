using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public abstract class Agency
    {
        public abstract ObservableCollection<Employee> Generate();   //抽象类
    }

   public class Boss : Agency
    {
        public ObservableCollection<Employee> staff;


        public Boss()
        {
            staff= new ObservableCollection<Employee>() { new Employee("asdf", 2, Gender.F) };
        }

        public override ObservableCollection<Employee> Generate()
        {
            //ObservableCollection<Employee> staff = new ObservableCollection<Employee>() {
            //new Employee("asdf",2,Gender.F),
            //new Employee("Jack",1,Gender.M),
            //new Employee("lyy",5,Gender.F)
            //        };
            staff.Add(new Employee("asdf", 3, Gender.F));

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
