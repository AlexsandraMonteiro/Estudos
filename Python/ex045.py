'''*Exercício Python 45: Crie um programa que faça o computador jogar Jokenpô com você.*'''

from random import randint
from time import sleep

itens = ("Pedra", "Papel", "Tesoura")
computador = randint(0, 2)
print('''Suas opções
[0] PEDRA
[1] PAPEL
[2] TESOURA''')
jogador = int(input("Qual é a sua jogada?"))
print("JO")
sleep(1)
print("KEN")
sleep(1)
print("PO!!!!")
print("-=-" * 10)
print(f"O computador escolheu {itens[computador]}")
print(f"O jogador escolheu {itens[jogador]}")
print("-=-" * 10)

if computador == 0:#computador jogou pedra
    if jogador == 0:#jogador jogou pedra
        print("Deu EMPATE")
    elif jogador == 1:#jogador jogou papel
        print("Jogador GANHOU")
    elif jogador == 2:#jogador jogou tesoura
        print("Computador GANHOU")
    else:
        print("Jogada INVÁLIDA")
elif computador == 1: #computador jogou papel
    if jogador == 0:#jogador jogou pedra
        print("Computador GANHOU")
    elif jogador == 1:#jogador jogou papel
        print("Deu EMPATE")
    elif jogador == 2:#jogador jogou tesoura
        print("Jogador GANHOU")
    else:
        print("Jogada INVÁLIDA")
elif computador == 2:#computador jogou tesoura
    if jogador == 0:#jogador jogou pedra
        print("Jogador GANHOU")
    elif jogador == 1:#jogador jogou papel
        print("Computador GANHOU")
    elif jogador == 2:#jogador jogou tesoura
        print("Deu EMPATE")
    else:
        print("Jogada INVÁLIDA")