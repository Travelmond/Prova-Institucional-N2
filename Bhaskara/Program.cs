using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            double delta;

            /*Aqui é colocado o modelo de input para o usuário utilizar, com o uso do CMD com cores.*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Para calcular a equação do segundo grau, digite o valor de:");
            Console.ResetColor();

            Console.Write("a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            c = Convert.ToDouble(Console.ReadLine());

            /*Fórmula de Bhaskara que será usada no código*/
            delta = (b * b) - (4 * a * c);


            /*Caso o calculo retorne que "a" tem valor zero, não pertence a equação de segundo grau*/
            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é uma equação de segundo grau.");
            }

            /*Caso o calculo retorne que delta é negativo, não possuindo raízes reais*/
            if (delta < 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Como delta = {delta}, a equação não possui raízes reais.");
            }

            /*Caso contrário, esta linha de código será compilada*/
            else if (a >= 1 && delta >= 1)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"x1 = {x1} e x2 = {x2}");
            }

            Console.ResetColor();
            Console.WriteLine("\n Fim do Programa \n");
        }
    }
}
