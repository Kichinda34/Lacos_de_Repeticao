using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lacos_de_Repeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço/Loop For
            for (int i = 0/*Iniciacização da Váriavel*/; i < 10/*Condição*/; i++/*Alteração da Váriavel*/)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------------------");

            //Laço/Loop While
            int j = 0;
            while (j < 50 /*Condição*/) 
            {
                Console.WriteLine("O valor de J é: " + j);
                j += 10;
            }
            Console.WriteLine("-----------------------------");

            //Laço/Loop Do... While
            int k = 0;
            do
            {
                Console.WriteLine("O valor de K atualmente é: " +k);
                k += 100;
            } while (k < 1000/*Condição*/);
            Console.WriteLine("-----------------------------");

            //Laço/Loop Foreach
            string[] nomes = { "Guilherme", "João", "Pedro", "Vitoria", "Reyna", "Ana" };
            foreach ( string nome in nomes /*Condição de Funcionamento do Array*/)  //Teoricamente o foreach usa a condição "Para cada string "nome" no Array "nomes" Execute o código." 
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-----------------------------");

            //Break e continue
            while (true)
            {
                Console.WriteLine("Pressione C para continue");
                Console.WriteLine("Pressione B para break");
                string tecla = Console.ReadKey().KeyChar.ToString();
                if (tecla == "c")
                {
                    continue; //Reinicia o Loop a partir do ponto em que este comando é executado, e começa uma nova execução. 
                }
                else if (tecla == "b")
                {
                    break; //Encerra o Loop, e executa oque estiver após ele
                }
                else
                {
                    Console.WriteLine("Tecla desconhecida!!");
                }
                Console.WriteLine("Pressione Qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("Pressione Qualquer tecla para sair");
            Console.ReadKey();
        }
    }
}
