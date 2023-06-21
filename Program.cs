using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefaCombinacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string endereço;
            string bairro;
            string cidade;
            string estado;
            int qnt_via;
            int via_plane;
            float total;
            float falta = 10f;
            float media = 2;
            float meses = 12;


            Console.WriteLine("Olá, bem-vindo ao programa conhecer o mundo!");
            Console.WriteLine("\n");
            Console.WriteLine("Para melhor experiencia, iremos fazer um cadastro!");
            Console.WriteLine("\n");
            Console.WriteLine("Qual o seu nome?:");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o seu sobrenome?:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Olá Sr(a) " + nome + " " + sobrenome + ", vamos continuar seu cadastro...");
            Console.WriteLine("\n");
            Console.WriteLine("Qual o seu endereço?:");
            endereço = Console.ReadLine();
            Console.WriteLine("Qual o seu bairro?:");
            bairro = Console.ReadLine();
            Console.WriteLine("Qual a sua cidade natal?:");
            cidade = Console.ReadLine();
            Console.WriteLine("Qual o estado que você nasceu?:");
            estado = Console.ReadLine();
            Console.WriteLine("O sr(a). " + sobrenome + " mora na cidade de " + cidade + "-" + estado + ", no endereço " + endereço + ", localizado no bairro " + bairro + "");
            Console.WriteLine("\n");
            Console.WriteLine("Quantas viagens você ja fez durante a vida?:");
            qnt_via = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas viagens você planeja fazer esse ano?:");
            via_plane = int.Parse(Console.ReadLine());
            total = qnt_via + via_plane;
            Console.WriteLine("Você ja fez " + total +" durante todo esse tempo!");
        
            falta = total - falta;  
            Console.WriteLine("Falta apenas " + falta + " para você completar 10 viagens ao todo!");
            
            media = qnt_via/media; 
            Console.WriteLine("Você tem uma média de  viagens ao todo!");
            meses = qnt_via * meses;
            Console.WriteLine("Seu intervalo é de   meses a cada viagem");
            Console.WriteLine("\n");
            Console.WriteLine("Obrigado " + nome + " " + sobrenome + " , o seu cadastro foi realizado com sucesso!");



            









        }
    }
}
