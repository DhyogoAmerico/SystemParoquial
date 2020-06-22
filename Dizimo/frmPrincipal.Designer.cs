namespace Dizimo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.gpbParoquia = new System.Windows.Forms.GroupBox();
            this.cmdIntencoes = new System.Windows.Forms.Button();
            this.cmdCampanha = new System.Windows.Forms.Button();
            this.cmdDizimo = new System.Windows.Forms.Button();
            this.gpbDiversos = new System.Windows.Forms.GroupBox();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.gpbOutros = new System.Windows.Forms.GroupBox();
            this.cmd04 = new System.Windows.Forms.Button();
            this.cmd03 = new System.Windows.Forms.Button();
            this.cmd02 = new System.Windows.Forms.Button();
            this.cmd01 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdAgenda = new System.Windows.Forms.Button();
            this.cmdGrupoP = new System.Windows.Forms.Button();
            this.gpbParoquia.SuspendLayout();
            this.gpbDiversos.SuspendLayout();
            this.gpbOutros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbParoquia
            // 
            this.gpbParoquia.Controls.Add(this.cmdGrupoP);
            this.gpbParoquia.Controls.Add(this.cmdAgenda);
            this.gpbParoquia.Controls.Add(this.cmdIntencoes);
            this.gpbParoquia.Controls.Add(this.cmdCampanha);
            this.gpbParoquia.Controls.Add(this.cmdDizimo);
            this.gpbParoquia.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbParoquia.Location = new System.Drawing.Point(12, 12);
            this.gpbParoquia.Name = "gpbParoquia";
            this.gpbParoquia.Size = new System.Drawing.Size(232, 345);
            this.gpbParoquia.TabIndex = 3;
            this.gpbParoquia.TabStop = false;
            this.gpbParoquia.Text = "Paróquia ";
            this.gpbParoquia.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmdIntencoes
            // 
            this.cmdIntencoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdIntencoes.Location = new System.Drawing.Point(6, 91);
            this.cmdIntencoes.Name = "cmdIntencoes";
            this.cmdIntencoes.Size = new System.Drawing.Size(220, 27);
            this.cmdIntencoes.TabIndex = 3;
            this.cmdIntencoes.Text = "Intenções";
            this.cmdIntencoes.UseVisualStyleBackColor = true;
            this.cmdIntencoes.Click += new System.EventHandler(this.cmdIntencoes_Click);
            // 
            // cmdCampanha
            // 
            this.cmdCampanha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCampanha.Location = new System.Drawing.Point(6, 57);
            this.cmdCampanha.Name = "cmdCampanha";
            this.cmdCampanha.Size = new System.Drawing.Size(220, 28);
            this.cmdCampanha.TabIndex = 2;
            this.cmdCampanha.Text = "Campanha dos Devotos";
            this.cmdCampanha.UseVisualStyleBackColor = true;
            this.cmdCampanha.Click += new System.EventHandler(this.cmdCampanha_Click);
            // 
            // cmdDizimo
            // 
            this.cmdDizimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDizimo.Location = new System.Drawing.Point(6, 24);
            this.cmdDizimo.Name = "cmdDizimo";
            this.cmdDizimo.Size = new System.Drawing.Size(220, 27);
            this.cmdDizimo.TabIndex = 1;
            this.cmdDizimo.Text = "Dízimo";
            this.cmdDizimo.UseVisualStyleBackColor = true;
            this.cmdDizimo.Click += new System.EventHandler(this.cmdDizimo_Click);
            // 
            // gpbDiversos
            // 
            this.gpbDiversos.Controls.Add(this.cmd4);
            this.gpbDiversos.Controls.Add(this.cmd3);
            this.gpbDiversos.Controls.Add(this.cmd2);
            this.gpbDiversos.Controls.Add(this.cmd1);
            this.gpbDiversos.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDiversos.Location = new System.Drawing.Point(250, 12);
            this.gpbDiversos.Name = "gpbDiversos";
            this.gpbDiversos.Size = new System.Drawing.Size(258, 345);
            this.gpbDiversos.TabIndex = 4;
            this.gpbDiversos.TabStop = false;
            this.gpbDiversos.Text = "Diversos";
            this.gpbDiversos.Enter += new System.EventHandler(this.gpbDiversos_Enter);
            // 
            // cmd4
            // 
            this.cmd4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd4.Location = new System.Drawing.Point(6, 124);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(246, 28);
            this.cmd4.TabIndex = 0;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd3
            // 
            this.cmd3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd3.Location = new System.Drawing.Point(6, 91);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(246, 27);
            this.cmd3.TabIndex = 0;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd2
            // 
            this.cmd2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd2.Location = new System.Drawing.Point(6, 55);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(246, 30);
            this.cmd2.TabIndex = 0;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cmd2_Click);
            // 
            // cmd1
            // 
            this.cmd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd1.Location = new System.Drawing.Point(6, 24);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(246, 27);
            this.cmd1.TabIndex = 0;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // gpbOutros
            // 
            this.gpbOutros.Controls.Add(this.cmd04);
            this.gpbOutros.Controls.Add(this.cmd03);
            this.gpbOutros.Controls.Add(this.cmd02);
            this.gpbOutros.Controls.Add(this.cmd01);
            this.gpbOutros.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOutros.Location = new System.Drawing.Point(514, 12);
            this.gpbOutros.Name = "gpbOutros";
            this.gpbOutros.Size = new System.Drawing.Size(258, 345);
            this.gpbOutros.TabIndex = 4;
            this.gpbOutros.TabStop = false;
            this.gpbOutros.Text = "Outros";
            // 
            // cmd04
            // 
            this.cmd04.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd04.Location = new System.Drawing.Point(6, 124);
            this.cmd04.Name = "cmd04";
            this.cmd04.Size = new System.Drawing.Size(246, 28);
            this.cmd04.TabIndex = 0;
            this.cmd04.Text = "4";
            this.cmd04.UseVisualStyleBackColor = true;
            this.cmd04.Click += new System.EventHandler(this.cmd04_Click);
            // 
            // cmd03
            // 
            this.cmd03.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd03.Location = new System.Drawing.Point(6, 91);
            this.cmd03.Name = "cmd03";
            this.cmd03.Size = new System.Drawing.Size(246, 27);
            this.cmd03.TabIndex = 0;
            this.cmd03.Text = "3";
            this.cmd03.UseVisualStyleBackColor = true;
            this.cmd03.Click += new System.EventHandler(this.cmd03_Click);
            // 
            // cmd02
            // 
            this.cmd02.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd02.Location = new System.Drawing.Point(6, 57);
            this.cmd02.Name = "cmd02";
            this.cmd02.Size = new System.Drawing.Size(246, 28);
            this.cmd02.TabIndex = 0;
            this.cmd02.Text = "2";
            this.cmd02.UseVisualStyleBackColor = true;
            this.cmd02.Click += new System.EventHandler(this.cmd02_Click);
            // 
            // cmd01
            // 
            this.cmd01.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd01.Location = new System.Drawing.Point(6, 24);
            this.cmd01.Name = "cmd01";
            this.cmd01.Size = new System.Drawing.Size(246, 27);
            this.cmd01.TabIndex = 0;
            this.cmd01.Text = "1";
            this.cmd01.UseVisualStyleBackColor = true;
            this.cmd01.Click += new System.EventHandler(this.d_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(827, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(449, 441);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // cmdAgenda
            // 
            this.cmdAgenda.Location = new System.Drawing.Point(6, 124);
            this.cmdAgenda.Name = "cmdAgenda";
            this.cmdAgenda.Size = new System.Drawing.Size(220, 28);
            this.cmdAgenda.TabIndex = 6;
            this.cmdAgenda.Text = "Agenda";
            this.cmdAgenda.UseVisualStyleBackColor = true;
            this.cmdAgenda.Click += new System.EventHandler(this.cmdAgenda_Click);
            // 
            // cmdGrupoP
            // 
            this.cmdGrupoP.Location = new System.Drawing.Point(6, 158);
            this.cmdGrupoP.Name = "cmdGrupoP";
            this.cmdGrupoP.Size = new System.Drawing.Size(220, 27);
            this.cmdGrupoP.TabIndex = 6;
            this.cmdGrupoP.Text = "Grupo Paroquial";
            this.cmdGrupoP.UseVisualStyleBackColor = true;
            this.cmdGrupoP.Click += new System.EventHandler(this.cmdGrupoP_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gpbOutros);
            this.Controls.Add(this.gpbDiversos);
            this.Controls.Add(this.gpbParoquia);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "System Paroquial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gpbParoquia.ResumeLayout(false);
            this.gpbDiversos.ResumeLayout(false);
            this.gpbOutros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbParoquia;
        private System.Windows.Forms.Button cmdDizimo;
        private System.Windows.Forms.GroupBox gpbDiversos;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.GroupBox gpbOutros;
        private System.Windows.Forms.Button cmd03;
        private System.Windows.Forms.Button cmd02;
        private System.Windows.Forms.Button cmd01;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd04;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdCampanha;
        private System.Windows.Forms.Button cmdIntencoes;
        private System.Windows.Forms.Button cmdGrupoP;
        private System.Windows.Forms.Button cmdAgenda;
    }
}

