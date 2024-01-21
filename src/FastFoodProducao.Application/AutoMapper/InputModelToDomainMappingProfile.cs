using AutoMapper;
using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Domain.Commands;
using FastFoodProducao.Domain.Models;
using FastFoodProducao.Domain.Commands.AndamentoCommands;

namespace FastFoodProducao.Application.AutoMapper
{
    public class InputModelToDomainMappingProfile:Profile
    {
        public InputModelToDomainMappingProfile()
        {            
            AllowNullCollections = true;

            CreateMap<AndamentoInputModel, AndamentoCreateCommand>();
            CreateMap<AndamentoInputModel, AndamentoUpdateCommand>();            
        }
    }
}
