namespace Dizimo
{
    partial class frmAddContato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContato));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.gpbTelefones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel3 = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGrupo = new System.Windows.Forms.ComboBox();
            this.checkGrupo = new System.Windows.Forms.CheckBox();
            this.cmdAdicionar = new System.Windows.Forms.Button();
            this.cmbPesquisar = new System.Windows.Forms.ComboBox();
            this.cmdRemover = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkPesquisar = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpbTelefones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeContato.Location = new System.Drawing.Point(36, 154);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(394, 24);
            this.txtNomeContato.TabIndex = 1;
            // 
            // gpbTelefones
            // 
            this.gpbTelefones.Controls.Add(this.label5);
            this.gpbTelefones.Controls.Add(this.label4);
            this.gpbTelefones.Controls.Add(this.label3);
            this.gpbTelefones.Controls.Add(this.txtTel3);
            this.gpbTelefones.Controls.Add(this.txtTel2);
            this.gpbTelefones.Controls.Add(this.txtTel1);
            this.gpbTelefones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbTelefones.Location = new System.Drawing.Point(457, 143);
            this.gpbTelefones.Name = "gpbTelefones";
            this.gpbTelefones.Size = new System.Drawing.Size(241, 159);
            this.gpbTelefones.TabIndex = 2;
            this.gpbTelefones.TabStop = false;
            this.gpbTelefones.Text = "Telefones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "2-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "3-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "1- ";
            // 
            // txtTel3
            // 
            this.txtTel3.Location = new System.Drawing.Point(55, 120);
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.Size = new System.Drawing.Size(156, 24);
            this.txtTel3.TabIndex = 4;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(55, 74);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(156, 24);
            this.txtTel2.TabIndex = 3;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(55, 30);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(156, 24);
            this.txtTel1.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(36, 225);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(394, 77);
            this.txtDescricao.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição Adicional:";
            // 
            // cmbGrupo
            // 
            this.cmbGrupo.Enabled = false;
            this.cmbGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupo.FormattingEnabled = true;
            this.cmbGrupo.Location = new System.Drawing.Point(36, 337);
            this.cmbGrupo.Name = "cmbGrupo";
            this.cmbGrupo.Size = new System.Drawing.Size(243, 26);
            this.cmbGrupo.TabIndex = 7;
            this.cmbGrupo.SelectedIndexChanged += new System.EventHandler(this.cmbGrupo_SelectedIndexChanged);
            // 
            // checkGrupo
            // 
            this.checkGrupo.AutoSize = true;
            this.checkGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkGrupo.Location = new System.Drawing.Point(36, 314);
            this.checkGrupo.Name = "checkGrupo";
            this.checkGrupo.Size = new System.Drawing.Size(139, 22);
            this.checkGrupo.TabIndex = 6;
            this.checkGrupo.Text = "Grupo Paroquial:";
            this.checkGrupo.UseVisualStyleBackColor = true;
            this.checkGrupo.CheckedChanged += new System.EventHandler(this.checkGrupo_CheckedChanged);
            // 
            // cmdAdicionar
            // 
            this.cmdAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdicionar.Location = new System.Drawing.Point(313, 423);
            this.cmdAdicionar.Name = "cmdAdicionar";
            this.cmdAdicionar.Size = new System.Drawing.Size(100, 27);
            this.cmdAdicionar.TabIndex = 8;
            this.cmdAdicionar.Text = "Salvar";
            this.cmdAdicionar.UseVisualStyleBackColor = true;
            this.cmdAdicionar.Click += new System.EventHandler(this.cmdAdicionar_Click);
            // 
            // cmbPesquisar
            // 
            this.cmbPesquisar.Enabled = false;
            this.cmbPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPesquisar.FormattingEnabled = true;
            this.cmbPesquisar.Location = new System.Drawing.Point(27, 34);
            this.cmbPesquisar.Name = "cmbPesquisar";
            this.cmbPesquisar.Size = new System.Drawing.Size(273, 26);
            this.cmbPesquisar.TabIndex = 11;
            this.cmbPesquisar.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisar_SelectedIndexChanged);
            // 
            // cmdRemover
            // 
            this.cmdRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemover.Location = new System.Drawing.Point(36, 423);
            this.cmdRemover.Name = "cmdRemover";
            this.cmdRemover.Size = new System.Drawing.Size(100, 27);
            this.cmdRemover.TabIndex = 9;
            this.cmdRemover.Text = "Remover";
            this.cmdRemover.UseVisualStyleBackColor = true;
            this.cmdRemover.Click += new System.EventHandler(this.cmdRemover_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPesquisar);
            this.groupBox1.Controls.Add(this.cmbPesquisar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(392, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 76);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione para editar um contato";
            // 
            // checkPesquisar
            // 
            this.checkPesquisar.AutoSize = true;
            this.checkPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPesquisar.Location = new System.Drawing.Point(6, 40);
            this.checkPesquisar.Name = "checkPesquisar";
            this.checkPesquisar.Size = new System.Drawing.Size(15, 14);
            this.checkPesquisar.TabIndex = 10;
            this.checkPesquisar.UseVisualStyleBackColor = true;
            this.checkPesquisar.CheckedChanged += new System.EventHandler(this.checkPesquisar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 47);
            this.label6.MaximumSize = new System.Drawing.Size(0, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Adicionar ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(144, 71);
            this.label7.MaximumSize = new System.Drawing.Size(0, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Contato na Agenda";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdRemover);
            this.Controls.Add(this.cmdAdicionar);
            this.Controls.Add(this.checkGrupo);
            this.Controls.Add(this.cmbGrupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.gpbTelefones);
            this.Controls.Add(this.txtNomeContato);
            this.Controls.Add(this.label1);
            this.Name = "frmAddContato";
            this.Text = "Adicionar contato";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            this.gpbTelefones.ResumeLayout(false);
            this.gpbTelefones.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.GroupBox gpbTelefones;
        private System.Windows.Forms.TextBox txtTel3;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGrupo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkGrupo;
        private System.Windows.Forms.Button cmdAdicionar;
        private System.Windows.Forms.ComboBox cmbPesquisar;
        private System.Windows.Forms.Button cmdRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkPesquisar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}