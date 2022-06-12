using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio_01();
        }

        static void Exercicio_01()
        {
            float valor;
            Console.WriteLine("Digite o valor");
            valor = float.Parse(Console.ReadLine());




        }

        static void Exercicio_02()
        {
            int[] numeros = new int[3];
            int maiorNumero = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Digite o número {i + 1}");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] > maiorNumero)
                {
                    maiorNumero = numeros[i];
                }
            }

            Console.WriteLine($"{maiorNumero} é o maior número.");


        }

        static void Exercicio_03()
        {
            int[] notas = new int[3];
            int media = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a {i + 1}'a nota");
                notas[i] = int.Parse(Console.ReadLine());
                media += notas[i];
            }

            media = media / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }


        }

        static void Exercicio_04()
        {
            float[] notas = new float[3];
            float media = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a {i + 1}'a nota");
                notas[i] = float.Parse(Console.ReadLine());
                media += notas[i];
            }

            media = media / 3;

            if (media < 6)
            {
                Console.WriteLine("Nota F");
            }
            else if (media < 7)
            {
                Console.WriteLine("Nota D");
            }
            else if (media < 8)
            {
                Console.WriteLine("Nota C");
            }
            else if (media < 9)
            {
                Console.WriteLine("Nota B");
            }
            else if (media <= 10)
            {
                Console.WriteLine("Nota A");
            }

        }

        static void Exercicio_05()
        {
   
            float salario;
            float aumentoPercentual = 0;
            float valorDeAumento;
            float novoSalario;

            Console.WriteLine("Digite o salário");
            salario = float.Parse(Console.ReadLine());

            if (salario < 400.01)
            {
                aumentoPercentual = 15;
            }

            else if (salario < 800.01)
            {
                aumentoPercentual = 12;
            }

            else if (salario < 1200.01)
            {
                aumentoPercentual = 10;
            }

            else if (salario < 2000.01)
            {
                aumentoPercentual = 7;
            }
            else if (salario >= 2000.01)
            {
                aumentoPercentual = 4;
            }

            novoSalario = ((aumentoPercentual + 100) * salario) / 100;
            valorDeAumento = novoSalario - salario;
            Console.WriteLine($"Seu novo salário é de {novoSalario}. Sofreu um ajuste de {aumentoPercentual}%, que significa um aumento de {valorDeAumento} Reais");

        }


    }
}
