﻿using System;
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
        string pericias_possiveis = "";
        string deslocamento = " ";
        string caracteristicas_racas = " ";
        string caracteristicas_classe = " ";
        string pericia_antecedente = " ";
        string pericia_racas = " ";
        string pericias_classe = " ";
        string idiomas_racas = " ";
        string idiomas_classe = " ";
        string idiomas_antecedentes = " ";
        string equipamentos_antecedentes = " ";
        string equipamentos_classe = " ";
        string resistencias_racas = " ";
        string resistencias_classe = " ";
        int destreza_racas = 0;
        int forca_racas = 0;
        int constituicao_racas = 0;
        int sabedoria_racas = 0;
        int inteligencia_racas = 0;
        int carisma_racas = 0;
        int vida = 0;
        int destreza_classe = 0;
        int forca_classe = 0;
        int constituicao_classe = 0;
        int sabedoria_classe = 0;
        int inteligencia_classe = 0;
        int carisma_classe = 0;

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
            }
            else
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
            }
            else
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
            }
            else
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
            }
            else
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
            }
            else
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
            lblcaracteristicas.Text = lblcaracteristicas.Text.Replace(caracteristicas_racas, "");
            lblidiomasraca.Text = lblidiomasraca.Text.Replace(idiomas_racas, "");
            lblpericiasraca.Text = lblpericiasraca.Text.Replace(pericia_racas, "");
            gbpericias.Text = gbpericias.Text.Replace(resistencias_racas,"");
            pericia_racas = "";
            idiomas_racas = "";
            caracteristicas_racas = "";
            txtdeslocamento.Text = "";

            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) - forca_racas);
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) - destreza_racas);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) - constituicao_racas);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) - inteligencia_racas);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) - sabedoria_racas);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) - carisma_racas);
                destreza_racas = 0;
                forca_racas = 0;
                constituicao_racas = 0;
                sabedoria_racas = 0;
                inteligencia_racas = 0;
                carisma_racas = 0;
            }

            if (cbracas.Text == "Alto Elfo")
            {
                destreza_racas = 2;
                deslocamento = "9";
                caracteristicas_racas = " Visão no Escuro \n Ancestral Feérico \n Transe";
                pericia_racas = " Percepção";
                idiomas_racas = " Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas_racas = " Um truque à sua escolha";
            }
            else if (cbracas.Text == "Elfo da Floresta")
            {
                destreza_racas = 2;
                deslocamento = "10.5";
                caracteristicas_racas = " Visão no Escuro \n Ancestral Feérico \n Transe";
                pericia_racas = " Percepção";
                idiomas_racas = " Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas_racas = " Máscara da Natureza";
            }
            else if (cbracas.Text == "Elfo Negro (Drow)")
            {
                destreza_racas = 2;
                deslocamento = "9";
                caracteristicas_racas = " Visão no Escuro Superior \n Ancestral Feérico \n Transe \n Sensibilidade à luz Solar \n Magia Drow";
                pericia_racas = " Percepção";
                idiomas_racas = " Comum \n Élfico \n Espadas curtas \n Bestas de mão \n Rapieiras";
            }
            else if (cbracas.Text == "Anão da Colina")
            {
                constituicao_racas = 2;
                deslocamento = "7.5";
                pericia_racas = "Uma perícia de ferramentas de anão à sua escolha: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro";
                idiomas_racas = " Comum \n Anão";
                caracteristicas_racas = "Visão no Escuro";
                sabedoria_racas = 1;
            }
            else if (cbracas.Text == "Anão da Montanha"){
                constituicao_racas = 2;
                deslocamento = "7.5";
                pericia_racas = "Uma perícia de ferramentas de anão à sua escolha: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro";
                idiomas_racas = " Comum \n Anão";
                caracteristicas_racas = "Visão no Escuro";
                forca_racas = 2;
                idiomas_racas = "\n Armaduras leves \n Armaduras médias";
                // Ganha +1 de vida
            }
            else if (cbracas.Text == "Humano") {
                forca_racas = 1;
                constituicao_racas = 1;
                destreza_racas = 1;
                sabedoria_racas = 1;
                inteligencia_racas = 1;
                carisma_racas = 1;
                deslocamento = "9";
                idiomas_racas = "\n Comum \n Um idioma à sua escolha";
            }
            else if (cbracas.Text == "Halfling Pés Leves")
            {
                carisma_racas = 3;
                caracteristicas_racas = "\n Sortudo \n Bravura \n Agilidade Halfling";
                deslocamento = "7.5";
                idiomas_racas = "\n Comum \n Halfling";
                caracteristicas_racas = "\n Furtividade Natural";
            }
            else if (cbracas.Text == "Halfling Robusto")
            {
                carisma_racas = 2;
                caracteristicas_racas = "\n Sortudo \n Bravura \n Agilidade Halfling";
                deslocamento = "7.5";
                idiomas_racas = "\n Comum \n Halfling";
                constituicao_racas = 1;
                caracteristicas_racas = "\n Resiliência dos Robustos";
            }
            else if (cbracas.Text == "Draconato")
            {
                forca_racas = 2;
                carisma_racas = 1;
                deslocamento = "9";
                caracteristicas_racas = "\n Escolher um ancestral dracônico. Consultar página 34 do livro dos jogadores \n Resistência a Dano envolvido ao seu ancestral";
                idiomas_racas = "\n Comum \n Dracônico";
            }
            else if(cbracas.Text == "Meio-Orc")
            {
                forca_racas = 2;
                constituicao_racas = 1;
                deslocamento = "9";
                caracteristicas_racas = "\n Resistência Implacável \n Ataques Selvagens";
                pericia_racas = "Intimidação";
                idiomas_racas = "\n Comum \n Orc";
            }
            else if  (cbracas.Text == "Meio-Elfo")
            {
                carisma_racas = 2;
                // Colocar soma nos modificadores: é nois
                deslocamento = "9";
                caracteristicas_racas = "\n Visão no Escuro \n Ancestral Feérico \n Versatilidade em Perícia";
                idiomas_racas = "\n Comum \n Élfico \n Um idioma à sua escolha";
            }
            else if (cbracas.Text == "Tiefling")
            {
                inteligencia_racas = 1;
                carisma_racas = 2;
                deslocamento = "9";
                caracteristicas_racas = "\n Visão no Escuro \n Resistência Infernal \n Legado Infernal";
                idiomas_racas = "\n Comum \n Infernal";
            }
            else if (cbracas.Text == "Gnomo da Floresta")
            {
                inteligencia_racas = 2;
                deslocamento = "7.5";
                caracteristicas_racas = "\n Visão no Escuro \n Esperteza Gnômica \n Ilusionista Nato \n Falar com bestas pequenas";
                idiomas_racas = "\n Comum \n Gnômico";
                resistencias_racas = "\n Inteligência \n Sabedoria \n Carisma";
                destreza_racas = 1;
            }
            else if (cbracas.Text == "Gnomo das Rochas")
            {
                inteligencia_racas = 2;
                deslocamento = "7.5";
                caracteristicas_racas = "\n Visão no Escuro \n Esperteza Gnômica \n Conhecimento de Artífice \n Engenhoqueiro";
                idiomas_racas = "\n Comum \n Gnômico \n Ferramentas de artesão";
                resistencias_racas = "\n Inteligência \n Sabedoria \n Carisma";
                constituicao_racas = 1;

            }
            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                lblcaracteristicas.Text = lblcaracteristicas.Text + caracteristicas_racas;
                lblpericiasraca.Text = lblpericiasraca.Text + pericia_racas;
                lblidiomasraca.Text = lblidiomasraca.Text + idiomas_racas;
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) + destreza_racas);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) + sabedoria_racas);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) + constituicao_racas);
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) + forca_racas);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) + inteligencia_racas);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) + carisma_racas);
                txtdeslocamento.Text = deslocamento;
            }
            else
            {
                cbracas.Text = "Raças";
                MessageBox.Show("Insira os valores de atributos antes de selecionar uma raça!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cbantecedentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblequipamentoantecedentes.Text = lblequipamentoantecedentes.Text.Replace(equipamentos_antecedentes, "");
            lblidiomaantecedentes.Text = lblidiomaantecedentes.Text.Replace(idiomas_antecedentes, "");
            lblpericiasantecedentes.Text = lblpericiasantecedentes.Text.Replace(pericia_antecedente, "");
            pericia_antecedente = "";
            idiomas_antecedentes = "";
            equipamentos_antecedentes = "";
            if (cbantecedentes.Text == "Acólito")
            {
                pericia_antecedente = " Intuição \n Religião";
                idiomas_antecedentes = " Dois idiomas à sua escolha ";
                equipamentos_antecedentes = " Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po";
            }

            else if (cbantecedentes.Text == "Artesão de Guilda")
            {
                pericia_antecedente = "  Intuição \n Persuasão \n Uma ferramenta à sua escolha";
                idiomas_antecedentes = " Um à sua escolha";
                equipamentos_antecedentes = " Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po";

            }
            else if (cbantecedentes.Text == "Artista")
            {
                pericia_antecedente = " Acrobacia \n Atuação";
                idiomas_antecedentes = "  Kit de disface \n Kit de falsificação";
                equipamentos_antecedentes = " Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos,um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 po";
            }
            else if (cbantecedentes.Text == "Charlatão")
            {
                pericia_antecedente = " Enganação \n Prestidigitação";
                idiomas_antecedentes = "Kit de disfarce \n Kit de Falsificação";
                equipamentos_antecedentes = "  Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha(dez garrafas tampadas preenchidas com líquidos coloridos, um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15po";
            }
            else if (cbantecedentes.Text == "Criminoso")
            {
                pericia_antecedente = " Enganação \n Furtividade";
                idiomas_antecedentes = "  Um kit de jogo à sua escolha \n Ferramentas de ladrão";
                equipamentos_antecedentes = " Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po";
                
            } 
            else if (cbantecedentes.Text == "Eremita")
            {
                pericia_antecedente = " Medicina \n Religião";
                idiomas_antecedentes = " Um idioma à sua escolha";
                equipamentos_antecedentes = " Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno,um conjunto de roupas comuns, um kit de herbalismo e 5 po";
            }
            else if (cbantecedentes.Text == "Forasteiro")
            {
                pericia_antecedente = " Atletismo \n Sobrevivência";
                idiomas_antecedentes = " Um idioma à sua escolha \n Um instrumento à sua escolha";
                equipamentos_antecedentes = " Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Herói do Povo")
            {
                pericia_antecedente = " Adestrar Animais \n Sobrevivência";
                idiomas_antecedentes = "Um tipo de ferramenta de artesão à sua escolha \n Veículos (terrestre)";
                equipamentos_antecedentes = " Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Marinheiro")
            {
                pericia_antecedente = " Atletismo \n Percepção";
                idiomas_antecedentes = " Uma ferramenta de marinheiro à sua escolha \n Veículo(aquático)";
                equipamentos_antecedentes = " Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e um algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Nobre")
            {
                pericia_antecedente = " História \n Persuasão";
                idiomas_antecedentes = " Um idioma à sua escolha \n Um kit de jogos à sua escolha";
                equipamentos_antecedentes = " Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po";
            }
            else if (cbantecedentes.Text == "Órfão")
            {
                pericia_antecedente = " Furtividade  Prestidigitação";
                idiomas_antecedentes = " Kit de disfarce  Ferramentas de ladrão";
                equipamentos_antecedentes = " Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Sábio")
            {
                pericia_antecedente = " Arcanismo \n História";
                idiomas_antecedentes = " Dois idiomas à sua escolha";
                equipamentos_antecedentes = " Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Soldado")
            {
                pericia_antecedente = " Atletismo \n Intimidação";
                idiomas_antecedentes = " Um tipo de kit de jogo à sua escolha";
                equipamentos_antecedentes = " Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâminapartida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            lblpericiasantecedentes.Text = lblpericiasantecedentes.Text + pericia_antecedente;
            lblidiomaantecedentes.Text = lblidiomaantecedentes.Text + idiomas_antecedentes;
            lblequipamentoantecedentes.Text = lblequipamentoantecedentes.Text + equipamentos_antecedentes;
        }

        private void Cbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcaracteristicas.Text = lblcaracteristicas.Text.Replace(caracteristicas_classe, "");
            lblidiomaantecedentes.Text = lblidiomaantecedentes.Text.Replace(idiomas_classe, "");
            lblpericiasantecedentes.Text = lblpericiasantecedentes.Text.Replace(pericias_classe, "");
            gbresistencias.Text = gbresistencias.Text.Replace(resistencias_classe, "");
            txtpvtotais.Text = txtpvtotais.Text.Replace(Convert.ToString(vida), "0");
            lblequipamentoantecedentes.Text = lblequipamentoantecedentes.Text.Replace(equipamentos_classe, "");
            caracteristicas_classe = "";
            idiomas_classe = "";
            pericias_classe = "";
            equipamentos_classe = "";
            if (cbclasse.Text == "Bárbaro")
            {
                caracteristicas_classe = "\n Fúria \n Defesa sem armadura";
                vida = 12 + Convert.ToInt32(lblc.Text);
                idiomas_classe = "\n Armaduras Leves \n Armaduras Médias \n Escudos \n Armas simples \n Armas marciais";
                // Colocar para escolher perícias
                chamarPericias();
                pericias_possiveis = "Teste";
                resistencias_classe = "\n Força \n Constituição";
                // Colocar para escolher equipamento
            }
            else if (cbclasse.Text == "Bardo")
            {
                resistencias_classe = "\n Destreza \n Carisma";
                idiomas_classe = "\n Armaduras Leves \n Armas simples \n Bestas de mão \n Espadas longas \n Rapieiras \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Dois truques de bardo \n Quatro magias de nível 1 de bardo \n Inspiração de bardo";
            }
            else if (cbclasse.Text == "Bruxo")
            {
                resistencias_classe = "\n Sabedoria \n Carisma";
                idiomas_classe = "\n Armaduras leves \n Armas simples";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Você deve escolher um ser transcedental para fazer barganha. Olha a página 58 do livro do jogador \n Dois truques de bruxo \n Duas magias de bruxo";
            }
            else if (cbclasse.Text == "Clérigo")
            {
                resistencias_classe = "\n Sabedoria \n Carisma";
                idiomas_classe = "\n Armaduras leves \n Armaduras médias \n Escudos \n Armas simples";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Três truques de clérigo \n Escolha um domínio relacionado à sua divindade. Olhe página 65 do livro dos jogadores";
            }
            else if (cbclasse.Text == "Druida")
            {
                resistencias_classe = "\n Inteligência \n Sabedoria";
                vida = 8 + Convert.ToInt32(lblc.Text);
                idiomas_classe = "\n Armaduras leves \n Armaduras médias \n Escudos \n Clavas \n Adagas \n Dardos \n Azagaias \n Maças \n Bordões \n Cimitarras \n Foices \n Fundas \n Lanças \n Kit de Herbalismo";
                caracteristicas_classe = "\n Você pode escolher dois truques de druida \n Você tem dois espaços de magia level 1";
            }
            else if (cbclasse.Text == "Feiticeiro")
            {
                resistencias_classe = "\n Constituição \n Carisma";
                idiomas_classe = " \n Adagas \n Dardos \n Fundas \n Bordões \n Bestas leves \n Druídico";
                caracteristicas_classe = "\n Quatro truques de feiticeiro \n Duas magias level 1";
                vida = 6 + Convert.ToInt32(lblc.Text);
            }
            else if (cbclasse.Text == "Guerreiro")
            {
                resistencias_classe = "\n Força \n Constituição";
                idiomas_classe = "\n Todas as armaduras \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Retomar o fôlego";
            }
            else if (cbclasse.Text == "Ladino")
            {
                resistencias_classe = "\n Destreza \n Inteligência";
                idiomas_classe = "\n Armaduras leves \n Armas simples \n Bestas de mão \n Espadas longas \n Rapieiras \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Especialização \n Ataque Furtivo \n Gírias de Ladrão";
            }
            else if (cbclasse.Text == "Mago")
            {
                resistencias_classe = "\n Inteligência \n Sabedoria";
                idiomas_classe = "\n Adagas \n Dardos \n Fundas \n Bastões \n Bestas leves";
                vida = 6 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Três truques de mago \n Grimório contendo seis magias";
                // Espaços mágicos
            }
            else if (cbclasse.Text == "Monge")
            {
                resistencias_classe = "\n Força \n Destreza";
                idiomas_classe = "\n Armas simples \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Defesa sem armadura \n Artes marciais";
            }
            else if (cbclasse.Text == "Paladino")
            {
                resistencias_classe = "\n Sabedoria \n Carisma";
                idiomas_classe = "\n Todas as armaduras \n Escudos \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Sentido divino \n Cura pelas mãos";
            }
            else if (cbclasse.Text == "Patrulheiro")
            {
                resistencias_classe = "\n Força \n Destreza";
                idiomas_classe = "\n Armaduras leves \n Escudos \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas_classe = "\n Inimigo Favorito \n Explorador Natural";
            }
            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                lblcaracteristicas.Text = lblcaracteristicas.Text + caracteristicas_classe;
                lblpericiasraca.Text = lblpericiasraca.Text + pericia_antecedente;
                lblidiomasraca.Text = lblidiomasraca.Text + idiomas_classe;
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) + destreza_classe);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) + sabedoria_classe);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) + constituicao_classe);
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) + forca_classe);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) + inteligencia_classe);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) + carisma_classe);
                txtdeslocamento.Text = deslocamento;
                gbresistencias.Text = gbresistencias.Text + resistencias_classe;
                txtpvtotais.Text = Convert.ToString(vida);
            }
            else
            {
                cbracas.Text = "Classe";
                MessageBox.Show("Insira os valores de atributos antes de selecionar uma classe!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Gbresistencias_Enter(object sender, EventArgs e)
        {

        }

        private void chamarPericias()
        {
            Pericias p = new Pericias(pericias_possiveis);
            p.ShowDialog();
        }
    }
}