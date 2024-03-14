using CarLog.Domain;
using CarLog.Infrastructure.Interfaces;
using CarLog.Infrastructure.Repository;

namespace CarLog.Infrastructure.Service
{
    public class VeiculoServico : IVeiculoServico
    {
        private readonly VeiculoRepositorio _veiculoRepositorio;
        public VeiculoServico()
        {
            _veiculoRepositorio = new VeiculoRepositorio();
        }

        public bool Cadastrar()
        {
            var veiculos = _veiculoRepositorio.RetornarTodos();
            var veiculo = CadastroVeiculo();
            veiculos.Add(veiculo);
            _veiculoRepositorio.Cadastrar(veiculos);
            return true;
        }

        public bool Excluir(string placa)
        {
            throw new NotImplementedException();
        }

        public void RetornarTodos()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("                             CAR LOG                         ");
            Console.WriteLine("                      VEÍCULOS CADASTRADOS                   ");
            Console.WriteLine("-------------------------------------------------------------");
            var veiculos = _veiculoRepositorio.RetornarTodos();

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine("**********************************************************");
                Console.WriteLine("  ID...............: " + veiculo.ExternalId);
                Console.WriteLine("  PLACA............: " + veiculo.Placa);
                Console.WriteLine("  FABRICANTE.......: " + veiculo.Fabricante);
                Console.WriteLine("  MODELO...........: " + veiculo.Modelo);
                Console.WriteLine("  ANO FABRICAÇÃO...: " + veiculo.AnoFabricacao);
                Console.WriteLine("  KM...............: " + veiculo.Km + " KM");
                Console.WriteLine("  STATUS...........: " + veiculo.Status);
                Console.WriteLine("  KM...............: " + veiculo.Km);
                Console.WriteLine("  LOCAL BASE.......: " + veiculo.LocaBase);
                Console.WriteLine("  CADASTRADO EM....: " + veiculo.CadastradoEm);
                Console.WriteLine("**********************************************************");

            }
            Console.ReadLine();
        }

        public void RetornarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("  INFORME A PLACA DO VEÍCULO");
            var placa = Console.ReadLine();

            var veiculo = _veiculoRepositorio.RetornarTodos().Where(x => x.Placa == placa).FirstOrDefault();

            Console.WriteLine("**********************************************************");
            Console.WriteLine("  ID...............: " + veiculo.ExternalId);
            Console.WriteLine("  PLACA............: " + veiculo.Placa);
            Console.WriteLine("  FABRICANTE.......: " + veiculo.Fabricante);
            Console.WriteLine("  MODELO...........: " + veiculo.Modelo);
            Console.WriteLine("  ANO FABRICAÇÃO...: " + veiculo.AnoFabricacao);
            Console.WriteLine("  KM...............: " + veiculo.Km + " KM");
            Console.WriteLine("  STATUS...........: " + veiculo.Status);
            Console.WriteLine("  KM...............: " + veiculo.Km);
            Console.WriteLine("  LOCAL BASE.......: " + veiculo.LocaBase);
            Console.WriteLine("  CADASTRADO EM....: " + veiculo.CadastradoEm);
            Console.WriteLine("**********************************************************");
            Console.ReadLine();
        }

        private Veiculo CadastroVeiculo()
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
            Console.WriteLine();

            var veiculocadastro = new Veiculo();
            veiculocadastro.Placa = placa;
            veiculocadastro.Fabricante = fabricante;
            veiculocadastro.Modelo = modelo;
            veiculocadastro.AnoFabricacao = anofabricacao;
            veiculocadastro.Km = km;
            veiculocadastro.Status = status;
            veiculocadastro.LocaBase = localbase;
            veiculocadastro.CadastradoEm = DateTime.Now;
            return veiculocadastro;
        }
    }
}
