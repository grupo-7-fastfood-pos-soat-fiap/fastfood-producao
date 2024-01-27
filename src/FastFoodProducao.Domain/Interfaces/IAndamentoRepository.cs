using FastFoodProducao.Domain.Models;
using GenericPack.Data;

namespace FastFoodProducao.Domain.Interfaces
{
    public interface IAndamentoRepository : IRepository<Andamento>
    {
        Task<Andamento?> GetById(Guid id);
        void Add(Andamento andamento);
        void Update(Andamento andamento);
        void DesativaAndamentosAnteriosDoPedido(Guid pedidoId);
        Task<IEnumerable<Andamento>> GetAllByPedido(Guid pedidoId);
        Task<IEnumerable<Andamento>> GetAllAtivos();
        Task<IEnumerable<Andamento>> GetAllByCriacao();
        Task<IEnumerable<Andamento>> GetAllBySituacao(int situacaoId);
    }
}
