using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class CourseDb:Db
    {
        public CourseDb(string server, string db, string user, string password):base(server,db,user,password)
        {
           
           
        }

        public CourseDb(string dblocal):base(dblocal)
        {
            
        }

        public List<Course> getall()
        {
            open();
            List<Course> course = new List<Course>();
            string query = "select id,name,id_teacher from Course";
            SqlCommand command = new SqlCommand(query, _conexion);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                int id_teacher = reader.GetInt32(2);
                course.Add(new Course(id, name, id_teacher));
            }
            close();
            return course;

        }

        public Course get(int id)
        {
            open();
            Course course = null;
            string query = "select id,name,id_teacher from Course where id=@id";
            SqlCommand command = new SqlCommand(query, _conexion);
            command.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(1);
                int idteacher = reader.GetInt32(2);
                course = new Course(id, name, idteacher);
            }
            close();
            return course;
        }

        public void edit(Course course)
        {
            open();
            string query = "update Course set name=@name where id=@id";
            SqlCommand command = new SqlCommand(query, _conexion);
            command.Parameters.AddWithValue("@name",course.name);
            command.Parameters.AddWithValue("@id",course.id);
            command.ExecuteNonQuery();
            close();
        }

        public void add(Course course)
        {
            open();
            string query = "INSERT INTO [dbo].[Course] ([name], [id_teacher]) VALUES (@nam, @idteacher)";
            SqlCommand command = new SqlCommand(query, _conexion);
            command.Parameters.AddWithValue("@nam", course.name);
            command.Parameters.AddWithValue("@idteacher", course.id_teacher);
            command.ExecuteNonQuery();
            close();
        }

        public void delete(int id)
        {
            open();
            string query = "Delete from Course where id=@id ";
            SqlCommand command = new SqlCommand(query, _conexion);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            close();
        }
    }
}
