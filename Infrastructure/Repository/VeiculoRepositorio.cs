using CarLog.Domain;
using CarLog.Infrastructure.Interfaces;
using System.Text.Json;

namespace CarLog.Infrastructure.Repository
{
    public class VeiculoRepositorio : IVeiculoRepositorio
    {
        public bool Cadastrar(List<Veiculo> veiculos)
        {
            var Json = JsonSerializer.Serialize(veiculos);
            File.WriteAllText("VeiculosBD.txt", Json);
            return true;
        }

        public bool Excluir(string placa)
        {
            throw new NotImplementedException();
        }

        public List<Veiculo> RetornarTodos()
        {
            if (File.Exists("VeiculosBD.txt"))
            {
                var dados = File.ReadAllText("VeiculosBD.txt");
                return JsonSerializer.Deserialize<List<Veiculo>>(dados);
            }
            return new List<Veiculo>();
        }
    }
}
