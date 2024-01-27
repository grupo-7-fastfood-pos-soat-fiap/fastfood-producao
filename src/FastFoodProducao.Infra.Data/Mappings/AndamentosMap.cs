using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace FastFoodProducao.Infra.Data.Mappings{
    public class AndamentosMap 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]        
        public Guid Id { get; set; }

        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid PedidoId { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime? DataHoraFim { get; private set; }

        [BsonGuidRepresentation(GuidRepresentation.Standard)]
        public Guid? FuncionarioId { get; private set; }
        public int SituacaoId { get; private set; }
        public bool Atual { get; set; }           
    }
}

