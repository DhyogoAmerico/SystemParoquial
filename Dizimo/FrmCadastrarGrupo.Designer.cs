namespace Dizimo
{
    partial class FrmCadastrarGrupo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarGrupo));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCooGrupo = new System.Windows.Forms.TextBox();
            this.cmbGrupos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdCadEdit = new System.Windows.Forms.Button();
            this.rdbNovo = new System.Windows.Forms.RadioButton();
            this.rdbAtalizar = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do grupo: ";
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeGrupo.Location = new System.Drawing.Point(28, 241);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(430, 24);
            this.txtNomeGrupo.TabIndex = 4;
            this.txtNomeGrupo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome do Coordenador: ";
            // 
            // txtCooGrupo
            // 
            this.txtCooGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCooGrupo.Location = new System.Drawing.Point(28, 326);
            this.txtCooGrupo.Name = "txtCooGrupo";
            this.txtCooGrupo.Size = new System.Drawing.Size(430, 24);
            this.txtCooGrupo.TabIndex = 5;
            // 
            // cmbGrupos
            // 
            this.cmbGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGrupos.FormattingEnabled = true;
            this.cmbGrupos.Location = new System.Drawing.Point(222, 148);
            this.cmbGrupos.Name = "cmbGrupos";
            this.cmbGrupos.Size = new System.Drawing.Size(236, 26);
            this.cmbGrupos.TabIndex = 3;
            this.cmbGrupos.SelectedIndexChanged += new System.EventHandler(this.cmbGrupos_SelectedIndexChanged);
            this.cmbGrupos.Click += new System.EventHandler(this.cmbGrupos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupos existentes:";
            // 
            // cmdCadEdit
            // 
            this.cmdCadEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCadEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadEdit.Location = new System.Drawing.Point(164, 405);
            this.cmdCadEdit.Name = "cmdCadEdit";
            this.cmdCadEdit.Size = new System.Drawing.Size(168, 28);
            this.cmdCadEdit.TabIndex = 6;
            this.cmdCadEdit.Text = "Cadastrar/Editar";
            this.cmdCadEdit.UseVisualStyleBackColor = true;
            this.cmdCadEdit.Click += new System.EventHandler(this.cmdCadEdit_Click);
            // 
            // rdbNovo
            // 
            this.rdbNovo.AutoSize = true;
            this.rdbNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNovo.Location = new System.Drawing.Point(28, 124);
            this.rdbNovo.Name = "rdbNovo";
            this.rdbNovo.Size = new System.Drawing.Size(108, 22);
            this.rdbNovo.TabIndex = 1;
            this.rdbNovo.TabStop = true;
            this.rdbNovo.Text = "Novo Grupo";
            this.rdbNovo.UseVisualStyleBackColor = true;
            this.rdbNovo.CheckedChanged += new System.EventHandler(this.rdbNovo_CheckedChanged);
            // 
            // rdbAtalizar
            // 
            this.rdbAtalizar.AutoSize = true;
            this.rdbAtalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAtalizar.Location = new System.Drawing.Point(28, 152);
            this.rdbAtalizar.Name = "rdbAtalizar";
            this.rdbAtalizar.Size = new System.Drawing.Size(128, 22);
            this.rdbAtalizar.TabIndex = 2;
            this.rdbAtalizar.TabStop = true;
            this.rdbAtalizar.Text = "Atualizar Grupo";
            this.rdbAtalizar.UseVisualStyleBackColor = true;
            this.rdbAtalizar.CheckedChanged += new System.EventHandler(this.rdbAtalizar_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cadastrar/Editar Grupo Paroquial";
            // 
            // FrmCadastrarGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 460);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rdbAtalizar);
            this.Controls.Add(this.rdbNovo);
            this.Controls.Add(this.cmdCadEdit);
            this.Controls.Add(this.cmbGrupos);
            this.Controls.Add(this.txtCooGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastrarGrupo";
            this.Text = "Cadastrar/Editar Grupo Paroquial";
            this.Load += new System.EventHandler(this.FrmCadastrarGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCooGrupo;
        private System.Windows.Forms.ComboBox cmbGrupos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdCadEdit;
        private System.Windows.Forms.RadioButton rdbNovo;
        private System.Windows.Forms.RadioButton rdbAtalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}