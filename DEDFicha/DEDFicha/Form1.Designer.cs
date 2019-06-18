namespace DEDFicha
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtclassenivel = new System.Windows.Forms.TextBox();
            this.txtantecedente = new System.Windows.Forms.TextBox();
            this.txtnomejogador = new System.Windows.Forms.TextBox();
            this.txttendencia = new System.Windows.Forms.TextBox();
            this.txtexp = new System.Windows.Forms.TextBox();
            this.gball = new System.Windows.Forms.GroupBox();
            this.gbhabilidades = new System.Windows.Forms.GroupBox();
            this.lbld = new System.Windows.Forms.Label();
            this.lbls = new System.Windows.Forms.Label();
            this.lbli = new System.Windows.Forms.Label();
            this.lblca = new System.Windows.Forms.Label();
            this.lblc = new System.Windows.Forms.Label();
            this.lblf = new System.Windows.Forms.Label();
            this.txtcarisma = new System.Windows.Forms.TextBox();
            this.lblcarisma = new System.Windows.Forms.Label();
            this.txtsabedoria = new System.Windows.Forms.TextBox();
            this.lblsabedoria = new System.Windows.Forms.Label();
            this.txtinteligencia = new System.Windows.Forms.TextBox();
            this.lblinteligencia = new System.Windows.Forms.Label();
            this.txtconstituicao = new System.Windows.Forms.TextBox();
            this.lblconstituicao = new System.Windows.Forms.Label();
            this.txtdestreza = new System.Windows.Forms.TextBox();
            this.lbldestreza = new System.Windows.Forms.Label();
            this.txtforca = new System.Windows.Forms.TextBox();
            this.lblforca = new System.Windows.Forms.Label();
            this.pblogo = new System.Windows.Forms.PictureBox();
            this.txtinspiracao = new System.Windows.Forms.TextBox();
            this.lblinspiracao = new System.Windows.Forms.Label();
            this.lblmodificador = new System.Windows.Forms.Label();
            this.txtbonusprof = new System.Windows.Forms.TextBox();
            this.gbresistencias = new System.Windows.Forms.GroupBox();
            this.gbpericias = new System.Windows.Forms.GroupBox();
            this.gbidiomas = new System.Windows.Forms.GroupBox();
            this.gbiniciativa = new System.Windows.Forms.GroupBox();
            this.txtiniciativa = new System.Windows.Forms.TextBox();
            this.gbdesloc = new System.Windows.Forms.GroupBox();
            this.txtdeslocamento = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldadosvida = new System.Windows.Forms.Label();
            this.lbltotalvida = new System.Windows.Forms.Label();
            this.txtdadosvida = new System.Windows.Forms.TextBox();
            this.txtpvtotais = new System.Windows.Forms.TextBox();
            this.gbataques = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbcarachabilidades = new System.Windows.Forms.GroupBox();
            this.cbracas = new System.Windows.Forms.ComboBox();
            this.gball.SuspendLayout();
            this.gbhabilidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).BeginInit();
            this.gbiniciativa.SuspendLayout();
            this.gbdesloc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNome.Location = new System.Drawing.Point(17, 46);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(157, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Text = "Nome do Personagem";
            // 
            // txtclassenivel
            // 
            this.txtclassenivel.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtclassenivel.Location = new System.Drawing.Point(13, 22);
            this.txtclassenivel.Name = "txtclassenivel";
            this.txtclassenivel.Size = new System.Drawing.Size(98, 20);
            this.txtclassenivel.TabIndex = 1;
            this.txtclassenivel.Text = "Classe e Nível";
            // 
            // txtantecedente
            // 
            this.txtantecedente.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtantecedente.Location = new System.Drawing.Point(117, 22);
            this.txtantecedente.Name = "txtantecedente";
            this.txtantecedente.Size = new System.Drawing.Size(100, 20);
            this.txtantecedente.TabIndex = 2;
            this.txtantecedente.Text = "Antecedente";
            this.txtantecedente.TextChanged += new System.EventHandler(this.Txtantecedente_TextChanged);
            // 
            // txtnomejogador
            // 
            this.txtnomejogador.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtnomejogador.Location = new System.Drawing.Point(223, 22);
            this.txtnomejogador.Name = "txtnomejogador";
            this.txtnomejogador.Size = new System.Drawing.Size(104, 20);
            this.txtnomejogador.TabIndex = 3;
            this.txtnomejogador.Text = "Nome do Jogador";
            // 
            // txttendencia
            // 
            this.txttendencia.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttendencia.Location = new System.Drawing.Point(132, 48);
            this.txttendencia.Name = "txttendencia";
            this.txttendencia.Size = new System.Drawing.Size(100, 20);
            this.txttendencia.TabIndex = 5;
            this.txttendencia.Text = "Tendência";
            // 
            // txtexp
            // 
            this.txtexp.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtexp.Location = new System.Drawing.Point(238, 48);
            this.txtexp.Name = "txtexp";
            this.txtexp.Size = new System.Drawing.Size(89, 20);
            this.txtexp.TabIndex = 6;
            this.txtexp.Text = "Experiência";
            // 
            // gball
            // 
            this.gball.Controls.Add(this.cbracas);
            this.gball.Controls.Add(this.txtexp);
            this.gball.Controls.Add(this.txtclassenivel);
            this.gball.Controls.Add(this.txtantecedente);
            this.gball.Controls.Add(this.txttendencia);
            this.gball.Controls.Add(this.txtnomejogador);
            this.gball.Location = new System.Drawing.Point(180, 12);
            this.gball.Name = "gball";
            this.gball.Size = new System.Drawing.Size(333, 83);
            this.gball.TabIndex = 7;
            this.gball.TabStop = false;
            // 
            // gbhabilidades
            // 
            this.gbhabilidades.BackColor = System.Drawing.SystemColors.Control;
            this.gbhabilidades.Controls.Add(this.lbld);
            this.gbhabilidades.Controls.Add(this.lbls);
            this.gbhabilidades.Controls.Add(this.lbli);
            this.gbhabilidades.Controls.Add(this.lblca);
            this.gbhabilidades.Controls.Add(this.lblc);
            this.gbhabilidades.Controls.Add(this.lblf);
            this.gbhabilidades.Controls.Add(this.txtcarisma);
            this.gbhabilidades.Controls.Add(this.lblcarisma);
            this.gbhabilidades.Controls.Add(this.txtsabedoria);
            this.gbhabilidades.Controls.Add(this.lblsabedoria);
            this.gbhabilidades.Controls.Add(this.txtinteligencia);
            this.gbhabilidades.Controls.Add(this.lblinteligencia);
            this.gbhabilidades.Controls.Add(this.txtconstituicao);
            this.gbhabilidades.Controls.Add(this.lblconstituicao);
            this.gbhabilidades.Controls.Add(this.txtdestreza);
            this.gbhabilidades.Controls.Add(this.lbldestreza);
            this.gbhabilidades.Controls.Add(this.txtforca);
            this.gbhabilidades.Controls.Add(this.lblforca);
            this.gbhabilidades.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbhabilidades.Location = new System.Drawing.Point(17, 96);
            this.gbhabilidades.Name = "gbhabilidades";
            this.gbhabilidades.Size = new System.Drawing.Size(82, 501);
            this.gbhabilidades.TabIndex = 8;
            this.gbhabilidades.TabStop = false;
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Location = new System.Drawing.Point(33, 128);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(13, 13);
            this.lbld.TabIndex = 13;
            this.lbld.Text = "0";
            // 
            // lbls
            // 
            this.lbls.AutoSize = true;
            this.lbls.Location = new System.Drawing.Point(34, 387);
            this.lbls.Name = "lbls";
            this.lbls.Size = new System.Drawing.Size(13, 13);
            this.lbls.TabIndex = 16;
            this.lbls.Text = "0";
            // 
            // lbli
            // 
            this.lbli.AutoSize = true;
            this.lbli.Location = new System.Drawing.Point(33, 301);
            this.lbli.Name = "lbli";
            this.lbli.Size = new System.Drawing.Size(13, 13);
            this.lbli.TabIndex = 15;
            this.lbli.Text = "0";
            // 
            // lblca
            // 
            this.lblca.AutoSize = true;
            this.lblca.Location = new System.Drawing.Point(33, 474);
            this.lblca.Name = "lblca";
            this.lblca.Size = new System.Drawing.Size(13, 13);
            this.lblca.TabIndex = 14;
            this.lblca.Text = "0";
            // 
            // lblc
            // 
            this.lblc.AutoSize = true;
            this.lblc.Location = new System.Drawing.Point(33, 211);
            this.lblc.Name = "lblc";
            this.lblc.Size = new System.Drawing.Size(13, 13);
            this.lblc.TabIndex = 13;
            this.lblc.Text = "0";
            // 
            // lblf
            // 
            this.lblf.AutoSize = true;
            this.lblf.Location = new System.Drawing.Point(32, 56);
            this.lblf.Name = "lblf";
            this.lblf.Size = new System.Drawing.Size(13, 13);
            this.lblf.TabIndex = 12;
            this.lblf.Text = "0";
            // 
            // txtcarisma
            // 
            this.txtcarisma.Location = new System.Drawing.Point(24, 451);
            this.txtcarisma.Name = "txtcarisma";
            this.txtcarisma.Size = new System.Drawing.Size(31, 20);
            this.txtcarisma.TabIndex = 11;
            this.txtcarisma.TextChanged += new System.EventHandler(this.Txtcarisma_TextChanged);
            // 
            // lblcarisma
            // 
            this.lblcarisma.AutoSize = true;
            this.lblcarisma.Location = new System.Drawing.Point(17, 434);
            this.lblcarisma.Name = "lblcarisma";
            this.lblcarisma.Size = new System.Drawing.Size(44, 13);
            this.lblcarisma.TabIndex = 10;
            this.lblcarisma.Text = "Carisma";
            // 
            // txtsabedoria
            // 
            this.txtsabedoria.Location = new System.Drawing.Point(24, 364);
            this.txtsabedoria.Name = "txtsabedoria";
            this.txtsabedoria.Size = new System.Drawing.Size(31, 20);
            this.txtsabedoria.TabIndex = 9;
            this.txtsabedoria.TextChanged += new System.EventHandler(this.Txtsabedoria_TextChanged);
            // 
            // lblsabedoria
            // 
            this.lblsabedoria.AutoSize = true;
            this.lblsabedoria.Location = new System.Drawing.Point(12, 348);
            this.lblsabedoria.Name = "lblsabedoria";
            this.lblsabedoria.Size = new System.Drawing.Size(55, 13);
            this.lblsabedoria.TabIndex = 8;
            this.lblsabedoria.Text = "Sabedoria";
            // 
            // txtinteligencia
            // 
            this.txtinteligencia.Location = new System.Drawing.Point(24, 278);
            this.txtinteligencia.Name = "txtinteligencia";
            this.txtinteligencia.Size = new System.Drawing.Size(31, 20);
            this.txtinteligencia.TabIndex = 7;
            this.txtinteligencia.TextChanged += new System.EventHandler(this.Txtinteligencia_TextChanged);
            // 
            // lblinteligencia
            // 
            this.lblinteligencia.AutoSize = true;
            this.lblinteligencia.Location = new System.Drawing.Point(10, 262);
            this.lblinteligencia.Name = "lblinteligencia";
            this.lblinteligencia.Size = new System.Drawing.Size(61, 13);
            this.lblinteligencia.TabIndex = 6;
            this.lblinteligencia.Text = "Inteligência";
            // 
            // txtconstituicao
            // 
            this.txtconstituicao.Location = new System.Drawing.Point(24, 188);
            this.txtconstituicao.Name = "txtconstituicao";
            this.txtconstituicao.Size = new System.Drawing.Size(31, 20);
            this.txtconstituicao.TabIndex = 5;
            this.txtconstituicao.TextChanged += new System.EventHandler(this.Txtconstituicao_TextChanged);
            // 
            // lblconstituicao
            // 
            this.lblconstituicao.AutoSize = true;
            this.lblconstituicao.Location = new System.Drawing.Point(9, 172);
            this.lblconstituicao.Name = "lblconstituicao";
            this.lblconstituicao.Size = new System.Drawing.Size(65, 13);
            this.lblconstituicao.TabIndex = 4;
            this.lblconstituicao.Text = "Constituição";
            // 
            // txtdestreza
            // 
            this.txtdestreza.Location = new System.Drawing.Point(24, 105);
            this.txtdestreza.Name = "txtdestreza";
            this.txtdestreza.Size = new System.Drawing.Size(31, 20);
            this.txtdestreza.TabIndex = 3;
            this.txtdestreza.TextChanged += new System.EventHandler(this.Txtdestreza_TextChanged);
            // 
            // lbldestreza
            // 
            this.lbldestreza.AutoSize = true;
            this.lbldestreza.Location = new System.Drawing.Point(15, 89);
            this.lbldestreza.Name = "lbldestreza";
            this.lbldestreza.Size = new System.Drawing.Size(49, 13);
            this.lbldestreza.TabIndex = 2;
            this.lbldestreza.Text = "Destreza";
            // 
            // txtforca
            // 
            this.txtforca.Location = new System.Drawing.Point(24, 33);
            this.txtforca.Name = "txtforca";
            this.txtforca.Size = new System.Drawing.Size(31, 20);
            this.txtforca.TabIndex = 1;
            this.txtforca.TextChanged += new System.EventHandler(this.Txtforca_TextChanged);
            // 
            // lblforca
            // 
            this.lblforca.AutoSize = true;
            this.lblforca.Location = new System.Drawing.Point(21, 16);
            this.lblforca.Name = "lblforca";
            this.lblforca.Size = new System.Drawing.Size(34, 13);
            this.lblforca.TabIndex = 0;
            this.lblforca.Text = "Força";
            // 
            // pblogo
            // 
            this.pblogo.Image = global::DEDFicha.Properties.Resources.logo;
            this.pblogo.Location = new System.Drawing.Point(18, 7);
            this.pblogo.Name = "pblogo";
            this.pblogo.Size = new System.Drawing.Size(45, 39);
            this.pblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogo.TabIndex = 9;
            this.pblogo.TabStop = false;
            // 
            // txtinspiracao
            // 
            this.txtinspiracao.Location = new System.Drawing.Point(105, 105);
            this.txtinspiracao.Name = "txtinspiracao";
            this.txtinspiracao.Size = new System.Drawing.Size(21, 20);
            this.txtinspiracao.TabIndex = 17;
            // 
            // lblinspiracao
            // 
            this.lblinspiracao.AutoSize = true;
            this.lblinspiracao.Location = new System.Drawing.Point(127, 108);
            this.lblinspiracao.Name = "lblinspiracao";
            this.lblinspiracao.Size = new System.Drawing.Size(56, 13);
            this.lblinspiracao.TabIndex = 18;
            this.lblinspiracao.Text = "Inspiração";
            // 
            // lblmodificador
            // 
            this.lblmodificador.AutoSize = true;
            this.lblmodificador.Location = new System.Drawing.Point(127, 136);
            this.lblmodificador.Name = "lblmodificador";
            this.lblmodificador.Size = new System.Drawing.Size(110, 13);
            this.lblmodificador.TabIndex = 20;
            this.lblmodificador.Text = "Bônus de Proficiência";
            // 
            // txtbonusprof
            // 
            this.txtbonusprof.Location = new System.Drawing.Point(105, 133);
            this.txtbonusprof.Name = "txtbonusprof";
            this.txtbonusprof.Size = new System.Drawing.Size(21, 20);
            this.txtbonusprof.TabIndex = 19;
            // 
            // gbresistencias
            // 
            this.gbresistencias.Location = new System.Drawing.Point(105, 160);
            this.gbresistencias.Name = "gbresistencias";
            this.gbresistencias.Size = new System.Drawing.Size(132, 144);
            this.gbresistencias.TabIndex = 21;
            this.gbresistencias.TabStop = false;
            this.gbresistencias.Text = "Testes de Resistência";
            // 
            // gbpericias
            // 
            this.gbpericias.Location = new System.Drawing.Point(105, 313);
            this.gbpericias.Name = "gbpericias";
            this.gbpericias.Size = new System.Drawing.Size(132, 284);
            this.gbpericias.TabIndex = 22;
            this.gbpericias.TabStop = false;
            this.gbpericias.Text = "Perícias";
            // 
            // gbidiomas
            // 
            this.gbidiomas.Location = new System.Drawing.Point(17, 603);
            this.gbidiomas.Name = "gbidiomas";
            this.gbidiomas.Size = new System.Drawing.Size(220, 106);
            this.gbidiomas.TabIndex = 23;
            this.gbidiomas.TabStop = false;
            this.gbidiomas.Text = "Idiomas e Outras Proficiências";
            // 
            // gbiniciativa
            // 
            this.gbiniciativa.Controls.Add(this.txtiniciativa);
            this.gbiniciativa.Location = new System.Drawing.Point(243, 108);
            this.gbiniciativa.Name = "gbiniciativa";
            this.gbiniciativa.Size = new System.Drawing.Size(63, 57);
            this.gbiniciativa.TabIndex = 24;
            this.gbiniciativa.TabStop = false;
            this.gbiniciativa.Text = "Iniciativa";
            // 
            // txtiniciativa
            // 
            this.txtiniciativa.Location = new System.Drawing.Point(20, 22);
            this.txtiniciativa.Name = "txtiniciativa";
            this.txtiniciativa.Size = new System.Drawing.Size(21, 20);
            this.txtiniciativa.TabIndex = 26;
            // 
            // gbdesloc
            // 
            this.gbdesloc.Controls.Add(this.txtdeslocamento);
            this.gbdesloc.Location = new System.Drawing.Point(312, 108);
            this.gbdesloc.Name = "gbdesloc";
            this.gbdesloc.Size = new System.Drawing.Size(63, 57);
            this.gbdesloc.TabIndex = 25;
            this.gbdesloc.TabStop = false;
            this.gbdesloc.Text = "Desloc.";
            // 
            // txtdeslocamento
            // 
            this.txtdeslocamento.Location = new System.Drawing.Point(20, 21);
            this.txtdeslocamento.Name = "txtdeslocamento";
            this.txtdeslocamento.Size = new System.Drawing.Size(21, 20);
            this.txtdeslocamento.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldadosvida);
            this.groupBox1.Controls.Add(this.lbltotalvida);
            this.groupBox1.Controls.Add(this.txtdadosvida);
            this.groupBox1.Controls.Add(this.txtpvtotais);
            this.groupBox1.Location = new System.Drawing.Point(243, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 82);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pontos de Vida";
            // 
            // lbldadosvida
            // 
            this.lbldadosvida.AutoSize = true;
            this.lbldadosvida.Location = new System.Drawing.Point(6, 56);
            this.lbldadosvida.Name = "lbldadosvida";
            this.lbldadosvida.Size = new System.Drawing.Size(77, 13);
            this.lbldadosvida.TabIndex = 3;
            this.lbldadosvida.Text = "Dados de Vida";
            // 
            // lbltotalvida
            // 
            this.lbltotalvida.AutoSize = true;
            this.lbltotalvida.Location = new System.Drawing.Point(7, 20);
            this.lbltotalvida.Name = "lbltotalvida";
            this.lbltotalvida.Size = new System.Drawing.Size(31, 13);
            this.lbltotalvida.TabIndex = 2;
            this.lbltotalvida.Text = "Total";
            // 
            // txtdadosvida
            // 
            this.txtdadosvida.Location = new System.Drawing.Point(89, 53);
            this.txtdadosvida.Name = "txtdadosvida";
            this.txtdadosvida.Size = new System.Drawing.Size(37, 20);
            this.txtdadosvida.TabIndex = 1;
            // 
            // txtpvtotais
            // 
            this.txtpvtotais.Location = new System.Drawing.Point(44, 19);
            this.txtpvtotais.Name = "txtpvtotais";
            this.txtpvtotais.Size = new System.Drawing.Size(82, 20);
            this.txtpvtotais.TabIndex = 0;
            // 
            // gbataques
            // 
            this.gbataques.Location = new System.Drawing.Point(243, 268);
            this.gbataques.Name = "gbataques";
            this.gbataques.Size = new System.Drawing.Size(132, 189);
            this.gbataques.TabIndex = 24;
            this.gbataques.TabStop = false;
            this.gbataques.Text = "Ataques e Magias";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(243, 464);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 245);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equipamento";
            // 
            // gbcarachabilidades
            // 
            this.gbcarachabilidades.Location = new System.Drawing.Point(382, 112);
            this.gbcarachabilidades.Name = "gbcarachabilidades";
            this.gbcarachabilidades.Size = new System.Drawing.Size(132, 597);
            this.gbcarachabilidades.TabIndex = 29;
            this.gbcarachabilidades.TabStop = false;
            this.gbcarachabilidades.Text = "Caracteristicas e Habilidades";
            // 
            // cbracas
            // 
            this.cbracas.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbracas.FormattingEnabled = true;
            this.cbracas.Items.AddRange(new object[] {
            "Anão da Colina",
            "Anão da Montanha",
            "Alto Elfo",
            "Elfo da Floresta",
            "Elfo Negro (Drow)",
            "Halfling Pés Leves",
            "Hafling Pés Robustos",
            "Humano",
            "Draconato",
            "Meio-Orc",
            "Meio-Elfo",
            "Tiefling",
            "Gnomo da Floresta",
            "Gnomo da Rochas"});
            this.cbracas.Location = new System.Drawing.Point(13, 48);
            this.cbracas.Name = "cbracas";
            this.cbracas.Size = new System.Drawing.Size(113, 21);
            this.cbracas.TabIndex = 0;
            this.cbracas.Tag = "";
            this.cbracas.Text = "Raças";
            this.cbracas.SelectedIndexChanged += new System.EventHandler(this.Cbracas_SelectedIndexChanged);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 721);
            this.Controls.Add(this.gbcarachabilidades);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbataques);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbdesloc);
            this.Controls.Add(this.gbiniciativa);
            this.Controls.Add(this.gbidiomas);
            this.Controls.Add(this.gbpericias);
            this.Controls.Add(this.gbresistencias);
            this.Controls.Add(this.lblmodificador);
            this.Controls.Add(this.txtbonusprof);
            this.Controls.Add(this.lblinspiracao);
            this.Controls.Add(this.txtinspiracao);
            this.Controls.Add(this.pblogo);
            this.Controls.Add(this.gbhabilidades);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gball);
            this.Name = "FormPrincipal";
            this.Text = "D&D Ficha";
            this.gball.ResumeLayout(false);
            this.gball.PerformLayout();
            this.gbhabilidades.ResumeLayout(false);
            this.gbhabilidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pblogo)).EndInit();
            this.gbiniciativa.ResumeLayout(false);
            this.gbiniciativa.PerformLayout();
            this.gbdesloc.ResumeLayout(false);
            this.gbdesloc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtclassenivel;
        private System.Windows.Forms.TextBox txtantecedente;
        private System.Windows.Forms.TextBox txtnomejogador;
        private System.Windows.Forms.TextBox txttendencia;
        private System.Windows.Forms.TextBox txtexp;
        private System.Windows.Forms.GroupBox gball;
        private System.Windows.Forms.GroupBox gbhabilidades;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.Label lbls;
        private System.Windows.Forms.Label lbli;
        private System.Windows.Forms.Label lblca;
        private System.Windows.Forms.Label lblc;
        private System.Windows.Forms.Label lblf;
        private System.Windows.Forms.TextBox txtcarisma;
        private System.Windows.Forms.Label lblcarisma;
        private System.Windows.Forms.TextBox txtsabedoria;
        private System.Windows.Forms.Label lblsabedoria;
        private System.Windows.Forms.TextBox txtinteligencia;
        private System.Windows.Forms.Label lblinteligencia;
        private System.Windows.Forms.TextBox txtconstituicao;
        private System.Windows.Forms.Label lblconstituicao;
        private System.Windows.Forms.TextBox txtdestreza;
        private System.Windows.Forms.Label lbldestreza;
        private System.Windows.Forms.TextBox txtforca;
        private System.Windows.Forms.Label lblforca;
        private System.Windows.Forms.PictureBox pblogo;
        private System.Windows.Forms.TextBox txtinspiracao;
        private System.Windows.Forms.Label lblinspiracao;
        private System.Windows.Forms.Label lblmodificador;
        private System.Windows.Forms.TextBox txtbonusprof;
        private System.Windows.Forms.GroupBox gbresistencias;
        private System.Windows.Forms.GroupBox gbpericias;
        private System.Windows.Forms.GroupBox gbidiomas;
        private System.Windows.Forms.GroupBox gbiniciativa;
        private System.Windows.Forms.TextBox txtiniciativa;
        private System.Windows.Forms.GroupBox gbdesloc;
        private System.Windows.Forms.TextBox txtdeslocamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldadosvida;
        private System.Windows.Forms.Label lbltotalvida;
        private System.Windows.Forms.TextBox txtdadosvida;
        private System.Windows.Forms.TextBox txtpvtotais;
        private System.Windows.Forms.GroupBox gbataques;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbcarachabilidades;
        private System.Windows.Forms.ComboBox cbracas;
    }
}

