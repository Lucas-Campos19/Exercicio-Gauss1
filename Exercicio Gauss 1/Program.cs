using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio_Gauss_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int escolha = 0;
            do
            {
                Console.WriteLine("Escolha o exercicio");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("1 - Média       2- fibonacci");
                Console.Write("Digite apenas o número 1 ou 2 para escolher um dos problemas: ");
                escolha = int.Parse(Console.ReadLine());

            } while (escolha != 1 && escolha != 2);

            if(escolha == 1)
            {
                double nota1, nota2, media;
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Problema calculo de media de um aluno");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.Write("Digite a primeira nota: ");
                nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.Write("Digite a segunda nota: ");
                nota2 = double.Parse(Console.ReadLine());
                media = (nota1 + nota2) / 2;

                if(media > 5)
                {
                    Console.WriteLine("Sua média final foi: " + media.ToString("F2", CultureInfo.InvariantCulture) +"\nParabéns você passou de ano");
                }
                else
                {
                    Console.WriteLine("Sua média final foi: " + media.ToString("F2", CultureInfo.InvariantCulture) + "\ninfelizmente não passou de ano");
                }

            }
            else
            {
                int N, soma = 0;
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.WriteLine("Fibonacci");
                Console.WriteLine("-------------------------------------------------------------------------------------------");
                Console.Write("Deseja ir até que número ? ");
                N = int.Parse(Console.ReadLine());
                for (int sub = 0; soma <= N;)
                {
                    sub = soma - sub;
                    Console.Write(soma + " ");
                    soma = soma + sub;
                    
                    if (soma == 0)
                    {
                        sub++;
                        soma++;

                    }

                }

            }
            Console.ReadKey();
        }
    }
}
