namespace Dizimo
{
    partial class frmListaAgenda
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmdCadastrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisarNome = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel3 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.rdbTel1 = new System.Windows.Forms.RadioButton();
            this.rdbTel2 = new System.Windows.Forms.RadioButton();
            this.rdbTel3 = new System.Windows.Forms.RadioButton();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCadastrar
            // 
            this.cmdCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastrar.Location = new System.Drawing.Point(618, 22);
            this.cmdCadastrar.Name = "cmdCadastrar";
            this.cmdCadastrar.Size = new System.Drawing.Size(158, 28);
            this.cmdCadastrar.TabIndex = 0;
            this.cmdCadastrar.Text = "Cadastrar Contato";
            this.cmdCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdCadastrar.UseVisualStyleBackColor = true;
            this.cmdCadastrar.Click += new System.EventHandler(this.cmdCadastrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(192, 208);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisarNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(449, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por contato";
            // 
            // cmdPesquisar
            // 
            this.cmdPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPesquisar.Location = new System.Drawing.Point(211, 22);
            this.cmdPesquisar.Name = "cmdPesquisar";
            this.cmdPesquisar.Size = new System.Drawing.Size(108, 28);
            this.cmdPesquisar.TabIndex = 1;
            this.cmdPesquisar.Text = "Pesquisar";
            this.cmdPesquisar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdPesquisar.UseVisualStyleBackColor = true;
            this.cmdPesquisar.Click += new System.EventHandler(this.cmdPesquisar_Click);
            // 
            // txtPesquisarNome
            // 
            this.txtPesquisarNome.Location = new System.Drawing.Point(6, 23);
            this.txtPesquisarNome.Name = "txtPesquisarNome";
            this.txtPesquisarNome.Size = new System.Drawing.Size(199, 24);
            this.txtPesquisarNome.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTel3);
            this.groupBox2.Controls.Add(this.rdbTel2);
            this.groupBox2.Controls.Add(this.rdbTel1);
            this.groupBox2.Controls.Add(this.txtTel3);
            this.groupBox2.Controls.Add(this.txtTel1);
            this.groupBox2.Controls.Add(this.txtTel2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(278, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(192, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telefones P/ Contato";
            // 
            // txtTel2
            // 
            this.txtTel2.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTel2.Location = new System.Drawing.Point(41, 49);
            this.txtTel2.MaxLength = 10;
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.ReadOnly = true;
            this.txtTel2.Size = new System.Drawing.Size(134, 22);
            this.txtTel2.TabIndex = 0;
            // 
            // txtTel3
            // 
            this.txtTel3.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTel3.Location = new System.Drawing.Point(41, 77);
            this.txtTel3.MaxLength = 10;
            this.txtTel3.Name = "txtTel3";
            this.txtTel3.ReadOnly = true;
            this.txtTel3.Size = new System.Drawing.Size(134, 22);
            this.txtTel3.TabIndex = 0;
            // 
            // txtTel1
            // 
            this.txtTel1.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTel1.Location = new System.Drawing.Point(41, 21);
            this.txtTel1.MaxLength = 10;
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.ReadOnly = true;
            this.txtTel1.Size = new System.Drawing.Size(134, 22);
            this.txtTel1.TabIndex = 0;
            // 
            // rdbTel1
            // 
            this.rdbTel1.AutoSize = true;
            this.rdbTel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTel1.Location = new System.Drawing.Point(19, 26);
            this.rdbTel1.Name = "rdbTel1";
            this.rdbTel1.Size = new System.Drawing.Size(14, 13);
            this.rdbTel1.TabIndex = 1;
            this.rdbTel1.TabStop = true;
            this.rdbTel1.UseVisualStyleBackColor = true;
            // 
            // rdbTel2
            // 
            this.rdbTel2.AutoSize = true;
            this.rdbTel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTel2.Location = new System.Drawing.Point(19, 54);
            this.rdbTel2.Name = "rdbTel2";
            this.rdbTel2.Size = new System.Drawing.Size(14, 13);
            this.rdbTel2.TabIndex = 1;
            this.rdbTel2.TabStop = true;
            this.rdbTel2.UseVisualStyleBackColor = true;
            // 
            // rdbTel3
            // 
            this.rdbTel3.AutoSize = true;
            this.rdbTel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbTel3.Location = new System.Drawing.Point(19, 82);
            this.rdbTel3.Name = "rdbTel3";
            this.rdbTel3.Size = new System.Drawing.Size(14, 13);
            this.rdbTel3.TabIndex = 1;
            this.rdbTel3.TabStop = true;
            this.rdbTel3.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(289, 310);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(45, 16);
            this.lblGrupo.TabIndex = 5;
            this.lblGrupo.Text = "label1";
            // 
            // txtDescrição
            // 
            this.txtDescrição.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescrição.Location = new System.Drawing.Point(497, 152);
            this.txtDescrição.Multiline = true;
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.ReadOnly = true;
            this.txtDescrição.Size = new System.Drawing.Size(279, 110);
            this.txtDescrição.TabIndex = 6;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Dizimo.Properties.Resources.IcoWhats;
            this.pictureBox1.Location = new System.Drawing.Point(587, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmdLimpar
            // 
            this.cmdLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLimpar.Location = new System.Drawing.Point(47, 390);
            this.cmdLimpar.Name = "cmdLimpar";
            this.cmdLimpar.Size = new System.Drawing.Size(78, 27);
            this.cmdLimpar.TabIndex = 7;
            this.cmdLimpar.Text = "Limpar";
            this.cmdLimpar.UseVisualStyleBackColor = true;
            this.cmdLimpar.Click += new System.EventHandler(this.cmdLimpar_Click);
            // 
            // frmListaAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLimpar);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.lblGrupo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdCadastrar);
            this.Name = "frmListaAgenda";
            this.Text = "Agenda Telefônica";
            this.Load += new System.EventHandler(this.frmListaAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCadastrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdPesquisar;
        private System.Windows.Forms.TextBox txtPesquisarNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTel3;
        private System.Windows.Forms.RadioButton rdbTel2;
        private System.Windows.Forms.RadioButton rdbTel1;
        private System.Windows.Forms.TextBox txtTel3;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button cmdLimpar;
    }
}