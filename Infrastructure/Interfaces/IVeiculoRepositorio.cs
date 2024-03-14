using CarLog.Domain;

namespace CarLog.Infrastructure.Interfaces
{
    public interface IVeiculoRepositorio
    {
        bool Cadastrar(List<Veiculo> veiculos);
        bool Excluir(string placa);
        List<Veiculo> RetornarTodos();
    }
}
