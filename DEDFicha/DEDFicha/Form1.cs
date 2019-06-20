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
        string resistencias = " ";
        int destreza = 0;
        int forca = 0;
        int constituicao = 0;
        int sabedoria = 0;
        int inteligencia = 0;
        int carisma = 0;
        int vida = 0;

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
            //Colocar aqui o substituir (replace)
            lblpericiasraca.Text = "";
            lblidiomasraca.Text = "";
            lblcaracteristicas.Text = "";
            lblequipamentoraca.Text = "";
            txtdeslocamento.Text = "";

            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) - forca);
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) - destreza);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) - constituicao);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) - inteligencia);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) - sabedoria);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) - carisma);
            }

            if (cbracas.Text == "Alto Elfo")
            {
                destreza = 2;
                deslocamento = "9";
                caracteristicas = " Visão no Escuro \n Ancestral Feérico \n Transe";
                pericias = " Percepção";
                idiomas = " Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas = " Um truque à sua escolha";
            }
            else if (cbracas.Text == "Elfo da Floresta")
            {
                destreza = 2;
                deslocamento = "10.5";
                caracteristicas = " Visão no Escuro \n Ancestral Feérico \n Transe";
                pericias = " Percepção";
                idiomas = " Comum \n Élfico \n Espadas longas \n Espadas curtas \n Arcos curtos \n Arcos longos \n Um idioma à sua escolha";
                caracteristicas = " Máscara da Natureza";
            }
            else if (cbracas.Text == "Elfo Negro (Drow)")
            {
                destreza = 2;
                deslocamento = "9";
                caracteristicas = " Visão no Escuro Superior \n Ancestral Feérico \n Transe \n Sensibilidade à luz Solar \n Magia Drow";
                pericias = " Percepção";
                idiomas = " Comum \n Élfico \n Espadas curtas \n Bestas de mão \n Rapieiras";
            }
            else if (cbracas.Text == "Anão da Colina")
            {
                constituicao = 2;
                deslocamento = "7.5";
                pericias = "Uma perícia de ferramentas de anão à sua escolha: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro";
                idiomas = " Comum \n Anão";
                caracteristicas = "Visão no Escuro";
                sabedoria = 1;
            }
            else if (cbracas.Text == "Anão da Montanha"){
                constituicao = 2;
                deslocamento = "7.5";
                pericias = "Uma perícia de ferramentas de anão à sua escolha: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro";
                idiomas = " Comum \n Anão";
                caracteristicas = "Visão no Escuro";
                forca = 2;
                idiomas = "\n Armaduras leves \n Armaduras médias";
                // Ganha +1 de vida
            }
            else if (cbracas.Text == "Humano") {
                forca = 1;
                constituicao = 1;
                destreza = 1;
                sabedoria = 1;
                inteligencia = 1;
                carisma = 1;
                deslocamento = "9";
                idiomas = "\n Comum \n Um idioma à sua escolha";
            }
            else if (cbracas.Text == "Halfing Pés Leves")
            {
                carisma = 3;
                caracteristicas = "\n Sortudo \n Bravura \n Agilidade Halfling";
                deslocamento = "7.5";
                idiomas = "\n Comum \n Halfling";
                caracteristicas = "\n Furtividade Natural";
            }
            else if (cbracas.Text == "Halfling Robusto")
            {
                carisma = 2;
                caracteristicas = "\n Sortudo \n Bravura \n Agilidade Halfling";
                deslocamento = "7.5";
                idiomas = "\n Comum \n Halfling";
                constituicao = 1;
                caracteristicas = "\n Resiliência dos Robustos";
            }
            else if (cbracas.Text == "Draconato")
            {
                forca = 2;
                carisma = 1;
                deslocamento = "9";
                caracteristicas = "\n Escolher um ancestral dracônico. Consultar página 34 do livro dos jogadores \n Resistência a Dano envolvido ao seu ancestral";
                idiomas = "\n Comum \n Dracônico";
            }
            else if(cbracas.Text == "Meio-Orc")
            {
                forca = 2;
                constituicao = 1;
                deslocamento = "9";
                caracteristicas = "\n Resistência Implacável \n Ataques Selvagens";
                pericias = "Intimidação";
                idiomas = "\n Comum \n Orc";
            }
            else if  (cbracas.Text == "Meio-Elfo")
            {
                carisma = 2;
                // Colocar soma nos modificadores: é nois
                deslocamento = "9";
                caracteristicas = "\n Visão no Escuro \n Ancestrak Feérico \n Versatilidade em Perícia";
                idiomas = "\n Comum \n Élfico \n Um idioma à sua escolha";
            }
            else if (cbracas.Text == "Tiefling")
            {
                inteligencia = 1;
                carisma = 2;
                deslocamento = "9";
                caracteristicas = "\n Visão no Escuro \n Resistência Infernal \n Legado Infernal";
                idiomas = "\n Comum \n Infernal";
            }
            else if (cbracas.Text == "Gnomo da Floresta")
            {
                inteligencia = 2;
                deslocamento = "7.5";
                caracteristicas = "\n Visão no Escuro \n Esperteza Gnômica \n Ilusionista Nato \n Falar com bestas pequenas";
                idiomas = "\n Comum \n Gnômico";
                resistencias = "\n Inteligência \n Sabedoria \n Carisma";
                destreza = 1;
            }
            else if (cbracas.Text == "Gnomo das Rochas")
            {
                inteligencia = 2;
                deslocamento = "7.5";
                caracteristicas = "\n Visão no Escuro \n Esperteza Gnômica \n Conhecimento de Artífice \n Engenhoqueiro";
                idiomas = "\n Comum \n Gnômico \n Ferramentas de artesão";
                resistencias = "\n Inteligência \n Sabedoria \n Carisma";
                constituicao = 1;

            }
            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                lblcaracteristicas.Text = lblcaracteristicas.Text + caracteristicas;
                lblpericiasraca.Text = lblpericiasraca.Text + pericias;
                lblidiomasraca.Text = lblidiomasraca.Text + idiomas;
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) + destreza);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) + sabedoria);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) + constituicao);
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) + forca);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) + inteligencia);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) + carisma);
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
            lblpericiasantecedentes.Text = "";
            lblidiomaantecedentes.Text = "";
            lblequipamentoantecedentes.Text = "";
            if (cbantecedentes.Text == "Acólito")
            {
                pericias = " Intuição \n Religião";
                idiomas = " Dois idiomas à sua escolha ";
                equipamentos = " Um símbolo sagrado (um presente dado quando você entrou no templo), um livro de preces ou conta de orações, 5 varetas de incenso, vestimentas, um conjunto de roupas comuns e uma algibeira contendo 15 po";
            }

            else if (cbantecedentes.Text == "Artesão de Guilda")
            {
                pericias = "  Intuição \n Persuasão \n Uma ferramenta à sua escolha";
                idiomas = " Um à sua escolha";
                equipamentos = " Um conjunto de ferramentas de artesão (à sua escolha), uma carta de apresentação da sua guilda, um conjunto de roupas de viajante e uma algibeira com 15 po";

            }
            else if (cbantecedentes.Text == "Artista")
            {
                pericias = " Acrobacia \n Atuação";
                idiomas = "  Kit de disface \n Kit de falsificação";
                equipamentos = " Um conjunto de roupas finas, um kit de disfarce, ferramentas de trapaça, à sua escolha (dez garrafas tampadas preenchidas com líquidos coloridos,um conjunto de dados viciados, um baralho de cartas marcadas ou um anel de sinete de um duque imaginário), e uma algibeira contendo 15 po";
            }
            else if (cbantecedentes.Text == "Charlatão")
            {
                pericias = " Enganação \n Furtividade";
                idiomas = "  Um kit de jogo à sua escolha \n Ferramentas de ladrão";
                equipamentos = " Um pé de cabra, um conjunto de roupas escuras comuns com capuz e uma algibeira contendo 15 po";
            }
            else if (cbantecedentes.Text == "Eremita")
            {
                pericias = " Medicina \n Religião";
                idiomas = " Um idioma à sua escolha";
                equipamentos = " Um estojo de pergaminho cheio de notas dos seus estudos e orações, um cobertor de inverno,um conjunto de roupas comuns, um kit de herbalismo e 5 po";
            }
            else if (cbantecedentes.Text == "Forasteiro")
            {
                pericias = " Atletismo \n Sobrevivência";
                idiomas = " Um idioma à sua escolha \n Um instrumento à sua escolha";
                equipamentos = " Um bordão, uma armadilha de caça, um fetiche de um animal que você matou, um conjunto de roupas de viajante e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Herói do povo")
            {
                pericias = " Adestrar Animais \n Sobrevivência";
                idiomas = "Um tipo de ferramenta de artesão à sua escolha \n Veículos (terrestre)";
                equipamentos = " Um conjunto de ferramentas de artesão (à sua escolha), uma pá, um pote de ferro, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Marinheiro")
            {
                pericias = " Atletismo \n Percepção";
                idiomas = " Uma ferramenta de marinheiro à sua escolha \n Veículo(aquático)";
                equipamentos = " Uma malagueta (clava), 15 metros de corda de seda, uma amuleto da sorte como um pé de coelho ou uma pequena pedra com um furo no centro (ou você pode rolar uma bugiganga da tabela Bugigangas no capítulo 5), um conjunto de trajes comuns e um algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Nobre")
            {
                pericias = " História \n Persuasão";
                idiomas = " Um idioma à sua escolha \n Um kit de jogos à sua escolha";
                equipamentos = " Um conjunto de trajes finos, um anel de sinete, um pergaminho de linhagem e uma algibeira contendo 25 po";
            }
            else if (cbantecedentes.Text == "Órfão")
            {
                pericias = " Furtividade  Prestidigitação";
                idiomas = " Kit de disfarce  Ferramentas de ladrão";
                equipamentos = " Uma faca pequena, um mapa da cidade em que você cresceu, um rato de estimação, um pequeno objeto para lembrar dos seus pais, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Sábio")
            {
                pericias = " Arcanismo \n História";
                idiomas = " Dois idiomas à sua escolha";
                equipamentos = " Um vidro de tinta escura, uma pena, uma faca pequena, uma carta de um falecido colega perguntando a você algo que você nunca terá a chance de responder, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            else if (cbantecedentes.Text == "Soldado")
            {
                pericias = " Atletismo \n Intimidação";
                idiomas = " Um tipo de kit de jogo à sua escolha";
                equipamentos = " Uma insígnia de patente, um fetiche obtido de um inimigo caído (uma adaga, lâminapartida ou tira de estandarte), um conjunto de dados de osso ou baralho, um conjunto de roupas comuns e uma algibeira contendo 10 po";
            }
            lblpericiasantecedentes.Text = lblpericiasantecedentes.Text + pericias;
            lblidiomaantecedentes.Text = lblidiomaantecedentes.Text + idiomas;
            lblequipamentoantecedentes.Text = lblequipamentoantecedentes.Text + equipamentos;
        }

        private void Cbclasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbclasse.Text == "Bárbaro")
            {
                caracteristicas = "\n Fúria \n Defesa sem armadura";
                vida = 12 + Convert.ToInt32(lblc.Text);
                idiomas = "\n Armaduras Leves \n Armaduras Médias \n Escudos \n Armas simples \n Armas marciais";
                // Colocar para escolher perícias
                resistencias = "\n Força \n Constituição";
                // Colocar para escolher equipamento
            }
            else if (cbclasse.Text == "Bardo")
            {
                resistencias = "\n Destreza \n Carisma";
                idiomas = "\n Armaduras Leves \n Armas simples \n Bestas de mão \n Espadas longas \n Rapieiras \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Dois truques de bardo \n Quatro magias de nível 1 de bardo \n Inspiração de bardo";
            }
            else if (cbclasse.Text == "Bruxo")
            {
                resistencias = "\n Sabedoria \n Carisma";
                idiomas = "\n Armaduras leves \n Armas simples";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Você deve escolher um ser transcedental para fazer barganha. Olha a página 58 do livro do jogador \n Dois truques de bruxo \n Duas magias de bruxo";
            }
            else if (cbclasse.Text == "Clérigo")
            {
                resistencias = "\n Sabedoria \n Carisma";
                idiomas = "\n Armaduras leves \n Armaduras médias \n Escudos \n Armas simples";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Três truques de clérigo \n Escolha um domínio relacionado à sua divindade. Olhe página 65 do livro dos jogadores";
            }
            else if (cbclasse.Text == "Druida")
            {
                resistencias = "\n Inteligência \n Sabedoria";
                vida = 8 + Convert.ToInt32(lblc.Text);
                idiomas = "\n Armaduras leves \n Armaduras médias \n Escudos \n Clavas \n Adagas \n Dardos \n Azagaias \n Maças \n Bordões \n Cimitarras \n Foices \n Fundas \n Lanças \n Kit de Herbalismo";
                caracteristicas = "\n Você pode escolher dois truques de druida \n Você tem dois espaços de magia level 1";
            }
            else if (cbclasse.Text == "Feiticeiro")
            {
                resistencias = "\n Constituição \n Carisma";
                idiomas = " \n Adagas \n Dardos \n Fundas \n Bordões \n Bestas leves \n Druídico";
                caracteristicas = "\n Quatro truques de feiticeiro \n Duas magias level 1";
                vida = 6 + Convert.ToInt32(lblc.Text);
            }
            else if (cbclasse.Text == "Guerreiro")
            {
                resistencias = "\n Força \n Constituição";
                idiomas = "\n Todas as armaduras \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Retomar o fôlego";
            }
            else if (cbclasse.Text == "Ladino")
            {
                resistencias = "\n Destreza \n Inteligência";
                idiomas = "\n Armaduras leves \n Armas simples \n Bestas de mão \n Espadas longas \n Rapieiras \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Especialização \n Ataque Furtivo \n Gírias de Ladrão";
            }
            else if (cbclasse.Text == "Mago")
            {
                resistencias = "\n Inteligência \n Sabedoria";
                idiomas = "\n Adagas \n Dardos \n Fundas \n Bastões \n Bestas leves";
                vida = 6 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Três truques de mago \n Grimório contendo seis magias";
                // Espaços mágicos
            }
            else if (cbclasse.Text == "Monge")
            {
                resistencias = "\n Força \n Destreza";
                idiomas = "\n Armas simples \n Espadas curtas";
                vida = 8 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Defesa sem armadura \n Artes marciais";
            }
            else if (cbclasse.Text == "Paladino")
            {
                resistencias = "\n Sabedoria \n Carisma";
                idiomas = "\n Todas as armaduras \n Escudos \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Sentido divino \n Cura pelas mãos";
            }
            else if (cbclasse.Text == "Patrulheiro")
            {
                resistencias = "\n Força \n Destreza";
                idiomas = "\n Armaduras leves \n Escudos \n Armas simples \n Armas marciais";
                vida = 10 + Convert.ToInt32(lblc.Text);
                caracteristicas = "\n Inimigo Favorito \n Explorador Natural";
            }
            if (txtdestreza.Text != "" && txtsabedoria.Text != "" && txtconstituicao.Text != "" && txtforca.Text != "" && txtinteligencia.Text != "" && txtcarisma.Text != "")
            {
                lblcaracteristicas.Text = lblcaracteristicas.Text + caracteristicas;
                lblpericiasraca.Text = lblpericiasraca.Text + pericias;
                lblidiomasraca.Text = lblidiomasraca.Text + idiomas;
                txtdestreza.Text = Convert.ToString(Convert.ToInt32(txtdestreza.Text) + destreza);
                txtsabedoria.Text = Convert.ToString(Convert.ToInt32(txtsabedoria.Text) + sabedoria);
                txtconstituicao.Text = Convert.ToString(Convert.ToInt32(txtconstituicao.Text) + constituicao);
                txtforca.Text = Convert.ToString(Convert.ToInt32(txtforca.Text) + forca);
                txtinteligencia.Text = Convert.ToString(Convert.ToInt32(txtinteligencia.Text) + inteligencia);
                txtcarisma.Text = Convert.ToString(Convert.ToInt32(txtcarisma.Text) + carisma);
                txtdeslocamento.Text = deslocamento;
                gbresistencias.Text = gbresistencias.Text + resistencias;
                txtpvtotais.Text = Convert.ToString(vida);
            }
            else
            {
                cbracas.Text = "Classe";
                MessageBox.Show("Insira os valores de atributos antes de selecionar uma classe!", "Cuidado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

