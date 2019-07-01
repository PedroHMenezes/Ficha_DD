using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEDFicha
{
    public partial class Pericias : Form
    {
        private string escolha;

        public string Escolha
        {
            get { return escolha; }
            set { escolha = value; }
        }
        public Pericias(string str_value,string opcaoum, string opcaodois, string opcaotres)
        {
            InitializeComponent();
            lbltextopericias.Text = str_value;
            lblopcaoum.Text = opcaoum;
            lblopcaodois.Text = opcaodois;
            lblopcaotres.Text = opcaotres;
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Botaoconfirma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quer esses equipamentos? Lembre que só pode escolher uma das opções","Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (opcaoum.Checked == true) //Faz o teste de confirmação da CheckBox
                {
                    escolha = lblopcaoum.Text;
                    this.Dispose(); //Fecha o formulário
                }
                else if (lblopcaodois.Text != "")
                {
                    escolha = lblopcaodois.Text;
                }
                else if (lblopcaotres.Text != "")
                {
                    escolha = lblopcaotres.Text;
                }
            }
        }        
    }
}
