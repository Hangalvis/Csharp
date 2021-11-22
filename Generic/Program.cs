using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> number = new MyList<int>(10);
            number.add(1);
            number.add(4);

            MyList<string> strings = new MyList<string>(10);
            strings.add("hola");

            MyList<People> people = new MyList<People>(5);
            people.add(new People() { Name = "Jisel", Country = "Colombia" });
            people.add(new People() { Name = "alex", Country = "usa" });

            Console.WriteLine(number.getstring());
            Console.WriteLine(strings.getstring());
            Console.WriteLine(people.getstring());

            Console.WriteLine(number.GetElement(11));
            Console.WriteLine(strings.GetElement(0));
            
        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            // return base.ToString();
            return $"Nombre: {Name} , Pais: {Country} ";
        }
    }

    public class MyList<T>
    {
        private T[] _element;
        private int _index = 0;

        public MyList(int n)
        {
            _element = new T[n];
        }

        public void add(T e)
        {
            if(_index < _element.Length)
            {
                _element[_index] = e;
                _index++;
            }
        }

        public T GetElement(int i)
        {
            if(i<=_index && i >= 0)
            {
                return _element[i];
            }

            return default(T);
        }

        public string getstring()
        {
            int i = 0;
            string result = "";
            while (i < _index)
            {
                result += _element[i].ToString() + ",";
                i++;
            }
            return result;
        }
    }
}
