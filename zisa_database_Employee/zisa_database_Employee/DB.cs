using System.Collections.Generic;
using System.Data.SqlClient;

namespace zisa_database_Employee
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
                    EmployeeId = int.Parse(rd.GetString(rd.GetOrdinal("EmployeeId"))),
                    Name = rd.GetString(rd.GetOrdinal("Name")),
                    Position = rd.GetString(rd.GetOrdinal("Position")),
                    HourlyPayRate = rd.GetString(rd.GetOrdinal("HourlyPayRate"))
                });
            rd.Close();
            
            return emp;
        }
    }
}
