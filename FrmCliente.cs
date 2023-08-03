using MySql.Data.MySqlClient;
using System.Data;

namespace SysVendas
{
    public partial class FrmCliente : Form
    {
        private MySqlConnection conexao;
        private string strConect = "Server=localhost;Database=dbsysvendas;Uid=root;Pwd=#Root2022;";

        public FrmCliente(){
            InitializeComponent();
        }
        private void Conectar()
        {
            conexao = new MySqlConnection(strConect);
            conexao.Open();
        }
        private void Desconectar()
        {
            conexao.Close();
            conexao.Dispose();

        }
        private void CarregaDados()
        {
            Conectar();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM clientes", conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DgvCliente.DataSource = dt;

            Desconectar();
        }

        private void label5_Click(object sender, EventArgs e){

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CboUF.Items.Add("AC");
            CboUF.Items.Add("AL");
            CboUF.Items.Add("AP");
            CboUF.Items.Add("AM");
            CboUF.Items.Add("BA");
            CboUF.Items.Add("CE");
            CboUF.Items.Add("DF");
            CboUF.Items.Add("ES");
            CboUF.Items.Add("GO");
            CboUF.Items.Add("MA");
            CboUF.Items.Add("MT");
            CboUF.Items.Add("MS");
            CboUF.Items.Add("MG");
            CboUF.Items.Add("PA");
            CboUF.Items.Add("PB");
            CboUF.Items.Add("PR");
            CboUF.Items.Add("PE");
            CboUF.Items.Add("PI");
            CboUF.Items.Add("RJ");
            CboUF.Items.Add("RN");
            CboUF.Items.Add("RS");
            CboUF.Items.Add("RO");
            CboUF.Items.Add("RR");
            CboUF.Items.Add("SC");
            CboUF.Items.Add("SP");
            CboUF.Items.Add("SE");
            CboUF.Items.Add("TO");

            CarregaDados();
        }

        private void DgvCliente_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridViewRow linha = DgvCliente.CurrentRow;

            TxtIDCliente.Text = linha.Cells[0].Value.ToString();

            TxtNome.Text = linha.Cells[1].Value.ToString();

            TxtEndereco.Text = linha.Cells[2].Value.ToString();

            TxtBairro.Text = linha.Cells[3].Value.ToString();

            TxtCidade.Text = linha.Cells[4].Value.ToString();

            CboUF.Text = linha.Cells[5].Value.ToString();

            TxtFone.Text = linha.Cells[6].Value.ToString();

            TxtEmail.Text = linha.Cells[7].Value.ToString();

        }

        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Conectar();

            int idCliente = Convert.ToInt32(TxtIDCliente.Text);
            string nome = TxtNome.Text;
            string endereco = TxtEndereco.Text;
            string bairro = TxtBairro.Text;
            string cidade = TxtCidade.Text;
            string uf = CboUF.Text;
            string fone = TxtFone.Text;
            string email = TxtEmail.Text;

            string cmdsql = "UPDATE clientes SET nome=@nome, endereco=@endereco," +
                "bairro=@bairro, cidade=@cidade, uf=@uf, fone=@fone, email=@email WHERE idClientes=@idClientes";

            MySqlCommand cmd = new MySqlCommand(cmdsql, conexao);
            cmd.Parameters.AddWithValue("@idClientes", idCliente);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();

            Desconectar();
            CarregaDados();


        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Conectar();
            int idCliente = Convert.ToInt32(TxtIDCliente.Text);
            string cmdsql = "DELETE FROM clientes WHERE idClientes=@idClientes";

            MySqlCommand cmd = new MySqlCommand(cmdsql, conexao);
            cmd.Parameters.AddWithValue("@idClientes", idCliente);
            cmd.ExecuteNonQuery();

            Desconectar();
            CarregaDados();

        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Conectar();

            string nome = TxtNome.Text;
            string endereco = TxtEndereco.Text;
            string bairro = TxtBairro.Text;
            string cidade = TxtCidade.Text;
            string uf = CboUF.Text;
            string fone = TxtFone.Text;
            string email = TxtEmail.Text;

            string cmdsql = "INSERT INTO clientes (nome, endereco, bairro, cidade, uf, fone, email)"+
                "VALUES (@nome, @endereco, @bairro, @cidade, @uf, @fone, @email)";

            MySqlCommand cmd = new MySqlCommand(cmdsql, conexao);
            
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@uf", uf);
            cmd.Parameters.AddWithValue("@fone", fone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.ExecuteNonQuery();

            Desconectar();
            CarregaDados();

        }
    }
}
