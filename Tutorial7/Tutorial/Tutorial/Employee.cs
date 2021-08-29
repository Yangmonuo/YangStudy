﻿using System;
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
        public string name { get; set; }
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
            name = sname;
            ID = sid;
            gender = sgender;
        }
        /// <summary>
        /// 这个类重载了ToString方法
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return ID + " " + name + " " + gender;
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
