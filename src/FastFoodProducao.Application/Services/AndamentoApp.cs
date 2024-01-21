using AutoMapper;
using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.Interfaces;
using FastFoodProducao.Domain.Commands.AndamentoCommands;
using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Domain.Models;
using FluentValidation.Results;
using GenericPack.Mediator;
using GenericPack.Messaging;

namespace FastFoodProducao.Application.Services
{
    public class AndamentoApp:IAndamentoApp
    {
        private readonly IAndamentoRepository _andamentoRepository;
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;

        public AndamentoApp(IAndamentoRepository andamentoRepository, IMediatorHandler mediator, IMapper mapper)
        {
            _andamentoRepository = andamentoRepository;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<CommandResult> Add(AndamentoInputModel model)
        {
            var command = _mapper.Map<AndamentoCreateCommand>(model);
            return await _mediator.SendCommand(command);
        }

        public async Task<CommandResult> Update(Guid id, AndamentoInputModel model)
        {
            var command = _mapper.Map<AndamentoUpdateCommand>(model);
            command.SetId(id);
            return await _mediator.SendCommand(command);
        }
    }
}
