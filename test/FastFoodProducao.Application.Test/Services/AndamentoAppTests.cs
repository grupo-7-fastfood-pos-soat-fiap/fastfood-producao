using AutoMapper;
using FastFoodProducao.Application.InputModels;
using FastFoodProducao.Application.Services;
using FastFoodProducao.Domain.Commands.AndamentoCommands;
using FastFoodProducao.Domain.Interfaces;
using GenericPack.Mediator;
using Moq;

namespace FastFoodProducao.Application.Test.Services
{
    public class AndamentoAppTests
    {
        [Fact]
        public async Task Create_ValidModel_ShouldCallMediator()
        {
            // Arrange
            var id = Guid.NewGuid();
            var situacaoId = 2;
            var model = new AndamentoInputModel();
            var command = new AndamentoCreateCommand(id, Guid.NewGuid(), situacaoId);

            var andamentoRepositoryMock = new Mock<IAndamentoRepository>();
            var mediatorMock = new Mock<IMediatorHandler>();
            var mapperMock = new Mock<IMapper>();

            mapperMock.Setup(m => m.Map<AndamentoCreateCommand>(model)).Returns(command);

            var andamentoApp = new AndamentoApp(andamentoRepositoryMock.Object, mediatorMock.Object, mapperMock.Object);

            // Act
            var result = await andamentoApp.Add(model);

            // Assert
            mediatorMock.Verify(m => m.SendCommand(command), Times.Once);
        }

        [Fact]
        public async Task Update_ValidModel_ShouldCallMediator()
        {
            // Arrange
            var id = Guid.NewGuid();
            var situacaoId = 2;
            var model = new AndamentoInputModel();
            var command = new AndamentoUpdateCommand(id,Guid.NewGuid(), situacaoId,DateTime.Now,null, true);

            var andamentoRepositoryMock = new Mock<IAndamentoRepository>();
            var mediatorMock = new Mock<IMediatorHandler>();
            var mapperMock = new Mock<IMapper>();

            mapperMock.Setup(m => m.Map<AndamentoUpdateCommand>(model)).Returns(command);

            var andamentoApp = new AndamentoApp(andamentoRepositoryMock.Object, mediatorMock.Object, mapperMock.Object);

            // Act
            var result = await andamentoApp.Update(id, model);

            // Assert
            mediatorMock.Verify(m => m.SendCommand(command), Times.Once);
        }

    }
}
