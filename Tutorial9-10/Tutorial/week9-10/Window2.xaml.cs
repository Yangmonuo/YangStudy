using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tutorial;

namespace week9_10
{
    /// <summary>
    /// Window2.xaml 的交互逻辑
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            
        }

     
        

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Boss boss = new Boss();
            boss.staff.Add(new Employee("11111111111", 22, Gender.M));
            boss.staff.Add(new Employee("11111111111", 22, Gender.M));
            boss.staff.Add(new Employee("11111111111", 22, Gender.M));
            boss.staff.Add(new Employee("11111111111", 22, Gender.M));
            boss.Generate();
            Application.Current.Resources["aaaaaaaaaaa"] = boss.staff;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> lt = new List<Employee>();
            lt.Add(new Employee("asdf", 1, Gender.F));

            lt.Add(new Employee("asdf", 1, Gender.F));

            lt.Add(new Employee("asdf", 1, Gender.F));

            lt.Add(new Employee("asdf", 1, Gender.F));

            lt.Add(new Employee("asdf", 1, Gender.F));
            Employee em = new Employee("asdf", 1, Gender.F);
            sp123.DataContext = em;
        }
    }
}
