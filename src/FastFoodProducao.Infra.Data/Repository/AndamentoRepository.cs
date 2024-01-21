using FastFoodProducao.Domain.Interfaces;
using FastFoodProducao.Domain.Models;
using FastFoodProducao.Infra.Data.Context;
using GenericPack.Data;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace FastFoodProducao.Infra.Data.Repository
{    
    public class AndamentoRepository:IAndamentoRepository
    {
        //protected readonly AppDbContext Db;
        //protected readonly DbSet<Andamento> DbSet;
        private readonly IMongoCollection<Andamento> _andamentos;

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public AndamentoRepository(IDatabaseConfig databaseConfig)
        {
            //Db = context;
            //DbSet = Db.Set<Andamento>();
            var client = new MongoClient(databaseConfig.ConnectionString);
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _andamentos = database.GetCollection<Andamento>("andamentos");
        }

        //public IUnitOfWork UnitOfWork => Db;

        public void Add(Andamento andamento)
        {
            //DbSet.Add(andamento);
            _andamentos.InsertOne(andamento);
        }

        public void Dispose()
        {
            //Db.Dispose();
        }

        public async Task<Andamento?> GetById(Guid id)
        {
            //return await DbSet.FindAsync(id);
            return _andamentos.Find(c => c.Id == id).FirstOrDefault();
        }

        public void Update(Andamento andamento)
        {
            //DbSet.Update(andamento);
             _andamentos.ReplaceOne(c => c.Id == andamento.Id, andamento);
        }

        public void DesativaAndamentosAnteriosDoPedido(Guid pedidoId)
        {
            // var andamentos = DbSet.AsNoTracking().Where(f => f.PedidoId == pedidoId && f.Atual).ToList();
            // foreach(var andamento in andamentos)
            // {
            //     andamento.Atual = false;
            //     DbSet.Update(andamento);
            // }           
        }

        public async Task<IEnumerable<Andamento>> GetAllByPedido(Guid pedidoId){
            //return await DbSet.AsNoTracking().Where(x => x.PedidoId == pedidoId).ToListAsync();
             return _andamentos.Find(c => true).ToList();
        }
    }
}
