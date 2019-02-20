using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    class Program
    {
        const int _MAXLINHA = 100;
        const int _MAXCOLUNA = 4;
        
        static void Main(string[] args)
        {
            string opcao;
            bool sair = false;
            string[,] alunos = new string[_MAXLINHA, _MAXCOLUNA];
            string[,] livros = new string[_MAXLINHA, _MAXCOLUNA];

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

                Console.WriteLine("             ║ 3 LISTAR ALUNOS                               ║    ");

                Console.WriteLine("             ║                                               ║    ");

                Console.WriteLine("             ║ 4 SAIR                                        ║    ");

                Console.WriteLine("             ╚═══════════════════════════════════════════════╝    ");

                Console.WriteLine(" ");


                Console.Write("DIGITE UMA OPÇÃO : ");


                opcao = Console.ReadLine();

                switch (int.Parse(opcao))
                {
                    case 1:
                        cadastraAluno(alunos);
                        break;
                    case 2:
                        cadastraLivro();
                        break;
                    default:
                        sair = true;
                        break;
                }
            }
            Console.ReadKey();
         }

        private static void cadastraLivro()
        {
            string titulo, autor, editora, edicao, continua;
        }

        static void cadastraAluno(string[,] matriz) {
            string nome, endereco, cpf, email, continua;

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

                Console.Write("■ Entre com o CPF do Aluno: ");
                cpf = Console.ReadLine();

                Console.Write("■ Entre com o email do Aluno: ");
                email = Console.ReadLine();
                
                //matriz[matriz.]
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
