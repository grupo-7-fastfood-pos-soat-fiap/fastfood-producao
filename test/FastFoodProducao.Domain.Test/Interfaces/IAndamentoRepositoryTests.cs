using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodProducao.Domain.Test.Interfaces
{
    public class IAndamentoRepositoryTests
    {
        [Fact]
        public async Task GetById_ShouldReturnAndamento_WhenIdExists()
        {
            // Arrange
            var id = Guid.NewGuid();
            var pedidoId = Guid.NewGuid();
            var funcionarioId = Guid.NewGuid();
            var situacaoId = 0;

            var andamento = new Andamento(id, pedidoId, funcionarioId, situacaoId, DateTime.Now, null, true);

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetById(id))
                .ReturnsAsync(andamento);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetById(id);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
        }

        [Fact]
        public async Task GetById_ShouldReturnNull_WhenIdDoesNotExist()
        {
            // Arrange
            var nonExistingId = Guid.NewGuid();

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetById(nonExistingId))
                .ReturnsAsync((Andamento)null!);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetById(nonExistingId);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task GetAll_ShouldReturnListOfAndamentosAtivos()
        {
            // Arrange
            var andamentos = new List<Andamento>
            {
                new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 0, DateTime.Now, null, true),
                new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 1, DateTime.Now, null, true),
                new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 2, DateTime.Now, null, true)
            };

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetAllAtivos())
                .ReturnsAsync(andamentos);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetAllAtivos();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(andamentos.Count, result.Count());
        }


        [Fact]
        public async Task GetAll_ShouldReturnListOfAndamentosByCricao()
        {
            // Arrange
            var andamentos = new List<Andamento>
        {
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 0, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 1, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 2, DateTime.Now, null, true)
        };

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetAllByCriacao())
                .ReturnsAsync(andamentos);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetAllByCriacao();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(andamentos.Count, result.Count());
        }

        [Fact]
        public async Task GetAll_ShouldReturnListOfAndamentosByPedido()
        {
            // Arrange
            var pedidoId = Guid.NewGuid();
            var andamentos = new List<Andamento>
        {
            new Andamento(Guid.NewGuid(), pedidoId, Guid.NewGuid(), 0, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), pedidoId, Guid.NewGuid(), 1, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 2, DateTime.Now, null, true)
        };

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetAllByPedido(pedidoId))
                .ReturnsAsync(andamentos);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetAllByPedido(pedidoId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(andamentos.Count, result.Count());
        }

        [Fact]
        public async Task GetAll_ShouldReturnListOfAndamentosBySituacao()
        {
            // Arrange
            var siatuacaoId = 2;
            var andamentos = new List<Andamento>
        {
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), siatuacaoId, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 1, DateTime.Now, null, true),
            new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), siatuacaoId, DateTime.Now, null, true)
        };

            var mockRepository = new Mock<IAndamentoRepository>();
            mockRepository.Setup(repo => repo.GetAllBySituacao(siatuacaoId))
                .ReturnsAsync(andamentos);

            var repository = mockRepository.Object;

            // Act
            var result = await repository.GetAllBySituacao(siatuacaoId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(andamentos.Count, result.Count());
        }

        [Fact]
        public void Add_ShouldAddAndamentoToRepository()
        {
            // Arrange
            var andamento = new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 0, DateTime.Now, null, true);

            var mockRepository = new Mock<IAndamentoRepository>();
            var repository = mockRepository.Object;

            // Act
            repository.Add(andamento);

            // Assert
            mockRepository.Verify(repo => repo.Add(It.IsAny<Andamento>()), Times.Once);
        }

        [Fact]
        public void Update_ShouldUpdateAndamentoInRepository()
        {
            // Arrange
            var andamento = new Andamento(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), 0, DateTime.Now, null, true);

            var mockRepository = new Mock<IAndamentoRepository>();
            var repository = mockRepository.Object;

            // Act
            repository.Update(andamento);

            // Assert
            mockRepository.Verify(repo => repo.Update(It.IsAny<Andamento>()), Times.Once);
        }

        [Fact]
        public void Update_ShouldDesativaAndamentosAnterioresInRepository()
        {
            // Arrange
            Guid pedidoId = Guid.NewGuid();

            var mockRepository = new Mock<IAndamentoRepository>();
            var repository = mockRepository.Object;

            // Act
            repository.DesativaAndamentosAnteriosDoPedido(pedidoId);

            // Assert
            mockRepository.Verify(repo => repo.DesativaAndamentosAnteriosDoPedido(pedidoId));
        }

    }
}
