using SysEstoque.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysEstoque {
	public partial class FormAdmUnidMedida : Form {
		private UnidadeMedida unidadeMedidaSelecionada = new UnidadeMedida();
		private int estadoAtual = 0;
		private enum EstadoUsuario {
			CRIANDO = 0,
			EDITANDO = 1
		}

		public FormAdmUnidMedida() {
			InitializeComponent();
			LoadUnidMedidaData();
		}

		private void LoadUnidMedidaData() {
			dgvUnidMedida.Rows.Clear();

			using (var db = new EstoqueContext()) {
				BindingSource binding = new BindingSource();
				binding.DataSource = db.UnidadesMedida.ToList();

				dgvUnidMedida.DataSource = binding;
				;

				//dgvUnidMedida.Columns[1].Width = 35;
			}

		}

		private void FormAdmUnidMedida_Load(object sender, EventArgs e) {

		}

		private void btnSave_Click(object sender, EventArgs e) {

			if (estadoAtual == (int)EstadoUsuario.CRIANDO) {
				unidadeMedidaSelecionada.Nome = nomeUnidMedida.Text;
				unidadeMedidaSelecionada.Descricao = descricaoUnidMedida.Text;

				int highId = 0;

				using (var db = new EstoqueContext()) {
					bool flagSucces = true;
					foreach (var unid in db.UnidadesMedida.ToList()) {

						if (unid.Nome == unidadeMedidaSelecionada.Nome)
							flagSucces = false;

						if (highId < unid.Id) {
							highId = unid.Id;
						}
					}

					if (flagSucces) {
						unidadeMedidaSelecionada.Id = ++highId;

						db.UnidadesMedida.Add(unidadeMedidaSelecionada);
						db.SaveChanges();

						LoadUnidMedidaData();
					} else {
						MessageBox.Show($"Erro: Sigla '{unidadeMedidaSelecionada.Nome}' já está cadastrado.");
					}
				}

			} else {
				unidadeMedidaSelecionada.Nome = nomeUnidMedida.Text;
				unidadeMedidaSelecionada.Descricao = descricaoUnidMedida.Text;
				unidadeMedidaSelecionada.Id = Convert.ToInt32(txbId.Text);

				using (var db = new EstoqueContext()) {
					db.UnidadesMedida.Update(unidadeMedidaSelecionada);
					db.SaveChanges();
				}

				//btnSave.Text = "Salvar";
				btnLimparText_Click(null, null);

				dgvUnidMedida.Refresh();
			}

			this.estadoAtual = (int)EstadoUsuario.CRIANDO;
		}

		private void dgvUnidMedida_CellClick(object sender, DataGridViewCellEventArgs e) {
		}

		private void btnEditar_Click(object sender, EventArgs e) {


			if (dgvUnidMedida.SelectedRows.Count > 0) {
				unidadeMedidaSelecionada = (UnidadeMedida)dgvUnidMedida.SelectedRows[0].DataBoundItem;

				int Edit = 1;

				if ((nomeUnidMedida.Text.Trim().Length != 0 ||
					descricaoUnidMedida.Text.Trim().Length != 0) &&
					txbId.Text == ""
					) {
					Edit = (int)MessageBox.Show("Ao editar a unidade selecionada os dados que estão sendo inseridos vão ser deletado", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
				}

				if (Edit == (int)DialogResult.OK) {
					btnSave.Text = "Atualizar";
					this.estadoAtual = (int)EstadoUsuario.EDITANDO;

					nomeUnidMedida.Text = unidadeMedidaSelecionada.Nome;
					descricaoUnidMedida.Text = unidadeMedidaSelecionada.Descricao;
					txbId.Text = unidadeMedidaSelecionada.Id.ToString();
				}
				/*
					using (var db = new EstoqueContext()) {

						db.UnidadesMedida.Update(unidadeMedidaSelecionada);
					}
				*/
			}

		}

		private void btnExcluir_Click(object sender, EventArgs e) {
			if (dgvUnidMedida.SelectedRows.Count > 0) {
				UnidadeMedida unid = dgvUnidMedida.SelectedRows[0].DataBoundItem as UnidadeMedida;
				int indexLinha = dgvUnidMedida.SelectedRows[0].Index;

				if (MessageBox.Show(
						$"Você relamente deseja excluir a unidade {unid.Nome}",
						"Atanção",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Question
						) == DialogResult.Yes
					) {

					using (var db = new EstoqueContext()) {
						db.UnidadesMedida.Remove(unid);
						int sucess = db.SaveChanges();


						if (sucess > 0) {
							LoadUnidMedidaData();
						} else {
							MessageBox.Show("Erro ao excluira unidade de medida", "Atenção");
						}

					}
				}
			}
		}

		private void btnLimparText_Click(object sender, EventArgs e) {
			this.estadoAtual = (int)EstadoUsuario.CRIANDO;

			nomeUnidMedida.Text = "";
			descricaoUnidMedida.Text = "";
			txbId.Text = "";

			btnSave.Text = "Salvar";
		}

		private void FormAdmUnidMedida_FormClosed(object sender, FormClosedEventArgs e) {

		}
	}
}
