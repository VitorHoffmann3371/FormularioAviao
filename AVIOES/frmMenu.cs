using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVIOES
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmCli = new frmClientes();
            frmCli.MdiParent = this;
            frmCli.Show();
        }

        private void aviõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAviao frmAvi = new frmAviao();
            frmAvi.MdiParent = this;
            frmAvi.Show();
        }

        private void aluguelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluguel frmAlug = new frmAluguel();
            frmAlug.MdiParent = this;
            frmAlug.Show();
        }

        private void aviõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelatorioGeral.relAviao();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RELATORIOS.RelatorioGeral.relCliente();
        }
    }
}
