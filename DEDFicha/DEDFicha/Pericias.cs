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
        public Pericias(string str_value,string opcaoum, string opcaodois, string opcaotres, string opcaoquatro, string opcaocinco, string opcaoseis, string opcaosete, string opcaooito, string opcaonove, string opcaodez, string opcaoonze, string opcaodoze, string opcaotreze, string opcaocatorze, string opcaoquinze, string opcaodezesseis, string opcaodezessete, string opcaodezoito, string opcoes)
        {
            InitializeComponent();
            lbltextopericias.Text = str_value;
            lblopcaoum.Text = opcaoum;
            lblopcaodois.Text = opcaodois;
            lblopcaotres.Text = opcaotres;
            lblopcaoquatro.Text = opcaoquatro;
            lblopcaocinco.Text = opcaocinco;
            lblopcaoseis.Text = opcaoseis;
            lblopcaosete.Text = opcaosete;
            lblopcaooito.Text = opcaooito;
            lblopcaonove.Text = opcaonove;
            lblopcaodez.Text = opcaodez;
            lblopcaoonze.Text = opcaoonze;
            lblopcaodoze.Text = opcaodoze;
            lblopcaotreze.Text = opcaotreze;
            lblopcaocatorze.Text = opcaocatorze;
            lblopcaoquinze.Text = opcaoquinze;
            lblopcaodezesseis.Text = opcaodezesseis;
            lblopcaodezessete.Text = opcaodezessete;
            lblopcaodezoito.Text = opcaodezoito;
            lblnumeroescolhas.Text = opcoes;
        }

        private void Botaoconfirma_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(lblnumeroescolhas.Text,"Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                if (opcaoum.Checked == true) //Faz o teste de confirmação da CheckBox
                {
                    escolha = escolha + "\n" + lblopcaoum.Text;
                }
                if (opcaodois.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaodois.Text;
                }
                if (opcaotres.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaotres.Text;
                }
                if (opcaoquatro.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaoquatro.Text;
                }
                if (opcaocinco.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaocinco.Text;
                }
                if (opcaoseis.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaoseis.Text;
                }
                if (opcaosete.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaosete.Text;
                }
                if (opcaooito.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaooito.Text;
                }
                if (opcaonove.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaonove.Text;
                }
                if (opcaodez.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaodez.Text;
                }
                if (opcaoonze.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaoonze.Text;
                }
                if (opcaodoze.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaodoze.Text;
                }
                if (opcaotreze.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaotreze.Text;
                }
                if (opcaocatorze.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaocatorze.Text;
                }
                if (opcaoquinze.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaoquinze.Text;
                }
                if (opcaodezesseis.Checked == true)
                {
                    escolha = escolha + "\n" + lblopcaodezesseis.Text;
                }
                if (opcaodezessete.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaodezessete.Text;
                }
                if (opcaodezoito.Checked == true)
                {
                    escolha = escolha + "\n " + lblopcaodezoito.Text;
                }
                this.Dispose();
            }
        }
    }
}
