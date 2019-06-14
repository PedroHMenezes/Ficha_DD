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
        modificador= input("Qual o atributo? Se tiver terminado de listar os modificadores digite sair ")
        while modificador != "sair":
            valor = int(input("Qual o valor do atributo? "))
            atributos[modificador]=valor
            modificador= input("Qual o atributo? Se tiver terminado de listar os modificadores digite sair ")
        for k,i in atributos.items():
            i-=10
            i=int(i/2)
            if i>0:
                i="+" + str(i)
            modificadores[k]=str(i)
        print("MODIFICADORES")
        pprint(modificadores)
        antecedente=input("Qual seu antecedente? Digitar tudo com letras minusculas e sem acentos ")
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
        
        
        raca = input("Qual sua raça? ")
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
                
        classe = input ("Qual sua classe? ")
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