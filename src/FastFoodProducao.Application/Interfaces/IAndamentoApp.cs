using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.ViewModels;
using GenericPack.Messaging;

namespace FastFoodProducao.Application.Interfaces
{
    public interface IAndamentoApp
    {
        Task<AndamentoViewModel> GetById(Guid pedidoId);
        Task<List<AndamentoViewModel>> GetAllByCriacao();
        Task<List<AndamentoViewModel>> GetAllAtivos();
        Task<List<AndamentoViewModel>> GetAllBySituacao(int situacaoId);
        Task<CommandResult> Add(AndamentoInputModel model);      
        Task<CommandResult> Update(Guid id, AndamentoInputModel model);
        
    }
}
