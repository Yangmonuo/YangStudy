using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MySql.Data.MySqlClient;

namespace KIT206_Week9
{
    abstract class Agency
    {
        //These would not be hard coded in the source file normally, but read from the application's settings (and, ideally, with some amount of basic encryption applied)
        private const string db = "kit206";
        private const string user = "kit206";
        private const string pass = "kit206";
        private const string server = "alacritas.cis.utas.edu.au";

        private static MySqlConnection conn = null;

        //Part of step 2.3.3 in Week 9 tutorial. This method is a gift to you because .NET's approach to converting strings to enums is so horribly broken
        public static T ParseEnum<T>(string value)
        {
            return (T)Enum.Parse(typeof(T), value);
        }

        /// <summary>
        /// Creates and returns (but does not open) the connection to the database.
        /// </summary>
        private static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                //Note: This approach is not thread-safe
                string connectionString = String.Format("Database={0};Data Source={1};User Id={2};Password={3}", db, server, user, pass);
                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }

        //For step 2.2 in Week 9 tutorial
        public static List<Employee> LoadAll()
        {
            List<Employee> staff = new List<Employee>();

            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select id, given_name, family_name from staff", conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    staff.Add(new Employee { ID = rdr.GetInt32(0), Name = rdr.GetString(1) + " " + rdr.GetString(2) });
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error connecting to database: " + e);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return staff;
        }

        //For step 2.3 in Week 9 tutorial
        public static List<RosterItem> LoadRosterItems(int id)
        {
            List<RosterItem> work = new List<RosterItem>();

            MySqlConnection conn = GetConnection();
            MySqlDataReader rdr = null;

            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand("select day, start, end from consultation where staff_id=?id", conn);
                cmd.Parameters.AddWithValue("id", id);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    work.Add(new RosterItem
                    {
                        Day = ParseEnum<DayOfWeek>(rdr.GetString(0)),
                        Start = rdr.GetTimeSpan(1),
                        End = rdr.GetTimeSpan(2)
                    });
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error connecting to database: " + e);
            }
            finally
            {
                if (rdr != null)
                {
                    rdr.Close();
                }
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return work;
        }

        //Optional part of step 2.3.4 in Week 9 tutorial illustrating that some answers can be obtained by directly querying the database.
        //This is useful if the necessary data has not been loaded into memory yet.
        public static bool EmployeeBusyNow(Employee e)
        {
            MySqlConnection conn = GetConnection();
            int overlapping = 0;

            try
            {
                conn.Open();

                DateTime now = DateTime.Now;
                MySqlCommand cmd = new MySqlCommand("select count(*) from consultation where staff_id=?id and day=?day and start <= ?now and end > ?now", conn);
                cmd.Parameters.AddWithValue("id", e.ID);
                cmd.Parameters.AddWithValue("day", now.DayOfWeek.ToString());
                cmd.Parameters.AddWithValue("now", now.TimeOfDay.ToString());
                overlapping = Int32.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error connecting to database: " + ex);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return overlapping > 0;
        }

        //This method is now obsolete.
        public static List<Employee> Generate()
        {
            return new List<Employee>() {
                new Employee { Name = "Jane", ID = 1, Gender = Gender.F },
                new Employee { Name = "John", ID = 3, Gender = Gender.M },
                new Employee { Name = "Mary", ID = 7, Gender = Gender.F },
                new Employee { Name = "Lindsay", ID = 5, Gender = Gender.X },
                new Employee { Name = "Meilin", ID = 2, Gender = Gender.F }
            };
        }
    }
}
