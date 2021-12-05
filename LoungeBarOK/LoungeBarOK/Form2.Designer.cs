
namespace LoungeBarOK
{
    partial class btSalvar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btSalvar));
            this.lblCadCliente = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbCPF = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblAniver = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.mskAniver = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.dgCadCliente = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pcBoxLogo = new System.Windows.Forms.PictureBox();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAniver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCadCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCadCliente
            // 
            this.lblCadCliente.AutoSize = true;
            this.lblCadCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCadCliente.Location = new System.Drawing.Point(200, 27);
            this.lblCadCliente.Name = "lblCadCliente";
            this.lblCadCliente.Size = new System.Drawing.Size(198, 33);
            this.lblCadCliente.TabIndex = 16;
            this.lblCadCliente.Text = "Cadastro de Clientes";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(12, 174);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 19);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail:";
            // 
            // lbCPF
            // 
            this.lbCPF.AutoSize = true;
            this.lbCPF.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCPF.ForeColor = System.Drawing.Color.Black;
            this.lbCPF.Location = new System.Drawing.Point(12, 134);
            this.lbCPF.Name = "lbCPF";
            this.lbCPF.Size = new System.Drawing.Size(31, 19);
            this.lbCPF.TabIndex = 18;
            this.lbCPF.Text = "CPF:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(12, 94);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 19);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "Nome Cliente:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.Black;
            this.lblTelefone.Location = new System.Drawing.Point(254, 218);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(56, 19);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblAniver
            // 
            this.lblAniver.AutoSize = true;
            this.lblAniver.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAniver.ForeColor = System.Drawing.Color.Black;
            this.lblAniver.Location = new System.Drawing.Point(12, 218);
            this.lblAniver.Name = "lblAniver";
            this.lblAniver.Size = new System.Drawing.Size(73, 19);
            this.lblAniver.TabIndex = 21;
            this.lblAniver.Text = "Aniversário:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 20);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 20);
            this.textBox2.TabIndex = 24;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(118, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(375, 20);
            this.textBox3.TabIndex = 25;
            // 
            // mskAniver
            // 
            this.mskAniver.Location = new System.Drawing.Point(118, 216);
            this.mskAniver.Mask = "00/00/0000";
            this.mskAniver.Name = "mskAniver";
            this.mskAniver.Size = new System.Drawing.Size(100, 20);
            this.mskAniver.TabIndex = 26;
            this.mskAniver.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(327, 216);
            this.maskedTextBox2.Mask = "(00)0 0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 27;
            // 
            // dgCadCliente
            // 
            this.dgCadCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCadCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colNomeCliente,
            this.colCPF,
            this.colEmail,
            this.colAniver,
            this.colTelefone});
            this.dgCadCliente.Location = new System.Drawing.Point(12, 306);
            this.dgCadCliente.Name = "dgCadCliente";
            this.dgCadCliente.Size = new System.Drawing.Size(675, 203);
            this.dgCadCliente.TabIndex = 28;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(59, 265);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 21);
            this.txtId.TabIndex = 30;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.Black;
            this.lblId.Location = new System.Drawing.Point(12, 268);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(25, 19);
            this.lblId.TabIndex = 29;
            this.lblId.Text = "ID: ";
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.Black;
            this.lblLogo.Location = new System.Drawing.Point(541, 120);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(122, 25);
            this.lblLogo.TabIndex = 36;
            this.lblLogo.Text = "samambaia bar";
            // 
            // pcBoxLogo
            // 
            this.pcBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcBoxLogo.Image")));
            this.pcBoxLogo.Location = new System.Drawing.Point(546, 12);
            this.pcBoxLogo.Name = "pcBoxLogo";
            this.pcBoxLogo.Size = new System.Drawing.Size(96, 99);
            this.pcBoxLogo.TabIndex = 35;
            this.pcBoxLogo.TabStop = false;
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.SaddleBrown;
            this.btExcluir.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExcluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExcluir.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btExcluir.Location = new System.Drawing.Point(556, 268);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(86, 31);
            this.btExcluir.TabIndex = 34;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btExcluir.UseVisualStyleBackColor = false;
            // 
            // btLimpar
            // 
            this.btLimpar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btLimpar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLimpar.Location = new System.Drawing.Point(556, 231);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(86, 31);
            this.btLimpar.TabIndex = 33;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btLimpar.UseVisualStyleBackColor = false;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btEditar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEditar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditar.Location = new System.Drawing.Point(556, 196);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(86, 29);
            this.btEditar.TabIndex = 32;
            this.btEditar.Text = "Editar";
            this.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btAdicionar.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAdicionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btAdicionar.Location = new System.Drawing.Point(556, 158);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(86, 32);
            this.btAdicionar.TabIndex = 31;
            this.btAdicionar.Text = "Salvar";
            this.btAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btAdicionar.UseVisualStyleBackColor = false;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 30;
            // 
            // colNomeCliente
            // 
            this.colNomeCliente.HeaderText = "Cliente";
            this.colNomeCliente.Name = "colNomeCliente";
            this.colNomeCliente.Width = 200;
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // colAniver
            // 
            this.colAniver.HeaderText = "Aniver";
            this.colAniver.Name = "colAniver";
            this.colAniver.Width = 70;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            // 
            // btSalvar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(693, 499);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.pcBoxLogo);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgCadCliente);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.mskAniver);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblAniver);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lbCPF);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblCadCliente);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "btSalvar";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgCadCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCadCliente;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbCPF;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblAniver;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox mskAniver;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dgCadCliente;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pcBoxLogo;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAniver;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
    }
}