using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoSemana1.Week2
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetData()
        {
            return $"Name: {name} - Age: {age}";
        }

        public void IncreaseAge()
        {
            age++;
        }

        public void ChangeName(string name)
        {
            this.name = name;
        }
    }
}
