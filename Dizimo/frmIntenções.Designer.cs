namespace Dizimo
{
    partial class frmIntenções
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntenções));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdImprimir = new System.Windows.Forms.Button();
            this.cmdRefazer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIntenção = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.lstLouvor = new System.Windows.Forms.ListBox();
            this.lstAcaoGracas = new System.Windows.Forms.ListBox();
            this.lstSaude = new System.Windows.Forms.ListBox();
            this.lstFalecidos = new System.Windows.Forms.ListBox();
            this.lst7dia = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb09 = new System.Windows.Forms.RadioButton();
            this.rdb19 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criar folha de intenções";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Dia/Data";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Location = new System.Drawing.Point(670, 594);
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(117, 31);
            this.cmdImprimir.TabIndex = 5;
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.UseVisualStyleBackColor = true;
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // cmdRefazer
            // 
            this.cmdRefazer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdRefazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRefazer.Location = new System.Drawing.Point(888, 594);
            this.cmdRefazer.Name = "cmdRefazer";
            this.cmdRefazer.Size = new System.Drawing.Size(117, 31);
            this.cmdRefazer.TabIndex = 6;
            this.cmdRefazer.Text = "Refazer";
            this.cmdRefazer.UseVisualStyleBackColor = true;
            this.cmdRefazer.Click += new System.EventHandler(this.cmdRefazer_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(268, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(27, 292);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(421, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Intenção:";
            // 
            // cbIntenção
            // 
            this.cbIntenção.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIntenção.FormattingEnabled = true;
            this.cbIntenção.Items.AddRange(new object[] {
            "Em louver:",
            "Em ação de graças:",
            "Pela saúde:",
            "Pelos falecidos:",
            "7º dia de falecimento:"});
            this.cbIntenção.Location = new System.Drawing.Point(27, 228);
            this.cbIntenção.Name = "cbIntenção";
            this.cbIntenção.Size = new System.Drawing.Size(268, 28);
            this.cbIntenção.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(551, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Em louvor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(824, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Em ação de graças:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(551, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Pela saúde de:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(824, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Pelos falecidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(551, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "7º dia de falecimento:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(60, 391);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(319, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Aniversariantes (Nascimento e Casamento):";
            // 
            // cmdOK
            // 
            this.cmdOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Location = new System.Drawing.Point(454, 291);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(42, 27);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // lstLouvor
            // 
            this.lstLouvor.FormattingEnabled = true;
            this.lstLouvor.Location = new System.Drawing.Point(555, 151);
            this.lstLouvor.Name = "lstLouvor";
            this.lstLouvor.Size = new System.Drawing.Size(267, 95);
            this.lstLouvor.TabIndex = 9;
            this.lstLouvor.DoubleClick += new System.EventHandler(this.lstLouvor_DoubleClick);
            // 
            // lstAcaoGracas
            // 
            this.lstAcaoGracas.FormattingEnabled = true;
            this.lstAcaoGracas.Location = new System.Drawing.Point(828, 151);
            this.lstAcaoGracas.Name = "lstAcaoGracas";
            this.lstAcaoGracas.Size = new System.Drawing.Size(267, 95);
            this.lstAcaoGracas.TabIndex = 10;
            this.lstAcaoGracas.DoubleClick += new System.EventHandler(this.lstAcaoGracas_DoubleClick);
            // 
            // lstSaude
            // 
            this.lstSaude.FormattingEnabled = true;
            this.lstSaude.Location = new System.Drawing.Point(555, 292);
            this.lstSaude.Name = "lstSaude";
            this.lstSaude.Size = new System.Drawing.Size(267, 95);
            this.lstSaude.TabIndex = 10;
            this.lstSaude.DoubleClick += new System.EventHandler(this.lstSaude_DoubleClick);
            // 
            // lstFalecidos
            // 
            this.lstFalecidos.FormattingEnabled = true;
            this.lstFalecidos.Location = new System.Drawing.Point(828, 292);
            this.lstFalecidos.Name = "lstFalecidos";
            this.lstFalecidos.Size = new System.Drawing.Size(267, 95);
            this.lstFalecidos.TabIndex = 10;
            this.lstFalecidos.DoubleClick += new System.EventHandler(this.lstFalecidos_DoubleClick);
            // 
            // lst7dia
            // 
            this.lst7dia.FormattingEnabled = true;
            this.lst7dia.Location = new System.Drawing.Point(555, 433);
            this.lst7dia.Name = "lst7dia";
            this.lst7dia.Size = new System.Drawing.Size(267, 95);
            this.lst7dia.TabIndex = 10;
            this.lst7dia.DoubleClick += new System.EventHandler(this.lst7dia_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb09);
            this.groupBox1.Controls.Add(this.rdb19);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(354, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hora:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb09
            // 
            this.rdb09.AutoSize = true;
            this.rdb09.Location = new System.Drawing.Point(22, 56);
            this.rdb09.Name = "rdb09";
            this.rdb09.Size = new System.Drawing.Size(75, 24);
            this.rdb09.TabIndex = 1;
            this.rdb09.TabStop = true;
            this.rdb09.Text = "às 09h";
            this.rdb09.UseVisualStyleBackColor = true;
            // 
            // rdb19
            // 
            this.rdb19.AutoSize = true;
            this.rdb19.Location = new System.Drawing.Point(22, 26);
            this.rdb19.Name = "rdb19";
            this.rdb19.Size = new System.Drawing.Size(75, 24);
            this.rdb19.TabIndex = 0;
            this.rdb19.TabStop = true;
            this.rdb19.Text = "às 19h";
            this.rdb19.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmIntenções
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1123, 660);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lst7dia);
            this.Controls.Add(this.lstFalecidos);
            this.Controls.Add(this.lstSaude);
            this.Controls.Add(this.lstAcaoGracas);
            this.Controls.Add(this.lstLouvor);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cbIntenção);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmdRefazer);
            this.Controls.Add(this.cmdImprimir);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "frmIntenções";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intenções";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdImprimir;
        private System.Windows.Forms.Button cmdRefazer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIntenção;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdOK;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ListBox lstLouvor;
        private System.Windows.Forms.ListBox lstAcaoGracas;
        private System.Windows.Forms.ListBox lstSaude;
        private System.Windows.Forms.ListBox lstFalecidos;
        private System.Windows.Forms.ListBox lst7dia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb09;
        private System.Windows.Forms.RadioButton rdb19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}