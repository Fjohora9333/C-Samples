using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;

namespace Zisa_Database_course_session
{
    class DB
    {
        const string CONNECT_STRING = @"Server=desktop-lt88502\fatimasql2017;Database=SIS;Trusted_Connection=True;";
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

        //Method to get all the sessions --ComboBox
        public List<Session> GetSession()
        {
            var sn = new List<Session>();
            var cmdString = "SELECT code,name FROM Session";
            var cmd = new SqlCommand(cmdString, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                sn.Add(new Session()
                {
                    Code = rd.GetString(rd.GetOrdinal("code")),

                    Name = rd.GetString(rd.GetOrdinal("name"))
                });
            rd.Close();


            return sn;
        }

        //method to get course detail for a selected Session code--Combobox to ListBox
        public List<CourseOffering> GetCourseOffering(Session s)
        {
            var co = new List<CourseOffering>();
            var cmdString = "SELECT CO.SessionCode, CO.CourseNumber, C.Name FROM CourseOffering CO join Course C" +
                               " ON CO.CourseNumber=C.number WHERE sessionCode=@sessionCode";
            var cmd = new SqlCommand(cmdString, conn);

            //cmd.Parameters.AddWithValue("@sessionCode", "%"+s.Code);
            cmd.Parameters.AddWithValue("@sessionCode", s.Code);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                co.Add(new CourseOffering()
                {
                    SessionCode = rd.GetString(rd.GetOrdinal("SessionCode")),
                    CourseNumber = rd.GetString(rd.GetOrdinal("CourseNumber")),
                    CourseName = rd.GetString(rd.GetOrdinal("Name"))
                });
            rd.Close();


            return co;
        }

        //method to get Course detal for a selected course--2nd List to dw 
        public Course GetSelectedCourseOffering(CourseOffering c)
        {

            var cc = new Course();
            var cmdString = "SELECT Number, Hours, Credits, Name FROM Course" +
                               "  WHERE Number=@number";
            var cmd = new SqlCommand(cmdString, conn);

            //cmd.Parameters.AddWithValue("@sessionCode", "%"+s.Code);
            cmd.Parameters.AddWithValue("@number", c.CourseNumber);

            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                cc=new Course()
                {
                    Number = rd.GetString(rd.GetOrdinal("Number")),
                    Hours = rd.GetInt32(rd.GetOrdinal("Hours")),
                    Credits =rd.GetInt32(rd.GetOrdinal("Credits")),
                    Name = rd.GetString(rd.GetOrdinal("Name")),
                };
            rd.Close();


            return cc;
            
        }

        //Method to get all the sessions --ComboBox
        public List<Course> GetCourse()
        {
            var C = new List<Course>();
            var cmdString = "SELECT Number, Hours, Credits, Name FROM Course";
            var cmd = new SqlCommand(cmdString, conn);
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
                C.Add(new Course()
                {
                    Number = rd.GetString(rd.GetOrdinal("Number")),
                    Hours = rd.GetInt32(rd.GetOrdinal("Hours")),
                    Credits = rd.GetInt32(rd.GetOrdinal("Credits")),
                    Name = rd.GetString(rd.GetOrdinal("Name"))

                });
            rd.Close();
            
            return C;
        }
        //CO.SessionCode, CO.CourseNumber, C.Name
        public void SaveNewCourseSession(Session S, Course C)
        {
            var cmdString = "INSERT INTO CourseOffering (SessionCode,CourseNumber,sectionNumber, employeeNumber,capacity,enrollment)" +
                               " VALUES (@SessionCode,@CourseNumber,1,3514239,40,14)";
            var cmd = new SqlCommand(cmdString, conn);

            //cmd.Parameters.AddWithValue("@sessionCode", "%"+s.Code);
            cmd.Parameters.AddWithValue("@SessionCode", S.Code);
            cmd.Parameters.AddWithValue("@CourseNumber", C.Number);
            
            cmd.ExecuteNonQuery();
            
        }
    }
}
