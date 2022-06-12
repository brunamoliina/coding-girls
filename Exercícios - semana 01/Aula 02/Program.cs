using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio_05();
        }

        static void Exercicio_01()
        {
            int anoDeNascimento;
            int idade;

            Console.WriteLine("Vou descobrir sua idade...");
            Console.WriteLine("Digite seu ano de nascimento");
            anoDeNascimento = int.Parse(Console.ReadLine());

            idade = (2022 - anoDeNascimento);


            Console.WriteLine($"Sua idade é: {idade} anos");
        }

        static void Exercicio_02()
        {
            int[] numeros = new int[10];
            int soma = 0;
         
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"------ {i + 1} Digite um número: ------");
                numeros[i] = int.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            Console.WriteLine(soma);
        }

        static void Exercicio_03()
        {
           //Não consegui imprimir o número com duas casas decimais obrigatoriamente.


            float horas;
            float valor;
            float salario;

            Console.WriteLine("Digite o número de horas trabalhadas: ");
            horas = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por hora trabalhada: ");
            valor = float.Parse(Console.ReadLine());
           
            salario = (valor) * (horas);

            Console.WriteLine($"Seu salário é: {salario}");


        }

        static void Exercicio_04()
        {
            
            int idade;
            int meses;
            int dias;

            Console.WriteLine("Digite a sua idade: ");
            idade = int.Parse(Console.ReadLine());

            meses = idade * 12;
            dias = idade * 365;

            Console.WriteLine($"Sua idade corresponde a: {idade} anos; {meses} meses; e {dias} dias");
            




        }

        static void Exercicio_05()
        {
            float real;
            float dolar = 4.99f;
            float conversao;

            Console.WriteLine("Digite o valor em real: ");
            real = float.Parse(Console.ReadLine());

            conversao = dolar * real;

            Console.WriteLine ($"O valor em dolar é: US${conversao}");



            

        }

    }   
    
}