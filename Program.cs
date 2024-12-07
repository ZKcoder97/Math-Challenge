using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualSomaDosValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vatiaveis
            bool appFuncionando = true;
            //Inicio
            while (appFuncionando)
            {
                Console.WriteLine("Qual A Soma Dos Valores!");
                Console.Write("Qual Opção Deseja: [I] Iniciar || [S] Sair: ");
                var opcao = Console.ReadKey().Key;

                switch (opcao)
                {
                    case ConsoleKey.I:
                        Console.Clear();
                        OsValores();
                        break;
                    case ConsoleKey.S:
                        Console.WriteLine("\nEncerrando App!");
                        appFuncionando = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
            //Fim
        }
        //Inicio Da Função
        static void OsValores()
        {
            bool funcionamentoApp = true;
            while (funcionamentoApp)
            {
                try
                {
                    string opercaoStr = null; var resultado = 0;
                    Console.WriteLine("Qual É O Resultado: ");
                    Random random = new Random();
                    var valor1 = random.Next(1, 1000);
                    var valor2 = random.Next(1, 1000);
                    var operacao = random.Next(1, 5);

                    switch (operacao)
                    {
                        case 1:
                            resultado = valor1 + valor2;
                            opercaoStr = "+";
                            break;
                        case 2:
                            resultado = valor1 - valor2;
                            opercaoStr = "-";
                            break;
                        case 3:
                            resultado = valor1 * valor2;
                            opercaoStr = "*";
                            break;
                        case 4:
                            resultado = valor1 / valor2;
                            opercaoStr = "/";
                            break;
                    }
                vSoma:
                    Console.WriteLine($"{valor1} {opercaoStr} {valor2} = ");
                    var resul = float.Parse(Console.ReadLine());
                    if (resul == resultado) { Console.WriteLine("\nResultado Correto"); }
                    else { Console.Clear(); goto vSoma; }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Valor Inválido!"); 
                }
            }
            
            
        }
        //Fim Da Função

    }
}
