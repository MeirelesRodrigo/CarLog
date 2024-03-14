using CarLog.Domain;

namespace CarLog.Infrastructure.Interfaces
{
    public interface IVeiculoServico
    {
        bool Cadastrar();
        bool Excluir(string placa);
        void RetornarVeiculo();
        void RetornarTodos();
    }
}
