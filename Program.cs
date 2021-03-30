using System;
using System.Threading;

namespace Cronometro
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

            char type = 'z';
            int time = 0;

            Console.WriteLine("====>  Menu - Stopwatch  <=====");
            Console.WriteLine("\nS - Segundo => Exemplo: 10s = 10 segundos");
            Console.WriteLine("M - Minuto => Exemplo: 10m = 10m minutos");
            Console.WriteLine("0 - Sair da aplicação");
            Console.WriteLine("\nQuanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();

            try
            {
                type = char.Parse(data.Substring(data.Length - 1, 1));
                time = int.Parse(data.Substring(0, data.Length - 1));
            }
            catch
            {
                Menu();
            }

            Console.WriteLine($"Você digitou {data}");
            Console.WriteLine($"Tipo {type}");
            Console.WriteLine($"Time: {time}");

            switch (type)
            {
                case 's':
                    Start(time);
                    break;
                case 'm':
                    Start(time * 60);
                    break;
                case '0':
                    System.Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }



        }
        static void Start(int time)
        {
            Console.Clear();

            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine($"Já se passaram: {currentTime} segundo(s)");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine($"Stopwatch finalizado! Tempo total: {currentTime} segundo(s)");
            Console.WriteLine($"Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            Menu();
        }

    }

}

