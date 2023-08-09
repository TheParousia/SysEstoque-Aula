using SysEstoque.Models;

namespace SysEstoque
{
    public partial class FormLogin : Form{

        Usuario usuario = new Usuario();
        ICollection<ItemNotaEntrada> itensNotaEntrada = new List<ItemNotaEntrada>();

        public FormLogin(){
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogar_Click(object sender, EventArgs e){
            using (var db = new EstoqueContext()){
                //db.Usuario.FirstOrDefault()    
            }
        }
    }
}