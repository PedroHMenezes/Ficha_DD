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
    deslocamento = ''
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
                            booleano_modificadores=False
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
                    vida = 8 + int(modificadores['constituicao'])
                    equipamento["acólito"]=equipamento["acólito"].replace('\n',' ')
                elif antecedente == 'artesao de guilda':
                    print('oi')
                elif antecedente == 'artista':
                    print('oi')
                elif antecedente == 'charlatao':
                    print('oi')
                elif antecedente == 'criminoso':
                    print('oi')
                elif antecedente == 'eremita':
                    print('oi')
                elif antecedente == 'forasteiro':
                    print('oi')
                elif antecedente == 'heroi do povo':
                    print('oi')
                elif antecedente == 'marinheiro':
                    print('oi')
                elif antecedente == 'nobre':
                    print('oi')
                elif antecedente == 'orfao':
                    print('oi')
                elif antecedente == 'sabio':
                    print('oi')
                elif antecedente == 'soldado':
                    print('oi')
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
                    pericias_anao = input ("Escolha uma das perícias de ferramentas de anão: ferramentas de ferreiro, suprimentos de cervejeiro ou ferramentas de pedreiro ")
                    pericias.append(pericias_anao)
                    idiomas.append("Comum")
                    idiomas.append("Anão")
                    deslocamento+='7.5'
                    habilidades.append('Visão no escuro')
                    sub_racas=input("Escolha um subraca: Anão da Colina ou Anão da Montanha ")
                    if sub_racas == "anao da colina":
                        atributos["sabedoria"]+=1
                        vida+=1
                elif raca == 'elfo':
                    print('oi')
                elif raca == 'humano':
                    print('oi')
                elif raca == 'halfling':
                    print('oi')
                elif raca == 'draconato':
                    print('oi')
                elif raca == 'meio-orc':
                    print('oi')
                elif raca == 'meio-elfo':
                    print('oi')
                elif raca == 'tiefling':
                    print('oi')
                elif raca == 'gnomo':
                    print('oi')
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
                    print('oi')
                elif classe == 'bruxo':
                    print('oi')
                elif classe == 'clerigo':
                    print('oi')
                elif classe == 'druida':
                    print('oi')
                elif classe == 'feiticeiro':
                    print('oi')
                elif classe == 'guerreiro':
                    print('oi')
                elif classe == 'ladino':
                    print('oi')
                elif classe == 'mago':
                    print('oi')
                elif classe == 'monge':
                    print('oi')
                elif classe == 'paladino':
                    print('oi')
                elif classe == 'patrulheiro':
                    print('oi')
                booleano_classe = False
        for k,i in atributos.items():
            i-=10
            i=int(i/2)
            if i>0:
                i="+" + str(i)
            modificadores[k]=str(i)
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