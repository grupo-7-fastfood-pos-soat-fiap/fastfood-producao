using AutoMapper;
//using FastFoodProducao.Application.InputModels;
//using FastFoodProducao.Domain.Commands.CategoriaProdutoCommands;
//using FastFoodProducao.Domain.Commands.PedidoCommands;
//using FastFoodProducao.Domain.Commands.ProdutoCommands;
//using FastFoodProducao.Domain.Commands.PagamentoCommands;
//using FastFoodProducao.Domain.Commands;
//using FastFoodProducao.Domain.Models;
//using FastFoodProducao.Domain.Commands.ClienteCommands;
//using FastFoodProducao.Domain.Models.PedidoAggregate;
//using FastFoodProducao.Domain.Commands.AndamentoCommands;

namespace FastFoodProducao.Application.AutoMapper
{
    public class InputModelToDomainMappingProfile:Profile
    {
        public InputModelToDomainMappingProfile()
        {            
            AllowNullCollections = true;

            ////Cliente
            //CreateMap<ClienteInputModel, ClienteCreateCommand>();
            
            ////CategoriaProduto
            //CreateMap<CategoriaProdutoInputModel, CategoriaProdutoCreateCommand>();
            //CreateMap<CategoriaProdutoInputModel, CategoriaProdutoUpdateCommand>();

            ////Produto  
            //CreateMap<ProdutoInputModel, ProdutoCreateCommand>();
            //CreateMap<ProdutoInputModel, ProdutoUpdateCommand>(); 

            ////Pedido
            //CreateMap<PedidoInputModel, PedidoCreateCommand>();
            //CreateMap<PedidoInputModel, PedidoUpdateCommand>();

            //CreateMap<PedidoComboInputModel, PedidoCombo>();
            //CreateMap<PedidoComboProdutoInputModel, PedidoComboProduto>();

            //CreateMap<AndamentoInputModel, AndamentoCreateCommand>();
            //CreateMap<AndamentoInputModel, AndamentoUpdateCommand>();

            //CreateMap<PagamentoInputModel, PagamentoUpdateCommand>();
        }
    }
}
