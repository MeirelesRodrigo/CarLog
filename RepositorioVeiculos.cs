using CadastroVeiculo;

namespace Repositorio;

public class RepositorioVeiculo()
{

    public List<Veiculos> veiculo = new List<Veiculos>();
    
    public void CadastroVeiculo()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("                             CAR LOG                         ");
        Console.WriteLine("                      CADASTRO DE VEÍCULO                    ");
        Console.WriteLine("-------------------------------------------------------------");

        Console.WriteLine("  PLACA");
        var placa = Console.ReadLine(); 
        Console.Write(Environment.NewLine);

        Console.WriteLine("  FABRICANTE");
        var fabricante = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  MODELO");
        var modelo = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  ANO DE FABRICAÇÃO");
        var anofabricacao = int.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("  KM");
        var km = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("  STATUS");
        var status = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  LOCAL-BASE");
        var localbase = Console.ReadLine();
        Console.Write(Environment.NewLine);

        var veiculocadastro = new Veiculos();
        veiculocadastro.Id = veiculo.Count + 1;
        veiculocadastro.Placa = placa;
        veiculocadastro.Fabricante = fabricante;
        veiculocadastro.Modelo = modelo;
        veiculocadastro.AnoFabricacao = anofabricacao;
        veiculocadastro.Km = km;
        veiculocadastro.Status = status;
        veiculocadastro.LocaBase = localbase;
        veiculocadastro.CadastradoEm = DateTime.Now;

        veiculo.Add(veiculocadastro);
        Console.Clear();
        Console.WriteLine("  VEÍCULO CADASTRADO COM SUCESSO, PRESSIONE [ENTER]");
        ImprimirVeiculos(veiculocadastro);
        Console.ReadKey();
        

    }


    public void ImprimirVeiculos(Veiculos veiculoscadastrado)
    { 
        Console.WriteLine("**********************************************************");
        Console.WriteLine("  ID...............: " + veiculoscadastrado.Id);
        Console.WriteLine("  PLACA............: " + veiculoscadastrado.Placa);
        Console.WriteLine("  FABRICANTE.......: " + veiculoscadastrado.Fabricante);
        Console.WriteLine("  MODELO...........: " + veiculoscadastrado.Modelo);
        Console.WriteLine("  ANO FABRICAÇÃO...: " + veiculoscadastrado.AnoFabricacao);
        Console.WriteLine("  KM...............: " + veiculoscadastrado.Km + " KM");
        Console.WriteLine("  STATUS...........: " + veiculoscadastrado.Status);
        Console.WriteLine("  KM...............: " + veiculoscadastrado.Km);
        Console.WriteLine("  LOCAL BASE.......: " + veiculoscadastrado.LocaBase);
        Console.WriteLine("  CADASTRADO EM....: " + veiculoscadastrado.CadastradoEm);
        Console.WriteLine("**********************************************************");
        
    }

    public void ExibirVeiculos()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("                             CAR LOG                         ");
        Console.WriteLine("                      VEÍCULO CADASTRADOS                   ");
        Console.WriteLine("-------------------------------------------------------------");

        foreach (var lista in veiculo)
        {
            ImprimirVeiculos(lista);

        }
        Console.WriteLine("  PRESSIONE [ENTER]");
        Console.ReadKey();

    }

    public void EditarVeiculos()
    {
        Console.Clear();
        Console.WriteLine("  INFORME A PLACA DO VEÍCULO");
        var placapesquisa = Console.ReadLine();

        var veiculocadastrado = veiculo.FirstOrDefault(v => v.Placa == placapesquisa); 

        if(veiculocadastrado == null)
        {
            Console.WriteLine("VEÍCULO NÃO ENCONTRADO");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("                             CAR LOG                         ");
        Console.WriteLine("                       VEÍCULO ENCONTRADADO                  ");
        Console.WriteLine("-------------------------------------------------------------");
       
        ImprimirVeiculos(veiculocadastrado);

        Console.WriteLine("  PLACA");
        var placa = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  FABRICANTE");
        var fabricante = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  MODELO");
        var modelo = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  ANO DE FABRICAÇÃO");
        var anofabricacao = int.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("  KM");
        var km = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.WriteLine("  STATUS");
        var status = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.WriteLine("  LOCAL-BASE");
        var localbase = Console.ReadLine();
        Console.Write(Environment.NewLine);

        veiculocadastrado.Placa = placa;
        veiculocadastrado.Fabricante = fabricante;
        veiculocadastrado.AnoFabricacao = anofabricacao;
        veiculocadastrado.Km = km;
        veiculocadastrado.Status = status;
        veiculocadastrado.LocaBase = localbase;


        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("                             CAR LOG                         ");
        Console.WriteLine("                      VEÍCULO EDITADO COM SUCESSO            ");
        Console.WriteLine("-------------------------------------------------------------");
        ImprimirVeiculos(veiculocadastrado);
        Console.ReadKey();
        
    }

    public void ExcluirVeiculos()
    {


        Console.Clear();
        Console.WriteLine("  INFORME A PLACA DO VEÍCULO");
        var placapesquisa = Console.ReadLine();

        var veiculocadastrado = veiculo.FirstOrDefault(v => v.Placa == placapesquisa);

        if (veiculocadastrado == null)
        {
            Console.WriteLine("VEÍCULO NÃO ENCONTRADO");
            Console.ReadKey();
            return;
        }

        ImprimirVeiculos(veiculocadastrado);
        veiculo.Remove(veiculocadastrado);
        Console.WriteLine("  VEÍCULO EXCLUÍDO COM SUCESSO, PRESSIONE ENTER");
        Console.ReadKey();

    }

    
    public void Lerdados()
    {
        if (File.Exists("VeiculosBD.txt"))
        {
            var dados = File.ReadAllText("VeiculosBD.txt");
            var clientesarquivo = System.Text.Json.JsonSerializer.Deserialize<List<Veiculos>>(dados);

            veiculo.AddRange(clientesarquivo);
        }
    }
    
    
    
    public void GravarDados()
    {
        var Json = System.Text.Json.JsonSerializer.Serialize(veiculo);
        File.WriteAllText("VeiculosBD.txt",Json);
    }

}
