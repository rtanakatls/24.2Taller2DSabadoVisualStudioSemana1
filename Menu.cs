using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._2Taller2DSabadoSemana1
{
    internal class Menu
    {
        public void Execute()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce la opción");
                Console.WriteLine("1. Leer 2 número y operar suma, resta, multiplicación");
                Console.WriteLine("2. Leer 2 números y operar división y módulo");
                Console.WriteLine("3. Leer una cantidad de días, convertirlo a años y semanas");
                Console.WriteLine("4. Leer un año y mostrar si es bisiesto o no");
                Console.WriteLine("5. Leer un número y mostrar si es negativo, positivo o cero");
                Console.WriteLine("6. Leer un número y mostrar si es divisible entre 7 y/o 13");
                Console.WriteLine("7. Leer un número y mostrar si es par o impar");
                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();
                Console.WriteLine();
                switch (option)
                {
                    case "1":
                        E1();
                        break;
                    case "2":
                        E2();
                        break;
                    case "3":
                        E3();
                        break;
                    case "4":
                        E4();
                        break;
                    case "5":
                        E5();
                        break;
                    case "6":
                        E6();
                        break;
                    case "7":
                        E7();
                        break;
                    case "0":
                        continueFlag = false;
                        break;
                }
                Console.WriteLine();
            }
        }

        private void E1()
        {
            int a;
            int b;
            Console.WriteLine("Introduce el primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"La suma de {a} y {b} es {a + b}");
            Console.WriteLine($"La resta de {a} y {b} es {a - b}");
            Console.WriteLine($"La multiplicación de {a} y {b} es {a * b}");
        }

        private void E2()
        {
            float a;
            float b;
            Console.WriteLine("Introduce el primer número");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine($"La división de {a} y {b} es {a / b}");
            Console.WriteLine($"El módulo de {a} y {b} es {a % b}");
        }

        private void E3()
        {
            float days;
            Console.WriteLine("Introduce la cantidad de días");
            days = float.Parse(Console.ReadLine());
            Console.WriteLine($"{days} días en años es {days / 365}");
            Console.WriteLine($"{days} días en semanas es {days / 7}");
        }

        private void E4()
        {
            int year;
            Console.WriteLine("Introduce el año");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("Es bisiesto");
                    }
                    else
                    {
                        Console.WriteLine("No es bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Es bisiesto");
                }
            }
            else
            {
                Console.WriteLine("No es bisiesto");
            }
        }

        private void E5()
        {
            int a;
            Console.WriteLine("Introduce un número");
            a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("Es negativo");
            }
            else if (a > 0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("Es cero");
            }

        }

        private void E6()
        {
            int a;
            Console.WriteLine("Introduce un número");
            a = int.Parse(Console.ReadLine());
            if (a % 7 == 0 && a % 13 == 0)
            {
                Console.WriteLine("Es divisible entre 7 y 13");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("Es divisible entre 7");
            }
            else if (a % 13 == 0)
            {
                Console.WriteLine("Es divisible entre 13");
            }
            else
            {
                Console.WriteLine("No es divisible entre 7 ni 13");
            }
        }

        private void E7()
        {
            int a;
            Console.WriteLine("Introduce un número");   
            a= int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

        }

        private void EnterName()
        {
            string name;
            Console.WriteLine("Introduce tu nombre");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
        }

        private void EnterAge()
        {
            int age;
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("Introduce tu edad");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tienes {age} años");
                if (age < 0)
                {
                    Console.WriteLine("No puedes tener edad negativa");
                }
                else if (age < 18)
                {
                    continueFlag = false;
                    Console.WriteLine("Eres menor de edad");
                }
                else
                {
                    continueFlag = false;
                    Console.WriteLine("Eres mayor de edad");
                }
            }
        }
    }
}
