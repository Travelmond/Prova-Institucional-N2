using System;

namespace UnidadeTesteMoq
{
    class Pessoa
    {
        static void Main(string[] args)
        {
            string nome, input;
            int idade;
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade: ");
            input = Console.ReadLine();
            idade = Convert.ToInt32(input);
            Console.WriteLine("Olá " + nome + ", você tem " + idade + " anos");
            Console.ReadLine();
            //Aqui está a parte qeu valida se o número da idade é primo ou não
            //Não esqueça de apertar ENTER depois da mensagem mostrando nome e idade
            if (idade == 0 || idade == 1)
            {
                Console.WriteLine(input + " Não é um número primo!");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= idade / 2; a++)
                {
                    if (idade % a == 0)
                    {
                        Console.WriteLine(input + " Não é um número primo!");
                        return;
                    }

                }
                Console.WriteLine(input + " É um número primo!!!!!!!!!!!!!!!!");
                Console.ReadLine();
            }

        }
    }
}
