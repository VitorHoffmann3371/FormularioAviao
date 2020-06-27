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
    public partial class frmAviao : Form
    {
        public frmAviao()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAviao_Load(object sender, EventArgs e)
        {
            CAMADAS.BLL.Avioes bllAvioes = new CAMADAS.BLL.Avioes();
            dtgAvioes.DataSource = "";
            dtgAvioes.DataSource = bllAvioes.Select();
            HabilitaControles(false);
            HabilitaBotoes(true);
            gpbPesquisar.Visible = false;
        }

        private void HabilitaControles(bool status)
        {
            txtModelo.Enabled = status;
            txtFabricante.Enabled = status;
            txtAno.Enabled = status;
            txtCor.Enabled = status;
        }

        private void HabilitaBotoes(bool status)
        {
            btnInserir.Enabled = true;
            btnEditar.Enabled = status;
            btnRemover.Enabled = status;
            btnGravar.Enabled = !status;
            btnCancelar.Enabled = !status;

        }

        private void LimpaControles()
        {
            lblID.Text = "-1";
            txtModelo.Text = "";
            txtFabricante.Text = "";
            txtAno.Text = "";
            txtCor.Text = "";
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            LimpaControles();
            HabilitaBotoes(false);
            HabilitaControles(true);
            lblID.Text = "-1";
            txtModelo.Focus();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaControles();
            HabilitaControles(false);
            HabilitaBotoes(true);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Avioes bllAvioes = new CAMADAS.BLL.Avioes();

            string msg;
            string modMsg;
            if (lblID.Text == "-1")
            {
                msg = "Deseja Adicionar um novo modelo de Avião?";
                modMsg = "Inserir";
            }
            else
            {
                msg = "Deseja Alterar o modelo do Avião?";
                modMsg = "Atualizar";
            }
            DialogResult resposta = MessageBox.Show(msg, modMsg, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(resposta == DialogResult.Yes)
            {
                CAMADAS.MODEL.Avioes aviao = new CAMADAS.MODEL.Avioes();
                aviao.id = Convert.ToInt32(lblID.Text);
                aviao.modelo = txtModelo.Text;
                aviao.fabricante = txtFabricante.Text;
                aviao.ano = Convert.ToInt32(txtAno.Text);
                aviao.cor = txtCor.Text;

                if (lblID.Text == "-1")
                {
                    bllAvioes.Insert(aviao);
                }
                else
                {
                    bllAvioes.Update(aviao);
                }
            }

            LimpaControles();
            HabilitaControles(false);
            HabilitaBotoes(true);
            dtgAvioes.DataSource = "";
            dtgAvioes.DataSource = bllAvioes.Select();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lblID.Text != "" && lblID.Text != "-1")
            {
                HabilitaControles(true);
                HabilitaBotoes(false);
                txtModelo.Focus();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dtgAvioes_DoubleClick(object sender, EventArgs e)
        {
            lblID.Text = dtgAvioes.SelectedRows[0].Cells["id"].Value.ToString();
            txtModelo.Text = dtgAvioes.SelectedRows[0].Cells["modelo"].Value.ToString();
            txtFabricante.Text = dtgAvioes.SelectedRows[0].Cells["fabricante"].Value.ToString();
            txtAno.Text = dtgAvioes.SelectedRows[0].Cells["ano"].Value.ToString();
            txtCor.Text = dtgAvioes.SelectedRows[0].Cells["cor"].Value.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Avioes bllAvioes = new CAMADAS.BLL.Avioes();
            string msg = "Não há Avião para remover";
            string modBox = "Remover";
            if (lblID.Text != "" && lblID.Text != "-1")
            {
                msg = "Deseja Remover o Aviao: " + txtModelo.Text + " ?";
                DialogResult resposta = MessageBox.Show(msg, modBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblID.Text);
                    bllAvioes.Delete(id);
                }
            }
            else MessageBox.Show(msg, modBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            LimpaControles();
            dtgAvioes.DataSource = "";
            dtgAvioes.DataSource = bllAvioes.Select();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            gpbPesquisar.Visible = !gpbPesquisar.Visible;
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Visible = false;
            txtFiltro.Visible = false;
            btnFiltrar.Visible = false;

            CAMADAS.BLL.Avioes bllAviao = new CAMADAS.BLL.Avioes();
            dtgAvioes.DataSource = "";
            dtgAvioes.DataSource = bllAviao.Select();
        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o ID do Aviao";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void rdbModelo_CheckedChanged(object sender, EventArgs e)
        {
            lblFiltrar.Text = "Informe o Modelo do Aviao";
            lblFiltrar.Visible = true;
            txtFiltro.Visible = true;
            btnFiltrar.Visible = true;
            txtFiltro.Focus();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            List<CAMADAS.MODEL.Avioes> lstAviao = new List<CAMADAS.MODEL.Avioes>();
            CAMADAS.BLL.Avioes bllAviao = new CAMADAS.BLL.Avioes();
            if (rdbID.Checked)
            {
                int id = Convert.ToInt32(txtFiltro.Text);
                lstAviao = bllAviao.SelectByID(id);
            }else if (rdbModelo.Checked)
            {
                lstAviao = bllAviao.SelectByModelo(txtFiltro.Text);
            }
            dtgAvioes.DataSource = "";
            dtgAvioes.DataSource = lstAviao;
        }
    }
}
