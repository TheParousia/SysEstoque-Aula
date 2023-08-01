using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SysEstoque.Models.Config {
	internal class ItemNotaEntradaConfig : IEntityTypeConfiguration<ItemNotaEntrada> {
		public void Configure(EntityTypeBuilder<ItemNotaEntrada> builder) {
			builder.HasKey(ItemNIn => new { ItemNIn.NotaEntradaId, ItemNIn.ProdutoId });

			builder.HasOne(ItemNIn => ItemNIn.NotaEntrada)
					.WithMany(NIn => NIn.ItensProdutoEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.NotaEntradaId);

			builder.HasOne(ItemNIn => ItemNIn.Produto)
					.WithMany(P => P.ItensNotaEntrada)
					.HasForeignKey(ItemNIn => ItemNIn.ProdutoId);
		}
	}
}
