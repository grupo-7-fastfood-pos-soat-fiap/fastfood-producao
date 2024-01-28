using FastFoodProducao.Domain.Commands.AndamentoCommands;
using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Domain.Models;
using GenericPack.Data;
using Moq;

namespace FastFoodProducao.Domain.Test.Commands.AndamentoCommands
{
    public class AndamentoCommandHandlerTests
    {
        public class PagamentoUpdateCommandHandlerTest
        {
            [Fact]
            public async Task Handle_AndamentoOrdemCorreta_Create()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var situacaoAtualId = 0;
                var situacaoNovaId = 1;
                var lista = new List<Andamento>();
                lista.Add(new Andamento(id, pedidoId, funcionarioId, situacaoAtualId, DateTime.Now, null, true));

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetAllByPedido(pedidoId))
                              .ReturnsAsync(lista);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoCreateCommand(pedidoId, funcionarioId, situacaoNovaId);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Create foi chamado no repositório
                repositoryMock.Verify(r => r.Add(It.IsAny<Andamento>()), Times.Once);

            }

            [Fact]
            public async Task Handle_AndamentoOrdemCorretaIncorreta_Create()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var situacaoAtualId = 0;
                var situacaoNovaId = 0;
                var lista = new List<Andamento>();
                lista.Add(new Andamento(id, pedidoId, funcionarioId, situacaoAtualId, DateTime.Now, null, true));

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetAllByPedido(pedidoId))
                              .ReturnsAsync(lista);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoCreateCommand(pedidoId, funcionarioId, situacaoNovaId);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Create foi chamado no repositório
                repositoryMock.Verify(r => r.Add(It.IsAny<Andamento>()), Times.Never);

            }

            [Fact]
            public async Task Handle_AndamentoPedidoSituacaoNaoExiste_Create()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var situacaoId = 0;

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetAllByPedido(id))
                              .ReturnsAsync((List<Andamento>)null);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoCreateCommand(pedidoId, funcionarioId, situacaoId);                

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Create foi chamado no repositório
                repositoryMock.Verify(r => r.Add(It.IsAny<Andamento>()), Times.Once);

            }

            [Fact]
            public async Task Handle_AndamentoPedidoSituacaoExiste_Create()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var situacaoId = 0;
                var lista = new List<Andamento>();
                lista.Add(new Andamento(id, pedidoId, funcionarioId, situacaoId, DateTime.Now, null, true));

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetAllByPedido(pedidoId))
                              .ReturnsAsync(lista);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoCreateCommand(pedidoId, funcionarioId, situacaoId);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Create foi chamado no repositório
                repositoryMock.Verify(r => r.Add(It.IsAny<Andamento>()), Times.Never);

            }

            [Fact]
            public async Task Handle_AndamentoPedidoSituacaoOrdemCorreta_Creates()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var situacaoId = 0;
                var lista = new List<Andamento>();
                lista.Add(new Andamento(id, pedidoId, funcionarioId, situacaoId, DateTime.Now, null, true));

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetAllByPedido(pedidoId))
                              .ReturnsAsync(lista);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoCreateCommand(pedidoId, funcionarioId, situacaoId);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Create foi chamado no repositório
                repositoryMock.Verify(r => r.Add(It.IsAny<Andamento>()), Times.Never);

            }

            [Fact]
            public async Task Handle_AndamentoExiste_Update()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var data = DateTime.Now;
                var situacaoId = 0;

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetById(id))
                              .ReturnsAsync(new Andamento(id, pedidoId, funcionarioId, situacaoId, data, null, true));


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoUpdateCommand(pedidoId, funcionarioId, situacaoId, data, DateTime.Now, false);
                command.SetId(id);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Update foi chamado no repositório
                repositoryMock.Verify(r => r.Update(It.IsAny<Andamento>()), Times.Once);

            }

            [Fact]
            public async Task Handle_AndamentoNaoExiste_Update()
            {
                // Arrange
                var id = Guid.NewGuid();
                var pedidoId = Guid.NewGuid();
                var funcionarioId = Guid.NewGuid();
                var data = DateTime.Now;
                var situacaoId = 0;

                var repositoryMock = new Mock<IAndamentoRepository>();
                repositoryMock.Setup(r => r.GetById(id))
                              .ReturnsAsync((Andamento)null);


                var handler = new AndamentoCommandHandler(null, repositoryMock.Object);
                var command = new AndamentoUpdateCommand(pedidoId, funcionarioId, situacaoId, data, DateTime.Now, false);
                command.SetId(id);

                // Act
                var result = await handler.Handle(command, CancellationToken.None);

                // Verifique se o método Update foi chamado no repositório
                repositoryMock.Verify(r => r.Update(It.IsAny<Andamento>()), Times.Never);

            }
        }
    }
}
