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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();

            gpbPesquisa.Visible = false;
        }

        public void LimpaControles()
        {
            txtID.Text = "";
            txtNome.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtCidade.Text = "";
            txtEndereco.Text = "";
            txtUF.Text = "";
            txtTelefone.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.nome = txtNome.Text;
            cliente.cpf = Convert.ToInt32(txtCPF.Text);
            cliente.rg = Convert.ToInt32(txtRG.Text);
            cliente.cidade = txtCidade.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.uf = txtUF.Text;
            cliente.telefone = Convert.ToInt32(txtTelefone.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Insert(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();

            LimpaControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Clientes cliente = new CAMADAS.MODEL.Clientes();
            cliente.id = Convert.ToInt32(txtID.Text);
            cliente.nome = txtNome.Text;
            cliente.cpf = Convert.ToInt32(txtCPF.Text);
            cliente.rg = Convert.ToInt32(txtRG.Text);
            cliente.cidade = txtCidade.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.uf = txtUF.Text;
            cliente.telefone = Convert.ToInt32(txtTelefone.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Update(cliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(txtID.Text);

            CAMADAS.DAL.Clientes dalCli = new CAMADAS.DAL.Clientes();
            dalCli.Delete(idCliente);

            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = dalCli.Select();

            LimpaControles();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisa.Visible = !gpbPesquisa.Visible;
        }

        private void rbdTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            btnFiltrar.Visible = false;

            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = bllCliente.Select();
        }

        private void rbdID_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o ID do Cliente";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o Nome do Cliente";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Clientes> lstCliente = new List<CAMADAS.MODEL.Clientes>();
            CAMADAS.BLL.Clientes bllCliente = new CAMADAS.BLL.Clientes();
            if (rbdID.Checked)
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstCliente = bllCliente.SelectByIDNew(id);
            }else if (rdbNome.Checked)
            {
                lstCliente = bllCliente.SelectByNome(txtFiltro.Text);
            }
            dtGrvClientes.DataSource = "";
            dtGrvClientes.DataSource = lstCliente;
        }

        private void dtGrvClientes_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dtGrvClientes.SelectedRows[0].Cells["id"].Value.ToString();
            txtNome.Text = dtGrvClientes.SelectedRows[0].Cells["nome"].Value.ToString();
            txtCPF.Text = dtGrvClientes.SelectedRows[0].Cells["cpf"].Value.ToString();
            txtRG.Text = dtGrvClientes.SelectedRows[0].Cells["rg"].Value.ToString();
            txtCidade.Text = dtGrvClientes.SelectedRows[0].Cells["cidade"].Value.ToString();
            txtEndereco.Text = dtGrvClientes.SelectedRows[0].Cells["endereco"].Value.ToString();
            txtUF.Text = dtGrvClientes.SelectedRows[0].Cells["uf"].Value.ToString();
            txtTelefone.Text = dtGrvClientes.SelectedRows[0].Cells["telefone"].Value.ToString();
        }
    }
}
