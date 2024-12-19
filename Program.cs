using System;
namespace Exerc_cioCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um operador pelo número correspondente:");
            Console.WriteLine("1.Adição 2.Subtração 3.Mulplicação 4.Divisão");
            int res = int.Parse(Console.ReadLine());
            float[] num = {0f};
            float resul = 0f;

            if (res == 1)
            {
                Console.WriteLine("Digite os valores para a soma:");
                num = Array.ConvertAll(Console.ReadLine().Split(' ','+'), float.Parse);
                float soma = 0f;
                for (int i = 0; i < num.Length; i++)
                {
                    soma += num[i];
                    resul = soma;
                }
                Console.WriteLine($"O resultado da soma é: {resul}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.Read();
            }
            else if (res == 2)
            {
                Console.WriteLine("Digite os valores para a subtração:");
                num = Array.ConvertAll(Console.ReadLine().Split(' ','-'),float.Parse);
                float sub = 0f;
                sub = num[0];
                for (int i = 1; i < num.Length; i++)
                {
                    sub -= num[i];
                    resul = sub;
                }
                Console.WriteLine($"O resultado da subtração é: {resul}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.Read();
            }
            else if (res == 3)
            {
                Console.WriteLine("Digite os valores para a multiplicação:");
                num = Array.ConvertAll(Console.ReadLine().Split(' ', '*', 'x'),float.Parse);
                float mul = 1f;
                for (int i = 0; i < num.Length; i++)
                {
                    mul *= num[i];
                    resul = mul;
                }
                Console.WriteLine($"O resultado da multiplicação é: {resul}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.Read();
            }
            else if (res == 4)
            {
                Console.WriteLine("Digite os valores para a divisão:");
                num = Array.ConvertAll(Console.ReadLine().Split(' ', '/'),float.Parse);
                float div = 0f;
                div = num[0];
                for (int i = 1; i < num.Length; i++)
                {
                    if (num[i] == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0.");
                        return;
                    }

                    div /= num[i];
                    resul = div;
                }
                Console.WriteLine($"O resultado da divisão é: {resul}");
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Valor inválido!");
                return;
            }
        }
    }
}