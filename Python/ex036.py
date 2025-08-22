''' Escreva um programa para aprovar o empréstimo bancário para a compra de uma casa. 
    Pergunte o valor da casa, o salário do comprador e em quantos anos ele vai pagar.
    A prestação mensal não pode exceder 30% do salário ou então o empréstimo será negado.
'''
casa = float(input('Qual valor da casa? R$'))
salario = float(input('Seu salário: R$'))
anos = int(input('Quantos anos pretende pagar a casa? R$'))

prestação = casa / (anos * 12)
minimo = salario * 30 /100

print(f'Para pagar essa casa de R${casa :.2f} em {anos} anos', end='')
print(f' a prestação será de R${prestação :.2f}.')

if prestação <= minimo:
    print('Empréstimo APROVADO!')
else:
    print('Empréstimo NEGADO!')