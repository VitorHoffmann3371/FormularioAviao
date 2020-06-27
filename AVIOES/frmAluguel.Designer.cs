namespace AVIOES
{
    partial class frmAluguel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.btnVoltarAlug = new System.Windows.Forms.Button();
            this.btnGravarAlug = new System.Windows.Forms.Button();
            this.btnCancelarAlug = new System.Windows.Forms.Button();
            this.btnRemoverAlug = new System.Windows.Forms.Button();
            this.btnEditarAlug = new System.Windows.Forms.Button();
            this.btnNovoAlug = new System.Windows.Forms.Button();
            this.dtgAluguel = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dptData = new System.Windows.Forms.DateTimePicker();
            this.lblAlugID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDevolverItem = new System.Windows.Forms.Button();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnNovoItem = new System.Windows.Forms.Button();
            this.dtgItem = new System.Windows.Forms.DataGridView();
            this.idItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluguelID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aviaoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dptDataItem = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAviaoID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.cmbAviao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluguel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.splitContainer1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(830, 533);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.txtClienteID);
            this.splitContainer1.Panel1.Controls.Add(this.btnVoltarAlug);
            this.splitContainer1.Panel1.Controls.Add(this.btnGravarAlug);
            this.splitContainer1.Panel1.Controls.Add(this.btnCancelarAlug);
            this.splitContainer1.Panel1.Controls.Add(this.btnRemoverAlug);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditarAlug);
            this.splitContainer1.Panel1.Controls.Add(this.btnNovoAlug);
            this.splitContainer1.Panel1.Controls.Add(this.dtgAluguel);
            this.splitContainer1.Panel1.Controls.Add(this.cmbCliente);
            this.splitContainer1.Panel1.Controls.Add(this.dptData);
            this.splitContainer1.Panel1.Controls.Add(this.lblAlugID);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.splitContainer1.Panel2.Controls.Add(this.btnDevolverItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravarItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelarItem);
            this.splitContainer1.Panel2.Controls.Add(this.btnNovoItem);
            this.splitContainer1.Panel2.Controls.Add(this.dtgItem);
            this.splitContainer1.Panel2.Controls.Add(this.dptDataItem);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtAviaoID);
            this.splitContainer1.Panel2.Controls.Add(this.lblItemID);
            this.splitContainer1.Panel2.Controls.Add(this.cmbAviao);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Size = new System.Drawing.Size(829, 534);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 0;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtClienteID.Location = new System.Drawing.Point(307, 130);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(35, 23);
            this.txtClienteID.TabIndex = 7;
            this.txtClienteID.Leave += new System.EventHandler(this.txtClienteID_Leave);
            // 
            // btnVoltarAlug
            // 
            this.btnVoltarAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnVoltarAlug.Location = new System.Drawing.Point(262, 317);
            this.btnVoltarAlug.Name = "btnVoltarAlug";
            this.btnVoltarAlug.Size = new System.Drawing.Size(80, 30);
            this.btnVoltarAlug.TabIndex = 14;
            this.btnVoltarAlug.Text = "Voltar";
            this.btnVoltarAlug.UseVisualStyleBackColor = true;
            this.btnVoltarAlug.Click += new System.EventHandler(this.btnVoltarAlug_Click);
            // 
            // btnGravarAlug
            // 
            this.btnGravarAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGravarAlug.Location = new System.Drawing.Point(167, 317);
            this.btnGravarAlug.Name = "btnGravarAlug";
            this.btnGravarAlug.Size = new System.Drawing.Size(80, 30);
            this.btnGravarAlug.TabIndex = 10;
            this.btnGravarAlug.Text = "Gravar";
            this.btnGravarAlug.UseVisualStyleBackColor = true;
            this.btnGravarAlug.Click += new System.EventHandler(this.btnGravarAlug_Click);
            // 
            // btnCancelarAlug
            // 
            this.btnCancelarAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarAlug.Location = new System.Drawing.Point(72, 318);
            this.btnCancelarAlug.Name = "btnCancelarAlug";
            this.btnCancelarAlug.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarAlug.TabIndex = 9;
            this.btnCancelarAlug.Text = "Cancelar";
            this.btnCancelarAlug.UseVisualStyleBackColor = true;
            this.btnCancelarAlug.Click += new System.EventHandler(this.btnCancelarAlug_Click);
            // 
            // btnRemoverAlug
            // 
            this.btnRemoverAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnRemoverAlug.Location = new System.Drawing.Point(262, 268);
            this.btnRemoverAlug.Name = "btnRemoverAlug";
            this.btnRemoverAlug.Size = new System.Drawing.Size(80, 30);
            this.btnRemoverAlug.TabIndex = 12;
            this.btnRemoverAlug.Text = "Remover";
            this.btnRemoverAlug.UseVisualStyleBackColor = true;
            this.btnRemoverAlug.Click += new System.EventHandler(this.btnRemoverAlug_Click);
            // 
            // btnEditarAlug
            // 
            this.btnEditarAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnEditarAlug.Location = new System.Drawing.Point(167, 268);
            this.btnEditarAlug.Name = "btnEditarAlug";
            this.btnEditarAlug.Size = new System.Drawing.Size(80, 30);
            this.btnEditarAlug.TabIndex = 11;
            this.btnEditarAlug.Text = "Editar";
            this.btnEditarAlug.UseVisualStyleBackColor = true;
            this.btnEditarAlug.Click += new System.EventHandler(this.btnEditarAlug_Click);
            // 
            // btnNovoAlug
            // 
            this.btnNovoAlug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnNovoAlug.Location = new System.Drawing.Point(72, 268);
            this.btnNovoAlug.Name = "btnNovoAlug";
            this.btnNovoAlug.Size = new System.Drawing.Size(80, 30);
            this.btnNovoAlug.TabIndex = 5;
            this.btnNovoAlug.Text = "Novo";
            this.btnNovoAlug.UseVisualStyleBackColor = true;
            this.btnNovoAlug.Click += new System.EventHandler(this.btnNovoAlug_Click);
            // 
            // dtgAluguel
            // 
            this.dtgAluguel.AllowUserToAddRows = false;
            this.dtgAluguel.AllowUserToDeleteRows = false;
            this.dtgAluguel.AllowUserToResizeColumns = false;
            this.dtgAluguel.AllowUserToResizeRows = false;
            this.dtgAluguel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgAluguel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAluguel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Cliente,
            this.clienteID,
            this.Data});
            this.dtgAluguel.Location = new System.Drawing.Point(9, 354);
            this.dtgAluguel.Name = "dtgAluguel";
            this.dtgAluguel.ReadOnly = true;
            this.dtgAluguel.Size = new System.Drawing.Size(391, 168);
            this.dtgAluguel.TabIndex = 13;
            this.dtgAluguel.DoubleClick += new System.EventHandler(this.dtgAluguel_DoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "id";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Cliente.DataPropertyName = "Cliente";
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Visible = false;
            // 
            // clienteID
            // 
            this.clienteID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clienteID.DataPropertyName = "clienteID";
            this.clienteID.HeaderText = "clienteID";
            this.clienteID.Name = "clienteID";
            this.clienteID.ReadOnly = true;
            this.clienteID.Visible = false;
            // 
            // Data
            // 
            this.Data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 55;
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(141, 128);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(148, 25);
            this.cmbCliente.TabIndex = 6;
            this.cmbCliente.SelectedIndexChanged += new System.EventHandler(this.cmbCliente_SelectedIndexChanged);
            this.cmbCliente.Leave += new System.EventHandler(this.cmbCliente_Leave);
            // 
            // dptData
            // 
            this.dptData.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dptData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptData.Location = new System.Drawing.Point(141, 167);
            this.dptData.Name = "dptData";
            this.dptData.Size = new System.Drawing.Size(201, 23);
            this.dptData.TabIndex = 8;
            // 
            // lblAlugID
            // 
            this.lblAlugID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblAlugID.Location = new System.Drawing.Point(141, 91);
            this.lblAlugID.Name = "lblAlugID";
            this.lblAlugID.Size = new System.Drawing.Size(113, 23);
            this.lblAlugID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(93, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(77, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(73, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Aluguel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alugueis";
            // 
            // btnDevolverItem
            // 
            this.btnDevolverItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnDevolverItem.Location = new System.Drawing.Point(311, 289);
            this.btnDevolverItem.Name = "btnDevolverItem";
            this.btnDevolverItem.Size = new System.Drawing.Size(80, 30);
            this.btnDevolverItem.TabIndex = 21;
            this.btnDevolverItem.Text = "Devolver";
            this.btnDevolverItem.UseVisualStyleBackColor = true;
            this.btnDevolverItem.Click += new System.EventHandler(this.btnDevolverItem_Click);
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnGravarItem.Location = new System.Drawing.Point(214, 289);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(80, 30);
            this.btnGravarItem.TabIndex = 20;
            this.btnGravarItem.Text = "Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = true;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnCancelarItem.Location = new System.Drawing.Point(117, 289);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(80, 30);
            this.btnCancelarItem.TabIndex = 19;
            this.btnCancelarItem.Text = "Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = true;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnNovoItem
            // 
            this.btnNovoItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnNovoItem.Location = new System.Drawing.Point(20, 289);
            this.btnNovoItem.Name = "btnNovoItem";
            this.btnNovoItem.Size = new System.Drawing.Size(80, 30);
            this.btnNovoItem.TabIndex = 18;
            this.btnNovoItem.Text = "Novo";
            this.btnNovoItem.UseVisualStyleBackColor = true;
            this.btnNovoItem.Click += new System.EventHandler(this.btnNovoItem_Click);
            // 
            // dtgItem
            // 
            this.dtgItem.AllowUserToAddRows = false;
            this.dtgItem.AllowUserToDeleteRows = false;
            this.dtgItem.AllowUserToResizeColumns = false;
            this.dtgItem.AllowUserToResizeRows = false;
            this.dtgItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgItem.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dtgItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItem,
            this.modelo,
            this.validade,
            this.aluguelID,
            this.aviaoID});
            this.dtgItem.Location = new System.Drawing.Point(10, 354);
            this.dtgItem.Name = "dtgItem";
            this.dtgItem.ReadOnly = true;
            this.dtgItem.Size = new System.Drawing.Size(391, 168);
            this.dtgItem.TabIndex = 15;
            this.dtgItem.DoubleClick += new System.EventHandler(this.dtgItem_DoubleClick);
            // 
            // idItem
            // 
            this.idItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idItem.DataPropertyName = "id";
            this.idItem.HeaderText = "ID";
            this.idItem.Name = "idItem";
            this.idItem.ReadOnly = true;
            this.idItem.Width = 43;
            // 
            // modelo
            // 
            this.modelo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "MODELO";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            this.modelo.Width = 78;
            // 
            // validade
            // 
            this.validade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.validade.DataPropertyName = "validade";
            this.validade.HeaderText = "VALIDADE";
            this.validade.Name = "validade";
            this.validade.ReadOnly = true;
            this.validade.Width = 85;
            // 
            // aluguelID
            // 
            this.aluguelID.DataPropertyName = "aluguelID";
            this.aluguelID.HeaderText = "ID ALUGUEL";
            this.aluguelID.Name = "aluguelID";
            this.aluguelID.ReadOnly = true;
            this.aluguelID.Visible = false;
            // 
            // aviaoID
            // 
            this.aviaoID.DataPropertyName = "aviaoID";
            this.aviaoID.HeaderText = "ID AVIAO";
            this.aviaoID.Name = "aviaoID";
            this.aviaoID.ReadOnly = true;
            this.aviaoID.Visible = false;
            // 
            // dptDataItem
            // 
            this.dptDataItem.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dptDataItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dptDataItem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dptDataItem.Location = new System.Drawing.Point(136, 167);
            this.dptDataItem.Name = "dptDataItem";
            this.dptDataItem.Size = new System.Drawing.Size(201, 23);
            this.dptDataItem.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(88, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Data";
            // 
            // txtAviaoID
            // 
            this.txtAviaoID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtAviaoID.Location = new System.Drawing.Point(302, 123);
            this.txtAviaoID.Name = "txtAviaoID";
            this.txtAviaoID.Size = new System.Drawing.Size(35, 23);
            this.txtAviaoID.TabIndex = 17;
            this.txtAviaoID.Leave += new System.EventHandler(this.txtAviaoID_Leave);
            // 
            // lblItemID
            // 
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.lblItemID.Location = new System.Drawing.Point(137, 79);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(113, 23);
            this.lblItemID.TabIndex = 16;
            // 
            // cmbAviao
            // 
            this.cmbAviao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.cmbAviao.FormattingEnabled = true;
            this.cmbAviao.Location = new System.Drawing.Point(136, 121);
            this.cmbAviao.Name = "cmbAviao";
            this.cmbAviao.Size = new System.Drawing.Size(160, 25);
            this.cmbAviao.TabIndex = 16;
            this.cmbAviao.SelectedIndexChanged += new System.EventHandler(this.cmbAviao_SelectedIndexChanged);
            this.cmbAviao.Leave += new System.EventHandler(this.cmbAviao_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(82, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Avião";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Itens Alugueis";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(73, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ID Item";
            // 
            // frmAluguel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(830, 533);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAluguel";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aluguel";
            this.Load += new System.EventHandler(this.frmAluguel_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgAluguel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Button btnVoltarAlug;
        private System.Windows.Forms.Button btnGravarAlug;
        private System.Windows.Forms.Button btnCancelarAlug;
        private System.Windows.Forms.Button btnRemoverAlug;
        private System.Windows.Forms.Button btnEditarAlug;
        private System.Windows.Forms.Button btnNovoAlug;
        private System.Windows.Forms.DataGridView dtgAluguel;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DateTimePicker dptData;
        private System.Windows.Forms.Label lblAlugID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnNovoItem;
        private System.Windows.Forms.DataGridView dtgItem;
        private System.Windows.Forms.DateTimePicker dptDataItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAviaoID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.ComboBox cmbAviao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDevolverItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluguelID;
        private System.Windows.Forms.DataGridViewTextBoxColumn aviaoID;
    }
}