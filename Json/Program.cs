using System;
using System.Text.Json;

namespace Json
{
    class Program
    {
        static void Main(string[] args)
        {
            comic c = new comic()
            {
                name = "superman",
                year = "1995"
            };

            //string json = "{\"name\":\"superman\",\"year\":\"1995\"}";
            string json = JsonSerializer.Serialize(c);
            comic comic1 = JsonSerializer.Deserialize<comic>(json);
            comic[] cs = new comic[]
            {
                new comic()
            {
                name = "superman",
                year = "1995"
            },
            new comic()
            {
                name = "batman",
                year = "1955"
            }
        };
        
        }
    }

    public class comic
    {
        public  string name { get; set; }
        public string year { get; set; }
    }
}
