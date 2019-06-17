# -*- coding: utf-8 -*-
"""
Created on Tue Jun 11 21:39:59 2019

@author: User
"""

from pprint import pprint

def ficha():
    ficha=True
    atributos={}
    modificador=''
    modificadores={}
    pericias = []
    idiomas=[]
    equipamento={}
    deslocamento = 0
    habilidades=[]
    proeficiencias=[]
    vida=0
    caracteristicas=[]
    resistencias=[]
    print("TUDO que você responder tem de ser minusculo e sem acentos(incluindo ç,ã)")
    while ficha:
        booleano_modificadores=True
        while booleano_modificadores:
            possiveis_modificadores=['sabedoria','carisma','inteligencia','forca','constituicao','destreza','sair']
            modificador= input("Qual o atributo? Se tiver terminado de listar os modificadores digite sair ")
            if modificador not in possiveis_modificadores:
                print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
            else:
                while modificador != "sair":
                    lista_modificadores1=True
                    valor = int(input("Qual o valor do atributo? "))
                    atributos[modificador]=valor
                    modificador= input("Qual o atributo? Se tiver terminado de listar os modificadores digite sair ")
                    while lista_modificadores1:
                        if modificador not in possiveis_modificadores:
                            print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                            modificador= input("Qual o atributo? Se tiver terminado de listar os modificadores digite sair ")
                        else:
                            lista_modificadores1=False
                booleano_modificadores=False
            for k,i in atributos.items():
                i-=10
                i=int(i/2)
                if i>0:
                    i="+" + str(i)
                modificadores[k]=str(i)
        print("MODIFICADORES")
        pprint(modificadores)
        antecedente=input("Qual seu antecedente? Digitar tudo com letras minusculas e sem acentos ")
        possiveis_antecedentes=['acolito','artesao de guilda','artista','charlatao','criminoso','eremita',
                                'forasteiro','heroi do povo','marinheiro','nobre','orfao','sabio','soldado']
        booleano_antecedentes=True
        while booleano_antecedentes:
            if antecedente not in possiveis_antecedentes:
                print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                antecedente=input("Qual seu antecedente? Digitar tudo com letras minusculas e sem acentos ")
            else:
                if antecedente == "acolito":
                    pericias.append("Intuição")
                    pericias.append("Religião")
                    idiomas.append("Dois a sua escolha(acólito)")
                    equipamento["acólito"]= """Um símbolo sagrado (um presente dado
                                            quando você entrou no templo), um livro de preces ou
                                            uma conta de orações, 5 varetas de incenso,
                                            vestimentas, um conjunto de roupas comuns e uma
                                            algibeira contendo 15 po
                                            """
                    equipamento["acólito"]=equipamento["acólito"].replace('\n',' ')
                elif antecedente == 'artesao de guilda':
                    pericias.append('Intuição')
                    pericias.append('Persuasão')
                    pericia = input('Escolha um tipo de ferramenta de artesão')
                    proeficiencias.append(pericia)
                    idiomas.append('Um idioma à sua escolha')
                    equipamento['artesao de guilda'] = '''Um conjunto de ferramentas de artesão
                                                        (à sua escolha), uma carta de apresentação da sua
                                                        guilda, um conjunto de roupas de viajante e uma
                                                        algibeira com 15 po
                                                        '''
                    equipamento['artesao de guilda']=equipamento['artesao de guilda'].replace('\n',' ')
                elif antecedente == 'artista':
                    pericias.append('Acrobacia')
                    pericias.append('Atuação')
                    proeficiencias.append('Kit de disfarce')
                    proeficiencias.append('Um tipo de instrumento musical à sua escolha')
                    equipamento['artista']='''Um instrumento musical (à sua escolha),
                                            um presente de um admirador (carta de amor, mecha
                                            de cabelo ou uma bijuteria), um traje e uma algibeira
                                            contendo 15 po
                                            '''
                    equipamento['artista']=equipamento['artista'].replace('\n',' ')                    
                elif antecedente == 'charlatao':
                    pericias.append('Enganação')
                    pericias.append('Prestidigitação')
                    proeficiencias.append('Kit de disfarce')
                    proeficiencias.append('Kit de falsificação')
                    equipamento['charlatao']='''Um conjunto de roupas finas, um kit de
                                            disfarce, ferramentas de trapaça, à sua escolha (dez
                                            garrafas tampadas preenchidas com líquidos coloridos,
                                            um conjunto de dados viciados, um baralho de cartas
                                            marcadas ou um anel de sinete de um duque
                                            imaginário), e uma algibeira contendo 15po
                                            '''
                    equipamento['charlatao']=equipamento['charlatao'].replace('\n',' ')                        
                elif antecedente == 'criminoso':
                    pericias.append('Enganação')
                    pericias.append('Furtividade')
                    proeficiencias.append('Um kit de jogo à sua escolha')
                    proeficiencias.append('Ferramentas de ladrão')
                    equipamento['criminoso']='''Um pé de cabra, um conjunto de roupas
                                            escuras comuns com capuz e uma algibeira contendo
                                            15 po
                                            '''
                    equipamento['criminoso']=equipamento['criminoso'].replace('\n',' ')                        
                elif antecedente == 'eremita':
                    pericias.append('Medicina')
                    pericias.append('Religião')
                    idiomas.append('Um idioma à sua escolha')
                    equipamento['eremita']='''Um estojo de pergaminho cheio de notas
                                            dos seus estudos e orações, um cobertor de inverno,
                                            um conjunto de roupas comuns, um kit de herbalismo
                                            e 5 po.
                                            '''
                    equipamento['eremita']=equipamento['eremita'].replace('\n',' ')
                elif antecedente == 'forasteiro':
                    pericias.append('Atletismo')
                    pericias.append('Sobrevivência')
                    proeficiencias.append('Um instrumento musical à sua escolha')
                    idiomas.append('Um idioma à sua escolha')
                    equipamento['forasteiro']='''Um bordão, uma armadilha de caça, um
                                            fetiche de um animal que você matou, um conjunto de
                                            roupas de viajante e uma algibeira contendo 10 po
                                            '''
                    equipamento['forasteiro']=equipamento['forasteiro'].replace('\n',' ')
                elif antecedente == 'heroi do povo':
                    pericias.append('Adestrar animais')
                    pericias.append('Sobrevivência')
                    proeficiencias.append('Um tipo de ferramenta de artesão à sua escolha')
                    proeficiencias.append('Veículos(terrestre)')
                    equipamento['heroi do povo']='''Um conjunto de ferramentas de artesão
                                                (à sua escolha), uma pá, um pote de ferro, um conjunto
                                                de roupas comuns e uma algibeira contendo 10 po
                                                '''
                    equipamento['heroi do povo']=equipamento['heroi do povo'].replace('\n',' ')
                elif antecedente == 'marinheiro':
                    pericias.append('Atletismo')
                    pericias.append('Percepção')
                    proeficiencias.append('Uma ferramenta de marinheiro à sua escolha')
                    proeficiencias.append('Veículo(aquático)')
                    equipamento['marinheiro']='''Uma malagueta (clava), 15 metros de
                                                corda de seda, uma amuleto da sorte como um pé de
                                                coelho ou uma pequena pedra com um furo no centro
                                                (ou você pode rolar uma bugiganga da tabela
                                                Bugigangas no capítulo 5), um conjunto de trajes
                                                comuns e uma algibeira contendo 10 po
                                                '''
                    equipamento['marinheiro']=equipamento['marinheiro'].replace('\n',' ')
                elif antecedente == 'nobre':
                    pericias.append('História')
                    pericias.append('Persuasão')
                    proeficiencias.append('Um kit de jogos à sua escolha')
                    idiomas.append('Um idioma à sua escolha')
                    equipamento['nobre']='''Um conjunto de trajes finos, um anel de
                                            sinete, um pergaminho de linhagem e uma algibeira
                                            contendo 25 po
                                            '''
                    equipamento['nobre']=equipamento['nobre'].replace('\n',' ')
                elif antecedente == 'orfao':
                    pericias.append('Furtividade')
                    pericias.append('Prestidigitação')
                    proeficiencias.append('Kit de disfarce')
                    proeficiencias.append('Ferramentas de ladrão')
                    equipamento['orfao']='''Uma faca pequena, um mapa da cidade
                                            em que você cresceu, um rato de estimação, um
                                            pequeno objeto para lembrar dos seus pais, um
                                            conjunto de roupas comuns e uma algibeira contendo
                                            10 po
                                            '''
                    equipamento['orfao']=equipamento['orfao'].replace('\n',' ')
                elif antecedente == 'sabio':
                    pericias.append('Arcanismo')
                    pericias.append('História')
                    idiomas.append('Dois idiomas à sua escolha')
                    equipamento['sabio']='''Um vidro de tinta escura, uma pena, uma
                                            faca pequena, uma carta de um falecido colega
                                            perguntando a você algo que você nunca terá a chance
                                            de responder, um conjunto de roupas comuns e uma
                                            algibeira contendo 10 po
                                            '''
                    equipamento['sabio']=equipamento['sabio'].replace('\n',' ')
                elif antecedente == 'soldado':
                    pericias.append('Atletismo')
                    pericias.append('Intimidação')
                    proeficiencias.append('Um tipo de kit de jogo à sua escolha')
                    proeficiencias.append('Veículo(terrestre)')
                    equipamento['soldado']='''Uma insígnia de patente, um fetiche
                                            obtido de um inimigo caído (uma adaga, lâmina
                                            partida ou tira de estandarte), um conjunto de dados
                                            de osso ou baralho, um conjunto de roupas comuns e
                                            uma algibeira contendo 10 po
                                            '''
                    equipamento['soldado']=equipamento['soldado'].replace('\n',' ')
                booleano_antecedentes=False
        raca = input("Qual sua raça? (Coloque traço '-' entre raças como meio-elfo, meio-orc etc.)")
        possiveis_raca = ['anao','elfo','humano','halfling','draconato','meio-orc','meio-elfo','tiefling','gnomo']
        booleano_raca=True
        while booleano_raca:
            if raca not in possiveis_raca:
                print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                raca = input("Qual sua raça? (Coloque traço '-' entre raças como meio-elfo, meio-orc etc.)")
            else:
                if raca == "anao":
                    atributos['constituicao']+=2
                    pericias_anao = input ("Escolha uma das perícias de ferramentas de anão: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro ")
                    pericias.append(pericias_anao)
                    idiomas.append("Comum")
                    idiomas.append("Anão")
                    deslocamento=7.5
                    habilidades.append('Visão no escuro')
                    booleano_subraca=True
                    sub_racas=['anao da colina','anao da montanha']
                    while booleano_subraca:
                        sub_raca=input("Escolha um sub-raça: Anão da Colina ou Anão da Montanha ")
                        if sub_raca not in sub_racas:
                            print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                            sub_raca=input("Escolha um subraca: Anão da Colina ou Anão da Montanha ")
                        else:
                            if sub_raca == "anao da colina":
                                atributos["sabedoria"]+=1
                                vida+=1
                            elif sub_raca=='anao da montanha':
                                atributos['forca']+=2
                                proeficiencias.append('Armaduras leves')
                                proeficiencias.append('Armaduras médias')
                            booleano_subraca=False
                elif raca == 'elfo':
                    atributos['destreza']+=2
                    deslocamento=9
                    habilidades.append('Visão no escuro')
                    pericias.append('Percepção')
                    habilidades.append('Ancestral Feérico')
                    habilidades.append('Transe')
                    idiomas.append('Comum')
                    idiomas.append('Élfico')
                    booleano_subraca=True
                    sub_racas=['alto elfo','elfo da floresta','elfo negro']
                    while booleano_subraca:
                        sub_raca=input('Escolha uma sub-raça: Alto elfo, Elfo da floresta, Elfo negro')
                        if sub_raca not in sub_racas:
                            print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                            sub_raca=input('Escolha uma sub-raça: Alto elfo, Elfo da floresta, Elfo negro')
                        else:
                            if sub_raca=='alto elfo':
                                atributos['inteligencia']+=1
                                proeficiencias.append('Espadas longas')
                                proeficiencias.append('Espadas curtas')
                                proeficiencias.append('Arcos longos')
                                proeficiencias.append('Arcos curtos')
                                habilidades.append('Você conhece um truque a mais - Inteligência é a habilidade usada para conjuração')
                                idiomas.append('Um idioma adicional à sua escolha')
                            elif sub_raca == 'elfo de floresta':
                                atributos['sabedoria']+=1
                                proeficiencias.append('Espadas longas')
                                proeficiencias.append('Espadas curtas')
                                proeficiencias.append('Arcos longos')
                                proeficiencias.append('Arcos curtos')
                                deslocamento=10.5
                                habilidades.append('Máscara da Natureza')
                            elif sub_raca == 'elfo negro':
                                atributos['carisma']+=1
                                habilidades.append('Visão no escuro superior')
                                habilidades.append('Sensibilidade à Luz Solar')
                                habilidades.append('Magia Drow')
                                proeficiencias.append('Rapieiras')
                                proeficiencias.append('Espadas curtas')
                                proeficiencias.append('Bestas de mão')
                            booleano_subraca=False
                elif raca == 'humano':
                    atributos['forca']+=1
                    atributos['constituicao']+=1
                    atributos['destreza']+=1
                    atributos['sabedoria']+=1
                    atributos['inteligencia']+=1
                    atributos['carisma']+=1
                    deslocamento=9
                    idiomas.append('Comum')
                    idiomas.append('Um idioma à sua escolha')
                    
                elif raca == 'halfling':
                    atributos['carisma']+=2
                    habilidades.append('Sortudo')
                    habilidades.append('Bravura')
                    habilidades.append('Agilidade Halfling')
                    deslocamento=7.5
                    idiomas.append('Comum')
                    idiomas.append('Halfling')
                    booleano_subraca=True
                    sub_racas=['pes leves','robusto']
                    while booleano_subraca:
                        sub_raca=input('Escolha uma sub-raça: Pés leves, Robusto')
                        if sub_raca not in sub_racas:
                            print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                            sub_raca=input('Escolha uma sub-raça: Pés leves, Robusto')
                        else:
                            if sub_raca == 'pes leves':
                                atributos['carisma']+=1
                                habilidades.append('Furtividade Natural')
                            elif sub_raca == 'robusto':
                                atributos['constituicao']+=1
                                habilidades.append('Resiliência dos robustos')
                            booleano_subraca=False
                elif raca == 'draconato':
                    atributos['forca']+=2
                    atributos['carisma']+=1
                    deslocamento=9
                    dragao= input('Você deve escolher um ancestral possível. Eles são azul, branco, bronze, cobre, latão, negro, ouro, prata, verde, vermelho')
                    habilidades.append('Resistência a Dano - envolvido ao seu ancestral')
                    idiomas.append('Comum')
                    idiomas.append('Dracônico')
                    
                elif raca == 'meio-orc':
                    atributos['forca']+=2
                    atributos['constituicao']+=1
                    deslocamento=9
                    habilidades.append('Visão no escuro')
                    pericias.append('Intimidação')
                    habilidades.append('Resistência Implacável')
                    habilidades.append('Ataques Selvagens')
                    idiomas.append('Comum')
                    idiomas.append('Orc')
                elif raca == 'meio-elfo':
                    atributos['carisma']+=2
                    print('Você pode escolher duas habilidades para acrescentar +1 no valor total')
                    atributo=input('Qual a primeira?')
                    atributos[atributo]+=1
                    atributo=input('Qual a segunda?')
                    atributos[atributo]+=1
                    deslocamento=9
                    habilidades.append('Visão no escuro')
                    habilidades.append('Ancestral Feérico')
                    habilidades.append('Versatilidade em Perícia')
                    idiomas.append('Comum')
                    idiomas.append('Élfico')
                    idiomas.append('Você pode escolher um idioma à sua escolha')
                elif raca == 'tiefling':
                    atributos['inteligencia']+=1
                    atributos['carisma']+=2
                    deslocamento=9
                    habilidades.append('Visão no escuro')
                    habilidades.append('Resistência Infernal')
                    habilidades.append('Legado Infernal')
                    idiomas.append('Comum')
                    idiomas.append('Infernal')
                elif raca == 'gnomo':
                    atributos['inteligencia']+=2
                    deslocamento=7.5
                    habilidades.append('Visão de Escuro')
                    habilidades.append('Esperteza Gnômica')
                    resistencias.append('Inteligência')
                    resistencias.append('Sabedoria')
                    resistencias.append('Carisma')
                    idiomas.append('Comum')
                    idiomas.append('Gnômico')
                    booleano_subraca=True
                    sub_racas=['gnomos da floresta','gnomos das rochas']
                    while booleano_subraca:
                        sub_raca=input('Escolha uma sub-raça: Gnomos da floresta, Gnomos das rochas')
                        if sub_raca not in sub_racas:
                            print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                            sub_raca=input('Escolha uma sub-raça: Gnomos da floresta, Gnomos das rochas')
                        else:
                            if sub_raca=='gnomos da floresta':
                                atributos['destreza']+=1
                                habilidades.append('Ilusionista Nato')
                                habilidades.append('Falar com bestas pequenas')
                            elif sub_raca == 'gnomos das rochas':
                                atributos['constituicao']+=1
                                habilidades.append('Conhecimento de Artífice')
                                proeficiencias.append('Ferramentas de artesão')
                                habilidades.append('Engenhoqueiro')
                            booleano_subraca=False
                booleano_raca=False
        possiveis_classes = ['barbaro','bardo','bruxo','clerigo','druida','feiticeiro','guerreiro','ladino',
                             'mago','monge','paladino','patrulheiro']
        classe = input ("Qual sua classe? ")
        booleano_classe = True
        while booleano_classe:
            if classe not in possiveis_classes:
                print("Acho que você digitou alguma coisa errada(ou com acento)... Tente de novo")
                classe = input ("Qual sua classe? ")
            else:
                if classe == 'barbaro':
                    caracteristicas.append('Fúria')
                    caracteristicas.append('Defesa sem armadura')
                    vida = 12 + int(modificadores['constituicao'])
                    proeficiencias.append("Armaduras leves")
                    proeficiencias.append("Armaduras médias")
                    proeficiencias.append("Escudos")
                    proeficiencias.append("Armas simples")
                    proeficiencias.append("Armas marciais")
                    resistencias.append("Força")
                    resistencias.append("Constituição")
                    pericia1 = input ("Escolha uma entre: Adestrar Animais, Atletismo, Intimidação, Natureza, Percepção e Sobrevivência")
                    pericia2 = input ("Escolha outra da lista acima")
                    pericias.append(pericia1)
                    pericias.append(pericia2)
                    equipamentos = input ("Escolha um machado grande ou qualquer arma marcial corpo-a-corpo")
                    equipamento['Bárbaro']=equipamentos
                    equipamentos = input ("Dois machados de mão ou qualquer arma simples")
                    equipamento['Bárbaro']=equipamento['Bárbaro']+', '+equipamentos
                    equipamentos = "Pacote de aventureiros e quatro azagaias"
                    equipamento['Bárbaro']=equipamento['Bárbaro']+', '+equipamentos
                elif classe == 'bardo':
                    resistencias.append('Destreza')
                    resistencias.append('Carisma')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Bestas de mão')
                    proeficiencias.append('Espadas longas')
                    proeficiencias.append('Rapieiras')
                    proeficiencias.append('Espadas curtas')
                    vida = 8 + int(modificadores['constituicao'])
                    equipamento['bardo']='Três instrumentos musicais à sua escolha'
                    print('Você tem direito a três perícias')
                    pericia=input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia=input('Qual a segunda?')
                    pericias.append(pericia)
                    pericia=input('Qual a terceira?')
                    pericias.append(pericia)
                    equipamentos = input ("Escolha uma rapieira, uma espada longa ou qualquer arma simples")
                    equipamento['bardo']=equipamento['bardo']+', '+equipamentos
                    equipamentos = input ('Escolha um pacote de diplomata ou um pacote de artista')
                    equipamento['bardo']=equipamento['bardo']+', '+equipamentos
                    equipamentos = input ('Escolha um lute ou qualquer outro instrumento musical')
                    equipamento['bardo']=equipamento['bardo']+', '+equipamentos
                    equipamentos = 'Armadura de couro e uma adaga'
                    equipamento['bardo']=equipamento['bardo']+', '+equipamentos
                    habilidades.append('Dois truques de bardo')
                    habilidades.append('Quatro magias de nível 1 de bardo')
                    habilidades.append('Inspiração de bardo')                    
                elif classe == 'bruxo':
                    resistencias.append('Sabedoria')
                    resistencias.append('Carisma')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Armas simples')
                    vida = 8 + int(modificadores['constituicao'])
                    print('Você pode escolher duas das seguintes perícias: Arcanismo, Enganação, História, Intimidação, Investigação, Natureza e Religião')
                    pericia = input('Qual a primeira perícia?')
                    pericias.append(pericia)
                    pericia = input('Qual a segunda perícia?')
                    pericias.append(pericia)
                    equipamentos=input('Escolha uma besta leve e 20 virotes ou qualquer arma simples')
                    equipamento['bruxo']=equipamentos
                    equipamentos = input ('Escolha uma bolsa de componentes ou um foco arcano')
                    equipamento['bruxo']=equipamento['bruxo']+', '+equipamentos
                    equipamentos = input('Escolha um pacote de estudioso ou um pacote de explorador')
                    equipamento['bruxo']=equipamento['bruxo']+', '+equipamentos
                    equipamento['bruxo']=equipamento['bruxo']+', '+'Armaduras de couro, qualquer arma simples e duas adagas'
                    habilidades.append('Você deve escolher um ser transcedental para fazer barganha. Eles podem ser a Arquifada, o Corruptor ou o Grande Antigo')
                    habilidades.append('Dois truques de bruxo')
                    habilidades.append('Duas magias de bruxo')
                elif classe == 'clerigo':
                    resistencias.append('Sabedoria')
                    resistencias.append('Carisma')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Armaduras médias')
                    proeficiencias.append('Escudos')
                    proeficiencias.append('Armas simples')
                    vida = 8 + int(modificadores['constituicao'])
                    print('Escolha duas entre História, Intuição, Medicina, Persuasão e Religião')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma maça ou um martelo de guerra(caso tenha proeficiência)')
                    equipamento['clerigo'] = equipamentos
                    equipamentos = input ('Escolha entre uma brunea, armadura de couro ou uma cota de malha (caso tenha proeficiência)')
                    equipamento['clerigo']=equipamento['clerigo']+', '+equipamento
                    equipamentos= input('Escolha entre uma besta leve e 20 virotes ou qualquer arma simples')
                    equipamento['clerigo']=equipamento['clerigo']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de sacerdote ou um pacote de aventureiro')
                    equipamento['clerigo']=equipamento['clerigo']+', '+equipamentos
                    equipamentos = 'Um escudo e um símbolo sagrado'
                    equipamento['clerigo']=equipamento['clerigo']+', '+equipamentos
                    habilidades.append('Três truques de clérigo')
                    habilidades.append('Você deve escolher um domínio relacionado à sua divindade. Os possíveis são: Conhecimento, Enganação, Guerra, Luz, Natureza, Tempestade ou Vida')
                elif classe == 'druida':
                    resistencias.append('Inteligência')
                    resistencias.append('Sabedoria')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Armaduras médias')
                    proeficiencias.append('Escudos')
                    proeficiencias.append('Clavas')
                    proeficiencias.append('Adagas')
                    proeficiencias.append('Dardos')
                    proeficiencias.append('Azagaias')
                    proeficiencias.append('Maças')
                    proeficiencias.append('Bordões')
                    proeficiencias.append('Cimitarras')
                    proeficiencias.append('Foices')
                    proeficiencias.append('Fundas')
                    proeficiencias.append('Lanças')
                    habilidades.append('Você pode escolher dois truques de druída')
                    habilidades.append('Você tem dois espaços de magia level 1.')
                    proeficiencias.append('Kit de Herbalismo')
                    equipamentos = input ('Escolha entre um escudo de madeira ou qualquer arma simples')
                    equipamento['druida'] = equipamentos
                    equipamentos = input ('Escolha entre uma cimitarra ou qualquer arma corpo-a-corpo simples')
                    equipamento['druida']=equipamento['druida']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de estudioso ou um pacote de explorador')
                    equipamento['druida']=equipamento['druida']+', '+equipamentos
                    equipamentos = 'Armadura de couro, um pacote de aventureiro e um foco druídico'
                    equipamento['druida']=equipamento['druida']+', '+equipamentos
                    print('Escolha duas entre Arcanismo, Adestrar Animais, Intuição, Medicina, Natureza, Percepção, Religião e Sobrevivência')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    idiomas.append('Druídico')
                elif classe == 'feiticeiro':
                    resistencias.append('Constituição')
                    resistencias.append('Carisma')
                    proeficiencias.append('Adagas')
                    proeficiencias.append('Dardos')
                    proeficiencias.append('Fundas')
                    proeficiencias.append('Bordões')
                    proeficiencias.append('Bestas leves')
                    habilidades.append('Você pode escolher quatro truques de feiticeiro')
                    habilidades.append('Você tem duas magias conhecidas level 1.')
                    vida = 6 + int(modificadores['constituicao'])
                    print('Escolha duas dessas perícias: Arcanismo, Enganação, Intuição, Intimidação, Persuasão e Religião')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma besta leve e 20 virotes ou qualquer arma simples')
                    equipamento['feiticeiro'] = equipamentos
                    equipamentos = input ('Escolha entre uma bolsa de explorador ou foco arcano')
                    equipamento['feiticeiro']=equipamento['feiticeiro']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de explorador ou pacote de aventureiro')
                    equipamento['feiticeiro']=equipamento['feiticeiro']+', '+equipamentos
                    print('Você deve escolher a origem do poder do seu feiticeiro')
                elif classe == 'guerreiro':
                    resistencias.append('Força')
                    resistencias.append('Constituição')
                    proeficiencias.append('Todas as armaduras')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Armas marciais')
                    vida = 10 + int(modificadores['constituicao'])
                    print('Escolha duas dessas perícias: Acrobacia, Adestrar Animais, Atletismo, História, Intuição, Intimidação, Percepção e Sobrevivência')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma cota de malha ou um gibão de peles,arco longo e 20 flechas')
                    equipamento['guerreiro'] = equipamentos
                    equipamentos = input ('Escolha entre uma arma marcial e um escudo ou duas armas marciais')
                    equipamento['guerreiro']=equipamento['guerreiro']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de explorador ou pacote de aventureiro')
                    equipamento['guerreiro']=equipamento['guerreiro']+', '+equipamentos
                    equipamentos = input('Escolha entre uma besta leve e 20 virotes ou dois machados de arremesso')
                    equipamento['guerreiro']=equipamento['guerreiro']+', '+equipamentos
                    print('Você deve escolher seu estilo de luta')
                    habilidades.append('Retomar o fôlego')
                elif classe == 'ladino':
                    resistencias.append('Destreza')
                    resistencias.append('Inteligência')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Bestas de mão')
                    proeficiencias.append('Espadas longas')
                    proeficiencias.append('Rapieiras')
                    proeficiencias.append('Espadas curtas')
                    vida = 8 + int(modificadores['constituicao'])
                    print('Escolha quatro dessas perícias: Acrobacia, Atletismo, Atuação, Enganação, Furtividade, Intimidação, Intuição, Investigação, Percepção, Persuasão e Pretisdigitação')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    pericia = input ('Qual a terceira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a quarta?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma rapieira ou uma espada longa')
                    equipamento['ladino'] = equipamentos
                    equipamentos = input ('Escolha entre um arco curto e um aljava com 20 flechas ou uma espada curta')
                    equipamento['ladino']=equipamento['ladino']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de assaltante ou um pacote de aventureiro ou um pacote de explorador')
                    equipamento['ladino']=equipamento['ladino']+', '+equipamentos
                    equipamentos = 'Armadura de couro, duas adagas e ferramentas de ladrão'
                    equipamento['ladino']=equipamento['ladino']+', '+equipamentos
                    habilidades.append('Especialização')
                    habilidades.append('Ataque Furtivo')
                    habilidades.append('Gírias de ladrão')
                elif classe == 'mago':
                    resistencias.append('Inteligência')
                    resistencias.append('Sabedoria')
                    proeficiencias.append('Adagas')
                    proeficiencias.append('Dardos')
                    proeficiencias.append('Fundas')
                    proeficiencias.append('Bastões')
                    proeficiencias.append('Bestas leves')
                    vida =6 + int(modificadores['constituicao'])
                    print('Escolha quatro dessas perícias: Arcanismo, História, Intuição, Investigação, Medicina e Religião')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre um bordão ou uma adaga')
                    equipamento['mago'] = equipamentos
                    equipamentos = input ('Escolha entre uma bolsa de componentes ou um foco arcano')
                    equipamento['mago']=equipamento['mago']+', '+equipamentos
                    equipamentos= input ('Escolha entre um pacote de estudioso ou um pacote de explorador')
                    equipamento['mago']=equipamento['mago']+', '+equipamentos
                    equipamentos = 'Grimório'
                    equipamento['mago']=equipamento['mago']+', '+equipamentos
                    habilidades.append('Três truques de mago')
                    habilidades.append('Grimório contendo seis magias')
                elif classe == 'monge':
                    resistencias.append('Força')
                    resistencias.append('Destreza')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Espadas curtas')
                    vida = 8 + int(modificadores['constituicao'])
                    print('Escolha duas dessas perícias: Acrobacia, Atletismo, Furtividade, História, Intuição e Religião')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma espada curta ou qualquer arma simples')
                    equipamento['monge'] = equipamentos
                    equipamentos= input ('Escolha entre um pacote de aventureiro ou um pacote de explorador')
                    equipamento['monge']=equipamento['monge']+', '+equipamentos
                    equipamentos = '10 dardos'
                    equipamento['monge']=equipamento['monge']+', '+equipamentos
                    habilidades.append('Defesa sem armadura')
                    habilidades.append('Artes marciais')
                elif classe == 'paladino':
                    resistencias.append('Sabedoria')
                    resistencias.append('Carisma')
                    proeficiencias.append('Todas as armaduras')
                    proeficiencias.append('Escudos')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Armas marciais')
                    vida = 10 + int(modificadores['constituicao'])
                    print('Escolha duas dessas perícias: Atletismo, Intuição, Intimidação, Medicina, Persuasão e Religião')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre uma arma marcial e um escudo ou duas armas marciais')
                    equipamento['paladino'] = equipamentos
                    equipamentos= input ('Escolha entre cinco azagaias ou qualquer arma simples corpo-a-corpo')
                    equipamento['paladino']=equipamento['paladino']+', '+equipamentos
                    equipamentos=input('Escolha entre um pacote de sacerdote ou um pacote de aventureiro')
                    equipamento['paladino']=equipamento['paladino']+', '+equipamentos
                    equipamentos = 'Cota de malha e um símbolo sagrado'
                    equipamento['paladino']=equipamento['paladino']+', '+equipamentos
                    habilidades.append('Sentido divino')
                    habilidades.append('Cura pelas mãos')
                elif classe == 'patrulheiro':
                    resistencias.append('Força')
                    resistencias.append('Destreza')
                    proeficiencias.append('Armaduras leves')
                    proeficiencias.append('Escudos')
                    proeficiencias.append('Armas simples')
                    proeficiencias.append('Armas marciais')
                    vida=10+int(modificadores['constituicao'])
                    print('Escolha três dessas perícias: Acrobacia, Adestrar Animais, Atletismo, Furtividade, Intuição, Investigação, Natureza, Percepção, Sobrevivência')
                    pericia = input('Qual a primeira?')
                    pericias.append(pericia)
                    pericia = input ('Qual a segunda?')
                    pericias.append(pericia)
                    pericia = input ('Qual a terceira?')
                    pericias.append(pericia)
                    equipamentos = input ('Escolha entre um camisão de malha ou armadura de couro')
                    equipamento['patrulheiro'] = equipamentos
                    equipamentos= input ('Escolha entre duas espadas curtas ou duas armas simples corpo-a-corpo')
                    equipamento['patrulheiro']=equipamento['patrulheiro']+', '+equipamentos
                    equipamentos=input('Escolha entre um pacote de explorador ou um pacote de aventureiro')
                    equipamento['patrulheiro']=equipamento['patrulheiro']+', '+equipamentos
                    equipamentos = 'Um arco longo e uma aljava com 20 flechas'
                    equipamento['patrulheiro']=equipamento['patrulheiro']+', '+equipamentos
                    habilidades.append('Inimigo favorito')
                    habilidades.append('Explorador natural')
                booleano_classe = False
        for k,i in atributos.items():
            i-=10
            i=int(i/2)
            if i>0:
                i="+" + str(i)
            modificadores[k]=str(i)
        if raca == 'draconato':
            print(dragao)
        print("Perícias:")
        print (pericias)
        print("Idiomas:")
        print(idiomas)
        print("Equipamentos:")
        print(equipamento)
        print("Vida:")
        print(vida)
        print("Atributos:")
        pprint(atributos)
        print("Deslocamento:")
        print(deslocamento)
        print("Proeficiências:")
        print(proeficiencias)
        print("Testes de resistências:")
        print(resistencias)
        print("Proeficiência: +2")
        ficha=False 
        
ficha()