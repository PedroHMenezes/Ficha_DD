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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Txtforca_TextChanged(object sender, EventArgs e)
        {
            if (txtforca.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtforca.Text));
                lblf.Text = num;
            } else
            {
                lblf.Text = "0";
            }
        }
        private string Modificador(int num)
        {
            string numero = "";
            num = (num - 10) / 2;
            if (num > 0)
            {
                numero = "+" + Convert.ToString(num);
            }
            else
            {
                numero = Convert.ToString(num);
            }
            return numero;
        }

        private void Txtdestreza_TextChanged(object sender, EventArgs e)
        {
            if (txtdestreza.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtdestreza.Text));
                lbld.Text = num;
            } else
            {
                lbld.Text = "0";
            }
        }

        private void Txtconstituicao_TextChanged(object sender, EventArgs e)
        {
            if (txtconstituicao.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtconstituicao.Text));
                lblc.Text = num;
            }
            else
            {
                lblc.Text = "0";
            }
            
        }

        private void Txtinteligencia_TextChanged(object sender, EventArgs e)
        {
            if (txtinteligencia.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtinteligencia.Text));
                lbli.Text = num;
            } else
            {
                lbli.Text = "0";
            }
        }

        private void Txtsabedoria_TextChanged(object sender, EventArgs e)
        {
            if (txtsabedoria.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtsabedoria.Text));
                lbls.Text = num;
            } else
            {
                lbls.Text = "0";
            }
        }

        private void Txtcarisma_TextChanged(object sender, EventArgs e)
        {
            if (txtcarisma.Text != "")
            {
                string num = Modificador(Convert.ToInt32(txtcarisma.Text));
                lblca.Text = num;
            } else
            {
                lblca.Text = "0";
            }
            
        }

        private void Txtantecedente_TextChanged(object sender, EventArgs e)
        {
            string pericias = "";
            string idiomas = "";
            string equipamentos= "";
            string proeficiencias = "";
            if (txtantecedente.Text != "acólito" && txtantecedente.Text != "artesão de guilda" && txtantecedente.Text != "artista" && txtantecedente.Text != "charlatão" && txtantecedente.Text != "criminoso" && txtantecedente.Text != "eremita" && txtantecedente.Text != "forasteiro" && txtantecedente.Text != "herói do povo" && txtantecedente.Text != "marinheiro" && txtantecedente.Text != "nobre" && txtantecedente.Text != "órfão" && txtantecedente.Text != "sábio" && txtantecedente.Text != "soldado")
            {
                pericias = "";
                idiomas = "";
                equipamentos = "";
                gbpericias.Text = "Perícias";
                gbidiomas.Text = "Idiomas";
                groupBox2.Text = "Equipamentos";
            }
            else
            {
                if (txtantecedente.Text == "acólito")
                {
                    pericias = "\n Intuição \n Religião";
                    idiomas = "\n Dois idiomas à sua escolha ";
                    equipamentos = "\n Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po";
                }

                else if (txtantecedente.Text == "artesão de guilda")
                {
                    pericias =  " \n Intuição \n Persuasão \n Uma ferramenta à sua escolha";
                    idiomas =  "\n Um à sua escolha";
                    equipamentos = "\n Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po";

                }
                else if (txtantecedente.Text == "artista"){
                    pericias = "\n Acrobacia \n Atuação";
                    proeficiencias = " \n Kit de disface \n Kit de falsificação";
                    equipamentos = "\n Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos,um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 po";
                }
                else if (txtantecedente.Text == "charlatão")
                {
                    pericias = "\n Enganação \n Furtividade";
                    proeficiencias = " \n Um kit de jogo à sua escolha \n Ferramentas de ladrão";
                    equipamentos = "\n Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po";
                }
                else if (txtantecedente.Text == "eremita")
                {
                    pericias = "\n Medicina \n Religião";
                    idiomas = "\n Um idioma à sua escolha";
                    equipamentos = "\n Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno,um conjunto de roupas comuns, um kit de herbalismo e 5 po";
                }
                else if (txtantecedente.Text == "forasteiro")
                {
                    pericias = "\n Atletismo \n Sobrevivência";
                    proeficiencias = "\n Um instrumento à sua escolha";
                    idiomas = "\n Um idioma à sua escolha";
                    equipamentos = "\n Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po";
                }
                else if (txtantecedente.Text == "herói do povo")
                {
                    pericias = "\n Adestrar Animais \n Sobrevivência";
                    proeficiencias = "Um tipo de ferramenta de artesão à sua escolha \n Veículos (terrestre)";
                    equipamentos = "\n Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (txtantecedente.Text == "marinheiro")
                {
                    pericias = " \n Atletismo \n Percepção";
                    proeficiencias = "\n Uma ferramenta de marinheiro à sua escolha \n Veículo(aquático)";
                    equipamentos = "\n Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e um algibeira contendo 10 po";
                }
                else if (txtantecedente.Text == "nobre")
                {
                    pericias = "\n História \n Persuasão";
                    proeficiencias = " \n Um kit de jogos à sua escolha";
                    idiomas = "\n Um idioma à sua escolha";
                    equipamentos = "\n Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po";
                }
                else if (txtantecedente.Text == "órfão")
                {
                    pericias = "\n Furtividade \n Prestidigitação";
                    proeficiencias = "\n Kit de disfarce \n Ferramentas de ladrão";
                    equipamentos = "\n Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (txtantecedente.Text == "sábio")
                {
                    pericias = "\n Arcanismo \n História";
                    idiomas = "\n Dois idiomas à sua escolha";
                    equipamentos = "\n Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (txtantecedente.Text == "soldado")
                {
                    pericias = "\n Atletismo \n Intimidação";
                    proeficiencias = "\n Um tipo de kit de jogo à sua escolha";
                    equipamentos = "\n Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâminapartida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
            }
            gbpericias.Text = gbpericias.Text + pericias;
            gbcarachabilidades.Text = gbcarachabilidades.Text + proeficiencias;
            gbidiomas.Text = gbidiomas.Text + idiomas;
            groupBox2.Text = groupBox2.Text + equipamentos;
        }
        private void Txtraca_TextChanged(object sender, EventArgs e)
        {
            if (txtraca.Text == "elfo")
            {
                gbpericias.Text = gbpericias.Text + " \n Oi";
            }
        }
    }
}
