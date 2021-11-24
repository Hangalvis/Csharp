using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            //Db db = new Db(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HanDev\Documents\Cursos\c#\DataBase\Data.mdf;Integrated Security=True;Connect Timeout=30");
            CourseDb db = new CourseDb(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HanDev\Documents\Cursos\c#\DataBase\Data.mdf;Integrated Security=True;Connect Timeout=30");

            bool estado = true;
            int op;
                do
                {
                    Console.WriteLine("--------------Bienvenido --------------");
                    Showmenu();
                    Console.WriteLine("Elija una de las opciones:");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            show(db);
                            break;
                        case 2:
                            add(db);
                            break;
                        case 3:
                            Edit(db);
                            break;
                        case 4:
                            delete(db);
                            break;
                        case 5:
                            estado = false;
                            break;
                        default:
                            Console.WriteLine("Eligio una opcion no valida");
                            break;

                    }
                } while (estado);
                
                
            
            }catch(SqlException es)
            {
                Console.WriteLine(es.Message);
                Console.WriteLine("tu cadena fallo");
            }
        }

        public static void Showmenu()
        {
            Console.WriteLine("-------------menu-------------");
            Console.WriteLine("1.Mostrar");
            Console.WriteLine("2.Agregar");
            Console.WriteLine("3.Editar");
            Console.WriteLine("4.Eliminar");
            Console.WriteLine("5.Salir");
        }
        public static void show(CourseDb coursedb)
        {
            Console.Clear();
            Console.WriteLine("-------Mostrando datos------");
            List<Course> course = coursedb.getall();
            foreach (var c in course)
            {
                Console.WriteLine($"{c.id} - {c.name}");
            }
        }

        public static void add(CourseDb coursedb)
        {
            Console.Clear();
            Console.WriteLine("-------Agregar datos------");
            Console.WriteLine("ingresa el Nombre de la Materia");
            string name = Console.ReadLine();
            Console.WriteLine("Ingresa el id del Profesor");
            int idteacher = int.Parse(Console.ReadLine());
            Course course = new Course(name, idteacher);
            coursedb.add(course);
            
        }

        public static void Edit(CourseDb coursedb)
        {
            Console.Clear();
            show(coursedb);
            Console.WriteLine("Editar Materia");
            Console.WriteLine("Escribe el id  de la materia ");
            int id = int.Parse(Console.ReadLine());
            Course course = coursedb.get(id);
            if(course != null)
            {
                Console.WriteLine("Escribe el nombre");
                string name = Console.ReadLine();

                course.name = name;
                coursedb.edit(course);
            }
            else
            {
                Console.WriteLine("La materia no existe");
            }

        }


        public static void delete(CourseDb coursedb)
        {
            Console.Clear();
            show(coursedb);
            Console.WriteLine("Eliminar Materia");
            Console.WriteLine("Escribe el id  de la materia ");
            int id = int.Parse(Console.ReadLine());
            Course course = coursedb.get(id);
            if (course != null)
            {
                coursedb.delete(id);
            }
            else
            {
                Console.WriteLine("La materia no existe");
            }

        }


    }
}
