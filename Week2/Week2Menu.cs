using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoSemana1.Week2
{
    internal class Week2Menu
    {
        private List<Person> people;

        public Week2Menu()
        {
            people = new List<Person>();
        }

        public void Execute()
        {
            bool continueFlag=true;
            while(continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Agregar persona");
                Console.WriteLine("2. Mostrar personas");   
                Console.WriteLine("0. Salir");
                string option=Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddPerson();
                        break;
                    case "2":
                        ShowAllPeople();
                        break;
                    case "0":
                        continueFlag=false;
                        break;
                }
            }
        }

        private void AddPerson()
        {
            string name;
            int age;

            Console.WriteLine("Introduce el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la edad:");
            age = int.Parse(Console.ReadLine());
            
            people.Add(new Person(name, age));
        }

        private void ShowAllPeople()
        {
            foreach(Person p in people)
            {
                Console.WriteLine(p.GetData());
            }
        }


        private void Example1()
        {

            string name;
            int age;

            Console.WriteLine("Introduce el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la edad:");
            age = int.Parse(Console.ReadLine());
            Person p = new Person(name, age);

            Console.WriteLine("Introduce el nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Introduce la edad:");
            age = int.Parse(Console.ReadLine());
            Person p1 = new Person(name, age);

            Console.WriteLine("Datos de las personas:");
            Console.WriteLine(p.GetData());
            Console.WriteLine(p1.GetData());

            Console.WriteLine("Ejemplo de ejecución de método");
            p.IncreaseAge();
            Console.WriteLine(p.GetData());
            Console.WriteLine(p1.GetData());

            int test;
            int test1;

            test = 10;
            test1 = test;


            Console.WriteLine("Ejemplo de asignación");
            p1 = p;
            Console.WriteLine(p.GetData());
            Console.WriteLine(p1.GetData());
            Console.WriteLine($"test: {test}");
            Console.WriteLine($"test1: {test1}");


            Console.WriteLine("Ejemplo de ejecución de método");
            p.IncreaseAge();
            test++;
            Console.WriteLine(p.GetData());
            Console.WriteLine(p1.GetData());
            Console.WriteLine($"test: {test}");
            Console.WriteLine($"test1: {test1}");

            Console.WriteLine("Ejemplo de cambio de nombre");
            p.ChangeName("Betty");
            test = 100000;
            Console.WriteLine(p.GetData());
            Console.WriteLine(p1.GetData());
            Console.WriteLine($"test: {test}");
            Console.WriteLine($"test1: {test1}");

        }
    }
}
