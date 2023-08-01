using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SysEstoque.Models.Config {
	public class NotaSaidaConfig : IEntityTypeConfiguration<NotaSaida> {
		public void Configure(EntityTypeBuilder<NotaSaida> builder) {

			builder.HasMany(NOut => NOut.ProdutosSaida)
				.WithMany(Produto => Produto.NotasSaida)
				.UsingEntity<ItemNotaSaida>();
		}
	}
}
