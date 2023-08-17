using SysEstoque.Models;
using SysEstoque.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MessageUtils;

namespace SysEstoque {
	public partial class FormMain : Form {




		internal Produto produtoSelecionado;

		public FormMain() {
						
			InitializeComponent();

			barStNome.Text = Globais.usuarioAtual.Nome;

			if (Globais.usuarioAtual.EhMaster) {
				barStNivel.Text = "Master";
			} else {
				barStNivel.Text = "Comum";
			}


			using (var db = new EstoqueContext()) {

				int qtdProd = db.Produtos.Count();

				if (qtdProd < 1) {


					var endereco1 = new Endereco {
						Id = 3,
						CEP = "68740000",
						Rua = "R. Pedro Porpino da Silva",
						Bairro = "Ianetama",
						Numero = "2773"
					};

					var endereco2 = new Endereco {
						Id = 4,
						CEP = "68740000",
						Rua = "Ave. Barão do Rio Brano",
						Bairro = "Centro",
						Numero = "5"
					};

					var usuario1 = new Usuario {
						Login = "root2",
						HashSenha = "2B64F2E3F9FEE1942AF9FF60D40AA5A719DB33B8BA8DD4864BB4F11E25CA2BEE00907DE32A59429602336CAC832C8F2EEFF5177CC14C864DD116C8BF6CA5D9A9",
						Nome = "Fulano",
						Sobrenome = "Silva",
						Email = "contato@asd.asd",
						Telefone = "123456879",
						Endereco = endereco2
					};


					var newCategora1 = new Categoria {
						Nome = "Móveis",
						Descricao = "Artigo para o lar"
					};

					var newCategora2 = new Categoria {
						Nome = "Eletrônicos",
						Descricao = "Artigos eletrônicos"
					};

					var newUnidadeM1 = new UnidadeMedida {
						Nome = "Kg",
						Descricao = "Kilograma"
					};

					var newProduto1 = new Produto {
						Nome = "Mercadoria 1",
						Preco = 15,
						Estoque = 50,
						UnidadeMedida = newUnidadeM1,
						Categoria = newCategora1,
						EstoqueMinimo = 50,
						EstoqueMedio = 75f,
						EstoqueMaximo = 100
					};

					var newProduto2 = new Produto {
						Nome = "Mercadoria 2",
						Preco = 7,
						Estoque = 60,
						UnidadeMedida = newUnidadeM1,
						Categoria = newCategora1,
						EstoqueMinimo = 25,
						EstoqueMedio = 52.5f,
						EstoqueMaximo = 80
					};

					var fornecedor1 = new Fornecedor {
						CNPJ = "48745781000180",
						NomeFantasia = "COZINHA DA SAUDE",
						RazaoSocial = "48.745.781 EDENILSA PIMENTEL DE CASTRO COSTA",
						CNAEPrincipal = "Outras atividades de ensino não especificadas anteriormente",
						ResponsavelRegistro = "Undefined",
						Email = "asd@asd.asd",
						Telefone = "9199941077",
						endereco = endereco1
					};

					db.Enderecos.AddRange(endereco1, endereco2);
					db.Usuario.Add(usuario1);
					db.Fornecedor.Add(fornecedor1);
					db.Produtos.AddRange(newProduto1, newProduto2);

					db.SaveChanges();
				}


				this.UpdateCbx(db);
				this.GetAllProduct(db);
			}
		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private void GetAllProduct(EstoqueContext db) {
			//Suprimi colunas vindas do banco de dados caso não tenham sido configurada no DataGridView
			dgvProdutos.AutoGenerateColumns = false;

			List<Produto> Produtos = db.Produtos
											.Include(i => i.Categoria)
											.Include(i => i.UnidadeMedida)
											.Include(i => i.Fornecedores)
											.Include(i => i.NotasEntrada)
											.Include(i => i.NotasSaida)
											.ToList();
			/*
			for (int j = 0; j < Produtos.Count(); j++) {
				Produtos[j].nomeCategoria = Produtos[j].Categoria.Nome;
				Produtos[j].nomeUnidadeMedida = Produtos[j].UnidadeMedida.Nome;
			}
			*/

			//List<Fornecedor> f1 =  db.Fornecedor.ToList();

			//Produtos[0].Fornecedores.Add(f1[0]);

			//db.SaveChangesAsync();

			dgvProdutos.DataSource = Produtos;

			/*
			int CategoriaIndex = dgvProdutos.Columns["CategoriaProd"].Index;
			int IdProdutoIndex = dgvProdutos.Columns["IdProduto"].Index;

			int i = 0;

			MessageBox.Show($"Value: {dgvProdutos.Rows[1].Cells[CategoriaIndex].Value}\nTypename: ", "info", MessageBoxButtons.OK);
			MessageBox.Show($"Value: {dgvProdutos.Rows[1].Cells[1].Value}\nTypename: ", "info", MessageBoxButtons.OK);
			MessageBox.Show($"Value: {dgvProdutos.Rows[1].Cells[1].Value}\nTypename: ", "info", MessageBoxButtons.OK);
			MessageBox.Show($"Value: {dgvProdutos.Rows[1].Cells[2].Value}\nTypename: ", "info", MessageBoxButtons.OK);
			
			var a = dgvProdutos.Rows[1].Cells[2].Value;
			*/



			/*
			foreach (Produto produto in Produtos) {

				//MessageBox.Show($"{produto.Categoria.Nome}", "info", MessageBoxButtons.OK);

				//MessageBox.Show($"{db.Categorias.Find(produto.idCategoria).Nome}", "info", MessageBoxButtons.OK);

				//Categoria cat = produto.Categoria;

				//var b = 

				//(dgvProdutos.Rows[i].Cells[CategoriaIndex] as DataGridViewTextBoxCell).Value = "Test";
				//(dgvProdutos.Rows[i].Cells[CategoriaIndex] as DataGridViewTextBoxCell).Value = "1000";

				//dgvProdutos.Columns["CategoriaProd"].DataPropertyName;

				//dgvProdutos[CategoriaIndex, i].Value = "5000";


				//(dgvProdutos.Rows[i].Cells[CategoriaIndex] as DataGridViewTextBoxCell).Value = produto.Categoria.Nome;

				//MessageBox.Show($"GetType: {b}", "info", MessageBoxButtons.OK);

				//= produto.Categoria.Nome.ToString();
				//dgvProdutos.Rows[i].Cells[CategoriaIndex].Value = produto.Categoria.Nome.ToString();
				//dgvProdutos[CategoriaIndex, i].Value = produto.Categoria.Nome.ToString();

				//TextBox CategoriaCell = new TextBox();

				//CategoriaCell.Text = db.Categorias.Find(produto.idCategoria).Nome;


				//dgvProdutos[CategoriaIndex, i].Value = CategoriaCell;

				//dgvProdutos[IdProdutoIndex, i].Value = db.UnidadesMedida.Find(produto.unidadeMedida).Nome.ToString();
				//produto.Categoria.Nome.ToString();

				i++;
			}
			*/

			//(dgvProdutos.Columns["Categoria"] as DataGridViewComboBoxColumn).DataSource= db.Categorias.ToList();

			//dgvProdutos.Columns["Categoria"]

			//dgvProdutos.Columns["UnidadeMedida"]

			/*
			List<MyEnumType> enumList = stringList.ConvertAll(delegate (string x) {
				return (MyEnumType)Enum.Parse(typeof(MyEnumType), x);
			});
			

			(dgvProdutos.Columns["UnidadeMedida"] as DataGridViewComboBoxColumn).DataSource = db.UnidadesMedida.ToList();
			

			/*
			dgvProdutos.Columns["NotasEntrada"].Visible = false;
			dgvProdutos.Columns["ItensNotaEntrada"].Visible = false;
			dgvProdutos.Columns["NotasSaida"].Visible = false;
			dgvProdutos.Columns["ItensNotaSaida"].Visible = false;
			dgvProdutos.Columns["Fornecedores"].Visible = false;
			dgvProdutos.Columns["Categoria"].Visible = false;
			dgvProdutos.Columns["UnidadeMedida"].Visible = false;
			*/
		}

		private void UpdateCbx(EstoqueContext db) {
			/*
			cbxCategorias.DataSource = db.Categorias.ToList();
			cbxCategorias.DisplayMember = "Nome";
			*/
		}
		private void btnAddCategoria_Click(object sender, EventArgs e) {
			using (FormCategoria formCategoria = new FormCategoria()) {
				formCategoria.Owner = this;
				formCategoria.ShowDialog();
				using (var db = new EstoqueContext()) {
					this.UpdateCbx(db);
				}
			}


		}

		private void dgvProdutos_RowEnter(object sender, DataGridViewCellEventArgs e) {

		}

		private void dgvProdutos_SelectionChanged(object sender, EventArgs e) {
			if (dgvProdutos.SelectedRows.Count > 0) {
				int i = dgvProdutos.SelectedRows[0].Index;
				var linhaSelecionada = dgvProdutos.Rows[i];

				this.produtoSelecionado = linhaSelecionada.DataBoundItem as Produto;

				estoqueMinimo.Text = this.produtoSelecionado.EstoqueMinimo.ToString();
				estoqueMedio.Text = this.produtoSelecionado.EstoqueMedio.ToString();
				estoqueMaximo.Text = this.produtoSelecionado.EstoqueMaximo.ToString();
				//imgProductFixed.Image = this.produtoSelecionado.ImagemProduto;
			}
		}

		private void btnVerFornecedores_Click(object sender, EventArgs e) {
			/*
			FormFornecedores formFornecedores = new FormFornecedores(
														produtoSelecionado.Fornecedores,
														produtoSelecionado.Nome.ToString()
													);

			foreach (var item in produtoSelecionado.Fornecedores) {
				//MessageBox.Show($"CNPJ: {item.CNPJ}\nNome: {item.NomeFantasia}");
			}


			formFornecedores.ShowDialog();

			*/
		}

		private void dgvProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
			if (
				(dgvProdutos.Rows[e.RowIndex].DataBoundItem != null) &&
				(dgvProdutos.Columns[e.ColumnIndex].DataPropertyName.Contains("."))

			   ) {

				e.Value = BindProperty.resolve(
							dgvProdutos.Rows[e.RowIndex].DataBoundItem,
							dgvProdutos.Columns[e.ColumnIndex].DataPropertyName
						);
			}
		}

		private void btnAdicionarProduto_Click(object sender, EventArgs e) {
			FormNewProduto formNewProduto = new FormNewProduto();
			formNewProduto.ShowDialog();

			using (var db = new EstoqueContext()) {
				this.GetAllProduct(db);
			}
		}

		private void dgvProdutos_DoubleClick(object sender, EventArgs e) {
			if (dgvProdutos.SelectedRows.Count > 0) {
				produtoSelecionado = dgvProdutos.SelectedRows[0].DataBoundItem as Produto;
				FormNewProduto formNewProduto = new FormNewProduto(lerProduto: produtoSelecionado);
				formNewProduto.ShowDialog();
			}
		}
	}
}