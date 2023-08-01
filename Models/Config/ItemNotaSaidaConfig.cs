using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SysEstoque.Models.Config {
	internal class ItemNotaSaidaConfig : IEntityTypeConfiguration<ItemNotaSaida> {
		public void Configure(EntityTypeBuilder<ItemNotaSaida> builder) {
			builder.HasKey(ItemNIn => new { ItemNIn.NotaSaidaId, ItemNIn.ProdutoId });

			builder.HasOne(ItemNIn => ItemNIn.NotaSaida)
					.WithMany(NIn => NIn.ItensNotaSaida)
					.HasForeignKey(ItemNIn => ItemNIn.NotaSaidaId);

			builder.HasOne(ItemNIn => ItemNIn.Produto)
					.WithMany(P => P.ItensNotaSaida)
					.HasForeignKey(ItemNIn => ItemNIn.ProdutoId);
		}
	}
}
