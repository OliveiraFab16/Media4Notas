using System;

namespace Media4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, nota3, nota4, mediaFinal;

            Console.Write("Digite seu Nome: ");
            nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"{nome}, digite sua 1ºNota: ");
            nota1 = double.Parse(Console.ReadLine());

            if (nota1 < 0 || nota1 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write($"{nome}, digite sua 2ºNota: ");
            nota2 = double.Parse(Console.ReadLine());

            if (nota2 < 0 || nota2 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write($"{nome}, digite sua 3ºNota: ");
            nota3 = double.Parse(Console.ReadLine());

            if (nota3 < 0 || nota3 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            Console.Write($"{nome}, digite sua 4ºNota: ");
            nota4 = double.Parse(Console.ReadLine());

            if (nota4 < 0 || nota4 > 10)
            {
                Console.WriteLine("Digite somente notas entre 0 e 10");
                Console.WriteLine("Pressione ENTER para sair e execute o programa novamente!");
                Console.ReadKey();
                Environment.Exit(-1);
            }

            mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

            if (mediaFinal < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{nome}, você foi reprovado!");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else if (mediaFinal >= 5 && mediaFinal < 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{nome}, você ficou de recuperação!");
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
                Environment.Exit(-1);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"{nome}, você foi aprovado!");
                
                Console.ResetColor();
                Console.WriteLine("Pressione ENTER para sair!");
                Console.ReadKey();
                Environment.Exit(-1);
            }
        }
    }
}
