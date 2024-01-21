using FastFoodProducao.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FastFoodProducao.Infra.Data.Mappings
{
    public class AndamentosMap : IEntityTypeConfiguration<Andamento>
    {
        public void Configure(EntityTypeBuilder<Andamento> builder)
        {
            builder.ToTable("pedidos_andamentos");

            builder.HasKey(c => c.Id)
                .HasName("PRIMARY");

            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.PedidoId)
                .HasColumnName("pedido_id");

            builder.HasIndex(c => c.PedidoId);            

            builder.Property(c => c.DataHoraInicio)
                .HasColumnName("data_hora_inicio");

            builder.Property(c => c.DataHoraFim)
                .HasColumnName("data_hora_fim");

            builder.Property(c => c.Atual)
                .HasColumnName("atual");

            builder.Property(c => c.SituacaoId)
                .HasColumnName("situacao_id");

            builder.HasIndex(c => c.SituacaoId);

            builder.HasOne(c => c.SituacaoPedidoNavegation)
               .WithMany()
               .HasForeignKey(p => p.SituacaoId);

            builder.Property(c => c.FuncionarioId)
                .HasColumnName("funcionario_id");

            builder.HasIndex(c => c.FuncionarioId);
            
            builder.Navigation(e => e.SituacaoPedidoNavegation).AutoInclude();            
        }
    }
}
