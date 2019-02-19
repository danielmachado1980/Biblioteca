using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            bool sair = false;
            
            while (!sair)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ BIBLIOTECA SENAC ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("");

                Console.WriteLine("             ╔═════════════════ MENU DE OPÇÕES ══════════════╗    ");

                Console.WriteLine("             ║ 1 CADASTRO DE ALUNOS                          ║    ");

                Console.WriteLine("             ║                                               ║    ");

                Console.WriteLine("             ║ 2 CADASTRO DE LIVROS                          ║    ");

                Console.WriteLine("             ║                                               ║    ");

                Console.WriteLine("             ║ 3 SAIR                                        ║    ");

                Console.WriteLine("             ╚═══════════════════════════════════════════════╝    ");

                Console.WriteLine(" ");


                Console.Write("DIGITE UMA OPÇÃO : ");


                //============================CADASTRO DE ALUNOS===========================
                opcao = Console.ReadLine();

                switch (int.Parse(opcao))
                {
                    case 1:
                        cadastraAluno();
                        break;
                    default:
                        sair = true;
                        break;
                }
            }
            Console.ReadKey();
         }

        static void cadastraAluno() {
            string nome, endereco, telefone, email, continua;

            do
            {
                Console.Clear(); //=======COR===============================================================
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒ CADASTRO DE ALUNOS ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("■ Entre com o nome do Aluno: ");
                nome = Console.ReadLine();

                Console.Write("■ Entre com o endereço do Aluno: ");
                endereco = Console.ReadLine();

                Console.Write("■ Entre com o telefone do Aluno: ");
                telefone = Console.ReadLine();

                Console.Write("■ Entre com o email do Aluno: ");
                email = Console.ReadLine();

                Console.WriteLine("");
                Console.WriteLine("O CADASTRO DO ALUNO " + "'" + nome + "'" + " FOI REALIZADO COM SUCESSO!");
                Console.WriteLine("");
                Console.WriteLine("╔════════════════════════════╗");
                Console.WriteLine("║'S' = CADASTRAR MAIS ALUNOS ║");
                Console.WriteLine("║'M' = VOLTAR AO MENU        ║");
                Console.WriteLine("╚════════════════════════════╝");
                continua = Console.ReadLine().ToUpper();
                Console.WriteLine();
            } while (continua == "S");
        }
    }
}
