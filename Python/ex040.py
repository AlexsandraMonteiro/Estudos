'''*Exercício Python 040: Crie um programa que leia duas notas de um aluno e calcule sua média, mostrando uma mensagem no final, de acordo com a média atingida:*

*– Média abaixo de 5.0: REPROVADO*

*– Média entre 5.0 e 6.9: RECUPERAÇÃO*

*– Média 7.0 ou superior: APROVADO*
'''

n1 = float(input("Primeira nota: "))
n2 = float(input("Segunda nota: "))
média = (n1 + n2) / 2
print(f"A média é {média}")
if média < 5:
    print("O aluno está REPROVADO")
elif (média >= 5) and (média < 7):
    print("O aluno está de RECUPERAÇÃO")
elif média >= 7:
    print("O aluno está APROVADO")