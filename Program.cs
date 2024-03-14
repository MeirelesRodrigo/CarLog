using Repositorio;

namespace CarLog;


class Program
{

    static RepositorioVeiculo _repositorioveiculo = new RepositorioVeiculo();

    static void Main(string[] args)
    {
        _repositorioveiculo.Lerdados();

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
        Console.WriteLine("  4 - REMOVER VEÍCULO        ");
        Console.WriteLine("  5 - SAIR                   ");
        Console.WriteLine("-----------------------------");

        OpMenu();
    
    
    }


    static void OpMenu()
    {
        Console.WriteLine("  ESCOLHA A OPÇÃO DESEJADA");
        var opcaomenu =  Console.ReadLine();

        switch(int.Parse(opcaomenu)) {
            case 1:
                {
                    _repositorioveiculo.CadastroVeiculo();
                    Menu();
                    break;
                }
            case 2:
                {
                    _repositorioveiculo.ExibirVeiculos();
                    Menu();
                    break;
                }
            case 3:
                {
                    _repositorioveiculo.EditarVeiculos();
                    Menu();
                    break;
                }
            case 4:
                {
                    _repositorioveiculo.ExcluirVeiculos();
                    Menu();
                    break;
                }
            case 5: {
                    _repositorioveiculo.GravarDados();
                    Environment.Exit(0);
                    break;
                }

            default:
                {
                    Console.WriteLine("  OPÇÃO INVÁLIDA, PRESSIONE [ENTER]");
                    Console.ReadKey();
                    Menu();
                    break;
                }
        }
    }



}
    