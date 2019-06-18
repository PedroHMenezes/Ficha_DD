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
        string deslocamento = " ";
        string caracteristicas = " ";
        string pericias = " ";
        string idiomas = " ";
        string equipamentos = " ";
        int destreza = 0;
        int forca = 0;
        int constituicao = 0;
        int sabedoria = 0;
        int inteligencia = 0;
        int carisma = 0;

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
        { }


        private void Cbracas_DropDown(object sender, EventArgs e)
        {
            cbracas.ForeColor = Color.Black;
        }
        private void Cbracas_Leave(object sender, EventArgs e)
        {
            if (cbracas.Text == "Raças")
            {
                cbracas.ForeColor = Color.LightGray;
            }
        }
        private void Cbclasse_DropDown(object sender, EventArgs e)
        {
            cbclasse.ForeColor = Color.Black;
        }
        private void Cbclasse_Leave(object sender, EventArgs e)
        {
            if (cbclasse.Text == "Classe")
            {
                cbclasse.ForeColor = Color.LightGray;
            }
        }
        private void Cbtencencia_DropDown(object sender, EventArgs e)
        {
            cbtendencia.ForeColor = Color.Black;
        }

        private void Cbtendencia_Leave(object sender, EventArgs e)
        {
            if (cbtendencia.Text == "Tendência")
            {
                cbtendencia.ForeColor = Color.LightGray;
            }
        }
        private void Cbantecedentes_DropDown(object sender, EventArgs e)
        {
            cbantecedentes.ForeColor = Color.Black;
        }
        private void Cbantecedentes_Leave(object sender, EventArgs e)
        {
            if (cbantecedentes.Text == "Antecedentes")
            {
                cbantecedentes.ForeColor = Color.LightGray;
            }
        } 
        private void TxtNome_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtNome.ForeColor = Color.Black;
        }
        private void TxtNome_Leave(object sender, EventArgs e)
        {
            if (txtNome.Text == "")
            {
                txtNome.Text = "Nome do Personagem";
                txtNome.ForeColor = Color.LightGray;
            }
        }
        private void Txtnomejogador_Click(object sender, EventArgs e)
        {
            txtnomejogador.Text = "";
            txtnomejogador.ForeColor = Color.Black;
        }
        private void Txtnomejogador_Leave(object sender, EventArgs e)
        {
            if (txtnomejogador.Text == "")
            {
                txtnomejogador.Text = "Nome do Jogador";
                txtnomejogador.ForeColor = Color.LightGray;
            }
        }

        private void Txtexp_Click(object sender, EventArgs e)
        {
            txtexp.Text = "";
            txtexp.ForeColor = Color.Black;
        }

        private void Txtexp_Leave(object sender, EventArgs e)
        {
            if (txtexp.Text == "")
            {
                txtexp.Text = "Experiência";
                txtexp.ForeColor = Color.LightGray;
            }
        }

        private void Cbracas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Colocar aqui o substituir (replace)
            gbpericias.Text = gbpericias.Text.Replace(pericias, " ");
            gbidiomas.Text = gbidiomas.Text.Replace(idiomas, " ");
            gbcarachabilidades.Text = gbcarachabilidades.Text.Replace(caracteristicas, " ");
            txtdeslocamento.Text = txtdeslocamento.Text.Replace(deslocamento, " ");
            if (cbracas.Text == "Alto Elfo")
            {
                destreza = 2;
                deslocamento = "9";
                caracteristicas = "\n Visão no Escuro \n Ancestral Feérico \n Transe";
                pericias = "\n Percepção";
                idiomas = "\n Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas = "\n Um truque à sua escolha";
            }
            else if (cbracas.Text == "Elfo da Floresta")
            {
                destreza = 2;
                deslocamento = "10.5";
                caracteristicas = "\n Visão no Escuro \n Ancestral Feérico \n Transe";
                pericias = "\n Percepção";
                idiomas = "\n Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas = "\n Máscara da Natureza";
            }
            else if (cbracas.Text == "Elfo Negro (Drow)")
            {
                destreza = 2;
                deslocamento = "9";
                caracteristicas = "\n Visão no Escuro Superior \n Ancestral Feérico \n Transe \n Sensibilidade à luz Solar \n Magia Drow";
                pericias = "\n Percepção";
                idiomas = "\n Comum \n Élfico \n Espadas curtas \n Bestas de mão \n Rapieiras";
            }
            else if (cbracas.Text == "Anão da Colina")
            {
                constituicao = 2;
                deslocamento = "7.5";
                pericias = "Uma perícia de ferramentas de anão à sua escolha: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro";
                idiomas = "\n Comum \n Anão";
                caracteristicas = "Visão no Escuro";
                sabedoria = 1;
            }
            gbcarachabilidades.Text = gbcarachabilidades.Text + caracteristicas;
            gbpericias.Text = gbpericias.Text + pericias;
            gbidiomas.Text = gbidiomas.Text + idiomas;
            txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) + destreza);
            txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) + sabedoria);
            txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) + constituicao);
            txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) + forca);
            txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) + inteligencia);
            txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) + carisma);
            txtdeslocamento.Text = deslocamento;
        }

        private void Cbantecedentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbpericias.Text = gbpericias.Text.Replace(pericias, " ");
            gbidiomas.Text = gbidiomas.Text.Replace(idiomas, " ");
            gbcarachabilidades.Text = gbcarachabilidades.Text.Replace(caracteristicas, " ");
            txtdeslocamento.Text = txtdeslocamento.Text.Replace(deslocamento, " ");

            if (cbantecedentes.Text == "Acólito")
                {
                    pericias = "\n Intuição \n Religião";
                    idiomas = "\n Dois idiomas à sua escolha ";
                    equipamentos = "\n Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po";
                }

                else if (cbantecedentes.Text == "Artesão de Guilda")
                {
                    pericias = " \n Intuição \n Persuasão \n Uma ferramenta à sua escolha";
                    idiomas = "\n Um à sua escolha";
                    equipamentos = "\n Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po";

                }
                else if (cbantecedentes.Text == "Artista")
                {
                    pericias = "\n Acrobacia \n Atuação";
                    idiomas = " \n Kit de disface \n Kit de falsificação";
                    equipamentos = "\n Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos,um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 po";
                }
                else if (cbantecedentes.Text == "Charlatão")
                {
                    pericias = "\n Enganação \n Furtividade";
                    idiomas = " \n Um kit de jogo à sua escolha \n Ferramentas de ladrão";
                    equipamentos = "\n Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po";
                }
                else if (cbantecedentes.Text == "Eremita")
                {
                    pericias = "\n Medicina \n Religião";
                    idiomas = "\n Um idioma à sua escolha";
                    equipamentos = "\n Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno,um conjunto de roupas comuns, um kit de herbalismo e 5 po";
                }
                else if (cbantecedentes.Text == "Forasteiro")
                {
                    pericias = "\n Atletismo \n Sobrevivência";
                    idiomas = "\n Um idioma à sua escolha \n Um instrumento à sua escolha";
                    equipamentos = "\n Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po";
                }
                else if (cbantecedentes.Text == "Herói do povo")
                {
                    pericias = "\n Adestrar Animais \n Sobrevivência";
                    idiomas = "Um tipo de ferramenta de artesão à sua escolha \n Veículos (terrestre)";
                    equipamentos = "\n Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (cbantecedentes.Text == "Marinheiro")
                {
                    pericias = " \n Atletismo \n Percepção";
                    idiomas = "\n Uma ferramenta de marinheiro à sua escolha \n Veículo(aquático)";
                    equipamentos = "\n Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e um algibeira contendo 10 po";
                }
                else if (cbantecedentes.Text == "Nobre")
                {
                    pericias = "\n História \n Persuasão";
                    idiomas = "\n Um idioma à sua escolha \n Um kit de jogos à sua escolha";
                    equipamentos = "\n Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po";
                }
                else if (cbantecedentes.Text == "Órfão")
                {
                    pericias = "\n Furtividade \n Prestidigitação";
                    idiomas = "\n Kit de disfarce \n Ferramentas de ladrão";
                    equipamentos = "\n Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (cbantecedentes.Text == "Sábio")
                {
                    pericias = "\n Arcanismo \n História";
                    idiomas = "\n Dois idiomas à sua escolha";
                    equipamentos = "\n Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
                else if (cbantecedentes.Text == "Soldado")
                {
                    pericias = "\n Atletismo \n Intimidação";
                    idiomas = "\n Um tipo de kit de jogo à sua escolha";
                    equipamentos = "\n Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâminapartida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po";
                }
            gbpericias.Text = gbpericias.Text + pericias;
            gbidiomas.Text = gbidiomas.Text + idiomas;
            groupBox2.Text = groupBox2.Text + equipamentos;
        }
    }
    }

