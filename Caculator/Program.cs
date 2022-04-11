using System;

namespace Caculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }


        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que deseja fazer?");

            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("-----------");
            Console.WriteLine("Selecione um numero: ");

            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subitracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }
        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            // Console.WriteLine("O resultado da soma é " + resultado);
            // Console.WriteLine($"O resultado da soma é {v1 + v2}");

            Console.ReadKey();
            Menu();
        }

        static void Subitracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O Resultado da Subtração {resultado}");

            Console.ReadKey();
            Menu();

        }

        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado dessa divisão é: {resultado}");

            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro numero:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo numero:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é : {resultado}");

            Console.ReadKey();
            Menu();
        }
    }
}