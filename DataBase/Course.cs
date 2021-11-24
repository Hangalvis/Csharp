using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int id_teacher { get; set; }

        public Course(int id,string name,int id_teacher)
        {
            this.id = id;
            this.name = name;
            this.id_teacher = id_teacher;
        }

        public Course(string name, int id_teacher)
        {
         
            this.name = name;
            this.id_teacher = id_teacher;
        }
    }
}
