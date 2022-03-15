using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora2
{
    internal class Program
    {

        enum menu { somar = 1,subtrair,dividir,multiplicar,Sair}
        
        static void Main(string[] args)
        {
            Console.WriteLine("****Bem Vindo a Calculadora da Lua Seleciona uma opção****");
            bool escolher = false;
            do{
                Console.WriteLine("1-Somar\n2-Subtrair\n3-Dividir\n4-Multiplicar\n5-Sair");
                menu opcao = (menu)int.Parse(Console.ReadLine());
               

               
                switch (opcao)
                {
                    case menu.somar:
                        Somar();
                        break;
                    case menu.subtrair:
                        Subtrair();
                        break;

                    case menu.dividir:
                        Dividir();
                        break;
                    case menu.multiplicar:
                        Multiplicar();
                        break;

                    case menu.Sair:
                        escolher = true;
                        break;


                }


                        Console.Clear();



             } while (!escolher) ;

             
            
        }
               

        static void Somar()
        {
            Console.WriteLine("Soma Dos Valores");
            Console.WriteLine("Entre com o Primeiro Valor:");
            int n1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Entre com o Segundo Valor:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 + n2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadLine();
        }

        static void Subtrair()
        {
            Console.WriteLine("Subtração Dos Valores");
            Console.WriteLine("Entre com o Primeiro Valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Segundo Valor:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 - n2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadLine();

        }
        static void Dividir()
        {
            Console.WriteLine("Subtração Dos Valores");
            Console.WriteLine("Entre com o Primeiro Valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Segundo Valor:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 / n2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadLine();
        }

        static void Multiplicar()
        {
            Console.WriteLine("Subtração Dos Valores");
            Console.WriteLine("Entre com o Primeiro Valor:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Segundo Valor:");
            int n2 = int.Parse(Console.ReadLine());
            int resultado = n1 * n2;
            Console.WriteLine("Resultado:" + resultado);
            Console.ReadLine();
        }

        
    }
}
