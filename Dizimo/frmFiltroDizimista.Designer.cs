namespace Dizimo
{
    partial class frmFiltroDizimista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomeForm = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmdImprimirComEnd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmdImprimirListaNomes = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeForm
            // 
            this.lblNomeForm.AutoSize = true;
            this.lblNomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblNomeForm.Location = new System.Drawing.Point(70, 34);
            this.lblNomeForm.Name = "lblNomeForm";
            this.lblNomeForm.Size = new System.Drawing.Size(70, 26);
            this.lblNomeForm.TabIndex = 0;
            this.lblNomeForm.Text = "label1";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.monthCalendar1.Location = new System.Drawing.Point(112, 204);
            this.monthCalendar1.MaxSelectionCount = 31;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCalendar.Location = new System.Drawing.Point(108, 175);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(53, 20);
            this.lblCalendar.TabIndex = 2;
            this.lblCalendar.Text = "label2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button1.Location = new System.Drawing.Point(176, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdImprimirComEnd
            // 
            this.cmdImprimirComEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdImprimirComEnd.Location = new System.Drawing.Point(911, 482);
            this.cmdImprimirComEnd.Name = "cmdImprimirComEnd";
            this.cmdImprimirComEnd.Size = new System.Drawing.Size(136, 46);
            this.cmdImprimirComEnd.TabIndex = 5;
            this.cmdImprimirComEnd.Text = "Imprimir Lista com Endereços";
            this.cmdImprimirComEnd.UseVisualStyleBackColor = true;
            this.cmdImprimirComEnd.Click += new System.EventHandler(this.cmdImprimirComEnd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(433, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 301);
            this.dataGridView1.TabIndex = 6;
            // 
            // cmdImprimirListaNomes
            // 
            this.cmdImprimirListaNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdImprimirListaNomes.Location = new System.Drawing.Point(582, 482);
            this.cmdImprimirListaNomes.Name = "cmdImprimirListaNomes";
            this.cmdImprimirListaNomes.Size = new System.Drawing.Size(136, 46);
            this.cmdImprimirListaNomes.TabIndex = 5;
            this.cmdImprimirListaNomes.Text = "Imprimir Lista de Nomes";
            this.cmdImprimirListaNomes.UseVisualStyleBackColor = true;
            this.cmdImprimirListaNomes.Click += new System.EventHandler(this.cmdImprimirListaNomes_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDocument2
            // 
            this.printDocument2.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_BeginPrint);
            this.printDocument2.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument2_EndPrint);
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // frmFiltroDizimista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 582);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdImprimirListaNomes);
            this.Controls.Add(this.cmdImprimirComEnd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.lblNomeForm);
            this.Name = "frmFiltroDizimista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Dizimistas";
            this.Load += new System.EventHandler(this.frmFiltroDizimista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeForm;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblCalendar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdImprimirComEnd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button cmdImprimirListaNomes;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
    }
}