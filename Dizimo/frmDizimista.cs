using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dizimo
{
    public partial class frmDizimista : Form
    {
        public frmDizimista()
        {
            InitializeComponent();
        }

        Dizimista Diz = new Dizimista();
        Setor Set = new Setor();
        private string status = "Navegando";

        private void HabilitaControle()
        {
            cmdIncluir.Enabled = (status == "Navegando");
            cmdPesquisar.Enabled = (status == "Navegando");
            cmdSalvar.Enabled = (status == "Editando" || status == "Inserindo");
            cmdExcluir.Enabled = (status == "Editando");

            if (status == "Inserindo" || status == "Editando")
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = true;
                }
                cmbSetor.Enabled = true;
            }
            else
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Enabled = false;
                }
                cmbSetor.Enabled = false;
            }
        }

        private void LimpaControle()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                    ctr.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e) //Botão Pesquisar
        {            
            PesquisarDiz PD = new PesquisarDiz(Diz); //Ta dando errado
            PD.ShowDialog();
            if (PD.id > 0) {
                cmdIncluir.Enabled = false;
                Diz.IdDizimista = PD.id;
                Diz.ConsultarDizimista();
                txtIDdiz.Text = Diz.IdDizimista.ToString();
                txtNome.Text = Diz.Nome_Dizimista;
                txtCPF.Text = Diz.Cpf_Dizimista;
                txtDataNasc.Text = Diz.DataN_Dizimista;
                txtConjuge.Text = Diz.Conjuge_Diz;
                txtDataCas.Text = Diz.DataCas_Dizimista;
                txtRua.Text = Diz.Rua_Dizimista;
                txtNumero.Text = Diz.Num_Dimista;
                txtBairro.Text = Diz.Bairro_dizimista;
                txtTelefone.Text = Diz.Tel_dizimista;
                txtValor.Text = Diz.Valor_dizimista.ToString();
                cmbSetor.SelectedIndex = Diz.Setor_Dizimista - 1;//alterado para adaptar os selectIndex

                status = "Editando";
                HabilitaControle();
            }
            else
            {
                status = "Navegando";
                HabilitaControle();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdIncluir_Click(object sender, EventArgs e)
        {
            LimpaControle();
            status = "Inserindo";
            HabilitaControle();
            int id = Diz.ConsultID();
            id++;
            txtIDdiz.Text = id.ToString();
        }

        private void Dizimista_Load(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
            //txtCPF.Mask = "999.999.999-99";

            cmbSetor.DisplayMember = "NomeSetor"; //Vai Mostrar
            cmbSetor.ValueMember = "idSetor"; //Vai trabalhar
            cmbSetor.DataSource = Set.ListarSetor().Tables[0];
            Set.IdSetor = int.Parse(cmbSetor.SelectedValue.ToString());
            Set.ConsultarSetor();
        }

        private void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Diz.Nome_Dizimista = txtNome.Text;
                Diz.Cpf_Dizimista = txtCPF.Text;
                if(txtDataNasc.Text == "")
                {
                    Diz.DataN_Dizimista = null;
                }
                else
                {
                    Diz.DataN_Dizimista = txtDataNasc.Text;
                }                
                
                if(txtDataCas.Text == "")
                {
                    Diz.DataCas_Dizimista = null;
                }
                else
                {
                    Diz.DataCas_Dizimista = txtDataCas.Text;
                }  
                Diz.Conjuge_Diz = txtConjuge.Text;
                Diz.Rua_Dizimista = txtRua.Text;
                Diz.Num_Dimista = txtNumero.Text;
                Diz.Bairro_dizimista = txtBairro.Text;
                Diz.Tel_dizimista = txtTelefone.Text;
                Diz.Valor_dizimista = float.Parse(txtValor.Text.ToString());
                //Diz.Setor_Dizimista = int.Parse(cmbSetor.SelectedValue.ToString());
                Set.IdSetor = int.Parse(cmbSetor.SelectedValue.ToString());
                Set.ConsultarSetor();
                Diz.Setor_Dizimista = Set.IdSetor;
                
                if (status == "Inserindo")
                {
                    Diz.IdDizimista = (Diz.ConsultID()) + 1;
                    Diz.IncluirDiz();
                    MessageBox.Show("Registro incluido com sucesso!!!");
                }
                if (status == "Editando")
                {
                    Diz.AlteraDizimista();
                    MessageBox.Show("Registro alterado com sucesso!!!");
                }
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
            }
            catch (SystemException X)
            {
                MessageBox.Show(X.ToString(),"Alerta!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void cmdExcluir_Click(object sender, EventArgs e)
        {
            if (status == "Editando")
            {
                if (DialogResult.Yes == MessageBox.Show("Deseja mesmo excluir este cadastro?", "Excluir Dizimista", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2))
                {
                    Diz.ExcluirDizimista();
                    MessageBox.Show("Excluido com sucesso!!!");
                    LimpaControle();
                    status = "Navegando";
                    HabilitaControle();
                }
            }
        }

        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diz.Setor_Dizimista = int.Parse(cmbSetor.SelectedValue.ToString());
            //Diz.ConsultarDizimista();
        }
    }
}
