using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio_04();
        }

        static void Exercicio_01()
        {
            string nome;
            string endereco;
            string cep;
            string telefone;

            Console.WriteLine("Digite seu nome completo: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite seu CEP: ");
            cep = Console.ReadLine();

            Console.WriteLine("Digite seu endereço: ");
            endereco = Console.ReadLine();

            Console.WriteLine("Digite seu telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine("---------CADASTRO DE USUÁRIO---------");
            Console.WriteLine($"Nome: {nome}\nCEP: {cep}\nEndereço: {endereco}\nTelefone: {telefone}");

        }

        static void Exercicio_02()
        {
            string nome = "Carol Shaw";
            string formacao = "Engenharia da computação";
            string contribuicao = "É considerada a primeira mulher que começou a trabalhar com o desenvolvimento de jogos digitais. Shaw criou softwares para games e consoles, sendo pioneira na geração procedural de conteúdo, que nada mais é que o aumento gradual da dificuldade nos níveis do jogo.";

            Console.WriteLine($"Nome: {nome}\nFormação: {formacao}\nContribuição: {contribuicao}");

        }

        static void Exercicio_03()
        {
            string letra;
            string compositor;
            string generoMusical;

            letra = "Pra você eu me desmonto\nEu quero que minha voz cante no teu ouvido\nVocê me lembra que não há nenhum perigo\nNo quarto escuro pra dormir\nE agora eu durmo bem\nDo amor, já disse tanto\nMeu coração já passeou em tanta casa\nAgora eu vejo que eu nem sabia nada\nAmar é mais do que dizer do amor\nA gente se escolhe todo dia\nE eu te escolheria mais milhões de vidas\nPorque uma só é pouco com você, amor\nE eu quero tudo que eu puder viver, amor\nA gente se escolhe todo dia\nE eu te escolheria mais milhões de vidas\nPorque uma só é pouco com você, amor\nE eu quero tudo que eu puder viver com você";
            compositor = "AnaVitoria";
            generoMusical = "MPB";

            Console.WriteLine($"{letra}\nCompositor: {compositor}\n{generoMusical}");





        }
    
        static void Exercicio_04()
        {
            string mensagem;

            mensagem = "Todas as mulheres podem usar o poder de mudança presente na Tecnologia e se tonar um agente transformador de sua própria realidade e, por que não, do mundo.";
      
            Console.WriteLine(mensagem);
        }
        
    }
}
