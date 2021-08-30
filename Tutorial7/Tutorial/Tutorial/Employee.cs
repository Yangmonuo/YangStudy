using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{

    /// <summary>
    /// 雇员类
    /// </summary>
    public class Employee : IComparable
    {

        /// <summary>
        /// 第一种定义属性的方法
        /// </summary>
        public string Name { get; set; }


        /// <summary>
        /// 第二种定义属性的方法
        /// </summary>
        public string Name2 { get; private set; }

        /// <summary>
        /// 第三种定义属性的方法
        /// </summary>
        private string name3;
        public string Name3
        {
            get
            {
                return name3;
            }
            set
            {
                if (value != null)
                {
                    name3 = value;
                }
            }
        }

        public int ID { get; set; }
        public Gender gender { get; set; }
        /// <summary>
        /// 类的初始化函数
        /// </summary>
        /// <param name="sname"></param>
        /// <param name="sid"></param>
        /// <param name="sgender"></param>
        public Employee(string sname, int sid, Gender sgender)
        {
            Name = sname;
            ID = sid;
            gender = sgender;
        }
        /// <summary>
        /// 这个类重载了ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ID:"+ID + " Name:" + Name + " Gender:" + gender;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="comparePart"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Employee objAsEmployee = obj as Employee;
            if (objAsEmployee == null) return 1;


            if (obj == null)
                return 1;
            else
                return this.ID.CompareTo(objAsEmployee.ID);
        }
    }

    /// <summary>
    /// 枚举，性别，M女，F男，X未知
    /// </summary>
    public enum Gender
    {
        M,
        F,
        X
    }


}
