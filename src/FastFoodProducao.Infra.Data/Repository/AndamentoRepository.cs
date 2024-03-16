using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Domain.Models;
using GenericPack.Data;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace FastFoodProducao.Infra.Data.Repository
{    
    public class AndamentoMensageria:IAndamentoRepository
    {
        private readonly IMongoCollection<Andamento> _andamentos;        

        public AndamentoMensageria(IOptions<StoreDatabaseConfig> databaseConfig )
        {
            var client = new MongoClient(databaseConfig.Value.ConnectionString);
            var database = client.GetDatabase(databaseConfig.Value.DatabaseName);
            _andamentos = database.GetCollection<Andamento>(databaseConfig.Value.CollectionName);            
        }

        public void Add(Andamento andamento)
        {
            _andamentos.InsertOne(andamento);
        }        

        public async Task<Andamento?> GetById(Guid id)
        {
            return (Andamento)await _andamentos.Find(c =>c.Id == id).FirstOrDefaultAsync();
        }

        public void Update(Andamento andamento)
        {
             _andamentos.ReplaceOne(c => c.Id == andamento.Id, andamento);
        }

        public void DesativaAndamentosAnteriosDoPedido(Guid pedidoId)
        {
            UpdateDefinition<Andamento> andamentos = Builders<Andamento>.Update.Set(x => x.Atual, false).Set(x => x.DataHoraFim, DateTime.UtcNow);            
            _andamentos.UpdateMany(c => c.PedidoId == pedidoId && c.Atual, andamentos);
        }
        

        public async Task<IEnumerable<Andamento>> GetAllByPedido(Guid pedidoId){
             return _andamentos.Find(x => x.PedidoId == pedidoId).ToList();
        }

        public async Task<IEnumerable<Andamento>> GetAllBySituacao(int situacaoId)
        {
            return _andamentos.Find(c => c.SituacaoId == situacaoId && c.Atual).ToList(); 
        }

        public async Task<IEnumerable<Andamento>> GetAllAtivos()
        {
            return _andamentos.Find(c => c.Atual && c.SituacaoId < 4).ToList().OrderBy(c => c.DataHoraInicio).OrderBy(c => c.SituacaoId);
        }

        public async Task<IEnumerable<Andamento>> GetAllByCriacao()
        {
            return _andamentos.Find(c => c.SituacaoId == 0).ToList().OrderBy(c => c.DataHoraInicio);
        }
    }
}
