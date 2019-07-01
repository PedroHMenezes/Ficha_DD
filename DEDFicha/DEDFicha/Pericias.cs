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
    }
}
