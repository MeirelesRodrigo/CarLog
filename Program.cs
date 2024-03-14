using CarLog.Infrastructure.Repository;
using CarLog.Infrastructure.Service;

namespace CarLog;


class Program
{
    static VeiculoServico _veiculoServico = new VeiculoServico();

    static void Main(string[] args)
    {

        while (true)
        {
            Menu();
            Console.ReadKey();
        }
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("-----------------------------");
        Console.WriteLine("           CAR LOG           ");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("  1 - CADASTRO DE VEÍCULOS   ");
        Console.WriteLine("  2 - VEICULOS CADASTRADOS   ");
        Console.WriteLine("  3 - EDITAR VEÍCULOS        ");
        Console.WriteLine("  4 - PESQUISAR VEÍCULO      ");
        Console.WriteLine("  5 - REMOVER VEÍCULO        ");
        Console.WriteLine("  6 - SAIR                   ");
        Console.WriteLine("-----------------------------");
        OpMenu();
    }

    static void OpMenu()
    {
        Console.WriteLine(" ESCOLHA A OPÇÃO DESEJADA");
        var opcaomenu = Console.ReadLine();

        switch (int.Parse(opcaomenu))
        {
            case 1:
                {
                    _veiculoServico.Cadastrar();
                    Menu();
                    break;
                }
            case 2:
                {
                    _veiculoServico.RetornarTodos();
                    Menu();
                    break;
                }
            case 4:
                {
                    _veiculoServico.RetornarVeiculo();
                    Menu();
                    break;
                }
            case 6:
                {
                    Environment.Exit(0);
                    break;
                }

            default:
                {
                    Console.WriteLine(" OPÇÃO INVÁLIDA, PRESSIONE [ENTER]");
                    Console.ReadKey();
                    Menu();
                    break;
                }
        }
    }



}
