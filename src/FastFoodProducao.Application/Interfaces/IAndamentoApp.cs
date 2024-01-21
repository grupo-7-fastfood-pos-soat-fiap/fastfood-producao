using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.ViewModels;
using GenericPack.Messaging;

namespace FastFoodProducao.Application.Interfaces
{
    public interface IAndamentoApp
    {
        Task<CommandResult> Add(AndamentoInputModel model);
        Task<CommandResult> Update(Guid id, AndamentoInputModel model);
    }
}
