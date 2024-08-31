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
            E30();
        }

        private void Execute1_10()
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
                Console.WriteLine("8. Leer 3 notas, determinar su promedio TLS y escribir si aprobó o no");
                Console.WriteLine("9. Leer 4 notas, 3 de promedio de clase y 1 de jurado, determinar su promedio TLS y escribir si aprobó o no");
                Console.WriteLine("10. Desarrollar una calculadora simple: leer 2 números, luego leer el símbolo de la operación a realizar (suma, resta, multiplicación, división y módulo) y ejecutar la operación.");
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
                    case "8":
                        E8();
                        break;
                    case "9":
                        E9();
                        break;
                    case "10":
                        E10();
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
                    if (year % 400 == 0)
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
            a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

        }

        private void E8()
        {
            float grade1;
            float grade2;
            float grade3;
            float average;
            Console.WriteLine("Introduce la primera nota");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            grade3 = float.Parse(Console.ReadLine());
            average = (grade1 + grade2 + 2 * grade3) / 4;
            Console.WriteLine($"El promedio es: {average}");
            if (average >= 12.5f)
            {
                Console.WriteLine("Aprobó");
            }
            else
            {
                Console.WriteLine("Desaprobó");
            }

        }

        private void E9()
        {
            float grade1;
            float grade2;
            float grade3;
            float grade4;
            float average;
            float finalAverage;
            Console.WriteLine("Introduce la primera nota");
            grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la segunda nota");
            grade2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la tercera nota");
            grade3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la nota de jurado");
            grade4 = float.Parse(Console.ReadLine());

            average = (grade1 + grade2 + 2 * grade3) / 4;
            finalAverage = (2 * average + grade4) / 3;
            Console.WriteLine($"El promedio final es: {finalAverage}");
            if (average >= 12.5f)
            {
                Console.WriteLine("Aprobó");
            }
            else
            {
                Console.WriteLine("Desaprobó");
            }
        }

        private void E10()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                float a;
                float b;
                Console.WriteLine("Introduce el primer número");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el segundo número");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("Introduce el símbolo de la operación");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        Console.WriteLine($"{a} / {b} = {a / b}");
                        break;
                    case "%":
                        Console.WriteLine($"{a} % {b} = {a % b}");
                        break;
                }

                Console.WriteLine("Introducir otro cálculo? (s/n)");
                string answer = Console.ReadLine();
                if (answer == "n")
                {
                    continueFlag = false;
                }

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

        private void E11()
        {
            int n;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        private void E12()
        {
            int n;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        private void E13()
        {
            int n;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private void E13A()
        {
            int n;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private void E14()
        {
            int n;
            int result = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

        private void E15()
        {
            int n;
            int result = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 1)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);
        }

        private void E15A()
        {
            int n;
            int result = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                result += i;
            }
            Console.WriteLine(result);
        }

        private void E16()
        {
            int n;
            int result = 1;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }

        private void E17()
        {
            int n;
            int count = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
        }

        private void E18()
        {
            int n;
            int count = 0;
            int result = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                count = 0;
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;
                    }
                }

                if (count == 2)
                {
                    result += j;
                }
            }
            Console.WriteLine(result);

        }

        private void E19()
        {
            int a;
            int b;
            int c;
            int n;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());
            a = 0;
            b = 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                c = a + b;
                a = b;
                b = c;
            }
        }

        private void E20()
        {
            int n;
            int count = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());

            int temp = n;
            while (temp > 0)
            {
                temp = (temp - temp % 10) / 10;
                count++;
            }
            Console.WriteLine(count);

        }

        private void E21()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0)
                {
                    Console.WriteLine(values[i]);
                }
            }
        }

        private void E22()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int result = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > 0)
                {
                    result += values[i];
                }
            }

            Console.WriteLine(result);
        }

        private void E23()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int count = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private void E24()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int count = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        private void E25()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int result = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 != 0)
                {
                    result += values[i];
                }
            }

            Console.WriteLine(result);
        }

        private void E26()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int result = 0;
            int max;
            int min;

            max = -99999999;
            min = 99999999;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > max)
                {
                    max = values[i];
                }
                if (values[i] < min)
                {
                    min = values[i];
                }
            }
            result = max + min;
            Console.WriteLine(result);
        }

        private void E27()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int index;

            Console.WriteLine("Introduce el índice");
            index = int.Parse(Console.ReadLine());

            int[] temp = new int[values.Length - 1];

            for (int i = 0; i < values.Length; i++)
            {
                if (i < index)
                {
                    temp[i] = values[i];
                }
                else if (i > index)
                {
                    temp[i - 1] = values[i];
                }
            }
            Console.WriteLine("Arreglo original");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
            values = temp;
            Console.WriteLine("Nuevo arreglo");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }

        }


        private void E28()
        {
            int[] values = { 10, -10, 20, -20, 20, -20, 20, 20, -10 };
            int n;
            int count = 0;

            Console.WriteLine("Introduce un número");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == n)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
        private void E29()
        {
            int[] values = { 10, -10, 20, -20, 20, -20, 20, 20, -10 };
            int[] temp = new int[values.Length];


            for (int i = 0; i < values.Length; i++)
            {
                temp[values.Length - 1 - i] = values[i];
            }

            Console.WriteLine("Arreglo original");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
            values = temp;
            Console.WriteLine("Nuevo arreglo");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write(values[i] + " ");
            }
        }
        private void E30()
        {
            int[] values = { 10, -10, 20, -20, 12, 59, -98, -12, 15 };
            int[] evenValues;
            int[] oddValues;
            int evenCount = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            evenValues = new int[evenCount];
            oddValues = new int[values.Length - evenCount];
            int index = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 == 0)
                {
                    evenValues[index] = values[i];
                    index++;
                }
            }
            index = 0;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] % 2 != 0)
                {
                    oddValues[index] = values[i];
                    index++;
                }
            }

            Console.WriteLine("Arreglo pares");
            for (int i = 0; i < evenValues.Length; i++)
            {
                Console.Write(evenValues[i] + " ");
            }
            Console.WriteLine("\nArreglo impares");
            for (int i = 0; i < oddValues.Length; i++)
            {
                Console.Write(oddValues[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
