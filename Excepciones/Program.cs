using System;
using System.IO;
namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*
                string content = File.ReadAllText(@"C:\blender-2.93.4-windows-x64\copyright.txt");
                Console.WriteLine(content);
                */

                string content2 = File.ReadAllText(@"C:\blender-2.93.4-windows-x64\copyright2.txt");
                Console.WriteLine(content2);
                throw new Exception("paso algo");

            }
            catch (FileNotFoundException EX)
            {
                Console.WriteLine(EX.Message);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("se ejecuta de igual manera");
            }
        }
    }
}
