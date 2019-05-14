using System.Collections.Generic;
using System.Data.SqlClient;

namespace Zisa_Database_Employee2
{
    public class DB
    {
        const string CONNECT_STRING = @"Server=desktop-lt88502\fatimasql2017;Database=Personnel;Trusted_Connection=True;";
        SqlConnection conn;

        static DB _db;

        private DB()
        {
            conn = new SqlConnection(CONNECT_STRING);
            conn.Open();
        }

        public static DB GetInstance()
        {
            if (_db == null)
                _db = new DB();
            return _db;
        }

        public double GetAvgPay()
        {
            double averageRate=0;
            var cmdString = "SELECT AVG(HourlyPayRate) as AVG_Rate" +
                               " FROM Employee";
            var cmd = new SqlCommand(cmdString, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                averageRate = rd.GetDouble(rd.GetOrdinal("AVG_Rate"));
            }
                
            rd.Close();

            return averageRate;
        }
        public double GetLowestPay()
        {
            double lowestRate = 0;
            var cmdString = "SELECT MIN(HourlyPayRate) as MIN_Rate" +
                               " FROM Employee";
            var cmd = new SqlCommand(cmdString, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                lowestRate = rd.GetDouble(rd.GetOrdinal("MIN_Rate"));
            }

            rd.Close();

            return lowestRate;
        }



        public List<Employee> Get()
        {
            var emp = new List<Employee>();
            var cmdString = "SELECT EmployeeId, Name, Position, HourlyPayRate" +
                               " FROM Employee";
            var cmd = new SqlCommand(cmdString, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                emp.Add(new Employee()
                {
                    EmployeeId = rd.GetInt32(rd.GetOrdinal("EmployeeId")),
                    Name = rd.GetString(rd.GetOrdinal("Name")),
                    Position = rd.GetString(rd.GetOrdinal("Position")),
                    HourlyPayRate = rd.GetDouble(rd.GetOrdinal("HourlyPayRate"))
                });
            rd.Close();

            return emp;
        }
    }
}
