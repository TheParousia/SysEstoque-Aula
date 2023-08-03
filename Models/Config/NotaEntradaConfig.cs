using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SysEstoque.Models.Config {
	internal class NotaEntradaConfig : IEntityTypeConfiguration<NotaEntrada> {
		public void Configure(EntityTypeBuilder<NotaEntrada> builder) {
			
			builder.HasMany(NIn => NIn.ProdutosEntrada)
				.WithMany(Produto => Produto.NotasEntrada)
				.UsingEntity<ItemNotaEntrada>();
		}
	}
}
