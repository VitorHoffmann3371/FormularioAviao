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
    public partial class frmAluguel : Form
    {
        public frmAluguel()
        {
            InitializeComponent();
        }

        private void habilitaControlesAluguel(bool status)
        {
            txtClienteID.Enabled = status;
            cmbCliente.Enabled = status;
            dptData.Enabled = status;
            btnCancelarAlug.Enabled = status;
            btnGravarAlug.Enabled = status;
            btnNovoAlug.Enabled = !status;
            btnEditarAlug.Enabled = !status;
            btnRemoverAlug.Enabled = !status;
        }

        private void habilitaControlesItens(bool status)
        {
            txtAviaoID.Enabled = status;
            cmbAviao.Enabled = status;
            dptDataItem.Enabled = false;
            btnDevolverItem.Enabled = status;
            btnCancelarItem.Enabled = status;
            btnGravarItem.Enabled = status;
        }

        private void limpaCamposAlug()
        {
            lblAlugID.Text = "-1";
            txtClienteID.Text = "";
            dptData.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            btnNovoItem.Enabled = false;
        }

        private void limpaCamposItens()
        {
            lblItemID.Text = "-1";
            txtAviaoID.Text = "";
            dptDataItem.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        }

        private void frmAluguel_Load(object sender, EventArgs e)
        {
            //Parte de Alugueis
            CAMADAS.BLL.Clientes bllCli = new CAMADAS.BLL.Clientes();
            cmbCliente.DisplayMember = "nome";
            cmbCliente.ValueMember = "id";
            cmbCliente.DataSource = bllCli.Select();

            CAMADAS.BLL.Aluguel bllAlug = new CAMADAS.BLL.Aluguel();
            dtgAluguel.DataSource = "";
            dtgAluguel.DataSource = bllAlug.Select();
            this.dtgAluguel.DefaultCellStyle.Font = new Font("Arial", 12);

            habilitaControlesAluguel(false);
            limpaCamposAlug();

            //Parte de Itens
            CAMADAS.BLL.Avioes bllAviao = new CAMADAS.BLL.Avioes();
            CAMADAS.BLL.ItensAluguel bllItensAluguel = new CAMADAS.BLL.ItensAluguel();
            cmbAviao.DisplayMember = "modelo";
            cmbAviao.ValueMember = "id";
            cmbAviao.DataSource = bllAviao.Select();

            limpaCamposItens();
            habilitaControlesItens(false);

            dtgItem.DataSource = bllItensAluguel.Select();
            this.dtgItem.DefaultCellStyle.Font = new Font("Arial", 12);

        }

        private void btnNovoAlug_Click(object sender, EventArgs e)
        {
            habilitaControlesAluguel(true);
            limpaCamposAlug();
            cmbCliente.Focus();
        }

        private void btnCancelarAlug_Click(object sender, EventArgs e)
        {
            limpaCamposAlug();
            habilitaControlesAluguel(false);
        }

        private void btnGravarAlug_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
            aluguel.id = Convert.ToInt32(lblAlugID.Text);
            aluguel.clienteID = Convert.ToInt32(txtClienteID.Text);
            aluguel.data = dptData.Value;

            CAMADAS.BLL.Aluguel bllAlug = new CAMADAS.BLL.Aluguel();
            if (lblAlugID.Text == "-1")
                bllAlug.Insert(aluguel);
            else bllAlug.Update(aluguel);


            dtgAluguel.DataSource = bllAlug.Select();

            habilitaControlesAluguel(false);
        }

        private void btnEditarAlug_Click(object sender, EventArgs e)
        {
            habilitaControlesAluguel(true);
            if (lblAlugID.Text != "" && lblAlugID.Text != "-1")
            {
                txtClienteID.Focus();
                CAMADAS.MODEL.Aluguel aluguel = new CAMADAS.MODEL.Aluguel();
                aluguel.id = Convert.ToInt32(lblAlugID.Text);
                aluguel.clienteID = Convert.ToInt32(cmbCliente.SelectedIndex);
                aluguel.data = Convert.ToDateTime(dptData.Value);

                CAMADAS.DAL.Aluguel dalAlug = new CAMADAS.DAL.Aluguel();
                dalAlug.Update(aluguel);

                dtgAluguel.DataSource = "";
                dtgAluguel.DataSource = dalAlug.Select();
            }
            else MessageBox.Show("Não há dados para atualizar", "Atualizar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClienteID.Text = cmbCliente.SelectedValue.ToString();
        }

        private void txtClienteID_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtClienteID.Text != "")
                    cmbCliente.SelectedValue = Convert.ToInt32(txtClienteID.Text);
            }
            catch
            {
                MessageBox.Show("Cliente não encontrado");
                cmbCliente.Focus();
            }
        }

        private void cmbCliente_Leave(object sender, EventArgs e)
        {
            cmbCliente_SelectedIndexChanged(null, null);
        }

        private void dtgAluguel_DoubleClick(object sender, EventArgs e)
        {
            lblAlugID.Text = dtgAluguel.SelectedRows[0].Cells["id"].Value.ToString();
            cmbCliente.SelectedValue = Convert.ToInt32(dtgAluguel.SelectedRows[0].Cells["clienteID"].Value.ToString());
            txtClienteID.Text = dtgAluguel.SelectedRows[0].Cells["clienteID"].Value.ToString();
            dptData.Value = Convert.ToDateTime(dtgAluguel.SelectedRows[0].Cells["data"].Value.ToString());
            btnNovoItem.Enabled = true;

            CAMADAS.BLL.ItensAluguel bllItem = new CAMADAS.BLL.ItensAluguel();
            dtgItem.DataSource = bllItem.SelectByAlug(Convert.ToInt32(lblAlugID.Text));
        }

        private void btnNovoItem_Click(object sender, EventArgs e)
        {
            limpaCamposItens();
            habilitaControlesItens(true);
            dptDataItem.Value = Convert.ToDateTime("01/01/1900");
            cmbAviao.Focus();
        }

        private void cmbAviao_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtAviaoID.Text = cmbAviao.SelectedValue.ToString();
        }

        private void cmbAviao_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbAviao_SelectedIndexChanged(null, null);
            }
            catch
            {
                cmbAviao.Focus();
            }
        }

        private void txtAviaoID_Leave(object sender, EventArgs e)
        {
            try
            {
                cmbAviao.SelectedValue = Convert.ToInt32(txtAviaoID.Text);
            }
            catch
            {
                cmbAviao.Focus();
            }
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            CAMADAS.MODEL.ItensAluguel item = new CAMADAS.MODEL.ItensAluguel();
            item.id = Convert.ToInt32(lblItemID.Text);
            item.aluguelID = Convert.ToInt32(lblAlugID.Text);
            item.aviaoID = Convert.ToInt32(txtAviaoID.Text);
            item.validade = Convert.ToDateTime("01/01/1900");


            CAMADAS.BLL.ItensAluguel bllItens = new CAMADAS.BLL.ItensAluguel();
            if (lblItemID.Text == "-1")
                bllItens.Insert(item);
            dtgItem.DataSource = bllItens.SelectByAlug(Convert.ToInt32(lblAlugID.Text));

        }

        private void btnVoltarAlug_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoverAlug_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Aluguel bllAluguel = new CAMADAS.BLL.Aluguel();
            string msg = "Não há aluguel para remover";
            string modBox = "Remover";
            if (lblAlugID.Text != "" && lblAlugID.Text != "-1")
            {
                msg = "Deseja Remover o Aluguel: " + cmbCliente.Text + " ?";
                DialogResult resposta = MessageBox.Show(msg, modBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblAlugID.Text);
                    bllAluguel.Delete(id);
                }
            }
            else MessageBox.Show(msg, modBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaCamposAlug();
            dtgAluguel.DataSource = "";
            dtgAluguel.DataSource = bllAluguel.Select();
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCamposItens();
            habilitaControlesItens(false);
        }

        private void btnDevolverItem_Click(object sender, EventArgs e)
        {
            CAMADAS.BLL.Aluguel bllAluguel = new CAMADAS.BLL.Aluguel();
            string msg = "Não há aluguel para devolver";
            string modBox = "Devolver";
            if (lblItemID.Text != "" && lblItemID.Text != "-1")
            {
                msg = "Deseja Devolver o Aviao: " + cmbAviao.Text + " ?";
                DialogResult resposta = MessageBox.Show(msg, modBox, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(lblItemID.Text);
                    bllAluguel.Delete(id);
                }
            }
            else MessageBox.Show(msg, modBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            limpaCamposAlug();
            dtgAluguel.DataSource = "";
            dtgAluguel.DataSource = bllAluguel.Select();
        }

        private void dtgItem_DoubleClick(object sender, EventArgs e)
        {

            lblItemID.Text = dtgItem.SelectedRows[0].Cells["idItem"].Value.ToString();
            cmbAviao.SelectedValue = dtgItem.SelectedRows[0].Cells["aluguelID"].Value;
            txtAviaoID.Text = dtgItem.SelectedRows[0].Cells["aluguelID"].Value.ToString();
            dptDataItem.Value = Convert.ToDateTime(dtgItem.SelectedRows[0].Cells["validade"].Value.ToString());
            btnDevolverItem.Enabled = (dptDataItem.Value == Convert.ToDateTime("1/1/1900")) ? true : false;


        }
    }
}
