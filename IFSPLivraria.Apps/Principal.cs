using IFSPLivraria.App.Cadastro;
using IFSPLivraria.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using IFSPLivraria.App.Infra;
using IFSPLivraria.App.Outros;
namespace IFSPLivraria.App
{
    public partial class Principal : MaterialForm
    {
        
            public static Usuario Usuario { get; set; }
            public Principal()
            {
                InitializeComponent();
                CarregaLogin(); 
            }

            private void CarregaLogin()
            {
                var login = ConfigureDI.ServicesProvider!.GetService<Login>();
                if (login != null && !login.IsDisposed)
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        Environment.Exit(0);
                    }
                   
                }
            }


            private void cidadeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCidade>();
        }     


        
     

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroCliente>();
        }   

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEditora>();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroLivro>();
        }
       

         private void emprestimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exibeformulario<CadastroEmprestimo>();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void Exibeformulario<TFormlario>() where TFormlario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormlario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();

            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }
    }
}
