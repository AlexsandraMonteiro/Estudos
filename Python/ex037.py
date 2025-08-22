'''Exercício Python 37: Escreva um programa em Python que leia um número inteiro qualquer e peça para o usuário escolher qual será a base de conversão: 
1 para binário, 2 para octal e 3 para hexadecimal.
'''

numero = int(input('Digite umnúmero inteiro: '))
print('''Escolha uma das bases para conversão:
[1] para BINÁRIO
[2] para OCTAL
[3] para HEXADECIMAL''')
opção = int(input('Sua opção: '))
if opção == 1:
    print(f'{numero} convertido para BINÁRIO é igual a {bin(numero)[2:]}')
elif opção == 2:
    print(f'{numero} convertido para OCTAL é igual a {oct(numero)[2:]}')
elif opção == 3:
    print(f'{numero} convertido para HEXADECIMAL é igual a {hex(numero)[2:]}')
else:
    print('Opção inválida. TENTE NOVAMENTE!')